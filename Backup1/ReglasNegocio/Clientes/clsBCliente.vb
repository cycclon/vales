' Static Model


Imports Bitacoras
Imports Entidades.Clientes
Namespace Clientes

    Public Class clsBCliente : Inherits clsBitacora
        Private xCliente As Entidades.Clientes.iCliente

        Public Sub New(ByVal prTipo As Entidades.Bitacoras.enTipoBitacora)
            Me.xTipo = prTipo
            Me.Inicializar()
        End Sub

        Public Property pdCliente() As iCliente
            Get
                Return Me.xCliente
            End Get

            Set(ByVal Value As iCliente)
                Me.xCliente = Value
            End Set
        End Property

        Public Overrides Function Mensaje() As String
            If Me.xCliente Is Nothing Then
                Return ""
            Else
                Return " Cliente: " & Me.xCliente.pdNombreCompleto & ". Estado: " & Me.xCliente.pdEstado.ToString
            End If
        End Function
    End Class ' END CLASS DEFINITION clsBCliente

End Namespace ' ReglasNegocio.Clientes

