Imports Entidades.Vales
Namespace Turnos

    Public Interface iResumen
        ReadOnly Property pdDescargas() As List(Of iDescarga)

        ReadOnly Property pdCombustibleDescargado() As Double

        ReadOnly Property pdDineroDescargado() As Double
    End Interface ' END INTERFACE DEFINITION iResumen

End Namespace ' Entidades.Turnos

