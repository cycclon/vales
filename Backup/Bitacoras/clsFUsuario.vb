' Static Model



Public Class clsFUsuario : Inherits clsFiltroBitacora

    Protected xUsuario As String

    Public Sub New(ByVal prUsuario As String)
        Me.xUsuario = prUsuario
    End Sub

    Public Property pdUsuario() As String
        Get
            Return Me.xUsuario
        End Get

        Set(ByVal Value As String)
            Me.xUsuario = Value
        End Set
    End Property

    Public Overrides Function Filtrar(ByVal prBitacora As Entidades.Bitacoras.iBitacora) As Boolean
        Return Me.xUsuario.Equals(prBitacora.pdUsuarioGenerador)
    End Function
End Class ' END CLASS DEFINITION clsFUsuario



