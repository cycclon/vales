Imports Entidades.Vales
Imports ReglasNegocio.Vales
Imports Validacion.Vales
Imports Acceso

Public Class frmDescargar
    Private xTmr As Integer = 0
    Private WithEvents xVale As iVale
    Private xParcial As Boolean = False
    Private xTecleos As List(Of Char)
    Private Const xTextoTarjeta As String = "Escanee su tarjeta de acceso con el lector de códigos de barras."
    Private Const xTextoVale As String = "Escanee el código de barras del vale para ver el detalle."
    Private xVales As List(Of iVale)

    Private Sub frmDescargar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Try
            'If e.KeyChar = Chr(27) Then Me.Escape()
            Me.xTecleos.Add(e.KeyChar)
            Me.xTmr = 0
            Me.tmrTarjeta.Stop()
            Me.tmrTarjeta.Start()
            If xTecleos.Count = 15 Then
                Dim xS As clsSesion = clsSesion.ObtenerInstancia

                xS.Iniciar(Me.xTecleos)
                Me.LimpiarVales()
                Me.lstVales.Visible = True
                frmPrincipal.BotonesLogin()
                frmPrincipal.CtrlMenu1.MostrarMenu()
                Me.lblCod.Visible = True
                Me.btnVer.Visible = True
                Me.lblSubTotal.Visible = True
                Me.lblTTotal.Visible = True
                Me.lblAyuda.Text = xTextoVale
                Me.KeyPreview = False
                Me.txtCodigo.Visible = True
                Me.txtCodigo.Enabled = True
                Me.txtCodigo.Focus()
                Me.txtCodigo.SelectAll()
                Me.xTecleos.Clear()
                Me.lblCancelar.Text = "Presione ""Esc"" para cerrar la sesión."
                Me.lblCancelar.Visible = True

            End If
        Catch ex As Exception

            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
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
        Me.xVales = New List(Of iVale)

        Me.Focus()
        Dim xS As clsSesion = clsSesion.ObtenerInstancia
        If xS.UsuarioLogueado Then
            Me.lblTTotal.Visible = True
            Me.lblSubTotal.Visible = True
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
        End If
    End Sub

    Private Sub MostrarVale()

        Try
            xVale = clsVale.ObtenerVale(Me.txtCodigo.Text)
            If xVale.pdID <> "" Then
                Me.pbIncorrecto.Visible = False
                Me.GroupBox1.Visible = True
                Me.btnDescargado.Visible = True
                txtCodigo.Focus()
                txtCodigo.SelectAll()
                With xVale
                    Me.lblCancelar.Text = "Presione ""Esc"" para cancelar la descarga."
                    Me.lblCancelar.Visible = True
                    Me.lblCliente.Text = .pdCliente.pdNombreCompleto
                    Me.lblCodigo.Text = .pdID
                    If .pdTipo = enTipoVale.Combustible Then Me.lblMonto.Text = Format(.pdValor, "0.00") & " lts."
                    If .pdTipo = enTipoVale.Combustible Then Me.lblMonto.Text = "$ " & Format(.pdValor, "0.00")
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
                txtCodigo.Focus()
                txtCodigo.SelectAll()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Try
            Me.CtrlMensaje.pdErrores.Clear()
            Me.CtrlMensaje.pdMensaje = ""
            Me.MostrarVale()
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub LimpiarVales()
        Me.lstVales.Items.Clear()
        Me.xVales.Clear()
        Me.lstVales.Visible = True
    End Sub

    Private Sub btnDescargado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescargado.Click
        Try
            Me.xParcial = False
            Me.CtrlMensaje.pdErrores.Clear()

            'If MsgBox("¿Está seguro que desea descargar estos vale?", MsgBoxStyle.YesNo, xTitulo & "Descargar vale") = MsgBoxResult.Yes Then
            MostrarLoading()
            For Each xx As iVale In Me.xVales
                xx.Descargar(xx.pdDisponible)
            Next
            OcultarLoading()
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
            Me.CtrlMensaje.pdMensaje = "Se descargaron " & Me.xVales.Count & " vales correctamente."

            Me.CerrarListado()

            Me.SubTotal()
            'Me.MostrarVale()
            'If Not Me.xParcial Then
            '    Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
            '    Me.CtrlMensaje.pdMensaje = "Vale descargado correctamente. No devuelva el vale al cliente ya que este no podrá ser descargado nuevamenete."
            '    Me.CerrarVale()
            'End If

            'End If

        Catch ex As Exception
            OcultarLoading()
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Chr(27) Then Me.Escape()
    End Sub

    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        If Me.Focused = False Then
            txtCodigo.Focus()
            txtCodigo.SelectAll()
        End If
    End Sub

    Private Function ComprobarLista(ByVal prVale As iVale) As Boolean
        Dim xF As Boolean = False
        For Each xx As iVale In xVales
            If xx.pdID = prVale.pdID Then
                xF = True
                Exit For
            End If
        Next
        Return xF
    End Function

    Private Sub SubTotal()
        Dim xTotal As Single = 0
        For Each xx As iVale In xVales
            xTotal += xx.pdDisponible
        Next
        Me.lblSubTotal.Text = "$" & Format(xTotal, "0.00")
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        If Me.txtCodigo.Text.Length = 9 Then
            Try
                Me.MostrarVale()
                If Me.xVale.pdEstado = enEstadoVale.Activo And Me.xVale.pdID <> "" Then
                    If Not ComprobarLista(Me.xVale) Then Me.xVales.Add(xVale)
                    'REPRODUCIR SONIDO DE OK
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                Else
                    'REPRODUCIR SONIDO DE ERROR
                    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                End If
                If Me.xVales.Count <> 0 Then
                    Me.MostrarListado()
                    Me.btnDescargado.Visible = True

                Else
                    Me.btnDescargado.Visible = False
                    Me.lstVales.Items.Add("Escanee un vale para agregarlo a la lista")
                End If
            Catch ex As Exception
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
                Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
            End Try
        End If
    End Sub

    Private Sub MostrarListado()
        Me.lstVales.Visible = True
        Me.lstVales.Items.Clear()
        For Each xx As iVale In Me.xVales
            Me.lstVales.Items.Add(xx.ToString)
        Next
        Me.SubTotal()
    End Sub

    Private Sub Escape()
        If Me.lstVales.Visible Then
            Me.CerrarVale()
            Me.lblAyuda.Text = xTextoVale
        Else
            Me.Reestablecer()
        End If
    End Sub

    Private Sub CerrarVale()
        If Me.xVales.Count <> 0 Then
            If MsgBox("¿Está seguro que desea cancelar la descarga de los vales de la lista?", MsgBoxStyle.YesNo, xTitulo & "Descargar") = MsgBoxResult.Yes Then
                Me.CerrarListado()
            End If
        Else
            Me.CerrarListado()
        End If
    End Sub

    Private Sub CerrarListado()
        Me.LimpiarVales()
        Me.lstVales.Visible = False
        Me.lblCancelar.Text = "Presione ""Esc"" para cerrar la sesión."
        Me.lblCancelar.Visible = True
        Me.btnDescargado.Visible = False
        Me.GroupBox1.Visible = False
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
            Me.lblSubTotal.Visible = False
            Me.lblTTotal.Visible = False
            Me.lblSubTotal.Text = "$0"
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