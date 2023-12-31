Imports Entidades.Vales
Imports Entidades.Clientes

Namespace Cuentas

    Public Interface iMovimiento : Inherits iLazy

        Property pdID() As Long

        ReadOnly Property pdMonto() As Double

        Property pdFecha() As Date

        ReadOnly Property pdTipo() As enTipoMovimiento

        ReadOnly Property pdTipoVale() As enTipoVale

        Property pdCliente() As iCliente

        Sub RegistrarRelacion()

    End Interface ' END INTERFACE DEFINITION iMovimiento

End Namespace ' Entidades.Cuentas

