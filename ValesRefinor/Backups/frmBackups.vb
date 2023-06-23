Imports Entidades.CopiasDeRespaldo
Imports CopiasDeRespaldo

Public Class frmBackups

    Private xBackups As List(Of iBackup)
    Private xBases() As String = {"Bitacoras", "Vales"}
    Private WithEvents xBackupARestaurar As iBackup
    Private xRestaurada As Boolean = False

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Backups"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Try
            MostrarLoading()
            Me.MostrarBackups()
            Me.cmbBases.SelectedIndex = 0
            OcultarLoading()
        Catch ex As Exception
            OcultarLoading()
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub dgvClientes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvBackups.SelectionChanged
        Me.dgvBackups.ClearSelection()
    End Sub

    Private Sub MostrarBackups()
        Try
            Me.xBackups = clsBackup.Listar
            Me.IBackupBindingSource.DataSource = xBackups
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Try
            If MsgBox("¿Está seguro que desea geenerar una copia de respaldo de la base de " & Me.xBases(Me.cmbBases.SelectedIndex) & "?", MsgBoxStyle.YesNo, xTitulo & "Generar Backup") = MsgBoxResult.Yes Then
                Dim xB As New clsBackup(Me.xBases(Me.cmbBases.SelectedIndex))
                MostrarLoading()
                xB.Generar()
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                Me.CtrlMensaje.pdMensaje = "Se generó una copia de respaldo de la base de " & Me.xBases(Me.cmbBases.SelectedIndex) & " en la carpeta: " & xB.RutaBackups
                Me.MostrarBackups()
                OcultarLoading()
            End If
        Catch ex As Exception
            OcultarLoading()
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub dgvBackups_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBackups.CellContentClick
        Try
            Me.xRestaurada = False
            If e.RowIndex <> -1 Then
                Select Case e.ColumnIndex
                    Case 3
                        'RESTAURAR
                        If MsgBox("¿Está seguro que desea restaurar la base de datos a esta fecha? (Pueden perderse algunos datos si continúa)", MsgBoxStyle.YesNo, xTitulo & "Restaurar base de datos.") = MsgBoxResult.Yes Then
                            Me.xBackupARestaurar = Me.xBackups(e.RowIndex)
                            Me.xBackupARestaurar.Restaurar()
                            If xRestaurada Then
                                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                                Me.CtrlMensaje.pdMensaje = "La base de datos de " & xBackupARestaurar.pdBase.pdNombre & " fue restaurada a la fecha: " & xBackupARestaurar.pdFecha
                            End If
                        End If
                    Case 4
                        'ELIMINAR
                        If MsgBox("¿Está seguro que desea eliminar el backup seleccionado?", MsgBoxStyle.YesNo, xTitulo & "Restaurar base de datos.") = MsgBoxResult.Yes Then
                            Me.xBackupARestaurar = Me.xBackups(e.RowIndex)
                            Me.xBackupARestaurar.Eliminar()
                            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                            Me.CtrlMensaje.pdMensaje = "Backup eliminado correctamente."
                            Me.MostrarBackups()
                        End If
                End Select
            End If
        Catch ex As Exception
            OcultarLoading()
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub xBackupARestaurar_ArchivoNoEncontrado() Handles xBackupARestaurar.ArchivoNoEncontrado
        Try
            Dim xDA As New OpenFileDialog
            xDA.Multiselect = False
            xDA.DefaultExt = ".bak"
            If xDA.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.xBackupARestaurar.pdArchivo = xDA.FileName
                Me.xBackupARestaurar.Restaurar()
                Me.xRestaurada = True
            Else
                Me.xRestaurada = False
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = "No se pudo encontrar el archivo de copia de respaldo. Si el problema persiste, comuníquese con el administrador."
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub
End Class