' Static Model

Namespace Bitacoras

    Public Interface iBitacora
        Property pdTipo() As enTipoBitacora

        Property pdID() As Long

        Property pdFecha() As Date

        Property pdUsuarioGenerador() As String

        ReadOnly Property pdMensaje() As String

    End Interface ' END INTERFACE DEFINITION iBitacora

End Namespace ' Entidades.Bitacoras

