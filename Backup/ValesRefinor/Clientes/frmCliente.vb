Imports Entidades.Clientes
Imports ReglasNegocio.Clientes

Public Class frmCliente

    Private Enum Accion
        Activar = 1
        Desactivar = 2
    End Enum

    Private xAccion As Accion
    Private xCliente As iCliente

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Cliente"
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
                Me.MostrarCliente()
            Catch ex As Exception
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
            End Try
        End Set
    End Property

    Private Sub MostrarCliente()
        Try
            With Me.xCliente
                If xCliente.pdEstado = enEstadoCliente.Activo Then
                    Me.pbEstado.Image = My.Resources.cliaz50
                    Me.MostrarDesactivar()
                Else
                    Me.pbEstado.Image = My.Resources.cliro50
                    Me.MostrarActivar()
                End If
                Me.lblNombre.Text = xCliente.pdNombreCompleto
                Me.lblSaldoLitros.Text = Format(.pdCuenta.pdSaldoCombustible, "0.00") & " lts."
                Me.lblSaldoPesos.Text = "$" & Format(.pdCuenta.pdSaldoDinero, "0.00")
            End With

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub MostrarActivar()
        Me.btnOpcion.Text = "Activar"
        Me.pbOpcion.Image = My.Resources.cliaz30
        Me.xAccion = Accion.Activar
    End Sub

    Private Sub MostrarDesactivar()
        Me.btnOpcion.Text = "Desactivar"
        Me.pbOpcion.Image = My.Resources.cliro30
        Me.xAccion = Accion.Desactivar
    End Sub

    Private Sub btnOpcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcion.Click
        Try
            Dim xR As MsgBoxResult = MsgBox("¿Está seguro que desea " & Me.xAccion.ToString & " este cliente?", MsgBoxStyle.YesNo, xTitulo & Me.xAccion.ToString & " cliente")
            If xR = MsgBoxResult.Yes Then
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                Select Case Me.xAccion
                    Case Accion.Activar
                        xCliente.Restaurar()
                        Me.CtrlMensaje.pdMensaje = "Cliente activado correctamente."
                    Case Accion.Desactivar
                        xCliente.Eliminar()
                        Me.CtrlMensaje.pdMensaje = "Cliente desactivado correctamente."
                End Select
                Me.MostrarCliente()
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub btnDetalleCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalleCuenta.Click
        frmCuenta.pdCliente = Me.xCliente
        Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Cuenta, "")
    End Sub
End Class