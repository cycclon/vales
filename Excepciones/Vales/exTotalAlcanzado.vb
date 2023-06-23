Namespace Vales
    Public Class exTotalAlcanzado : Inherits Exception

        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "La distribución ingresada supera el total de la serie.")
        End Sub

    End Class
End Namespace

