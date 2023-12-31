
Namespace Turnos

    Public Interface iDiaTrabajo : Inherits iLazy

        Function TurnoActual() As iTurno

        Property pdTurnos() As List(Of iTurno)

        Property pdFecha() As Date

        Property pdID() As Short

        ReadOnly Property pdCantidadDescargas() As Short

        ReadOnly Property pdCombustibleDescargado() As Double

        ReadOnly Property pdDineroDescargado() As Double

        Sub Obtener(ByVal prFecha As Date)

    End Interface ' END INTERFACE DEFINITION iDiaTrabajo

End Namespace ' Entidades.Turnos

