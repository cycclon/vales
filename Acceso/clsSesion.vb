' Static Model


Imports Entidades.Acceso
Imports Excepciones.Acceso

Public Class clsSesion : Implements iSesion

    Private Shared xInstancia As clsSesion

    Protected xUsuario As Entidades.Acceso.iUsuario

    Private Sub New()

    End Sub

    Public Shared Function ObtenerInstancia() As clsSesion
        If xInstancia Is Nothing Then xInstancia = New clsSesion
        Return xInstancia
    End Function

    Public Sub Cerrar() Implements Entidades.Acceso.iSesion.Cerrar
        Me.xUsuario = Nothing
    End Sub

    Public Sub ComprobarPermisos(ByVal prPatente As Byte) Implements Entidades.Acceso.iSesion.ComprobarPermisos
        Dim xF As Boolean = False

        If Not Me.xUsuario Is Nothing Then

            For Each xx As iFamilia In Me.xUsuario.pdCredencial.pdFamilias
                For Each yy As iPatente In xx.pdPatentes
                    If yy.pdID = prPatente Then
                        xF = True
                        Exit For
                    End If
                    If xF Then Exit For
                Next
            Next
        End If

        If Not xF Then Throw New exPermisos
    End Sub

    Public Sub EstablecerContraseña(ByVal prUsername As String, ByVal prPassword As String, ByVal prPassword2 As String) Implements Entidades.Acceso.iSesion.EstablecerContraseña
        Try
            'COMPROBAR CONTRASEÑAS
            If prPassword <> prPassword2 Then Throw New exDuplicadoContraseña

            'MODIFICAR USUARIo
            Dim xU As clsUsuario = clsUsuario.Obtener(prUsername)
            xU.pdCredencial.pdPassword = Encriptacion.clsGestorEncriptacion.Encriptar(prPassword)
            xU.Modificar()

            'BITACORA
            Dim xB As New clsBUsuario(Entidades.Bitacoras.enTipoBitacora.ContraseñaEstablecida)
            xB.pdUsuarioGenerador = xU.pdCredencial.pdUsername
            xB.pdUsuario = xU
            xB.Registrar()

            'INICIAR SESIÓN
            Me.Ingresar(xU, prPassword)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Ingresar(ByVal prUsuario As Entidades.Acceso.iUsuario, ByVal prPassword As String) Implements Entidades.Acceso.iSesion.Ingresar
        Try
            If prUsuario.pdCredencial.pdPassword <> Encriptacion.clsGestorEncriptacion.Encriptar(prPassword) Then
                Dim xB As New clsBUsuario(Entidades.Bitacoras.enTipoBitacora.ContraseñaIncorrecta)
                xB.pdUsuarioGenerador = ""
                xB.pdUsuario = prUsuario
                xB.Registrar()
                Throw New exContraseñaIncorrecta
            Else
                Me.xUsuario = prUsuario
                Dim xB As New clsBUsuario(Entidades.Bitacoras.enTipoBitacora.InicioDeSesion)
                xB.pdUsuarioGenerador = Me.xUsuario.pdCredencial.pdUsername
                xB.pdUsuario = prUsuario
                xB.Registrar()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Iniciar(ByVal prTarjeta As List(Of Char))
        Try
            Dim xCodigo As String = "*"
            For Each xx As Char In prTarjeta
                xCodigo &= xx.ToString
            Next
            xCodigo &= "*"

            Dim xU As clsUsuario = clsUsuario.ObtenerPorTarjeta(xCodigo)
            If Not xU.pdID = 0 Then
                If xU.pdEstado = enEstadoUsuario.Inactivo Then
                    Dim xB As New clsBUsuario(Entidades.Bitacoras.enTipoBitacora.UsuarioInactivo)
                    xB.pdUsuarioGenerador = xU.pdCredencial.pdUsername
                    xB.pdUsuario = xU
                    xB.Registrar()
                    Throw New exUsuarioInactivo
                End If
                Me.xUsuario = xU
            Else
                Throw New exTarjetaInvalida
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function Iniciar(ByVal prUsername As String, ByVal prPassword As String) As Boolean Implements Entidades.Acceso.iSesion.Iniciar
        Try
            Dim xU As clsUsuario = clsUsuario.Obtener(prUsername)
            If xU.pdCredencial.pdUsername = "" Then
                Dim xB As New clsBUsuario(Entidades.Bitacoras.enTipoBitacora.UsuarioInexistente)
                xB.pdUsuarioGenerador = xU.pdCredencial.pdUsername
                xB.pdUsuario = xU
                xB.Registrar()
                Throw New exUsuarioInexistente
            End If
            If xU.pdEstado = enEstadoUsuario.Inactivo Then
                Dim xB As New clsBUsuario(Entidades.Bitacoras.enTipoBitacora.UsuarioInactivo)
                xB.pdUsuarioGenerador = xU.pdCredencial.pdUsername
                xB.pdUsuario = xU
                xB.Registrar()
                Throw New exUsuarioInactivo
            End If

            If xU.pdCredencial.pdPassword = "" Then
                Return False
            Else
                Ingresar(xU, prPassword)
                Return True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Property pdUsuario() As Entidades.Acceso.iUsuario Implements Entidades.Acceso.iSesion.pdUsuario
        Get
            Return Me.xUsuario
        End Get
        Set(ByVal value As Entidades.Acceso.iUsuario)
            Me.xUsuario = value
        End Set
    End Property

    Public Function UsuarioLogueado() As Boolean Implements Entidades.Acceso.iSesion.UsuarioLogueado
        If Me.xUsuario Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ValidarPermiso(ByVal prPatente As Byte) As Boolean Implements Entidades.Acceso.iSesion.ValidarPermiso
        Dim xF As Boolean = False

        If prPatente = 0 Then
            xF = True
        Else
            If Not Me.xUsuario Is Nothing Then

                For Each xx As iFamilia In Me.xUsuario.pdCredencial.pdFamilias
                    For Each yy As iPatente In xx.pdPatentes
                        If yy.pdID = prPatente Then
                            xF = True
                            Exit For
                        End If
                        If xF Then Exit For
                    Next
                Next
            End If
        End If

        Return xF
    End Function
End Class ' END CLASS DEFINITION clsSesion



