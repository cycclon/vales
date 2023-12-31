' Static Model


Imports Bitacoras
Imports Entidades.Vales

Namespace Vales

    Public Class clsBVale : Inherits clsBitacora

        Protected xVale As Entidades.Vales.iVale

        Public Sub New(ByVal prTipo As Entidades.Bitacoras.enTipoBitacora)
            Me.xTipo = prTipo
            Me.Inicializar()
        End Sub

        Public Property pdVale() As iVale
            Get
                Return Me.xVale
            End Get

            Set(ByVal Value As iVale)
                Me.xVale = Value
            End Set
        End Property

        Public Overrides Function Mensaje() As String
            If Me.xVale Is Nothing Then
                Return ""
            Else
                Return "Vale: " & xVale.pdID & " - Cliente: " & Me.xVale.pdCliente.pdNombreCompleto & ". Tipo: " & Me.xVale.pdTipo.ToString & ". Monto: " & Me.xVale.pdValor & ". Vto: " & Me.xVale.pdVencimiento & ". Monto disponible: " & Me.xVale.pdDisponible
            End If
        End Function
    End Class ' END CLASS DEFINITION clsBVale

End Namespace ' ReglasNegocio.Vales

