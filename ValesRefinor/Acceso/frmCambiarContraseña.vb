Imports Acceso
Imports Entidades.Acceso
Imports PRS.Framework.Validacion

Public Class frmCambiarContraseña

    Private xUsuario As iUsuario
    Private xVCambiarPass As clsValidador

    Public Property pdUsuario() As iUsuario
        Get
            Return Me.xUsuario
        End Get
        Set(ByVal value As iUsuario)
            Me.xUsuario = value
        End Set
    End Property

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Cambiar mi Contraseña"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Me.ctrlAPassActual.Parent = Me
        Me.ctrlAPassword.Parent = Me
        Me.ctrlAPassActual.BackColor = Color.Transparent
        Me.ctrlAPassword.BackColor = Color.Transparent
        ValidacionYAyuda()
    End Sub

    Private Sub ValidacionYAyuda()
        Dim valUsuario As New Validacion.Acceso.vUsuario
        xVCambiarPass = New clsValidador
        xVCambiarPass.pdCampos.Add(New clsCampoTexto("Contraseña actual", Me.txtPassActual))
        xVCambiarPass.pdCampos.Add(New clsCampoTexto("Nueva contraseña", Me.txtPassNueva))

        With valUsuario
            Me.ctrlAPassword.pdAyuda = .HelpPassword
            Me.ctrlAPassActual.pdAyuda = .HelpPassword
        End With
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            Me.CtrlMensaje.pdErrores.Clear()
            If Me.xVCambiarPass.Validar Then
                xUsuario.ActualizarContraseña(Me.txtPassActual.Text, Me.txtPassNueva.Text, Me.txtPassNueva2.Text)
                frmUsuario.pdUsuario = Me.xUsuario
                Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Usuario, "Contraseña actualizada correctamente")
            Else
                Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = xErrorCampo
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

End Class