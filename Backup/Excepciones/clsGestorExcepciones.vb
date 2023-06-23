Public Class clsGestorExcepciones

    Protected Const xPreambulo As String = "/*preambulo*\
    Private xRutaLog As String = System.AppDomain.CurrentDomain.BaseDirectory() & "Log\"
	Private xArchivo As String
	Private Shared xInstancia As clsGestorExcepciones
    Private xMensajeGenerico As String = "Ocurrió un error en la aplicación. Se generó un informe en " & xRutaLog & xArchivo

    Friend Shared ReadOnly Property pdPreambulo() As String
        Get
            Return xPreambulo
        End Get
    End Property

    Public Function Gestionar(ByVal prError As Exception, ByVal prVentana As String) As String
        If Left(prError.Message, Len(clsGestorExcepciones.pdPreambulo)) = clsGestorExcepciones.pdPreambulo Then
            Return Right(prError.Message, Len(prError.Message) - Len(clsGestorExcepciones.pdPreambulo))
        Else
            Dim xStr As String = ""
            xStr &= "-----------------------------------------------------------------------" & vbCrLf
            xStr &= Date.Now & vbCrLf
            xStr &= "Ventana: " & prVentana & vbCrLf
            xStr &= "Reporte: " & prError.Message & vbCrLf

            clsGestorLog.GrabarenLog(xStr, xRutaLog, "Log.txt")
            Return ""
        End If
    End Function


	
	
End Class ' END CLASS DEFINITION clsGestorExcepciones


