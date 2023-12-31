' Static Model


Imports Entidades.Bitacoras
Namespace Mapeo.Bitacoras

    Public Class mBitacoras

        Public Shared Function Listar(ByVal prUsuario As String, ByVal prCantidad As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Bitacoras)
                Dim objComm As New SqlCommand
                Dim xPUsuario As New SqlParameter("@usuario", SqlDbType.VarChar)
                Dim objDS As New DataSet

                xPUsuario.Value = prUsuario

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarBitacorasUsuario"

                objComm.Parameters.Add(xPUsuario)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Sub Registrar(ByVal prBitacora As iBitacora)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Bitacoras)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.BigInt)
                Dim xPTipo As New SqlParameter("@tipo", SqlDbType.TinyInt)
                Dim xPFecha As New SqlParameter("@fecha", SqlDbType.DateTime)
                Dim xPUsuario As New SqlParameter("@usuario", SqlDbType.VarChar)
                Dim xPBitacora As New SqlParameter("bitacora", SqlDbType.VarChar)

                With prBitacora
                    .pdID = Tablas.clsTablas.ObtenerClave(enBDs.Bitacoras, "bitacora")
                    xPID.Value = .pdID
                    xPTipo.Value = .pdTipo
                    xPFecha.Value = .pdFecha
                    xPUsuario.Value = .pdUsuarioGenerador
                    xPBitacora.Value = .pdMensaje
                End With

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "RegistrarBitacora"

                With objComm.Parameters
                    .Add(xPID)
                    .Add(xPTipo)
                    .Add(xPFecha)
                    .Add(xPUsuario)
                    .Add(xPBitacora)
                End With

                xBD.EjecutarComando(objComm)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function Listar() As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Bitacoras)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarBitacoras"

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

    End Class ' END CLASS DEFINITION mBitacoras

End Namespace ' AccesoADatos.Mapeo.Bitacoras

