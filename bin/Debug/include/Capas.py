import json, os, sys, time
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

    def adicionar_categorias_sub(self, dados,catLetra,subLetra,espCat,espsub1,espsub2, x_inicio=20, y_inicio=60):
        # Define o ponto de partida
        self.set_xy(x_inicio, y_inicio)

        for categoria, lista_subcats in dados.items():
            # Categoria (fonte grande)
            self.set_x(x_inicio)
            self.set_font("Arial", "B", size= catLetra)
            self.set_text_color(31, 73, 125)
            self.cell(0, 10, categoria, ln=True)

            # Pequeno espaço antes das subcategorias
            self.ln(espCat)

            # Subcategorias (fonte média) com recuo
            for subcategoria in lista_subcats:
                self.set_x(x_inicio + 15)
                self.set_text_color(31, 73, 125)

                # Seta com DejaVu
                self.set_font("DejaVu", size=subLetra)
                self.write(8, "➤  ")

                # Subcategoria com Arial
                self.set_font("Arial", size=subLetra)
                self.multi_cell(w=0, h=8, txt=subcategoria)  # h=8 para espaçamento entre linhas internas

                self.ln(espsub1)  # espaçamento entre subcategorias diferentes



            # Espaço extra antes da próxima categoria
            self.ln(espsub2)

    
    def adicionar_categorias(self, dados,catLetra,subLetra,espCat,espsub1, x_inicio=20, y_inicio=60):
        

        for categoria, lista_subcats in dados.items():
            # Categoria (fonte grande)
            self.add_page()
            self.add_layout_elements()
            self.set_xy(x_inicio, y_inicio)
            self.set_font("Arial","B", size= catLetra)
            self.set_text_color(31, 73, 125)
            self.cell(0, 10, categoria, ln=True) 

            self.ln(espCat)

            for subcategoria in lista_subcats:
                self.set_x(x_inicio + 15)
                self.set_text_color(31, 73, 125)

                # Seta com DejaVu
                self.set_font("DejaVu", size=subLetra)
                self.write(8, "➤  ")

                # Subcategoria com Arial
                self.set_font("Arial", size=subLetra)
                self.multi_cell(w=0, h=8, txt=subcategoria)  # h=8 para espaçamento entre linhas internas

                self.ln(espsub1)  # espaçamento entre subcategorias diferentes

    def adicionar_SubCategoria(self, dados,subLetra,espsub1, x_inicio=20, y_inicio=60):
        

        for categoria, lista_subcats in dados.items():
            
            for subcategoria in lista_subcats:
                self.add_page()
                self.add_layout_elements()
                self.set_xy(x_inicio + 15, y_inicio)
                self.set_text_color(31, 73, 125)

                # Seta com DejaVu
                self.set_font("DejaVu", size=subLetra)
                self.write(8, "➤  ")

                # Subcategoria com Arial
                self.set_font("Arial", size=subLetra)
                self.multi_cell(w=0, h=8, txt=subcategoria)  # h=8 para espaçamento entre linhas internas

                self.ln(espsub1)  # espaçamento entre subcategorias diferentes

    def itemApenas(self, dados,subLetra,espsub1, x_inicio=20, y_inicio=60):
        
        self.set_xy(x_inicio + 15, y_inicio)
        for categoria, lista_subcats in dados.items():
            
            for subcategoria in lista_subcats:
                self.set_x(x_inicio + 15)
                self.set_text_color(31, 73, 125)

                # Seta com DejaVu
                self.set_font("DejaVu", size=subLetra)
                self.write(8, "➤  ")

                # Subcategoria com Arial
                self.set_font("Arial",size= subLetra)
                self.multi_cell(w=0, h=8, txt=subcategoria)

                self.ln(espsub1)

    def fornecedores(self, dados, letraFornecedor,  y_inicio=110):
        for categoria, lista in dados.items():
            for item in lista:
                self.add_page()
                self.add_layout_elements()
                # self.set_xy(x_inicio, y_inicio)
                self.set_text_color(31, 73, 125)
                self.set_font("Arial", "B", size=letraFornecedor)
                
                
                # Texto completo
                
                texto = f"FORNECEDOR: {item}".strip()

                # Calcula largura do texto
                cell_width = self.get_string_width(texto) + 4  # margem extra
                page_width = self.w
                x_centralizado = (page_width - cell_width) / 2

                # Define posição e escreve em uma única linha
                self.set_xy(x_centralizado, y_inicio)
                
                self.cell(w=cell_width, h=12, txt=categoria, border=0, ln=0, align='C')

                self.set_xy(x_centralizado, y_inicio+12)
                self.cell(w=cell_width, h=12, txt=texto, border=0, ln=0, align='C')
        
        self.add_page()
        self.add_layout_elements()
        # self.set_xy(x_inicio, y_inicio)
        self.set_text_color(31, 73, 125)
        self.set_font("Arial", "B", size=letraFornecedor)
        
        dec = "DECLÍNIOS"
        cell_width = self.get_string_width(dec) + 4  # margem extra
        page_width = self.w
        x_centralizado = (page_width - cell_width) / 2
        # Define posição e escreve em uma única linha
        self.set_xy(x_centralizado, y_inicio)
        self.cell(w=cell_width, h=12, txt=dec, border=0, ln=0, align='C')            

    def draw_test_layout(self,escolha):
        with open("include/categorias.json", "r", encoding="utf-8") as f:
            dados = json.load(f)
        
        with open("config.json", "r", encoding="utf-8") as f:
            configPDF = json.load(f)
            config = configPDF["PDF"]
            
        cls = int(config["Cat_letra_Size"])
        sls = int(config["Sub_letra_Size"])
        fls = int(config["Fornecedor_letra_Size"])
        ces = int(config["Cat_Espa_Size"])
        ses1 =int(config["Sub1_Espa_Size"])
        ses2 = int(config["Sub2_Espa_Size"])
        
        match(escolha):
            case 1:
                arquivotxt.atualizar_arquivo("Gerando Índices Técnico e Comercial")
                self.add_page()
                self.add_layout_elements()
                self.adicionar_categorias_sub(dados, catLetra=cls,subLetra=sls,espCat=ces,espsub1=ses1,espsub2=ses2)
                self.adicionar_categorias(dados,catLetra=cls,subLetra=sls,espCat=ces,espsub1=ses1)
                self.adicionar_SubCategoria(dados,subLetra=sls,espsub1=ses1)
                
            case 2:                
                arquivotxt.atualizar_arquivo("Gerando Índices")
                self.adicionar_categorias(dados,catLetra=cls,subLetra=sls,espCat=ces,espsub1=ses1)
                self.adicionar_SubCategoria(dados,subLetra=sls,espsub1=ses1)
            case 4:
                arquivotxt.atualizar_arquivo("Gerando Índices Simples")
                self.add_page()
                self.add_layout_elements()
                self.itemApenas(dados,subLetra=sls,espsub1=ses1)
                self.adicionar_SubCategoria(dados,subLetra=sls,espsub1=ses1)
            case 3:
                arquivotxt.atualizar_arquivo("Gerando Capas do Fornecedor")
                self.fornecedores(dados,letraFornecedor=fls)   

def main():
    with open("config.json", "r", encoding="utf-8") as f:
            configSalvar = json.load(f)
            config = configSalvar["Salvar"]
    caminho = config["SalvarCapas"]
    pasta = os.path.join(os.getcwd(),caminho)
    pasta_destino = Path(pasta)
    pasta_destino.mkdir(parents=True, exist_ok=True)
    pdf = LayoutPDF()
    pdf.set_auto_page_break(auto=True, margin=15)
    pdf.draw_test_layout(escolha=modo)
    pdf.output(f"{pasta_destino}/Indices - Capas - Área {area}.pdf")

    arquivotxt.atualizar_arquivo(f"Arquivos Referentes à {area} Gerados")
    time.sleep(2)
    arquivotxt.atualizar_arquivo("Tarefa Concluida")
    time.sleep(2)
    arquivotxt.limpar_arquivo()

arquivotxt = GerenciadorArquivo("include/log.txt")
area = sys.argv[1]
descri = sys.argv[2]
modo = int(sys.argv[3])
if __name__ == "__main__":
    main()
    
