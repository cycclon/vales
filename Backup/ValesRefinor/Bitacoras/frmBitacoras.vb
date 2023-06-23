Imports Entidades.Clientes
Imports Entidades.Acceso
Imports Acceso
Imports ReglasNegocio.Clientes
Imports Bitacoras
Imports Entidades.Bitacoras
Imports PRS.Framework.Validacion

Public Class frmBitacoras

    Private xClientes As List(Of iCliente)
    Private xFiltros As List(Of iFiltroBitacora)
    Private xUsuariosA As List(Of iUsuario)
    Private xUsuariosI As List(Of iUsuario)
    Private xVBitacoras As clsValidador

    Private Sub MostrarUsuarios()
        Try
            xUsuariosA = clsUsuario.Listar(enEstadoUsuario.Activo)
            xUsuariosI = clsUsuario.Listar(enEstadoUsuario.Inactivo)

            Me.cmbUsuario.Items.Clear()
            Me.cmbUsuario.Items.Add("Todos")
            For Each xx As iUsuario In xUsuariosA
                Me.cmbUsuario.Items.Add(xx.pdNombreCompleto)
            Next
            For Each xx As iUsuario In xUsuariosI
                Me.cmbUsuario.Items.Add(xx.pdNombreCompleto)
            Next
            Me.cmbUsuario.SelectedIndex = 0
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub MostrarBitacoras()
        Try
            Me.EstablecerFiltros()
            Me.IBitacoraBindingSource.DataSource = clsBitacora.Listar(Me.xFiltros)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub MostrarTipos()
        Me.cmbTipo.Items.Clear()
        Me.cmbTipo.Items.Add("Todas")

        For Each xx As enTipoBitacora In System.Enum.GetValues(GetType(enTipoBitacora))
            Me.cmbTipo.Items.Add(xx.ToString)
        Next
        Me.cmbTipo.SelectedIndex = 0
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = xTitulo & "Bitácoras"
        Me.MdiParent = frmPrincipal
        Me.Dock = DockStyle.Fill
        Try
            Me.MostrarUsuarios()
            Me.MostrarTipos()
            Me.MostrarBitacoras()
            Me.Validacion()
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub Validacion()
        Me.xVBitacoras = New clsValidador
        Me.xVBitacoras.pdCampos.Add(New clsCampoCombo("Usuario", Me.cmbUsuario, 0))
        Me.xVBitacoras.pdCampos.Add(New clsCampoCombo("Tipo de bitácora", Me.cmbTipo, 0))
    End Sub

    Private Sub dgvClientes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvBitacoras.SelectionChanged
        Me.dgvBitacoras.ClearSelection()
    End Sub

    Private Sub rdFActivar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdFActivar.CheckedChanged
        Me.lblEntre.Visible = rdFActivar.Checked
        Me.lblY.Visible = rdFActivar.Checked
        Me.dtpEntre.Visible = rdFActivar.Checked
        Me.dtpHasta.Visible = rdFActivar.Checked
    End Sub

    Private Sub dtpEntre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEntre.ValueChanged
        If dtpEntre.Value > Date.Now Then dtpEntre.Value = Date.Now
    End Sub

    Private Sub dtpHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHasta.ValueChanged
        If dtpHasta.Value > Date.Now Then dtpHasta.Value = Date.Now
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Try
            If Me.xVBitacoras.Validar Then
                Me.MostrarBitacoras()
            End If
        Catch ex As Exception
            Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
            Me.CtrlMensaje.pdMensaje = ManejarExcepcion(ex, Me.Text)
        End Try
    End Sub

    Private Sub EstablecerFiltros()
        Me.xFiltros = New List(Of iFiltroBitacora)
        If Me.cmbTipo.SelectedIndex > 0 Then
            xFiltros.Add(New clsFTipo(CType(System.Enum.Parse(GetType(enTipoBitacora), CStr(Me.cmbTipo.SelectedItem)), enTipoBitacora)))
        End If
        If Me.cmbUsuario.SelectedIndex > 0 Then
            If Me.cmbUsuario.SelectedIndex > xUsuariosA.Count Then
                xFiltros.Add(New clsFUsuario(xUsuariosI(Me.cmbUsuario.SelectedIndex - 1).pdUsername))
            Else
                xFiltros.Add(New clsFUsuario(xUsuariosA(Me.cmbUsuario.SelectedIndex - 1).pdUsername))
            End If
        End If
        If Me.rdFActivar.Checked Then
            xFiltros.Add(New clsFFecha(Me.dtpEntre.Value, Me.dtpHasta.Value))
        End If
    End Sub
End Class