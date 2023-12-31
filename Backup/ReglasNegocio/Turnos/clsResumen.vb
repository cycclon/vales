' Static Model


Imports Entidades.Turnos
Imports Entidades.Vales
Namespace Turnos

    Public Class clsResumen : Implements iResumen

        Protected xDescargas As List(Of Entidades.Vales.iDescarga)

        Private Sub New()
            Me.xDescargas = New List(Of iDescarga)
        End Sub

        Public ReadOnly Property pdDescargas() As System.Collections.Generic.List(Of Entidades.Vales.iDescarga) Implements Entidades.Turnos.iResumen.pdDescargas
            Get
                Try
                    Return Me.xDescargas
                Catch ex As Exception
                    Throw
                End Try
            End Get
        End Property

        Public Shared Function ObtenerHistorico() As iResumen
            Try
                Dim xR As New clsResumen
                xR.xDescargas = Vales.clsDescarga.ListarHistorico
                Return xR
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorAño(ByVal prAño As Integer) As iResumen
            Try
                Dim xR As New clsResumen
                xR.xDescargas = Vales.clsDescarga.ListarPorAño(prAño)
                Return xR
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorMes(ByVal prAño As Integer, ByVal prMes As Integer) As iResumen
            Try
                Dim xR As New clsResumen
                xR.xDescargas = Vales.clsDescarga.ListarPorMes(prAño, prMes)
                Return xR
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorSemana(ByVal prAño As Integer, ByVal prSemana As Integer) As iResumen
            Try
                Dim xR As New clsResumen
                xR.xDescargas = Vales.clsDescarga.ListarPorSemana(prAño, prSemana)
                Return xR
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Shared Function ObtenerPorTurno(ByVal prTurno As Integer) As iResumen
            Try
                Dim xR As New clsResumen
                xR.xDescargas = Vales.clsDescarga.ListarPorTurno(prTurno)
                Return xR
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public ReadOnly Property pdCombustibleDescargado() As Double Implements Entidades.Turnos.iResumen.pdCombustibleDescargado
            Get
                Dim xContador As Double = 0
                For Each xx As iDescarga In Me.pdDescargas
                    If xx.pdTipoVale = enTipoVale.Combustible Then
                        xContador += xx.pdMonto
                    End If
                Next
                Return xContador
            End Get
        End Property

        Public ReadOnly Property pdDineroDescargado() As Double Implements Entidades.Turnos.iResumen.pdDineroDescargado
            Get
                Dim xContador As Double = 0
                For Each xx As iDescarga In Me.pdDescargas
                    If xx.pdTipoVale = enTipoVale.Dinero Then
                        xContador += xx.pdMonto
                    End If
                Next
                Return xContador
            End Get
        End Property
    End Class ' END CLASS DEFINITION clsResumen

End Namespace ' ReglasNegocio.Turnos

