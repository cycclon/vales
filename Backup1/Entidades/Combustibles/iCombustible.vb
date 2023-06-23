
Namespace Combustibles

    Public Interface iCombustible

        Property pdNombre() As String

        Property pdID() As Byte

        ReadOnly Property pdEstado() As enEstadoCombustible

        Sub Registrar()

        Sub Eliminar()

        Sub Restaurar()

        Sub Obtener(ByVal prIDVale As String)

    End Interface ' END INTERFACE DEFINITION iCombustible

End Namespace ' Entidades.Combustibles

