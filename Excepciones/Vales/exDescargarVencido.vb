Namespace Vales
    Public Class exDescargarVencido : Inherits Exception

        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "El vale seleccionado no se puede descargar porque ya pas� su fecha de vencimiento.")
        End Sub

    End Class
End Namespace

