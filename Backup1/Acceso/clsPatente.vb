' Static Model

Imports AccesoADatos.Mapeo.Acceso
Imports Entidades.Acceso

Public Class clsPatente : Implements iPatente

    Protected xID As Byte

    Protected xNombre As String

    Public Property pdID() As Byte Implements Entidades.Acceso.iPatente.pdID
        Get
            Return Me.xID
        End Get
        Set(ByVal value As Byte)
            Me.xID = value
        End Set
    End Property

    Public Property pdNombre() As String Implements Entidades.Acceso.iPatente.pdNombre
        Get
            Return Me.xNombre
        End Get
        Set(ByVal value As String)
            Me.xNombre = value
        End Set
    End Property

    Private Sub ArmarPatente(ByVal prRegistro As DataRow)
        Me.xID = prRegistro.Item("pat_id")
        Me.xNombre = prRegistro.Item("pat_nombre")
    End Sub

    Public Shared Function Listar(ByVal prFamilia As Byte) As List(Of iPatente)
        Try
            Dim objDS As DataSet = mPatentes.ObtenerPatentes(prFamilia)
            Dim xPatentes As New List(Of iPatente)
            For Each xx As DataRow In objDS.Tables(0).Rows
                Dim xP As New clsPatente
                xP.ArmarPatente(xx)
                xPatentes.Add(xP)
            Next
            Return xPatentes
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class ' END CLASS DEFINITION clsPatente


