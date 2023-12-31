' Static Model

Imports AccesoADatos.Mapeo.Turnos
Imports Entidades.Turnos
Imports Excepciones.Turnos

Namespace Turnos

    Public Class clsDiaTrabajo : Implements iDiaTrabajo

        Protected xTurnos As List(Of Entidades.Turnos.iTurno)
        Protected xFecha As Date
        Protected xID As Short
        Private xDiaTrabajo As clsDiaTrabajo

        Public Sub New()
            Me.xID = 0
            Me.xTurnos = New List(Of iTurno)
            Me.xFecha = Date.Now
        End Sub

        Public Sub New(ByVal prFecha As Date)
            Me.xTurnos = New List(Of iTurno)
            Try
                Me.ObtenerDia(prFecha)
                If Me.xID = 0 Then
                    RegistrarDia()
                End If

            Catch ex As Exception
                Throw
            End Try
        End Sub

        Private Sub ObtenerDia(ByVal prFecha)
            Try
                Dim objDS As DataSet = mDiasTrabajo.Obtener(Date.Now.Date)
                If objDS.Tables(0).Rows.Count <> 0 Then
                    Me.ArmarLazy(objDS.Tables(0).Rows(0))
                Else
                    Me.xFecha = prFecha
                    Me.xID = 0
                    Me.xTurnos = New List(Of iTurno)
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Private Sub RegistrarDia()
            Try
                Dim xTurnosActuales As List(Of iTurnoActual)
                Select Case Date.Now.DayOfWeek
                    Case DayOfWeek.Sunday
                        xTurnosActuales = clsTurnoActual.ListarPorDia(enDiasSemana.Domingo)
                    Case DayOfWeek.Monday
                        xTurnosActuales = clsTurnoActual.ListarPorDia(enDiasSemana.Lunes)
                    Case DayOfWeek.Tuesday
                        xTurnosActuales = clsTurnoActual.ListarPorDia(enDiasSemana.Martes)
                    Case DayOfWeek.Wednesday
                        xTurnosActuales = clsTurnoActual.ListarPorDia(enDiasSemana.Miércoles)
                    Case DayOfWeek.Thursday
                        xTurnosActuales = clsTurnoActual.ListarPorDia(enDiasSemana.Jueves)
                    Case DayOfWeek.Friday
                        xTurnosActuales = clsTurnoActual.ListarPorDia(enDiasSemana.Viernes)
                    Case DayOfWeek.Saturday

                        xTurnosActuales = clsTurnoActual.ListarPorDia(enDiasSemana.Sábado)
                    Case Else
                        xTurnosActuales = New List(Of iTurnoActual)
                End Select
                If xTurnosActuales.Count = 0 Then Throw New exDiaSinTurnos

                For Each xx As iTurnoActual In xTurnosActuales
                    Dim xT As New clsTurno
                    With xT
                        .pdFinal = xx.pdFinal
                        .pdInicio = xx.pdInicio
                    End With
                    Me.pdTurnos.Add(xT)
                Next
                Me.xFecha = Date.Now.Date
                mDiasTrabajo.Registrar(Me)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub ArmarFull() Implements Entidades.iLazy.ArmarFull
            Try
                If Me.xDiaTrabajo Is Nothing Then
                    Me.xDiaTrabajo = New clsDiaTrabajo
                    Me.xDiaTrabajo.xTurnos = clsTurno.ListarPorDia(Me.xID)
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub ArmarLazy(ByVal prRegistro As System.Data.DataRow) Implements Entidades.iLazy.ArmarLazy
            With prRegistro
                Me.xFecha = .Item("ditr_fecha")
                Me.xID = .Item("ditr_id")
            End With
        End Sub

        Public Property pdFecha() As Date Implements Entidades.Turnos.iDiaTrabajo.pdFecha
            Get
                Return Me.xFecha
            End Get
            Set(ByVal value As Date)
                Me.xFecha = value
            End Set
        End Property

        Public Property pdID() As Short Implements Entidades.Turnos.iDiaTrabajo.pdID
            Get
                Return Me.xID
            End Get
            Set(ByVal value As Short)
                Me.xID = value
            End Set
        End Property

        Public Property pdTurnos() As System.Collections.Generic.List(Of Entidades.Turnos.iTurno) Implements Entidades.Turnos.iDiaTrabajo.pdTurnos
            Get
                Try
                    ArmarFull()
                    Return Me.xDiaTrabajo.xTurnos
                Catch ex As Exception
                    Throw
                End Try
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of Entidades.Turnos.iTurno))
                Try
                    ArmarFull()
                    Me.xDiaTrabajo.xTurnos = value
                Catch ex As Exception
                    Throw
                End Try
            End Set
        End Property

        Public Sub Obtener(ByVal prFecha As Date) Implements Entidades.Turnos.iDiaTrabajo.Obtener
            Try
                Dim objDS As DataSet = mDiasTrabajo.Obtener(prFecha)
                If objDS.Tables(0).Rows.Count <> 0 Then
                    Me.ArmarLazy(objDS.Tables(0).Rows(0))
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public ReadOnly Property pdCantidadDescargas() As Short Implements Entidades.Turnos.iDiaTrabajo.pdCantidadDescargas
            Get
                Dim xContador As Short = 0

                For Each xx As iTurno In Me.pdTurnos
                    xContador += xx.pdResumen.pdDescargas.Count
                Next

                Return xContador
            End Get
        End Property

        Public ReadOnly Property pdCombustibleDescargado() As Double Implements Entidades.Turnos.iDiaTrabajo.pdCombustibleDescargado
            Get
                Dim xContador As Double = 0
                For Each xx As iTurno In Me.pdTurnos
                    xContador += xx.pdResumen.pdCombustibleDescargado
                Next
                Return xContador
            End Get
        End Property

        Public ReadOnly Property pdDineroDescargado() As Double Implements Entidades.Turnos.iDiaTrabajo.pdDineroDescargado
            Get
                Dim xContador As Double = 0
                For Each xx As iTurno In Me.pdTurnos
                    xContador += xx.pdResumen.pdDineroDescargado
                Next
                Return xContador
            End Get
        End Property

        Public Function TurnoActual() As Entidades.Turnos.iTurno Implements Entidades.Turnos.iDiaTrabajo.TurnoActual
            Dim xT As iTurno = Nothing

            For Each xx As iTurno In Me.pdTurnos
                If xx.pdInicio <= Date.Now.TimeOfDay And xx.pdFinal >= Date.Now.TimeOfDay Then
                    xT = xx
                End If
            Next

            If xT Is Nothing Then
                For Each xx As iTurno In Me.pdTurnos
                    If xT Is Nothing Then xT = xx
                    If xx.pdFinal < Date.Now.TimeOfDay Then
                        If xx.pdFinal > xT.pdFinal Then
                            xT = xx
                        End If
                    Else
                        If xx.pdInicio < xT.pdInicio Then
                            xT = xx
                        End If
                    End If
                Next
            End If

            If xT Is Nothing Then
                Return New clsTurno
            Else
                Return xT
            End If
        End Function
    End Class ' END CLASS DEFINITION clsDiaTrabajo

End Namespace ' ReglasNegocio.Turnos

