' Static Model

Imports Acceso
Imports Entidades.CopiasDeRespaldo
Imports AccesoADatos.Mapeo.CopiasDeRespaldo
Public Class clsBackup : Implements iBackup

    Protected xBase As Entidades.CopiasDeRespaldo.iBase

    Protected xFecha As Date

    Protected xID As Integer

    Protected xArchivo As String

    Private Sub New(ByVal prRegistro As DataRow)
        With prRegistro
            Me.xArchivo = .Item("cdr_archivo")
            Me.xBase = New clsBase(.Item("cdr_base"), 0)
            Me.xFecha = .Item("cdr_fecha")
            Me.xID = .Item("cdr_id")
        End With
    End Sub

    Public Sub New()
        Me.xFecha = Date.Now
    End Sub

    Public Sub New(ByVal prBase As String)
        Me.New()
        Select Case prBase
            Case "Bitacoras"
                Me.xBase = New clsBase(AccesoADatos.enBDs.Bitacoras)
            Case "Vales"
                Me.xBase = New clsBase(AccesoADatos.enBDs.Vales)
        End Select
    End Sub

    Public Property pdArchivo() As String Implements Entidades.CopiasDeRespaldo.iBackup.pdArchivo
        Get
            Return Me.xArchivo
        End Get
        Set(ByVal value As String)
            Me.xArchivo = value
        End Set
    End Property

    Public Property pdFecha() As Date Implements Entidades.CopiasDeRespaldo.iBackup.pdFecha
        Get
            Return Me.xFecha
        End Get
        Set(ByVal value As Date)
            Me.xFecha = value
        End Set
    End Property

    Public Property pdID() As Integer Implements Entidades.CopiasDeRespaldo.iBackup.pdID
        Get
            Return Me.xID
        End Get
        Set(ByVal value As Integer)
            Me.xID = value
        End Set
    End Property

    Public Property pdBase() As Entidades.CopiasDeRespaldo.iBase Implements Entidades.CopiasDeRespaldo.iBackup.pdBase
        Get
            Return Me.xBase
        End Get
        Set(ByVal value As Entidades.CopiasDeRespaldo.iBase)
            Me.xBase = value
        End Set
    End Property

    Public Sub Generar(ByVal prUnidad As String) Implements Entidades.CopiasDeRespaldo.iBackup.Generar
        Try
            Dim xA As String

            xA = Me.xBase.pdNombre & "bk" & Format(Day(Me.pdFecha), "00") & Format(Month(Me.pdFecha), "00") & Year(Me.pdFecha) & Format(Hour(Me.pdFecha), "00") & Format(Minute(Me.pdFecha), "00") & _
           Format(Second(Me.pdFecha), "00") & ".bak"

            Me.xArchivo = prUnidad & xA

            mBackups.Generar(Me)

            Dim xS As clsSesion = clsSesion.ObtenerInstancia
            Dim xBB As New clsBBackup(Entidades.Bitacoras.enTipoBitacora.BackupGenerado)
            xBB.pdBackup = Me
            xBB.pdUsuarioGenerador = xS.pdUsuario.pdUsername
            xBB.Registrar()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public ReadOnly Property pdNombreBase() As String Implements Entidades.CopiasDeRespaldo.iBackup.pdNombreBase
        Get
            Return Me.xBase.pdNombre
        End Get
    End Property

    Public Shared Sub Restaurar(ByVal prArchivo As String)
        Try
            Dim xStr As String = Left(Right(prArchivo, 22), 2)


            Select Case xStr
                Case "as"
                    mBackups.Restaurar(prArchivo, AccesoADatos.enBDs.Bitacoras)
                Case "es"
                    mBackups.Restaurar(prArchivo, AccesoADatos.enBDs.Vales)
                Case Else

            End Select
            'Dim xS As clsSesion = clsSesion.ObtenerInstancia
            'Dim xBB As New clsBBackup(Entidades.Bitacoras.enTipoBitacora.BaseRestaurada)
            'xBB.pdBackup = Me
            'xBB.pdUsuarioGenerador = xS.pdUsuario.pdUsername
            'xBB.Registrar()
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class ' END CLASS DEFINITION clsBackup



