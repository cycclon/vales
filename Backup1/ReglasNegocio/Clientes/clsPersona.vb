' Static Model

Imports ReglasNegocio.Cuentas
Namespace Clientes

    Public Class clsPersona : Inherits clsCliente

        Protected xNombre As String

        Protected xApellido As String

        Public Property pdNombre() As String
            Get
                Return Me.xNombre
            End Get

            Set(ByVal Value As String)
                Me.xNombre = Value
            End Set
        End Property

        Public Property pdApellido() As String
            Get
                Return Me.xApellido
            End Get

            Set(ByVal Value As String)
                Me.xApellido = Value
            End Set
        End Property

        Public Overrides ReadOnly Property pdNombreCompleto() As String
            Get
                Return Me.xApellido & ", " & xNombre
            End Get
        End Property

        Public Overrides Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow)
            With prRegistro
                Me.xApellido = .Item("cli_apellido")
                Me.xEstadoEn = .Item("cli_estado")
                Me.xID = .Item("cli_id")
                Me.xNombre = .Item("cli_nombre")
                Me.xCuenta = New clsCuenta()
                xCuenta.ArmarLazy(prRegistro)
            End With
        End Sub

        Public Overrides ReadOnly Property pdTipo() As Entidades.Clientes.enTipoCliente
            Get
                Return Entidades.Clientes.enTipoCliente.Persona
            End Get
        End Property
    End Class ' END CLASS DEFINITION clsPersona

End Namespace ' ReglasNegocio.Clientes

