Imports Entidades.Clientes
Imports ReglasNegocio.Clientes

Public Class frmMovimientos

    Private xCliente As iCliente

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Movimientos"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
    End Sub

    Public Property pdCliente() As iCliente
        Get
            Return Me.xCliente
        End Get
        Set(ByVal value As iCliente)
            Me.xCliente = value
            Try
                Me.MostrarMovimientos()
            Catch ex As Exception
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
            End Try
        End Set
    End Property

    Private Sub MostrarMovimientos()
        Try
            With Me.xCliente.pdCuenta
                Me.lblNombre.Text = Me.xCliente.pdNombreCompleto
                Me.IMovimientoBindingSource.DataSource = .pdMovimientos
            End With
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub dgvUltimosMovimientos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvUltimosMovimientos.SelectionChanged
        Me.dgvUltimosMovimientos.ClearSelection()
    End Sub

    Private Sub btnOpcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcion.Click
        frmCuenta.pdCliente = Me.xCliente
        Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Cuenta, "")
    End Sub
End Class