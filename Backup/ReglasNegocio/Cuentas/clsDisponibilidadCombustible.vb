Imports Entidades.Cuentas
Imports Entidades.Combustibles

Namespace Cuentas
    Public Class clsDisponibilidadCombustible : Implements iDisponibilidadCombustible

        Protected xCantidad As Integer

        Protected xCombustible As iCombustible

        Public Sub New(ByVal prCombustible As iCombustible, ByVal prCantidad As Integer)
            Me.xCombustible = prCombustible
            Me.xCantidad = prCantidad
        End Sub

        Public Property pdCantidad() As Integer Implements Entidades.Cuentas.iDisponibilidadCombustible.pdCantidad
            Get
                Return Me.xCantidad
            End Get
            Set(ByVal value As Integer)
                Me.xCantidad = value
            End Set
        End Property

        Public ReadOnly Property pdResumen() As String Implements Entidades.Cuentas.iDisponibilidadCombustible.pdResumen
            Get
                Return Me.xCombustible.pdNombre & ": " & Me.xCantidad & " lts."
            End Get
        End Property

        Public ReadOnly Property pdCombustible() As Entidades.Combustibles.iCombustible Implements Entidades.Cuentas.iDisponibilidadCombustible.pdCombustible
            Get
                Return Me.xCombustible
            End Get
        End Property
    End Class
End Namespace

