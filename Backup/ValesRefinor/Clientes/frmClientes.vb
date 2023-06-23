Imports Entidades.Clientes
Imports ReglasNegocio.Clientes

Public Class frmClientes

    Private xClientes As List(Of iCliente)

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Usuarios"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Try
            MostrarClientes(enEstadoCliente.Activo)
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub MostrarClientes(ByVal prEstado As enEstadoCliente)
        Try
            MostrarLoading()
            Me.xClientes = clsCliente.Listar(prEstado)
            OcultarLoading()
            Me.IClienteBindingSource.DataSource = xClientes
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub rdActivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdActivos.CheckedChanged
        Try
            If rdActivos.Checked Then
                MostrarClientes(enEstadoCliente.Activo)
            Else
                MostrarClientes(enEstadoCliente.Inactivo)
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub dgvClientes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvClientes.SelectionChanged
        Me.dgvClientes.ClearSelection()
    End Sub

    Private Sub dgvClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        If e.RowIndex <> -1 And e.ColumnIndex = 2 Then
            frmCliente.pdCliente = xClientes(e.RowIndex)
            MostrarLoading()
            Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Cliente, "")
            OcultarLoading()
        End If
    End Sub
End Class