import pandas as pd
import gc, sqlite3, os


pln1 = r"C:\Users\lucasduarte\Downloads\arquivos\R20 Tub-Sup-Sist_seg.xlsx"
pln2 = r"C:\Users\lucasduarte\Downloads\arquivos\R20_GERAL_ELÉTRICA E INSTRUMENTAÇÃO - 28.08.2025.xlsx"

# Nome do banco de dados
db_path = "planilhas.db"

especificas = ["2502", "2511", "2706", "2721", "2722", "2737", "2744", "7816", "7818"]

tabela = "tabela_unica02"

def export_planilhas(plan1, plan2, database):

    

    # Colunas que você realmente precisa
    colunas = [0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,48,49,50]

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

def ModDB(database):
    # Caminho do banco SQLite
    caminho_banco = database
    tabela = "tabela_unica02"

    # Conecta ao banco
    conn = sqlite3.connect(caminho_banco)
    cursor = conn.cursor()

    # Descobre os nomes das colunas na ordem física
    cursor.execute(f"PRAGMA table_info({tabela})")
    colunas_info = cursor.fetchall()

    # colunas_info retorna: [(cid, name, type, notnull, dflt_value, pk), ...]
    coluna_32 = colunas_info[32][1]  # índice 33 → nome da coluna
    coluna_33 = colunas_info[33][1]  # índice 34 → nome da coluna

    coluna_32_sql = f'"{coluna_32}"'
    coluna_33_sql = f'"{coluna_33}"'

    # 1️⃣ Deleta linhas onde coluna_33 é NULL
    cursor.execute(f"""
    DELETE FROM {tabela}
    WHERE {coluna_32_sql} IS NULL
       OR {coluna_32_sql} = ?
       OR {coluna_32_sql} = ?
    """,
    ("SAIU DO ORÇAMENTO", "#")
)
    cursor.execute(f"""
    UPDATE {tabela}
    SET {coluna_32_sql} = LTRIM({coluna_32_sql}, '#')
    WHERE {coluna_32_sql} LIKE '#%';
""")


    # 2️⃣ Deleta linhas onde coluna_34 NÃO é NULL
    cursor.execute(f"DELETE FROM {tabela} WHERE {coluna_33_sql} IS NOT NULL")

    # Salva as alterações
    conn.commit()

    # Fecha a conexão
    conn.close()

    print("Linhas deletadas com sucesso!")

def trocando_Valores(database, areas, tabela):
    # Conecta ao banco
    conn = sqlite3.connect(database)
    cursor = conn.cursor()

    # Descobre nomes das colunas
    cursor.execute(f"PRAGMA table_info({tabela})")
    colunas_info = cursor.fetchall()

    coluna_3 = colunas_info[2][1]   # terceira coluna (índice 2)
    coluna_33 = colunas_info[32][1] # coluna 33 (índice 33)

    # Escapa nomes de colunas
    coluna_3_sql = f'"{coluna_3}"'
    coluna_33_sql = f'"{coluna_33}"'

    # Monta placeholders para o IN
    placeholders = ",".join("?" for _ in areas)

    # Query:
    # - SUBSTR(coluna_33, 1, 8) → mantém do início até antes da posição 9
    # - SUBSTR(coluna_3, 1, 4) → pega os 4 primeiros caracteres da coluna 3
    # - SUBSTR(coluna_33, 13) → mantém do caractere 13 até o fim
    sql = f"""
    UPDATE {tabela}
    SET {coluna_33_sql} = SUBSTR({coluna_33_sql}, 1, 8) 
                        || SUBSTR({coluna_3_sql}, 1, 4) 
                        || SUBSTR({coluna_33_sql}, 13)
    WHERE SUBSTR({coluna_3_sql}, 1, 4) IN ({placeholders})
    """

    # Executa
    cursor.execute(sql, areas)

    conn.commit()
    conn.close()

    print("Atualização concluída!")

def exportar_por_area_arquivos(caminho_banco, tabela, array_areas, pasta_saida):
    # Garante que a pasta de saída existe
    os.makedirs(pasta_saida, exist_ok=True)

    conn = sqlite3.connect(caminho_banco)

    # Descobre nomes das colunas
    cursor = conn.cursor()
    cursor.execute(f"PRAGMA table_info({tabela})")
    colunas_info = cursor.fetchall()
    colunas = [c[1] for c in colunas_info]

    coluna_33 = colunas[32]  # índice 33 (34ª coluna)

    # Lê tudo do banco
    df = pd.read_sql_query(f"SELECT * FROM {tabela}", conn)

    # Extrai código da posição 9–12 da coluna 33
    df["codigo_area"] = df[coluna_33].astype(str).str.slice(8, 12)  # pandas é 0-based

    # 1️⃣ Filtros principais
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

    # 2️⃣ Filtros para cada código específico do array
    for codigo in array_areas:
        filtros[f"Área {codigo}"] = df[df["codigo_area"] == codigo]

    # 3️⃣ Exporta cada filtro para um arquivo separado
    for nome_area, dados in filtros.items():
        if not dados.empty:
            caminho_arquivo = os.path.join(pasta_saida, f"{nome_area}.xlsx")
            dados.to_excel(caminho_arquivo, index=False)
            print(f"Arquivo gerado: {caminho_arquivo}")

    conn.close()
    print("Exportação concluída!")

exportar_por_area_arquivos(
    caminho_banco=db_path,
    tabela=tabela,
    array_areas=especificas,
    pasta_saida="export_areas"
)
# trocando_Valores(database=db_path, areas= especificas, tabela=tabela)
# export_planilhas(pln1,pln2,db_path)
# ModDB(database= db_path)