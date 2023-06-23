Namespace Combustibles
    Public Class exEliminarEliminado : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "El combustible ya se encuentra desactivado.")
        End Sub

    End Class
End Namespace

