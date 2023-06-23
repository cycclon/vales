Namespace Turnos
    Public Class exHorariosSolapados : Inherits Exception

        Public Sub New()
            MyBase.New(ClsGestorExcepciones.pdPreambulo & "No se pueden registrar los turnos porque sus horarios coinciden con los de otros turnos ya registrados.")
        End Sub

    End Class
End Namespace

