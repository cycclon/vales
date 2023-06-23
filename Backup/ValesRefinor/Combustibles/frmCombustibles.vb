Imports Entidades.Combustibles
Imports ReglasNegocio.Combustibles
Imports Validacion.Combustibles
Imports PRS.Framework.Validacion

Public Class frmCombustibles

    Private xCombustibles As List(Of iCombustible)
    Private xVCombustible As clsValidador

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Combustibles"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Validacion()
        Try

            MostrarCombustibles()
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub Validacion()
        Dim valC As New vCombustible
        Me.xVCombustible = New clsValidador
        Me.xVCombustible.pdCampos.Add(New clsCampoTexto("Nombre", Me.txtNombre))
    End Sub

    Private Sub MostrarCombustibles()
        Try
            MostrarLoading()
            If rdActivos.Checked Then
                Me.xCombustibles = clsCombustible.Listar(enEstadoCombustible.Activo)
            Else
                Me.xCombustibles = clsCombustible.Listar(enEstadoCombustible.Inactivo)
            End If

            OcultarLoading()
            Me.ICombustibleBindingSource.DataSource = xCombustibles
        Catch ex As Exception
            OcultarLoading()
            Throw
        End Try
    End Sub

    Private Sub rdActivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdActivos.CheckedChanged
        Try
            Me.MostrarCombustibles()
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub dgvClientes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCombustibles.SelectionChanged
        Me.dgvCombustibles.ClearSelection()
    End Sub

    Private Sub dgvClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCombustibles.CellContentClick
        Try
            If e.RowIndex <> -1 Then
                Select Case e.ColumnIndex
                    Case 1
                        Eliminar(e.RowIndex)
                    Case 2
                        Restaurar(e.RowIndex)
                End Select
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub Eliminar(ByVal prIndex As Integer)
        Try
            Dim xR As MsgBoxResult = MsgBox("¿Está seguro que desea eliminar el combustible seleccionado?", MsgBoxStyle.YesNo, xTitulo & "Eliminar combustible.")
            If xR = MsgBoxResult.Yes Then
                Me.xCombustibles(prIndex).Eliminar()
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                Me.CtrlMensaje.pdMensaje = "Combustible eliminado correctamente."
                Me.MostrarCombustibles()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Restaurar(ByVal prIndex As Integer)
        Try
            Dim xR As MsgBoxResult = MsgBox("¿Está seguro que desea restaurar el combustible seleccionado?", MsgBoxStyle.YesNo, xTitulo & "Restaurar combustible.")
            If xR = MsgBoxResult.Yes Then
                Me.xCombustibles(prIndex).Restaurar()
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                Me.CtrlMensaje.pdMensaje = "Combustible restaurado correctamente."
                Me.MostrarCombustibles()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Try
            If Me.xVCombustible.Validar Then
                Dim xC As New clsCombustible
                xC.pdNombre = Me.txtNombre.Text
                xC.Registrar()
                Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.Mensaje
                Me.CtrlMensaje.pdMensaje = "Combustible registrado correctamente."
                Me.MostrarCombustibles()
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub
End Class