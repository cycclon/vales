Namespace Vales
    Public Class exDistribucionInsuficiente : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "La distribución de vales establecida es menor al total de la serie.")
        End Sub

    End Class
End Namespace

