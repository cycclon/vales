Imports Entidades.Vales
Imports Entidades.Cuentas
Imports AccesoADatos.Mapeo.Cuentas

Namespace Mapeo.Vales
    Public Class mSeries

        Public Shared Function ClienteSerie(ByVal prIDSerie As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPSerie As New SqlParameter("@serie", SqlDbType.Int)
                Dim objDS As New DataSet

                xPSerie.Value = prIDSerie
                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerClienteSerie"

                objComm.Parameters.Add(xPSerie)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function TipoSerie(ByVal prIDSerie As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPSerie As New SqlParameter("@serie", SqlDbType.Int)
                Dim objDS As New DataSet

                xPSerie.Value = prIDSerie
                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerTipoSerie"

                objComm.Parameters.Add(xPSerie)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function TotalSerie(ByVal prIDSerie As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPSerie As New SqlParameter("@serie", SqlDbType.Int)
                Dim objDS As New DataSet

                xPSerie.Value = prIDSerie
                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerTotalSerie"

                objComm.Parameters.Add(xPSerie)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function Listar(ByVal prIDCliente As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPCliente As New SqlParameter("@cliente", SqlDbType.Int)
                Dim objDS As New DataSet

                xPCliente.Value = prIDCliente

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarSeriesCliente"

                objComm.Parameters.Add(xPCliente)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorMovimiento(ByVal prIDMovimiento As Long) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet
                Dim xPMovimiento As New SqlParameter("@movimiento", SqlDbType.BigInt)

                xPMovimiento.Value = prIDMovimiento

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerSerieMovimiento"

                objComm.Parameters.Add(xPMovimiento)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Sub RegistrarSerie(ByVal prSerie As iSerie, ByVal prIngreso As iMovimiento)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.Int)
                Dim xPFecha As New SqlParameter("@fecha_emision", SqlDbType.DateTime)
                Dim xComandos As New List(Of SqlCommand)

                With prSerie
                    .pdID = Tablas.clsTablas.ObtenerClave(enBDs.Vales, "serie")
                    xPID.Value = .pdID
                    xPFecha.Value = .pdFechaEmision
                End With

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "RegistrarSerie"

                objComm.Parameters.Add(xPID)
                objComm.Parameters.Add(xPFecha)

                xComandos.Add(objComm)

                For Each xx As iVale In prSerie.pdVales
                    xComandos.Add(mVales.ComandoRegistrar(xx))
                    xComandos.Add(ComandoValeSerie(prSerie.pdID, xx.pdID))
                    If xx.pdTipo = enTipoVale.Combustible Then
                        xComandos.Add(mVales.ComandoValeCombustible(xx.pdID, xx.pdIDCombustible))
                    End If
                Next

                xComandos.Add(mMovimientos.ComandoRegistrar(prIngreso))

                xComandos.Add(mMovimientos.ComandoIngresoSerie(prSerie, prIngreso))

                xBD.EjecutarTransaccion(xComandos)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function ComandoValeSerie(ByVal prSerie As Integer, _
               ByVal prVale As String) As SqlCommand
            Dim objComm As New SqlCommand
            Dim xPSerie As New SqlParameter("@serie", SqlDbType.Int)
            Dim xPVale As New SqlParameter("@vale", SqlDbType.VarChar)

            xPSerie.Value = prSerie
            xPVale.Value = prVale

            objComm.CommandType = CommandType.StoredProcedure
            objComm.CommandText = "RegistrarSerieVale"

            objComm.Parameters.Add(xPSerie)
            objComm.Parameters.Add(xPVale)

            Return objComm
        End Function


    End Class
End Namespace

