' Static Model


Imports Entidades.CopiasDeRespaldo

Public Class clsAlmacenamiento : Implements iAlmacenamiento

    Protected xAlmacenamiento As Entidades.CopiasDeRespaldo.iAlmacenamiento

    Protected xBases As List(Of Entidades.CopiasDeRespaldo.iBase)

    Public Property pdBases() As System.Collections.Generic.List(Of Entidades.CopiasDeRespaldo.iBase) Implements Entidades.CopiasDeRespaldo.iAlmacenamiento.pdBases
        Get
            Return Me.xBases
        End Get
        Set(ByVal value As System.Collections.Generic.List(Of Entidades.CopiasDeRespaldo.iBase))
            Me.xBases = value
        End Set
    End Property

    Public Sub ArmarFull() Implements Entidades.iLazy.ArmarFull

    End Sub

    Public Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow) Implements Entidades.iLazy.ArmarLazy

    End Sub
End Class ' END CLASS DEFINITION clsAlmacenamiento



