Imports Acceso
Imports ReglasNegocio.Configuracion
Imports System.Threading

Public Class frmPrincipal

    Private Sub frmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim xR As MsgBoxResult = MsgBox("¿Está seguro que desea cerrar la aplicación?", MsgBoxStyle.YesNo, xTitulo & "Salir")
        If xR = MsgBoxResult.No Then e.Cancel = True
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim handler As ThreadExceptionHandler = _
            New ThreadExceptionHandler()

        AddHandler Application.ThreadException, _
            AddressOf handler.Application_ThreadException

        Dim xEmpresa As clsEmpresa = clsEmpresa.Instanciar(mGlobal.xEmpresa)
        Me.pbEncabezado.Image = xEmpresa.pdEncabezado
        If clsGestorConfiguracion.ComprobarArchivos Then
            Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Descargar, "")
        Else
            frmConfigurar.Show()
        End If
        Me.CtrlMenu1.MostrarMenu()
        Me.btnCerrarSesion.Parent = Me.pbEncabezado
        Me.btnUsuario.Parent = Me.pbEncabezado
        Me.pbUsuario.Parent = Me.pbEncabezado
        Try
            Me.Enabled = False
            'MostrarLoading()
            Dim xS As clsSesion = clsSesion.ObtenerInstancia
            xS.Iniciar(New List(Of Char))
            'OcultarLoading()
            Me.Enabled = True
        Catch ex As Exception
            'OcultarLoading()
            Me.Enabled = True
        End Try
    End Sub

    Private Sub btnCerrarSesion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.MouseHover
        Me.btnCerrarSesion.ForeColor = Color.White
    End Sub

    Private Sub btnCerrarSesion_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.MouseLeave
        Me.btnCerrarSesion.ForeColor = Color.Silver
    End Sub

    Friend Sub BotonesLogin()
        Dim xSesion As Acceso.clsSesion = Acceso.clsSesion.ObtenerInstancia
        Me.btnCerrarSesion.Visible = xSesion.UsuarioLogueado
        Me.btnUsuario.Visible = xSesion.UsuarioLogueado
        Me.pbUsuario.Visible = xSesion.UsuarioLogueado
        If xSesion.UsuarioLogueado Then Me.btnUsuario.Text = xSesion.pdUsuario.pdCredencial.pdUsername
    End Sub

    Private Sub btnUsuario_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUsuario.MouseHover
        btnUsuario.ForeColor = Color.White
    End Sub

    Private Sub btnUsuario_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUsuario.MouseLeave
        btnUsuario.ForeColor = Color.Silver
    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        Try
            Dim xR As Microsoft.VisualBasic.MsgBoxResult = MsgBox("¿Está seguro que desea cerrar su sesión?", MsgBoxStyle.YesNo, xTitulo & "Cerrar Sesión")
            If xR = MsgBoxResult.Yes Then
                Dim xSesion As Acceso.clsSesion = Acceso.clsSesion.ObtenerInstancia
                xSesion.Cerrar()
                Me.BotonesLogin()
                Me.CtrlMenu1.MostrarMenu()
                Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Login, "")
                Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Descargar, "")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuario.Click
        Dim xS As clsSesion = clsSesion.ObtenerInstancia
        frmUsuario.pdUsuario = xS.pdUsuario
        Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Usuario, "")
    End Sub

    Friend Class ThreadExceptionHandler

        '''
        ''' Handles the thread exception.
        '''
        Public Sub Application_ThreadException( _
            ByVal sender As System.Object, _
            ByVal e As ThreadExceptionEventArgs)

            Try
                ' Exit the program if the user clicks Abort.
                Dim result As DialogResult = Windows.Forms.DialogResult.Ignore

                If (result = DialogResult.Abort) Then
                    Application.Exit()
                End If
            Catch
                ' Fatal error, terminate program
                Try
                    'MessageBox.Show("Fatal Error", _
                    '    "Fatal Error", _
                    '    MessageBoxButtons.OK, _
                    '    MessageBoxIcon.Stop)
                Finally
                    Application.Exit()
                End Try
            End Try
        End Sub

        '''
        ''' Creates and displays the error message.
        '''
        Private Function ShowThreadExceptionDialog( _
            ByVal ex As Exception) As DialogResult

            Dim errorMessage As String = _
                "Unhandled Exception:" _
                & vbCrLf & vbCrLf & _
                ex.Message & vbCrLf & vbCrLf & _
                ex.GetType().ToString() & vbCrLf & vbCrLf & _
                "Stack Trace:" & vbCrLf & _
                ex.StackTrace

            Return MessageBox.Show(errorMessage, _
                "Application Error", _
                MessageBoxButtons.AbortRetryIgnore, _
                MessageBoxIcon.Stop)
        End Function

    End Class
End Class
