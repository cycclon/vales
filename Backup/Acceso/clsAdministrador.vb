' Static Model


Public Class clsAdministrador : Inherits clsUsuario

    Public Sub New()
        MyBase.new()
        Me.xIDFamilias = New List(Of Byte)
        Me.xIDFamilias.Add(1)
    End Sub

    Public Overrides ReadOnly Property pdTipo() As Entidades.Acceso.enTipoUsuario
        Get
            Return Entidades.Acceso.enTipoUsuario.Administrador
        End Get
    End Property
End Class ' END CLASS DEFINITION clsAdministrador



