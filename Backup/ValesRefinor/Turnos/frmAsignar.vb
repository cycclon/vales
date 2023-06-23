Imports Acceso
Imports Entidades.Acceso
Imports Entidades.Turnos
Imports ReglasNegocio.Turnos

Public Class frmAsignar

    Private xSinAsignar As List(Of iUsuario)
    Private xAsignados As List(Of iUsuario)
    Private xTurnos As List(Of iTurnoActual)

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Text = xTitulo & "Asignar Turnos"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill

        Try
            Me.ControlarEmpleados()
            Me.ObtenerEmpleados()
            Me.xAsignados = New List(Of iUsuario)
            Me.MostrarTurnos()
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub ControlarEmpleados()
        Try
            clsTurnoActual.ControlarEmpleados()
        Catch ex As Exception
            Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Inicio, "")
            frmInicio.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            frmInicio.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub MostrarTurnos()
        Try
            Me.xTurnos = clsTurnoActual.listar()
            Me.ITurnoActualBindingSource.DataSource = xTurnos
            Me.DataSourceTurnos()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub DataSourceTurnos()
        Me.lstTurnos.DataSource = Nothing
        Me.lstTurnos.Items.Clear()
        Me.lstTurnos.DataSource = Me.ITurnoActualBindingSource.DataSource
    End Sub

    Private Sub ObtenerEmpleados()
        Try
            xSinAsignar = clsUsuario.ListarPorTipo(enTipoUsuario.Empleado)
            Me.IUsuarioBindingSource.DataSource = xSinAsignar
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub EstablecerDataSources()
        Me.IUsuarioBindingSource.DataSource = xSinAsignar
        Me.IUsuarioBindingSource1.DataSource = xAsignados
        Me.lstSinAsignar.DataSource = Nothing
        Me.lstSinAsignar.Items.Clear()
        Me.lstSinAsignar.DataSource = IUsuarioBindingSource.DataSource
        Me.lstAsignados.DataSource = Nothing
        Me.lstAsignados.Items.Clear()
        Me.lstAsignados.DataSource = IUsuarioBindingSource1.DataSource
    End Sub

    Private Sub btnAgregarEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarEmpleado.Click
        If Me.lstSinAsignar.SelectedIndex <> -1 Then
            Me.xAsignados.Add(Me.xSinAsignar(Me.lstSinAsignar.SelectedIndex))
            Me.xSinAsignar.RemoveAt(Me.lstSinAsignar.SelectedIndex)
            Me.EstablecerDataSources()

            If Me.ActualizarTurno() Then
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                Me.CtrlMensaje.pdMensaje = "Se agregaron correctamente los empleados seleccionados."
            End If
        End If
    End Sub

    Private Function ActualizarTurno() As Boolean
        Try
            If xTurnos(lstTurnos.SelectedIndex).pdID <> 0 Then
                xTurnos(lstTurnos.SelectedIndex).Actualizar()
                Me.IUsuarioBindingSource2.DataSource = Me.xTurnos(Me.lstTurnos.SelectedIndex).pdEmpleados
                Me.DataSourceEmpleados()
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Function

    Private Sub btnQuitarEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarEmpleado.Click
        If Me.lstAsignados.SelectedIndex <> -1 Then
            Me.xSinAsignar.Add(Me.xAsignados(Me.lstAsignados.SelectedIndex))
            Me.xAsignados.RemoveAt(Me.lstAsignados.SelectedIndex)
            Me.EstablecerDataSources()
            If Me.ActualizarTurno() Then
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                Me.CtrlMensaje.pdMensaje = "Se quitaron correctamente los empleados seleccionados."
            End If
        End If
    End Sub

    Private Sub lstTurnos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTurnos.SelectedIndexChanged
        If Me.lstTurnos.SelectedIndex <> -1 Then
            Me.IUsuarioBindingSource2.DataSource = Me.xTurnos(Me.lstTurnos.SelectedIndex).pdEmpleados
            Me.xAsignados = Me.xTurnos(Me.lstTurnos.SelectedIndex).pdEmpleados

            Dim xNoAsignados As New List(Of iUsuario)

            For Each xx As iUsuario In clsUsuario.ListarPorTipo(enTipoUsuario.Empleado)
                Dim xAgregar As Boolean = True
                For Each yy As iUsuario In xTurnos(lstTurnos.SelectedIndex).pdEmpleados
                    If xx.pdID = yy.pdID Then
                        xAgregar = False
                        Exit For
                    End If
                Next
                If xAgregar Then xNoAsignados.Add(xx)
            Next

            Me.xSinAsignar = xNoAsignados

            Me.EstablecerDataSources()
            Me.DataSourceEmpleados()
        End If
    End Sub

    Private Sub DataSourceEmpleados()
        Me.lstEmpleados.DataSource = Nothing
        Me.lstEmpleados.Items.Clear()
        Me.lstEmpleados.DataSource = Me.IUsuarioBindingSource2.DataSource
    End Sub

    Private Function AgregarTurno(ByVal prDiaSemana As enDiasSemana) As iTurnoActual
        Try
            Dim xT As New clsTurnoActual
            With xT
                .pdDiaSemana = prDiaSemana
                .pdEmpleados = Me.xAsignados
                .pdFinal = TimeSpan.Parse(Me.nudHFinal.Value.ToString & ":" & Me.nudMFinal.Value.ToString & ":00.0000")
                .pdInicio = TimeSpan.Parse(Me.nudhInicio.Value.ToString & ":" & Me.nudMInicio.Value.ToString & ":00.0000")
            End With

            Return xT
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        Try
            MostrarLoading()
            Dim xTs As New List(Of iTurnoActual)
            If chkDomingo.Checked Then
                xTs.Add(AgregarTurno(enDiasSemana.Domingo))
            End If
            If chkLunes.Checked Then
                xTs.Add(AgregarTurno(enDiasSemana.Lunes))
            End If
            If chkMartes.Checked Then
                xTs.Add(AgregarTurno(enDiasSemana.Martes))
            End If
            If chkMiercoles.Checked Then
                xTs.Add(AgregarTurno(enDiasSemana.Miércoles))
            End If
            If chkJueves.Checked Then
                xTs.Add(AgregarTurno(enDiasSemana.Jueves))
            End If
            If chkViernes.Checked Then
                xTs.Add(AgregarTurno(enDiasSemana.Viernes))
            End If
            If chkSábado.Checked Then
                xTs.Add(AgregarTurno(enDiasSemana.Sábado))
            End If
            clsTurnoActual.Registrar(xTs)
            OcultarLoading()
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
            Me.CtrlMensaje.pdMensaje = "El/ los turno/s se registraron correctamente."
            Me.xAsignados = New List(Of iUsuario)
            Me.ObtenerEmpleados()
            Me.EstablecerDataSources()
            Me.MostrarTurnos()
            Me.lstTurnos.ClearSelected()
        Catch ex As Exception
            OcultarLoading()
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub btnQuitarTurno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarTurno.Click
        Try
            If Me.lstTurnos.SelectedIndex <> -1 Then
                If MsgBox("¿Está seguro que desea eliminar el turno seleccionado?", MsgBoxStyle.YesNo, xTitulo & "Eliminar Turno") = MsgBoxResult.Yes Then
                    xTurnos(Me.lstTurnos.SelectedIndex).Eliminar()
                    Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                    Me.CtrlMensaje.pdMensaje = "Turno eliminado correctamente"
                    Me.MostrarTurnos()
                    If Me.lstTurnos.Items.Count <> 0 Then
                        Me.lstTurnos.SelectedIndex = 0
                    Else
                        Me.IUsuarioBindingSource2.DataSource = New List(Of iUsuario)
                        Me.DataSourceEmpleados()
                    End If

                End If
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub
End Class