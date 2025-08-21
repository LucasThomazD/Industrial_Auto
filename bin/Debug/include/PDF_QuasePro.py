import PyPDF2, sys, os, time
from manipular import GerenciadorArquivo

sys.path.append(os.path.join(os.path.dirname(__file__), "../libs"))

class alterar_pag:
    def remover_pagina(pdf_entrada, pdf_saida, pagina_remover):
        with open(pdf_entrada, "rb") as arquivo:
            leitor_pdf = PyPDF2.PdfReader(arquivo)
            escritor_pdf = PyPDF2.PdfWriter()

            # Adiciona todas as páginas, exceto a que deve ser removida
            for i in range(len(leitor_pdf.pages)):
                if i != pagina_remover - 1:  # Índice começa em 0
                    escritor_pdf.add_page(leitor_pdf.pages[i])

            with open(pdf_saida, "wb") as arquivo_saida:
                escritor_pdf.write(arquivo_saida)

            arquivotxt.atualizar_arquivo("Atualizando PDF")
            time.sleep(3)
            arquivotxt.atualizar_arquivo("Tarefa Concluida")
            time.sleep(2.5)
            arquivotxt.limpar_arquivo()

    def inserir_pdf(base_pdf, inserir_pdf, posicao, antes=True):
        
        # Abrindo os arquivos PDF
        with open(base_pdf, "rb") as base, open(inserir_pdf, "rb") as inserir:
            base_reader = PyPDF2.PdfReader(base)
            inserir_reader = PyPDF2.PdfReader(inserir)
            writer = PyPDF2.PdfWriter()

            # Adicionando páginas antes ou depois da posição especificada
            for i in range(len(base_reader.pages)):
                if i == posicao - 1 and antes:  # Inserir antes da posição
                    for page in inserir_reader.pages:
                        writer.add_page(page)
                writer.add_page(base_reader.pages[i])
                if i == posicao - 1 and not antes:  # Inserir depois da posição
                    for page in inserir_reader.pages:
                        writer.add_page(page)

            output_pdf = os.path.join(base_pdf) # Adiciona um sufixo ao nome original

            # Salvando o novo PDF
            with open(output_pdf, "wb") as output:
                writer.write(output)
            arquivotxt.atualizar_arquivo("Atualizando PDF")
            time.sleep(3)
            arquivotxt.atualizar_arquivo("Tarefa Concluida")
            time.sleep(2.5)
            arquivotxt.limpar_arquivo()

    def copiar_pagina(pdf_entrada, pagina_remover):
        with open(pdf_entrada, "rb") as arquivo:
            leitor_pdf = PyPDF2.PdfReader(arquivo)
            escritor_pdf = PyPDF2.PdfWriter()

            # Ajustando índice para começar em 0
            pagina = pagina_remover - 1

            if 0 <= pagina < len(leitor_pdf.pages):
                escritor_pdf.add_page(leitor_pdf.pages[pagina])

                nome_base, extensao = os.path.splitext(pdf_entrada)
                nome_saida = f"{nome_base}_pagina_{pagina_remover}{extensao}"

                with open(nome_saida, "wb") as arquivo_saida:
                    escritor_pdf.write(arquivo_saida)
                arquivotxt.atualizar_arquivo("Atualizando PDF")
                time.sleep(3)
                arquivotxt.atualizar_arquivo("Tarefa Concluida")
                time.sleep(2.5)
                arquivotxt.limpar_arquivo()
                
            else:
                arquivotxt.atualizar_arquivo("Atualizando PDF")
                time.sleep(3)
                arquivotxt.atualizar_arquivo("Tarefa Concluida")
                time.sleep(2.5)
                arquivotxt.limpar_arquivo()
    
    
    def rotacionar_pdf(pdf_entrada, pdf_saida,  pagina_especifica=None, graus = 90, sentido="horario"):
        with open(pdf_entrada, "rb") as arquivo:
            leitor_pdf = PyPDF2.PdfReader(arquivo)
            escritor_pdf = PyPDF2.PdfWriter()

            # Ajustando o sentido da rotação
            if sentido.lower() == "horario":
                rotacao = graus  # Rotacionar para a direita
            else:
                rotacao = -graus  # Rotacionar para a esquerda

            # Rotacionando as páginas
            for i in range(len(leitor_pdf.pages)):
                pagina = leitor_pdf.pages[i]
                
                if pagina_especifica is None or i == pagina_especifica - 1:  # Todas ou uma específica
                    pagina.rotate(rotacao)
                
                escritor_pdf.add_page(pagina)

            saida = os.path.join(pdf_saida)
            # Salvando o PDF rotacionado
            with open(saida, "wb") as arquivo_saida:
                escritor_pdf.write(arquivo_saida)
            arquivotxt.atualizar_arquivo("Página Inválida")
            time.sleep(3)
            arquivotxt.atualizar_arquivo("Atualizando PDF")
            time.sleep(3)
            arquivotxt.atualizar_arquivo("Tarefa Concluida")
            time.sleep(2.5)
            arquivotxt.limpar_arquivo()

                


arquivotxt = GerenciadorArquivo("include/log.txt")


