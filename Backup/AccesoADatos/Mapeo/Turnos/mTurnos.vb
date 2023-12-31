' Static Model


Imports Entidades.Turnos

Namespace Mapeo.Turnos

    Public Class mTurnos

        Public Shared Function Obtener(ByVal prID As Long) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@turno", SqlDbType.BigInt)
                Dim objDS As New DataSet

                xPID.Value = prID

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerTurnoID"

                objComm.Parameters.Add(xPID)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ComandoRegistrar(ByVal prTurno As iTurno, ByVal prDia As Short) As SqlCommand
            Dim objComm As New SqlCommand
            Dim xPID As New SqlParameter("@id", SqlDbType.Int)
            Dim xPInicio As New SqlParameter("@inicio", SqlDbType.DateTime)
            Dim xPFinal As New SqlParameter("@final", SqlDbType.DateTime)
            Dim xPDia As New SqlParameter("@dia", SqlDbType.SmallInt)

            With prTurno
                xPID.Value = .pdID
                xPInicio.Value = New Date(Year(Date.Now), Month(Date.Now), Day(Date.Now), .pdInicio.Hours, .pdInicio.Minutes, .pdInicio.Seconds)
                xPFinal.Value = New Date(Year(Date.Now), Month(Date.Now), Day(Date.Now), .pdFinal.Hours, .pdFinal.Minutes, .pdFinal.Seconds)
                xPDia.Value = prDia
            End With

            objComm.CommandType = CommandType.StoredProcedure
            objComm.CommandText = "RegistrarTurno"

            With objComm.Parameters
                .Add(xPID)
                .Add(xPInicio)
                .Add(xPFinal)
                .Add(xPDia)
            End With

            Return objComm
        End Function

        Public Shared Sub RegistrarTurnoDescarga(ByVal prTurno As Integer, ByVal prDescarga As Long)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPTurno As New SqlParameter("@turno", SqlDbType.Int)
                Dim xPDescarga As New SqlParameter("@descarga", SqlDbType.BigInt)

                xPTurno.Value = prTurno
                xPDescarga.Value = prDescarga

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "RegistrarTurnoDescarga"

                objComm.Parameters.Add(xPTurno)
                objComm.Parameters.Add(xPDescarga)

                xBD.EjecutarComando(objComm)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function ListarPorDia(ByVal prDia As Short) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPDia As New SqlParameter("@dia", SqlDbType.BigInt)
                xPDia.Value = prDia
                Dim objDS As New DataSet

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarTurnosDia"

                objComm.Parameters.Add(xPDia)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

    End Class ' END CLASS DEFINITION mTurnos

End Namespace ' AccesoADatos.Mapeo.Turnos

