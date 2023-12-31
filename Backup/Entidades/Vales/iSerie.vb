
Imports Entidades.Clientes

Namespace Vales

    Public Interface iSerie : Inherits iLazy

        ReadOnly Property pdValesDisponibles() As List(Of iVale)

        ReadOnly Property pdVencimiento() As Date

        ReadOnly Property pdSaldoDisponible() As Double

        ReadOnly Property pdValePor() As String

        Property pdFechaEmision() As Date

        Property pdVales() As List(Of iVale)

        ReadOnly Property pdCliente() As iCliente

        ReadOnly Property pdNombreCliente() As String

        Property pdID() As Integer

        ReadOnly Property pdTotal() As Double

        ReadOnly Property pdTipo() As enTipoVale

        Sub ObtenerPorMovimiento(ByVal prIDMovimiento As Long)

        Sub ArmarVales(ByVal prValeModelo As iVale, ByVal prDistribucion As iDistribucion)

        Sub ExtenderVencimiento(ByVal prDias As Short)

        Sub Reportar()

    End Interface ' END INTERFACE DEFINITION iSerie

End Namespace ' Entidades.Vales

