' Static Model



Public Class clsEmpleado : Inherits clsUsuario

    Public Sub New()
        MyBase.New()
        Me.xIDFamilias = New List(Of Byte)
        Me.xIDFamilias.Add(2)
    End Sub

    Public Overrides ReadOnly Property pdTipo() As Entidades.Acceso.enTipoUsuario
        Get
            Return Entidades.Acceso.enTipoUsuario.Empleado
        End Get
    End Property
End Class ' END CLASS DEFINITION clsEmpleado



