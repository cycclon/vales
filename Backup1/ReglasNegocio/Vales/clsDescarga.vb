Imports Entidades.Vales
Imports AccesoADatos.Mapeo.Vales
Imports Acceso

Namespace Vales
    Public Class clsDescarga : Implements iDescarga

        Private xID As Long

        Private xMonto As Single

        Private xFecha As Date

        Private xIDVale As String

        Public Property pdID() As Long Implements Entidades.Vales.iDescarga.pdID
            Get
                Return Me.xID
            End Get
            Set(ByVal value As Long)
                Me.xID = value
            End Set
        End Property

        Public Property pdFecha() As Date Implements Entidades.Vales.iDescarga.pdFecha
            Get
                Return Me.xFecha
            End Get
            Set(ByVal value As Date)
                Me.xFecha = value
            End Set
        End Property

        Public Property pdMonto() As Single Implements Entidades.Vales.iDescarga.pdMonto
            Get
                Return Me.xMonto
            End Get
            Set(ByVal value As Single)
                Me.xMonto = value
            End Set
        End Property

        Private Sub Armar(ByVal prRegistro As DataRow)
            With prRegistro
                Me.xIDVale = .Item("des_val_id")
                Me.xID = .Item("des_id")
                Me.xFecha = .Item("des_fecha")
                Me.xMonto = .Item("des_monto")
            End With
        End Sub

        Public Shared Function Listar(ByVal prVale As String) As List(Of iDescarga)
            Try
                Dim objDS As DataSet = mVales.ListarDescargas(prVale)
                Dim xDs As New List(Of iDescarga)
                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xD As New clsDescarga
                    xD.Armar(xx)
                    xDs.Add(xD)
                Next

                Return xDs
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorMovimiento(ByVal prMovimiento As Long) As iDescarga
            Try
                Dim objDS As DataSet = mVales.ObtenerDescargaPorMovimiento(prMovimiento)
                Dim xD As New clsDescarga
                If objDS.Tables(0).Rows.Count <> 0 Then
                    xD.Armar(objDS.Tables(0).Rows(0))
                End If

                Return xD
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Sub Registrar(ByVal prVale As String) Implements Entidades.Vales.iDescarga.Registrar
            Try
                Dim xS As clsSesion = clsSesion.ObtenerInstancia
                mVales.RegistrarDescarga(Me, prVale, xS.pdUsuario.pdID)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function ListarPorTurno(ByVal prTurno As Integer) As List(Of iDescarga)
            Try
                Dim objDS As DataSet = mVales.ListarDescargasPorTurno(prTurno)
                Dim xDs As New List(Of iDescarga)
                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xD As New clsDescarga
                    xD.Armar(xx)
                    xDs.Add(xD)
                Next

                Return xDs
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ListarHistorico() As List(Of iDescarga)
            Try
                Dim objDS As DataSet = mVales.ListarDescargasHistorico()
                Dim xDs As New List(Of iDescarga)
                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xD As New clsDescarga
                    xD.Armar(xx)
                    xDs.Add(xD)
                Next

                Return xDs
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ListarPorAño(ByVal prAño As Integer) As List(Of iDescarga)
            Try
                Dim objDS As DataSet = mVales.ListarDescargasAño(prAño)
                Dim xDs As New List(Of iDescarga)
                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xD As New clsDescarga
                    xD.Armar(xx)
                    xDs.Add(xD)
                Next

                Return xDs
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ListarPorMes(ByVal prAño As Integer, ByVal prMes As Integer) As List(Of iDescarga)
            Try
                Dim objDS As DataSet = mVales.ListarDescargasMes(prAño, prMes)
                Dim xDs As New List(Of iDescarga)
                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xD As New clsDescarga
                    xD.Armar(xx)
                    xDs.Add(xD)
                Next

                Return xDs
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ListarPorSemana(ByVal prAño As Integer, ByVal prSemana As Integer) As List(Of iDescarga)
            Try
                Dim objDS As DataSet = mVales.ListarDescargasSemana(prAño, prSemana)
                Dim xDs As New List(Of iDescarga)
                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xD As New clsDescarga
                    xD.Armar(xx)
                    xDs.Add(xD)
                Next

                Return xDs
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public ReadOnly Property pdUsuario() As String Implements Entidades.Vales.iDescarga.pdUsuario
            Get
                Try
                    Dim objUsuario As Acceso.clsUsuario = Acceso.clsUsuario.ObtenerPorDescarga(Me.xID)
                    Return objUsuario.pdNombreCompleto
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public ReadOnly Property pdTipoVale() As Entidades.Vales.enTipoVale Implements Entidades.Vales.iDescarga.pdTipoVale
            Get
                Try
                    Dim xVale As iVale = clsVale.ObtenerVale(Left(Right(Me.xIDVale, Me.xIDVale.Length - 1), Me.xIDVale.Length - 1))
                    Return xVale.pdTipo
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property
    End Class
End Namespace

