' Static Model

Imports AccesoADatos.Mapeo.Cuentas
Imports Entidades.Cuentas
Imports Entidades.Vales
Imports Entidades.Combustibles
Imports ReglasNegocio.Combustibles
Imports ReglasNegocio.Vales

Namespace Cuentas

    Public Class clsCuenta : Implements iCuenta

        Protected xIDCliente As Short

        Protected xCuenta As clsCuenta

        Protected xMovimientos As List(Of iMovimiento)

        Public Property pdMovimientos() As System.Collections.Generic.List(Of Entidades.Cuentas.iMovimiento) Implements Entidades.Cuentas.iCuenta.pdMovimientos
            Get
                Try
                    ArmarFull()
                    Return Me.xCuenta.xMovimientos
                Catch ex As Exception
                    Throw
                End Try
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of Entidades.Cuentas.iMovimiento))
                Try
                    ArmarFull()
                    Me.xCuenta.xMovimientos = value
                Catch ex As Exception
                    Throw
                End Try
            End Set
        End Property

        Public ReadOnly Property pdSaldoCombustible() As Integer Implements Entidades.Cuentas.iCuenta.pdSaldoCombustible
            Get
                Try
                    ArmarFull()
                    Dim xContador As Integer = 0
                    For Each xx As iMovimiento In Me.xCuenta.xMovimientos
                        If xx.pdTipo = enTipoMovimiento.Ingreso Then
                            If xx.pdTipoVale = enTipoVale.Combustible Then
                                xContador += xx.pdMonto
                            End If
                        Else
                            If xx.pdTipoVale = enTipoVale.Combustible Then
                                xContador -= xx.pdMonto
                            End If
                        End If
                    Next

                    Return xContador
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public ReadOnly Property pdSaldoDinero() As Single Implements Entidades.Cuentas.iCuenta.pdSaldoDinero
            Get
                Try
                    ArmarFull()
                    Dim xContador As Integer = 0
                    For Each xx As iMovimiento In Me.xCuenta.xMovimientos
                        If xx.pdTipo = enTipoMovimiento.Ingreso Then
                            If xx.pdTipoVale = enTipoVale.Dinero Then
                                xContador += xx.pdMonto
                            End If
                        Else
                            If xx.pdTipoVale = enTipoVale.Dinero Then
                                xContador -= xx.pdMonto
                            End If
                        End If
                    Next

                    Return xContador
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public Function UltimosMovimientos() As System.Collections.Generic.List(Of Entidades.Cuentas.iMovimiento) Implements Entidades.Cuentas.iCuenta.UltimosMovimientos
            Try
                Dim xMs As New List(Of iMovimiento)
                If Me.xCuenta Is Nothing Then

                    Dim objDS As DataSet = mMovimientos.Listar(Me.xIDCliente, 10)

                    For Each xx As DataRow In objDS.Tables(0).Rows
                        Dim xM As iMovimiento = clsFabricaMovimientos.Fabricar(xx.Item("mov_tipo"))
                        xM.ArmarLazy(xx)
                        xMs.Add(xM)
                    Next
                Else
                    If xCuenta.xMovimientos.Count >= 10 Then
                        For i As Integer = 0 To 9
                            xMs.Add(xCuenta.xMovimientos(i))
                        Next
                    Else
                        For Each xx As iMovimiento In xCuenta.xMovimientos
                            xMs.Add(xx)
                        Next
                    End If
                End If

                Return xMs
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Sub ArmarFull() Implements Entidades.iLazy.ArmarFull
            Try
                If Me.xCuenta Is Nothing Then
                    Me.xCuenta = New clsCuenta
                    Me.xCuenta.xMovimientos = clsMovimiento.Listar(Me.xIDCliente)
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow) Implements Entidades.iLazy.ArmarLazy
            Me.xIDCliente = prRegistro.Item("cli_id")
        End Sub

        Public ReadOnly Property pdDetalleCombustibles() As System.Collections.Generic.List(Of Entidades.Cuentas.iDisponibilidadCombustible) Implements Entidades.Cuentas.iCuenta.pdDetalleCombustibles
            Get
                Try
                    Dim xDetalle As New List(Of iDisponibilidadCombustible)
                    Dim xCombustiblesActivos As List(Of iCombustible)
                    Dim xCombustiblesInactivos As List(Of iCombustible)

                    xCombustiblesActivos = clsCombustible.Listar(enEstadoCombustible.Activo)
                    xCombustiblesInactivos = clsCombustible.Listar(enEstadoCombustible.Inactivo)

                    For Each xx As iCombustible In xCombustiblesInactivos
                        xCombustiblesActivos.Add(xx)
                    Next

                    For Each xx As iCombustible In xCombustiblesActivos
                        xDetalle.Add(New clsDisponibilidadCombustible(xx, 0))
                    Next

                    ArmarFull()

                    For Each xx As iMovimiento In Me.xCuenta.xMovimientos
                        If xx.pdTipo = enTipoMovimiento.Ingreso Then
                            If xx.pdTipoVale = enTipoVale.Combustible Then
                                Dim xIngreso As clsIngreso = xx
                                Dim xVC As clsValeCombustible = xIngreso.pdSerie.pdVales(0)
                                For Each zz As iDisponibilidadCombustible In xDetalle
                                    If zz.pdCombustible.pdID = xVC.pdCombustible.pdID Then
                                        zz.pdCantidad += xx.pdMonto
                                        Exit For
                                    End If
                                Next
                            End If
                        Else
                            If xx.pdTipoVale = enTipoVale.Combustible Then
                                Dim xEgreso As clsEgresoDescarga = xx
                                Dim xVC As clsValeCombustible = xEgreso.pdVale
                                For Each zz As iDisponibilidadCombustible In xDetalle
                                    If zz.pdCombustible.pdID = xVC.pdCombustible.pdID Then
                                        zz.pdCantidad -= xx.pdMonto
                                        Exit For
                                    End If
                                Next
                            End If
                        End If
                    Next

                    Return xDetalle
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property
    End Class ' END CLASS DEFINITION clsCuenta

End Namespace ' ReglasNegocio.Cuentas

