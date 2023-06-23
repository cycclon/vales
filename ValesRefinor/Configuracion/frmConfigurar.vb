Imports ReglasNegocio.Configuracion
Imports PRS.Framework.Validacion

Public Class frmConfigurar

    Private xVServidor As clsValidador

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Configurar"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Me.txtServidor.Focus()
        Me.Validacion()
    End Sub

    Private Sub Validacion()
        Me.xVServidor = New clsValidador
        xVServidor.pdCampos.Add(New clsCampoTexto("Servidor", Me.txtServidor))
    End Sub

    Private Sub btnProbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProbar.Click
        Try
            If xVServidor.Validar Then
                'MostrarLoading()
                clsGestorConfiguracion.ProbarConexion(Me.txtServidor.Text)
                'OcultarLoading()
                Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.Mensaje
                Me.CtrlMensaje.pdMensaje = "Prueba de conexión satisfactoria. Presione el botón 'Establecer Servidor' para comenzar a utilizar la aplicación."
                Me.btnEstablecer.Visible = True
                Me.txtServidor.Enabled = False
            End If
        Catch ex As Exception
            'OcultarLoading()
            Me.btnEstablecer.Visible = False
            Me.txtServidor.Enabled = True
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub btnEstablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstablecer.Click
        Try
            'MostrarLoading()
            clsGestorConfiguracion.EstablecerServidor(Me.txtServidor.Text)
            'OcultarLoading()
            Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Login, "Servidor establecido. Ya puede comenzar a utilizar la aplicación.")
        Catch ex As Exception
            'OcultarLoading()
            Me.btnEstablecer.Visible = False
            Me.txtServidor.Enabled = True
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub
End Class