Namespace Clientes
    Public Class exDesactivarDesactivado : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "El cliente ya fue eliminado.")
        End Sub

    End Class
End Namespace

