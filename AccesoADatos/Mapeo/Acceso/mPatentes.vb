Namespace Mapeo.Acceso
    Public Class mPatentes
        Public Shared Function ObtenerPatentes(ByVal prFamilia As Byte) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet
                Dim xPFamilia As New SqlParameter("@familia", SqlDbType.TinyInt)

                xPFamilia.Value = prFamilia

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarPatentesFamilia"

                objComm.Parameters.Add(xPFamilia)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function
    End Class
End Namespace

