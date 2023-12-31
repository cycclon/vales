' Static Model


Imports Entidades.Vales

Namespace Mapeo.Vales

    Public Class mVales

        Public Shared Function ListarDescargasHistorico() As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarDescargasHistorico"

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ListarDescargasAño(ByVal prAño As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPAño As New SqlParameter("@año", SqlDbType.Int)
                Dim objDS As New DataSet

                xPAño.Value = prAño

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarDescargasAño"

                objComm.Parameters.Add(xPAño)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ListarDescargasMes(ByVal prAño As Integer, ByVal prMes As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPAño As New SqlParameter("@año", SqlDbType.Int)
                Dim xPMes As New SqlParameter("@mes", SqlDbType.Int)
                Dim objDS As New DataSet

                xPAño.Value = prAño
                xPMes.Value = prMes

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarDescargasMes"

                objComm.Parameters.Add(xPAño)
                objComm.Parameters.Add(xPMes)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ListarDescargasSemana(ByVal prAño As Integer, ByVal prSemana As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPAño As New SqlParameter("@año", SqlDbType.Int)
                Dim xPSemana As New SqlParameter("@semana", SqlDbType.Int)
                Dim objDS As New DataSet

                xPAño.Value = prAño
                xPSemana.Value = prSemana

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarDescargasSemana"

                objComm.Parameters.Add(xPAño)
                objComm.Parameters.Add(xPSemana)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerClave(ByVal prClave As String) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPClave As New SqlParameter("@clave", SqlDbType.VarChar)
                Dim objDS As New DataSet

                xPClave.Value = prClave

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerClaveVale"

                objComm.Parameters.Add(xPClave)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ListarDescargasPorTurno(ByVal prTurno As Integer) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPTurno As New SqlParameter("@turno", SqlDbType.BigInt)
                Dim objDS As New DataSet

                xPTurno.Value = prTurno

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarDescargasTurno"

                objComm.Parameters.Add(xPTurno)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerDescargaPorMovimiento(ByVal prIDMovimiento As Long) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPMovimiento As New SqlParameter("@movimiento", SqlDbType.BigInt)
                Dim objDS As New DataSet

                xPMovimiento.Value = prIDMovimiento

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerDescargaMovimiento"

                objComm.Parameters.Add(xPMovimiento)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Sub RegistrarDescarga(ByVal prDescarga As iDescarga, ByVal prVale As String, ByVal prUsuario As Short)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.BigInt)
                Dim xPMonto As New SqlParameter("@monto", SqlDbType.SmallMoney)
                Dim xPFecha As New SqlParameter("@fecha", SqlDbType.DateTime)
                Dim xPVale As New SqlParameter("@vale", SqlDbType.VarChar)
                Dim xPUsuario As New SqlParameter("@usuario", SqlDbType.SmallInt)

                With prDescarga
                    .pdID = Tablas.clsTablas.ObtenerClave(enBDs.Vales, "descarga")
                    xPID.Value = .pdID
                    xPMonto.Value = .pdMonto
                    xPFecha.Value = .pdFecha
                    xPVale.Value = prVale
                    xPUsuario.Value = prUsuario
                End With

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "RegistrarDescargaVale"

                With objComm.Parameters
                    .Add(xPID)
                    .Add(xPMonto)
                    .Add(xPFecha)
                    .Add(xPVale)
                    .Add(xPUsuario)
                End With

                xBD.EjecutarComando(objComm)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function ListarDescargas(ByVal prIDVale As String) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPVale As New SqlParameter("@vale", SqlDbType.VarChar)
                Dim objDS As New DataSet

                If prIDVale Is Nothing Then
                    xPVale.Value = ""
                Else
                    xPVale.Value = prIDVale
                End If

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarDescargasVale"

                objComm.Parameters.Add(xPVale)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function Obtener(ByVal prID As String) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.VarChar)
                Dim objDS As New DataSet

                xPID.Value = prID

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerValeID"

                objComm.Parameters.Add(xPID)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function
        Public Shared Function ListarClaves() As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As DataSet

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarClavesVales"

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Sub Registrar(ByVal prVale As iVale, ByVal prSerie As Integer)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As SqlCommand = ComandoRegistrar(prVale)
                Dim xComms As New List(Of SqlCommand)
                Dim objComm2 As SqlCommand = mSeries.ComandoValeSerie(prSerie, prVale.pdID)
                xComms.Add(objComm)
                xComms.Add(objComm2)

                xBD.EjecutarTransaccion(xComms)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function ComandoRegistrar(ByVal prVale As iVale) As SqlCommand
            Try
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.VarChar)
                Dim xPTipo As New SqlParameter("@tipo", SqlDbType.TinyInt)
                Dim xPValor As New SqlParameter("@valor", SqlDbType.SmallMoney)
                Dim xPVencimiento As New SqlParameter("@vencimiento", SqlDbType.DateTime)
                Dim xPCliente As New SqlParameter("@cliente", SqlDbType.Int)

                With prVale
                    xPID.Value = .pdID
                    xPTipo.Value = .pdTipo
                    xPValor.Value = .pdValor
                    xPVencimiento.Value = .pdVencimiento
                    xPCliente.Value = .pdCliente.pdID
                End With

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "RegistrarVale"

                With objComm.Parameters
                    .Add(xPID)
                    .Add(xPTipo)
                    .Add(xPValor)
                    .Add(xPVencimiento)
                    .Add(xPCliente)
                End With

                Return objComm
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ListarPorSerie(ByVal prIDSerie As Long) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPSerie As New SqlParameter("@serie", SqlDbType.Int)
                Dim objDS As New DataSet

                xPSerie.Value = prIDSerie

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarValesSerie"

                objComm.Parameters.Add(xPSerie)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Sub Modificar(ByVal prValeModificado As iVale)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.VarChar)
                Dim xPEstado As New SqlParameter("@estado", SqlDbType.TinyInt)
                Dim xPVencimiento As New SqlParameter("@vencimiento", SqlDbType.DateTime)
                Dim xComms As New List(Of SqlCommand)

                xPID.Value = prValeModificado.pdID
                xPEstado.Value = prValeModificado.pdEstado
                xPVencimiento.Value = prValeModificado.pdVencimiento

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ModificarVale"

                objComm.Parameters.Add(xPEstado)
                objComm.Parameters.Add(xPVencimiento)
                objComm.Parameters.Add(xPID)


                xComms.Add(objComm)

                If prValeModificado.pdEstado = enEstadoVale.Descargado Then

                End If
                xBD.EjecutarTransaccion(xComms)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function ObtenerPorMovimiento(ByVal prIDMovimiento As Long) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet
                Dim xPMovimiento As New SqlParameter("@movimiento", SqlDbType.BigInt)

                xPMovimiento.Value = prIDMovimiento

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerValeMovimiento"

                objComm.Parameters.Add(xPMovimiento)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ComandoValeCombustible(ByVal prVale As String, ByVal prCombustible As Byte) As SqlCommand
            Dim objComm As New SqlCommand
            Dim xPVale As New SqlParameter("@vale", SqlDbType.VarChar)
            Dim xPCombustible As New SqlParameter("@combustible", SqlDbType.TinyInt)

            xPVale.Value = prVale
            xPCombustible.Value = prCombustible

            objComm.CommandType = CommandType.StoredProcedure
            objComm.CommandText = "RegistrarValeCombustible"

            objComm.Parameters.Add(xPVale)
            objComm.Parameters.Add(xPCombustible)

            Return objComm
        End Function

    End Class ' END CLASS DEFINITION mVales

End Namespace ' AccesoADatos.Mapeo.Vales

