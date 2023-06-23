' Static Model


Namespace Acceso


    Public Interface iCredencial : Inherits iLazy

        Property pdFamilias() As List(Of iFamilia)

        Property pdUsername() As String

        Property pdPassword() As String

        ReadOnly Property pdTarjetaAcceso() As iTarjetaAcceso

        Sub GenerarTarjeta()

    End Interface ' END INTERFACE DEFINITION iCredencial

End Namespace ' Entidades.Acceso

