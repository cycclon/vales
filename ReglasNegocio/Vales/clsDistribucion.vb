Imports Excepciones.Vales
Imports Entidades.Vales

Namespace Vales

    Public Class clsDistribucion : Implements iDistribucion

        Private xItems As List(Of Entidades.Vales.iItemDistribucion)

        Private xTotal As Double

        Public Sub New()
            Me.xItems = New List(Of iItemDistribucion)
            Me.xTotal = 0
        End Sub

        Private Sub ControlarTotal(ByVal prItem As iItemDistribucion) Implements Entidades.Vales.iDistribucion.ControlarTotal
            Dim xAcumulado As Double = Me.ValorAcumulado
            If xAcumulado + (prItem.pdCantidad * prItem.pdValor) > xTotal Then
                Throw New exTotalAlcanzado
            End If
        End Sub

        Private Sub ControlarTotal() Implements iDistribucion.ControlarTotal
            Dim xAcumulado As Double = Me.ValorAcumulado
            If xAcumulado < xTotal Then
                Throw New exDistribucionInsuficiente
            End If
        End Sub

        Public ReadOnly Property pdItems() As List(Of iItemDistribucion) Implements Entidades.Vales.iDistribucion.pdItems
            Get
                Return Me.xItems
            End Get
        End Property

        Public Function ValorAcumulado() As Double Implements Entidades.Vales.iDistribucion.ValorAcumulado
            Dim xContador As Double = 0
            For Each xx As iItemDistribucion In Me.xItems
                xContador += (xx.pdValor * xx.pdCantidad)
            Next

            Return xContador
        End Function

        Public Function CantidadVales() As Integer Implements Entidades.Vales.iDistribucion.CantidadVales
            Dim xContador As Integer = 0
            For Each xx As iItemDistribucion In Me.xItems
                xContador += xx.pdCantidad
            Next

            Return xContador
        End Function

        Public Sub AgregarItem(ByVal prItem As Entidades.Vales.iItemDistribucion) Implements Entidades.Vales.iDistribucion.AgregarItem
            Try
                Me.ControlarTotal(prItem)
                Me.xItems.Add(prItem)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Property pdTotal() As Double Implements Entidades.Vales.iDistribucion.pdTotal
            Get
                Return Me.xTotal
            End Get
            Set(ByVal value As Double)
                Me.xTotal = value
            End Set
        End Property

        Public Function Restante() As Double Implements Entidades.Vales.iDistribucion.Restante
            Return (Me.xTotal - Me.ValorAcumulado)
        End Function
    End Class ' END CLASS DEFINITION clsDistribucion

End Namespace ' ReglasNegocio.Vales

