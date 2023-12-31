' Static Model
Imports Acceso
Imports Excepciones.Clientes
Imports Entidades.Clientes
Imports AccesoADatos.Mapeo.Clientes
Imports Entidades.Cuentas
Namespace Clientes

    Public MustInherit Class clsCliente : Implements iCliente

#Region "Datos Miembro"
        Protected xCliente As clsCliente

        Protected xCuenta As Entidades.Cuentas.iCuenta

        Protected xID As Integer

        Protected xEstadoEn As Entidades.Clientes.enEstadoCliente

        Protected xEstado As clsEstado

        Protected xTipo As enTipoCliente
#End Region

#Region "Propiedades"
        Public ReadOnly Property pdEstado() As Entidades.Clientes.enEstadoCliente Implements Entidades.Clientes.iCliente.pdEstado
            Get
                Try
                    ArmarFull()
                    Return Me.xCliente.xEstado.pdEstado
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public Property pdID() As Integer Implements Entidades.Clientes.iCliente.pdID
            Get
                Return Me.xID
            End Get
            Set(ByVal value As Integer)
                Me.xID = value
            End Set
        End Property

        Public Property pdCuenta() As iCuenta Implements Entidades.Clientes.iCliente.pdCuenta
            Get
                Return Me.xCuenta
            End Get
            Set(ByVal value As iCuenta)
                Me.xCuenta = value
            End Set
        End Property

        Public MustOverride ReadOnly Property pdNombreCompleto() As String Implements iCliente.pdNombreCompleto

        Public MustOverride ReadOnly Property pdTipo() As Entidades.Clientes.enTipoCliente Implements Entidades.Clientes.iCliente.pdTipo

#End Region

#Region "Métodos"
        Public Shared Function Obtener(ByVal prIDCliente As Short) As iCliente
            Try
                Dim xC As iCliente
                Dim objDS As DataSet = mClientes.Obtener(prIDCliente)

                If objDS.Tables(0).Rows.Count <> 0 Then
                    xC = clsFabricaClientes.Fabricar(objDS.Tables(0).Rows(0).Item("cli_tipo"))
                    xC.ArmarLazy(objDS.Tables(0).Rows(0))
                Else
                    xC = clsFabricaClientes.Fabricar(enTipoCliente.Persona)
                End If

                Return xC
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function Listar(ByVal prEstado As enEstadoCliente) As List(Of iCliente)
            Try
                Dim objDS As DataSet = mClientes.Listar(prEstado)
                Dim xClientes As New List(Of iCliente)
                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xC As clsCliente = clsFabricaClientes.Fabricar(xx.Item("cli_tipo"))
                    xC.ArmarLazy(xx)
                    xClientes.Add(xC)
                Next

                Return xClientes
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Sub Eliminar() Implements Entidades.Clientes.iCliente.Eliminar
            Try
                ArmarFull()
                Me.xCliente.xEstado.Eliminar(Me)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub Restaurar() Implements Entidades.Clientes.iCliente.Restaurar
            Try
                ArmarFull()
                Me.xCliente.xEstado.Restaurar(Me)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub ArmarFull() Implements Entidades.iLazy.ArmarFull
            Try
                If Me.xCliente Is Nothing Then
                    Me.xCliente = clsFabricaClientes.Fabricar(Me.xTipo)
                    Me.xCliente.xEstado = clsEstado.Fabricar(Me.xEstadoEn)
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public MustOverride Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow) Implements Entidades.iLazy.ArmarLazy

        Private Sub CambiarEstado(ByVal prNuevoEstado As clsEstado)
            Me.xCliente.xEstado = prNuevoEstado
        End Sub

        Public Sub Registrar() Implements Entidades.Clientes.iCliente.Registrar
            Try
                mClientes.Registrar(Me)
                Dim xS As clsSesion = clsSesion.ObtenerInstancia
                Dim xB As New clsBCliente(Entidades.Bitacoras.enTipoBitacora.ClienteRegistrado)
                xB.pdCliente = Me
                xB.pdUsuarioGenerador = xS.pdUsuario.pdUsername
                xB.Registrar()
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Overrides Function ToString() As String Implements Entidades.Clientes.iCliente.ToString
            Return Me.pdNombreCompleto
        End Function

        Public Shared Function Listar() As List(Of iCliente)
            Try
                Dim objDS As DataSet = mClientes.Listar
                Dim xCs As New List(Of iCliente)
                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xC As clsCliente = clsFabricaClientes.Fabricar(xx.Item("cli_tipo"))
                    xC.ArmarLazy(xx)
                    xCs.Add(xC)
                Next
                Return xCs
            Catch ex As Exception
                Throw
            End Try
        End Function

#End Region

#Region "Clases Anidadas"
        Protected MustInherit Class clsEstado

            Friend Shared Function Fabricar(ByVal prEstado As enEstadoCliente) As clsEstado
                Select Case prEstado
                    Case enEstadoCliente.Activo
                        Return New clsActivo
                    Case enEstadoCliente.Inactivo
                        Return New clsInactivo
                    Case Else
                        Return New clsInactivo
                End Select
            End Function

            Friend MustOverride Sub Eliminar(ByVal prCliente As clsCliente)

            Friend MustOverride Sub Restaurar(ByVal prCliente As clsCliente)

            Friend MustOverride ReadOnly Property pdEstado() As enEstadoCliente
        End Class

        Protected Class clsActivo : Inherits clsEstado

            Friend Overrides Sub Eliminar(ByVal prCliente As clsCliente)
                Try
                    prCliente.CambiarEstado(clsEstado.Fabricar(enEstadoCliente.Inactivo))
                    mClientes.Modificar(prCliente)
                    Dim xB As New clsBCliente(Entidades.Bitacoras.enTipoBitacora.ClienteEliminado)
                    Dim xS As clsSesion = clsSesion.ObtenerInstancia
                    xB.pdCliente = prCliente
                    xB.pdUsuarioGenerador = xS.pdUsuario.pdUsername
                    xB.Registrar()
                Catch ex As Exception
                    Throw
                End Try
            End Sub

            Friend Overrides Sub Restaurar(ByVal prCliente As clsCliente)
                Throw New exActivarActivado
            End Sub

            Friend Overrides ReadOnly Property pdEstado() As Entidades.Clientes.enEstadoCliente
                Get
                    Return enEstadoCliente.Activo
                End Get
            End Property
        End Class

        Protected Class clsInactivo : Inherits clsEstado

            Friend Overrides Sub Eliminar(ByVal prCliente As clsCliente)
                Throw New exDesactivarDesactivado
            End Sub

            Friend Overrides Sub Restaurar(ByVal prCliente As clsCliente)
                Try
                    prCliente.CambiarEstado(clsEstado.Fabricar(enEstadoCliente.Activo))
                    mClientes.Modificar(prCliente)
                    Dim xB As New clsBCliente(Entidades.Bitacoras.enTipoBitacora.ClienteRestaurado)
                    Dim xS As clsSesion = clsSesion.ObtenerInstancia
                    xB.pdCliente = prCliente
                    xB.pdUsuarioGenerador = xS.pdUsuario.pdUsername
                    xB.Registrar()
                Catch ex As Exception
                    Throw
                End Try
            End Sub

            Friend Overrides ReadOnly Property pdEstado() As Entidades.Clientes.enEstadoCliente
                Get
                    Return enEstadoCliente.Inactivo
                End Get
            End Property
        End Class
#End Region



    End Class ' END CLASS DEFINITION clsCliente

End Namespace ' ReglasNegocio.Clientes

