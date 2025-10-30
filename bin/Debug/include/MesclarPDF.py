import os, sys, time
from manipular import *
from pypdf import PdfWriter


def unir_pdfs(pasta, nome_saida):

    if not pasta:
        arquivotxt.atualizar_arquivo("Pasta não Selecionada")
    
    merger = PdfWriter()
    arquivos_pdf = [f for f in os.listdir(pasta) if f.lower().endswith(".pdf")]
    #arquivos_pdf.sort()
    contador = len(arquivos_pdf)
    arquivotxt.atualizar_arquivo(f"Unificando {contador} Arquivos")
    if not arquivos_pdf:
        arquivotxt.atualizar_arquivo("Sem arquivo PDF na pasta")
        return
    
    for arquivo in arquivos_pdf:
        caminho_pdf = os.path.join(pasta, arquivo)
        merger.append(caminho_pdf)
    
    caminho_saida = os.path.join(pasta, nome_saida + ".pdf")
    merger.write(caminho_saida)
    merger.close()
    time.sleep(1)
    arquivotxt.atualizar_arquivo("Tarefa Concluida")
    time.sleep(3)
    arquivotxt.limpar_arquivo()

nomear = sys.argv[2]
    
arquivotxt = GerenciadorArquivo("include/log.txt")
if __name__ == "__main__":
    pasta_selecionada = sys.argv[1]
    unir_pdfs(pasta_selecionada, nomear)
