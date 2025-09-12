import win32com.client, sqlite3, os
import pandas as pd
from pathlib import Path


arquivo_excel = (r"C:\Users\lucasduarte\source\repos\Orçamento_Industrial\windowsFormOI\bin\Debug\include\Nova pasta\Área 7818.xlsx")
arquivo_macro = Path(r"C:\Users\lucasduarte\source\repos\Orçamento_Industrial\windowsFormOI\bin\Debug\include\Macros\MC_R20.bas")
ta = 33
pasta_planilhas = r"C:\Users\lucasduarte\Downloads\arquivos\ppqs"


def AtivandoMacro(macro, arquivo):

    # Abre o Excel
    excel = win32com.client.Dispatch("Excel.Application")
    excel.Visible = False  # ou True se quiser ver a execução

    # Lê o conteúdo da macro
    with open(macro, "r", encoding="utf-8") as f:
        vba_code = f.read()

    wb = excel.Workbooks.Open(arquivo)

    # Modificação: insere linha e texto em A1
    ws = wb.Sheets(1)
    ws.Rows("1:1").Insert()
    ws.Range("A1").Value = f"TA - {ta} \nRELATÓRIO DE CALCULO DE SERVIÇO\nDETALHADO - MONTAGEM - REDES INDUSTRIAIS - BSIM-S\nÁREA 2000"

    # Adiciona módulo e insere código
    vb_module = wb.VBProject.VBComponents.Add(1)
    vb_module.CodeModule.AddFromString(vba_code)

    # Executa macro
    excel.Application.Run("TransP1")

    # Remove o módulo VBA antes de salvar
    wb.VBProject.VBComponents.Remove(vb_module)

    # Salva o arquivo sem gravar o VBA
    wb.SaveAs(r"Nova pasta\Área 8000-2.xlsx", FileFormat=51)  # 51 = .xlsx sem macro
    wb.Close(SaveChanges=False)
    excel.Quit()

def DadosPPQ():


    conn = sqlite3.connect('planilhas.db')
    tabela_criada = False
    colunas_padrao = None  # será definida com base na primeira planilha válida

    for arquivo in os.listdir(pasta_planilhas):
        if arquivo.endswith('.xlsx') or arquivo.endswith('.xls'):
            caminho_arquivo = os.path.join(pasta_planilhas, arquivo)

            try:
                df = pd.read_excel(caminho_arquivo, skiprows=7)
            except Exception as e:
                print(f"Erro ao ler {arquivo}: {e}")
                continue

            # Limpa os nomes das colunas
            df.columns = (
                df.columns
                .str.encode('latin1', errors='ignore')
                .str.decode('latin1')
                .str.strip()
                .str.replace('\n', ' ', regex=False)
                .str.replace('\r', '', regex=False)
            )

            # Filtra linhas onde a coluna B contém "OCC"
            coluna_b = df.columns[1]
            df_filtrado = df[df[coluna_b].astype(str).str.contains("OCC", na=False)]

            # Define colunas padrão com base na primeira planilha válida
            if colunas_padrao is None:
                colunas_padrao = df_filtrado.columns.tolist()

            # Garante que o DataFrame tenha as mesmas colunas
            df_filtrado = df_filtrado.reindex(columns=colunas_padrao)

            # Insere no banco
            if not tabela_criada:
                df_filtrado.to_sql('OCC_33', conn, if_exists='replace', index=False)
                tabela_criada = True
            else:
                df_filtrado.to_sql('OCC_33', conn, if_exists='append', index=False)

    conn.close()



DadosPPQ()
# AtivandoMacro(arquivo_macro, arquivo_excel)