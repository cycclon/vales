Imports Entidades.Vales
Namespace Vales

    Public Class clsItemDistribucion : Implements iItemDistribucion

        Private xCantidad As Integer

        Private xValor As Single

        Public Property pdCantidad() As Integer Implements Entidades.Vales.iItemDistribucion.pdCantidad
            Get
                Return Me.xCantidad
            End Get
            Set(ByVal value As Integer)
                Me.xCantidad = value
            End Set
        End Property

        Public Property pdValor() As Single Implements Entidades.Vales.iItemDistribucion.pdValor
            Get
                Return Me.xValor
            End Get
            Set(ByVal value As Single)
                Me.xValor = value
            End Set
        End Property
    End Class ' END CLASS DEFINITION clsItemDistribucion

End Namespace ' ReglasNegocio.Vales

