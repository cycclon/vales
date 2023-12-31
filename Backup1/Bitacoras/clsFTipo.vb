' Static Model

Imports Entidades.Bitacoras
Public Class clsFTipo : Inherits clsFiltroBitacora

    Protected xTipo As Entidades.Bitacoras.enTipoBitacora

    Public Sub New(ByVal prTipo As enTipoBitacora)
        Me.xTipo = prTipo
    End Sub

    Public Property pdTipo() As enTipoBitacora
        Get
            Return Me.xTipo
        End Get

        Set(ByVal Value As enTipoBitacora)
            Me.xTipo = Value
        End Set
    End Property

    Public Overrides Function Filtrar(ByVal prBitacora As Entidades.Bitacoras.iBitacora) As Boolean
        Return prBitacora.pdTipo.Equals(Me.xTipo)
    End Function
End Class ' END CLASS DEFINITION clsFTipo



