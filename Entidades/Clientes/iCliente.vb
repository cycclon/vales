' Static Model
Imports Entidades.Cuentas
Namespace Clientes

    Public Interface iCliente : Inherits iLazy

        Property pdCuenta() As iCuenta

        Property pdID() As Integer

        ReadOnly Property pdEstado() As enEstadoCliente

        Sub Eliminar()

        Sub Restaurar()

        ReadOnly Property pdTipo() As enTipoCliente

        ReadOnly Property pdNombreCompleto() As String

        Sub Registrar()

        Function ToString() As String

    End Interface ' END INTERFACE DEFINITION iCliente

End Namespace ' Entidades.Clientes

