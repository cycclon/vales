' Static Model

Namespace CopiasDeRespaldo

    Public Interface iBackup

        Property pdBase() As iBase

        Property pdID() As Integer

        Property pdArchivo() As String

        Property pdFecha() As Date

        ReadOnly Property pdNombreBase() As String

        Sub Generar(ByVal prUnidad As String)

      

    End Interface ' END INTERFACE DEFINITION iBackup

End Namespace ' Entidades.CopiasDeRespaldo

