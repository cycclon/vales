Imports Entidades.Clientes
Imports ReglasNegocio.Clientes
Imports Entidades.Cuentas

Public Class frmCuenta

    Private xCliente As iCliente

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Cuenta"
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
                Me.MostrarCuenta()
            Catch ex As Exception
                Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
            End Try
        End Set
    End Property

    Private Sub MostrarCuenta()
        Try
            With Me.xCliente.pdCuenta
                Me.lblNombre.Text = Me.xCliente.pdNombreCompleto
                Me.lblSaldoLitros.Text = Format(.pdSaldoCombustible, "0.00") & " lts."
                Me.lblSaldoPesos.Text = "$" & Format(.pdSaldoDinero, "0.00")
                Dim xDetalle As List(Of iDisponibilidadCombustible) = .pdDetalleCombustibles
                Me.IDisponibilidadCombustibleBindingSource.DataSource = xDetalle
            End With
            Me.MostrarUltimosMovimientos()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub MostrarUltimosMovimientos()
        Try
            Me.IMovimientoBindingSource.DataSource = Me.xCliente.pdCuenta.UltimosMovimientos
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnOpcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcion.Click
        Try
            frmCliente.pdCliente = Me.xCliente
            Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Cliente, "")
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub dgvUltimosMovimientos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvUltimosMovimientos.SelectionChanged
        Me.dgvUltimosMovimientos.ClearSelection()
    End Sub

   
    Private Sub btnDetalleCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalleCuenta.Click
        frmMovimientos.pdCliente = Me.xCliente
        Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Movimientos, "")
    End Sub
End Class