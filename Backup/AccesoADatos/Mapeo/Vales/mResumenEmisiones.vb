Imports Entidades.Vales

Namespace Mapeo.Vales
    Public Class mResumenEmisiones

        Public Shared Function ObtenerHistorico() As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarEmisionesHistorico"

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorMes(ByVal prAño As Integer, ByVal prMes As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet

                Dim xPAño As New SqlParameter("@año", SqlDbType.Int)
                Dim xPMes As New SqlParameter("@mes", SqlDbType.Int)

                xPAño.Value = prAño
                xPMes.Value = prMes

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarEmisionesMes"
                objComm.Parameters.Add(xPAño)
                objComm.Parameters.Add(xPMes)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorSemana(ByVal prAño As Integer, ByVal prSemana As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet

                Dim xPAño As New SqlParameter("@año", SqlDbType.Int)
                Dim xPSemana As New SqlParameter("@semana", SqlDbType.Int)

                xPAño.Value = prAño
                xPSemana.Value = prSemana

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarEmisionesSemana"
                objComm.Parameters.Add(xPAño)
                objComm.Parameters.Add(xPSemana)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorAño(ByVal prAño As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet

                Dim xPAño As New SqlParameter("@año", SqlDbType.Int)

                xPAño.Value = prAño

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarEmisionesAño"
                objComm.Parameters.Add(xPAño)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

    End Class
End Namespace
