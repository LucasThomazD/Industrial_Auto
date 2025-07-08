import os,time,win32com.client,sys,json
from manipular import GerenciadorArquivo

sys.path.append(os.path.join(os.path.dirname(__file__), "../libs"))

with open("include/layouts_papel.json", "r", encoding="utf-8") as arquivo:
    layouts = json.load(arquivo)
    
def obter_nome_saida(caminho_arquivo):
    """Retorna o nome do arquivo original (sem extensão) na pasta ./out/Excel_PDF."""
    nome_base = os.path.splitext(os.path.basename(caminho_arquivo))[0]
    return os.path.join(os.getcwd(), "out", "Imprimir", f"{nome_base}.pdf") 
    
def gerarPDF(arquivo_excel, config):
    # Obter o caminho de saída do PDF a partir do arquivo Excel
    arquivo_pdf = obter_nome_saida(arquivo_excel)
        
        
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
    wb.ExportAsFixedFormat(0, arquivo_pdf)

    # Fechar tudo
    wb.Close(False)
    excel.Quit()
    # Envia mensagem para a Named Pipe ao concluir o processamento
        
        
    return arquivo_pdf

# def timbrado():
    

layout_escolhido = sys.argv[1]
entrada = sys.argv[3]
config = layouts[layout_escolhido]
arquivotxt = GerenciadorArquivo("include/log.txt")

if os.path.isdir(entrada):
    # Se for diretório, percorre todos os arquivos Excel dentro dele
    itens = os.listdir(entrada)
    total_itens = len(itens)
    for indice, item in enumerate(itens, start=1):  # Itera sobre os itens com índice
        caminho_item = os.path.join(entrada, item)
        if os.path.isfile(caminho_item) and caminho_item.lower().endswith((".xlsx", ".xls")):
            # Atualiza o progresso e processa o arquivo
            arquivotxt.atualizar_arquivo(f"Convertendo Arquivo Excel {indice} de {total_itens}: {item}")
            gerarPDF(caminho_item, config)
    arquivotxt.atualizar_arquivo(f"{total_itens} Arquivos Convertidos!")
    time.sleep(3)
    arquivotxt.atualizar_arquivo("Tarefa Concluida")
    time.sleep(2)
    arquivotxt.limpar_arquivo()
else:
    # Se for um arquivo único, processa ele mesmo
    if os.path.isfile(entrada) and entrada.lower().endswith((".xlsx", ".xls")):
        arquivotxt.atualizar_arquivo(f"Convertendo Arquivo Excel: {entrada}")
        gerarPDF(entrada, config)
        arquivotxt.atualizar_arquivo("Tarefa Concluida")
        time.sleep(2)
        arquivotxt.limpar_arquivo()