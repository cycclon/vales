Imports Entidades.Acceso
Imports Acceso
Imports PRS.Framework.Validacion

Public Class frmNuevoUsuario
    Private xVNuevoUsuario As clsValidador

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Registrar Usuario"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill

        ValidacionyAyuda()
    End Sub

    Private Sub ValidacionyAyuda()
        Dim valUsuario As New Validacion.Acceso.vUsuario
        Me.xVNuevoUsuario = New clsValidador
        Me.xVNuevoUsuario.pdCampos.Add(New clsCampoTexto("Nombre", Me.txtNombre))
        Me.xVNuevoUsuario.pdCampos.Add(New clsCampoTexto("Apellido", Me.txtApellido))
        Me.xVNuevoUsuario.pdCampos.Add(New clsCampoTexto("Nombre de usuario", Me.txtUsuario))

        With valUsuario
            Me.ctrlAApellido.pdAyuda = .HelpApellido
            Me.ctrlANombre.pdAyuda = .HelpNombre
            Me.ctrlAUsuario.pdAyuda = .HelpUsername
            Me.ctrlATipo.pdAyuda = "El tipo de usuario determinará el nivel de acceso."
        End With
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Me.CtrlMensaje.pdErrores.Clear()
            Dim xTipo As String = ""
            If Me.rdAdministrador.Checked Then
                xTipo = "Administrador"
            Else
                xTipo = "Empleado"
            End If
            Dim xR As MsgBoxResult = MsgBox("¿Está seguro que desea registrar este " & xTipo & "?", MsgBoxStyle.YesNo, xTitulo & "Nuevo Usuario")
            If xR = MsgBoxResult.Yes Then
                If Me.xVNuevoUsuario.Validar Then
                    'REGISTRAR USUARIO
                    Dim xUsuario As iUsuario
                    If Me.rdAdministrador.Checked Then
                        xUsuario = clsFabricaUsuarios.Fabricar(enTipoUsuario.Administrador)
                    Else
                        xUsuario = clsFabricaUsuarios.Fabricar(enTipoUsuario.Empleado)
                    End If

                    'ESTABLECER PROPIEDADES
                    xUsuario.pdNombre = Me.txtNombre.Text
                    xUsuario.pdApellido = Me.txtApellido.Text
                    xUsuario.pdCredencial.pdUsername = Me.txtUsuario.Text

                    'REGISTAR
                    xUsuario.Registrar()

                    Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.VerUsuarios, "Usuario registrado correctamente. Cuando el usuario inicie sesión, establecerá su contraseña.")
                Else
                    Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
                    Me.CtrlMensaje.pdMensaje = xErrorCampo
                End If
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

End Class