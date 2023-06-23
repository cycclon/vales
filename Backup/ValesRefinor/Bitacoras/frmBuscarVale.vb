Imports Entidades.Vales
Imports ReglasNegocio.Vales

Public Class frmBuscarVale

    Private xVale As iVale

    Private Sub MostrarVale()

        Try
            xVale = clsVale.ObtenerVale(Me.txtCodigo.Text)
            Me.gbDescarga.Visible = False
            If xVale.pdID <> "" Then
                gbVale.Visible = True
                With xVale
                    Me.lblCliente.Text = .pdCliente.pdNombreCompleto
                    Me.lblCodigo.Text = .pdID
                    If .pdTipo = enTipoVale.Combustible Then Me.lblMonto.Text = Format(.pdValor, "0.00") & " lts."
                    If .pdTipo = enTipoVale.Combustible Then Me.lblMonto.Text = "$ " & Format(.pdValor, "0.00")
                    Me.lblTipo.Text = .pdTipo.ToString
                    Me.lblEstado.Text = .pdEstado.ToString

                    Select Case .pdEstado
                        Case enEstadoVale.Activo
                            Me.lblImporte.Text = "Disponible:"
                            Me.lblMonto.Text = Format(.pdDisponible, "0.00")
                            Me.pbImagen.Visible = False
                        Case enEstadoVale.Cancelado
                            Me.lblImporte.Text = "Disponible:"
                            Me.lblMonto.Text = Format(.pdDisponible, "0.00")
                            Me.pbImagen.Visible = True
                            Me.pbImagen.Image = My.Resources.reportado_copy
                        Case enEstadoVale.Descargado
                            Me.lblImporte.Text = "Monto:"
                            Me.lblMonto.Text = Format(.pdValor, "0.00")
                            Me.pbImagen.Visible = True
                            Me.pbImagen.Image = My.Resources.descargado
                            Me.gbDescarga.Visible = True
                            Me.MostrarDescarga()
                        Case enEstadoVale.Vencido
                            Me.lblImporte.Text = "Disponible:"
                            Me.lblMonto.Text = Format(.pdDisponible, "0.00")
                            Me.pbImagen.Visible = True
                            Me.pbImagen.Image = My.Resources.vencido
                    End Select

                    If .pdTipo = enTipoVale.Combustible Then
                        Me.lblMonto.Text &= " lts."
                    Else
                        Me.lblMonto.Text = Me.lblMonto.Text.Insert(0, "$ ")
                    End If
                End With
            Else
                gbVale.Visible = False
                MsgBox("Vale no encontrado.", MsgBoxStyle.OkOnly, "Buscar vale")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub MostrarDescarga()
        Try
            Me.dgvBitacoras.DataSource = Nothing
            Me.dgvBitacoras.DataSource = xVale.pdDescargas
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub frmBuscarVale_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.MostrarVale()
    End Sub
End Class