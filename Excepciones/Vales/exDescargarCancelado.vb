Namespace Vales
    Public Class exDescargarCancelado : Inherits Exception

        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "El vale seleccionado no puede ser descargado porque fue reportado como extraviado / robado.")
        End Sub

    End Class
End Namespace

