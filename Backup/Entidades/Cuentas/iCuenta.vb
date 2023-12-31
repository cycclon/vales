
Namespace Cuentas

    Public Interface iCuenta : Inherits iLazy

        Property pdMovimientos() As List(Of iMovimiento)

        ReadOnly Property pdSaldoDinero() As Single

        ReadOnly Property pdSaldoCombustible() As Integer

        Function UltimosMovimientos() As List(Of iMovimiento)

        ReadOnly Property pdDetalleCombustibles() As List(Of iDisponibilidadCombustible)

    End Interface ' END INTERFACE DEFINITION iCuenta

End Namespace ' Entidades.Cuentas

