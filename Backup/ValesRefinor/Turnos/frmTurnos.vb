Imports Entidades.Turnos
Imports ReglasNegocio.Turnos

Public Class frmTurnos

    Private xDiaTrabajo As iDiaTrabajo

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Turnos"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Try
            Me.MostrarDia()
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub MostrarDia()
        Try
            Me.xDiaTrabajo = New clsDiaTrabajo()
            xDiaTrabajo.obtener(Me.dtpDia.Value)
            Me.MostrarTurnos()
            Me.lblDescargasDia.Text = CStr(xDiaTrabajo.pdCantidadDescargas)
            Me.lblDineroDia.Text = " $ " & Format(xDiaTrabajo.pdDineroDescargado, "0.00")
            Me.lblLitrosDia.Text = xDiaTrabajo.pdCombustibleDescargado & " lts."
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub MostrarTurnos()
        Me.lstTurnos.Items.Clear()
        For Each xx As iTurno In Me.xDiaTrabajo.pdTurnos
            Me.lstTurnos.Items.Add(xx.Turno)
        Next
    End Sub

    Private Sub dtpDia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDia.ValueChanged
        Try
            If dtpDia.Value > Date.Now Then dtpDia.Value = Date.Now
            Me.MostrarDia()
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub MostrarTurno()
        With Me.xDiaTrabajo.pdTurnos(Me.lstTurnos.SelectedIndex)
            Me.lblDescargasTurno.Text = CStr(.pdResumen.pdDescargas.Count)
            Me.lblDineroTurno.Text = " $ " & Format(.pdResumen.pdDineroDescargado)
            Me.lblLitrosTurno.Text = .pdResumen.pdCombustibleDescargado & " lts."
        End With
    End Sub

    Private Sub lstTurnos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTurnos.SelectedIndexChanged
        If Me.lstTurnos.SelectedIndex <> -1 Then
            Me.MostrarTurno()
            Me.IDescargaBindingSource.DataSource = Me.xDiaTrabajo.pdTurnos(Me.lstTurnos.SelectedIndex).pdResumen.pdDescargas
        End If
    End Sub

    Private Sub dgvDescargas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvDescargas.SelectionChanged
        Me.dgvDescargas.ClearSelection()
    End Sub

    Private Sub btnImprimirDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirDia.Click
        frmImprimirDia.pdDia = Me.xDiaTrabajo
        frmImprimirDia.Show()
    End Sub

    Private Sub btnImprimirTurno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirTurno.Click
        If Me.lstTurnos.SelectedIndex <> -1 Then
            frmImprimirTurno.pdDia = Me.xDiaTrabajo
            frmImprimirTurno.pdTurno = Me.xDiaTrabajo.pdTurnos(Me.lstTurnos.SelectedIndex)
            frmImprimirTurno.Show()
        End If
    End Sub
End Class