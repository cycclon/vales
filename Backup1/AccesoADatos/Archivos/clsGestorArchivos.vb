Imports System.IO
Namespace Archivos
    Public Class clsGestorArchivos
        Public Shared Function GetFileContents(ByVal FullPath As String) As String

            Dim strContents As String
            Dim objReader As StreamReader
            Try

                objReader = New StreamReader(FullPath)
                strContents = objReader.ReadToEnd()
                objReader.Close()
                Return strContents
            Catch Ex As Exception
                Throw
            End Try
        End Function

        Public Shared Sub SaveTextToFile(ByVal strData As String, _
     ByVal FullPath As String)

            Dim objReader As StreamWriter
            Try
                objReader = New StreamWriter(FullPath)
                objReader.Write(Encriptacion.clsGestorEncriptacion.Encriptar(strData))
                objReader.Close()

            Catch Ex As Exception
                Throw
            End Try
        End Sub
    End Class
End Namespace

