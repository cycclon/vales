' Static Model
Imports Entidades.Acceso

Namespace Mapeo.Acceso

    Public Class mUsuarios
        Public Shared Function ObtenerPorTarjeta(ByVal prCodigo As String) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPCodigo As New SqlParameter("@codigo", SqlDbType.VarChar)
                Dim objDS As New DataSet

                xPCodigo.Value = prCodigo

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerUsuarioTarjeta"

                objComm.Parameters.Add(xPCodigo)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Shared Function ObtenerPorDescarga(ByVal prDescarga As Long) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPDescarga As New SqlParameter("@descarga", SqlDbType.BigInt)
                Dim objDS As New DataSet

                xPDescarga.Value = prDescarga

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerUsuarioDescarga"

                objComm.Parameters.Add(xPDescarga)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ListarPorTipo(ByVal prTipo As enTipoUsuario) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPTipo As New SqlParameter("@tipo", SqlDbType.BigInt)
                Dim objDS As New DataSet

                xPTipo.Value = prTipo

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarUsuariosTipo"

                objComm.Parameters.Add(xPTipo)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ListarPorTurno(ByVal prTurno As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPTurno As New SqlParameter("@turno", SqlDbType.BigInt)
                Dim objDS As New DataSet

                xPTurno.Value = prTurno

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarUsuariosTurno"

                objComm.Parameters.Add(xPTurno)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Sub Registrar(ByVal prUsuario As iUsuario)
            Try
                Dim xComms As New List(Of SqlCommand)
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.SmallInt)
                Dim xPUsername As New SqlParameter("@username", SqlDbType.VarChar)
                Dim xPNombre As New SqlParameter("@nombre", SqlDbType.VarChar)
                Dim xPApellido As New SqlParameter("@apellido", SqlDbType.VarChar)
                Dim xPTipo As New SqlParameter("@tipo", SqlDbType.TinyInt)
                Dim xPEstado As New SqlParameter("@estado", SqlDbType.TinyInt)

                With prUsuario
                    .pdID = Tablas.clsTablas.ObtenerClave(enBDs.Vales, "usuario")
                    xPID.Value = .pdID
                    xPUsername.Value = .pdCredencial.pdUsername
                    xPNombre.Value = .pdNombre
                    xPApellido.Value = .pdApellido
                    xPTipo.Value = .pdTipo
                    xPEstado.Value = .pdEstado
                End With

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "RegistrarUsuario"

                With objComm.Parameters
                    .Add(xPID)
                    .Add(xPUsername)
                    .Add(xPNombre)
                    .Add(xPApellido)
                    .Add(xPTipo)
                    .Add(xPEstado)
                End With

                xComms.Add(objComm)
                For Each xx As Byte In prUsuario.pdIDFamilias
                    xComms.Add(ComandoFamilia(prUsuario.pdID, xx))
                Next

                xBD.EjecutarTransaccion(xComms)
            Catch ex As Exception
                Throw
            End Try
        End Sub


        Private Shared Function ComandoFamilia(ByVal prIDUsuario As Short, ByVal prFamilia As Byte) As SqlCommand
            Dim objComm As New SqlCommand
            Dim xPUsuario As New SqlParameter("@usuario", SqlDbType.SmallInt)
            Dim xPFamilia As New SqlParameter("@familia", SqlDbType.TinyInt)

            xPUsuario.Value = prIDUsuario
            xPFamilia.Value = prFamilia

            objComm.CommandType = CommandType.StoredProcedure
            objComm.CommandText = "RegistrarUsuarioFamilia"

            objComm.Parameters.Add(xPUsuario)
            objComm.Parameters.Add(xPFamilia)

            Return objComm
        End Function

        Public Shared Sub Modificar(ByVal prUsuarioModificado As iUsuario)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.SmallInt)
                Dim xPPassword As New SqlParameter("@password", SqlDbType.VarChar)
                Dim xPEstado As New SqlParameter("@estado", SqlDbType.TinyInt)

                xPID.Value = prUsuarioModificado.pdID
                xPPassword.Value = prUsuarioModificado.pdCredencial.pdPassword
                xPEstado.Value = prUsuarioModificado.pdEstado

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ModificarUsuario"

                objComm.Parameters.Add(xPPassword)
                objComm.Parameters.Add(xPEstado)
                objComm.Parameters.Add(xPID)

                xBD.EjecutarComando(objComm)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function Listar(ByVal prEstado As enEstadoUsuario) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet
                Dim xPEstado As New SqlParameter("@estado", SqlDbType.TinyInt)
                xPEstado.Value = prEstado

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarUsuariosEstado"

                objComm.Parameters.Add(xPEstado)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorID(ByVal prID As Short) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPUsername As New SqlParameter("@usuario", SqlDbType.SmallInt)
                Dim objDS As New DataSet

                xPUsername.Value = prID

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerUsuarioID"

                objComm.Parameters.Add(xPUsername)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function Obtener(ByVal prUsername As String) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPUsername As New SqlParameter("@username", SqlDbType.VarChar)
                Dim objDS As New DataSet

                xPUsername.Value = prUsername

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerUsuarioNombre"

                objComm.Parameters.Add(xPUsername)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

    End Class ' END CLASS DEFINITION mUsuarios

End Namespace ' AccesoADatos.Mapeo.Acceso

