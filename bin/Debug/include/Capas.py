import json, os, sys
from fpdf import FPDF
from pathlib import Path
from manipular import GerenciadorArquivo


class LayoutPDF(FPDF):
    def __init__(self):
        super().__init__()
        # 1) Registrar a família DejaVu (uni=True)
        self.add_font(
        family="DejaVuB",        # nome para usar no set_font
        style="",               # "", "B", "I" ou "BI"
        fname=os.path.join(os.getcwd(),"assets","font","DejaVuSansMNerdFont-Bold.ttf"), # caminho para o arquivo .ttf
        uni=True                # habilita Unicode
        )
        self.add_font(
        family="DejaVu",        # nome para usar no set_font
        style="",               # "", "B", "I" ou "BI"
        fname=os.path.join(os.getcwd(),"assets","font","DejaVuSansMNerdFont-Regular.ttf"), # caminho para o arquivo .ttf
        uni=True                # habilita Unicode
        )
        
        
    

    # def __init__(self):
    #     super().__init__()

    def header(self):
        # Linhas horizontais e verticais para ver a posição
        caminho = os.path.join(os.getcwd(),"assets","img",)
        self.set_line_width(0.1)
        self.set_fill_color(23, 54, 93) 
        self.rect(x=0, y=1.5, w=210, h=44 - 1.5, style='F')
        self.set_fill_color(23, 54, 93)  
        self.rect(x=0, y=265, w=210, h=296.5 - 265, style='F')
        self.image(caminho+'/imagem4.png', x=5, y=-1, w=3, h=300)
        self.image(caminho+'/imagem4.png', x=202, y=-1, w=3, h=300)
        self.image(caminho+'/imagem3.png', x=15, y=3.5, w=180, h=38)
        self.image(caminho+'/imagem2.png', x=18, y=15, w=29, h=14)
        self.image(caminho+'/imagem1.png', x=153, y=15, w=39, h=13.5)

    
        
    def add_layout_elements(self):
        # Área onde os textos ficarão
        x_area = 25       # posição X da área de texto
        y_area = 3.5       # posição Y da área (mesma da imagem1)
        largura = 150      # largura disponível
        altura_area = 38   # altura da área (altura da imagem1)

       

        # Textos a serem centralizados
        textos = [
            "ESTALEIRO NAVAL E BASE NAVAL - EBN",
            "ÁREA "+area,
            descri
        ]

        self.set_font("Arial", "B", size=12)
        self.set_text_color(23, 54, 93)

        altura_linha = 10
        altura_total_texto = len(textos) * altura_linha
        espacamento_vertical = (altura_area - altura_total_texto) / 2

        y_texto = y_area + espacamento_vertical
        
        for linha in textos:
            # Cálculo para centralizar horizontalmente
            largura_texto = self.get_string_width(linha)
            x_texto = x_area + (largura - largura_texto) / 2

            self.set_xy(x_texto, y_texto)
            self.cell(w=largura_texto, h=altura_linha, txt=linha, ln=1)
            y_texto += altura_linha

    def adicionar_categorias_sub(self, dados, x_inicio=20, y_inicio=60):
        # Define o ponto de partida
        self.set_xy(x_inicio, y_inicio)

        for categoria, lista_subcats in dados.items():
            # Categoria (fonte grande)
            self.set_x(x_inicio)
            self.set_font("Arial", "B", size= 18)
            self.set_text_color(31, 73, 125)
            self.cell(0, 10, categoria, ln=True)

            # Pequeno espaço antes das subcategorias
            self.ln(6)

            # Subcategorias (fonte média) com recuo
            for subcategoria in lista_subcats:
                self.set_x(x_inicio + 15)
                self.set_text_color(31, 73, 125)

                # Seta com DejaVu
                self.set_font("DejaVu", size=16)
                self.write(8, "➤  ")

                # Subcategoria com Arial
                self.set_font("Arial", size=16)
                self.multi_cell(w=0, h=8, txt=subcategoria)  # h=8 para espaçamento entre linhas internas

                self.ln(7)  # espaçamento entre subcategorias diferentes



            # Espaço extra antes da próxima categoria
            self.ln(6)

    
    def adicionar_categorias(self, dados, x_inicio=20, y_inicio=60):
        

        for categoria, lista_subcats in dados.items():
            # Categoria (fonte grande)
            self.add_page()
            self.add_layout_elements()
            self.set_xy(x_inicio, y_inicio)
            self.set_font("Arial","B", size= 18)
            self.set_text_color(31, 73, 125)
            self.cell(0, 10, categoria, ln=True) 

            self.ln(6)

            for subcategoria in lista_subcats:
                self.set_x(x_inicio + 15)
                self.set_text_color(31, 73, 125)

                # Seta com DejaVu
                self.set_font("DejaVu", size=16)
                self.write(8, "➤  ")

                # Subcategoria com Arial
                self.set_font("Arial", size=16)
                self.multi_cell(w=0, h=8, txt=subcategoria)  # h=8 para espaçamento entre linhas internas

                self.ln(7)  # espaçamento entre subcategorias diferentes

    def adicionar_SubCategoria(self, dados, x_inicio=20, y_inicio=60):
        

        for categoria, lista_subcats in dados.items():
            
            for subcategoria in lista_subcats:
                self.add_page()
                self.add_layout_elements()
                self.set_xy(x_inicio + 15, y_inicio)
                self.set_text_color(31, 73, 125)

                # Seta com DejaVu
                self.set_font("DejaVu", size=16)
                self.write(8, "➤  ")

                # Subcategoria com Arial
                self.set_font("Arial", size=16)
                self.multi_cell(w=0, h=8, txt=subcategoria)  # h=8 para espaçamento entre linhas internas

                self.ln(7)  # espaçamento entre subcategorias diferentes

    def itemApenas(self, dados, x_inicio=20, y_inicio=60):
        
        self.set_xy(x_inicio + 15, y_inicio)
        for categoria, lista_subcats in dados.items():
            
            for subcategoria in lista_subcats:
                self.set_x(x_inicio + 15)
                self.set_text_color(31, 73, 125)

                # Seta com DejaVu
                self.set_font("DejaVu", size=16)
                self.write(15, "➤  ")

                # Subcategoria com Arial
                self.set_font("Arial",size= 16)
                self.write(15, subcategoria)

                self.ln(15)


                    

    def draw_test_layout(self,escolha):
        with open("include/categorias.json", "r", encoding="utf-8") as f:
            dados = json.load(f)
        match(escolha):
            case 1:
                self.add_page()
                self.add_layout_elements()
                self.adicionar_categorias_sub(dados)
                self.adicionar_categorias(dados)
                self.adicionar_SubCategoria(dados)
            case 2:                
                self.adicionar_categorias(dados)
                self.adicionar_SubCategoria(dados)
            case 3:
                self.add_page()
                self.add_layout_elements()
                self.itemApenas(dados)
                self.adicionar_SubCategoria(dados)

def main():
    
    pasta = os.path.join(os.getcwd(),"out", "capas")
    pasta_destino = Path(pasta)
    pasta_destino.mkdir(parents=True, exist_ok=True)
    pdf = LayoutPDF()
    pdf.set_auto_page_break(auto=True, margin=15)
    pdf.draw_test_layout(escolha=modo)
    pdf.output(f"{pasta_destino}/Indices - Capas - Área {area}.pdf")

    arquivotxt.atualizar_arquivo("Tarefa Concluida")

arquivotxt = GerenciadorArquivo("include/log.txt")
area = sys.argv[1]
descri = sys.argv[2]
modo = int(sys.argv[3])
if __name__ == "__main__":
    main()
    
