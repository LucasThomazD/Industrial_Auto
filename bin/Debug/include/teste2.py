# import os, sys, PyPDF2, time
# from manipular import *
# from pypdf import PdfMerger


# def unir_pdfs(pasta, nome_saida="PDF_Unificado.pdf"):

#     if not pasta:
#         arquivotxt.atualizar_arquivo("Pasta não Selecionada")
    
#     merger = PyPDF2.PdfMerger()
#     arquivos_pdf = [f for f in os.listdir(pasta) if f.lower().endswith(".pdf")]
#     arquivos_pdf.sort()
#     contador = len(arquivos_pdf)
#     arquivotxt.atualizar_arquivo(f"Unificando {contador} Arquivos")
#     if not arquivos_pdf:
#         arquivotxt.atualizar_arquivo("Sem arquivo PDF na pasta")
#         return
    
#     for arquivo in arquivos_pdf:
#         caminho_pdf = os.path.join(pasta, arquivo)
#         merger.append(caminho_pdf)
    
#     caminho_saida = os.path.join(pasta, nome_saida)
#     merger.write(caminho_saida)
#     merger.close()
#     time.sleep(1)
#     arquivotxt.atualizar_arquivo("Tarefa Concluida")
#     time.sleep(3)
#     arquivotxt.limpar_arquivo()
    
# arquivotxt = GerenciadorArquivo("include/log.txt")
# if __name__ == "__main__":
#     pasta_selecionada = sys.argv[1]
#     unir_pdfs(pasta_selecionada)
from fpdf import FPDF


class PDF(FPDF):
    def header(self):
        # Rendering logo:
        self.image(r"C:\Users\lucasduarte\source\repos\Orçamento_Industrial\windowsFormOI\bin\Debug\assets\img\Imagem2.png", 10, 8, 33)
        # Setting font: helvetica bold 15
        self.set_font("helvetica", style="B", size=15)
        # Moving cursor to the right:
        self.cell(80)
        # Printing title:
        self.cell(30, 10, "Title", border=1, align="C")
        # Performing a line break:
        self.ln(20)

    def footer(self):
        # Position cursor at 1.5 cm from bottom:
        self.set_y(-15)
        # Setting font: helvetica italic 8
        self.set_font("helvetica", style="I", size=8)
        # Printing page number:
        self.cell(0, 10, f"Page {self.page_no()}/{{nb}}", align="C")


# Instantiation of inherited class
pdf = PDF()
pdf.add_page()
pdf.set_font("Times", size=12)
for i in range(1, 41):
    pdf.cell(0, 10, f"Printing line number {i}", new_x="LMARGIN", new_y="NEXT")
pdf.output("new-tuto2.pdf")