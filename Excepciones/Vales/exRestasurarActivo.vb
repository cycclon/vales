Namespace Vales
    Public Class exRestaurarActivo : Inherits Exception
        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "El vale ya se encuentra activo.")
        End Sub
    End Class
End Namespace

