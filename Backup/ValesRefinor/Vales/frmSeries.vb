Imports Entidades.Vales
Imports Entidades.Clientes
Imports ReglasNegocio.Clientes
Imports ReglasNegocio.Vales

Public Class frmSeries

    Private xSeries As List(Of iSerie)
    Private xClientes As List(Of iCliente)

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Emisiones"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Try
            Me.MostrarClientes()
            Me.MostrarSeries(CInt(Me.cmbClientes.SelectedValue))

        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub MostrarClientes()
        Try
            xClientes = clsCliente.Listar
            Me.IClienteBindingSource.DataSource = xClientes
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub MostrarSeries(ByVal prCliente As Integer)
        Try
            MostrarLoading()
            Me.xSeries = clsSerie.Listar(CInt(Me.cmbClientes.SelectedValue))
            Me.ISerieBindingSource.DataSource = Me.xSeries
            OcultarLoading()
        Catch ex As Exception
            OcultarLoading()
            Throw
        End Try
    End Sub

    Private Sub dgvClientes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvVales.SelectionChanged
        Me.dgvVales.ClearSelection()
    End Sub

    Private Sub dgvClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVales.CellContentClick
        If e.RowIndex <> -1 And e.ColumnIndex = 3 Then
            frmSerie.pdSerie = Me.xSeries(e.RowIndex)
            Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.VerSerie, "")
        End If
    End Sub

    Private Sub cmbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClientes.SelectedIndexChanged
        Try
            If Me.cmbClientes.SelectedIndex <> -1 Then
                Me.MostrarSeries(CInt(cmbClientes.SelectedValue))
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub
End Class