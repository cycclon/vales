Namespace Vales
    Public Class exTotalAlcanzado : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "La distribución ingresada supera el total de la serie.")
        End Sub

    End Class
End Namespace

