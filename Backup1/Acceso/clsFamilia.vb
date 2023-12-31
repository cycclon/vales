' Static Model

Imports AccesoADatos.Mapeo.Acceso
Imports Entidades.Acceso

Public Class clsFamilia : Implements iFamilia

    Protected xPatentes As List(Of Entidades.Acceso.iPatente)

    Protected xNombre As String

    Protected xID As Byte

    Private xFamilia As Acceso.clsFamilia

    Public Sub New(ByVal prID As Integer)
        Me.xID = prID
    End Sub

    Public Sub New()

    End Sub

    Public Property pdID() As Byte Implements Entidades.Acceso.iFamilia.pdID
        Get
            Return Me.xID
        End Get
        Set(ByVal value As Byte)
            Me.xID = value
        End Set
    End Property

    Public Property pdNombre() As String Implements Entidades.Acceso.iFamilia.pdNombre
        Get
            Return Me.xNombre
        End Get
        Set(ByVal value As String)
            Me.xNombre = value
        End Set
    End Property

    Public Property pdPatentes() As System.Collections.Generic.List(Of Entidades.Acceso.iPatente) Implements Entidades.Acceso.iFamilia.pdPatentes
        Get
            Try
                ArmarFull()
                Return Me.xFamilia.xPatentes
            Catch ex As Exception
                Throw
            End Try
        End Get
        Set(ByVal value As System.Collections.Generic.List(Of Entidades.Acceso.iPatente))
            Me.xFamilia.xPatentes = value
        End Set
    End Property

    Public Sub ArmarFull() Implements Entidades.iLazy.ArmarFull
        Try
            If Me.xFamilia Is Nothing Then
                Me.xFamilia = New clsFamilia
                Me.xFamilia.xPatentes = clsPatente.Listar(Me.xID)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow) Implements Entidades.iLazy.ArmarLazy
        With prRegistro
            Me.xID = .Item("fam_id")
            Me.xNombre = .Item("fam_nombre")
        End With
    End Sub

    Public Shared Function Listar(ByVal prIDUsuario As Short) As System.Collections.Generic.List(Of Entidades.Acceso.iFamilia)
        Try
            Dim objDS As DataSet = mFamilias.ObtenerFamilias(prIDUsuario)
            Dim xFamilias As New List(Of iFamilia)
            For Each xx As DataRow In objDS.Tables(0).Rows
                Dim xF As New clsFamilia
                xF.ArmarLazy(xx)
                xFamilias.Add(xF)
            Next

            Return xFamilias
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class ' END CLASS DEFINITION clsFamilia



