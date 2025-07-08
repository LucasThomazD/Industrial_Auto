import sys
import os
import json
from manipular import GerenciadorArquivo
import time

import PyPDF2

# Adiciona o diretório dos pacotes à variável sys.path
#sys.path.append(r"..\bin\pyPDF\Lib\site-packages")
sys.path.append(os.path.join(os.path.dirname(__file__), "../libs"))

with open("include/layouts_papel.json", "r", encoding="utf-8") as arquivo:
    layouts = json.load(arquivo)

def obter_nome_saida(caminho_arquivo):
    """Retorna o nome do arquivo original (sem extensão) na pasta ./out/Imprimir."""
    nome_base = os.path.splitext(os.path.basename(caminho_arquivo))[0]
    return os.path.join(os.getcwd(), "out", "Imprimir", f"{nome_base}.pdf")

def ajustar_tamanho_pagina(pagina, tamanho_papel):
    """Redimensiona a página para o tamanho de papel escolhido."""
    nova_pagina = PyPDF2.PageObject.create_blank_page(width=tamanho_papel[0], height=tamanho_papel[1])
    nova_pagina.merge_page(pagina)  # Mantém o conteúdo original dentro do novo tamanho
    return nova_pagina

def aplicar_fundo_preservando_texto(pdf_original, pdf_fundo, pdf_saida_temp, tamanho_papel):
    """Sobrepõe um PDF de fundo em cada página, preservando o texto e numeração do original."""
    with open(pdf_original, "rb") as arquivo_original, open(pdf_fundo, "rb") as arquivo_fundo:
        leitor_original = PyPDF2.PdfReader(arquivo_original)
        leitor_fundo = PyPDF2.PdfReader(arquivo_fundo)
        escritor = PyPDF2.PdfWriter()

        if len(leitor_fundo.pages) == 0:
            raise ValueError("O arquivo de fundo está vazio!")

        fundo_pagina = leitor_fundo.pages[0]  # Pegamos a primeira página do fundo

        for pagina in leitor_original.pages:
            pagina_ajustada = ajustar_tamanho_pagina(pagina, tamanho_papel)
            nova_pagina = PyPDF2.PageObject.create_blank_page(width=tamanho_papel[0], height=tamanho_papel[1])
            nova_pagina.merge_page(fundo_pagina)
            nova_pagina.merge_page(pagina_ajustada)

            escritor.add_page(nova_pagina)

        with open(pdf_saida_temp, "wb") as saida:
            escritor.write(saida)

def inserir_pagina_repetida(arquivo_pdf_original, arquivo_pdf_pagina_repetida, arquivo_pdf_resultado, arquivo_pdf_fundo, tamanho_papel):
    """Aplica um fundo a cada página antes de inserir a página repetida."""
    pdf_temp_com_fundo = "temp_com_fundo.pdf"
    aplicar_fundo_preservando_texto(arquivo_pdf_original, arquivo_pdf_fundo, pdf_temp_com_fundo, tamanho_papel)

    try:
        with open(pdf_temp_com_fundo, 'rb') as arquivo_original, open(arquivo_pdf_pagina_repetida, 'rb') as arquivo_repetida:
            leitor_original = PyPDF2.PdfReader(arquivo_original)
            leitor_repetida = PyPDF2.PdfReader(arquivo_repetida)
            escritor = PyPDF2.PdfWriter()

            if len(leitor_repetida.pages) == 0:
                raise ValueError("O arquivo de página repetida está vazio.")

            pagina_repetida = ajustar_tamanho_pagina(leitor_repetida.pages[0], tamanho_papel)

            for pagina in leitor_original.pages:
                pagina_ajustada = ajustar_tamanho_pagina(pagina, tamanho_papel)
                escritor.add_page(pagina_ajustada)
                escritor.add_page(pagina_repetida)

            with open(arquivo_pdf_resultado, 'wb') as arquivo_resultado:
                escritor.write(arquivo_resultado)

        print(f"Arquivo salvo com sucesso: {arquivo_pdf_resultado}")

    except Exception as e:
        print(f"Erro ao processar os arquivos: {e}")



def processar_arquivo_pdf(arquivo_pdf_original, config):
    """Processa um arquivo PDF individualmente."""
    arquivo_pdf_resultado = obter_nome_saida(arquivo_pdf_original)
    arquivo_pdf_fundo = config["fundo"]
    arquivo_pdf_pagina_repetida = config["repetido"]
    tamanho_papel = config["tamanho"]

    inserir_pagina_repetida(arquivo_pdf_original, arquivo_pdf_pagina_repetida,
                            arquivo_pdf_resultado, arquivo_pdf_fundo, tamanho_papel)
    

# Argumentos passados pelo C#
# sys.argv[1] -> layout escolhido
# sys.argv[3] -> arquivo PDF ou pasta que contém os PDFs
layout_escolhido = sys.argv[1]
entrada = sys.argv[3]
arquivotxt = GerenciadorArquivo("include/log.txt")
# Obtém a configuração do layout escolhido (o JSON deve conter as chaves "fundo", "repetido" e "tamanho")
config = layouts[layout_escolhido]

if os.path.isdir(entrada):
    # Obtém a lista de itens no diretório
    itens = os.listdir(entrada)
    total_itens = len(itens)
    
    # Itera com o índice usando enumerate()
    for indice, item in enumerate(itens, start=1):  # start=1 para começar do índice 1
        caminho_item = os.path.join(entrada, item)
        # Atualiza o status com o progresso
        arquivotxt.atualizar_arquivo(f"Mesclando Páginas No Arquivo {indice} de {total_itens}: {item}")
        
        if os.path.isfile(caminho_item) and caminho_item.lower().endswith(".pdf"):
            processar_arquivo_pdf(caminho_item, config)
    arquivotxt.atualizar_arquivo(f"{total_itens} Mesclados!")
    time.sleep(3)
    arquivotxt.atualizar_arquivo("Tarefa Concluida")
    time.sleep(2)
    arquivotxt.limpar_arquivo()
else:
    # Se for um arquivo único, processa ele mesmo
    arquivotxt.atualizar_arquivo(f"Mesclando Páginas no Arquivo {entrada}")
    processar_arquivo_pdf(entrada, config)
    arquivotxt.atualizar_arquivo("Tarefa Concluida")
    time.sleep(2)
    arquivotxt.limpar_arquivo()
