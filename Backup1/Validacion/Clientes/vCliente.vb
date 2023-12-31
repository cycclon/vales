' Static Model


Namespace Clientes

    Public Class vCliente

        Private xCNombre As New List(Of enComponenteValidacion)
        Private xCApellido As New List(Of enComponenteValidacion)
        Private xCRazonSocial As New List(Of enComponenteValidacion)

        Public Sub New()
            Me.xCNombre.Add(enComponenteValidacion.letras)
            Me.xCNombre.Add(enComponenteValidacion.espacio)
            Me.xCNombre.Add(enComponenteValidacion.punto)

            Me.xCApellido.Add(enComponenteValidacion.letras)
            Me.xCApellido.Add(enComponenteValidacion.espacio)
            Me.xCApellido.Add(enComponenteValidacion.punto)

            Me.xCRazonSocial.Add(enComponenteValidacion.letras)
            Me.xCRazonSocial.Add(enComponenteValidacion.espacio)
            Me.xCRazonSocial.Add(enComponenteValidacion.punto)
        End Sub

        Public Function exNombre() As String
            Return ValidacionGeneral.Texto(2, 50, Me.xCNombre)
        End Function

        Public Function exApellido() As String
            Return ValidacionGeneral.Texto(2, 50, Me.xCApellido)
        End Function

        Public Function exRazonSocial() As String
            Return ValidacionGeneral.Texto(2, 50, Me.xCRazonSocial)
        End Function

        Public Function msgNombre() As String
            Return "Error en el formato del nombre del cliente."
        End Function

        Public Function msgApellido() As String
            Return "Error en el formato del apellido del cliente."
        End Function

        Public Function msgRazonSocial() As String
            Return "Error en el formato de la razón social del cliente."
        End Function

        Public Function msgRNombre() As String
            Return "Debe ingresar el nombre del cliente"
        End Function

        Public Function msgRApellido() As String
            Return "Debe ingresar el apellido del cliente."
        End Function

        Public Function msgRRazonSocial() As String
            Return "Debe ingresar la razón social del cliente."
        End Function

        Public Function helpNombre() As String
            Return ValidacionGeneral.msgTexto(2, 50, Me.xCNombre)
        End Function

        Public Function helpApellido() As String
            Return ValidacionGeneral.msgTexto(2, 50, Me.xCApellido)
        End Function

        Public Function helpRazonSocial() As String
            Return ValidacionGeneral.msgTexto(2, 50, Me.xCRazonSocial)
        End Function

    End Class ' END CLASS DEFINITION vCliente

End Namespace ' Validacion.Clientes

