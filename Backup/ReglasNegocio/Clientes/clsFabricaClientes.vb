Imports Entidades.Clientes
Namespace Clientes
    Public Class clsFabricaClientes
        Public Shared Function Fabricar(ByVal prTipo As entipocliente) As iCliente
            Select Case prTipo
                Case enTipoCliente.Entidad
                    Return New CLSentidad
                Case enTipoCliente.Persona
                    Return New clsPersona
                Case Else
                    Return New clsPersona
            End Select
        End Function
    End Class
End Namespace

