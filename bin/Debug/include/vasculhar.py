import os
import pandas as pd
import sqlite3

# Função para coletar dados dos arquivos
def coletar_dados_diretorio(caminho_raiz):
    dados = []

    for pasta_atual, subpastas, arquivos in os.walk(caminho_raiz):
        for nome_arquivo in arquivos:
            caminho_completo = os.path.join(pasta_atual, nome_arquivo)

            dados.append({
                'nome_arquivo': nome_arquivo,
                'caminho': caminho_completo,
                'pasta': pasta_atual
            })

    return pd.DataFrame(dados)

# Caminho da pasta que você quer escanear
caminho_diretorio = 'I:/PLANEJAMENTO/UFEM-01'  # Altere para o seu caminho

# Coletando os dados
df = coletar_dados_diretorio(caminho_diretorio)

# Salvando no banco SQLite
db_path = 'dados_arquivos.db'
conn = sqlite3.connect(db_path)
df.to_sql('arquivos', conn, if_exists='replace', index=False)
conn.close()

print(f'{len(df)} arquivos salvos com sucesso em {db_path}')
