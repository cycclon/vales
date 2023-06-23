Namespace Combustibles
    Public Class exActivarActivado : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "El combustible ya se encuentra activo.")
        End Sub

    End Class
End Namespace

