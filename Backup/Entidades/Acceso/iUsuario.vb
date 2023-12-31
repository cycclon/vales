' Static Model

Namespace Acceso

    Public Interface iUsuario
        Inherits iLazy

        ReadOnly Property pdIDFamilias() As List(Of Byte)

        ReadOnly Property pdUsername() As String

        Property pdCredencial() As iCredencial

        Property pdNombre() As String
        
        Property pdApellido() As String
        
        Property pdID() As Short

        ReadOnly Property pdTipo() As enTipoUsuario

        ReadOnly Property pdEstado() As enEstadoUsuario

        ReadOnly Property pdNombreCompleto() As String

        Sub Modificar()

        Sub Registrar()

        Sub Desactivar()

        Sub Activar()

        Sub ReestablecerContraseña()

        Sub ActualizarContraseña(ByVal prContraseñaActual As String, _
             ByVal prNuevaContraseña As String, _
             ByVal prNuevaContraseña2 As String)

	End Interface ' END INTERFACE DEFINITION iUsuario

End Namespace ' Entidades.Acceso

