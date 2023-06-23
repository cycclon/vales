Imports Entidades.Turnos
Imports Entidades.Acceso
Imports Acceso
Imports AccesoADatos.Mapeo.Turnos
Imports Excepciones.Turnos

Namespace Turnos
    Public Class clsTurnoActual : Implements iTurnoActual

        Private xDiaSemana As enDiasSemana
        Private xEmpleados As List(Of iUsuario)
        Private xTurno As clsTurnoActual
        Private xFinal As TimeSpan
        Private xInicio As TimeSpan
        Private xID As Byte

        Public Sub ArmarFull() Implements Entidades.iLazy.ArmarFull
            Try
                If Me.xTurno Is Nothing Then
                    Me.xTurno = New clsTurnoActual
                    Me.xTurno.xEmpleados = clsUsuario.ListarPorTurno(Me.xID)
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow) Implements Entidades.iLazy.ArmarLazy
            With prRegistro
                Me.xFinal = Date.Parse(.Item("tuac_final")).TimeOfDay
                Me.xID = .Item("tuac_id")
                Me.xInicio = Date.Parse(.Item("tuac_inicio")).TimeOfDay
                Me.xDiaSemana = .Item("tuac_dia_semana")
            End With
        End Sub

        Public Property pdDiaSemana() As Entidades.Turnos.enDiasSemana Implements iTurnoActual.pdDiaSemana
            Get
                Return Me.xDiaSemana
            End Get
            Set(ByVal value As Entidades.Turnos.enDiasSemana)
                Me.xDiaSemana = value
            End Set
        End Property

        Public Property pdEmpleados() As List(Of iUsuario) Implements iTurnoActual.pdEmpleados
            Get
                Try
                    ArmarFull()
                    Return xTurno.xEmpleados
                Catch ex As Exception
                    Throw
                End Try
            End Get

            Set(ByVal Value As List(Of iUsuario))
                Try
                    ArmarFull()
                    xTurno.xEmpleados = Value
                Catch ex As Exception
                    Throw
                End Try
            End Set
        End Property

        Public Property pdFinal() As TimeSpan Implements Entidades.Turnos.iTurnoActual.pdFinal
            Get
                Return Me.xFinal
            End Get
            Set(ByVal value As TimeSpan)
                Me.xFinal = value
            End Set
        End Property

        Public Property pdID() As Short Implements Entidades.Turnos.iTurnoActual.pdID
            Get
                Return Me.xID
            End Get
            Set(ByVal value As Short)
                Me.xID = value
            End Set
        End Property

        Public Property pdInicio() As TimeSpan Implements Entidades.Turnos.iTurnoActual.pdInicio
            Get
                Return Me.xInicio
            End Get
            Set(ByVal value As TimeSpan)
                Me.xInicio = value
            End Set
        End Property

        Public ReadOnly Property Turno() As String Implements Entidades.Turnos.iTurnoActual.Turno
            Get
                Return Me.xDiaSemana.ToString & " de " & String.Format("{0:HH:mm}", Me.xInicio) & " a " & String.Format("{0:HH:mm}", Me.xFinal)
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return Turno
        End Function

        Public Shared Function Listar() As List(Of iTurnoActual)
            Try
                Dim objDS As DataSet = mTurnosActuales.Listar
                Dim xTs As New List(Of iTurnoActual)
                'Dim xComparer As New DynamicComparer.DynamicComparer(Of iTurnoActual)("pdDiaSemana ASC")
                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xT As New clsTurnoActual
                    xT.ArmarLazy(xx)
                    xTs.Add(xT)
                Next

                'xTs.Sort(AddressOf xComparer.Compare)

                Return xTs
            Catch ex As Exception
                Throw
            End Try
        End Function

        Private Shared Sub ControlarHorarioSolapado(ByVal prTurnosActuales As List(Of iTurnoActual))
            Try
                Dim xTs As List(Of iTurnoActual) = Listar()
                For Each xx As iTurnoActual In prTurnosActuales
                    For Each yy As iTurnoActual In xTs
                        If xx.pdDiaSemana = yy.pdDiaSemana Then
                            'Hora de inicio del nuevo entre hora de inicio y hora de final
                            If xx.pdInicio >= yy.pdInicio And xx.pdInicio <= yy.pdFinal Then Throw New exHorariosSolapados
                            'Hora de final del nuevo entre hora de inicio y hora de final
                            If xx.pdFinal >= yy.pdInicio And xx.pdInicio <= yy.pdFinal Then Throw New exHorariosSolapados
                            'Nuevo Horario encierra a horario existente
                            If xx.pdInicio <= yy.pdInicio And xx.pdFinal >= yy.pdFinal Then Throw New exHorariosSolapados
                        End If
                    Next
                Next
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Private Shared Sub ControlarTurnoSinEmpleado(ByVal prTurnos As List(Of iTurnoActual))
            Try
                For Each xx As iTurnoActual In prTurnos
                    If xx.pdEmpleados.Count = 0 Then Throw New exTurnoSinEmpleados
                Next
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Sub Registrar(ByVal prTurnos As List(Of iTurnoActual))
            Try
                If prTurnos.Count = 0 Then Throw New exDiaNoSeleccionado
                ControlarTurnoSinEmpleado(prTurnos)
                ControlarHorarioSolapado(prTurnos)
                For Each xx As iTurnoActual In prTurnos
                    xx.Registrar()
                Next
            Catch ex As Exception
                Throw
            End Try
        End Sub


        Private Sub Registrar() Implements Entidades.Turnos.iTurnoActual.Registrar
            Try
                'REGISTRAR TURNO
                mTurnosActuales.Registrar(Me)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Sub ControlarEmpleados()
            Try
                Dim xF As Boolean = False
                Dim xEs As List(Of iUsuario) = clsUsuario.ListarPorTipo(enTipoUsuario.Empleado)
                For Each xx As iUsuario In xEs
                    If xx.pdEstado = enEstadoUsuario.Activo Then
                        xF = True
                        Exit For
                    End If
                Next
                If Not xF Then Throw New exEmpleadosNoRegistrados
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub Eliminar() Implements Entidades.Turnos.iTurnoActual.Eliminar
            Try
                mTurnosActuales.Eliminar(Me.xID)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Shared Function ListarPorDia(ByVal prDia As enDiasSemana) As List(Of iTurnoActual)
            Try
                Dim xTs As New List(Of iTurnoActual)
                Dim objDS As DataSet = mTurnosActuales.Listar(prDia)
                For Each xx As DataRow In objDS.Tables(0).Rows
                    Dim xT As New clsTurnoActual
                    xT.ArmarLazy(xx)
                    xTs.Add(xT)
                Next

                Return xTs

            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Sub Actualizar() Implements Entidades.Turnos.iTurnoActual.Actualizar
            Try
                mTurnosActuales.Actualizar(Me)
            Catch ex As Exception
                Throw
            End Try
        End Sub
    End Class
End Namespace

