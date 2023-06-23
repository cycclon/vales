Imports Acceso
Imports PRS.Framework.Validacion

Public Class frmLogin
    Private xVLogin As clsValidador

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Iniciar Sesión"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Me.ctrlAUsername.Parent = Me
        Me.ctrlAPassword.Parent = Me
        Me.ctrlAUsername.BackColor = Color.Transparent
        Me.ctrlAPassword.BackColor = Color.Transparent
        ValidacionYAyuda()
        Me.ControlarLogueo()
    End Sub

    Private Sub ControlarLogueo()
        Dim xS As clsSesion = clsSesion.ObtenerInstancia
        If xS.UsuarioLogueado Then
            If xS.pdUsuario.pdTipo = Entidades.Acceso.enTipoUsuario.Administrador Then
                Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Inicio, "")
            Else
                Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Descargar, "")
            End If
        End If
    End Sub

    Private Sub ValidacionYAyuda()
        Dim valUsuario As New Validacion.Acceso.vUsuario
        Me.xVLogin = New clsValidador
        xVLogin.pdCampos.Add(New clsCampoTexto("Nombre de usuario", Me.txtUsername))
        xVLogin.pdCampos.Add(New clsCampoTexto("Contraseña", Me.txtPassword))

        With valUsuario


            'Me.txtPassword.Validation = .exPassword
            'Me.txtPassword.pdFormatErrorMessage = .msgPassword
            'Me.txtPassword.pdRequiredErrorMessage = .msgRPassword

            'Me.txtUsername.Validation = .exUsername
            'Me.txtUsername.pdRequiredErrorMessage = .msgRUsername
            'Me.txtUsername.pdFormatErrorMessage = .msgUsername

            Me.ctrlAPassword.pdAyuda = .HelpPassword
            Me.ctrlAUsername.pdAyuda = .HelpUsername
        End With
    End Sub

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        frmPrincipal.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Me.CtrlMensaje.pdErrores.Clear()
            If Me.xVLogin.Validar Then
                Dim xSesion As Acceso.clsSesion = Acceso.clsSesion.ObtenerInstancia
                Dim xF As Boolean
                ''MostrarLoading()
                xF = xSesion.Iniciar(Me.txtUsername.Text, Me.txtPassword.Text)

                If Not xF Then
                    ''OcultarLoading()
                    Me.lblPass2.Visible = True
                    Me.txtPassword2.Visible = True
                    If txtPassword2.Text <> "" Then
                        'MostrarLoading()
                        xSesion.EstablecerContraseña(Me.txtUsername.Text, Me.txtPassword.Text, Me.txtPassword2.Text)
                    End If
                End If

                If xSesion.UsuarioLogueado Then
                    frmPrincipal.BotonesLogin()
                    frmPrincipal.CtrlMenu1.MostrarMenu()
                    ''OcultarLoading()

                    If xSesion.pdUsuario.pdTipo = Entidades.Acceso.enTipoUsuario.Administrador Then
                        Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Inicio, "Sesión iniciada correctamente")
                    Else
                        Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Descargar, "")
                    End If
                End If
            Else
                Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = xErrorCampo
            End If
        Catch ex As Exception
            ''OcultarLoading()
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = mGlobal.ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress, txtPassword2.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnAceptar_Click(Me, EventArgs.Empty)
        End If
    End Sub


End Class