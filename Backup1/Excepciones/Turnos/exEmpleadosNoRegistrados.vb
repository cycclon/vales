Namespace Turnos
    Public Class exEmpleadosNoRegistrados : Inherits Exception

        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "No hay ningún empleado registrado. Para poder registrar un turno primero debe registrar por lo menos un empleado.")
        End Sub

    End Class
End Namespace

