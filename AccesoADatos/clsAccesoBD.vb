Imports System.Collections.Generic
Imports System
Imports System.Data.Common

Public Class clsAccesoBD
    'Conexion
    Public objConexion As New SqlConnection

    Public Shared Sub ProbarConexion(ByVal prStringConexion As String)
        Try
            Dim xC As New SqlConnection

            xC.ConnectionString = prStringConexion
            xC.Open()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub New(ByVal prBD As enBDs)
        Try
            Dim xArchivo As String
            Dim xRuta As String = System.AppDomain.CurrentDomain.BaseDirectory()
            Dim xCadenaEncriptada As String
            Select Case prBD
                Case enBDs.Vales
                    xArchivo = "rv.txt"
                Case enBDs.Bitacoras
                    xArchivo = "rb.txt"
                Case Else
                    xArchivo = "rv.txt"
            End Select
            xRuta &= xArchivo
            xCadenaEncriptada = Archivos.clsGestorArchivos.GetFileContents(xRuta)
            objConexion.ConnectionString = Encriptacion.clsGestorEncriptacion.Desencriptar(xCadenaEncriptada)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Ejecuta un comando que no devuelve una consulta
    ''' </summary>
    ''' <param name="prComando">Comando a ejecutar</param>
    ''' <remarks></remarks>
    Public Sub EjecutarComando(ByVal prComando As Object)
        Try
            'Conecto con la base de datos
            Conectar()
            'Establezco la conexion activa
            prComando.Connection = objConexion

            'Ejecuto el comando
            prComando.executenonquery()

        Catch ex As Exception
            Throw New BDException(1, ex.Message)
        Finally
            'Desconecto de la base de datos
            Desconectar()
        End Try
    End Sub

    Public Sub RestaurarBD(ByVal prComando As Object)
        Try
            'Conecto con la base de datos
            Conectar()
            objConexion.ChangeDatabase("master")
            'Establezco la conexion activa
            prComando.Connection = objConexion

            'Ejecuto el comando
            prComando.executenonquery()

        Catch ex As Exception
            Throw New BDException(1, ex.Message)
        Finally
            'Desconecto de la base de datos
            Desconectar()
        End Try
    End Sub

    ''' <summary>
    ''' Ejecuta una consulta
    ''' </summary>
    ''' <param name="prComando">Comando a ejecutar</param>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Public Function EjecutarConsulta(ByVal prComando As Object) As DataSet
        'Objeto DataSet
        Dim objDS As New DataSet
        'Objeto dataadapter
        Dim objDA As New SqlDataAdapter

        Try
            'Conecto con la base de datos
            Conectar()
            'Establezco la conexion activa
            prComando.Connection = objConexion
            objDA.SelectCommand = prComando

            'Ejecuto la consulta
            objDA.Fill(objDS)

            'Devuelvo el DataSet
            Return objDS
        Catch ex As Exception
            Throw New BDException(2, ex.Message)
        Finally
            'Desconecto de la base de datos
            Desconectar()
        End Try
    End Function

    ''' <summary>
    ''' Ejecuta un grupo de comandos en una transaccion
    ''' </summary>
    ''' <param name="prComandos">Lista de comandos</param>
    ''' <remarks></remarks>
    Public Sub EjecutarTransaccion(ByVal prComandos As List(Of SqlCommand))
        'Conecto a la base de datos
        Conectar()
        'transaccion
        Dim xTrans As SqlTransaction = objConexion.BeginTransaction()
        Try
            'Contador
            Dim xCount As Integer = 0

            'Recorro los comandos
            For xCount = 0 To (prComandos.Count - 1)
                'Conexion activa
                prComandos(xCount).Connection = objConexion
                'Establezco la transaccion
                prComandos(xCount).Transaction = xTrans

                'Ejecuto el comando
                prComandos(xCount).ExecuteNonQuery()
            Next

            'Confirmo la transaccion
            xTrans.Commit()

            'Desconecto de la base de datos
            Desconectar()
        Catch ex As Exception
            'Elimino los cambios realizados hasta el momento
            xTrans.Rollback()

            Throw New BDException(3, ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Conecta con la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Conectar()
        Try
            'objConexion.ConnectionString = "Data Source=PCVERO\SQLEXPRESS;Initial Catalog=refinorbitacoras;User Id=refinor;Password=triangulo3"
            'Abro la conexion
            objConexion.Open()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Desconecta de la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Desconectar()
        Try
            'Desconecto de la BD
            objConexion.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Class BDException : Inherits Exception

        Public Sub New(ByVal tipo As Integer, ByVal ex As String)
            Select Case tipo
                Case 1
                    Throw New Exception("Error al ejecutar el comando: " & ex)
                Case 2
                    Throw New Exception("Error al ejecutar la consulta: " & ex)
                Case 3
                    Throw New Exception("Error al ejecutar la transaccion: " & ex)
                Case 5
                    Throw New Exception("Error al conectar con la BD: " & ex)
                Case 6
                    Throw New Exception("Error al desconectar de la BD: " & ex)
                Case Else
                    Throw New Exception("Error accediendo a la BD: " & ex)
            End Select

        End Sub
    End Class
End Class ' END CLASS DEFINITION AccesoBD

