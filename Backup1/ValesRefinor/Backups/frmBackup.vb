Imports Entidades.CopiasDeRespaldo
Imports CopiasDeRespaldo
Imports System.IO
Imports PRS.Framework.Validacion

Public Class frmBackup
    Private xBackups As List(Of iBackup)
    Private xBases() As String = {"Bitacoras", "Vales"}
    Private WithEvents xBackupARestaurar As iBackup
    Private xRestaurada As Boolean = False

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Backups"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Try

            Me.ObtenerUnidades()
            Me.cmbBases.SelectedIndex = 0

        Catch ex As Exception

            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub ObtenerUnidades()
        Me.cmbUnidades.Items.Clear()
        For Each xx As DriveInfo In DriveInfo.GetDrives
            Me.cmbUnidades.Items.Add(xx.Name)
        Next
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Try
            If MsgBox("¿Está seguro que desea geenerar una copia de respaldo de la base de " & Me.xBases(Me.cmbBases.SelectedIndex) & "?", MsgBoxStyle.YesNo, xTitulo & "Generar Backup") = MsgBoxResult.Yes Then
                Dim xB As New clsBackup(Me.xBases(Me.cmbBases.SelectedIndex))
                'MostrarLoading()
                xB.Generar(CStr(Me.cmbUnidades.SelectedItem))
                Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.Mensaje
                Me.CtrlMensaje.pdMensaje = "Se generó una copia de respaldo de la base de " & Me.xBases(Me.cmbBases.SelectedIndex) & " en la unidad: " & Me.cmbUnidades.SelectedItem.ToString

                'OcultarLoading()
            End If
        Catch ex As Exception
            'OcultarLoading()
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Me.ObtenerUnidades()
    End Sub


    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If ofdBackup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lblArchivo.Text = ofdBackup.FileName
            Me.btnRestaurar.Enabled = True
        Else
            Me.lblArchivo.Text = "Archivo no seleccionado"
            Me.btnRestaurar.Enabled = False
        End If
    End Sub

    Private Sub btnRestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurar.Click
        Try
            If MsgBox("¿Está seguro que desea restaurar la base de datos con el archivo seleccionado?", MsgBoxStyle.YesNo, "Restaurar base") = MsgBoxResult.Yes Then
                'MostrarLoading()
                clsBackup.Restaurar(Me.ofdBackup.FileName)
                'OcultarLoading()

                Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.Mensaje
                Me.CtrlMensaje.pdMensaje = "Se restauró la base de datos correctamente."
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub
End Class