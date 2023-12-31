Imports Entidades.Turnos
Imports Entidades.Acceso
Imports AccesoADatos.Mapeo.Turnos

Namespace Turnos

    Public Class clsTurno : Implements iTurno

        Protected xInicio As TimeSpan

        Protected xFinal As TimeSpan

        Protected xID As Integer

        Private xTurno As clsTurno

        Protected xResumen As iResumen

       

        Public Sub ArmarFull() Implements Entidades.iLazy.ArmarFull
            Try
                If Me.xTurno Is Nothing Then
                    Me.xTurno = New clsTurno
                    Me.xTurno.xResumen = clsResumen.ObtenerPorTurno(Me.xID)
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow) Implements Entidades.iLazy.ArmarLazy
            With prRegistro
                Me.xFinal = Date.Parse(.Item("tur_final")).TimeOfDay
                Me.xID = .Item("tur_id")
                Me.xInicio = Date.Parse(.Item("tur_inicio")).TimeOfDay
                
            End With
        End Sub

        Public Property pdFinal() As TimeSpan Implements Entidades.Turnos.iTurno.pdFinal
            Get
                Return Me.xFinal
            End Get
            Set(ByVal value As TimeSpan)
                Me.xFinal = value
            End Set
        End Property

        Public Property pdID() As Integer Implements Entidades.Turnos.iTurno.pdID
            Get
                Return Me.xID
            End Get
            Set(ByVal value As Integer)
                Me.xID = value
            End Set
        End Property

        Public Property pdInicio() As TimeSpan Implements Entidades.Turnos.iTurno.pdInicio
            Get
                Return Me.xInicio
            End Get
            Set(ByVal value As TimeSpan)
                Me.xInicio = value
            End Set
        End Property

        Public Property pdResumen() As Entidades.Turnos.iResumen Implements Entidades.Turnos.iTurno.pdResumen
            Get
                Try
                    ArmarFull()
                    Return xTurno.xResumen
                Catch ex As Exception
                    Throw
                End Try
            End Get
            Set(ByVal value As Entidades.Turnos.iResumen)
                Try
                    ArmarFull()
                    Me.xTurno.xResumen = value
                Catch ex As Exception
                    Throw
                End Try
            End Set
        End Property

        Public Shared Function ListarPorDia(ByVal prDia As Short) As List(Of iTurno)
            Try
                Dim objDS As DataSet = mTurnos.ListarPorDia(prDia)
                Dim xTs As New List(Of iTurno)
                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xT As New clsTurno
                    xT.ArmarLazy(xx)
                    xTs.Add(xT)
                Next

                Return xTs
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public ReadOnly Property Turno() As String Implements Entidades.Turnos.iTurno.Turno
            Get
                Return "de " & String.Format("{0:HH:mm}", Me.xInicio) & " a " & String.Format("{0:HH:mm}", Me.xFinal)
            End Get
        End Property

        Public Sub AgregarDescarga(ByVal prDescarga As Entidades.Vales.iDescarga) Implements Entidades.Turnos.iTurno.AgregarDescarga
            Try
                mTurnos.RegistrarTurnoDescarga(Me.xID, prDescarga.pdID)
                Me.pdResumen.pdDescargas.Add(prDescarga)
            Catch ex As Exception
                Throw
            End Try
        End Sub
    End Class ' END CLASS DEFINITION clsTurno

End Namespace ' ReglasNegocio.Turnos

