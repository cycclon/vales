Imports Excepciones.Configuracion
Namespace Configuracion
    Public Class clsGestorConfiguracion

        Public Shared Function ComprobarArchivos() As Boolean

            Dim xRutaRB As String = System.AppDomain.CurrentDomain.BaseDirectory() & "rb.txt"
            Dim xRutaRV As String = System.AppDomain.CurrentDomain.BaseDirectory() & "rv.txt"

            If IO.File.Exists(xRutaRB) And IO.File.Exists(xRutaRV) Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Sub ProbarConexion(ByVal prServidor As String)
            Try
                Dim xStringConexion As String = "Data Source=" & prServidor & "\SQLEXPRESS;Initial Catalog=refinorbitacoras;User Id=refinor;Password=triangulo3"
                AccesoADatos.clsAccesoBD.ProbarConexion(xStringConexion)
            Catch ex As Exception
                Throw New exPruebaDeConexionFallida
            End Try
        End Sub

        Public Shared Sub EstablecerServidor(ByVal prNombre As String)
            Try
                Dim xStringConexion1 As String = "Data Source=" & prNombre & "\SQLEXPRESS;Initial Catalog=refinorbitacoras;User Id=refinor;Password=triangulo3"
                Dim xStringConexion2 As String = "Data Source=" & prNombre & "\SQLEXPRESS;Initial Catalog=refinorvales;User Id=refinor;Password=triangulo3"
                Dim xRutaRB As String = System.AppDomain.CurrentDomain.BaseDirectory() & "rb.txt"
                Dim xRutaRV As String = System.AppDomain.CurrentDomain.BaseDirectory() & "rv.txt"
                Dim xRutaSrv As String = System.AppDomain.CurrentDomain.BaseDirectory() & "server.txt"
                AccesoADatos.Archivos.clsGestorArchivos.SaveTextToFile(xStringConexion1, xRutaRB)
                AccesoADatos.Archivos.clsGestorArchivos.SaveTextToFile(xStringConexion2, xRutaRV)
                AccesoADatos.Archivos.clsGestorArchivos.SaveTextToFile(Encriptacion.clsGestorEncriptacion.Encriptar(prNombre), xRutaSrv)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function ObtenerServidor() As String
            Try
                Dim xRutaSrv As String = System.AppDomain.CurrentDomain.BaseDirectory() & "server.txt"
                Dim xSrv As String = Encriptacion.clsGestorEncriptacion.Desencriptar(Encriptacion.clsGestorEncriptacion.Desencriptar(AccesoADatos.Archivos.clsGestorArchivos.GetFileContents(xRutaSrv)))
                Return xSrv
            Catch ex As Exception
                Return ""
            End Try
        End Function
    End Class
End Namespace

