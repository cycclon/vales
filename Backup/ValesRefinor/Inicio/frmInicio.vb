Imports ReglasNegocio
Public Class frmInicio

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Inicio"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Try
            Me.MostrarEstadisticas()
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub MostrarEstadisticas()
        Try
            MostrarLoading()
            Dim xG As clsGestorEstadisticas = clsGestorEstadisticas.Instanciar
            With xG
                'VALES
                Me.lblDinero.Text = "$" & Format(.DineroEmitido, "0.00")
                Me.lblCombustible.Text = .CombustibleEmitido & " lts."
                Me.lblDineroRestante.Text = "$" & Format(.DineroRestante, "0.00")
                Me.lblCombustibleRestante.Text = .CombustibleRestante & " lts."

                ''DIAS Y TURNOS
                Me.lblDia.Text = .DiaDeMasDescargas
                Me.lblPromedioCombustible.Text = Format(.PromedioDescargasCombustibleDia, "0.00") & " lts."
                Me.lblPromedioDinero.Text = "$" & Format(.PromedioDescargasDineroDia, "0.00")

                ''USUARIOS
                Me.lblAdministradores.Text = .CantidadAdministradores.ToString
                Me.lblEmpleados.Text = .CantidadEmpleados.ToString
                Me.lblEmpleadoMayorDescarga.Text = .EmpleadoQueMasDescarga
            End With
            OcultarLoading()
        Catch ex As Exception
            OcultarLoading()
            Throw
        End Try
    End Sub
End Class