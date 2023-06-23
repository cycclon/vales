Namespace Clientes
    Public Class exActivarActivado : Inherits Exception

        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "El cliente ya fue restaurado.")
        End Sub

    End Class
End Namespace

