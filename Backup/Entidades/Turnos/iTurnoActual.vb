Imports Entidades.Acceso

Namespace Turnos
    Public Interface iTurnoActual : Inherits iLazy
        Sub Registrar()

        Sub Eliminar()

        Sub Actualizar()

        Property pdEmpleados() As List(Of iUsuario)

        Property pdInicio() As TimeSpan

        Property pdFinal() As TimeSpan

        Property pdID() As Short

        Property pdDiaSemana() As enDiasSemana

        ReadOnly Property Turno() As String
    End Interface
End Namespace

