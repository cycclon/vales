' Static Model


Imports Bitacoras
Imports Entidades.Vales

Namespace Vales

    Public Class clsBSerie : Inherits clsBitacora

        Public Sub New(ByVal prTipo As Entidades.Bitacoras.enTipoBitacora)
            Me.xTipo = prTipo
            Me.Inicializar()
        End Sub

        Protected xSerie As Entidades.Vales.iSerie

        Public Property pdSerie() As iSerie
            Get
                Return Me.xSerie
            End Get

            Set(ByVal Value As iSerie)
                Me.xSerie = Value
            End Set
        End Property

        Public Overrides Function Mensaje() As String
            If Me.xSerie Is Nothing Then
                Return ""
            Else
                Return " Cliente: " & Me.xSerie.pdCliente.pdNombreCompleto & ". Tipo: " & Me.xSerie.pdTipo.ToString & ". Total: " & Me.xSerie.pdTotal
            End If
        End Function
    End Class ' END CLASS DEFINITION clsBVale

End Namespace ' ReglasNegocio.Vales

