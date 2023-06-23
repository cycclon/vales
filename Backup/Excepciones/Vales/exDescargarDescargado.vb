Namespace Vales
    Public Class exDescargarDescargado : Inherits Exception
        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "El vale seleccionado ya fue descargado.")
        End Sub
    End Class
End Namespace

