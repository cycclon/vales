Namespace Acceso
    Public Class exActivarActivado : Inherits Exception
        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "El usuario ya se encuentra activo.")
        End Sub
    End Class
End Namespace

