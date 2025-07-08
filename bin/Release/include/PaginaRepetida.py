import PyPDF2
import time
import os
import sys
import json
from manipular import GerenciadorArquivo

sys.path.append(os.path.join(os.path.dirname(__file__), "../libs"))

with open("include/layouts_papel.json", "r", encoding="utf-8") as arquivo:
    layouts = json.load(arquivo)

def obter_nome_saida(caminho_arquivo, saida):
    """Retorna o nome do arquivo original (sem extensão) na pasta ./out/Imprimir."""
    nome_base = os.path.splitext(os.path.basename(caminho_arquivo))[0]
    return os.path.join(os.getcwd(), saida, f"{nome_base}.pdf")

def inserir_paginas(arquivo_principal, arquivo_inserido, pdf_resultado):
    """Insere as páginas de dois arquivos PDF."""
    try:
        # Abrir os PDFs
        with open(arquivo_principal, "rb") as file_principal, open(arquivo_inserido, "rb") as file_inserido:
            leitor_principal = PyPDF2.PdfReader(file_principal)
            leitor_inserido = PyPDF2.PdfReader(file_inserido)
            escritor = PyPDF2.PdfWriter()

            # Combina as páginas dos dois PDFs
            for i in range(len(leitor_principal.pages)):
                escritor.add_page(leitor_principal.pages[i])
                for page in leitor_inserido.pages:
                    escritor.add_page(page)

            # Salva o arquivo mesclado
            with open(pdf_resultado, "wb") as output_file:
                escritor.write(output_file)

        print(f"Arquivo salvo em: {pdf_resultado}")
    except Exception as e:
        print(f"Erro ao tratar arquivo(s): {e}")

def processar_arquivo_pdf(arquivo_pdf_original, config, saida):
    """Processa um arquivo PDF individualmente."""
    pdf_resultado = obter_nome_saida(arquivo_pdf_original, saida)
    arquivo_inserido = config["repetido"]

    inserir_paginas(arquivo_pdf_original, arquivo_inserido, pdf_resultado)

# Obtém os argumentos da linha de comando
layout = sys.argv[1]  # Arquivo inserido
diretorio = sys.argv[3]  # Diretório principal
saida = sys.argv[2]  # Diretório para salvar o arquivo mesclado
config = layouts[layout]

arquivotxt = GerenciadorArquivo("include/log.txt")

if os.path.isdir(diretorio):
    itens = os.listdir(diretorio)
    total_itens = len(itens)

    for indice, item in enumerate(itens, start=1):
        caminho_item = os.path.join(diretorio, item)
        arquivotxt.atualizar_arquivo(f"Adicionando páginas extras ao arquivo {item} ({indice} de {total_itens})")

        if os.path.isfile(caminho_item) and caminho_item.lower().endswith(".pdf"):
            processar_arquivo_pdf(caminho_item, config, saida)

    arquivotxt.atualizar_arquivo(f"Páginas em branco inseridas em {total_itens} itens")
    time.sleep(3)
    arquivotxt.atualizar_arquivo("Tarefa Concluida")
    time.sleep(2)
    arquivotxt.limpar_arquivo()

else:
    # Se for um arquivo único, processa ele mesmo
    arquivotxt.atualizar_arquivo(f"Mesclando páginas no arquivo {diretorio}")
    processar_arquivo_pdf(diretorio, config, saida)
    arquivotxt.atualizar_arquivo("Tarefa Concluida")
    time.sleep(2)
    arquivotxt.limpar_arquivo()
