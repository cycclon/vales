Imports Entidades.Vales
Imports ReglasNegocio.Vales
Imports Validacion.Vales
Imports Acceso
Imports PRS.Framework.Validacion

Public Class frmDescargaParcial
    Private xTmr As Integer = 0
    Private WithEvents xVale As iVale
    Private xTecleos As List(Of Char)
    Private Const xTextoTarjeta As String = "Escanee su tarjeta de acceso con el lector de códigos de barras."
    Private Const xTextoVale As String = "Escanee el código de barras del vale para ver el detalle."
    Private xVDescarga As clsValidador

    Private Sub frmDescargar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Try
            'If e.KeyChar = Chr(27) Then Me.Escape()
            Me.xTecleos.Add(e.KeyChar)
            Me.xTmr = 0
            Me.tmrTarjeta.Stop()
            Me.tmrTarjeta.Start()
            If xTecleos.Count = 15 Then
                Dim xS As clsSesion = clsSesion.ObtenerInstancia
                'MostrarLoading()
                xS.Iniciar(Me.xTecleos)
                frmPrincipal.BotonesLogin()
                frmPrincipal.CtrlMenu1.MostrarMenu()
                Me.lblCod.Visible = True
                Me.btnVer.Visible = True
                Me.lblAyuda.Text = xTextoVale
                Me.KeyPreview = False
                Me.txtCodigo.Visible = True
                Me.txtCodigo.Enabled = True
                Me.txtCodigo.Focus()
                Me.txtCodigo.SelectAll()
                Me.xTecleos.Clear()
                Me.lblCancelar.Text = "Presione ""Esc"" para cerrar la sesión."
                Me.lblCancelar.Visible = True
                'OcultarLoading()
            End If
        Catch ex As Exception
            'OcultarLoading()
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
            Me.xTecleos.Clear()
            Me.Focus()
        End Try

    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.xTecleos = New List(Of Char)
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Me.pbIncorrecto.Visible = False
        Me.btnDescargado.Visible = False
        Me.Validacion()

        Me.Focus()
        Dim xS As clsSesion = clsSesion.ObtenerInstancia
        If xS.UsuarioLogueado Then
            Me.lblCod.Visible = True
            Me.btnVer.Visible = True
            Me.lblAyuda.Text = xTextoVale
            Me.KeyPreview = False
            Me.txtCodigo.Visible = True
            Me.txtCodigo.Enabled = True
            Me.txtCodigo.Focus()
            Me.txtCodigo.SelectAll()
            Me.xTecleos.Clear()
            Me.lblCancelar.Text = "Presione ""Esc"" para cancelar la descarga."
            Me.lblCancelar.Visible = True
        End If
    End Sub

    Private Sub Validacion()
        Dim valVale As New vVale
        Me.xVDescarga = New clsValidador
        Me.xVDescarga.pdCampos.Add(New clsCampoTexto("Monto", Me.txtDescargado))
        With valVale
            'Me.txtDescargado.Validation = .exDescargado
            'Me.txtDescargado.pdFormatErrorMessage = .msgDescargado
            'Me.txtDescargado.pdRequiredErrorMessage = .msgRDescargad

            Me.ctrlADescargado.pdAyuda = "Valor real descargado (Puede ser inferior o igual al monto del vale). " & .helpDescargado
        End With
    End Sub

    Private Sub MostrarVale()
        'MostrarLoading()
        Try
            xVale = clsVale.ObtenerVale(Me.txtCodigo.Text)
            If xVale.pdID <> "" Then
                Me.pbIncorrecto.Visible = False
                Me.GroupBox1.Visible = True
                Me.btnDescargado.Visible = True
                Me.lblDescargado.Visible = True
                Me.txtDescargado.Visible = True
                Me.ctrlADescargado.Visible = True
                txtCodigo.Focus()
                txtCodigo.SelectAll()
                With xVale
                    Me.lblCancelar.Text = "Presione ""Esc"" para cancelar la descarga."
                    Me.lblCancelar.Visible = True
                    Me.lblCliente.Text = .pdCliente.pdNombreCompleto
                    Me.lblCodigo.Text = .pdID
                    If .pdTipo = enTipoVale.Combustible Then Me.lblMonto.Text = Format(.pdValor, "0.00") & " lts."
                    If .pdTipo = enTipoVale.Combustible Then Me.lblMonto.Text = "$ " & Format(.pdValor, "0.00")
                    Me.txtDescargado.Text = Format(.pdDisponible, "0.00")
                    Me.lblTipo.Text = .pdTipo.ToString

                    Select Case .pdEstado
                        Case enEstadoVale.Activo
                            Me.lblImporte.Text = "Disponible:"
                            Me.lblMonto.Text = CStr(.pdDisponible)
                            Me.pbImagen.Visible = False
                        Case enEstadoVale.Cancelado
                            Me.lblImporte.Text = "Disponible:"
                            Me.lblMonto.Text = CStr(.pdDisponible)
                            Me.pbImagen.Visible = True
                            Me.pbImagen.Image = My.Resources.reportado_copy
                        Case enEstadoVale.Descargado
                            Me.lblImporte.Text = "Monto:"
                            Me.lblMonto.Text = CStr(.pdValor)
                            Me.pbImagen.Visible = True
                            Me.pbImagen.Image = My.Resources.descargado
                        Case enEstadoVale.Vencido
                            Me.lblImporte.Text = "Disponible:"
                            Me.lblMonto.Text = CStr(.pdDisponible)
                            Me.pbImagen.Visible = True
                            Me.pbImagen.Image = My.Resources.vencido
                    End Select
                End With
            Else
                Me.GroupBox1.Visible = False
                Me.pbIncorrecto.Visible = True
                Me.btnDescargado.Visible = False
                Me.lblDescargado.Visible = False
                Me.txtDescargado.Visible = False
                Me.ctrlADescargado.Visible = False
                txtCodigo.Focus()
                txtCodigo.SelectAll()
            End If
            'OcultarLoading()
        Catch ex As Exception
            'OcultarLoading()
            Throw
        End Try
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Try
            Me.CtrlMensaje.pdErrores.Clear()
            Me.CtrlMensaje.pdMensaje = ""
            Me.MostrarVale()
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub btnDescargado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescargado.Click
        Try
            Me.CtrlMensaje.pdErrores.Clear()
            If Me.xVDescarga.Validar Then
                If MsgBox("¿Está seguro que desea descargar este vale?", MsgBoxStyle.YesNo, xTitulo & "Descargar vale") = MsgBoxResult.Yes Then
                    'MostrarLoading()
                    Me.xVale.Descargar(CSng(Me.txtDescargado.Text))
                    'OcultarLoading()
                    CloseAllDataforms()
                    'frmDescargaParcial.Show()
                    frmDescargar.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.Mensaje
                    frmDescargar.CtrlMensaje.pdMensaje = "Decarga Parcial realizada. Escriba el saldo restante del vale en el reverso del mismo y entréguelo al cliente."
                End If
            Else
                Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = xErrorCampo
            End If
        Catch ex As Exception
            'OcultarLoading()
            Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub txtDescargado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescargado.KeyPress
        If e.KeyChar = Chr(27) Then Me.Escape()
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Chr(27) Then Me.Escape()
    End Sub

    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        If txtDescargado.Focused = False And Me.Focused = False Then
            txtCodigo.Focus()
            txtCodigo.SelectAll()
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        If Me.txtCodigo.Text.Length = 9 Then
            Try
                Me.MostrarVale()
                If Me.xVale.pdID <> "" Then
                    Me.btnDescargado.Visible = True
                End If
            Catch ex As Exception
                Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
            End Try
        End If
    End Sub

    Private Sub Escape()
        If Me.GroupBox1.Visible Then
            Me.CerrarVale()
            Me.lblAyuda.Text = xTextoVale
        Else
            Me.Reestablecer()
        End If
    End Sub

    Private Sub CerrarVale()
        Me.lblCancelar.Text = "Presione ""Esc"" para cerrar la sesión."
        Me.lblCancelar.Visible = True
        Me.btnDescargado.Visible = False
        Me.GroupBox1.Visible = False
        Me.txtDescargado.Visible = False
        Me.lblDescargado.Visible = False
        Me.ctrlADescargado.Visible = False
        Me.pbIncorrecto.Visible = False
        Me.txtCodigo.Focus()
    End Sub

    Private Sub Reestablecer()
        Me.CerrarVale()

        Dim xS As clsSesion = clsSesion.ObtenerInstancia
        If xS.pdUsuario.pdTipo <> Entidades.Acceso.enTipoUsuario.Administrador Then
            Me.lblCancelar.Visible = False
            Me.lblCod.Visible = False
            Me.txtCodigo.Visible = False
            Me.btnVer.Visible = False
            Me.txtCodigo.Enabled = False
            Me.Focus()
            Me.KeyPreview = True
            Me.lblAyuda.Text = xTextoTarjeta
            xS.Cerrar()
            frmPrincipal.BotonesLogin()
            frmPrincipal.CtrlMenu1.MostrarMenu()
        End If
    End Sub

    Private Sub tmrTarjeta_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrTarjeta.Tick
        Me.xTmr += 1
        If Me.xTmr >= 1 Then
            Me.xTecleos.Clear()
            Me.xTmr = 0
            Me.tmrTarjeta.Stop()
        End If
    End Sub
End Class