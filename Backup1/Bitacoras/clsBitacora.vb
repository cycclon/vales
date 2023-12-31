' Static Model

Imports AccesoADatos.Mapeo.Bitacoras
Imports Entidades.Bitacoras

Public Class clsBitacora : Implements iBitacora

    Protected xTipo As Entidades.Bitacoras.enTipoBitacora

    Protected xID As Long

    Protected xFecha As Date

    Protected xUsuarioGenerador As String

    Protected xMensaje As String

    Protected Sub Inicializar()
        Me.xMensaje = clsFabricaBitacoras.Fabricar(Me.xTipo)
    End Sub

    Public Shared Function Listar(ByVal prUsuario As String, _
              ByVal prCantidad As Byte) As List(Of iBitacora)
        Try
            Dim objDS As DataSet = mBitacoras.Listar(prUsuario, prCantidad)
            Dim xBs As New List(Of iBitacora)
            For Each xx As DataRow In objDS.Tables(0).Rows
                Dim xB As New clsBitacora
                xB.ArmarBitacora(xx)
                xBs.Add(xB)
            Next

            Return xBs
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub ArmarBitacora(ByVal prRegistro As DataRow)
        With prRegistro
            Me.xFecha = .Item("bit_fecha")
            Me.xID = .Item("bit_id")
            Me.xMensaje = .Item("bit_bitacora")
            Me.xTipo = .Item("bit_tipo")
            Me.xUsuarioGenerador = .Item("bit_usuario")
        End With
    End Sub

    Public Sub Registrar()
        Try
            Me.xFecha = Date.Now
            mBitacoras.Registrar(Me)
            Dim xIB As clsIteradorBitacoras = clsIteradorBitacoras.Instanciar
            If xIB.ComprobarLista Then xIB.pdBitacoras.Insert(0, Me)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Overridable Function Mensaje() As String
        Return ""
    End Function

    Public Property pdFecha() As Date Implements Entidades.Bitacoras.iBitacora.pdFecha
        Get
            Return Me.xFecha
        End Get
        Set(ByVal value As Date)
            Me.xFecha = value
        End Set
    End Property

    Public Property pdID() As Long Implements Entidades.Bitacoras.iBitacora.pdID
        Get
            Return Me.xID
        End Get
        Set(ByVal value As Long)
            Me.xID = value
        End Set
    End Property

    Public Property pdTipo() As Entidades.Bitacoras.enTipoBitacora Implements Entidades.Bitacoras.iBitacora.pdTipo
        Get
            Return Me.xTipo
        End Get
        Set(ByVal value As Entidades.Bitacoras.enTipoBitacora)
            Me.xTipo = value
        End Set
    End Property

    Public Property pdUsuarioGenerador() As String Implements Entidades.Bitacoras.iBitacora.pdUsuarioGenerador
        Get
            Return Me.xUsuarioGenerador
        End Get
        Set(ByVal value As String)
            Me.xUsuarioGenerador = value
        End Set
    End Property

    Public ReadOnly Property pdMensaje() As String Implements Entidades.Bitacoras.iBitacora.pdMensaje
        Get
            Return Me.xMensaje & Me.Mensaje
        End Get
    End Property

    Public Shared Function Listar(ByVal prFiltros As List(Of iFiltroBitacora)) As List(Of iBitacora)
        Try
            Dim xIB As clsIteradorBitacoras = clsIteradorBitacoras.Instanciar
            Dim xBsF As New List(Of iBitacora)

            xIB.pdFiltros = prFiltros

            If Not xIB.ComprobarLista Then
                Dim xBs As New List(Of iBitacora)
                Dim objDS As DataSet = mBitacoras.Listar
                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xB As New clsBitacora
                    xB.ArmarBitacora(xx)
                    xBs.Add(xB)
                Next
                xIB.pdBitacoras = xBs
            End If
            xIB.Primero()
            While Not xIB.FinAlcanzado
                xBsF.Add(xIB.pdItemActual)
                xIB.Siguiente()
            End While
            Return xBsF
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class ' END CLASS DEFINITION clsBitacora
