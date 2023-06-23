Namespace Acceso
    Public Interface iTarjetaAcceso
        Property pdID() As String

        Property pdVigente() As Boolean

        Sub ArmarTarjeta(ByVal prRegistro As DataRow)

        Sub Obtener(ByVal prIDUsuario As Short)

        Sub Registrar(ByVal prIDUsuario As Short)
    End Interface
End Namespace

