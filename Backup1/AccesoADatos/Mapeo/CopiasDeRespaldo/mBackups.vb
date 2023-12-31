Imports PRS.Framework.Excepciones.Archivos
Imports Entidades.CopiasDeRespaldo

Namespace Mapeo.CopiasDeRespaldo

    Public Class mBackups

        Public Shared Sub Generar(ByVal prBackup As iBackup)
            Try
                'Dim xComms As New List(Of SqlCommand)

                'Dim xBD As New clsAccesoBD(enBDs.Vales)
                'Dim objComm As New SqlCommand
                'Dim xPID As New SqlParameter("@id", SqlDbType.Int)
                'Dim xPBase As New SqlParameter("@base", SqlDbType.VarChar)
                'Dim xPFecha As New SqlParameter("@fecha", SqlDbType.DateTime)
                'Dim xPArchivo As New SqlParameter("@archivo", SqlDbType.VarChar)

                'With prBackup
                '    .pdID = Tablas.clsTablas.ObtenerClave(enBDs.Vales, "copia_de_respaldo")
                '    xPID.Value = .pdID
                '    xPBase.Value = .pdBase.pdNombre
                '    xPFecha.Value = .pdFecha
                '    xPArchivo.Value = .pdArchivo
                'End With

                'objComm.CommandType = CommandType.StoredProcedure
                'objComm.CommandText = "RegistrarBackup"

                'With objComm.Parameters
                '    .Add(xPID)
                '    .Add(xPBase)
                '    .Add(xPFecha)
                '    .Add(xPArchivo)
                'End With

                'xBD.EjecutarComando(objComm)

                Select Case prBackup.pdBase.pdNombre
                    Case "Vales"
                        GenerarBackup(prBackup.pdArchivo, enBDs.Vales)
                    Case "Bitacoras"
                        GenerarBackup(prBackup.pdArchivo, enBDs.Bitacoras)
                End Select
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Private Shared Sub GenerarBackup(ByVal prRuta As String, ByVal prBase As enBDs)
            Try
                Dim xBD As New clsAccesoBD(prBase)

                Dim objComm As New SqlCommand
                Dim xPRuta As New SqlParameter("@ruta", SqlDbType.VarChar)


                xPRuta.Value = prRuta

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "GenerarBackup"

                objComm.Parameters.Add(xPRuta)

                xBD.EjecutarComando(objComm)
            Catch ex As Exception
                Throw New exErrorEscrituraPermisos(prRuta)
            End Try
        End Sub

        Public Shared Sub Restaurar(ByVal prRuta As String, ByVal prBase As enBDs)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                'MATAR CONEXIONES
                Dim objComm2 As New SqlCommand
                objComm2.CommandType = CommandType.Text
                Select Case prBase
                    Case enBDs.Bitacoras
                        objComm2.CommandText = "ALTER DATABASE refinorbitacoras SET SINGLE_USER WITH ROLLBACK IMMEDIATE"
                    Case enBDs.Vales
                        objComm2.CommandText = "ALTER DATABASE refinorvales SET SINGLE_USER WITH ROLLBACK IMMEDIATE"
                End Select
                xBD.EjecutarComando(objComm2)

                Dim objComm As New SqlCommand
                Dim objDS As New DataSet
                Dim xPRuta As New SqlParameter("@ruta", SqlDbType.VarChar)

                xPRuta.Value = prRuta
                objComm.CommandType = CommandType.Text

                Select Case prBase
                    Case enBDs.Bitacoras
                        objComm.CommandText = "RESTORE  DATABASE refinorbitacoras FROM DISK = @ruta WITH REPLACE"
                    Case enBDs.Vales
                        objComm.CommandText = "RESTORE  DATABASE refinorvales FROM DISK = @ruta WITH REPLACE"
                End Select

                objComm.Parameters.Add(xPRuta)

                xBD.RestaurarBD(objComm)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function Listar() As DataSet
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim objDS As New DataSet

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "ListarBackups"

                objDS = xBD.EjecutarConsulta(objComm)

                Return objDS
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Sub Eliminar(ByVal prID As Short)
            Try
                Dim xBD As New clsAccesoBD(enBDs.Vales)
                Dim objComm As New SqlCommand
                Dim xPID As New SqlParameter("@id", SqlDbType.Int)

                xPID.Value = prID

                objComm.CommandType = CommandType.StoredProcedure
                objComm.CommandText = "EliminarBackup"

                objComm.Parameters.Add(xPID)

                xBD.EjecutarComando(objComm)
            Catch ex As Exception
                Throw
            End Try
        End Sub

    End Class ' END CLASS DEFINITION mBackups

End Namespace ' AccesoADatos.Mapeo.CopiasDeRespaldo

