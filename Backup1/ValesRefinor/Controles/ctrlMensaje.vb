Public Class ctrlMensaje

    Private xTipo As enTipoMensaje
    Private xErrores As New List(Of String)

    Public Property pdErrores() As List(Of String)
        Get
            Return Me.xErrores
        End Get
        Set(ByVal value As List(Of String))
            Me.xErrores = value
        End Set
    End Property

    Public Property pdTipo() As enTipoMensaje
        Get
            Return Me.xTipo
        End Get
        Set(ByVal value As enTipoMensaje)
            Me.xTipo = value
            Select Case Me.xTipo
                Case enTipoMensaje.Mensaje
                    Me.pbImagen.Image = My.Resources.acceptvertumb
                    Me.lblMensaje.ForeColor = Color.DarkGreen
                Case enTipoMensaje.msgError
                    Me.pbImagen.Image = My.Resources.errorcirrotumb
                    Me.lblMensaje.ForeColor = Color.Red
                Case Else
                    Me.pbImagen.Image = My.Resources.errorcirrotumb
                    Me.lblMensaje.ForeColor = Color.Red
            End Select
        End Set
    End Property

    Public Property pdMensaje() As String
        Get
            Return Me.lblMensaje.Text
        End Get
        Set(ByVal value As String)
            Me.lblMensaje.Text = value
            If Me.lblMensaje.Text <> "" Then
                Me.pbImagen.Visible = True
            Else
                Me.pbImagen.Visible = False
            End If

            For Each xx As String In Me.xErrores
                Me.lblMensaje.Text &= vbCrLf
                Me.lblMensaje.Text &= "*" & xx
            Next
        End Set
    End Property

    Private Sub pbImagen_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbImagen.MouseHover
        Me.lblMensaje.Visible = True
    End Sub

    Private Sub pbImagen_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbImagen.MouseLeave
        Me.lblMensaje.Visible = False
    End Sub

    Public Enum enTipoMensaje
        msgError = 0
        Mensaje = 1
    End Enum
End Class
