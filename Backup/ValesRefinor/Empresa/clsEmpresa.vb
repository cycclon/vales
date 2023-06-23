Public Class clsEmpresa

    Private xEmpresa As clsStrategyEmpresa

    Private Shared xSingleton As clsEmpresa

    Public Shared Function Instanciar(ByVal prEmpresa As enEmpresas) As clsEmpresa
        If xSingleton Is Nothing Then xSingleton = New clsEmpresa(prEmpresa)
        Return xSingleton
    End Function

    Private Sub New(ByVal prEmpresa As enEmpresas)
        Select Case prEmpresa
            Case enEmpresas.ElTriangulo
                Me.xEmpresa = New clsTriangulo
            Case enEmpresas.SanFranciscoSRL
                Me.xEmpresa = New clsSanFrancisco
            Case enEmpresas.LasMarias
                Me.xEmpresa = New clsLasMarias
        End Select
    End Sub

    Public ReadOnly Property pdRazonSocial() As String
        Get
            Return Me.xEmpresa.pdRazonSocial
        End Get
    End Property

    Public ReadOnly Property pdDirección() As String
        Get
            Return Me.xEmpresa.pdDirección
        End Get
    End Property

    Public ReadOnly Property pdEncabezado() As Image
        Get
            Return Me.xEmpresa.pdEncabezado
        End Get
    End Property

    Public ReadOnly Property pdDueños() As String
        Get
            Return Me.xEmpresa.pdDueños
        End Get
    End Property

    Public ReadOnly Property pdPosicionLogo() As Byte
        Get
            Return Me.xEmpresa.pdPosicionLogo
        End Get
    End Property

#Region "Clases Anidadas"
    Private MustInherit Class clsStrategyEmpresa

        MustOverride ReadOnly Property pdRazonSocial() As String

        MustOverride ReadOnly Property pdDirección() As String

        MustOverride ReadOnly Property pdEncabezado() As Image

        MustOverride ReadOnly Property pdDueños() As String

        MustOverride ReadOnly Property pdPosicionLogo() As Byte
    End Class

    Private Class clsTriangulo : Inherits clsStrategyEmpresa

        Public Overrides ReadOnly Property pdDirección() As String
            Get
                Return "Ruta 5 esquina Solano Gómez (5300) L. R."
            End Get
        End Property

        Public Overrides ReadOnly Property pdEncabezado() As System.Drawing.Image
            Get
                Return My.Resources.Encabezado
            End Get
        End Property

        Public Overrides ReadOnly Property pdRazonSocial() As String
            Get
                Return "EL TRIÁNGULO"
            End Get
        End Property

        Public Overrides ReadOnly Property pdDueños() As String
            Get
                Return "de Carlos de la Fuente y Luis de la Fuente S. de H."
            End Get
        End Property


        Public Overrides ReadOnly Property pdPosicionLogo() As Byte
            Get
                Return 30
            End Get
        End Property
    End Class

    Private Class clsSanFrancisco : Inherits clsStrategyEmpresa

        Public Overrides ReadOnly Property pdDirección() As String
            Get
                Return "Av. San Francisco 600 (5300) L. R."
            End Get
        End Property

        Public Overrides ReadOnly Property pdEncabezado() As System.Drawing.Image
            Get
                Return My.Resources.Encabezadosf
            End Get
        End Property

        Public Overrides ReadOnly Property pdRazonSocial() As String
            Get
                Return "SAN FRANCISCO S.R.L."
            End Get
        End Property

        Public Overrides ReadOnly Property pdDueños() As String
            Get
                Return ""
            End Get
        End Property

        Public Overrides ReadOnly Property pdPosicionLogo() As Byte
            Get
                Return 13
            End Get
        End Property
    End Class

    Private Class clsLasMarias : Inherits clsStrategyEmpresa

        Public Overrides ReadOnly Property pdDirección() As String
            Get
                Return "Rivadavia 402 y Av. Angeleli 950"
            End Get
        End Property

        Public Overrides ReadOnly Property pdDueños() As String
            Get
                Return ""
            End Get
        End Property

        Public Overrides ReadOnly Property pdEncabezado() As System.Drawing.Image
            Get
                Return My.Resources.Encabezadolm
            End Get
        End Property

        Public Overrides ReadOnly Property pdPosicionLogo() As Byte
            Get
                Return 13
            End Get
        End Property

        Public Overrides ReadOnly Property pdRazonSocial() As String
            Get
                Return "LAS MARIAS S.R.L."
            End Get
        End Property
    End Class
#End Region

    Public Enum enEmpresas
        ElTriangulo = 1
        SanFranciscoSRL = 2
        LasMarias = 3
    End Enum
End Class
