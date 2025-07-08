import sys, os, json, time, PyPDF2
from manipular import GerenciadorArquivo


sys.path.append(os.path.join(os.path.dirname(__file__), "../libs"))

with open("include/layouts_papel.json", "r", encoding="utf-8") as arquivo:
    layouts = json.load(arquivo)

def obter_nome_saida(caminho_arquivo, saida):
    """Retorna o nome do arquivo original (sem extensão) na pasta ./out/Imprimir."""
    nome_base = os.path.splitext(os.path.basename(caminho_arquivo))[0]
    return os.path.join(os.getcwd(), saida, f"{nome_base}.pdf")

def ajustar_tamanho_pagina(pagina, tamanho_papel):
    """Redimensiona a página para o tamanho de papel escolhido."""
    nova_pagina = PyPDF2.PageObject.create_blank_page(width=tamanho_papel[0], height=tamanho_papel[1])
    nova_pagina.merge_page(pagina)  # Mantém o conteúdo original dentro do novo tamanho
    return nova_pagina

def aplicar_fundo_preservando_texto(pdf_original, pdf_fundo, pdf_resultado, tamanho_papel):
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

        with open(pdf_resultado, "wb") as saida:
            escritor.write(saida)

def processar_arquivo_pdf(arquivo_pdf_original, config, saida):
    """Processa um arquivo PDF individualmente."""
    pdf_resultado = obter_nome_saida(arquivo_pdf_original, saida)
    arquivo_pdf_fundo = config["fundo"]
    tamanho_papel = config["tamanho"]

    aplicar_fundo_preservando_texto(arquivo_pdf_original, arquivo_pdf_fundo, pdf_resultado, tamanho_papel)

layout_escolhido = sys.argv[1]
diretorio = sys.argv[3]
saida = sys.argv[2] 
arquivotxt = GerenciadorArquivo("include/log.txt")
# Obtém a configuração do layout escolhido (o JSON deve conter as chaves "fundo", "repetido" e "tamanho")
config = layouts[layout_escolhido]

if os.path.isdir(diretorio):
    itens = os.listdir(diretorio)
    total_itens = len(itens)

    for indice, item in enumerate(itens, start=1):
        caminho_item = os.path.join(diretorio, item)
        arquivotxt.atualizar_arquivo(f"Adicionando Timbrado ao arquivo {item} ({indice} de {total_itens})")

        if os.path.isfile(caminho_item) and caminho_item.lower().endswith(".pdf"):
            processar_arquivo_pdf(caminho_item, config, saida)

    arquivotxt.atualizar_arquivo(f"Timbrado inserido em {total_itens} itens")
    time.sleep(3)
    arquivotxt.atualizar_arquivo("Tarefa Concluida")
    time.sleep(2)
    arquivotxt.limpar_arquivo()

else:
    # Se for um arquivo único, processa ele mesmo
    arquivotxt.atualizar_arquivo(f"Inserindo Timbrado no arquivo {diretorio}")
    processar_arquivo_pdf(diretorio, config, saida)
    arquivotxt.atualizar_arquivo("Tarefa Concluida")
    time.sleep(2)
    arquivotxt.limpar_arquivo()