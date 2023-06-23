' Static Model


Imports Entidades.Acceso


Public Class clsFabricaUsuarios

    Public Shared Function Fabricar(ByVal prTipoUsuario As enTipoUsuario) As iUsuario
        Select Case prTipoUsuario
            Case enTipoUsuario.Administrador
                Return New clsAdministrador
            Case enTipoUsuario.Empleado
                Return New clsEmpleado
            Case Else
                Return New clsEmpleado
        End Select

    End Function

End Class ' END CLASS DEFINITION clsFabricaUsuarios


