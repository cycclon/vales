Imports Entidades.Acceso
Imports Entidades.Bitacoras
Imports Acceso
Imports Bitacoras

Public Class frmUsuario

    Private Enum enOpciones
        Desactivar = 1
        Activar = 2
        CambiarPass = 3
    End Enum

    Private xUsuario As iUsuario
    Private xAccionOpcion As enOpciones

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Usuario"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
    End Sub

    Public Property pdUsuario() As iUsuario
        Get
            Return Me.xUsuario
        End Get
        Set(ByVal value As iUsuario)
            Me.xUsuario = value
            Try
                Me.MostrarUsuario()
            Catch ex As Exception
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
            End Try
        End Set
    End Property

    Private Sub MostrarUsuario()
        Try
            With Me.xUsuario
                Me.lblUsuario.Text = .pdUsername
                Me.lblTipoUsuario.Text = .pdTipo.ToString & ":"
                Me.lblNombre.Text = .pdNombreCompleto
                If .pdEstado = enEstadoUsuario.Activo Then
                    Me.pbEstado.Image = My.Resources.userazmed
                Else
                    Me.pbEstado.Image = My.Resources.userromed
                End If
            End With
            MostrarBitacoras()
            MostrarOpciones()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub MostrarOpciones()
        Dim xS As clsSesion = clsSesion.ObtenerInstancia
        Me.gbOpciones.Visible = True

        If xS.pdUsuario.pdTipo = enTipoUsuario.Administrador Then
            pbAcceso.Visible = True
            btnTarjeta.Visible = True
            If xS.pdUsuario.pdID = Me.xUsuario.pdID Then
                Me.pbOpcion.Image = My.Resources.llavenar30
                Me.btnOpcion.Text = "Cambiar Contraseña"
                Me.xAccionOpcion = enOpciones.CambiarPass
                Me.pbRestablecer.Visible = False
                Me.btnRestablecer.Visible = False
            Else
                Me.pbRestablecer.Visible = True
                Me.btnRestablecer.Visible = True
                If xUsuario.pdEstado = enEstadoUsuario.Activo Then
                    Me.pbOpcion.Image = My.Resources.userro30
                    Me.btnOpcion.Text = "Desactivar"
                    Me.xAccionOpcion = enOpciones.Desactivar
                Else
                    Me.pbOpcion.Image = My.Resources.useraz30
                    Me.btnOpcion.Text = "Activar"
                    Me.xAccionOpcion = enOpciones.Activar
                End If
            End If
        Else
            pbAcceso.Visible = False
            btnTarjeta.Visible = False
            If xS.pdUsuario.pdID = Me.xUsuario.pdID Then
                Me.pbOpcion.Image = My.Resources.llavenar30
                Me.btnOpcion.Text = "Cambiar Contraseña"
                Me.xAccionOpcion = enOpciones.CambiarPass
            Else
                Me.gbOpciones.Visible = False
            End If
            
        End If
    End Sub

    Private Sub MostrarBitacoras()
        Try
            Me.IBitacoraBindingSource.DataSource = Bitacoras.clsBitacora.Listar(Me.xUsuario.pdCredencial.pdUsername, 10)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Desactivar()
        Try
            Dim xR As MsgBoxResult = MsgBox("¿Está seguro que desea desactivar este usuario? Al hacerlo, el usuario no podrá iniciar sesión.", MsgBoxStyle.YesNo, xTitulo & "Desactivar Usuario")
            If xR = MsgBoxResult.Yes Then
                MostrarLoading()
                Me.xUsuario.Desactivar()
                OcultarLoading()
                Me.MostrarUsuario()
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                Me.CtrlMensaje.pdMensaje = "Usuario desactivado"
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Activar()
        Try
            Dim xR As MsgBoxResult = MsgBox("¿Está seguro que desea activar este usuario?", MsgBoxStyle.YesNo, xTitulo & "Desactivar Usuario")
            If xR = MsgBoxResult.Yes Then
                MostrarLoading()
                Me.xUsuario.Activar()
                OcultarLoading()
                Me.MostrarUsuario()
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                Me.CtrlMensaje.pdMensaje = "Usuario activado"
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub CambiarContraseña()
        Try
            frmCambiarContraseña.pdUsuario = Me.xUsuario
            Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.CambiarContraseña, "")
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnOpcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcion.Click
        Try
            Select Case Me.xAccionOpcion
                Case enOpciones.Activar
                    Me.Activar()
                Case enOpciones.CambiarPass
                    Me.CambiarContraseña()
                Case enOpciones.Desactivar
                    Me.Desactivar()
            End Select
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub btnRestablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestablecer.Click
        Try
            If MsgBox("¿Está seguro que desea reestablecer la contraseña de este usuario? Se le pedirá una nueva contraseña cuando el usuario inicie sesión nuevamente.", MsgBoxStyle.YesNo, xTitulo & "Reestablecer Contraseña") = MsgBoxResult.Yes Then
                Me.xUsuario.ReestablecerContraseña()
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                Me.CtrlMensaje.pdMensaje = "Contraseña reestablecida. Cuando el usuario inicie sesión nuevamente, deberá ingresar su nueva contraseña."
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub btnTarjeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTarjeta.Click
        Try
            If MsgBox("Al generar una nueva tarjeta de acceso, las anteriores (de existir) se eliminarán. ¿Desea continuar?", MsgBoxStyle.YesNo, xTitulo & "Generar Tarjeta de Acceso") = MsgBoxResult.Yes Then
                Me.xUsuario.pdCredencial.GenerarTarjeta()
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                Me.CtrlMensaje.pdMensaje = "Tarjeta de acceso generada correctamente."
                frmImprimirTarjeta.pdUsuario = Me.xUsuario
                frmImprimirTarjeta.Show()
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub
End Class