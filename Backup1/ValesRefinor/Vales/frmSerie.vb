Imports ReglasNegocio.Vales
Imports Entidades.Vales
Imports Validacion.Vales
Imports PRS.Framework.Validacion

Public Class frmSerie

    Private xSerie As iSerie
    Private xVVencimiento As clsValidador

    Public Property pdSerie() As iSerie
        Get
            Return Me.xSerie
        End Get
        Set(ByVal value As iSerie)
            Me.xSerie = value
            Try
                'MostrarLoading()
                Me.MostrarSerie()
                'OcultarLoading()
            Catch ex As Exception
                'OcultarLoading()
                Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
            End Try
        End Set
    End Property

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill

        Try
            Me.Validacion()

        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub Validacion()
        Dim valVale As New vVale
        xVVencimiento = New clsValidador
        xVVencimiento.pdCampos.Add(New clsCampoTexto("Extender vencimiento", Me.txtVigencia))

        With valVale
            'Me.txtVigencia.Validation = .exVigencia
            'Me.txtVigencia.pdFormatErrorMessage = .msgVigencia
            'Me.txtVigencia.pdRequiredErrorMessage = .msgRVigencia
            'Me.ctrlAVigencia.pdAyuda = .helpVigencia
        End With
    End Sub

    Private Sub MostrarSerie()
        Try
            With Me.xSerie
                Me.lblCantidadVales.Text = CStr(.pdVales.Count)
                Me.lblCliente.Text = .pdCliente.pdNombreCompleto
                If .pdTipo = enTipoVale.Combustible Then
                    Me.lblTotal.Text = "Total (lts.):"
                    Me.lblNombreCombustible.Visible = True
                    Me.lblCombustible.Visible = True
                    Me.lblNombreCombustible.Text = .pdValePor
                Else
                    Me.lblTotal.Text = "Total ($):"
                    Me.lblNombreCombustible.Visible = False
                    Me.lblCombustible.Visible = False
                End If
                Me.lblSinDescargar.Text = CStr(.pdSaldoDisponible)
                Me.lblTipoVale.Text = .pdTipo.ToString
                Me.lblTotalSerie.Text = CStr(.pdTotal)
                Me.lblVencimiento.Text = CStr(.pdVencimiento)
            End With
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            If Me.xSerie.pdValesDisponibles.Count <> 0 Then
                MsgBox("Se imprimirán todos los vales DISPONIBLES (No descargados, no reportados, no vencidos) de esta serie.", MsgBoxStyle.OkOnly, xTitulo & "Imprimir vales")

                frmImprimir.pdVales = Me.xSerie.pdValesDisponibles
                frmImprimir.Show()
            Else
                MsgBox("Esta serie no tiene vales restantes por canjear.", MsgBoxStyle.OkOnly, xTitulo & "Imprimir vales")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnExtender_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExtender.Click
        Try
            If Me.xVVencimiento.Validar Then
                'If Me.xSerie.pdValesDisponibles.Count <> 0 Then
                If MsgBox("¿Está seguro que desea extender la vigencia de los vales de la serie por " & Me.txtVigencia.Text & " días?", MsgBoxStyle.YesNo, xTitulo & "Extender vencimiento") = MsgBoxResult.Yes Then
                    'MostrarLoading()
                    Me.xSerie.ExtenderVencimiento(CShort(Me.txtVigencia.Text))
                    Me.MostrarSerie()
                    'OcultarLoading()
                    Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.Mensaje
                    Me.CtrlMensaje.pdMensaje = "Se extendió la fecha de vencimiento de esta serie por " & Me.txtVigencia.Text & " días."
                    Me.txtVigencia.Text = CStr(0)
                End If
                'Else
                'MsgBox("Esta serie no tiene vales restantes por canjear.", MsgBoxStyle.OkOnly, xTitulo & "Extender vencimiento")
                'End If
            Else
                'OcultarLoading()
                Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = xErrorCampo
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub btnReportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportar.Click
        Try
            If Me.xSerie.pdValesDisponibles.Count <> 0 Then
                If MsgBox("Al establecer una serie como robada o extraviada, se crearán nuevos vales por todos los vales que aún no fueron descargados, y estos últimos serán eliminados. ¿Desea continuar?", MsgBoxStyle.YesNo, xTitulo & "Reportar serie") = MsgBoxResult.Yes Then
                    'MostrarLoading()
                    xSerie.Reportar()
                    Me.MostrarSerie()
                    'OcultarLoading()
                    Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.Mensaje
                    Me.CtrlMensaje.pdMensaje = "Los vales disponibles de esta serie fueron establecidos como extraviados / robados. Se registraron nuevos vales reemplazando los reportados."
                    If MsgBox("¿Desea imprimir los nuevos vales registrados?", MsgBoxStyle.YesNo, xTitulo & "Imprimir vales") = MsgBoxResult.Yes Then
                        frmImprimir.pdVales = Me.xSerie.pdValesDisponibles
                        frmImprimir.Show()
                    End If
                End If
            Else
                MsgBox("Esta serie no tiene vales restantes por canjear.", MsgBoxStyle.OkOnly, xTitulo & "Reportar serie")
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub
End Class