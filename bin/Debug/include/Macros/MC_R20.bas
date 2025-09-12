Sub TransP1()
    Dim wb As Workbook, ws As Worksheet
    Dim pastaArquivo As String,imagemCaminhoOEC As String, imagemCaminhoMB As String, imagemOEC As Object, imagemMB As Object
    Dim rng1 As Range, rng2 As Range, rng3 As Range, ultimaLinha As Long

    Application.ScreenUpdating = False
    Application.Calculation = xlCalculationManual
    Application.EnableEvents = False
    Application.DisplayAlerts = False

    pastaArquivo = ThisWorkbook.Path
    imagemCaminhoOEC = pastaArquivo & "..\..\..\assets\img\imagem1.png"
    imagemCaminhoMB = pastaArquivo & "..\..\..\assets\img\imagem2.png"

    Set ws = ThisWorkbook.Worksheets("Sheet1")
    ws.Columns("AH").Delete

          '------------------- alteração nas linhas no tamanho ------------------
    ws.Columns("A").ColumnWidth = 120 / 7
    ws.Columns("B").ColumnWidth = 78 / 7
    ws.Columns("C").ColumnWidth = 460 / 7
    ws.Columns("D").ColumnWidth = 150 / 7
    ws.Columns("E").ColumnWidth = 100 / 7
    ws.Columns("F").ColumnWidth = 150 / 7
    ws.Columns("G").ColumnWidth = 190 / 7
    ws.Columns("H").ColumnWidth = 190 / 7
    ws.Columns("I").ColumnWidth = 455 / 7
    ws.Columns("J").ColumnWidth = 140 / 7
    ws.Columns("K").ColumnWidth = 140 / 7
    ws.Columns("L").ColumnWidth = 140 / 7
    ws.Columns("M").ColumnWidth = 80 / 7
    ws.Columns("N").ColumnWidth = 80 / 7
    ws.Columns("O").ColumnWidth = 250 / 7
    ws.Columns("P").ColumnWidth = 250 / 7
    ws.Columns("Q").ColumnWidth = 105 / 7
    ws.Columns("R").ColumnWidth = 250 / 7
    ws.Columns("S").ColumnWidth = 250 / 7
    ws.Columns("T").ColumnWidth = 175 / 7
    ws.Columns("U").ColumnWidth = 80 / 7
    ws.Columns("V").ColumnWidth = 80 / 7
    ws.Columns("X").ColumnWidth = 155 / 7
    ws.Columns("Y").ColumnWidth = 155 / 7
    ws.Columns("W").ColumnWidth = 80 / 7
    ws.Columns("Z").ColumnWidth = 155 / 7
    ws.Columns("AA").ColumnWidth = 155 / 7
    ws.Columns("AB").ColumnWidth = 45 / 7
    ws.Columns("AC").ColumnWidth = 140 / 7
    ws.Columns("AD").ColumnWidth = 140 / 7
    ws.Columns("AE").ColumnWidth = 140 / 7
    ws.Columns("AF").ColumnWidth = 185 / 7
    ws.Columns("AG").ColumnWidth = 120 / 7
    ws.Rows(1).RowHeight = 70
    ws.Rows(2).RowHeight = 25
    ws.Rows(3).Insert Shift:=xlDown
    ws.Rows(3).RowHeight = 18

    ws.Range("A1:AG1").HorizontalAlignment = xlCenterAcrossSelection
    ws.Range("A1:AG1").VerticalAlignment = xlCenter
    ws.Range("A2:AG2").VerticalAlignment = xlCenter
    ws.Range("A1").Font.Bold = True
    ws.Range("A1").Font.Size = 12
    Set rng1 = ws.Range("A2:AG3")

    rng1.Interior.Color = RGB(31, 78, 120)
    rng1.Font.Color = vbWhite

    ultimaLinha = ws.Cells(ws.Rows.Count, 1).End(xlUp).Row

    Set rng2 = ws.Range("A4:AG" & ultimaLinha)



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




    Set imagemOEC = ws.Shapes.AddPicture( _
        Filename:=imagemCaminhoOEC, _
        LinkToFile:=msoFalse, _
        SaveWithDocument:=msoTrue, _
        Left:=25, Top:=10, Width:=170, Height:=50)
    
    ' Inserir a imagem MB como objeto fixo
    Set imagemMB = ws.Shapes.AddPicture( _
        Filename:=imagemCaminhoMB, _
        LinkToFile:=msoFalse, _
        SaveWithDocument:=msoTrue, _
        Left:=3960, Top:=10, Width:=150, Height:=50)


    'Formulas

    ws.Range("AG2").Value = "Quantidade"

    ws.Range("AG4:AG" & ultimaLinha).FormulaLocal = "=(Q4/100) * U4"

    ws.Range("A4:AG" & ultimaLinha).AutoFilter
    
    Application.ScreenUpdating = True
    Application.Calculation = xlCalculationAutomatic
    Application.EnableEvents = True
    Application.DisplayAlerts = True

End Sub
