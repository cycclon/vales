' Static Model

Imports AccesoADatos.Mapeo.Cuentas
Imports Entidades.Cuentas
Imports Entidades.Clientes
Imports ReglasNegocio.Clientes

Namespace Cuentas

    Public MustInherit Class clsMovimiento : Implements iMovimiento


#Region "Datos Miembro"

        Protected xID As Long

        Protected xFecha As Date

        Protected xTipo As Entidades.Cuentas.enTipoMovimiento

        Protected xCliente As iCliente
#End Region

        Public Sub New()
            Me.xCliente = New clsPersona
        End Sub

#Region "Propiedades"
        Public Property pdID() As Long Implements Entidades.Cuentas.iMovimiento.pdID
            Get
                Return Me.xID
            End Get
            Set(ByVal value As Long)
                Me.xID = value
            End Set
        End Property

        Public MustOverride ReadOnly Property pdTipo() As Entidades.Cuentas.enTipoMovimiento Implements Entidades.Cuentas.iMovimiento.pdTipo

        Public Property pdFecha() As Date Implements iMovimiento.pdFecha
            Get
                Return Me.xFecha
            End Get
            Set(ByVal value As Date)
                Me.xFecha = value
            End Set
        End Property

        Public MustOverride ReadOnly Property pdMonto() As Double Implements iMovimiento.pdMonto

        Public MustOverride ReadOnly Property pdTipoVale() As Entidades.Vales.enTipoVale Implements Entidades.Cuentas.iMovimiento.pdTipoVale

        Public MustOverride Property pdCliente() As Entidades.Clientes.iCliente Implements Entidades.Cuentas.iMovimiento.pdCliente

#End Region

#Region "Métodos"

        Public Shared Function Listar(ByVal prIDCliente As Short) As List(Of iMovimiento)
            Try
                Dim xMovimientos As New List(Of iMovimiento)
                Dim objDS As DataSet = mMovimientos.Listar(prIDCliente)

                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xM As clsMovimiento = clsFabricaMovimientos.Fabricar(xx.Item("mov_tipo"))
                    xM.ArmarLazy(xx)
                    xMovimientos.Add(xM)
                Next

                Return xMovimientos
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public MustOverride Sub ArmarFull() Implements Entidades.iLazy.ArmarFull

        Public Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow) Implements Entidades.iLazy.ArmarLazy
            With prRegistro
                Me.xID = .Item("mov_id")
                Me.xFecha = .Item("mov_fecha")
                Me.xTipo = .Item("mov_tipo")
                Me.xCliente.pdID = .Item("mov_cli_id")
            End With
        End Sub

        Public Sub Registrar()
            Try
                mMovimientos.Registrar(Me)
                Me.RegistrarRelacion()
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Protected MustOverride Sub RegistrarRelacion() Implements iMovimiento.RegistrarRelacion
#End Region

#Region "Clases Anidadas"

#End Region




    End Class ' END CLASS DEFINITION clsMovimiento

End Namespace ' ReglasNegocio.Cuentas

