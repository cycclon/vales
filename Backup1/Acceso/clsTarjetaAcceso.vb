Imports Entidades.Acceso
Imports AccesoADatos.Mapeo.Acceso
Public Class clsTarjetaAcceso : Implements iTarjetaAcceso

    Private xID As String

    Private xVigente As Boolean

    Public Property pdID() As String Implements Entidades.Acceso.iTarjetaAcceso.pdID
        Get
            Return Me.xID
        End Get
        Set(ByVal value As String)
            Me.xID = value
        End Set
    End Property

    Public Property pdVigente() As Boolean Implements Entidades.Acceso.iTarjetaAcceso.pdVigente
        Get
            Return Me.xVigente
        End Get
        Set(ByVal value As Boolean)
            Me.xVigente = value
        End Set
    End Property

    Public Sub ArmarTarjeta(ByVal prRegistro As System.Data.DataRow) Implements Entidades.Acceso.iTarjetaAcceso.ArmarTarjeta
        With prRegistro
            Me.xID = .Item("tda_id")
            Me.xID = .Item("tda_vigente")
        End With
    End Sub

    Public Sub Obtener(ByVal prIDUsuario As Short) Implements Entidades.Acceso.iTarjetaAcceso.Obtener
        Try
            Dim objDS As DataSet = mTarjetasAcceso.Obtener(prIDUsuario)
            If objDS.Tables(0).Rows.Count <> 0 Then
                ArmarTarjeta(objDS.Tables(0).Rows(0))
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Registrar(ByVal prIDUsuario As Short) Implements Entidades.Acceso.iTarjetaAcceso.Registrar
        Try
            Me.xID = clsGeneradorIDs.Generate(15)
            Me.xVigente = True
            mTarjetasAcceso.Registrar(prIDUsuario, Me)
            'BITACORA
            Dim xS As clsSesion = clsSesion.ObtenerInstancia
            Dim xBTarjeta As New clsBTarjetaAcceso(Entidades.Bitacoras.enTipoBitacora.TarjetaDeAccesoGenerada)
            xBTarjeta.pdUsuario = clsUsuario.ObtenerPorID(prIDUsuario)
            xBTarjeta.pdTarjeta = Me
            xBTarjeta.pdUsuarioGenerador = xS.pdUsuario.pdUsername
            xBTarjeta.Registrar()
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class
