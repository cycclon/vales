' Static Model


Imports Entidades.Clientes
Namespace Mapeo.Clientes

    Public Class mClientes

        Public Shared Sub Registrar(ByVal prCliente As iCliente)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.SmallInt)
                Dim xPNombre As New SqlParameter("@nombre", SqlDbType.VarChar)
                Dim xPApellido As New SqlParameter("@apellido", SqlDbType.VarChar)
                Dim xPTipo As New SqlParameter("@tipo", SqlDbType.TinyInt)
                Dim xNombre As String()

                With prCliente
                    .pdID = Tablas.clsTablas.ObtenerClave(enBDs.Vales, "cliente")
                    xPID.Value = .pdID
                    If .pdTipo = enTipoCliente.Entidad Then
                        xPNombre.Value = .pdNombreCompleto
                        xPApellido.Value = ""
                    Else
                        xNombre = Split(.pdNombreCompleto, ", ")
                        xPNombre.Value = xNombre(1)
                        xPApellido.Value = xNombre(0)
                    End If
                    xPTipo.Value = .pdTipo
                End With

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "RegistrarCliente"

                With objComm.Parameters
                    .Add(xPID)
                    .Add(xPNombre)
                    .Add(xPApellido)
                    .Add(xPTipo)
                End With

                xBD.EjecutarComando(objComm)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Sub Modificar(ByVal prClienteModificado As iCliente)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPEstado As New SqlParameter("@estado", SqlDbType.TinyInt)
                Dim xPID As New SqlParameter("@id", SqlDbType.SmallInt)

                xPID.Value = prClienteModificado.pdID
                xPEstado.Value = prClienteModificado.pdEstado

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ModificarCliente"

                objComm.Parameters.Add(xPEstado)
                objComm.Parameters.Add(xPID)

                xBD.EjecutarComando(objComm)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function Listar(ByVal prEstado As enEstadoCliente) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPEstado As New SqlParameter("@estado", SqlDbType.TinyInt)
                Dim objDS As New DataSet

                xPEstado.Value = prEstado

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarClientesEstado"

                objComm.Parameters.Add(xPEstado)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function Listar() As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarClientes"

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function Obtener(ByVal prID As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.SmallInt)
                Dim objDS As New DataSet

                xPID.Value = prID

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerClienteID"

                objComm.Parameters.Add(xPID)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

    End Class ' END CLASS DEFINITION mClientes

End Namespace ' AccesoADatos.Mapeo.Clientes

