Namespace Turnos
    Public Class exTurnoSinEmpleados : Inherits Exception

        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "No se puede registrar el turno, porque no seleccion� ning�n empleado.")
        End Sub

    End Class
End Namespace

