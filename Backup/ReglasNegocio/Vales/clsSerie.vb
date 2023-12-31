' Static Model
Imports Entidades.Clientes
Imports Entidades.Combustibles
Imports AccesoADatos.Mapeo.Vales
Imports Entidades.Vales
Imports Entidades.Cuentas
Imports ReglasNegocio.Cuentas
Imports Acceso
Imports DynamicComparer

Namespace Vales

    Public Class clsSerie : Implements iSerie

        Protected xSerie As clsSerie
        Protected xVales As List(Of Entidades.Vales.iVale)
        Protected xID As Integer
        Protected xFechaEmision As Date
        Protected xTotal As Double
        Protected xTipo As enTipoVale
        Protected xCliente As String

        Public Sub New()
            Me.xVales = New List(Of iVale)
            Me.xID = 0
            Me.xFechaEmision = Date.Now
            Me.xTotal = 0
            Me.xTipo = enTipoVale.Dinero
            Me.xCliente = ""
        End Sub

        Public Sub New(ByVal prTotal As Integer, _
      ByVal prCliente As iCliente, _
      ByVal prDistribucion As iDistribucion, _
      ByVal prInicioVigencia As Date, _
      ByVal prVencimiento As Integer)
            Me.New()
            Try

                Me.xFechaEmision = Date.Now
                prDistribucion.ControlarTotal()
                Dim xV As New clsValeDinero
                With xV
                    .pdVencimiento = prInicioVigencia.AddDays(prVencimiento)
                    .pdCliente = prCliente
                End With
                Me.ArmarVales(xV, prDistribucion)

                mSeries.RegistrarSerie(Me, IngresoPorSerie)

                Dim xS As clsSesion = clsSesion.ObtenerInstancia
                Dim xB As New clsBSerie(Entidades.Bitacoras.enTipoBitacora.SerieEmitida)
                xB.pdUsuarioGenerador = xS.pdUsuario.pdUsername
                xB.pdSerie = Me
                xB.Registrar()
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Private Function IngresoPorSerie() As iMovimiento
            Dim xIngreso As New clsIngreso
            With xIngreso
                .pdFecha = Date.Now
                .pdSerie = Me
                .pdCliente = Me.pdCliente
            End With
            Return xIngreso
        End Function

        Public Sub New(ByVal prTotal As Integer, _
            ByVal prCliente As iCliente, _
            ByVal prDistribucion As iDistribucion, _
            ByVal prInicioVigencia As Date, _
            ByVal prVencimiento As Integer, _
            ByVal prCombustible As iCombustible)
            Me.New()
            Try
                Me.xFechaEmision = Date.Now
                Dim xV As New clsValeCombustible
                With xV
                    .pdVencimiento = prInicioVigencia.AddDays(prVencimiento)
                    .pdCliente = prCliente
                    .pdCombustible = prCombustible
                End With
                Me.ArmarVales(xV, prDistribucion)
                mSeries.RegistrarSerie(Me, IngresoPorSerie)

                Dim xS As clsSesion = clsSesion.ObtenerInstancia
                Dim xB As New clsBSerie(Entidades.Bitacoras.enTipoBitacora.SerieEmitida)
                xB.pdUsuarioGenerador = xS.pdUsuario.pdUsername
                xB.pdSerie = Me
                xB.Registrar()
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub ArmarFull() Implements Entidades.iLazy.ArmarFull
            Try
                If Me.xSerie Is Nothing Then
                    Me.xSerie = New clsSerie
                    Me.xSerie.xVales = clsVale.ListarPorSerie(Me.xID)
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow) Implements Entidades.iLazy.ArmarLazy
            With prRegistro
                Me.xID = .Item("ser_id")
                Me.xFechaEmision = .Item("ser_fecha_emision")

            End With
        End Sub

        Public ReadOnly Property pdCliente() As Entidades.Clientes.iCliente Implements Entidades.Vales.iSerie.pdCliente
            Get
                Try
                    Me.ArmarFull()
                    Return Me.xSerie.xVales(0).pdCliente
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public Property pdID() As Integer Implements Entidades.Vales.iSerie.pdID
            Get
                Return Me.xID
            End Get
            Set(ByVal value As Integer)
                Me.xID = value
            End Set
        End Property

        Public ReadOnly Property pdTipo() As Entidades.Vales.enTipoVale Implements Entidades.Vales.iSerie.pdTipo
            Get
                Try
                    Dim objDS As DataSet = mSeries.TipoSerie(Me.xID)
                    If objDS.Tables(0).Rows.Count > 0 Then
                        Me.xTotal = objDS.Tables(0).Rows(0).Item(0)
                    End If
                    Return Me.xTipo
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public ReadOnly Property pdTotal() As Double Implements Entidades.Vales.iSerie.pdTotal
            Get
                Try
                    Dim objDS As DataSet = mSeries.TotalSerie(Me.xID)
                    If objDS.Tables(0).Rows.Count > 0 Then
                        xTotal = objDS.Tables(0).Rows(0).Item(0)
                    End If

                    Return xTotal
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public Property pdVales() As System.Collections.Generic.List(Of Entidades.Vales.iVale) Implements Entidades.Vales.iSerie.pdVales
            Get
                Try
                    ArmarFull()
                    Return Me.xSerie.xVales
                Catch ex As Exception
                    Throw
                End Try
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of Entidades.Vales.iVale))
                Try
                    ArmarFull()
                    Me.xSerie.xVales = value
                Catch ex As Exception
                    Throw
                End Try
            End Set
        End Property

        Public Sub ObtenerPorMovimiento(ByVal prIDMovimiento As Long) Implements Entidades.Vales.iSerie.ObtenerPorMovimiento
            Try
                Dim objDS As DataSet = mSeries.ObtenerPorMovimiento(prIDMovimiento)

                If objDS.Tables(0).Rows.Count <> 0 Then
                    Me.ArmarLazy(objDS.Tables(0).Rows(0))
                End If

            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub ArmarVales(ByVal prValeModelo As iVale, ByVal prDistribucion As iDistribucion) Implements Entidades.Vales.iSerie.ArmarVales
            Try
                Dim xGestorClaves As clsGestorIDS = clsGestorIDS.ObtenerInstancia
                xGestorClaves.ActualizarClaves()
                xGestorClaves.GenerarIDs(prDistribucion.CantidadVales)
                For Each xx As iItemDistribucion In prDistribucion.pdItems
                    For i As Integer = 1 To xx.pdCantidad
                        Dim xV As iVale = clsFabricaVales.Fabricar(prValeModelo.pdTipo)
                        With xV
                            .pdCliente = prValeModelo.pdCliente
                            .pdValor = xx.pdValor
                            .pdVencimiento = prValeModelo.pdVencimiento
                            .pdID = xGestorClaves.ObtenerUnaClave
                        End With
                        If TypeOf xV Is clsValeCombustible Then
                            Dim xVC As New clsValeCombustible
                            Dim xVC2 As New clsValeCombustible
                            xVC = xV
                            xVC2 = prValeModelo
                            xVC.pdCombustible = xVC2.pdCombustible
                            Me.pdVales.Add(xVC)
                        Else
                            Me.pdVales.Add(xV)
                        End If
                    Next
                Next
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Property pdFechaEmision() As Date Implements Entidades.Vales.iSerie.pdFechaEmision
            Get
                Return Me.xFechaEmision
            End Get
            Set(ByVal value As Date)
                Me.xFechaEmision = value
            End Set
        End Property

        Public Shared Function Listar(ByVal prIDCliente As Integer) As List(Of iSerie)
            Try
                Dim xComparer As New DynamicComparer(Of iSerie)("pdFechaEmision DESC")
                Dim objDS As DataSet = mSeries.Listar(prIDCliente)
                Dim xSs As New List(Of iSerie)

                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xS As New clsSerie
                    xS.ArmarLazy(xx)
                    xSs.Add(xS)
                Next

                xSs.Sort(AddressOf xComparer.Compare)
                Return xSs
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public ReadOnly Property pdValePor() As String Implements Entidades.Vales.iSerie.pdValePor
            Get
                Try
                    If Me.pdTipo = enTipoVale.Combustible Then
                        Dim xVC As clsValeCombustible = Me.pdVales(0)
                        Return xVC.pdCombustible.pdNombre
                    Else
                        Return "Dinero"
                    End If
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public ReadOnly Property pdSaldoDisponible() As Double Implements Entidades.Vales.iSerie.pdSaldoDisponible
            Get
                Try
                    Dim xContador As Double = 0
                    For Each xx As iVale In Me.pdVales
                        If xx.pdEstado <> enEstadoVale.Descargado And xx.pdEstado <> enEstadoVale.Cancelado Then
                            xContador += xx.pdDisponible
                        End If
                    Next

                    Return xContador
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public ReadOnly Property pdVencimiento() As Date Implements Entidades.Vales.iSerie.pdVencimiento
            Get
                Try
                    Return Me.pdVales(0).pdVencimiento
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public ReadOnly Property pdValesDisponibles() As System.Collections.Generic.List(Of Entidades.Vales.iVale) Implements Entidades.Vales.iSerie.pdValesDisponibles
            Get
                Try
                    Dim xVs As New List(Of iVale)
                    For Each xx As iVale In Me.pdVales
                        If xx.pdEstado = enEstadoVale.Activo Then
                            xVs.Add(xx)
                        End If
                    Next
                    Return xVs
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public Sub ExtenderVencimiento(ByVal prDias As Short) Implements Entidades.Vales.iSerie.ExtenderVencimiento
            Try
                For Each xx As iVale In Me.pdVales
                    xx.ExtenderVencimiento(prDias)
                Next
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub Reportar() Implements Entidades.Vales.iSerie.Reportar
            Try
                For Each xx As iVale In Me.pdVales
                    xx.Reportar(Me.xID)
                Next
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public ReadOnly Property pdNombreCliente() As String Implements Entidades.Vales.iSerie.pdNombreCliente
            Get
                Try
                    Dim objDS As DataSet = mSeries.ClienteSerie(Me.xID)
                    If objDS.Tables(0).Rows.Count > 0 Then
                        Me.xCliente = objDS.Tables(0).Rows(0).Item("cli_nombre") & " " & objDS.Tables(0).Rows(0).Item("cli_apellido")
                    End If

                    Return Me.xCliente
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property
    End Class ' END CLASS DEFINITION clsSerie

End Namespace ' ReglasNegocio.Vales

