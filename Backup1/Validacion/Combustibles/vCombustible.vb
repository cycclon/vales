Namespace Combustibles
    Public Class vCombustible
        Private xCNombre As New List(Of enComponenteValidacion)

        Public Function exNombre() As String
            Return ValidacionGeneral.Texto(2, 50, Me.xCNombre)
        End Function

        Public Function msgNombre() As String
            Return "Error en el formato del nombre del combustible."
        End Function

        Public Function msgRNombre() As String
            Return "Debe ingresar el nombre del combustible."
        End Function

        Public Function helpNombre() As String
            Return ValidacionGeneral.msgTexto(2, 50, Me.xCNombre)
        End Function
    End Class
End Namespace

