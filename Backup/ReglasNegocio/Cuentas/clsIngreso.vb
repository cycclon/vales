' Static Model

Imports ReglasNegocio.Vales
Imports Entidades.Vales
Imports ReglasNegocio.Clientes

Namespace Cuentas

    Public Class clsIngreso : Inherits clsMovimiento

        Protected xMovimiento As clsIngreso

        Protected xSerie As Entidades.Vales.iSerie

        Public Property pdSerie() As iSerie
            Get
                Try
                    ArmarFull()
                    Return Me.xMovimiento.xSerie
                Catch ex As Exception
                    Throw
                End Try
            End Get
            Set(ByVal value As iSerie)
                Try
                    ArmarFull()
                    Me.xMovimiento.xSerie = value
                Catch ex As Exception
                    Throw
                End Try
            End Set
        End Property

        Public Overrides ReadOnly Property pdTipo() As Entidades.Cuentas.enTipoMovimiento
            Get
                Return Entidades.Cuentas.enTipoMovimiento.Ingreso
            End Get
        End Property

        Public Overrides ReadOnly Property pdMonto() As Double
            Get
                Try
                    ArmarFull()
                    Return Me.xMovimiento.xSerie.pdTotal
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public Overrides Sub ArmarFull()
            If Me.xMovimiento Is Nothing Then
                Me.xMovimiento = clsFabricaMovimientos.Fabricar(Entidades.Cuentas.enTipoMovimiento.Ingreso)
                Me.xMovimiento.xSerie = New clsSerie
                Me.xMovimiento.xSerie.ObtenerPorMovimiento(Me.xID)
                Me.xMovimiento.xCliente = clsCliente.Obtener(Me.xCliente.pdID)
            End If
        End Sub

        Public Overrides ReadOnly Property pdTipoVale() As Entidades.Vales.enTipoVale
            Get
                Try
                    ArmarFull()
                    Return Me.xMovimiento.xSerie.pdTipo
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public Overrides Property pdCliente() As Entidades.Clientes.iCliente
            Get
                Try
                    ArmarFull()
                    Return Me.xMovimiento.xCliente
                Catch ex As Exception
                    Throw
                End Try
            End Get
            Set(ByVal value As Entidades.Clientes.iCliente)
                Try
                    ArmarFull()
                    Me.xMovimiento.xCliente = value
                Catch ex As Exception
                    Throw
                End Try
            End Set
        End Property

        Protected Overrides Sub RegistrarRelacion()
            'COMPORTAMIENTO ESTABLECIDO EN CAPA DE MAPEO
        End Sub
    End Class ' END CLASS DEFINITION clsIngreso

End Namespace ' ReglasNegocio.Cuentas

