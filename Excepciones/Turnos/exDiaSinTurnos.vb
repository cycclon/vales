Namespace Turnos
    Public Class exDiaSinTurnos : Inherits Exception
        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "No hay turnos establecidos para este día de la semana. Comuníquese con el administrador para registrar nuevos turnos.")
        End Sub
    End Class
End Namespace

