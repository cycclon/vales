
Imports Entidades.Clientes

Namespace Vales

    Public Interface iVale : Inherits iLazy

        Property pdDescargas() As List(Of iDescarga)

        Property pdID() As String

        ReadOnly Property pdTipo() As enTipoVale

        Property pdValor() As Single

        Property pdVencimiento() As Date

        Property pdCliente() As iCliente

        ReadOnly Property pdDisponible() As Single

        ReadOnly Property pdMontoDescargado() As Single

        ReadOnly Property pdEstado() As enEstadoVale

        ReadOnly Property pdIDCombustible() As Byte

        Sub Descargar(ByVal prMonto As Single)

        Sub ExtenderVencimiento(ByVal prDias As Short)

        Sub Reportar(ByVal prSerie As Integer)

        Sub Registrar(ByVal prSerie As Integer)

        Sub Cancelar(prSerie As Integer)

        Sub Restaurar(prSerie As Integer)

        Event DescargaParcial()

        Function ToString() As String

    End Interface ' END INTERFACE DEFINITION iVale

End Namespace ' Entidades.Vales

