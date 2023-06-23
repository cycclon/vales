Module mGlobal
    Friend xTitulo As String = My.Application.Info.ProductName & " - "
    Private xF As frmLoading
    Private xL As Threading.Thread
    Friend xErrorCampo As String = "Hay errores en los campos del formulario."
    Friend xEmpresa As clsEmpresa.enEmpresas = clsEmpresa.enEmpresas.SanFranciscoSRL

    Friend Function ManejarExcepcion(ByVal prException As Exception, ByVal prTitulo As String) As String
        Dim xGE As New Excepciones.clsGestorExcepciones
        Dim xError As String = xGE.Gestionar(prException, prTitulo)
        If xError <> "" Then
            Return xError
        Else
            Return "Ocurrió un error en la aplicación. Si el problema persiste, comuníquese con el administrador."
        End If
    End Function

    Friend Sub MostrarLoading()

        If Not xL Is Nothing Then
            If xL.ThreadState = Threading.ThreadState.Running Then xL.Abort()
        End If

        xL = New System.Threading.Thread(AddressOf mGlobal.MostrarLoadingDialog)
        xL.Start()


    End Sub

    Private Sub MostrarLoadingDialog()
        xF = New frmLoading
        xF.ShowDialog()
    End Sub

    Friend Sub OcultarLoading()

        If xL.ThreadState = Threading.ThreadState.Running Then xL.Abort()
       
    End Sub

    Friend Sub CloseAllDataforms()

        Dim f As Form

        For Each f In frmPrincipal.MdiChildren
            f.Close()
        Next

    End Sub
End Module
