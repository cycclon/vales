' Static Model
Imports AccesoADatos.Mapeo.Vales
Imports ReglasNegocio.Clientes
Imports ReglasNegocio.Cuentas
Imports ReglasNegocio.Turnos
Imports Entidades.Clientes
Imports Excepciones.Vales
Imports Entidades.Vales
Imports Acceso

Namespace Vales

    Public MustInherit Class clsVale : Implements iVale


#Region "Datos Miembro"

        Protected xID As String

        Protected xTipo As enTipoVale

        Protected xValor As Single

        Protected xVencimiento As Date

        Protected xCliente As Entidades.Clientes.iCliente

        Protected xVale As clsVale

        Protected xEstado As clsEstado

        Protected xEstadoEn As enEstadoVale

        Protected xDescargas As List(Of iDescarga)

#End Region

#Region "Constructores"
        Public Sub New()
            Me.xCliente = New clsPersona
        End Sub
#End Region

#Region "Propiedades"

        Public Property pdDescargas() As System.Collections.Generic.List(Of Entidades.Vales.iDescarga) Implements Entidades.Vales.iVale.pdDescargas
            Get
                Try
                    ArmarFull()
                    Return Me.xVale.xDescargas
                Catch ex As Exception
                    Throw
                End Try
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of Entidades.Vales.iDescarga))
                Try
                    ArmarFull()
                    Me.xVale.xDescargas = value
                Catch ex As Exception
                    Throw
                End Try
            End Set
        End Property

        Public MustOverride ReadOnly Property pdIDCombustible() As Byte Implements Entidades.Vales.iVale.pdIDCombustible

        Public Property pdCliente() As Entidades.Clientes.iCliente Implements Entidades.Vales.iVale.pdCliente
            Get
                Try
                    ArmarFull()
                    Return Me.xVale.xCliente
                Catch ex As Exception
                    Throw
                End Try
            End Get
            Set(ByVal value As Entidades.Clientes.iCliente)
                Try
                    ArmarFull()
                    Me.xVale.xCliente = value
                Catch ex As Exception
                    Throw
                End Try
            End Set
        End Property

        Public Property pdID() As String Implements Entidades.Vales.iVale.pdID
            Get
                Return Me.xID
            End Get
            Set(ByVal value As String)
                Me.xID = value
            End Set
        End Property

        Public MustOverride ReadOnly Property pdTipo() As Entidades.Vales.enTipoVale Implements Entidades.Vales.iVale.pdTipo

        Public Property pdValor() As Single Implements Entidades.Vales.iVale.pdValor
            Get
                Return Me.xValor
            End Get
            Set(ByVal value As Single)
                Me.xValor = value
            End Set
        End Property

        Public Property pdVencimiento() As Date Implements Entidades.Vales.iVale.pdVencimiento
            Get
                Return Me.xVencimiento.Date
            End Get
            Set(ByVal value As Date)
                Me.xVencimiento = value.Date
            End Set
        End Property

        Public ReadOnly Property pdMontoDescargado() As Single Implements Entidades.Vales.iVale.pdMontoDescargado
            Get
                Try
                    ArmarFull()
                    Dim xContador As Single = 0
                    For Each xx As iDescarga In Me.xVale.xDescargas
                        xContador += xx.pdMonto
                    Next
                    Return xContador
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public ReadOnly Property pdEstado() As enEstadoVale Implements Entidades.Vales.iVale.pdEstado
            Get
                Try
                    ArmarFull()
                    Return Me.xVale.xEstado.pdEstado
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public ReadOnly Property pdDisponible() As Single Implements Entidades.Vales.iVale.pdDisponible
            Get
                Try
                    Return Me.xValor - Me.pdMontoDescargado
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property
#End Region

#Region "Métodos"
        Public Overridable Sub ArmarFull() Implements Entidades.iLazy.ArmarFull
            Try
                If Me.xVale Is Nothing Then
                    Me.xVale = clsFabricaVales.Fabricar(Me.xTipo)
                    Me.xVale.xCliente = New clsPersona
                    Me.xVale.xCliente = clsCliente.Obtener(Me.xCliente.pdID)
                    If Not ComprobarVencimiento() Then
                        Me.xVale.xEstado = clsEstado.Fabricar(Me.xEstadoEn)
                    End If
                    Me.xVale.xDescargas = clsDescarga.Listar(Me.xID)
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow) Implements Entidades.iLazy.ArmarLazy
            With prRegistro
                Me.xCliente.pdID = prRegistro.Item("val_cli_id")
                Me.xID = prRegistro.Item("val_id")
                Me.xTipo = prRegistro.Item("val_tipo")
                Me.xValor = prRegistro.Item("val_valor")
                Me.xVencimiento = prRegistro.Item("val_vencimiento")
                Me.xEstadoEn = prRegistro.Item("val_estado")
            End With
        End Sub

        Public Shared Function ListarPorSerie(ByVal prIDSerie As Long) As List(Of iVale)
            Try
                Dim objDS As DataSet = mVales.ListarPorSerie(prIDSerie)
                Dim xVs As New List(Of iVale)
                Dim xC As New DynamicComparer.DynamicComparer(Of iVale)("pdValor DESC, pdID ASC")
                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xV As clsVale = clsFabricaVales.Fabricar(xx.Item("val_tipo"))
                    xV.ArmarLazy(xx)
                    xVs.Add(xV)
                Next

                xVs.Sort(AddressOf xC.Compare)
                Return xVs
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorMovimiento(ByVal prIDMovimiento As Long) As iVale
            Try
                Dim xV As clsVale
                Dim objDS As DataSet = mVales.ObtenerPorMovimiento(prIDMovimiento)
                If objDS.Tables(0).Rows.Count <> 0 Then
                    xV = clsFabricaVales.Fabricar(objDS.Tables(0).Rows(0).Item("val_tipo"))
                    xV.ArmarLazy(objDS.Tables(0).Rows(0))
                Else
                    xV = clsFabricaVales.Fabricar(enTipoVale.Dinero)
                End If

                Return xV
            Catch ex As Exception
                Throw
            End Try
        End Function

        Protected Function ComprobarVencimiento() As Boolean
            If Me.xVencimiento.Date < Date.Now.Date Then
                Me.xVale.xEstado = New clsVencido
                Return True
            Else
                Return False
            End If
        End Function

        Protected Sub CambiarEstado(ByVal prNuevoEstado As clsEstado)
            Try
                ArmarFull()
                Me.xVale.xEstado = prNuevoEstado
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function ObtenerVale(ByVal prID As String) As iVale
            Try
                Dim objDS As DataSet = mVales.Obtener("*" & prID & "*")
                Dim xVale As iVale
                If objDS.Tables(0).Rows.Count <> 0 Then
                    xVale = clsFabricaVales.Fabricar(objDS.Tables(0).Rows(0).Item("val_tipo"))
                    xVale.ArmarLazy(objDS.Tables(0).Rows(0))
                Else
                    xVale = New clsValeDinero
                End If

                Return xVale
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Sub Descargar(ByVal prMonto As Single) Implements iVale.Descargar
            Try
                Me.xVale.xEstado.Descargar(Me, prMonto)
                If prMonto < Me.xValor And pdDisponible > 0 Then RaiseEvent DescargaParcial()
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub ExtenderVencimiento(ByVal prDias As Short) Implements Entidades.Vales.iVale.ExtenderVencimiento
            Try
                ArmarFull()
                If Me.xVale.xEstado.pdEstado = enEstadoVale.Vencido Then Me.CambiarEstado(clsEstado.Fabricar(enEstadoVale.Activo))
                Me.xVencimiento = Me.xVencimiento.AddDays(prDias)
                mVales.Modificar(Me)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub Reportar(ByVal prSerie As Integer) Implements Entidades.Vales.iVale.Reportar
            Try
                ArmarFull()
                Me.xVale.xEstado.Reportar(Me, prSerie)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub Registrar(ByVal prSerie As Integer) Implements Entidades.Vales.iVale.Registrar
            Try
                mVales.Registrar(Me, prSerie)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public MustOverride Shadows Function ToString() As String Implements Entidades.Vales.iVale.ToString

        Public Sub Cancelar(prSerie As Integer) Implements iVale.Cancelar
            Try
                Me.xVale.xEstado.Cancelar(Me, prSerie)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub Restaurar(prSerie As Integer) Implements iVale.Restaurar
            Try
                Me.xVale.xEstado.Restaurar(Me, prSerie)
            Catch ex As Exception
                Throw
            End Try
        End Sub

#End Region

#Region "Clases Anidadas"
        Protected MustInherit Class clsEstado
            'Public MustOverride Sub ExtenderVencimiento(ByVal prVale As iVale, ByVal prDias As Short)

            Public MustOverride Sub Reportar(ByVal prVale As clsVale, ByVal prSerie As Integer)

            Public MustOverride Sub Cancelar(prVale As clsVale, prSerie As Integer)

            Public MustOverride Sub Restaurar(prVale As clsVale, prSerie As Integer)

            Public MustOverride ReadOnly Property pdEstado() As enEstadoVale

            Public MustOverride Sub Descargar(ByVal prVale As clsVale, ByVal prMonto As Single)

            Public Shared Function Fabricar(ByVal prEstado As enEstadoVale) As clsEstado
                Select Case prEstado
                    Case enEstadoVale.Activo
                        Return New clsActivo
                    Case enEstadoVale.Cancelado
                        Return New clsCancelado
                    Case enEstadoVale.Vencido
                        Return New clsVencido
                    Case enEstadoVale.Descargado
                        Return New clsDescargado
                    Case Else
                        Return New clsActivo
                End Select
            End Function
        End Class

        Protected Class clsActivo : Inherits clsEstado

            Public Overrides ReadOnly Property pdEstado() As enEstadoVale
                Get
                    Return enEstadoVale.Activo
                End Get
            End Property

            Public Overrides Sub Descargar(ByVal prVale As clsVale, ByVal prMonto As Single)
                Try
                    Dim xS As clsSesion = clsSesion.ObtenerInstancia

                    'COMPROBAR SI EL MONTO DESCARGADO NO SUPERA EL VALOR DEL VALE
                    If prMonto > prVale.pdDisponible Then
                        Throw New exMontoMayorAValor
                    End If

                    Dim xDia As New clsDiaTrabajo(Date.Now.Date)

                    'NUEVA DESCARGA
                    Dim xD As New clsDescarga
                    xD.pdMonto = prMonto
                    xD.pdFecha = Date.Now
                    xD.Registrar(prVale.pdID)
                    prVale.pdDescargas.Add(xD)

                    'ASOCIAR DESCARGA AL TURNO ACTUAL
                    xDia.TurnoActual.AgregarDescarga(xD)

                    If prVale.pdDisponible = 0 Then
                        'MODIFICAR VALE
                        prVale.CambiarEstado(clsEstado.Fabricar(enEstadoVale.Descargado))
                        mVales.Modificar(prVale)
                    End If

                    'REGRISTRAR EGRESO
                    Dim xE As New clsEgresoDescarga
                    With xE
                        .pdCliente = prVale.pdCliente
                        .pdFecha = Date.Now
                        .pdVale = prVale
                        .Registrar()
                    End With

                    'BITACORA
                    Dim xBVale As New clsBVale(Entidades.Bitacoras.enTipoBitacora.DescargaEfectuada)
                    xBVale.pdUsuarioGenerador = xS.pdUsuario.pdUsername
                    xBVale.pdVale = prVale
                    xBVale.Registrar()
                Catch ex As Exception
                    Throw
                End Try
            End Sub

            Public Overrides Sub Reportar(ByVal prVale As clsVale, ByVal prSerie As Integer)
                Try
                    prVale.CambiarEstado(clsEstado.Fabricar(enEstadoVale.Cancelado))
                    mVales.Modificar(prVale)
                    'REGISTRAR NUEVO VALE
                    Dim xV As clsVale = prVale
                    'OBTENER NUEVO ID
                    Dim xG As clsGestorIDS = clsGestorIDS.ObtenerInstancia()
                    xG.GenerarIDs(1)
                    xV.pdID = xG.ObtenerUnaClave
                    xV.CambiarEstado(clsEstado.Fabricar(enEstadoVale.Activo))
                    xV.Registrar(prSerie)
                Catch ex As Exception
                    Throw
                End Try
            End Sub

            Public Overrides Sub Cancelar(prVale As clsVale, prSerie As Integer)
                Try
                    prVale.CambiarEstado(clsEstado.Fabricar(enEstadoVale.Cancelado))
                    mVales.Modificar(prVale)
                Catch ex As Exception
                    Throw
                End Try
            End Sub

            Public Overrides Sub Restaurar(prVale As clsVale, prSerie As Integer)
                Throw New exRestaurarActivo
            End Sub
        End Class

        Protected Class clsVencido : Inherits clsEstado

            Public Overrides ReadOnly Property pdEstado() As enEstadoVale
                Get
                    Return enEstadoVale.Vencido
                End Get
            End Property

            Public Overrides Sub Descargar(ByVal prVale As clsVale, ByVal prMonto As Single)
                Try
                    'BITACORA
                    Dim xS As clsSesion = clsSesion.ObtenerInstancia
                    Dim xBVale As New clsBVale(Entidades.Bitacoras.enTipoBitacora.DescargarValeVencido)
                    xBVale.pdUsuarioGenerador = xS.pdUsuario.pdUsername
                    xBVale.pdVale = prVale
                    xBVale.Registrar()

                    Throw New exDescargarVencido
                Catch ex As Exception
                    Throw
                End Try
            End Sub

            Public Overrides Sub Reportar(ByVal prVale As clsVale, ByVal prSerie As Integer)

            End Sub

            Public Overrides Sub Cancelar(prVale As clsVale, prSerie As Integer)
                prVale.CambiarEstado(clsEstado.Fabricar(enEstadoVale.Cancelado))
                mVales.Modificar(prVale)
            End Sub

            Public Overrides Sub Restaurar(prVale As clsVale, prSerie As Integer)
                prVale.CambiarEstado(clsEstado.Fabricar(enEstadoVale.Activo))
                mVales.Modificar(prVale)
            End Sub
        End Class

        Protected Class clsCancelado : Inherits clsEstado

            Public Overrides ReadOnly Property pdEstado() As enEstadoVale
                Get
                    Return enEstadoVale.Cancelado
                End Get
            End Property

            Public Overrides Sub Descargar(ByVal prVale As clsVale, ByVal prMonto As Single)
                Try
                    'BITACORA
                    Dim xS As clsSesion = clsSesion.ObtenerInstancia
                    Dim xBVale As New clsBVale(Entidades.Bitacoras.enTipoBitacora.DescargarValeReportado)
                    xBVale.pdUsuarioGenerador = xS.pdUsuario.pdUsername
                    xBVale.pdVale = prVale
                    xBVale.Registrar()

                    Throw New exDescargarCancelado
                Catch ex As Exception
                    Throw
                End Try
            End Sub

            Public Overrides Sub Reportar(ByVal prVale As clsVale, ByVal prSerie As Integer)

            End Sub

            Public Overrides Sub Cancelar(prVale As clsVale, prSerie As Integer)
                Throw New exCancelarCancelado
            End Sub

            Public Overrides Sub Restaurar(prVale As clsVale, prSerie As Integer)
                Try
                    prVale.CambiarEstado(clsEstado.Fabricar(enEstadoVale.Activo))
                    mVales.Modificar(prVale)
                Catch ex As Exception
                    Throw
                End Try
            End Sub
        End Class

        'AGREGAR CLASE DESCARGADO
        Private Class clsDescargado : Inherits clsEstado

            Public Overrides Sub Descargar(ByVal prVale As clsVale, ByVal prMonto As Single)
                Try
                    'BITACORA
                    Dim xS As clsSesion = clsSesion.ObtenerInstancia
                    Dim xBVale As New clsBVale(Entidades.Bitacoras.enTipoBitacora.DescargarValeDescargado)
                    xBVale.pdUsuarioGenerador = xS.pdUsuario.pdUsername
                    xBVale.pdVale = prVale
                    xBVale.Registrar()

                    Throw New exDescargarDescargado
                Catch ex As Exception
                    Throw
                End Try
            End Sub

            Public Overrides ReadOnly Property pdEstado() As Entidades.Vales.enEstadoVale
                Get
                    Return enEstadoVale.Descargado
                End Get
            End Property

            Public Overrides Sub Reportar(ByVal prVale As clsVale, ByVal prSerie As Integer)

            End Sub

            Public Overrides Sub Cancelar(prVale As clsVale, prSerie As Integer)

            End Sub

            Public Overrides Sub Restaurar(prVale As clsVale, prSerie As Integer)

            End Sub
        End Class
#End Region

        Public Event DescargaParcial() Implements Entidades.Vales.iVale.DescargaParcial


    End Class ' END CLASS DEFINITION clsVale

End Namespace ' ReglasNegocio.Vales

