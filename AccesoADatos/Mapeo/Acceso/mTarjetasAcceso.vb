Imports Entidades.Acceso
Namespace Mapeo.Acceso
    Public Class mTarjetasAcceso
        Public Shared Sub Registrar(ByVal prIDUsuario As Short, ByVal prTarjeta As itarjetaAcceso)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.VarChar)
                Dim xPUsuario As New SqlParameter("@usuario", SqlDbType.SmallInt)

                xPID.Value = prTarjeta.pdID
                xPUsuario.Value = prIDUsuario

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "RegistrarTarjetaAcceso"

                objComm.Parameters.Add(xPID)
                objComm.Parameters.Add(xPUsuario)

                xBD.EjecutarComando(objComm)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function Obtener(ByVal prUsuario As Short) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPUsuario As New SqlParameter("@usuario", SqlDbType.SmallInt)
                Dim objDS As New DataSet
                xPUsuario.Value = prUsuario

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerTarjetaAccesoUsuario"

                objComm.Parameters.Add(xPUsuario)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function
    End Class
End Namespace

