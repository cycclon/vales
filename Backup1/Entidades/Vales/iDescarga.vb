
Namespace Vales
    Public Interface iDescarga

        Property pdID() As Long

        Property pdFecha() As Date

        Property pdMonto() As Single

        ReadOnly Property pdUsuario() As String

        Sub Registrar(ByVal prVale As String)

        ReadOnly Property pdTipoVale() As enTipoVale

    End Interface
End Namespace

