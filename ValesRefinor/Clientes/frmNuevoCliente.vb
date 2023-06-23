Imports Entidades.Clientes
Imports ReglasNegocio.Clientes
Imports Validacion.Clientes
Imports PRS.Framework.Validacion

Public Class frmNuevoCliente
    Private xVCliente As clsValidador

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Registrar Cliente"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill

        ValidacionyAyuda()
    End Sub

    Private Sub ValidacionyAyuda()
        Dim valCliente As New vCliente


        With valCliente
            If Me.rdPersona.Checked Then
                Me.ctrlANombre.pdAyuda = .helpNombre
            Else
                Me.ctrlANombre.pdAyuda = .helpRazonSocial
            End If
            Me.ctrlAApellido.pdAyuda = .helpApellido
        End With

        Me.ctrlATipo.pdAyuda = "Seleccione el tipo de cliente a registrar."
    End Sub

    Private Sub rdPersona_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdPersona.CheckedChanged

        xVCliente = New clsValidador

        Me.txtApellido.Visible = Me.rdPersona.Checked
        Me.ctrlAApellido.Visible = Me.rdPersona.Checked
        Me.lblApellido.Visible = Me.rdPersona.Checked
        If Me.rdPersona.Checked Then
            Me.lblNombre.Text = "Nombre:"
            Me.xVCliente.pdCampos.Add(New clsCampoTexto("Nombre", Me.txtNombre))
            Me.xVCliente.pdCampos.Add(New clsCampoTexto("Apellido", Me.txtApellido))
        Else
            Me.lblNombre.Text = "Razón Social:"
            Me.xVCliente.pdCampos.Add(New clsCampoTexto("Razón social", Me.txtNombre))
        End If

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Me.CtrlMensaje.pdErrores.Clear()
            If Me.xVCliente.Validar Then

                If Me.rdPersona.Checked Then
                    Dim xPersona As New clsPersona
                    xPersona.pdApellido = Me.txtApellido.Text
                    xPersona.pdNombre = Me.txtNombre.Text
                    xPersona.Registrar()
                Else
                    Dim xEntidad As New clsEntidad
                    xEntidad.pdRazonSocial = Me.txtNombre.Text
                    xEntidad.Registrar()
                End If

                Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Clientes, "Cliente registrado correctamente.")
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