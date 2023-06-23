Imports Entidades.Bitacoras
Public Class clsIteradorBitacoras
    Private xBitacoras As List(Of iBitacora)
    Private Shared xInstancia As clsIteradorBitacoras
    Private xIndice As Long
    Private xFiltros As List(Of iFiltroBitacora)

    Private Sub New()
        xIndice = 0
        xFiltros = New List(Of iFiltroBitacora)
    End Sub

    Public Property pdFiltros() As List(Of iFiltroBitacora)
        Get
            Return Me.xFiltros
        End Get
        Set(ByVal value As List(Of iFiltroBitacora))
            Me.xFiltros = value
        End Set
    End Property

    Public Shared Function Instanciar() As clsIteradorBitacoras
        If xInstancia Is Nothing Then xInstancia = New clsIteradorBitacoras
        Return xInstancia
    End Function

    Public Function ComprobarLista() As Boolean
        If xBitacoras Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Property pdBitacoras() As List(Of iBitacora)
        Get
            Return Me.xBitacoras
        End Get
        Set(ByVal value As List(Of iBitacora))
            Me.xBitacoras = value
        End Set
    End Property

    Private Function Filtrar(ByVal prIndice As Long) As Boolean
        Dim xF As Boolean = True
        If prIndice > xBitacoras.Count - 1 Then
            xF = False
        Else
            For Each xx As iFiltroBitacora In Me.xFiltros
                xF = xx.Filtrar(Me.xBitacoras(prIndice))
                If Not xF Then Exit For
            Next
        End If
        Return xF
    End Function

    Public Sub Siguiente()
        Do
            xIndice += 1
        Loop While (Not Filtrar(xIndice) And Not xIndice >= xBitacoras.Count)
    End Sub

    Public Sub Anterior()
        While Filtrar(xIndice - 1) Or Not xIndice - 1 > xBitacoras.Count - 1
            xIndice -= 1
        End While
    End Sub

    Public Sub Primero()
        Me.xIndice = -1
        Me.Siguiente()
    End Sub

    Public Sub Ultimo()
        Me.xIndice = xBitacoras.Count
    End Sub

    Public Function FinAlcanzado() As Boolean
        If xIndice >= Me.xBitacoras.Count Then
            Return True
        Else
            Return False
        End If
    End Function

    Public ReadOnly Property pdItemActual() As iBitacora
        Get
            If xBitacoras.Count > 0 Then
                Return Me.xBitacoras(xIndice)
            Else
                Return New clsBitacora
            End If
        End Get
    End Property
End Class
