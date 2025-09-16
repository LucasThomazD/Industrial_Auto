import os

class macros :
    def fornecimento(area,ta1,ta2):
        arquivo = os.getcwd()
        caminho = arquivo + "\.."
        forn = f"""
Sub ComparativoCpuArea()
    Dim arquivo1 As Variant, arquivo2 As Variant
    Dim wb1 As Workbook, wb2 As Workbook
    Dim ws1 As Worksheet, ws2 As Worksheet
    Dim novaAba1 As Worksheet, novaAba2 As Worksheet
    Dim abaNomes As Worksheet
    Dim caminhoInicial As String
    ' Desabilitar atualização de tela, cálculo e eventos
    Application.ScreenUpdating = False
    Application.Calculation = xlCalculationManual
    Application.EnableEvents = False
    Application.DisplayAlerts = False
    
    caminhoInicial = "C:/Users/lucasduarte/source/repos/Orçamento_Industrial/windowsFormOI/bin/Debug"
    ' Abre a caixa de diálogo para seleção do arquivo
    ChDrive Left(caminhoInicial, 1) ' Define o drive (ex.: C:)
    ChDir caminhoInicial ' Define o diretório
    ' Solicitar arquivos
    arquivo1 = Application.GetOpenFilename(FileFilter:="Arquivos Excel (*.xls*), *.xls*", Title:="Selecione o primeiro arquivo Excel")
    If arquivo1 = False Then
        MsgBox "Nenhum arquivo selecionado.", vbCritical
        Exit Sub
    End If
    

    arquivo2 = Application.GetOpenFilename(FileFilter:="Arquivos Excel (*.xls*), *.xls*", Title:="Selecione o segundo arquivo Excel")
    If arquivo2 = False Then
        MsgBox "Nenhum arquivo selecionado.", vbCritical
        Exit Sub
    End If
     On Error Resume Next
     
    Worksheets("Consolidado CPU").Delete
    Worksheets("Dados do Arquivo 1").Delete
    Worksheets("Dados do Arquivo 2").Delete

    On Error GoTo 0
    ' Criar uma nova aba para armazenar os nomes dos arquivos
    Set abaNomes = ThisWorkbook.Sheets.Add(After:=ThisWorkbook.Sheets(ThisWorkbook.Sheets.Count))
    abaNomes.Name = "Consolidado CPU"
    abaNomes.Cells(1, 20).Value = Dir(arquivo1) ' Nome do arquivo 1 na célula A1
    abaNomes.Cells(1, 21).Value = Dir(arquivo2) ' Nome do arquivo 2 na célula B1

    ' Abrir arquivos
    Set wb1 = Workbooks.Open(arquivo1)
    Set ws1 = wb1.Sheets(1)
    Set wb2 = Workbooks.Open(arquivo2)
    Set ws2 = wb2.Sheets(1)

    ' Criar novas abas para copiar os dados
    Set novaAba1 = ThisWorkbook.Sheets.Add(After:=ThisWorkbook.Sheets(ThisWorkbook.Sheets.Count))
    novaAba1.Name = "Dados do Arquivo 1"
    Set novaAba2 = ThisWorkbook.Sheets.Add(After:=ThisWorkbook.Sheets(ThisWorkbook.Sheets.Count))
    novaAba2.Name = "Dados do Arquivo 2"

    ' Copiar valores a partir da 9ª linha para as novas abas
    ws1.Rows("9:" & ws1.Rows.Count).Copy
    novaAba1.Cells.PasteSpecial xlPasteValues
    ws2.Rows("9:" & ws2.Rows.Count).Copy
    novaAba2.Cells.PasteSpecial xlPasteValues

    ' Fechar arquivos
    wb1.Close SaveChanges:=False
    wb2.Close SaveChanges:=False

    ' Limpar objetos
    Set wb1 = Nothing
    Set ws1 = Nothing
    Set wb2 = Nothing
    Set ws2 = Nothing
    Set novaAba1 = Nothing
    Set novaAba2 = Nothing
    Set abaNomes = Nothing

    ' Tempo de espera de 20 segundos
    'Application.Wait Now + TimeValue("00:00:20")
   ' UserForm2.Show
    ' Executar macros adicionais
    Call filtro01 ' Rodar a macro filtro01 para o primeiro arquivo
    Call filtro02 ' Rodar a macro filtro02 para o segundo arquivo
    'Application.Wait Now + TimeValue("00:00:20")
    Call FiltrarStep01
    
    
    ' Reativar atualização de tela, cálculo e eventos
    Application.ScreenUpdating = True
    Application.Calculation = xlCalculationAutomatic
    Application.EnableEvents = True
    Application.DisplayAlerts = True
    ' Código específico para a Função 1
End Sub

Sub filtro01()

    On Error GoTo ErrorHandler

    Dim ultimaLinha As Long
    Dim ultimaLinhaM As Long
    Dim cel As Range
    Dim i As Long
    
    With Sheets("Dados do Arquivo 1")

        ' Determinar a última linha da coluna E
        ultimaLinha = .Cells(Rows.Count, "E").End(xlUp).Row

        ' Aplicar filtro para "Serviços de Engenharia" na coluna E
        .Range("A1:E" & ultimaLinha).AutoFilter Field:=5, Criteria1:="Serviços de Engenharia"

        ' Inserir fórmulas na coluna M para células visíveis
        For Each cel In .Range("M2:M" & ultimaLinha).SpecialCells(xlCellTypeVisible)
            cel.FormulaR1C1 = "=RC[-10]"  ' Referência relativa à coluna C
        Next cel

        ' Remover o filtro
        .AutoFilterMode = False

        ' Determinar a última linha da coluna M
        'ultimaLinhaM = .Cells(.Rows.Count, "M").End(xlUp).Row

        ' Preencher células vazias na coluna M
        For i = 3 To ultimaLinha
            If IsEmpty(.Cells(i, "M").Value) Then
                If Not IsEmpty(.Cells(i - 1, "M").Value) Then
                    .Cells(i, "M").Formula = "=M" & i - 1
                End If
            End If
        Next i

        ' Deletar linhas a partir da linha 4 que estejam em branco na coluna M
        For i = ultimaLinhaM To 4 Step -1 ' Iteração de baixo para cima
            If IsEmpty(.Cells(i, "M").Value) Then
                .Rows(i).Delete
            End If
        Next i

        ' Concatenar os valores das colunas B e M na coluna N
        ultimaLinhaM = .Cells(.Rows.Count, "M").End(xlUp).Row ' Atualizar a última linha após deleção
        For i = 4 To ultimaLinhaM
            .Cells(i, "N").Value = .Cells(i, "B").Value & " / " & .Cells(i, "M").Value
        Next i

         ' Deletar linhas onde a coluna M não contém "fornecimento"
        For i = ultimaLinhaM To 2 Step -1 ' Iteração de baixo para cima
            If InStr(1, .Cells(i, "M").Value, "fornecimento", vbTextCompare) = 0 Then
                .Rows(i).Delete
            End If
        
        Next i
    End With
    
    Call CopiarColarApenasValores1
    Call deletarVazioB1
    
    Exit Sub

ErrorHandler:
    MsgBox "An error occurred."
End Sub

Private Sub deletarVazioB1()

    Dim ws As Worksheet
    Dim ultimaLinha As Long
    Dim i As Long

    ' Definir a aba "dados arquivo 1"
    Set ws = ThisWorkbook.Sheets("Dados do Arquivo 1")

    ' Identificar a última linha preenchida na coluna A (ou outra referência relevante)
    ultimaLinha = ws.Cells(ws.Rows.Count, 1).End(xlUp).Row

    ' Percorrer as linhas de baixo para cima
    For i = ultimaLinha To 1 Step -1
        ' Verificar se a célula na coluna B está vazia
        If Trim(ws.Cells(i, "B").Value) = "" Then
            ' Excluir a linha
            ws.Rows(i).Delete
        End If
    Next i


End Sub


Private Sub CopiarColarApenasValores1()
    Dim ws As Worksheet
    Set ws = ThisWorkbook.Sheets("Dados do Arquivo 1") ' Certifique-se de usar o mesmo nome da aba

    ws.UsedRange.Copy
    ws.UsedRange.PasteSpecial Paste:=xlPasteValues

    ' Limpar a seleção de cópia
    Application.CutCopyMode = False

End Sub



Sub filtro02()

    On Error GoTo ErrorHandler

    Dim ultimaLinha As Long
    Dim ultimaLinhaM As Long
    Dim cel As Range
    Dim i As Long

    With Sheets("Dados do Arquivo 2")

        ' Determinar a última linha da coluna E
        ultimaLinha = .Cells(Rows.Count, "E").End(xlUp).Row

        ' Aplicar filtro para "Serviços de Engenharia" na coluna E
        .Range("A1:E" & ultimaLinha).AutoFilter Field:=5, Criteria1:="Serviços de Engenharia"

        ' Inserir fórmulas na coluna M para células visíveis
        For Each cel In .Range("M2:M" & ultimaLinha).SpecialCells(xlCellTypeVisible)
            cel.FormulaR1C1 = "=RC[-10]"  ' Referência relativa à coluna C
        Next cel

        ' Remover o filtro
        .AutoFilterMode = False

        ' Determinar a última linha da coluna M
        ultimaLinhaM = .Cells(.Rows.Count, "M").End(xlUp).Row

        ' Preencher células vazias na coluna M
        For i = 3 To ultimaLinha
            If IsEmpty(.Cells(i, "M").Value) Then
                If Not IsEmpty(.Cells(i - 1, "M").Value) Then
                    .Cells(i, "M").Formula = "=M" & i - 1
                End If
            End If
        Next i

        ' Deletar linhas a partir da linha 4 que estejam em branco na coluna M
        For i = ultimaLinhaM To 4 Step -1 ' Iteração de baixo para cima
            If IsEmpty(.Cells(i, "M").Value) Then
                .Rows(i).Delete
            End If
        Next i

        ' Concatenar os valores das colunas B e M na coluna N
        ultimaLinhaM = .Cells(.Rows.Count, "M").End(xlUp).Row ' Atualizar a última linha após deleção
        For i = 4 To ultimaLinhaM
            .Cells(i, "N").Value = .Cells(i, "B").Value & " / " & .Cells(i, "M").Value
        Next i

         ' Deletar linhas onde a coluna M não contém "fornecimento"
        For i = ultimaLinhaM To 2 Step -1 ' Iteração de baixo para cima
            If InStr(1, .Cells(i, "M").Value, "fornecimento", vbTextCompare) = 0 Then
                .Rows(i).Delete
            End If
        Next i
    End With
    
    Call CopiarColarApenasValores2
    Call deletarVazioB2
    
    Exit Sub

ErrorHandler:
    MsgBox "An error occurred."
End Sub


Private Sub deletarVazioB2()

    Dim ws As Worksheet
    Dim ultimaLinha As Long
    Dim i As Long

    ' Definir a aba "dados arquivo 2"
    Set ws = ThisWorkbook.Sheets("Dados do Arquivo 2")

    ' Identificar a última linha preenchida na coluna A (ou outra referência relevante)
    ultimaLinha = ws.Cells(ws.Rows.Count, 1).End(xlUp).Row

    ' Percorrer as linhas de baixo para cima
    For i = ultimaLinha To 1 Step -1
        ' Verificar se a célula na coluna B está vazia
        If Trim(ws.Cells(i, "B").Value) = "" Then
            ' Excluir a linha
            ws.Rows(i).Delete
        End If
    Next i


End Sub


Private Sub CopiarColarApenasValores2()
    Dim ws As Worksheet
    Set ws = ThisWorkbook.Sheets("Dados do Arquivo 2") ' Certifique-se de usar o mesmo nome da aba

    ws.UsedRange.Copy
    ws.UsedRange.PasteSpecial Paste:=xlPasteValues

    ' Limpar a seleção de cópia
    Application.CutCopyMode = False

End Sub

Sub FiltrarStep01()
    Dim wsConsolidado As Worksheet
    Dim wsDados1 As Worksheet
    Dim wsDados2 As Worksheet
    Dim lastRowConsolidado As Long
    Dim lastRowDados1 As Long
    Dim lastRowDados2 As Long
    Dim i As Long
    Dim j As Long
    Dim rng As Range
    Dim rng3 As Range
    Dim rng2 As Range
    Dim rng4 As Range
    Dim cor1 As Range
    Dim cor2 As Range
    Dim cor3 As Range
    Dim cor4 As Range
    Dim cor5 As Range
    Dim cor6 As Range
    Dim ultimaLinha As Long
    Dim pastaArquivo As String
    Dim imagemCaminhoOEC As String
    Dim imagemCaminhoMB As String
    Dim imagemOEC As Object
    Dim imagemMB As Object
    Dim contb As String
    Dim area As String
    Dim ta1 As String
    Dim Ta2 As String
    Dim textoConcatenado As String
    
    
    
    imagemCaminhoOEC = "{caminho}" & "\\assets\\img\\imagem1.png"
    imagemCaminhoMB = "{caminho}" & "\\assets\\img\\imagem2.png"

    
    ' Define as planilhas
    Set wsConsolidado = ThisWorkbook.Worksheets("Consolidado CPU")
    Set wsDados1 = ThisWorkbook.Worksheets("Dados do Arquivo 1")
    Set wsDados2 = ThisWorkbook.Worksheets("Dados do Arquivo 2")
    
    ' Encontra a última linha da coluna N em ambas as abas de dados
    lastRowDados1 = wsDados1.Cells(wsDados1.Rows.Count, "N").End(xlUp).Row
    lastRowDados2 = wsDados2.Cells(wsDados2.Rows.Count, "N").End(xlUp).Row
    
    ' Começa a colar na linha 3 da coluna A da aba Consolidado CPU
    j = 4
    
    ' Copia os dados da coluna N da aba "dados do arquivo 1" para a aba "Consolidado CPU"
    For i = 2 To lastRowDados1 ' Começa na linha 2, assumindo que a linha 1 é o cabeçalho
        wsConsolidado.Cells(j, 15).Value = wsDados1.Cells(i, "N").Value
        j = j + 1
    Next i
    
    ' Copia os dados da coluna N da aba "dados do arquivo 2" para a aba "Consolidado CPU"
    For i = 2 To lastRowDados2 ' Começa na linha 2, assumindo que a linha 1 é o cabeçalho
        wsConsolidado.Cells(j, 15).Value = wsDados2.Cells(i, "N").Value
        j = j + 1
    Next i



    ' Remove as linhas vazias na coluna A, a partir da linha 3
    For i = lastRowConsolidado To 4 Step -1
        If IsEmpty(wsConsolidado.Cells(i, 15)) Then
            wsConsolidado.Rows(i).Delete
        End If
    Next i
    
    Call RemoverDuplicadosColunaO
    
    ' Atualiza a última linha após as remoções
    lastRowConsolidado = wsConsolidado.Cells(wsConsolidado.Rows.Count, "O").End(xlUp).Row
    
    ultimaLinha = wsConsolidado.Cells(Rows.Count, 1).End(xlUp).Row
    ultimaColuna = wsConsolidado.Cells(1, Columns.Count).End(xlToLeft).Column
    
    
    '--------------
    
    area = {area}
    ta1 = {ta1}
    Ta2 = {ta2}
   ' textoConcatenado = "COMPARATIVO" & Chr(10) & "REDES INDUSTRIAIS - Área " & area & Chr(10) & ta1 & " X " & ta2
    
    ' Aplica bordas finas verticais e pontilhadas horizontais nas colunas A a N
    
    '----------------------Colunas A-C-------------------
    Set rng = wsConsolidado.Range("A3:C" & lastRowConsolidado)
    With rng.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .Weight = xlMedium
    End With
    
    Set cor1 = wsConsolidado.Range("A3:C3")
    cor1.Interior.Color = RGB(189, 215, 238)
    cor1.Cells(1, 1).Value = "Descrição"
    cor1.Cells(1, 2).Value = "Cod. Engenharia"
    cor1.Cells(1, 3).Value = "Uni."
    
     
    
   '-------------------Colunas E-G---------------------
    Set rng2 = wsConsolidado.Range("E2:G" & lastRowConsolidado)
    With rng2.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng2.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng2.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng2.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng2.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng2.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    
    Set cor2 = wsConsolidado.Range("E3:G3")
    cor2.Interior.Color = RGB(189, 215, 238)
    cor2.Cells(1, 1).Value = "Quantidade"
    cor2.Cells(1, 2).Value = "Preço Unitário "
    cor2.Cells(1, 3).Value = "Preço Total"
    
    
    Set cor4 = wsConsolidado.Range("E2:G2")
    cor4.Interior.Color = RGB(31, 78, 120)
    
    wsConsolidado.Range("E2").Value = ta1 & " (MAI/12)"
    With wsConsolidado.Range("E2:G2")
        .HorizontalAlignment = xlCenterAcrossSelection ' Centraliza o texto horizontalmente
        .VerticalAlignment = xlCenter   ' Centraliza o texto verticalmente
    End With
    
    wsConsolidado.Range("F3").WrapText = True
    '------------------colunas I-K ----------------------
    Set rng3 = wsConsolidado.Range("I2:K" & lastRowConsolidado)
    With rng3.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng3.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng3.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng3.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng3.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng3.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    
    Set cor3 = wsConsolidado.Range("I3:K3")
    cor3.Interior.Color = RGB(189, 215, 238)
    cor3.Cells(1, 1).Value = "Quantidade"
    cor3.Cells(1, 2).Value = "Preço Unitário "
    cor3.Cells(1, 3).Value = "Preço Total"
    
    Set cor5 = wsConsolidado.Range("I2:K2")
    cor5.Interior.Color = RGB(31, 78, 120)
    
    wsConsolidado.Range("I2").Value = Ta2 & " (MAI/12)"
  
    
    With wsConsolidado.Range("I2:K2")
        .HorizontalAlignment = xlCenterAcrossSelection ' Centraliza o texto horizontalmente
        .VerticalAlignment = xlCenter   ' Centraliza o texto verticalmente
    End With
    
    wsConsolidado.Range("J3").WrapText = True
    '----------------------------Coluna M ---------------------------------------
    Set rng4 = wsConsolidado.Range("M2:M" & lastRowConsolidado)
    With rng4.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng4.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng4.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng4.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng4.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng4.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    
    Set cor3 = wsConsolidado.Range("M3")
    cor3.Interior.Color = RGB(189, 215, 238)
    cor3.Cells(1, 1).Value = "Variação Quantidade"
    wsConsolidado.Range("M2").Value = ta1 & " X " & Ta2 & Chr(10) & "(MAI/12)"
    
    Set cor6 = wsConsolidado.Range("M2")
    cor6.Interior.Color = RGB(31, 78, 120)
    
    With wsConsolidado.Range("M2")
        .HorizontalAlignment = xlCenter ' Centraliza o texto horizontalmente
        .VerticalAlignment = xlCenter   ' Centraliza o texto verticalmente
    End With
    
'--------------------------------------------------------------------------
    'dando merge na primeira linha
     With wsConsolidado.Range("A1:M1")
        .HorizontalAlignment = xlCenterAcrossSelection ' Centraliza o texto horizontalmente
        .VerticalAlignment = xlCenter   ' Centraliza o texto verticalmente
    End With
    
     With wsConsolidado.Range("A3:M3")
        
        .HorizontalAlignment = xlCenter ' Centraliza o texto horizontalmente
        .VerticalAlignment = xlCenter   ' Centraliza o texto verticalmente
    End With
    
    '-------------------------------------Cabeçalho---------------------------------
    
    wsConsolidado.Cells(1, 1).Value = textoConcatenado
    wsConsolidado.Rows("1").Font.Size = 16
    wsConsolidado.Rows("1").Font.Bold = True
    With wsConsolidado.Rows("2").Font
        .Size = 14
        .Color = RGB(255, 255, 255)
        .Bold = True
    End With
    '------------------- alteração nas linhas no tamanho ------------------
    wsConsolidado.Columns("A").ColumnWidth = 850 / 11
    wsConsolidado.Columns("B").ColumnWidth = 180 / 11
    wsConsolidado.Columns("C").ColumnWidth = 35 / 11
    wsConsolidado.Columns("D").ColumnWidth = 14 / 11
    wsConsolidado.Columns("E").ColumnWidth = 150 / 11
    wsConsolidado.Columns("F").ColumnWidth = 100 / 11
    wsConsolidado.Columns("G").ColumnWidth = 130 / 11
    wsConsolidado.Columns("H").ColumnWidth = 14 / 11
    wsConsolidado.Columns("I").ColumnWidth = 150 / 11
    wsConsolidado.Columns("J").ColumnWidth = 100 / 11
    wsConsolidado.Columns("K").ColumnWidth = 130 / 11
    wsConsolidado.Columns("L").ColumnWidth = 14 / 11
    wsConsolidado.Columns("M").ColumnWidth = 215 / 11
    wsConsolidado.Rows(1).RowHeight = 105
    wsConsolidado.Rows(2).RowHeight = 37
    wsConsolidado.Rows(3).RowHeight = 30
    

    
    Rows("4:" & ultimaLinha).AutoFit
    
    
    ' Define a coluna A como o intervalo a ser verificado
    'Range("A1:O" & ultimaLinha).RemoveDuplicates Columns:=15, Header:=xlNo
    'Call RemoverDuplicadosColunaO
    Call InserirFormula
    
    
   contb = "E3:M10000"
    wsConsolidado.Range(contb).NumberFormatLocal = "_(* #.##0,00_);_(* - #.##0,00_);_(* ""-""??_);_(@_)"


 
    
    
    '------------------ Ajustar imagens --------------------
    
    Set imagemOEC = wsConsolidado.Shapes.AddPicture( _
        Filename:=imagemCaminhoOEC, _
        LinkToFile:=msoFalse, _
        SaveWithDocument:=msoTrue, _
        Left:=10, Top:=10, Width:=-1, Height:=-1)
    
    ' Inserir a imagem MB como objeto fixo
    Set imagemMB = wsConsolidado.Shapes.AddPicture( _
        Filename:=imagemCaminhoMB, _
        LinkToFile:=msoFalse, _
        SaveWithDocument:=msoTrue, _
        Left:=850, Top:=10, Width:=-1, Height:=-1)
    

    Call CopiarColarSemFormulas
    
     If Dir(imagemCaminhoOEC) = "" Then
        MsgBox "O arquivo da imagem não foi encontrado no caminho especificado.", vbExclamation
        Exit Sub
    End If
    
     If Dir(imagemCaminhoMB) = "" Then
        MsgBox "O arquivo da imagem não foi encontrado no caminho especificado.", vbExclamation
        Exit Sub
    End If
    
     If Dir(pastaArquivo, vbDirectory) = "" Then
        MsgBox "A pasta 'img' não foi encontrada: " & imagemCaminho, vbExclamation
        Exit Sub
    End If
  
End Sub

Sub RemoverDuplicadosColunaO()
    Dim ws As Worksheet
    Dim ultimaLinha As Long
    
    ' Definir a aba onde os dados estão
    Set ws = ThisWorkbook.Sheets("Consolidado CPU") ' Substitua pelo nome correto da aba

    ' Determinar a última linha na coluna O
    ultimaLinha = ws.Cells(ws.Rows.Count, "O").End(xlUp).Row

    ' Remover duplicados na coluna O
    ws.Range("O2:O" & ultimaLinha).RemoveDuplicates Columns:=1, Header:=xlYes

End Sub

Private Sub CopiarColarSemFormulas()
    Dim wsOrigem As Worksheet
    Dim wsDestino As Worksheet
    Dim rng As Range
    
    ' Definir a aba de origem (onde estão os dados)
    Set wsOrigem = ThisWorkbook.Worksheets("Consolidado CPU")
    
    ' Definir a aba de destino (pode ser a mesma ou outra)
    ' Aqui, usamos a mesma aba de origem para colar sem fórmulas
    Set wsDestino = wsOrigem ' Alterar para outra planilha se necessário
    
    ' Identificar o intervalo usado na aba de origem
    Set rng = wsOrigem.UsedRange
    
    ' Copiar e colar apenas valores no destino
    rng.Copy
    wsDestino.Cells(1, 1).PasteSpecial Paste:=xlPasteValues
    
    ' Limpar a área de transferência (opcional, para evitar excesso de memória usada)
    Application.CutCopyMode = False
    
    ' Mensagem de confirmação
End Sub
Sub InserirFormula()

    On Error GoTo ErrorHandler

    Dim ws As Worksheet
    Dim ultimaLinha As Long

    ' Definir a aba Consolidar CPU
    Set ws = Sheets("Consolidado CPU")

    ' Determinar a última linha preenchida na coluna A
    ultimaLinha = ws.Cells(ws.Rows.Count, "O").End(xlUp).Row

    ' Verificar se há dados para copiar a fórmula
    If ultimaLinha < 4 Then
        MsgBox "Não há itens suficientes na coluna A para apicar a fórmula.", vbExclamation
        Exit Sub
    End If

    ' Alterar o formato para Geral antes de inserir a fórmula
    ws.Range("A:A").NumberFormat = "General"

    ' Inserir a fórmula dinamicamente da 4° linha até a última linha
    ws.Range("A4:A" & ultimaLinha).Formula = "=XLOOKUP(O4,'Dados do Arquivo 1'!N:N,'Dados do Arquivo 1'!C:C,XLOOKUP('Consolidado CPU'!O4,'Dados do Arquivo 2'!N:N,'Dados do Arquivo 2'!C:C,0,0,1),0,1)"
    ws.Range("B4:B" & ultimaLinha).FormulaLocal = "=PROCX(O4;'Dados do Arquivo 1'!N:N;'Dados do Arquivo 1'!B:B;PROCX('Consolidado CPU'!O4;'Dados do Arquivo 2'!N:N;'Dados do Arquivo 2'!B:B;0;0;1);0;1)"
    ws.Range("C4:C" & ultimaLinha).FormulaLocal = "=PROCX(O4;'Dados do Arquivo 1'!N:N;'Dados do Arquivo 1'!D:D;PROCX('Consolidado CPU'!O4;'Dados do Arquivo 2'!N:N;'Dados do Arquivo 2'!D:D;0;0;1);0;1)"
    ws.Range("E4:E" & ultimaLinha).FormulaLocal = "=PROCX(O4;'Dados do Arquivo 1'!N:N;'Dados do Arquivo 1'!G:G;0;0;1)"
    ws.Range("F4:F" & ultimaLinha).FormulaLocal = "=SEERRO(PROCX(O4;'Dados do Arquivo 1'!N:N;'Dados do Arquivo 1'!F:F;0;0;1) * (1 + 31,92%);0)"
    ws.Range("G4:G" & ultimaLinha).FormulaLocal = "=PROCX(O4;'Dados do Arquivo 1'!N:N;'Dados do Arquivo 1'!L:L;0;0;1)"
    ws.Range("I4:I" & ultimaLinha).FormulaLocal = "=PROCX(O4;'Dados do Arquivo 2'!N:N;'Dados do Arquivo 2'!G:G;0;0;1)"
    ws.Range("J4:J" & ultimaLinha).FormulaLocal = "=SEERRO(PROCX(O4;'Dados do Arquivo 2'!N:N;'Dados do Arquivo 2'!F:F;0;0;1) * (1 + 31,92%);0)"
    ws.Range("K4:K" & ultimaLinha).FormulaLocal = "=PROCX(O4;'Dados do Arquivo 2'!N:N;'Dados do Arquivo 2'!L:L;0;0;1)"
    ws.Range("M4:M" & ultimaLinha).FormulaLocal = "=I4 - E4"
    ws.Range("A4:A5000").WrapText = True
    
    Exit Sub

ErrorHandler:
    MsgBox "Ocorreu um erro ao inserir as fórmulas: " & Err.Description, vbCritical

End Sub

Sub gerarUnico()
    Dim arquivo2 As Variant
    Dim wsConsolidado As Worksheet
    Dim wsHome As Worksheet
    Dim wsDados2 As Worksheet
    Dim lastRowConsolidado As Long
    Dim lastRowDados2 As Long
    Dim i As Long
    Dim j As Long
    Dim wb2 As Workbook
    Dim ws2 As Worksheet
    Dim abaNomes As Worksheet
    Dim novaAba2 As Worksheet
    Dim caminhoInicial As String
    Dim cor1 As Range
    Dim cor2 As Range
    Dim cor3 As Range
    Dim cor4 As Range
    Dim cor5 As Range
    Dim cor6 As Range
    Dim ta1 As String
    Dim Ta2 As String
    
    Set wsHome = ThisWorkbook.Worksheets("Home")
    
    ta1 = wsHome.Range("A1").Value
    Ta2 = wsHome.Range("B1").Value
    
    ' Desabilitar atualização de tela, cálculo e eventos
    Application.ScreenUpdating = False
    Application.Calculation = xlCalculationManual
    Application.EnableEvents = False
    Application.DisplayAlerts = False
    
    caminhoInicial = ThisWorkbook.Path
    ' Abre a caixa de diálogo para seleção do arquivo
    ChDrive Left(caminhoInicial, 1) ' Define o drive (ex.: C:)
    ChDir caminhoInicial ' Define o diretório
    ' Solicitar arquivos
    arquivo2 = Application.GetOpenFilename(FileFilter:="Arquivos Excel (*.xls*), *.xls*", Title:="Selecione o arquivo Excel")
    If arquivo2 = False Then
        MsgBox "Nenhum arquivo selecionado.", vbCritical
        Exit Sub
    End If
    
         On Error Resume Next
     
    Worksheets("Consolidado CPU").Delete
    Worksheets("Dados do Arquivo 2").Delete

    On Error GoTo 0
    Set abaNomes = ThisWorkbook.Sheets.Add(After:=ThisWorkbook.Sheets(ThisWorkbook.Sheets.Count))
    abaNomes.Name = "Consolidado CPU"
    ' Abrir arquivos
    Set wb2 = Workbooks.Open(arquivo2)
    Set ws2 = wb2.Sheets(1)

    ' Criar nova aba para copiar os dados

    Set novaAba2 = ThisWorkbook.Sheets.Add(After:=ThisWorkbook.Sheets(ThisWorkbook.Sheets.Count))
    novaAba2.Name = "Dados do Arquivo 2"

    ' Copiar valores a partir da 9ª linha para as novas abas
    ws2.Rows("9:" & ws2.Rows.Count).Copy
    novaAba2.Cells.PasteSpecial xlPasteValues

    ' Fechar arquivos
    wb2.Close SaveChanges:=False

    ' Limpar objetos
    Set wb2 = Nothing
    Set ws2 = Nothing
    Set novaAba2 = Nothing


    ' Tempo de espera de 20 segundos
    'Application.Wait Now + TimeValue("00:00:20")
   ' UserForm2.Show
    ' Executar macros adicionais
    ' Rodar a macro filtro01 para o primeiro arquivo
    Call filtro02 ' Rodar a macro filtro02 para o segundo arquivo
    Set wsConsolidado = ThisWorkbook.Worksheets("Consolidado CPU")
    Set wsDados2 = ThisWorkbook.Worksheets("Dados do Arquivo 2")
    lastRowDados2 = wsDados2.Cells(wsDados2.Rows.Count, "N").End(xlUp).Row
    j = 4
    ' Copia os dados da coluna N da aba "dados do arquivo 2" para a aba "Consolidado CPU"
    For i = 2 To lastRowDados2 ' Começa na linha 2, assumindo que a linha 1 é o cabeçalho
        wsConsolidado.Cells(j, 15).Value = wsDados2.Cells(i, "N").Value
        j = j + 1
    Next i
    
    For i = lastRowConsolidado To 4 Step -1
        If IsEmpty(wsConsolidado.Cells(i, 15)) Then
            wsConsolidado.Rows(i).Delete
        End If
    Next i
      
    ' Atualiza a última linha após as remoções
    lastRowConsolidado = wsConsolidado.Cells(wsConsolidado.Rows.Count, "O").End(xlUp).Row
    ultimaLinha = wsConsolidado.Cells(Rows.Count, 1).End(xlUp).Row
    ultimaColuna = wsConsolidado.Cells(1, Columns.Count).End(xlToLeft).Column

Call FormUnit

'---------------------------------------
    Set cor1 = wsConsolidado.Range("A3:C3")
    cor1.Interior.Color = RGB(189, 215, 238)
    cor1.Cells(1, 1).Value = "Descrição"
    cor1.Cells(1, 2).Value = "Cod. Engenharia"
    cor1.Cells(1, 3).Value = "Uni."
    Set cor2 = wsConsolidado.Range("E3:G3")
    cor2.Interior.Color = RGB(189, 215, 238)
    cor2.Cells(1, 1).Value = "Quantidade"
    cor2.Cells(1, 2).Value = "Preço Unitário "
    cor2.Cells(1, 3).Value = "Preço Total"
    
    Set cor3 = wsConsolidado.Range("I3:K3")
    cor3.Interior.Color = RGB(189, 215, 238)
    cor3.Cells(1, 1).Value = "Quantidade"
    cor3.Cells(1, 2).Value = "Preço Unitário "
    cor3.Cells(1, 3).Value = "Preço Total"
    
    Set cor5 = wsConsolidado.Range("I2:K2")
    cor5.Interior.Color = RGB(31, 78, 120)
    
    wsConsolidado.Range("I2").Value = Ta2 & " (MAI/12)"
  
    
    With wsConsolidado.Range("I2:K2")
        .HorizontalAlignment = xlCenterAcrossSelection ' Centraliza o texto horizontalmente
        .VerticalAlignment = xlCenter   ' Centraliza o texto verticalmente
    End With
    
    wsConsolidado.Range("J3").WrapText = True
    Set cor4 = wsConsolidado.Range("E2:G2")
    cor4.Interior.Color = RGB(31, 78, 120)
    
    wsConsolidado.Range("E2").Value = ta1 & " (MAI/12)"
    With wsConsolidado.Range("E2:G2")
        .HorizontalAlignment = xlCenterAcrossSelection ' Centraliza o texto horizontalmente
        .VerticalAlignment = xlCenter   ' Centraliza o texto verticalmente
    End With
    
    wsConsolidado.Range("F3").WrapText = True

    Set cor3 = wsConsolidado.Range("M3")
    cor3.Interior.Color = RGB(189, 215, 238)
    cor3.Cells(1, 1).Value = "Variação Quantidade"
    wsConsolidado.Range("M2").Value = ta1 & " X " & Ta2 & Chr(10) & "(MAI/12)"
    
    Set cor6 = wsConsolidado.Range("M2")
    cor6.Interior.Color = RGB(31, 78, 120)
    
    With wsConsolidado.Range("M2")
        .HorizontalAlignment = xlCenter ' Centraliza o texto horizontalmente
        .VerticalAlignment = xlCenter   ' Centraliza o texto verticalmente
    End With
    
'--------------------------------------------------------------------------
    'dando merge na primeira linha
     With wsConsolidado.Range("A1:M1")
        .HorizontalAlignment = xlCenterAcrossSelection ' Centraliza o texto horizontalmente
        .VerticalAlignment = xlCenter   ' Centraliza o texto verticalmente
    End With
    
     With wsConsolidado.Range("A3:M3")
        
        .HorizontalAlignment = xlCenter ' Centraliza o texto horizontalmente
        .VerticalAlignment = xlCenter   ' Centraliza o texto verticalmente
    End With
    
    '-------------------------------------Cabeçalho---------------------------------
    
    wsConsolidado.Cells(1, 1).Value = textoConcatenado
    wsConsolidado.Rows("1").Font.Size = 16
    wsConsolidado.Rows("1").Font.Bold = True
    With wsConsolidado.Rows("2").Font
        .Size = 14
        .Color = RGB(255, 255, 255)
        .Bold = True
    End With

Worksheets("Consolidado CPU").Activate

'Call layoutComparativo

    Application.ScreenUpdating = True
    Application.Calculation = xlCalculationAutomatic
    Application.EnableEvents = True
    Application.DisplayAlerts = True

End Sub

Sub FormUnit()
        On Error GoTo ErrorHandler

    Dim wsConsolidado As Worksheet
    Dim lastRowConsolidado As Long

    ' Definir a aba Consolidar CPU
    Set wsConsolidado = Sheets("Consolidado CPU")


    ' Determinar a última linha preenchida na coluna A
  lastRowConsolidado = wsConsolidado.Cells(wsConsolidado.Rows.Count, "O").End(xlUp).Row
    ' Verificar se há dados para copiar a fórmula
   ' If lastRowConsolidado < 4 Then
        'MsgBox "Não há itens suficientes na coluna O para apicar a fórmula.", vbExclamation
       ' Exit Sub
    'End If

    ' Alterar o formato para Geral antes de inserir a fórmula
    wsConsolidado.Range("A:A").NumberFormat = "General"

    ' Inserir a fórmula dinamicamente da 4° linha até a última linha
    wsConsolidado.Range("A4:A" & lastRowConsolidado).Formula = "=XLOOKUP(O4,'Dados do Arquivo 2'!N:N,'Dados do Arquivo 2'!C:C,,0,1)"
    wsConsolidado.Range("B4:B" & lastRowConsolidado).FormulaLocal = "=PROCX(O4;'Dados do Arquivo 2'!N:N;'Dados do Arquivo 2'!B:B;;0;1)"
    wsConsolidado.Range("C4:C" & lastRowConsolidado).FormulaLocal = "=PROCX(O4;'Dados do Arquivo 2'!N:N;'Dados do Arquivo 2'!D:D;;0;1)"
    wsConsolidado.Range("E4:G" & lastRowConsolidado).FormulaLocal = 0
    wsConsolidado.Range("I4:I" & lastRowConsolidado).FormulaLocal = "=PROCX(O4;'Dados do Arquivo 2'!N:N;'Dados do Arquivo 2'!G:G;0;0;1)"
    wsConsolidado.Range("J4:J" & lastRowConsolidado).FormulaLocal = "=TRUNCAR(SEERRO(PROCX(O4;'Dados do Arquivo 2'!N:N;'Dados do Arquivo 2'!F:F;0;0;1) * (1 + 31,92%);0);2)"
    wsConsolidado.Range("K4:K" & lastRowConsolidado).FormulaLocal = "=TRUNCAR(PROCX(O4;'Dados do Arquivo 2'!N:N;'Dados do Arquivo 2'!L:L;0;0;1);2)"
    wsConsolidado.Range("M4:M" & lastRowConsolidado).FormulaLocal = "=TRUNCAR(I4 - E4;2)"
    wsConsolidado.Range("A4:A5000").WrapText = True


    Exit Sub

ErrorHandler:
    MsgBox "Ocorreu um erro ao inserir as fórmulas: " & Err.Description, vbCritical
End Sub



Sub layoutComparativo()

    Dim wsConsolidado As Worksheet
    Dim rngFiltro As Range
    Dim rng As Range
    Dim rng3 As Range
    Dim rng2 As Range
    Dim rng4 As Range
    Dim ultimaLinha As Long
    Dim lastRowConsolidado As Long
    Dim pastaArquivo As String
    Dim imagemCaminhoOEC As String
    Dim imagemCaminhoMB As String
    Dim imagemOEC As Object
    Dim imagemMB As Object
    Dim contb As String
    Dim area As String
    Dim ta1 As String
    Dim Ta2 As String
    Dim nomeArquivo As String
    Dim resposta As VbMsgBoxResult
    Dim caminho As String
    Dim texto As String
    Dim wsHome As Worksheet
    
    Application.ScreenUpdating = False
    Application.Calculation = xlCalculationManual
    Application.EnableEvents = False
    Application.DisplayAlerts = False
    

    If ThisWorkbook.Path <> "" Then
        caminho = ThisWorkbook.Path & "/out/"
    Else
        MsgBox "O arquivo atual não está salvo. Por favor, salve-o antes de executar a macro.", vbExclamation, "Erro"
        Exit Sub
    End If

    ' Criar a pasta "out" se não existir
    If Dir(caminho, vbDirectory) = "" Then
        MkDir caminho
    End If
     
    
    pastaArquivo = ThisWorkbook.Path
    imagemCaminhoOEC = pastaArquivo & "/assets/img/imagem1.png"
    imagemCaminhoMB = pastaArquivo & "/assets/img/imagem2.png"
    Set wsConsolidado = ActiveSheet

    
    area = {area}
    ta1 = {ta1}
    Ta2 = {ta2}
    
    lastRowConsolidado = wsConsolidado.Cells(wsConsolidado.Rows.Count, "O").End(xlUp).Row
    
       '------------------- alteração nas linhas no tamanho ------------------
    wsConsolidado.Columns("A").ColumnWidth = 850 / 11
    wsConsolidado.Columns("B").ColumnWidth = 180 / 11
    wsConsolidado.Columns("C").ColumnWidth = 35 / 11
    wsConsolidado.Columns("D").ColumnWidth = 14 / 11
    wsConsolidado.Columns("E").ColumnWidth = 150 / 11
    wsConsolidado.Columns("F").ColumnWidth = 100 / 11
    wsConsolidado.Columns("G").ColumnWidth = 130 / 11
    wsConsolidado.Columns("H").ColumnWidth = 14 / 11
    wsConsolidado.Columns("I").ColumnWidth = 150 / 11
    wsConsolidado.Columns("J").ColumnWidth = 100 / 11
    wsConsolidado.Columns("K").ColumnWidth = 130 / 11
    wsConsolidado.Columns("L").ColumnWidth = 14 / 11
    wsConsolidado.Columns("M").ColumnWidth = 215 / 11
    wsConsolidado.Rows(1).RowHeight = 115
    wsConsolidado.Rows(2).RowHeight = 37
    wsConsolidado.Rows(3).RowHeight = 30
    
    '-------------------Colunas A-D---------------------

Set rng = wsConsolidado.Range("A3:C" & lastRowConsolidado)
    With rng.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .Weight = xlMedium
    End With
    
    
   '-------------------Colunas E-G---------------------
    Set rng2 = wsConsolidado.Range("E2:G" & lastRowConsolidado)
    With rng2.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng2.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng2.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng2.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng2.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng2.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With

    '------------------colunas I-K ----------------------
    Set rng3 = wsConsolidado.Range("I2:K" & lastRowConsolidado)
    With rng3.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng3.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng3.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng3.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng3.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng3.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    
    '----------------------------Coluna M ---------------------------------------
    Set rng4 = wsConsolidado.Range("M2:M" & lastRowConsolidado)
    With rng4.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng4.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng4.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng4.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng4.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    With rng4.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .Weight = xlThin
    End With
    
    wsConsolidado.Range("A4:A" & lastRowConsolidado).WrapText = True
    
    Rows("4:" & lastRowConsolidado).AutoFit
    
    contb = "E3:M10000"
   ' wsConsolidado.Range(contb).NumberFormatLocal = "_(* #.##0,00_);_(* - #.##0,00_);_(* ""-""??_);_(@_)"
    
    
    '------------------ Ajustar imagens --------------------
    
    Set imagemOEC = wsConsolidado.Shapes.AddPicture( _
        Filename:=imagemCaminhoOEC, _
        LinkToFile:=msoFalse, _
        SaveWithDocument:=msoTrue, _
        Left:=25, Top:=20, Width:=220, Height:=66)
    
    ' Inserir a imagem MB como objeto fixo
    Set imagemMB = wsConsolidado.Shapes.AddPicture( _
        Filename:=imagemCaminhoMB, _
        LinkToFile:=msoFalse, _
        SaveWithDocument:=msoTrue, _
        Left:=860, Top:=15, Width:=-1, Height:=-1)
    
    nomeArquivo = wsConsolidado.Name & " " & ta1 & " X " & Ta2 & " - Área " & area & ".xlsx"
    
    wsConsolidado.Rows("4").Delete Shift:=xlUp
    wsConsolidado.Columns("O").Delete
    ActiveWindow.View = xlPageBreakPreview
    ActiveWindow.Zoom = 85
    wsConsolidado.VPageBreaks(1).DragOff Direction:=xlToRight, RegionIndex:=1
    
    '----------------------
    
    ultimaLinha = wsConsolidado.Cells(wsConsolidado.Rows.Count, 1).End(xlUp).Row ' Encontrando a última linha usada na coluna A
    
    ' Deletar todas as linhas abaixo da última linha utilizada
    If ultimaLinha < wsConsolidado.Rows.Count Then
        wsConsolidado.Rows(ultimaLinha + 1 & ":" & wsConsolidado.Rows.Count).Delete
    End If

    With wsConsolidado.Columns("E:M") ' Ajuste conforme necessário
    .NumberFormat = "_-* #,##0.00;-* #,##0.00;""-  "";-@" ' Formato contábil sem "R$"
    End With
    
    wsConsolidado.Range("E2:M3").NumberFormat = "@"
      
    wsConsolidado.Copy ' Copiar a aba para um novo arquivo
    
    On Error Resume Next
    With ActiveWorkbook
        .SaveAs Filename:=caminho & nomeArquivo, FileFormat:=xlOpenXMLWorkbook
        .Close SaveChanges:=False
    End With
    On Error GoTo 0
    
     If Dir(imagemCaminhoOEC) = "" Then
        MsgBox "O arquivo da imagem não foi encontrado no caminho especificado.", vbExclamation
        Exit Sub
    End If
    
     If Dir(imagemCaminhoMB) = "" Then
        MsgBox "O arquivo da imagem não foi encontrado no caminho especificado.", vbExclamation
        Exit Sub
    End If
    
     If Dir(pastaArquivo, vbDirectory) = "" Then
        MsgBox "A pasta 'img' não foi encontrada: " & imagemCaminho, vbExclamation
        Exit Sub
    End If
     
    Application.ScreenUpdating = True
    Application.Calculation = xlCalculationAutomatic
    Application.EnableEvents = True
    Application.DisplayAlerts = True
     
End Sub


"""  
        return forn
        