' Static Model


Namespace Acceso

    Public Interface iSesion
        Property pdUsuario() As iUsuario

        Function Iniciar(ByVal prUsername As String, _
           ByVal prPassword As String) As Boolean

        Sub EstablecerContraseña(ByVal prUsername As String, _
             ByVal prPassword As String, _
             ByVal prPassword2 As String)

        Sub Ingresar(ByVal prUsuario As iUsuario, _
          ByVal prPassword As String)

        Sub ComprobarPermisos(ByVal prPatente As Byte)

        Sub Cerrar()

        Function UsuarioLogueado() As Boolean

        Function ValidarPermiso(ByVal prPatente As Byte) As Boolean
    End Interface ' END INTERFACE DEFINITION iSesion

End Namespace ' Entidades.Acceso

