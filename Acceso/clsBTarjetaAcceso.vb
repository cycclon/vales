' Static Model
Imports Entidades.Acceso
Imports Bitacoras

Public Class clsBTarjetaAcceso : Inherits clsBitacora

    Protected xUsuario As Entidades.Acceso.iUsuario

    Protected xTarjeta As iTarjetaAcceso

    Public Property pdTarjeta() As iTarjetaAcceso
        Get
            Return Me.xTarjeta
        End Get
        Set(ByVal value As iTarjetaAcceso)
            Me.xTarjeta = value
        End Set
    End Property

    Public Property pdUsuario() As iUsuario
        Get
            Return Me.xUsuario
        End Get

        Set(ByVal Value As iUsuario)
            Me.xUsuario = Value
        End Set
    End Property

    Public Sub New(ByVal prTipo As Entidades.Bitacoras.enTipoBitacora)
        Me.xTipo = prTipo
        Me.Inicializar()
    End Sub

    Public Overrides Function Mensaje() As String
        If Me.xUsuario Is Nothing Then
            Return ""
        Else
            Return " Usuario: " & Me.xUsuario.pdNombreCompleto & " ID de Tarjeta: " & Me.xTarjeta.pdID
        End If
    End Function
End Class ' END CLASS DEFINITION clsBUsuario

