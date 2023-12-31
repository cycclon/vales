' Static Model

Imports AccesoADatos.Mapeo.Acceso
Imports Entidades.Acceso
Imports Excepciones.Acceso

Public MustInherit Class clsUsuario : Implements iUsuario

#Region "DATOS MIEMBRO"
    Protected xUsuario As Acceso.clsUsuario

    Protected xCredencial As Entidades.Acceso.iCredencial

    Protected xNombre As String

    Protected xID As Short

    Protected xApellido As String

    Private xEstado As clsEstado

    Protected xTipo As enTipoUsuario

    Protected xEstadoEn As enEstadoUsuario

    Protected xIDFamilias As List(Of Byte)
#End Region

#Region "CONSTRUCTORES"
    Public Sub New()
        Me.xCredencial = New clsCredencial(0, "", "")
        Me.xEstadoEn = enEstadoUsuario.Activo
    End Sub
#End Region

#Region "PROPIEDADES"
    Public Property pdApellido() As String Implements Entidades.Acceso.iUsuario.pdApellido
        Get
            Return Me.xApellido
        End Get
        Set(ByVal value As String)
            Me.xApellido = value
        End Set
    End Property

    Public Property pdCredencial() As Entidades.Acceso.iCredencial Implements Entidades.Acceso.iUsuario.pdCredencial
        Get
            Try
                ArmarFull()
                Return Me.xUsuario.xCredencial
            Catch ex As Exception
                Throw
            End Try
        End Get
        Set(ByVal value As Entidades.Acceso.iCredencial)
            Me.xUsuario.xCredencial = value
        End Set
    End Property

    Public Property pdID() As Short Implements Entidades.Acceso.iUsuario.pdID
        Get
            Return Me.xID
        End Get
        Set(ByVal value As Short)
            Me.xID = value
        End Set
    End Property

    Public Property pdNombre() As String Implements Entidades.Acceso.iUsuario.pdNombre
        Get
            Return Me.xNombre
        End Get
        Set(ByVal value As String)
            Me.xNombre = value
        End Set
    End Property

    Public MustOverride ReadOnly Property pdTipo() As Entidades.Acceso.enTipoUsuario Implements Entidades.Acceso.iUsuario.pdTipo

    Public ReadOnly Property pdEstado() As Entidades.Acceso.enEstadoUsuario Implements Entidades.Acceso.iUsuario.pdEstado
        Get
            Try
                Me.ArmarFull()
                Return Me.xUsuario.xEstado.pdEstado
            Catch ex As Exception
                Throw
            End Try
        End Get
    End Property

    Public ReadOnly Property pdUsername() As String Implements Entidades.Acceso.iUsuario.pdUsername
        Get
            Return Me.pdCredencial.pdUsername
        End Get
    End Property

    Public ReadOnly Property pdIDFamilias() As System.Collections.Generic.List(Of Byte) Implements Entidades.Acceso.iUsuario.pdIDFamilias
        Get
            Return Me.xIDFamilias
        End Get
    End Property

    Public ReadOnly Property pdNombreCompleto() As String Implements Entidades.Acceso.iUsuario.pdNombreCompleto
        Get
            Return Me.xApellido & ", " & Me.xNombre
        End Get
    End Property
#End Region

#Region "METODOS"
    Public Sub Activar() Implements Entidades.Acceso.iUsuario.Activar
        Try
            Me.xUsuario.xEstado.Activar(Me)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ActualizarContraseña(ByVal prContraseñaActual As String, ByVal prNuevaContraseña As String, ByVal prNuevaContraseña2 As String) Implements Entidades.Acceso.iUsuario.ActualizarContraseña
        Try
            If prNuevaContraseña <> prNuevaContraseña2 Then Throw New exDuplicadoContraseña
            If Me.pdCredencial.pdPassword <> Encriptacion.clsGestorEncriptacion.Encriptar(prContraseñaActual) Then Throw New exContraseñaIncorrecta
            Me.pdCredencial.pdPassword = Encriptacion.clsGestorEncriptacion.Encriptar(prNuevaContraseña)
            mUsuarios.Modificar(Me)
            'BITACORA
            Dim xB As New clsBUsuario(Entidades.Bitacoras.enTipoBitacora.ContraseñaCambiada)
            xB.pdUsuarioGenerador = Me.pdCredencial.pdUsername
            xB.pdUsuario = Me
            xB.Registrar()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Desactivar() Implements Entidades.Acceso.iUsuario.Desactivar
        Try
            Me.xUsuario.xEstado.Desactivar(Me)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Shared Function Listar(ByVal prEstado As Entidades.Acceso.enEstadoUsuario) As System.Collections.Generic.List(Of Entidades.Acceso.iUsuario)
        Try
            Dim xUsuarios As New List(Of iUsuario)
            Dim objDS As DataSet = mUsuarios.Listar(prEstado)

            For Each xx As DataRow In objDS.Tables(0).Rows
                Dim xU As clsUsuario = clsFabricaUsuarios.Fabricar(xx.Item("usr_tipo"))
                xU.ArmarLazy(xx)
                xUsuarios.Add(xU)
            Next

            Return xUsuarios
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub Modificar() Implements Entidades.Acceso.iUsuario.Modificar
        Try
            mUsuarios.Modificar(Me)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Shared Function Obtener(ByVal prNombre As String) As iUsuario
        Try
            Dim objDS As DataSet
            objDS = mUsuarios.Obtener(prNombre)
            Dim xU As clsUsuario

            If objDS.Tables(0).Rows.Count <> 0 Then
                xU = clsFabricaUsuarios.Fabricar(objDS.Tables(0).Rows(0).Item("usr_tipo"))
                xU.ArmarLazy(objDS.Tables(0).Rows(0))
            Else
                xU = clsFabricaUsuarios.Fabricar(enTipoUsuario.Empleado)
            End If

            Return xU
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub Registrar() Implements Entidades.Acceso.iUsuario.Registrar
        Try
            'COMPROBAR NOMBRE
            Dim xU As clsUsuario = clsUsuario.Obtener(Me.pdCredencial.pdUsername)
            If xU.pdCredencial.pdUsername <> "" Then Throw New exApodoEnUso

            'REGITRAR USUARIO
            mUsuarios.Registrar(Me)

            'BITACORA
            Dim xB As New clsBUsuario(Entidades.Bitacoras.enTipoBitacora.UsuarioRegistrado)
            xB.pdUsuario = xU
            Dim xSesion As clsSesion = clsSesion.ObtenerInstancia()
            xB.pdUsuarioGenerador = xSesion.pdUsuario.pdCredencial.pdUsername
            xB.Registrar()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ArmarFull() Implements Entidades.iLazy.ArmarFull
        Try
            If Me.xUsuario Is Nothing Then
                Me.xUsuario = clsFabricaUsuarios.Fabricar(Me.xTipo)
                With Me.xUsuario
                    .xEstado = clsFabricaEstados.Fabricar(Me.xEstadoEn)
                    .xCredencial = New clsCredencial(Me.xID, Me.xCredencial.pdUsername, Me.xCredencial.pdPassword)
                End With
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow) Implements Entidades.iLazy.ArmarLazy
        With prRegistro
            Me.xApellido = .Item("usr_apellido")
            Me.xCredencial.pdPassword = .Item("usr_password")
            Me.xCredencial.pdUsername = .Item("usr_username")
            Me.xID = .Item("usr_id")
            Me.xNombre = .Item("usr_nombre")
            Me.xTipo = .Item("usr_tipo")
            Me.xEstadoEn = .Item("usr_estado")
        End With
    End Sub

    Private Sub Cambiarestado(ByVal prNuevoEstado As clsEstado)
        Try
            ArmarFull()
            Me.xUsuario.xEstado = prNuevoEstado
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Shared Function ListarPorTurno(ByVal prTurno As Integer) As List(Of iUsuario)
        Try
            Dim objDS As DataSet = mUsuarios.ListarPorTurno(prTurno)
            Dim xUs As New List(Of iUsuario)
            Dim xComparer As New DynamicComparer.DynamicComparer(Of iUsuario)("pdNombreCompleto ASC")
            For Each xx As DataRow In objDS.Tables(0).Rows
                Dim xU As clsUsuario = clsFabricaUsuarios.Fabricar(xx.Item("usr_tipo"))
                xU.ArmarLazy(xx)
                xUs.Add(xU)
            Next
            xUs.Sort(AddressOf xComparer.Compare)

            Return xUs
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Shared Function ListarPorTipo(ByVal prTipo As enTipoUsuario) As List(Of iUsuario)
        Try
            Dim objDS As DataSet = mUsuarios.ListarPorTipo(prTipo)

            Dim xUs As New List(Of iUsuario)
            For Each xx As DataRow In objDS.Tables(0).Rows
                Dim xU As clsUsuario = clsFabricaUsuarios.Fabricar(xx.Item("usr_tipo"))
                xU.ArmarLazy(xx)
                xUs.Add(xU)
            Next

            Return xUs
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Overrides Function ToString() As String
        Return Me.pdNombreCompleto
    End Function

    Public Shared Function ObtenerPorDescarga(ByVal prDescarga As Long) As iUsuario
        Try
            Dim objDS As DataSet = mUsuarios.ObtenerPorDescarga(prDescarga)
            Dim xU As clsUsuario
            If objDS.Tables(0).Rows.Count <> 0 Then
                xU = clsFabricaUsuarios.Fabricar(objDS.Tables(0).Rows(0).Item("usr_tipo"))
                xU.ArmarLazy(objDS.Tables(0).Rows(0))
            Else
                xU = clsFabricaUsuarios.Fabricar(enTipoUsuario.Empleado)
            End If

            Return xU
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Shared Function ObtenerPorID(ByVal prID As Short) As iUsuario
        Try
            Dim objDS As DataSet = mUsuarios.ObtenerPorID(prID)
            Dim xU As clsUsuario
            If objDS.Tables(0).Rows.Count <> 0 Then
                xU = clsFabricaUsuarios.Fabricar(objDS.Tables(0).Rows(0).Item("usr_tipo"))
                xU.ArmarLazy(objDS.Tables(0).Rows(0))
            Else
                xU = clsFabricaUsuarios.Fabricar(enTipoUsuario.Empleado)
            End If

            Return xU
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ReestablecerContraseña() Implements Entidades.Acceso.iUsuario.ReestablecerContraseña
        Try
            Me.pdCredencial.pdPassword = ""
            mUsuarios.Modificar(Me)
            Dim xS As clsSesion = clsSesion.ObtenerInstancia
            Dim xB As New clsBUsuario(Entidades.Bitacoras.enTipoBitacora.ReestablecerContraseña)
            xB.pdUsuario = Me
            xB.pdUsuarioGenerador = xS.pdUsuario.pdUsername
            xB.Registrar()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Shared Function ObtenerPorTarjeta(ByVal prCodigo As String)
        Try
            Dim objDS As DataSet = mUsuarios.ObtenerPorTarjeta(prCodigo)
            Dim xU As clsUsuario
            If objDS.Tables(0).Rows.Count <> 0 Then
                xU = clsFabricaUsuarios.Fabricar(objDS.Tables(0).Rows(0).Item("usr_tipo"))
                xU.ArmarLazy(objDS.Tables(0).Rows(0))
            Else
                xU = clsFabricaUsuarios.Fabricar(enTipoUsuario.Empleado)
            End If

            Return xU
        Catch ex As Exception
            Throw
        End Try
    End Function
#End Region

#Region "Clases Anidadas"
    Private MustInherit Class clsEstado
        Public MustOverride ReadOnly Property pdEstado() As enEstadoUsuario

        Public MustOverride Sub Activar(ByVal prUsuario As clsUsuario)

        Public MustOverride Sub Desactivar(ByVal prUsuario As clsUsuario)
    End Class

    Private NotInheritable Class clsFabricaEstados
        Public Shared Function Fabricar(ByVal prEstado As enEstadoUsuario) As clsEstado
            Select Case prEstado
                Case enEstadoUsuario.Activo
                    Return New clsActivo
                Case enEstadoUsuario.Inactivo
                    Return New clsInactivo
                Case Else
                    Return New clsInactivo
            End Select
        End Function
    End Class

    Private Class clsActivo : Inherits clsEstado

        Public Overrides ReadOnly Property pdEstado() As Entidades.Acceso.enEstadoUsuario
            Get
                Return enEstadoUsuario.Activo
            End Get
        End Property

        Public Overrides Sub Activar(ByVal prUsuario As clsUsuario)
            Throw New exActivarActivado
        End Sub

        Public Overrides Sub Desactivar(ByVal prUsuario As clsUsuario)
            Try
                prUsuario.Cambiarestado(New clsInactivo)
                mUsuarios.Modificar(prUsuario)
            Catch ex As Exception
                Throw
            End Try
        End Sub
    End Class

    Private Class clsInactivo : Inherits clsEstado

        Public Overrides ReadOnly Property pdEstado() As Entidades.Acceso.enEstadoUsuario
            Get
                Return enEstadoUsuario.Inactivo
            End Get
        End Property

        Public Overrides Sub Activar(ByVal prUsuario As clsUsuario)
            Try
                prUsuario.Cambiarestado(New clsActivo)
                mUsuarios.Modificar(prUsuario)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Overrides Sub Desactivar(ByVal prUsuario As clsUsuario)
            Throw New exDesactivarDesactivado
        End Sub
    End Class
#End Region

    
End Class ' END CLASS DEFINITION clsUsuario



