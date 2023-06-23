Imports Entidades.Vales
Imports System.Drawing.Printing
Imports ReglasNegocio.Vales

Public Class frmImprimirSF
    Private xVales As New List(Of iVale)
    Private Const xValesPorHoja As Integer = 8
    Private xMVSI As New List(Of Point)
    Private xPaginas As Integer
    Private xDoc As PrintDocument
    Private xEmpresa As clsEmpresa

    Public Property pdVales() As List(Of iVale)
        Get
            Return Me.xVales
        End Get
        Set(ByVal value As List(Of iVale))
            Me.xVales = value
            Me.lblHojas.Text = CStr(Me.CantidadHojas)
            Me.CrearDocumento()
        End Set
    End Property

    Private Sub CrearDocumento()
        Try
            Me.xEmpresa = clsEmpresa.Instanciar(mGlobal.xEmpresa)

            xDoc = New PrintDocument

            AddHandler xDoc.PrintPage, AddressOf Imprimir
            xDoc.DocumentName = "Vales para " & xVales(0).pdCliente.pdNombreCompleto
            xDoc.DefaultPageSettings.Margins.Left = 20
            xDoc.DefaultPageSettings.Margins.Top = 20
            xDoc.DefaultPageSettings.Margins.Right = 20
            xDoc.DefaultPageSettings.Margins.Bottom = 20
            xDoc.DefaultPageSettings.PaperSize = New PaperSize("paperA4", 826, 1169)
            Me.ppcVales.Document = xDoc

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MargenesVales(ByVal e As PrintPageEventArgs)
        'Margen Superior Izquierdo
        xMVSI.Add(New Point(e.PageSettings.Margins.Left, e.PageSettings.Margins.Top))
        xMVSI.Add(New Point(CInt(e.PageSettings.PaperSize.Width / 2), e.PageSettings.Margins.Top))
        xMVSI.Add(New Point(e.PageSettings.Margins.Left, CInt((e.PageSettings.PaperSize.Height - (e.PageSettings.Margins.Top + e.PageSettings.Margins.Bottom)) / 4)))
        xMVSI.Add(New Point(CInt(e.PageSettings.PaperSize.Width / 2), CInt((e.PageSettings.PaperSize.Height - (e.PageSettings.Margins.Top + e.PageSettings.Margins.Bottom)) / 4)))
        xMVSI.Add(New Point(e.PageSettings.Margins.Left, CInt(((e.PageSettings.PaperSize.Height - (e.PageSettings.Margins.Top + e.PageSettings.Margins.Bottom)) / 4) * 2)))
        xMVSI.Add(New Point(CInt(e.PageSettings.PaperSize.Width / 2), CInt(((e.PageSettings.PaperSize.Height - (e.PageSettings.Margins.Top + e.PageSettings.Margins.Bottom)) / 4) * 2)))
        xMVSI.Add(New Point(e.PageSettings.Margins.Left, CInt(((e.PageSettings.PaperSize.Height - (e.PageSettings.Margins.Top + e.PageSettings.Margins.Bottom)) / 4) * 3)))
        xMVSI.Add(New Point(CInt(e.PageSettings.PaperSize.Width / 2), CInt(((e.PageSettings.PaperSize.Height - (e.PageSettings.Margins.Top + e.PageSettings.Margins.Bottom)) / 4) * 3)))
    End Sub

    Private Sub Imprimir(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        MargenesVales(e)
        Dim dotted_pen As New Pen(Color.Black, 1)
        dotted_pen.DashStyle = Drawing2D.DashStyle.Dash

        'BORDES
        e.Graphics.DrawRectangle(dotted_pen, e.MarginBounds)

        'LINEA 1
        Dim xL1X1 As Single = e.PageSettings.Margins.Left
        Dim xL1Y1 As Single = CSng((e.PageSettings.PaperSize.Height - (e.PageSettings.Margins.Top + e.PageSettings.Margins.Bottom)) / 4)
        Dim xL1X2 As Single = e.PageSettings.PaperSize.Width - e.PageSettings.Margins.Right
        Dim xL1Y2 As Single = CSng((e.PageSettings.PaperSize.Height - (e.PageSettings.Margins.Top + e.PageSettings.Margins.Bottom)) / 4)

        e.Graphics.DrawLine(dotted_pen, xL1X1, xL1Y1, xL1X2, xL1Y2)

        'LINEA2
        Dim xL2X1 As Single = e.PageSettings.Margins.Left
        Dim xL2Y1 As Single = CSng(((e.PageSettings.PaperSize.Height - (e.PageSettings.Margins.Top + e.PageSettings.Margins.Bottom)) / 4) * 2)
        Dim xL2X2 As Single = e.PageSettings.PaperSize.Width - e.PageSettings.Margins.Right
        Dim xL2Y2 As Single = CSng(((e.PageSettings.PaperSize.Height - (e.PageSettings.Margins.Top + e.PageSettings.Margins.Bottom)) / 4) * 2)

        e.Graphics.DrawLine(dotted_pen, xL2X1, xL2Y1, xL2X2, xL2Y2)

        'LINEA2
        Dim xL4X1 As Single = e.PageSettings.Margins.Left
        Dim xL4Y1 As Single = CSng(((e.PageSettings.PaperSize.Height - (e.PageSettings.Margins.Top + e.PageSettings.Margins.Bottom)) / 4) * 3)
        Dim xL4X2 As Single = e.PageSettings.PaperSize.Width - e.PageSettings.Margins.Right
        Dim xL4Y2 As Single = CSng(((e.PageSettings.PaperSize.Height - (e.PageSettings.Margins.Top + e.PageSettings.Margins.Bottom)) / 4) * 3)

        e.Graphics.DrawLine(dotted_pen, xL4X1, xL4Y1, xL4X2, xL4Y2)

        'LINEA VERTICAL
        Dim xL3X1 As Single = CSng(e.PageSettings.PaperSize.Width / 2)
        Dim xL3Y1 As Single = e.PageSettings.Margins.Top
        Dim xL3X2 As Single = CSng(e.PageSettings.PaperSize.Width / 2)
        Dim xL3Y2 As Single = e.PageSettings.PaperSize.Height - e.PageSettings.Margins.Bottom

        e.Graphics.DrawLine(dotted_pen, xL3X1, xL3Y1, xL3X2, xL3Y2)

        Dim xLimiteBucle As Integer = 0
        If Me.xVales.Count - (Me.xPaginas * xValesPorHoja) >= 0 Then
            xLimiteBucle = 7
        Else
            xLimiteBucle = (xValesPorHoja + (Me.xVales.Count - (Me.xPaginas * xValesPorHoja))) - 1
        End If

        For i As Integer = 0 To xLimiteBucle
            Dim xIndiceVale As Integer = (xPaginas - 1) * xValesPorHoja + i
            'LOGO
            Dim xPR As New Pen(Color.Black, 1)
            e.Graphics.DrawRectangle(xPR, Me.xMVSI(i).X + 10, Me.xMVSI(i).Y + 15, 135, 60)
            e.Graphics.DrawString(Me.xEmpresa.pdRazonSocial, New Font("Times New Roman", 8, FontStyle.Bold), Brushes.Black, Me.xMVSI(i).X + xEmpresa.pdPosicionLogo, Me.xMVSI(i).Y + 30)
            e.Graphics.DrawString("REFINOR", New Font("Century Gothic", 8, FontStyle.Regular), Brushes.Black, Me.xMVSI(i).X + 11, Me.xMVSI(i).Y + 55)
            e.Graphics.DrawLine(xPR, Me.xMVSI(i).X + 10, Me.xMVSI(i).Y + 50, Me.xMVSI(i).X + 145, Me.xMVSI(i).Y + 50)
            'e.Graphics.DrawString(xEmpresa.pdDueños, New Font("Agency FB", 7, FontStyle.Regular), Brushes.Black, Me.xMVSI(i).X + 8, Me.xMVSI(i).Y + 75)
            e.Graphics.DrawString(xEmpresa.pdDirección, New Font("Agency FB", 8, FontStyle.Regular), Brushes.Black, Me.xMVSI(i).X + 8, Me.xMVSI(i).Y + 75)

            'CODIGO DE BARRAS
            Dim xFuenteCodigo As New Font("IDAutomationHC39M", 14, FontStyle.Regular)
            e.Graphics.DrawString(Me.xVales(xIndiceVale).pdID, xFuenteCodigo, Brushes.Black, Me.xMVSI(i).X + 155, Me.xMVSI(i).Y + 8)

            'VALE
            e.Graphics.DrawString("Se autoriza al cliente: " & xVales(xIndiceVale).pdCliente.pdNombreCompleto & ", a cargar", New Font("Verdana", 8, FontStyle.Bold), Brushes.Black, Me.xMVSI(i).X + 10, Me.xMVSI(i).Y + 90)
            e.Graphics.DrawString("combustible por", New Font("Verdana", 8, FontStyle.Bold), Brushes.Black, Me.xMVSI(i).X + 10, Me.xMVSI(i).Y + 105)
            If Me.xVales(xIndiceVale).pdTipo = enTipoVale.Dinero Then e.Graphics.DrawString("un valor equivalente en pesos:", New Font("Verdana", 8, FontStyle.Bold), Brushes.Black, Me.xMVSI(i).X + 120, Me.xMVSI(i).Y + 105)
            If Me.xVales(xIndiceVale).pdTipo = enTipoVale.Combustible Then
                Dim xVC As clsValeCombustible = CType(xVales(xIndiceVale), clsValeCombustible)
                e.Graphics.DrawString(" litros de " & xVC.pdCombustible.pdNombre & ":", New Font("Verdana", 8, FontStyle.Bold), Brushes.Black, Me.xMVSI(i).X + 120, Me.xMVSI(i).Y + 125)
            End If

            e.Graphics.DrawString("VALE POR:", New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, Me.xMVSI(i).X + 20, Me.xMVSI(i).Y + 130)
            If Me.xVales(xIndiceVale).pdTipo = enTipoVale.Dinero Then e.Graphics.DrawString("$", New Font("Times New Roman", 24, FontStyle.Bold), Brushes.Black, Me.xMVSI(i).X + 190, Me.xMVSI(i).Y + 133)
            e.Graphics.DrawString(Me.xVales(xIndiceVale).pdValor.ToString, New Font("Arial", 40, FontStyle.Bold), Brushes.Black, Me.xMVSI(i).X + 210, Me.xMVSI(i).Y + 115)
            If Me.xVales(xIndiceVale).pdTipo = enTipoVale.Combustible Then e.Graphics.DrawString("lts.", New Font("Times New Roman", 24, FontStyle.Bold), Brushes.Black, Me.xMVSI(i).X + 320, Me.xMVSI(i).Y + 133)

            'ACLARACION
            e.Graphics.DrawString("El presente no puede ser canjeado por dinero en efectivo.", New Font("Verdana", 8, FontStyle.Italic), Brushes.Black, Me.xMVSI(i).X + 10, Me.xMVSI(i).Y + 165)
            e.Graphics.DrawString("El monto de este vale es indivisible.", New Font("Verdana", 8, FontStyle.Italic), Brushes.Black, Me.xMVSI(i).X + 10, Me.xMVSI(i).Y + 180)
            e.Graphics.DrawString("LA GERENCIA", New Font("Verdana", 8, FontStyle.Underline), Brushes.Black, Me.xMVSI(i).X + 230, Me.xMVSI(i).Y + 180)

            'VENCIMIENTO
            e.Graphics.DrawString("Válido hasta el:", New Font("Verdana", 10, FontStyle.Regular), Brushes.Black, Me.xMVSI(i).X + 20, Me.xMVSI(i).Y + 195)
            e.Graphics.DrawString(Format(Me.xVales(xIndiceVale).pdVencimiento, "dd/MM/yyyy"), New Font("Verdana", 12, FontStyle.Bold), Brushes.Black, Me.xMVSI(i).X + 130, Me.xMVSI(i).Y + 195)
        Next

        If xPaginas = CInt(Me.txtHasta.Text) Then
            e.HasMorePages = False
        Else
            e.HasMorePages = True
        End If

        xPaginas += 1
    End Sub

    Private Function CantidadHojas() As Short
        Dim xS As Single = CSng(Me.xVales.Count / xValesPorHoja)

        Dim xEnt As Short = CShort(Math.Floor(xS))
        If xS - xEnt = 0 Then
            Return xEnt
        Else
            Return CShort(xEnt + 1)
        End If
    End Function

    Private Sub frmImprimir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ppcVales.Show()
        Me.xPaginas = 1
        Me.nudPagina.Minimum = 1
        Me.nudPagina.Maximum = Me.CantidadHojas
        Me.txtHasta.Text = CStr(Me.CantidadHojas)
        'Me.txtPaginaInicio.Text = 1
    End Sub

    Private Sub nudPagina_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudPagina.ValueChanged
        Me.ppcVales.StartPage = CInt(Me.nudPagina.Value - 1)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim xSettings As New PrintDialog
        With xSettings
            .AllowSelection = True
            .AllowPrintToFile = False
            .PrintToFile = False
            .AllowSomePages = False
            .UseEXDialog = True

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.xPaginas = CInt(Me.txtPaginaInicio.Text)
                xDoc.PrinterSettings = .PrinterSettings
                xDoc.DefaultPageSettings.Margins.Left = 15
                xDoc.DefaultPageSettings.Margins.Top = 20
                xDoc.DefaultPageSettings.Margins.Right = 20
                xDoc.DefaultPageSettings.Margins.Bottom = 20
                xDoc.Print()
            End If
        End With

    End Sub

    Private Sub txtPaginaInicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaginaInicio.TextChanged
        If Me.xVales.Count <> 0 Then
            If Not IsNumeric(Me.txtPaginaInicio.Text) Then
                Me.txtPaginaInicio.Text = CStr(1)
            Else
                If CInt(Me.txtPaginaInicio.Text) < 1 Then Me.txtPaginaInicio.Text = CStr(1)
                If CInt(Me.txtPaginaInicio.Text) > Me.CantidadHojas Then Me.txtPaginaInicio.Text = CStr(CantidadHojas())
            End If
        End If
    End Sub

    Private Sub txtHasta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHasta.TextChanged
        If Me.xVales.Count <> 0 Then
            If Not IsNumeric(Me.txtPaginaInicio.Text) Then
                Me.txtHasta.Text = CStr(CantidadHojas())
            Else
                If CInt(Me.txtHasta.Text) < 1 Then Me.txtPaginaInicio.Text = CStr(1)
                If CInt(Me.txtHasta.Text) > Me.CantidadHojas Then Me.txtPaginaInicio.Text = CStr(CantidadHojas())
            End If
        End If
    End Sub

    Private Sub frmImprimir_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.ppcVales.Height = Me.Height - 80
    End Sub
End Class