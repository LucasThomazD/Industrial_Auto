import pandas as pd
import gc, sqlite3

pln1 = r"C:\Users\lucasduarte\Desktop\Leticia\MAPÃO PARA F_C 02.09.2025_.xlsx"
db_path = "Mapão.db"

# Nome da tabela original
tabela_original = "tabela"

# Nome temporário para a tabela ordenada
tabela_ordenada = "tabela_ordenada"

excel_path = r"primeiras_medicoes.xlsx"


def export_planilhas(plan1, database):

    

    # Colunas que você realmente precisa
    colunas = [0,1,2,3,4,5,6,7,8,9,28,29]

    # 1️⃣ Lê a primeira planilha (todas as linhas, só as colunas necessárias)
    df1 = pd.read_excel(plan1, usecols=colunas)

    # 🔹 Padroniza os nomes para garantir igualdade

    df1.columns = df1.columns.str.strip().str.upper()
   



    # 4️⃣ Salva no banco SQLite
    conn = sqlite3.connect(database)
    df1.to_sql("tabela", conn, if_exists="replace", index=False)
    conn.close()
    gc.collect()

def alterarDB(database):

    conn = sqlite3.connect(database)
    cursor = conn.cursor()

    # 1️⃣ Atualiza a coluna para manter só os 10 primeiros caracteres
    cursor.execute(f"""
        UPDATE {tabela_original}
        SET "MÊS DA PROPOSTA" = substr("MÊS DA PROPOSTA", 1, 10);
    """)

    conn.commit()

    # Cria nova tabela ordenada
    cursor.execute(f"""
        CREATE TABLE {tabela_original}_ordenada AS
        SELECT *
        FROM {tabela_original}
        ORDER BY "MÊS DA PROPOSTA" ASC;
    """)

    # Remove a tabela original
    cursor.execute(f"DROP TABLE {tabela_original};")

    # Renomeia a nova tabela para o nome original
    cursor.execute(f"""
        ALTER TABLE {tabela_original}_ordenada
        RENAME TO {tabela_original};
    """)

    conn.commit()
    conn.close()
    print("Tabela reordenada permanentemente com sucesso!")

def get_primeiras_medicoes(db_path):
    """
    Retorna, para cada FOTA_TAG, a linha com a menor DT_MEDICAO
    da tabela TBL_MED_SERVICO_POS_MIGRACAO.
    """
    conn = sqlite3.connect(db_path)
    cursor = conn.cursor()

    query = """SELECT T.*
FROM tabela AS T
INNER JOIN (
  SELECT 
    "UNNAMED: 29",
    MIN("MÊS DA PROPOSTA") AS DATA_MINIMA
  FROM tabela
  GROUP BY "UNNAMED: 29"
) AS M
  ON T."UNNAMED: 29" = M."UNNAMED: 29"
 AND T."MÊS DA PROPOSTA" = M.DATA_MINIMA;
"""

    cursor.execute(query)
    # 2️⃣ Pega dados e cabeçalho
    rows = cursor.fetchall()
    cols = [desc[0] for desc in cursor.description]
    conn.close()

    # 3️⃣ Cria DataFrame e exporta para Excel
    df = pd.DataFrame(rows, columns=cols)
    df.to_excel(excel_path, index=False)

    print(f"Exportado {len(df)} linhas para '{excel_path}' com sucesso!")

get_primeiras_medicoes(db_path)
# export_planilhas(pln1,db_path)
# alterarDB(db_path)
