from Excel_macros import *
import win32com.client

def fornecimento():
    # Abre o Excel
    excel = win32com.client.Dispatch("Excel.Application")
    excel.Visible = False  # True se quiser ver a execução

    # Lê o conteúdo da macro
    vba_code = macros.fornecimento(area=2000,ta1=31,ta2=33)

    # Cria um novo arquivo em branco
    wb = excel.Workbooks.Add()

  
    # Adiciona módulo e insere código
    vb_module = wb.VBProject.VBComponents.Add(1)  # 1 = módulo padrão
    vb_module.CodeModule.AddFromString(vba_code)

    # Executa macro
    excel.Application.Run("ComparativoCpuArea")

    # Fecha sem salvar (arquivo é descartado)
    wb.Close(SaveChanges=False)
    excel.Quit()

fornecimento()