Imports Acceso
Namespace Navegacion
    Public Class clsFormulario

        Protected xFormulario As Windows.Forms.Form

        Protected xPatente As Byte

        Public Sub New(ByVal prFormulario As Windows.Forms.Form, ByVal prPatente As Byte)
            Me.xFormulario = prFormulario
            Me.xPatente = prPatente
        End Sub

        Public ReadOnly Property pdPatente() As Integer
            Get
                Return Me.xPatente
            End Get
        End Property

        Public ReadOnly Property pdForm() As Windows.Forms.Form
            Get
                Return Me.xFormulario
            End Get
        End Property

        Public Sub Show()
            Try
                CloseAllDataforms()
                If Me.xPatente <> 0 Then
                    Dim xSesion As clsSesion = clsSesion.ObtenerInstancia
                    xSesion.ComprobarPermisos(Me.xPatente)
                End If

                Me.xFormulario.Show()
            Catch ex As Exception
                Throw
            End Try
        End Sub

    End Class
End Namespace

