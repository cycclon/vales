' Static Model


Imports Entidades.Combustibles

Namespace Mapeo.Combustibles

    Public Class mCombustibles

        Public Shared Sub Registrar(ByVal prCombustible As iCombustible)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.TinyInt)
                Dim xPNombre As New SqlParameter("@nombre", SqlDbType.VarChar)

                With prCombustible
                    .pdID = Tablas.clsTablas.ObtenerClave(enBDs.Vales, "combustible")
                    xPID.Value = .pdID
                    xPNombre.Value = .pdNombre
                End With

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "RegistrarCombustible"

                objComm.Parameters.Add(xPID)
                objComm.Parameters.Add(xPNombre)

                xBD.EjecutarComando(objComm)

            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function Listar(ByVal prEstado As enEstadoCombustible) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPEstado As New SqlParameter("@estado", SqlDbType.TinyInt)
                Dim objDS As New DataSet

                xPEstado.Value = prEstado

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarCombustiblesEstado"

                objComm.Parameters.Add(xPEstado)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorVale(ByVal prVale As String) As DataSet
            Dim xBD As New clsAccesoBD(enBDs.Vales)
            Dim objComm As New SqlCommand
            Dim xPVale As New SqlParameter("@vale", SqlDbType.VarChar)
            Dim objDS As New DataSet
            If prVale Is Nothing Then
                xPVale.Value = ""
            Else
                xPVale.Value = prVale
            End If

            objComm.CommandType = CommandType.StoredProcedure
            objComm.CommandText = "ObtenerCombustibleVale"

            objComm.Parameters.Add(xPVale)

            objDS = xBD.EjecutarConsulta(objComm)

            Return objDS

        End Function

        Public Shared Function Obtener(ByVal prNombre As String) As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPNombre As New SqlParameter("@nombre", SqlDbType.VarChar)
                Dim objDS As New DataSet

                xPNombre.Value = prNombre

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ObtenerCombustiblesNombre"

                objComm.Parameters.Add(xPNombre)

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Sub Modificar(ByVal prCombustibleModificado As iCombustible)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.TinyInt)
                Dim xPEstado As New SqlParameter("@estado", SqlDbType.TinyInt)

                With prCombustibleModificado
                    xPID.Value = .pdID
                    xPEstado.Value = .pdEstado
                End With

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ModificarCombustible"

                objComm.Parameters.Add(xPEstado)
                objComm.Parameters.Add(xPID)

                xBD.EjecutarComando(objComm)
            Catch ex As Exception
                Throw
            End Try
        End Sub

    End Class ' END CLASS DEFINITION mCombustibles

End Namespace ' AccesoADatos.Mapeo.Combustibles

