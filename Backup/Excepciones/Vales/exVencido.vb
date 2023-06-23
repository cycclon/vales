Namespace Vales
    Public Class exVencido : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "El vale se encuentra vencido.")
        End Sub

    End Class

End Namespace
