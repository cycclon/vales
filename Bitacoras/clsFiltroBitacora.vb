' Static Model


Imports Entidades.Bitacoras
Public MustInherit Class clsFiltroBitacora : Implements iFiltroBitacora

    Public MustOverride Function Filtrar(ByVal prBitacora As Entidades.Bitacoras.iBitacora) As Boolean Implements Entidades.Bitacoras.iFiltroBitacora.Filtrar

End Class
