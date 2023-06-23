Public Class ctrlInformacion

    Public Property pdInformacion() As String
        Get
            Return Me.lblInformacion.Text
        End Get
        Set(ByVal value As String)
            Me.lblInformacion.Text = value
            
        End Set
    End Property

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Me.lblInformacion.Visible = True
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Me.lblInformacion.Visible = False
    End Sub
End Class
