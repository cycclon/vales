Namespace Vales
    Public Class exCancelarCancelado : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "El vale ya fue cancelado.")
        End Sub

    End Class
End Namespace

