Namespace Mapeo.Acceso
    Public Class mFamilias
        Public Shared Function ObtenerFamilias(ByVal prUsuario As Short) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet
                Dim xPUsuario As New SqlParameter("@usuario", SqlDbType.SmallInt)

                xPUsuario.Value = prUsuario

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarFamiliasUsuario"

                objComm.Parameters.Add(xPUsuario)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function
    End Class
End Namespace

