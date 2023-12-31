' Static Model


Imports Entidades.Acceso

Public Class clsCredencial : Implements iCredencial

    Protected xTarjetaAcceso As iTarjetaAcceso

    Protected xFamilias As List(Of Entidades.Acceso.iFamilia)

    Protected xUsername As String

    Protected xPassword As String

    Private xCredencial As Acceso.clsCredencial

    Protected xIDUsuario As Short

    Public Sub New(ByVal prIDUsuario As Short, ByVal prUsername As String, ByVal prPassword As String)
        Me.xUsername = prUsername
        Me.xPassword = prPassword
        Me.xIDUsuario = prIDUsuario
    End Sub

    Public Property pdIDUsuario() As Short
        Get
            Return Me.xIDUsuario
        End Get
        Set(ByVal value As Short)
            Me.xIDUsuario = value
        End Set
    End Property

    Public Property pdFamilias() As System.Collections.Generic.List(Of Entidades.Acceso.iFamilia) Implements Entidades.Acceso.iCredencial.pdFamilias
        Get
            Try
                Me.ArmarFull()
                Return Me.xCredencial.xFamilias
            Catch ex As Exception
                Throw
            End Try
        End Get
        Set(ByVal value As System.Collections.Generic.List(Of Entidades.Acceso.iFamilia))
            Try
                ArmarFull()
                Me.xCredencial.xFamilias = value
            Catch ex As Exception
                Throw
            End Try
        End Set
    End Property

    Public Property pdPassword() As String Implements Entidades.Acceso.iCredencial.pdPassword
        Get
            Return Me.xPassword
        End Get
        Set(ByVal value As String)
            Me.xPassword = value
        End Set
    End Property

    Public Property pdUsername() As String Implements Entidades.Acceso.iCredencial.pdUsername
        Get
            Return Me.xUsername
        End Get
        Set(ByVal value As String)
            Me.xUsername = value
        End Set
    End Property

    Public Sub ArmarFull() Implements Entidades.iLazy.ArmarFull
        Try
            If Me.xCredencial Is Nothing Then
                Me.xCredencial = New clsCredencial(Me.xIDUsuario, Me.xUsername, Me.xPassword)
                xCredencial.xFamilias = clsFamilia.Listar(Me.xIDUsuario)
                Me.xCredencial.xTarjetaAcceso = New clsTarjetaAcceso
                Me.xCredencial.xTarjetaAcceso.Obtener(Me.xIDUsuario)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow) Implements Entidades.iLazy.ArmarLazy

    End Sub

    Public ReadOnly Property pdTarjetaAcceso() As Entidades.Acceso.iTarjetaAcceso Implements Entidades.Acceso.iCredencial.pdTarjetaAcceso
        Get
            Try
                ArmarFull()
                Return Me.xCredencial.xTarjetaAcceso
            Catch ex As Exception
                Throw
            End Try
        End Get
    End Property

    Public Sub GenerarTarjeta() Implements Entidades.Acceso.iCredencial.GenerarTarjeta
        Try
            ArmarFull()
            Dim xT As New clsTarjetaAcceso
            xT.registrar(Me.xIDUsuario)
            Me.xCredencial.xTarjetaAcceso = xT
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class ' END CLASS DEFINITION clsCredencial



