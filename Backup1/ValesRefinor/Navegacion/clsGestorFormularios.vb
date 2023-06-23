Namespace Navegacion
    Public Class clsGestorFormularios

        Public Shared Sub Abrir(ByVal prFormulario As enFormulario, ByVal prMensaje As String)
            Try
                Dim xFormulario As clsFormulario = clsFabricaFormularios.Fabricar(prFormulario, prMensaje)
                xFormulario.Show()
            Catch ex As Exception
                MsgBox(ManejarExcepcion(ex, "Error de navegación"), MsgBoxStyle.OkOnly, xTitulo & "Error de navegación")
            End Try
        End Sub

    End Class
End Namespace

