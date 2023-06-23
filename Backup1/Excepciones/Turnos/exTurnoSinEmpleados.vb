Namespace Turnos
    Public Class exTurnoSinEmpleados : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "No se puede registrar el turno, porque no seleccionó ningún empleado.")
        End Sub

    End Class
End Namespace

