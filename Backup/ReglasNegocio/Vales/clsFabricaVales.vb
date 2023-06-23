Imports Entidades.Vales
Namespace Vales
    Public Class clsFabricaVales
        Public Shared Function Fabricar(ByVal prTipoVale As entipovale) As clsVale
            Select Case prTipoVale
                Case enTipoVale.Combustible
                    Return New clsValeCombustible
                Case enTipoVale.Dinero
                    Return New clsValeDinero
                Case Else
                    Return New clsValeDinero
            End Select
        End Function
    End Class
End Namespace

