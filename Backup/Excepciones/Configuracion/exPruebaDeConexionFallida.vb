Namespace Configuracion
    Public Class exPruebaDeConexionFallida : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "Prueba de conexi�n fallida. Compruebe el nombre del servidor, su conexi�n LAN o la configuraci�n del servidor.")
        End Sub

    End Class
End Namespace

