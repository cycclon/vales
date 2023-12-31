' Static Model
Imports AccesoADatos.Mapeo.Cuentas
Imports ReglasNegocio.Vales
Imports Entidades.Vales
Imports ReglasNegocio.Clientes

Namespace Cuentas

    Public Class clsEgresoDescarga : Inherits clsMovimiento

        Protected xMovimiento As clsEgresoDescarga

        Protected xDescarga As iDescarga

        Protected xVale As iVale

        Public Property pdVale() As iVale
            Get
                Try
                    ArmarFull()
                    Return Me.xMovimiento.xVale
                Catch ex As Exception
                    Throw
                End Try
            End Get
            Set(ByVal value As iVale)
                Try
                    ArmarFull()
                    Me.xMovimiento.xVale = value
                Catch ex As Exception
                    Throw
                End Try
            End Set
        End Property

        Public Property pdDescarga() As iDescarga
            Get
                Try
                    ArmarFull()
                    Return Me.xMovimiento.xDescarga
                Catch ex As Exception
                    Throw
                End Try
            End Get
            Set(ByVal value As iDescarga)
                Try
                    ArmarFull()
                    Me.xMovimiento.xDescarga = value
                Catch ex As Exception
                    Throw
                End Try
            End Set
        End Property

        Public Overrides ReadOnly Property pdTipo() As Entidades.Cuentas.enTipoMovimiento
            Get
                Return Entidades.Cuentas.enTipoMovimiento.Egreso
            End Get
        End Property

        Public Overrides ReadOnly Property pdMonto() As Double
            Get
                Try
                    ArmarFull()
                    Return Me.xMovimiento.xDescarga.pdMonto
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public Overrides Sub ArmarFull()
            If Me.xMovimiento Is Nothing Then
                Me.xMovimiento = clsFabricaMovimientos.Fabricar(Entidades.Cuentas.enTipoMovimiento.Egreso)
                Me.xMovimiento.xDescarga = clsDescarga.ObtenerPorMovimiento(Me.xID)
                Me.xMovimiento.xVale = clsVale.ObtenerPorMovimiento(Me.xID)
                Me.xMovimiento.xCliente = clsCliente.Obtener(Me.xCliente.pdID)
            End If
        End Sub

        Public Overrides ReadOnly Property pdTipoVale() As Entidades.Vales.enTipoVale
            Get
                Try
                    ArmarFull()
                    Return Me.xMovimiento.xVale.pdTipo
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
            Try
                mMovimientos.RegistrarMovimientoVale(Me.xID, Me.pdVale.pdID)
            Catch ex As Exception
                Throw
            End Try
        End Sub
    End Class ' END CLASS DEFINITION clsEgresoDescarga

End Namespace ' ReglasNegocio.Cuentas

