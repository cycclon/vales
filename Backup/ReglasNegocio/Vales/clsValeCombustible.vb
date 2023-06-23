Imports Entidades.Combustibles
Imports ReglasNegocio.Clientes
Imports ReglasNegocio.Combustibles

Namespace Vales
    Public Class clsValeCombustible : Inherits clsVale

        Private xCombustible As iCombustible

        Private xValeC As clsValeCombustible

        Public Property pdCombustible() As iCombustible
            Get
                Try
                    ArmarFull()
                    Return Me.xValeC.xCombustible
                Catch ex As Exception
                    Throw
                End Try
            End Get
            Set(ByVal value As iCombustible)
                Try
                    ArmarFull()
                    Me.xValeC.xCombustible = value
                Catch ex As Exception
                    Throw
                End Try
            End Set
        End Property

        Public Overrides Sub ArmarFull()
            Try
                MyBase.ArmarFull()
                If Me.xValeC Is Nothing Then
                    Me.xValeC = clsFabricaVales.Fabricar(Me.pdTipo)
                    Me.xValeC.xCombustible = New clsCombustible
                    Me.xValeC.xCombustible.Obtener(Me.xID)
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Overrides ReadOnly Property pdTipo() As Entidades.Vales.enTipoVale
            Get
                Return Entidades.Vales.enTipoVale.Combustible
            End Get
        End Property

        Public Overrides ReadOnly Property pdIDCombustible() As Byte
            Get
                Try
                    ArmarFull()
                    Return Me.xValeC.xCombustible.pdID
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public Overrides Function ToString() As String
            Try
                Return Me.pdID & " Vale por: " & Me.pdTipo.ToString & " " & Me.pdCombustible.pdNombre & ": " & Me.pdDisponible & " lts."
            Catch ex As Exception
                Throw
            End Try
        End Function
    End Class
End Namespace

