Imports Acceso
Imports Entidades.Acceso

Public Class frmUsuarios

    Private xUsuarios As List(Of iUsuario)

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Usuarios"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Try
            MostrarUsuarios(enEstadoUsuario.Activo)
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub MostrarUsuarios(ByVal prEstado As enEstadoUsuario)
        Try
            'MostrarLoading()
            xUsuarios = Acceso.clsUsuario.Listar(prEstado)
            Me.IUsuarioBindingSource.DataSource = xUsuarios
            'OcultarLoading()
        Catch ex As Exception
            'OcultarLoading()
            Throw
        End Try
    End Sub

    Private Sub rdActivos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdActivos.CheckedChanged
        If rdActivos.Checked Then
            MostrarUsuarios(enEstadoUsuario.Activo)
        Else
            MostrarUsuarios(enEstadoUsuario.Inactivo)
        End If
    End Sub

    Private Sub dgvUsuarios_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvUsuarios.SelectionChanged
        dgvUsuarios.ClearSelection()
    End Sub

    Private Sub dgvUsuarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick
        If e.RowIndex <> -1 And e.ColumnIndex = 4 Then
            frmUsuario.pdUsuario = xUsuarios(e.RowIndex)
            Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Usuario, "")
        End If

    End Sub
End Class