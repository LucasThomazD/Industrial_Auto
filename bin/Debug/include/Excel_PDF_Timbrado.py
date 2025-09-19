import win32com.client, os, sys, json, time, PyPDF2, win32print
from manipular import *
from PyPDF2 import PdfReader, PdfWriter, PageObject


with open("include/layouts_papel.json", "r", encoding="utf-8") as arquivo:
    layouts = json.load(arquivo)

with open("config.json","r", encoding="utf-8") as configurar:
    defin = json.load(configurar)


select = defin["Geral"]
impressora = select["Impressora"]



win32print.SetDefaultPrinter(impressora)
# win32print.GetDefaultPrinter()

class Pdf_Bonito:

    def obter_nome_saida(caminho_arquivo, divisão):
        """Retorna o nome do arquivo original (sem extensão) na pasta ./out/Excel_PDF."""
        nome_base = os.path.splitext(os.path.basename(caminho_arquivo))[0]
        return os.path.join(divisão, f"{nome_base}.pdf") 

    def ajustar_tamanho_pagina(pagina, tamanho_papel):
        """Redimensiona a página para o tamanho de papel escolhido."""
        nova_pagina = PyPDF2.PageObject.create_blank_page(width=tamanho_papel[0], height=tamanho_papel[1])
        nova_pagina.merge_page(pagina)  # Mantém o conteúdo original dentro do novo tamanho
        return nova_pagina
    
    
    
    def gerarPDF(arquivo_excel, config, arquivo_nome):
        # Obter o caminho de saída do PDF a partir do arquivo Excel
        
        # Inicializar o Excel
        excel = win32com.client.Dispatch("Excel.Application")
        excel.Visible = False  # Manter em segundo plano
        
        # Abrir o arquivo Excel
        wb = excel.Workbooks.Open(arquivo_excel)

        
        # Selecionar a primeira planilha
        ws = wb.Worksheets(1)
        
        # Configurar a página (margens, orientação, tamanho do papel) usando os valores em config
        ws.PageSetup.TopMargin = config["topMarg"]
        ws.PageSetup.BottomMargin = config["botMarg"]
        ws.PageSetup.LeftMargin = config["leftMarg"]
        ws.PageSetup.RightMargin = config["rightMarg"]
        ws.PageSetup.FooterMargin = 0
        ws.PageSetup.PaperSize = config["papel"]
        ws.PageSetup.Orientation = config["orientacao"]
        ws.PageSetup.Zoom = False
        ws.PageSetup.FitToPagesWide = 1
        ws.PageSetup.FitToPagesTall = False
        ws.PageSetup.CenterHorizontally = True
        ws.PageSetup.RightFooter = "   &P de &N"
        ws.PageSetup.PrintTitleRows = config["cabecalho"]

        # Salvar como PDF
        wb.ExportAsFixedFormat(0, arquivo_nome)

        # Fechar tudo
        wb.Close(False)
        excel.Quit()

        return arquivo_nome
    
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
                pagina_ajustada = Pdf_Bonito.ajustar_tamanho_pagina(pagina, tamanho_papel)
                nova_pagina = PyPDF2.PageObject.create_blank_page(width=tamanho_papel[0], height=tamanho_papel[1])
                nova_pagina.merge_page(fundo_pagina)
                nova_pagina.merge_page(pagina_ajustada)

                escritor.add_page(nova_pagina)

            with open(pdf_resultado, "wb") as saida:
                escritor.write(saida)

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



   

salvar = sys.argv[2]
layout = sys.argv[1]
input = sys.argv[3]
escolha = int(sys.argv[4])
config = layouts[layout]
arquivo_pdf_fundo = config["fundo"]
tamanho_papel = config["tamanho"]
pagina_repetida = config["repetido"]
arquivotxt = GerenciadorArquivo("include/log.txt")
def iniciar_func(func,entrada,index,lista):
        match func:
            case 1:
                nome = Pdf_Bonito.obter_nome_saida(entrada,divisão= salvar)
                nome_base = os.path.splitext(os.path.basename(entrada))[0]
                arquivotxt.atualizar_arquivo(f"Gerando PDF - {nome_base} - {index} de {lista}")
                Pdf_Bonito.gerarPDF(entrada,config,nome)
                arquivotxt.atualizar_arquivo(f"Inserindo Timbrado - {nome_base} - {index} de {lista}")
                Pdf_Bonito.aplicar_fundo_preservando_texto(nome, arquivo_pdf_fundo, nome, tamanho_papel)
                arquivotxt.atualizar_arquivo(f"Inserindo páginas em branco - {nome_base} - {index} de {lista}")
                Pdf_Bonito.inserir_paginas(nome,pagina_repetida,nome)



            case 2:
                nome = Pdf_Bonito.obter_nome_saida(entrada,divisão= salvar)
                nome_base = os.path.splitext(os.path.basename(entrada))[0]
                arquivotxt.atualizar_arquivo(f"Inserindo Timbrado - {nome_base} - {index} de {lista}")
                Pdf_Bonito.aplicar_fundo_preservando_texto(entrada, arquivo_pdf_fundo, nome, tamanho_papel)


            case 3:
                nome = Pdf_Bonito.obter_nome_saida(entrada,divisão= salvar)
                nome_base = os.path.splitext(os.path.basename(entrada))[0]
                arquivotxt.atualizar_arquivo(f"Inserindo páginas em branco - {nome_base} - {index} de {lista}")
                Pdf_Bonito.inserir_paginas(entrada,pagina_repetida,nome)


                

# iniciar_func(escolha,input)
# 
 
if os.path.isdir(input):
    if int(sys.argv[4]) == 1:# Se for diretório, percorre todos os arquivos Excel dentro dele
        itens = os.listdir(input)
        total_itens = len(itens)
        for indice, item in enumerate(itens, start=1):  # Itera sobre os itens com índice
            caminho_item = os.path.join(input, item)
            if os.path.isfile(caminho_item) and caminho_item.lower().endswith((".xlsx", ".xls")):
                # Atualiza o progresso e processa o arquivo
                iniciar_func(escolha,caminho_item,indice,total_itens)
        arquivotxt.atualizar_arquivo(f"{total_itens} Arquivos gerados")
        time.sleep(4)
        arquivotxt.atualizar_arquivo("Tarefa Concluida")
        time.sleep(2)
        arquivotxt.limpar_arquivo()
    
    else:
        itens = os.listdir(input)
        total_itens = len(itens)
        for indice, item in enumerate(itens, start=1):  # Itera sobre os itens com índice
            caminho_item = os.path.join(input, item)
            if os.path.isfile(caminho_item) and caminho_item.lower().endswith((".pdf")):
                # Atualiza o progresso e processa o arquivo
                iniciar_func(escolha,caminho_item,indice,total_itens)
        arquivotxt.atualizar_arquivo(f"{total_itens} Arquivos Convertidos!")
        time.sleep(4)
        arquivotxt.atualizar_arquivo("Tarefa Concluida")
        time.sleep(2)
        arquivotxt.limpar_arquivo()
        
else:
    # Se for um arquivo único, processa ele mesmo
    if int(sys.argv[4]) == 1:
        if os.path.isfile(input) and input.lower().endswith((".xlsx", ".xls")):
            iniciar_func(escolha,input, index=1, lista=1)
            arquivotxt.atualizar_arquivo("Tarefa Concluida")
            time.sleep(2)
            arquivotxt.limpar_arquivo()
    
    else:
        if os.path.isfile(input) and input.lower().endswith((".pdf")):          
            iniciar_func(escolha,input, index=1, lista=1)
            arquivotxt.atualizar_arquivo("Tarefa Concluida")
            time.sleep(2)
            arquivotxt.limpar_arquivo()