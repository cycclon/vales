Imports System.IO

Friend Class clsGestorLog
    Friend Shared Sub GrabarenLog(ByVal prCadena As String, ByVal prRUta As String, ByVal prArchivo As String)
        Try
            If Not IO.Directory.Exists(prRUta) Then IO.Directory.CreateDirectory(prRUta)

            'Variables para abrir el archivo en modo de escritura
            Dim strStreamW As Stream
            Dim strStreamWriter As StreamWriter

            'Se abre el archivo y si este no existe se crea
            strStreamW = File.Open(prRUta & prArchivo, FileMode.Append)
            strStreamWriter = New StreamWriter(strStreamW, _
                                System.Text.Encoding.UTF8)

            strStreamWriter.WriteLine(prCadena)
            strStreamWriter.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class
