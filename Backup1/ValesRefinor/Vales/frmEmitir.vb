Imports ReglasNegocio.Clientes
Imports ReglasNegocio.Combustibles
Imports ReglasNegocio.Vales
Imports Entidades.Clientes
Imports Entidades.Combustibles
Imports Entidades.Vales
Imports Validacion.Vales
Imports PRS.Framework.Validacion

Public Class frmEmitir

    Private xClientes As List(Of iCliente)
    Private xCombustibles As List(Of iCombustible)
    Dim xDistribucion As New clsDistribucion
    Private xVVigencia As clsValidador
    Private xVTotal As clsValidador
    Private xVSerie As clsValidador

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Me.GroupBox1.Parent = Me
        Me.GroupBox1.BackColor = Color.Transparent
        Try
            Me.Validacion()
            Me.dtpFechaInicio.Value = Date.Now
            Me.MostrarClientesActivos()
            Me.MostrarCombustiblesActivos()
            Me.EstablecerTotal()
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub Validacion()
        Dim valVale As New vVale
        Me.xVVigencia = New clsValidador
        Me.xVTotal = New clsValidador
        Me.xVSerie = New clsValidador

        Me.xVVigencia.pdCampos.Add(New clsCampoTexto("Días de vigencia", Me.txtVigencia))
        Me.xVTotal.pdCampos.Add(New clsCampoTexto("Total", Me.txtTotal))
        Me.xVSerie.pdCampos.Add(New clsCampoTexto("Cantidad", Me.txtCantidad))
        Me.xVSerie.pdCampos.Add(New clsCampoTexto("Valor", Me.txtValor))

        With valVale
            Me.ctrlAVigencia.pdAyuda = .helpVigencia
            Me.ctrlAValor.pdAyuda = .helpValor
            Me.ctrlATotal.pdAyuda = .helpTotal
            Me.ctrlACantidad.pdAyuda = .helpCantidad
        End With
    End Sub

    Private Sub MostrarClientesActivos()
        Try
            xClientes = clsCliente.Listar(enEstadoCliente.Activo)
            If xClientes.Count = 0 Then
                Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Inicio, "")
                frmInicio.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
                frmInicio.CtrlMensaje.pdMensaje = "No hay clientes registrados. Para emitir vales, primero debe registrar un cliente haciendo click en la opción 'Nuevo cliente' en la sección 'Clientes' del menú."
            Else
                Me.IClienteBindingSource.DataSource = Me.xClientes
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub MostrarCombustiblesActivos()
        Try
            xCombustibles = clsCombustible.Listar(enEstadoCombustible.Activo)
            Me.ICombustibleBindingSource.DataSource = Me.xCombustibles
        Catch ex As Exception
            Throw
        End Try
    End Sub


    Private Sub rdDinero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdDinero.CheckedChanged
        Me.xDistribucion.pdItems.Clear()
        Me.EstablecerTotal()
        Me.MostrarDistribucion()
        If rdDinero.Checked Then
            Me.lblTotal.Text = "Total ($)"

        Else
            If Me.xCombustibles.Count = 0 Then
                Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = "No hay combustibles registrados. Para emitir vales por combustible, primero debe registrar uno haciendo click en el botón 'Nuevo' de la sección 'Combustibles' del menú."
                Me.rdDinero.Checked = True
            Else
                Me.lblTotal.Text = "Total (lts.)"
            End If
        End If
        Me.lblCombustible.Visible = Me.rdCombustible.Checked
        Me.lstCombustible.Visible = Me.rdCombustible.Checked
    End Sub

    Private Sub btnAgregarSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarSerie.Click
        Try
            Me.CtrlMensaje.pdErrores.Clear()
            Me.CtrlMensaje.pdMensaje = ""
            If Me.xVSerie.Validar Then
                Me.xDistribucion.pdTotal = CDbl(Me.txtTotal.Text)
                Dim xItemDistr As New clsItemDistribucion
                xItemDistr.pdCantidad = CInt(Me.txtCantidad.Text)
                xItemDistr.pdValor = CSng(Me.txtValor.Text)
                Me.xDistribucion.AgregarItem(xItemDistr)
                Me.EstablecerTotal()
                Me.MostrarDistribucion()
            Else
                Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = xErrorCampo
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub EstablecerTotal()
        Me.CtrlMensaje.pdMensaje = ""
        If Me.txtTotal.Text = "" Then Me.txtTotal.Text = CStr(0)
        Me.xDistribucion.pdTotal = CDbl(Me.txtTotal.Text)
        If Me.rdDinero.Checked Then
            Me.lblTotalDistribucion.Text = "$"
            Me.lblRestante.Text = "$"
        Else
            Me.lblTotalDistribucion.Text = ""
            Me.lblRestante.Text = ""
        End If

        Dim xAcumulado As Double = Me.xDistribucion.ValorAcumulado
        Dim xRestante As Double = Me.xDistribucion.Restante

        If xAcumulado < CDbl(Me.txtTotal.Text) Or xAcumulado > CDbl(Me.txtTotal.Text) Then
            Me.lblTotalDistribucion.ForeColor = Color.Red
        ElseIf xAcumulado = CDbl(Me.txtTotal.Text) Then
            Me.lblTotalDistribucion.ForeColor = Color.Green
        End If

        Me.lblTotalDistribucion.Text &= xAcumulado
        Me.lblRestante.Text &= xRestante

        If Me.rdCombustible.Checked Then
            Me.lblTotalDistribucion.Text &= " lts."
            Me.lblRestante.Text &= " lts."
        End If
    End Sub

    Private Sub btnQuitarSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarSerie.Click
        If Me.lstDistribucion.SelectedIndex <> -1 Then
            Me.xDistribucion.pdItems.RemoveAt(Me.lstDistribucion.SelectedIndex)
            Me.EstablecerTotal()
            Me.MostrarDistribucion()
        Else
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = "No seleccionó ningún elemento de la lista."
        End If
    End Sub

    Private Sub MostrarDistribucion()
        Me.lstDistribucion.Items.Clear()
        For Each xx As iItemDistribucion In Me.xDistribucion.pdItems
            If Me.rdDinero.Checked Then
                Me.lstDistribucion.Items.Add(xx.pdCantidad & " x $" & xx.pdValor)
            Else
                Me.lstDistribucion.Items.Add(xx.pdCantidad & " x " & xx.pdValor & " lts.")
            End If
        Next
    End Sub

    Private Sub txtTotal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.LostFocus
        Me.CtrlMensaje.pdErrores.Clear()
        Me.CtrlMensaje.pdMensaje = ""
        If Me.xVTotal.Validar Then
            Me.EstablecerTotal()
        Else
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = xErrorCampo
        End If
    End Sub

    Private Sub btnEmitir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmitir.Click
        Try
            Me.CtrlMensaje.pdErrores.Clear()
            Me.CtrlMensaje.pdMensaje = ""
            If Me.xVVigencia.Validar And Me.xVTotal.Validar Then
                Dim xR As MsgBoxResult = MsgBox("¿Está seguro que desea registrar esta serie?", MsgBoxStyle.YesNo, xTitulo & "Emitir Serie")
                If xR = MsgBoxResult.Yes Then
                    Dim xSerie As clsSerie
                    If Me.rdCombustible.Checked Then
                        MostrarLoading()
                        xSerie = New clsSerie(CInt(Me.txtTotal.Text), Me.xClientes(Me.lstCliente.SelectedIndex), Me.xDistribucion, Me.dtpFechaInicio.Value, CInt(Me.txtVigencia.Text), Me.xCombustibles(Me.lstCombustible.SelectedIndex))
                        OcultarLoading()
                    Else
                        MostrarLoading()
                        xSerie = New clsSerie(CInt(Me.txtTotal.Text), Me.xClientes(Me.lstCliente.SelectedIndex), Me.xDistribucion, Me.dtpFechaInicio.Value, CInt(Me.txtVigencia.Text))
                        OcultarLoading()
                    End If
                    Dim xR2 As MsgBoxResult = MsgBox("¿Desea imprimir esta serie ahora?", MsgBoxStyle.YesNo, xTitulo & "Imprimir Serie")
                    If xR2 = MsgBoxResult.Yes Then
                        Dim xC As New DynamicComparer.DynamicComparer(Of iVale)("pdValor DESC, pdID ASC")
                        frmImprimir.pdVales = xSerie.pdVales
                        frmImprimir.Show()
                        Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Inicio, "Serie registrada correctamente. Haga click en el botón 'Imprimir' de la ventana 'Imprimir Vales' para imprimir la serie.")
                    Else
                        Navegacion.clsGestorFormularios.Abrir(Navegacion.enFormulario.Inicio, "Serie registrada correctamente. Si desea imprimir la serie, haga click en el botón 'Emisiones' en la sección 'Vales' del menú")
                    End If
                End If
            Else
                Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = xErrorCampo
            End If
        Catch ex As Exception
            OcultarLoading()
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub
End Class