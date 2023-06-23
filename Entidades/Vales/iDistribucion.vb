
Namespace Vales

    Public Interface iDistribucion

        ReadOnly Property pdItems() As List(Of iItemDistribucion)

        Function ValorAcumulado() As Double

        Sub ControlarTotal(ByVal prItem As iItemDistribucion)

        Sub ControlarTotal()

        Function CantidadVales() As Integer

        Sub AgregarItem(ByVal prItem As iItemDistribucion)

        Property pdTotal() As Double

        Function Restante() As Double

    End Interface ' END INTERFACE DEFINITION iDistribucion

End Namespace ' Entidades.Vales

