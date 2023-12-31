' Static Model


Namespace Acceso

    Public Class vUsuario

        Private xCUsername As New List(Of enComponenteValidacion)

        Private xCPassword As New List(Of enComponenteValidacion)

        Private xCNombre As New List(Of enComponenteValidacion)

        Private xCApellido As New List(Of enComponenteValidacion)

        Public Sub New()
            xCUsername.Add(enComponenteValidacion.letras)
            xCUsername.Add(enComponenteValidacion.numeros)
            xCUsername.Add(enComponenteValidacion.punto)
            xCUsername.Add(enComponenteValidacion.guion)
            xCUsername.Add(enComponenteValidacion.guionbajo)

            xCPassword.Add(enComponenteValidacion.letras)
            xCPassword.Add(enComponenteValidacion.numeros)

            xCNombre.Add(enComponenteValidacion.letras)
            xCNombre.Add(enComponenteValidacion.espacio)
            xCNombre.Add(enComponenteValidacion.punto)

            xCApellido.Add(enComponenteValidacion.letras)
            xCApellido.Add(enComponenteValidacion.espacio)
            xCApellido.Add(enComponenteValidacion.punto)
        End Sub

        Public Function exUsername() As String
            Return ValidacionGeneral.Texto(3, 15, Me.xCUsername)
        End Function

        Public Function exPassword() As String
            Return ValidacionGeneral.Texto(8, 15, Me.xCUsername)
        End Function

        Public Function exNombre() As String
            Return ValidacionGeneral.Texto(2, 50, Me.xCNombre)
        End Function

        Public Function exApellido() As String
            Return ValidacionGeneral.Texto(2, 50, Me.xCApellido)
        End Function

        Public Function msgUsername() As String
            Return "Error en el formato del nombre de usuario."
        End Function

        Public Function msgPassword() As String
            Return "Error en el formato de la contraseña."
        End Function

        Public Function msgNombre() As String
            Return "Error en el formato del nombre."
        End Function

        Public Function msgApellido() As String
            Return "Error en el formato del apellido"
        End Function

        Public Function msgRUsername() As String
            Return "Debe ingresar el nombre de usuario."
        End Function

        Public Function msgRPassword() As String
            Return "Debe ingresar la contraseña."
        End Function

        Public Function msgRNombre() As String
            Return "Debe ingresar el nombre"
        End Function

        Public Function msgRApellido() As String
            Return "Debe ingresar el apellido"
        End Function

        Public Function HelpUsername() As String
            Return "Apodo del usuario. " & ValidacionGeneral.msgTexto(3, 15, Me.xCNombre)
        End Function

        Public Function HelpPassword() As String
            Return ValidacionGeneral.msgTexto(8, 15, Me.xCPassword)
        End Function

        Public Function HelpNombre() As String
            Return ValidacionGeneral.msgTexto(2, 50, Me.xCNombre)
        End Function

        Public Function HelpApellido() As String
            Return ValidacionGeneral.msgTexto(2, 50, Me.xCApellido)
        End Function

    End Class ' END CLASS DEFINITION vUsuario

End Namespace ' Validacion.Acceso

