Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Namespace Tablas
    Friend Class clsTablas

        ''' <summary>
        ''' Funcion para obtener un valor de clave para una tabla.
        ''' </summary>
        ''' <param name="prTabla">Tabla para la que se necesita un valor de clave.</param>
        ''' <returns>Cadena con el valor de clave.</returns>
        ''' <remarks></remarks>
        Public Shared Function ObtenerClave(ByVal prBD As enBDs, ByVal prTabla As String) As Long
            Try
                'Variable para la clave
                Dim xClave As Long = 1
                'DataSet
                Dim objDS As New DataSet
                'Comando
                Dim objComm As New SqlCommand
                'Variable para el SQL
                Dim xSQL As String
                'Contador
                Dim xCount As Long
                Dim xBD As New clsAccesoBD(prBD)

                'Armo la instruccion SQL
                xSQL = "SELECT * from " & prTabla

                'Tipo y texto del comando
                objComm.CommandType = CommandType.Text
                objComm.CommandText = xSQL

                'Ejecuto la consulta
                objDS = xBD.EjecutarConsulta(objComm)

                'Si la cantidad de filas es cero, devuelvo 1
                If objDS.Tables(0).Rows.Count = 0 Then
                    Return xClave
                Else 'sino
                    For xCount = 0 To (objDS.Tables(0).Rows.Count - 1)
                        'Comparo la clave actual con la clave de la tabla
                        If objDS.Tables(0).Rows(xCount).Item(0) <> xClave Then
                            Exit For
                        End If
                        'Incremento la clave
                        xClave = xClave + 1
                    Next
                    Return xClave
                End If
            Catch ex As Exception
                Throw
            End Try
        End Function

        ''' <summary>
        ''' Devuelve la ultima clave para una tabla con clave numerica
        ''' </summary>
        ''' <param name="prTabla">Nombre de la tabla</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function ObtenerUltimaClave(ByVal prBase As enBDs, ByVal prTabla As String) As Long
            Try
                'Variable para la clave
                Dim xClave As Long = 0
                'DataSet
                Dim objDS As New DataSet
                'Comando
                Dim objComm As New SqlCommand
                'Variable para el SQL
                Dim xSQL As String
                Dim xBD As New clsAccesoBD(prBase)

                'Armo la instruccion SQL
                xSQL = "SELECT * from " & prTabla

                'Tipo y texto del comando
                objComm.CommandType = CommandType.Text
                objComm.CommandText = xSQL

                'Ejecuto la consulta
                objDS = xBD.EjecutarConsulta(objComm)

                'Si la cantidad de filas es cero, devuelvo 1
                If objDS.Tables(0).Rows.Count = 0 Then
                    Return xClave
                Else 'sino
                    Return objDS.Tables(0).Rows((objDS.Tables(0).Rows.Count - 1)).Item(0)
                End If
            Catch ex As Exception
                Throw
            End Try
        End Function
    End Class
End Namespace




