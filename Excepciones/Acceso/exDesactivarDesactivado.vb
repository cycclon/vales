Namespace Acceso
    Public Class exDesactivarDesactivado : Inherits Exception
        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "El usuario ya se encuentra desactivado.")
        End Sub

    End Class
End Namespace

