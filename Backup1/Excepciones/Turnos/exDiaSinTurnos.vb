Namespace Turnos
    Public Class exDiaSinTurnos : Inherits Exception
        Public Sub New()
            MyBase.New(clsGestorExcepciones.pdPreambulo & "No hay turnos establecidos para este d�a de la semana. Comun�quese con el administrador para registrar nuevos turnos.")
        End Sub
    End Class
End Namespace

