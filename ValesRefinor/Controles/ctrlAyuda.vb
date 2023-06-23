Public Class ctrlAyuda

    Public Property pdAyuda() As String
        Get
            Return Me.lblAyuda.Text
        End Get
        Set(ByVal value As String)
            Me.lblAyuda.Text = value
            If Me.lblAyuda.Text <> "" Then
                Me.Dimensionar()
                Me.Contraer()
            End If
        End Set
    End Property

    Private Sub Dimensionar()

        If lblAyuda.Height > 25 Then Me.Height = Me.lblAyuda.Height
        If Me.Parent.Width - Me.Location.X < Me.Width Then
            Me.Width = Me.Parent.Width - Me.Location.X - 10
            Dim xS As New System.Drawing.Size(Me.Parent.Width - Me.Location.X - 35, 0)
            Me.lblAyuda.MaximumSize = xS
        End If

    End Sub

    Private Sub pbAyuda_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbAyuda.MouseHover
        Me.lblAyuda.Visible = True
        Me.Dimensionar()
    End Sub

    Private Sub Contraer()
        Me.Height = 25
        Me.lblAyuda.Visible = False
        Me.Width = 250
    End Sub

    Private Sub pbAyuda_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbAyuda.MouseLeave
        Contraer()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.pdAyuda = ""
    End Sub
End Class
