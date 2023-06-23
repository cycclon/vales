Imports Entidades.Turnos
Imports Entidades.Acceso

Namespace Mapeo.Turnos
    Public Class mTurnosActuales

        Public Shared Sub Eliminar(ByVal prIDTurnoActual As Byte)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPTurno As New SqlParameter("@turno", SqlDbType.TinyInt)

                xPTurno.Value = prIDTurnoActual

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "EliminarTurnoActual"

                objComm.Parameters.Add(xPTurno)

                xBD.EjecutarComando(objComm)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function Listar(ByVal prDia As enDiasSemana) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet
                Dim xPDia As New SqlParameter("@dia", SqlDbType.TinyInt)

                xPDia.Value = prDIa

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarTurnosActualesDia"

                objComm.Parameters.Add(xPDia)

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
                objComm.CommandText = "ListarTurnosActuales"

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Sub Actualizar(ByVal prTurno As iTurnoActual)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xComms As New List(Of SqlCommand)
                Dim xPIDTurno As New SqlParameter("@turno", SqlDbType.SmallInt)
                xPIDTurno.Value = prTurno.pdID

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "EliminarEmpleadosTurno"

                objComm.Parameters.Add(xPIDTurno)

                xComms.Add(objComm)

                For Each xx As iUsuario In prTurno.pdEmpleados
                    xComms.Add(ComandoTurnoEmpleado(prTurno.pdID, xx.pdID))
                Next

                xBD.EjecutarTransaccion(xComms)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Sub Registrar(ByVal prTurno As iTurnoActual)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xComms As New List(Of SqlCommand)
                Dim xPID As New SqlParameter("@id", SqlDbType.TinyInt)
                Dim xPInicio As New SqlParameter("@inicio", SqlDbType.DateTime)
                Dim xPFinal As New SqlParameter("@final", SqlDbType.DateTime)
                Dim xPDia As New SqlParameter("@dia", SqlDbType.TinyInt)

                With prTurno
                    .pdID = Tablas.clsTablas.ObtenerClave(enBDs.Vales, "turno_actual")
                    xPID.Value = .pdID
                    xPInicio.Value = New Date(Year(Date.Now), Month(Date.Now), Day(Date.Now), .pdInicio.Hours, .pdInicio.Minutes, .pdInicio.Seconds)
                    xPFinal.Value = New Date(Year(Date.Now), Month(Date.Now), Day(Date.Now), .pdFinal.Hours, .pdFinal.Minutes, .pdFinal.Seconds)
                    xPDia.Value = .pdDiaSemana
                End With

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "RegistrarTurnoActual"

                With objComm.Parameters
                    .Add(xPID)
                    .Add(xPInicio)
                    .Add(xPFinal)
                    .Add(xPDia)
                End With

                xComms.Add(objComm)

                For Each xx As iUsuario In prTurno.pdEmpleados
                    xComms.Add(ComandoTurnoEmpleado(prTurno.pdID, xx.pdID))
                Next

                xBD.EjecutarTransaccion(xComms)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function ComandoTurnoEmpleado(ByVal prIDTurno As Byte, ByVal prIDEmpleado As Short) As SqlCommand
            Dim objComm As New SqlCommand
            Dim xPTurno As New SqlParameter("@turno", SqlDbType.TinyInt)
            Dim xPEmpleado As New SqlParameter("@empleado", SqlDbType.SmallInt)

            xPTurno.Value = prIDTurno
            xPEmpleado.Value = prIDEmpleado

            objComm.CommandType = CommandType.StoredProcedure
            objComm.CommandText = "RegistrarTurnoEmpleado"

            objComm.Parameters.Add(xPTurno)
            objComm.Parameters.Add(xPEmpleado)

            Return objComm
        End Function
    End Class
End Namespace

