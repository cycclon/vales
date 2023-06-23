Namespace Turnos
    Public Class exDiaNoSeleccionado : Inherits Exception

        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "No seleccionó ningún día de la semana.")
        End Sub

    End Class
End Namespace

