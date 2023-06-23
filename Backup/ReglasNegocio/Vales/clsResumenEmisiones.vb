Imports Entidades.Vales
Imports AccesoADatos.Mapeo.Vales

Namespace Vales
    Public Class clsResumenEmisiones : Implements iResumenEmisiones

        Private xEmisiones As List(Of iSerie)

        Private Sub New()
            Me.xEmisiones = New List(Of iSerie)
        End Sub

        Private Sub New(ByVal prRegistro As DataSet)
            Me.New()
            Try
                For Each xx As DataRow In prRegistro.Tables(0).Rows
                    Dim xS As New clsSerie
                    xS.ArmarLazy(xx)
                    xEmisiones.Add(xS)
                Next
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public ReadOnly Property pdCombustibleEmitido() As Double Implements Entidades.Vales.iResumenEmisiones.pdCombustibleEmitido
            Get
                pdCombustibleEmitido = 0
                For Each xx As iSerie In xEmisiones
                    If xx.pdTipo = enTipoVale.Combustible Then pdCombustibleEmitido += xx.pdTotal
                Next
            End Get
        End Property

        Public ReadOnly Property pdDineroEmitido() As Double Implements Entidades.Vales.iResumenEmisiones.pdDineroEmitido
            Get
                pdDineroEmitido = 0
                For Each xx As iSerie In xEmisiones
                    If xx.pdTipo = enTipoVale.Dinero Then pdDineroEmitido += xx.pdTotal
                Next
            End Get
        End Property

        Public ReadOnly Property pdEmisiones() As System.Collections.Generic.List(Of Entidades.Vales.iSerie) Implements Entidades.Vales.iResumenEmisiones.pdEmisiones
            Get
                Return Me.xEmisiones
            End Get
        End Property

        Public Shared Function ObtenerHistorico() As iResumenEmisiones
            Try
                Dim objDS As DataSet = mResumenEmisiones.ObtenerHistorico
                ObtenerHistorico = New clsResumenEmisiones(objDS)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorMes(ByVal prAño As Integer, ByVal prMes As Integer) As iResumenEmisiones
            Try
                Dim objDS As DataSet = mResumenEmisiones.ObtenerPorMes(prAño, prMes)
                ObtenerPorMes = New clsResumenEmisiones(objDS)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorSemana(ByVal prAño As Integer, ByVal prSemana As Integer) As iResumenEmisiones
            Try
                Dim objDS As DataSet = mResumenEmisiones.ObtenerPorSemana(prAño, prSemana)
                ObtenerPorSemana = New clsResumenEmisiones(objDS)
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorAño(ByVal prAño As Integer) As iResumenEmisiones
            Try
                Dim objDS As DataSet = mResumenEmisiones.ObtenerPorAño(prAño)
                ObtenerPorAño = New clsResumenEmisiones(objDS)
            Catch ex As Exception
                Throw
            End Try
        End Function
    End Class
End Namespace

