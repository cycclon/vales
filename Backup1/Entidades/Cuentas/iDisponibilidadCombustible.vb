Imports Entidades.Combustibles
Namespace Cuentas
    Public Interface iDisponibilidadCombustible

        ReadOnly Property pdCombustible() As icombustible

        Property pdCantidad() As Integer

        ReadOnly Property pdResumen() As String

    End Interface
End Namespace

