' Static Model

Imports Entidades.CopiasDeRespaldo
Imports AccesoADatos


Public Class clsBase : Implements iBase

    Protected xNombre As String

    Public Sub New(ByVal prBase As enBDs)
        Select Case prBase
            Case enBDs.Bitacoras
                Me.xNombre = "Bitacoras"
            Case enBDs.Vales
                Me.xNombre = "Vales"
        End Select
    End Sub

    Public Sub New(ByVal prBase As String, ByVal prD As Byte)
        Me.xNombre = prBase
    End Sub

    Public Property pdNombre() As String Implements Entidades.CopiasDeRespaldo.iBase.pdNombre
        Get
            Return Me.xNombre
        End Get
        Set(ByVal value As String)
            Me.xNombre = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.xNombre
    End Function
End Class ' END CLASS DEFINITION clsBase



