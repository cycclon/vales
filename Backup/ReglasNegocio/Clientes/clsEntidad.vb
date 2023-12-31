' Static Model
Imports ReglasNegocio.Cuentas
Namespace Clientes

    Public Class clsEntidad : Inherits clsCliente

        Private xRazonSocial As String

        Public Property pdRazonSocial() As String
            Get
                Return Me.xRazonSocial
            End Get

            Set(ByVal Value As String)
                Me.xRazonSocial = Value
            End Set
        End Property

        Public Overrides ReadOnly Property pdNombreCompleto() As String
            Get
                Return Me.xRazonSocial
            End Get
        End Property

        Public Overrides Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow)
            With prRegistro
                Me.xEstadoEn = .Item("cli_estado")
                Me.xID = .Item("cli_id")
                Me.xRazonSocial = .Item("cli_nombre")
                Me.xCuenta = New clsCuenta()
                xCuenta.ArmarLazy(prRegistro)
            End With
        End Sub

        Public Overrides ReadOnly Property pdTipo() As Entidades.Clientes.enTipoCliente
            Get
                Return Entidades.Clientes.enTipoCliente.Entidad
            End Get
        End Property

        
    End Class ' END CLASS DEFINITION clsEntidad

End Namespace ' ReglasNegocio.Clientes

