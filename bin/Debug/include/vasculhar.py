import os, time, sys, json
import pandas as pd
import sqlite3
from manipular import *

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

def varredura_com_data(caminho_raiz):
    dados = []

    for pasta_atual, subpastas, arquivos in os.walk(caminho_raiz):
        for nome_arquivo in arquivos:
            caminho_completo = os.path.join(pasta_atual, nome_arquivo)
            try:
                data_raw = time.ctime(os.path.getctime(caminho_completo))
                partes = data_raw.split()  # ['Wed', 'Aug', '27', '09:00:00', '2025']
                mes = partes[1]
                dia_hora = f"{partes[2]} {partes[3]}"
                ano = partes[4]
            except Exception:
                mes = dia_hora = ano = "Desconhecido"

            dados.append({
                'nome_arquivo': nome_arquivo,
                'caminho': caminho_completo,
                'pasta': pasta_atual,
                'dia_hora': dia_hora,
                'mes': mes,
                'ano': ano
            })

    return pd.DataFrame(dados)

def varredura_pastas(caminho_raiz):
    import os
    import pandas as pd

    dados = []

    for pasta_atual, subpastas, arquivos in os.walk(caminho_raiz):
        for subpasta in subpastas:
            caminho_completo = os.path.join(pasta_atual, subpasta)
            dados.append({
                'nome_pasta': subpasta,
                'caminho': caminho_completo
            })

    return pd.DataFrame(dados)

def deletar_tabela(nome_tabela, db_path):
    conn = sqlite3.connect(db_path)
    cursor = conn.cursor()

    try:
        cursor.execute(f'DROP TABLE IF EXISTS {nome_tabela}')
        conn.commit()
        print(f'Tabela "{nome_tabela}" deletada com sucesso.')
    except Exception as e:
        print(f'Erro ao deletar a tabela: {e}')
    finally:
        conn.close()

# Caminho da pasta que você quer escanear
caminho_diretorio = sys.argv[3]  # Altere para o seu caminho
modo = sys.argv[1]
tabela = sys.argv[2]
arquivoTxT = GerenciadorArquivo("log.txt")
# Coletando os dados

def iniciar_varredura(modo):
    with open("config.json", "r", encoding="utf-8") as f:
            configPDF = json.load(f)
            config = configPDF["Geral"]
    db_path = config["DataBase"]
            
    match modo:
        case "Arquivos e Data":
            df = varredura_com_data(caminho_diretorio) 
        case "Arquivos e Pastas":
            df = coletar_dados_diretorio(caminho_diretorio)
        case "Apenas Pastas":
            df = varredura_pastas(caminho_diretorio)
        case "Deletar":
            df = deletar_tabela(tabela, db_path)
            arquivoTxT.atualizar_arquivo("Deletando Arquivos")
            return

    
    conn = sqlite3.connect(db_path)
    df.to_sql(tabela, conn, if_exists='replace', index=False)
    conn.close()

    print(f'{len(df)} arquivos salvos com sucesso em {db_path}')
    # return df

iniciar_varredura(modo)
# Salvando no banco SQLite

