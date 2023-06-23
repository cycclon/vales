Public Class ctrlCategoriaMenu

    Private xBotones As List(Of ctrlBotonMenu)

    Public Property pdTitulo() As String
        Get
            Return Me.lblTitulo.Text
        End Get
        Set(ByVal value As String)
            Me.lblTitulo.Text = value
        End Set
    End Property

    Public Property pdBotones() As List(Of ctrlBotonMenu)
        Get
            Return Me.xBotones
        End Get
        Set(ByVal value As List(Of ctrlBotonMenu))
            Me.xBotones = value
            Dim xTop As Integer = 20
            'Me.LimpiarBotones()
            For Each xx As ctrlBotonMenu In xBotones
                xx.Left = 0
                xx.Top = xTop
                xTop += 30

                Me.Controls.Add(xx)
            Next

            Me.Height = 13 + (xBotones.Count * 30) + 13
        End Set
    End Property

    Private Sub LimpiarBotones()
        Me.Controls.Clear()
    End Sub
End Class
