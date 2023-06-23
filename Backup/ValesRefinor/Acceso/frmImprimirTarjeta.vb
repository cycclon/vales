Imports System.Drawing.Printing
Imports Entidades.Acceso
Imports Acceso

Public Class frmImprimirTarjeta

    Private xDoc As PrintDocument

    Private xUsuario As iUsuario

    Public Property pdUsuario() As iUsuario
        Get
            Return Me.xUsuario
        End Get
        Set(ByVal value As iUsuario)
            Me.xUsuario = value
            Me.CrearDocumento()
        End Set
    End Property

    Private Sub CrearDocumento()
        Try
            xDoc = New PrintDocument

            AddHandler xDoc.PrintPage, AddressOf Imprimir
            xDoc.DocumentName = "Tarjeta de Acceso para " & xUsuario.pdNombreCompleto
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
        Dim xP As New Pen(Color.Black, 1)
        xP.DashStyle = Drawing2D.DashStyle.Dash
        e.Graphics.DrawString("Tarjeta de acceso de: ", New Font("Verdana", 10, FontStyle.Regular), Brushes.Black, 180, 290)
        e.Graphics.DrawString(xUsuario.pdNombreCompleto, New Font("Verdana", 10, FontStyle.Bold), Brushes.Black, 345, 290)
        e.Graphics.DrawString(Me.xUsuario.pdCredencial.pdTarjetaAcceso.pdID, New Font("IDAutomationHC39M", 12, FontStyle.Regular), Brushes.Black, 275, 350)
        e.Graphics.DrawString("Para uso exclusivo del personal de: LAS MARIAS S.R.L.", New Font("Verdana", 8, FontStyle.Italic), Brushes.Black, 200, 460)
        e.Graphics.DrawString("No preste ni transfiera esta credencial a otros miembros de personal o particulares.", New Font("Verdana", 8, FontStyle.Italic), Brushes.Black, 180, 480)
        e.Graphics.DrawLine(xP, 170, 500, 670, 500)
        e.Graphics.DrawRectangle(xP, 170, 250, 500, 500)

        Dim xF As New Font("Verdana", 8, FontStyle.Regular)
        e.Graphics.DrawString("Instrucciones de uso:", New Font("Verdana", 10, FontStyle.Bold), Brushes.Black, 180, 530)
        e.Graphics.DrawString("1) Abra la aplicación SIV cuyo ícono se encuentra en el escritorio.", xF, Brushes.Black, 190, 550)
        e.Graphics.DrawString("2) Escanee esta tarjeta con el lector de código de barras.", xF, Brushes.Black, 190, 570)
        e.Graphics.DrawString("3) Escanee el vale con el mismo lector de código de barras.", xF, Brushes.Black, 190, 590)
        e.Graphics.DrawString("4) Compruebe que los datos en pantalla se corresponden con los del vale recibido.", xF, Brushes.Black, 190, 610)
        e.Graphics.DrawString("5) Efectue la carga de combustible al cliente.", xF, Brushes.Black, 190, 630)
        e.Graphics.DrawString("6) Presione el botón descargar.", xF, Brushes.Black, 190, 650)

        e.Graphics.DrawString("En caso de pérdida, robo o daño de esta credencial, informe a un administrador.", New Font("Verdana", 8, FontStyle.Italic), Brushes.Black, 180, 730)

        e.HasMorePages = False

        e.HasMorePages = False
    End Sub

    Private Sub frmImprimir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ppcVales.Show()
        'Me.txtPaginaInicio.Text = 1
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim xSettings As New PrintDialog
        With xSettings
            .AllowSelection = True
            .AllowPrintToFile = False
            .PrintToFile = False
            .AllowSomePages = False

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                xDoc.PrinterSettings = .PrinterSettings
                xDoc.DefaultPageSettings.Margins.Left = 20
                xDoc.DefaultPageSettings.Margins.Top = 20
                xDoc.DefaultPageSettings.Margins.Right = 20
                xDoc.DefaultPageSettings.Margins.Bottom = 20
                xDoc.Print()
            End If
        End With

    End Sub

    Private Sub frmImprimirTarjeta_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.ppcVales.Height = Me.Height - 80
    End Sub
End Class