Imports Entidades.Turnos
Namespace Mapeo.Turnos
    Public Class mDiasTrabajo

        Public Shared Sub Registrar(ByVal prDia As idiatrabajo)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xComms As New List(Of SqlCommand)
                Dim xPID As New SqlParameter("@id", SqlDbType.SmallInt)
                Dim xPFecha As New SqlParameter("@fecha", SqlDbType.DateTime)

                With prDia
                    .pdID = Tablas.clsTablas.ObtenerClave(enBDs.Vales, "dia_trabajo")
                    xPID.Value = .pdID
                    xPFecha.Value = .pdFecha.Date
                End With

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "RegistrarDiaTrabajo"

                objComm.Parameters.Add(xPID)
                objComm.Parameters.Add(xPFecha)

                xComms.Add(objComm)

                Dim xPrimerID As Long = Tablas.clsTablas.ObtenerUltimaClave(enBDs.Vales, "turno")

                For Each xx As iTurno In prDia.pdTurnos
                    xPrimerID += 1
                    xx.pdID = xPrimerID
                    xComms.Add(mTurnos.ComandoRegistrar(xx, prDia.pdID))
                Next

                xBD.EjecutarTransaccion(xComms)

            Catch ex As Exception
                Throw
            End Try
        End Sub


        Public Shared Function Obtener(ByVal prFecha As Date) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPFecha As New SqlParameter("@fecha", SqlDbType.DateTime)
                Dim objDS As New DataSet

                xPFecha.Value = New Date(prFecha.Year, prFecha.Month, prFecha.Day, 0, 0, 0)

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerDiaTrabajoFecha"

                objComm.Parameters.Add(xPFecha)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function
    End Class
End Namespace

