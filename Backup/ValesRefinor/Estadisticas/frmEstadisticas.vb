Imports Entidades.Turnos
Imports ReglasNegocio.Turnos
Imports Entidades.Vales
Imports ReglasNegocio.Vales

Public Class frmEstadisticas
    Private xResumen As iResumen
    Private xResumenEmisiones As iResumenEmisiones

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Estadísticas"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Try
            'Me.MostrarEstadisticas()
            Me.MostrarAños()
            Me.MostrarAñosEmisiones()
            cmbAño.SelectedItem = Year(Date.Now)
            cmbMes.SelectedIndex = Month(Date.Now)
            Dim xSemana As Integer = DatePart(DateInterval.WeekOfYear, Date.Now, FirstDayOfWeek.Sunday, FirstWeekOfYear.FirstFourDays)
            cmbSemana.SelectedIndex = xSemana
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub MostrarEstadisticas()
        Try
            If rdHistorico.Checked Then
                MostrarLoading()
                Me.xResumen = clsResumen.ObtenerHistorico
                OcultarLoading()
            Else
                If cmbAño.SelectedIndex > 0 Then
                    If cmbMes.SelectedIndex > 0 Then
                        MostrarLoading()
                        xResumen = clsResumen.ObtenerPorMes(CInt(cmbAño.SelectedItem), cmbMes.SelectedIndex)
                        OcultarLoading()
                    Else
                        MostrarLoading()
                        If cmbSemana.SelectedIndex > 0 Then
                            xResumen = clsResumen.ObtenerPorSemana(CInt(cmbAño.SelectedItem), cmbSemana.SelectedIndex)
                        Else
                            xResumen = clsResumen.ObtenerPorAño(CInt(cmbAño.SelectedItem))
                        End If
                        OcultarLoading()
                    End If
                Else
                    Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
                    Me.CtrlMensaje.pdMensaje = "Debe seleccionar un año"
                End If
            End If

            With xResumen
                Me.lblDescargas.Text = xResumen.pdDescargas.Count.ToString
                Me.lblDinero.Text = "$" & Format(xResumen.pdDineroDescargado, "0.00")
                Me.lblLitros.Text = .pdCombustibleDescargado & " lts."

                Me.dgvDescargas.DataSource = Nothing
                Me.dgvDescargas.DataSource = xResumen.pdDescargas
            End With
        Catch ex As Exception
            OcultarLoading()
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub MostrarAños()
        Me.cmbAño.Items.Clear()
        cmbAño.Items.Add("-- Año --")
        For i As Integer = Year(Date.Now) To 2008 Step -1
            cmbAño.Items.Add(i)
        Next
        cmbAño.SelectedIndex = 0
    End Sub

    Private Sub cmbAño_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAño.SelectedIndexChanged
        If cmbAño.SelectedIndex > -1 Then cmbMes.SelectedIndex = 0
        Me.MostrarSemanas()

    End Sub

    Private Sub MostrarSemanas()
        cmbSemana.Items.Clear()
        cmbSemana.Items.Add("--Semana--")
        If cmbAño.SelectedIndex > 0 Then
            Dim xUltimaSemana As Integer = DatePart(DateInterval.WeekOfYear, New Date(CInt(cmbAño.SelectedItem), 12, 31), FirstDayOfWeek.Sunday, FirstWeekOfYear.FirstFourDays)
            For i As Integer = 1 To xUltimaSemana
                cmbSemana.Items.Add(i)
            Next
        End If
        cmbSemana.SelectedIndex = 0
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMes.SelectedIndexChanged
        If cmbMes.SelectedIndex > 0 Then
            cmbSemana.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmbSemana_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSemana.SelectedIndexChanged
        If cmbSemana.SelectedIndex > 0 Then
            cmbMes.SelectedIndex = 0

        End If
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Me.MostrarEstadisticas()
    End Sub

    Private Sub rdFiltro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdFiltro.CheckedChanged
        cmbAño.Enabled = rdFiltro.Checked
        cmbMes.Enabled = rdFiltro.Checked
        cmbSemana.Enabled = rdFiltro.Checked
    End Sub

#Region "Emisiones"
    Private Sub MostrarAñosEmisiones()
        Me.cmbAñoEmisiones.Items.Clear()
        cmbAñoEmisiones.Items.Add("-- Año --")
        For i As Integer = Year(Date.Now) To 2008 Step -1
            cmbAñoEmisiones.Items.Add(i)
        Next
        cmbAñoEmisiones.SelectedIndex = 0
    End Sub

    Private Sub cmbAñoEmisiones_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAñoEmisiones.SelectedIndexChanged
        If cmbAñoEmisiones.SelectedIndex > -1 Then cmbMesEmisiones.SelectedIndex = 0
        Me.MostrarSemanasEmisiones()
    End Sub

    Private Sub MostrarSemanasEmisiones()
        cmbSemanEmisiones.Items.Clear()
        cmbSemanEmisiones.Items.Add("--Semana--")
        If cmbAñoEmisiones.SelectedIndex > 0 Then
            Dim xUltimaSemana As Integer = DatePart(DateInterval.WeekOfYear, New Date(CInt(cmbAñoEmisiones.SelectedItem), 12, 31), FirstDayOfWeek.Sunday, FirstWeekOfYear.FirstFourDays)
            For i As Integer = 1 To xUltimaSemana
                cmbSemanEmisiones.Items.Add(i)
            Next
        End If
        cmbSemanEmisiones.SelectedIndex = 0
    End Sub

    Private Sub cmbMesEmisiones_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMesEmisiones.SelectedIndexChanged
        If cmbMesEmisiones.SelectedIndex > 0 Then
            cmbSemanEmisiones.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmbSemanaEmisiones_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSemanEmisiones.SelectedIndexChanged
        If cmbSemanEmisiones.SelectedIndex > 0 Then
            cmbMesEmisiones.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnFiltrarEmisiones_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFiltrarEmisiones.Click
        Me.MostrarEstadisticasEmisiones()
    End Sub

    Private Sub rdFiltroEmisiones_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdFiltroEmisiones.CheckedChanged
        cmbAñoEmisiones.Enabled = rdFiltroEmisiones.Checked
        cmbMesEmisiones.Enabled = rdFiltroEmisiones.Checked
        cmbSemanEmisiones.Enabled = rdFiltroEmisiones.Checked
    End Sub

    Private Sub MostrarEstadisticasEmisiones()
        Try
            If rdHistoricoEmisiones.Checked Then
                MostrarLoading()
                Me.xResumenEmisiones = clsResumenEmisiones.ObtenerHistorico
                OcultarLoading()
            Else
                If cmbAñoEmisiones.SelectedIndex > 0 Then
                    If cmbMesEmisiones.SelectedIndex > 0 Then
                        MostrarLoading()
                        xResumenEmisiones = clsResumenEmisiones.ObtenerPorMes(CInt(cmbAñoEmisiones.SelectedItem), cmbMesEmisiones.SelectedIndex)
                        OcultarLoading()
                    Else
                        MostrarLoading()
                        If cmbSemanEmisiones.SelectedIndex > 0 Then
                            xResumenEmisiones = clsResumenEmisiones.ObtenerPorSemana(CInt(cmbAñoEmisiones.SelectedItem), cmbSemanEmisiones.SelectedIndex)
                        Else
                            xResumenEmisiones = clsResumenEmisiones.ObtenerPorAño(CInt(cmbAñoEmisiones.SelectedItem))
                        End If
                        OcultarLoading()
                    End If
                Else
                    Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
                    Me.CtrlMensaje.pdMensaje = "Debe seleccionar un año"
                End If
            End If

            With xResumenEmisiones
                Me.lblEmisiones.Text = .pdEmisiones.Count.ToString
                Me.lblMontoEmitido.Text = "$" & Format(xResumenEmisiones.pdDineroEmitido, "0.00")
                Me.lblLitrosEmitidos.Text = .pdCombustibleEmitido & " lts."

                Me.dgvEmisiones.DataSource = Nothing
                Me.dgvEmisiones.DataSource = xResumenEmisiones.pdEmisiones
            End With
        Catch ex As Exception
            OcultarLoading()
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

#End Region
End Class