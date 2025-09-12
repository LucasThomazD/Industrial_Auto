import pandas as pd
import gc, sqlite3, os, glob, asyncio
from openpyxl import load_workbook
from openpyxl.drawing.image import Image
from openpyxl.styles import PatternFill, Font, Border, Side, Alignment


pln1 = r"C:\Users\lucasduarte\Downloads\arquivos\R20 Tub-Sup-Sist_seg.xlsx"
pln2 = r"C:\Users\lucasduarte\Downloads\arquivos\R20_GERAL_ELÉTRICA E INSTRUMENTAÇÃO - 28.08.2025.xlsx"

imagem_Odebrecht = r"../assets/img/Imagem1.png" 
imagem_Marinha = r"../assets/img/Imagem2.png" 
pasta_planilhas = r"export_areas"

path_tabelas = r"C:\Users\lucasduarte\Documents\tabelas"

# Nome do banco de dados
db_path = "planilhas.db"

especificas = ["2502", "2511", "2706", "2721", "2722", "2737", "2744", "7816", "7818"]

tabela = "tabela_unica02"

async def export_planilhas(plan1, plan2, database):

    

    # Colunas que você realmente precisa
    colunas = [0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,49,50]

    # 1️⃣ Lê a primeira planilha (todas as linhas, só as colunas necessárias)
    df1 = pd.read_excel(plan1, usecols=colunas)

    # 2️⃣ Lê a segunda planilha (pulando a primeira linha, só as colunas necessárias)
    df2 = pd.read_excel(plan2, skiprows=1, usecols=colunas)

    # 🔹 Padroniza os nomes para garantir igualdade

    df1.columns = df1.columns.str.strip().str.upper()
    df2.columns = df2.columns.str.strip().str.upper()

    # 🔹 Força df2 a ter exatamente os mesmos nomes e ordem de df1
    df2.columns = df1.columns

    # 3️⃣ Une as duas
    df_final = pd.concat([df1, df2], ignore_index=True)

    # 4️⃣ Salva no banco SQLite
    conn = sqlite3.connect(database)
    df_final.to_sql("tabela_unica02", conn, if_exists="replace", index=False)
    conn.close()
    gc.collect()

async def ModDB(database,table):
    # Caminho do banco SQLite
    caminho_banco = database
    tabela = table

    # Conecta ao banco
    conn = sqlite3.connect(caminho_banco)
    cursor = conn.cursor()

    # Descobre os nomes das colunas na ordem física
    cursor.execute(f"PRAGMA table_info({tabela})")
    colunas_info = cursor.fetchall()

    # colunas_info retorna: [(cid, name, type, notnull, dflt_value, pk), ...]
    coluna_31 = colunas_info[31][1]  # índice 33 → nome da coluna
    coluna_32 = colunas_info[32][1]  # índice 34 → nome da coluna


    coluna_31_sql = f'"{coluna_31}"'
    coluna_32_sql = f'"{coluna_32}"'


    # 1️⃣ Deleta linhas onde coluna_33 é NULL
    cursor.execute(f"""
    DELETE FROM {tabela}
    WHERE {coluna_31_sql} IS NULL
       OR {coluna_31_sql} = ?
       OR {coluna_31_sql} = ?
    """,
    ("SAIU DO ORÇAMENTO", "#")
)
    cursor.execute(f"""
    UPDATE {tabela}
    SET {coluna_31_sql} = LTRIM({coluna_31_sql}, '#')
    WHERE {coluna_31_sql} LIKE '#%';
""")


    # 2️⃣ Deleta linhas onde coluna_34 NÃO é NULL
    cursor.execute(f"DELETE FROM {tabela} WHERE {coluna_32_sql} IS NOT NULL")


    # Salva as alterações
    conn.commit()

    # Fecha a conexão
    conn.close()

    print("Linhas deletadas com sucesso!")

async def trocando_Valores(database, areas, tabela):
    # Conecta ao banco
    conn = sqlite3.connect(database)
    cursor = conn.cursor()

    # Descobre nomes das colunas
    cursor.execute(f"PRAGMA table_info({tabela})")
    colunas_info = cursor.fetchall()

    coluna_3 = colunas_info[2][1]   # terceira coluna (índice 2)
    coluna_31 = colunas_info[31][1] # coluna 33 (índice 33)

    # Escapa nomes de colunas
    coluna_3_sql = f'"{coluna_3}"'
    coluna_31_sql = f'"{coluna_31}"'

    # Monta placeholders para o IN
    placeholders = ",".join("?" for _ in areas)

    # Query:
    # - SUBSTR(coluna_33, 1, 8) → mantém do início até antes da posição 9
    # - SUBSTR(coluna_3, 1, 4) → pega os 4 primeiros caracteres da coluna 3
    # - SUBSTR(coluna_33, 13) → mantém do caractere 13 até o fim
    sql = f"""
    UPDATE {tabela}
    SET {coluna_31_sql} = SUBSTR({coluna_31_sql}, 1, 8) 
                        || SUBSTR({coluna_3_sql}, 1, 4) 
                        || SUBSTR({coluna_31_sql}, 13)
    WHERE SUBSTR({coluna_3_sql}, 1, 4) IN ({placeholders})
    """

    # Executa
    cursor.execute(sql, areas)

    conn.commit()
    conn.close()

    print("Atualização concluída!")

async def exportar_por_area_arquivos(caminho_banco, tabela, array_areas, pasta_saida):
    # Garante que a pasta de saída existe
    os.makedirs(pasta_saida, exist_ok=True)

    conn = sqlite3.connect(caminho_banco)

    # Descobre nomes das colunas
    cursor = conn.cursor()
    cursor.execute(f"PRAGMA table_info({tabela})")
    colunas_info = cursor.fetchall()
    colunas = [c[1] for c in colunas_info]

    coluna_31 = colunas[31]  # índice 33 (34ª coluna)

    # Lê tudo do banco
    df = pd.read_sql_query(f"SELECT * FROM {tabela}", conn)

    # Extrai código da posição 9–12 da coluna 33
    df["codigo_area"] = df[coluna_31].astype(str).str.slice(8, 12)  # pandas é 0-based

    # 1 Filtros principais
    filtros = {
        "Área 1000": df[df["codigo_area"].str.startswith("1")],
        "Área 2000": df[df["codigo_area"].str.startswith("2") & (~df["codigo_area"].isin(array_areas))],
        "Área 3000": df[df["codigo_area"].str.startswith("3")],
        "Área 4000": df[df["codigo_area"].str.startswith("4") | df["codigo_area"].str.startswith("0")],
        "Área 5000": df[df["codigo_area"].str.startswith("5")],
        "Área 6000": df[df["codigo_area"].str.startswith("6")],
        "Área 7000": df[df["codigo_area"].str.startswith("7") & (~df["codigo_area"].isin(array_areas))],
        "Área 8000": df[df["codigo_area"].str.startswith("8")],
    }

    # 2 Filtros para cada código específico do array
    for codigo in array_areas:
        filtros[f"Área {codigo}"] = df[df["codigo_area"] == codigo]

    # 3 Exporta cada filtro para um arquivo separado
    for nome_area, dados in filtros.items():
        if not dados.empty:
            caminho_arquivo = os.path.join(pasta_saida, f"{nome_area}.xlsx")
            dados.to_excel(caminho_arquivo, index=False)
            print(f"Arquivo gerado: {caminho_arquivo}")

    conn.close()
    print("Exportação concluída!")


async def ajeitar(pasta,OEC,mb,ta):
    # Configurações
    coluna_formula = "AG"  # coluna onde a fórmula será aplicada
    formula_excel = "=(Q{row}/100)*U{row}"  # fórmula (pode usar =SOMA(...) se preferir)
    celula_ancora = "B2"  # célula de referência para a imagem
    offset_x = 50  # deslocamento horizontal em pixels
    offset_y = 30  # deslocamento vertical em pixels

    # Loop por todas as planilhas .xlsx na pasta
    for arquivo in glob.glob(f"{pasta}/*.xlsx"):
        print(f"Processando: {arquivo}")
        wb = load_workbook(arquivo)
        ws = wb.active

        # Última linha com dados
        ultima_linha = ws.max_row

        ws.delete_cols(33)

        # Ajustar largura e altura
        ws.column_dimensions['A'].width = 17
        ws.column_dimensions['B'].width = 11
        ws.column_dimensions['C'].width = 65
        ws.column_dimensions['D'].width = 21
        ws.column_dimensions['E'].width = 14
        ws.column_dimensions['F'].width = 21
        ws.column_dimensions['G'].width = 27
        ws.column_dimensions['H'].width = 27
        ws.column_dimensions['I'].width = 65
        ws.column_dimensions['J'].width = 20
        ws.column_dimensions['K'].width = 18
        ws.column_dimensions['L'].width = 18
        ws.column_dimensions['M'].width = 11
        ws.column_dimensions['N'].width = 11
        ws.column_dimensions['O'].width = 36
        ws.column_dimensions['P'].width = 36
        ws.column_dimensions['Q'].width = 15
        ws.column_dimensions['R'].width = 40
        ws.column_dimensions['S'].width = 50
        ws.column_dimensions['T'].width = 25
        ws.column_dimensions['U'].width = 10
        ws.column_dimensions['V'].width = 10
        ws.column_dimensions['X'].width = 22
        ws.column_dimensions['Y'].width = 22
        ws.column_dimensions['W'].width = 7
        ws.column_dimensions['Z'].width = 22
        ws.column_dimensions['AA'].width = 18
        ws.column_dimensions['AB'].width = 6
        ws.column_dimensions['AC'].width = 20
        ws.column_dimensions['AD'].width = 20
        ws.column_dimensions['AE'].width = 25
        ws.column_dimensions['AF'].width = 26
        ws.column_dimensions['AG'].width = 17
      
        

        ws.row_dimensions[1].height = 20

        # Bordas finas em toda a área de dados
        borda_fina = Border(
            left=Side(style="thin"),
            right=Side(style="thin"),
            top=Side(style="thin"),
            bottom=Side(style="thin")
        )
        # Definir estilos
        fonte_estilo = Font(bold=True, size=11, color="FFFFFF")  # negrito, tamanho 14, texto branco
        preenchimento = PatternFill(start_color="1F4E78", end_color="1F4E78", fill_type="solid")  # fundo azul
        # borda_grossa = Border(
        #     left=Side(style="thick"),
        #     right=Side(style="thick"),
        #     top=Side(style="thick"),
        #     bottom=Side(style="thick")
        # )
        alinhamento_centro = Alignment(horizontal="center", vertical="center")

        ws.insert_rows(2)
        # Aplicar no range A1:AG1
        for row in ws.iter_rows(min_row=1, max_row=2, min_col=1, max_col=33):  # AG é a 33ª coluna
            for cell in row:
                cell.font = fonte_estilo
                cell.fill = preenchimento
                cell.border = borda_fina
                cell.alignment = alinhamento_centro


        for row in ws.iter_rows(min_row=2, max_row=ultima_linha + 1, min_col=1, max_col=33):
            for cell in row:
                cell.border = borda_fina
        
        ws.insert_rows(1)
        ws.row_dimensions[1].height = 65

        # Texto na primeira célula do intervalo
        ws["A1"].value = f"TA - {ta} \nRELATÓRIO DE CALCULO DE SERVIÇO\nDETALHADO - MONTAGEM - REDES INDUSTRIAIS - BSIM-S\nÁREA 2000"
        ws["A1"].font = Font(bold=True)
        alinhamento_centro = Alignment(horizontal="centerContinuous", vertical="center", wrap_text=True)

        # Percorrer todas as células do intervalo A1:AG1
        for row in ws["A1:AG1"]:
            for cell in row:
                cell.alignment = alinhamento_centro
        
        # Inserir imagem flutuante com deslocamento
        img_Oec = Image(OEC)
        img_Oec.width = 200   # largura
        img_Oec.height = 70  # altura
        img_Oec.anchor = "B1"
        ws.add_image(img_Oec)

        img_mb = Image(mb)
        img_mb.width = 170   # largura
        img_mb.height = 80  # altura
        img_mb.anchor = "AF1"
        ws.add_image(img_mb)

        ws["AG2"].value = "QUANTIDADE"

        # Última linha com dados
        ultima_linha = ws.max_row

        # Aplicar fórmula da linha 2 até a última
        for row in range(4, ultima_linha + 1):
            ws[f"{coluna_formula}{row}"] = formula_excel.format(row=row)

        # Salvar alterações
        wb.save(arquivo)

async def main():
    try:
        await export_planilhas(pln1,pln2,db_path)
        await ModDB(db_path,tabela)
        await trocando_Valores(database=db_path, areas= especificas, tabela=tabela)
        await exportar_por_area_arquivos(caminho_banco=db_path,tabela=tabela,array_areas=especificas,pasta_saida="export_areas")
        await ajeitar(pasta_planilhas,imagem_Odebrecht,imagem_Marinha,ta=33)
    
        print("Tarefa Concluida")
                    
    except Exception as e:
        print(f"Erro inesperado: {e}")
                
# asyncio.run(main())
