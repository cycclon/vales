' Static Model


Namespace Acceso

    Public Interface iFamilia : Inherits iLazy
        Property pdPatentes() As List(Of iPatente)

        Property pdNombre() As String

        Property pdID() As Byte

    End Interface ' END INTERFACE DEFINITION iFamilia

End Namespace ' Entidades.Acceso

