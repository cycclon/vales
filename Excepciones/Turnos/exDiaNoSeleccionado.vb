Namespace Turnos
    Public Class exDiaNoSeleccionado : Inherits Exception

        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "No seleccion� ning�n d�a de la semana.")
        End Sub

    End Class
End Namespace

