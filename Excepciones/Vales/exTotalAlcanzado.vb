Namespace Vales
    Public Class exTotalAlcanzado : Inherits Exception

        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "La distribuci�n ingresada supera el total de la serie.")
        End Sub

    End Class
End Namespace

