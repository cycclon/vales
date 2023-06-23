Public Class ctrlBotonMenu
    Private xAccion As Navegacion.enFormulario

    Public Property pdTexto() As String
        Get
            Return Me.btnBoton.Text
        End Get
        Set(ByVal value As String)
            Me.btnBoton.Text = value
        End Set
    End Property

    Public Property pdFormulario() As Navegacion.enFormulario
        Get
            Return Me.xAccion
        End Get
        Set(ByVal value As Navegacion.enFormulario)
            Me.xAccion = value
        End Set
    End Property

    Private Sub btnBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoton.Click
        Try
            CloseAllDataforms()
            Navegacion.clsGestorFormularios.Abrir(Me.xAccion, "")
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub New(ByVal prTexto As String, ByVal prFormulario As Navegacion.enFormulario)
        InitializeComponent()

        Me.btnBoton.Text = prTexto
        Me.xAccion = prFormulario

    End Sub

    Public Sub New(ByVal prTexto As String)
        InitializeComponent()
        Me.btnBoton.Text = prTexto
    End Sub
End Class
