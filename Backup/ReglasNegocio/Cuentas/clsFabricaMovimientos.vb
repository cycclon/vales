Imports Entidades.Cuentas

Namespace Cuentas
    Public Class clsFabricaMovimientos
        Public Shared Function Fabricar(ByVal prTipo As enTipoMovimiento) As iMovimiento
            Select Case prTipo
                Case enTipoMovimiento.Egreso
                    Return New clsEgresoDescarga
                Case enTipoMovimiento.Ingreso
                    Return New clsIngreso
                Case Else
                    Return New clsEgresoDescarga
            End Select
        End Function
    End Class
End Namespace

