' Static Model

Imports Entidades.Vales
Imports Entidades.Cuentas

Namespace Mapeo.Cuentas

    Public Class mMovimientos

        Public Shared Function Listar(ByVal prCliente As Short) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet
                Dim xPCliente As New SqlParameter("@cliente", SqlDbType.SmallInt)

                xPCliente.Value = prCliente

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarMovimientosCliente"

                objComm.Parameters.Add(xPCliente)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function Listar(ByVal prCliente As Short, ByVal prCantidad As Byte) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet
                Dim xPCliente As New SqlParameter("@cliente", SqlDbType.SmallInt)
                Dim xPCantidad As New SqlParameter("@cantidad", SqlDbType.TinyInt)

                xPCliente.Value = prCliente
                xPCantidad.Value = prCantidad

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarMovimientosClienteCantidad"

                objComm.Parameters.Add(xPCliente)
                objComm.Parameters.Add(xPCantidad)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Sub Registrar(ByVal prMovimiento As iMovimiento)
            Try
                Dim objComm As SqlCommand = ComandoRegistrar(prMovimiento)
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                xBD.EjecutarComando(objComm)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Sub RegistrarMovimientoVale(ByVal prIDMovimiento As Long, ByVal prIDVale As String)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPIDMovimiento As New SqlParameter("@movimiento", SqlDbType.BigInt)
                Dim xPIDVale As New SqlParameter("@vale", SqlDbType.VarChar)

                xPIDMovimiento.Value = prIDMovimiento
                xPIDVale.Value = prIDVale

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "RegistrarMovimientoVale"

                objComm.Parameters.Add(xPIDMovimiento)
                objComm.Parameters.Add(xPIDVale)

                xBD.EjecutarComando(objComm)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function ComandoRegistrar(ByVal prMovimiento As iMovimiento) As SqlCommand
            Dim objComm As New SqlCommand
            Dim xPID As New SqlParameter("@id", SqlDbType.BigInt)
            Dim xPFecha As New SqlParameter("@fecha", SqlDbType.DateTime)
            Dim xPCliente As New SqlParameter("@cliente", SqlDbType.Int)
            Dim xPtipo As New SqlParameter("@tipo", SqlDbType.TinyInt)

            With prMovimiento
                .pdID = Tablas.clsTablas.ObtenerClave(enBDs.Vales, "movimiento")
                xPID.Value = .pdID
                xPFecha.Value = .pdFecha
                xPCliente.Value = .pdcliente.pdid
                xPtipo.Value = .pdTipo
            End With

            objComm.CommandType = CommandType.StoredProcedure
            objComm.CommandText = "RegistrarMovimiento"

            With objComm.Parameters
                .Add(xPID)
                .Add(xPFecha)
                .Add(xPCliente)
                .Add(xPtipo)
            End With

            Return objComm
        End Function

        Public Shared Function ComandoIngresoSerie(ByVal prSerie As iSerie, ByVal prIngreso As iMovimiento) As SqlCommand
            Dim objComm As New SqlCommand
            Dim xPMovimiento As New SqlParameter("@movimiento", SqlDbType.BigInt)
            Dim xPSerie As New SqlParameter("@serie", SqlDbType.Int)

            xPMovimiento.Value = prIngreso.pdID
            xPSerie.Value = prSerie.pdID

            objComm.CommandType = CommandType.StoredProcedure
            objComm.CommandText = "RegistrarMovimientoSerie"

            objComm.Parameters.Add(xPMovimiento)
            objComm.Parameters.Add(xPSerie)

            Return objComm
        End Function

    End Class ' END CLASS DEFINITION mMovimientos

End Namespace ' AccesoADatos.Mapeo.Cuentas

