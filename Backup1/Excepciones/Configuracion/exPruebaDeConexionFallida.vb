Namespace Configuracion
    Public Class exPruebaDeConexionFallida : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "Prueba de conexión fallida. Compruebe el nombre del servidor, su conexión LAN o la configuración del servidor.")
        End Sub

    End Class
End Namespace

