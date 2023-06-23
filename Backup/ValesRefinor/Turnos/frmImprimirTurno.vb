Imports Entidades.Turnos
Imports System.Drawing.Printing
Imports ReglasNegocio.Turnos

Public Class frmImprimirTurno
    Private xDia As idiatrabajo
    Private xPagina As Integer = 1
    Private xDoc As PrintDocument
    Private xDescargasDescargadas As Integer = 0
    Private xEstaticosImpresos As Boolean = False
    Private xMostrarEncTurno As Boolean = True
    Private xFinalAlcanzado As Boolean = False
    Private xTotalPags As Integer = 32000
    Private xY As Integer = 70
    Private xTurno As iTurno

    Public Property pdTurno() As iTurno
        Get
            Return Me.xTurno
        End Get
        Set(ByVal value As iTurno)
            Me.xTurno = value
            Me.CrearDocumento()
        End Set
    End Property

    Public Property pdDia() As iDiaTrabajo
        Get
            Return Me.xDia
        End Get
        Set(ByVal value As iDiaTrabajo)
            Me.xDia = value
        End Set
    End Property

    Private Sub CrearDocumento()
        Try
            xDoc = New PrintDocument

            AddHandler xDoc.PrintPage, AddressOf Imprimir
            xDoc.DocumentName = "Turno " & Me.xTurno.Turno & " del día: " & Me.xDia.pdFecha.Date
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

    Private Sub Imprimir(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim dotted_pen As New Pen(Color.Black, 1)
        dotted_pen.DashStyle = Drawing2D.DashStyle.Dash
        Dim solid_pen As New Pen(Color.Black, 1)

        'ENCABEZADO
        e.Graphics.DrawString("Parte del día: " & Date.Now.Date, New Font("Century Gothic", 16, FontStyle.Regular), Brushes.Black, 30, 30)
        e.Graphics.DrawLine(dotted_pen, 10, 60, e.PageBounds.Width - 10, 60)

        If Not xEstaticosImpresos Then
            'RESUMEN
            e.Graphics.DrawString("RESUMEN DE TURNO: " & UCase(xTurno.Turno), New Font("Courier New", 12, FontStyle.Bold), Brushes.Black, 20, xY + 5)
            e.Graphics.DrawString("Cantidad de vales descargados: " & xTurno.pdResumen.pdDescargas.Count, New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, 40, xY + 20)
            e.Graphics.DrawString("Monto descargado en dinero: $" & xTurno.pdResumen.pdDineroDescargado, New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, 40, xY + 35)
            e.Graphics.DrawString("Litros de combustible descargado: " & xTurno.pdResumen.pdCombustibleDescargado & " lts.", New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, 40, xY + 50)

            'DETALLE
            e.Graphics.DrawLine(solid_pen, 10, xY + 65, e.PageBounds.Width - 10, xY + 65)
            e.Graphics.DrawString("DETALLE DE DESCARGAS:", New Font("Courier New", 12, FontStyle.Bold), Brushes.Black, 20, xY + 80)
            xEstaticosImpresos = True

            e.Graphics.DrawString("Tipo de vale |", New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, 150, xY + 100)
            e.Graphics.DrawString("Monto ($ / lts.) |", New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, 290, xY + 100)
            e.Graphics.DrawString("Usuario", New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, 470, xY + 100)
            e.Graphics.DrawLine(dotted_pen, 120, xY + 120, e.PageBounds.Width - 175, xY + 120)
            xY += 135
        End If

        For j As Integer = 0 + xDescargasDescargadas To xTurno.pdResumen.pdDescargas.Count - 1

            e.Graphics.DrawString(xTurno.pdResumen.pdDescargas(Me.xDescargasDescargadas).pdTipoVale.ToString, New Font("Courier New", 10, FontStyle.Regular), Brushes.Black, 150, xY)
            e.Graphics.DrawString(xTurno.pdResumen.pdDescargas(Me.xDescargasDescargadas).pdMonto.ToString, New Font("Courier New", 10, FontStyle.Regular), Brushes.Black, 290, xY)
            e.Graphics.DrawString(xTurno.pdResumen.pdDescargas(Me.xDescargasDescargadas).pdUsuario, New Font("Courier New", 10, FontStyle.Regular), Brushes.Black, 470, xY)
            xY += 15

            xDescargasDescargadas += 1

            If xY >= e.PageBounds.Height - 140 Then
                xFinalAlcanzado = True
                Exit For
            Else
                xFinalAlcanzado = False
            End If
        Next

        xY += 20

        'PIE
        e.Graphics.DrawLine(dotted_pen, 10, e.PageBounds.Height - 80, e.PageBounds.Width - 10, e.PageBounds.Height - 80)
        e.Graphics.DrawString("Página " & xPagina, New Font("Courier New", 10, FontStyle.Regular), Brushes.Black, e.PageBounds.Width - 150, e.PageBounds.Height - 70)

        If xDescargasDescargadas >= xTurno.pdResumen.pdDescargas.Count - 1 Or Me.xPagina >= Me.xTotalPags Then
            e.HasMorePages = False
            Me.lblHojas.Text = CStr(xPagina)
            Me.nudPagina.Maximum = xPagina
            Me.xTotalPags = xPagina
            Me.txtHasta.Text = CStr(xPagina)
        Else
            xPagina += 1
            e.HasMorePages = True
        End If

        xY = 70
    End Sub

    Private Sub frmImprimir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ppcVales.Show()
        Me.xPagina = 1
        Me.nudPagina.Minimum = 1
        'Me.txtPaginaInicio.Text = 1
    End Sub

    Private Sub nudPagina_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudPagina.ValueChanged
        If Me.nudPagina.Value > 0 Then
            Me.ppcVales.StartPage = CInt(Me.nudPagina.Value - 1)
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim xSettings As New PrintDialog
        With xSettings
            .AllowSelection = True
            .AllowPrintToFile = False
            .PrintToFile = False
            .AllowSomePages = False
            xDescargasDescargadas = 0
            xEstaticosImpresos = False
            xMostrarEncTurno = True
            xFinalAlcanzado = False
            xPagina = 1
            xY = 70
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.xPagina = CInt(Me.txtPaginaInicio.Text)
                xDoc.PrinterSettings = .PrinterSettings
                xDoc.DefaultPageSettings.Margins.Left = 20
                xDoc.DefaultPageSettings.Margins.Top = 20
                xDoc.DefaultPageSettings.Margins.Right = 20
                xDoc.DefaultPageSettings.Margins.Bottom = 20
                xDoc.Print()
            End If
        End With

    End Sub

    Private Sub txtPaginaInicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaginaInicio.TextChanged
        If IsNumeric(Me.txtPaginaInicio.Text) Then
            If CInt(Me.txtPaginaInicio.Text) < 1 Then Me.txtPaginaInicio.Text = CStr(1)
            If CInt(Me.txtPaginaInicio.Text) > Me.xTotalPags Then Me.txtPaginaInicio.Text = CStr(Me.xTotalPags)
        Else
            Me.txtPaginaInicio.Text = CStr(1)
        End If
    End Sub

    Private Sub txtHasta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHasta.TextChanged
        If IsNumeric(Me.txtPaginaInicio.Text) Then
            If CInt(Me.txtHasta.Text) < 1 Then Me.txtHasta.Text = CStr(1)
            If CInt(Me.txtHasta.Text) > Me.xTotalPags Then Me.txtHasta.Text = CStr(Me.xTotalPags)
        Else
            Me.txtHasta.Text = CStr(xTotalPags)
        End If
    End Sub

    Private Sub frmImprimirTurno_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.ppcVales.Height = Me.Height - 80
    End Sub
End Class