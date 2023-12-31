' Static Model
Imports Entidades.Acceso
Imports Bitacoras

Public Class clsBUsuario : Inherits clsBitacora

    Protected xUsuario As Entidades.Acceso.iUsuario

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
            Return " Usuario: " & Me.xUsuario.pdCredencial.pdUsername & ". Nombre: " & Me.xUsuario.pdNombreCompleto
        End If
    End Function
End Class ' END CLASS DEFINITION clsBUsuario

