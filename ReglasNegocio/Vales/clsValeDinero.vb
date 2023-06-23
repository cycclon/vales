Imports ReglasNegocio.Clientes
Namespace Vales
    Public Class clsValeDinero : Inherits clsVale

        Public Overrides Sub ArmarFull()
            Try
                MyBase.ArmarFull()
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Overrides ReadOnly Property pdTipo() As Entidades.Vales.enTipoVale
            Get
                Return Entidades.Vales.enTipoVale.Dinero
            End Get
        End Property

        Public Overrides ReadOnly Property pdIDCombustible() As Byte
            Get
                Return 0
            End Get
        End Property

        Public Overrides Function ToString() As String
            Try
                Return Me.pdID & " Vale por: " & Me.pdTipo.ToString & ": $" & Me.pdDisponible
            Catch ex As Exception
                Throw
            End Try
        End Function
    End Class
End Namespace

