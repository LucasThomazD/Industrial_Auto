import pandas as pd
import sqlite3
import gc
from concurrent.futures import ThreadPoolExecutor, as_completed

# Caminhos dos arquivos Excel
# pln1 = r"C:\Users\lucasduarte\Downloads\arquivos\R20 Tub-Sup-Sist_seg.xlsx"
# pln2 = r"C:\Users\lucasduarte\Downloads\arquivos\R20_GERAL_ELÉTRICA E INSTRUMENTAÇÃO - 28.08.2025.xlsx"

# # Nome do banco de dados
# db_path = "teste.db"

# # Índices das colunas desejadas
# colunas_idx = [0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,48,49,50]

# arquivos = [r"C:\Users\lucasduarte\Downloads\arquivos\R20 Tub-Sup-Sist_seg.xlsx",r"C:\Users\lucasduarte\Downloads\arquivos\R20_GERAL_ELÉTRICA E INSTRUMENTAÇÃO - 28.08.2025.xlsx"]

# Lista de arquivos e parâmetros específicos
arquivos = [
    {"path": r"C:\Users\lucasduarte\Downloads\arquivos\R20 Tub-Sup-Sist_seg.xlsx", "skiprows": 0},  # lê desde o cabeçalho
    {"path": r"C:\Users\lucasduarte\Downloads\arquivos\R20_GERAL_ELÉTRICA E INSTRUMENTAÇÃO - 28.08.2025.xlsx", "skiprows": 1}   # pula a primeira linha
]

def processar_planilha(info):
    """Lê, remove colunas e retorna DataFrame limpo."""
    df = pd.read_excel(info["path"], skiprows=info["skiprows"])
    # Remove colunas de índice 31 a 47
    df.drop(df.columns[31:48], axis=1, inplace=True)
    return df

# Processa em paralelo
with ThreadPoolExecutor() as executor:
    resultados = list(executor.map(processar_planilha, arquivos))

# Junta tudo em um único DataFrame
df_final = pd.concat(resultados, ignore_index=True)

# Conferência
print(df_final.head())

# Salva se quiser
df_final.to_excel("planilhas_limpas.xlsx", index=False)