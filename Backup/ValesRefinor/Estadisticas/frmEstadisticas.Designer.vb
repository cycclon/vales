<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadisticas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadisticas))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnFiltrar = New System.Windows.Forms.Button
        Me.cmbSemana = New System.Windows.Forms.ComboBox
        Me.cmbMes = New System.Windows.Forms.ComboBox
        Me.lblSemana = New System.Windows.Forms.Label
        Me.lblMes = New System.Windows.Forms.Label
        Me.lblAño = New System.Windows.Forms.Label
        Me.cmbAño = New System.Windows.Forms.ComboBox
        Me.rdFiltro = New System.Windows.Forms.RadioButton
        Me.rdHistorico = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblLitros = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblDinero = New System.Windows.Forms.Label
        Me.lblDescargas = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgvDescargas = New System.Windows.Forms.DataGridView
        Me.PdFechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pdTipoVale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdMontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDescargaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tcEstadisticas = New System.Windows.Forms.TabControl
        Me.tpDescargas = New System.Windows.Forms.TabPage
        Me.tpEmisiones = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.lblLitrosEmitidos = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblMontoEmitido = New System.Windows.Forms.Label
        Me.lblEmisiones = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dgvEmisiones = New System.Windows.Forms.DataGridView
        Me.PdFechaEmisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdNombreClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdTipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ISerieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnFiltrarEmisiones = New System.Windows.Forms.Button
        Me.cmbSemanEmisiones = New System.Windows.Forms.ComboBox
        Me.cmbMesEmisiones = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbAñoEmisiones = New System.Windows.Forms.ComboBox
        Me.rdFiltroEmisiones = New System.Windows.Forms.RadioButton
        Me.rdHistoricoEmisiones = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.CtrlMensaje = New ValesRefinor.ctrlMensaje
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDescargas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDescargaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcEstadisticas.SuspendLayout()
        Me.tpDescargas.SuspendLayout()
        Me.tpEmisiones.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvEmisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISerieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ValesRefinor.My.Resources.Resources.Cuerpo
        Me.PictureBox1.Location = New System.Drawing.Point(657, 392)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFiltrar)
        Me.GroupBox1.Controls.Add(Me.cmbSemana)
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.lblSemana)
        Me.GroupBox1.Controls.Add(Me.lblMes)
        Me.GroupBox1.Controls.Add(Me.lblAño)
        Me.GroupBox1.Controls.Add(Me.cmbAño)
        Me.GroupBox1.Controls.Add(Me.rdFiltro)
        Me.GroupBox1.Controls.Add(Me.rdHistorico)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(100, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(633, 103)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTRO"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnFiltrar.Location = New System.Drawing.Point(553, 52)
        Me.btnFiltrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(65, 30)
        Me.btnFiltrar.TabIndex = 8
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'cmbSemana
        '
        Me.cmbSemana.Enabled = False
        Me.cmbSemana.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSemana.ForeColor = System.Drawing.Color.Black
        Me.cmbSemana.FormattingEnabled = True
        Me.cmbSemana.Location = New System.Drawing.Point(445, 55)
        Me.cmbSemana.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbSemana.Name = "cmbSemana"
        Me.cmbSemana.Size = New System.Drawing.Size(102, 25)
        Me.cmbSemana.TabIndex = 7
        '
        'cmbMes
        '
        Me.cmbMes.Enabled = False
        Me.cmbMes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMes.ForeColor = System.Drawing.Color.Black
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Items.AddRange(New Object() {"--Mes--", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbMes.Location = New System.Drawing.Point(263, 55)
        Me.cmbMes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(105, 25)
        Me.cmbMes.TabIndex = 6
        '
        'lblSemana
        '
        Me.lblSemana.AutoSize = True
        Me.lblSemana.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemana.ForeColor = System.Drawing.Color.DimGray
        Me.lblSemana.Location = New System.Drawing.Point(374, 59)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(65, 17)
        Me.lblSemana.TabIndex = 5
        Me.lblSemana.Text = "Semana:"
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.ForeColor = System.Drawing.Color.DimGray
        Me.lblMes.Location = New System.Drawing.Point(221, 59)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(36, 17)
        Me.lblMes.TabIndex = 4
        Me.lblMes.Text = "Mes:"
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAño.ForeColor = System.Drawing.Color.DimGray
        Me.lblAño.Location = New System.Drawing.Point(103, 58)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(38, 17)
        Me.lblAño.TabIndex = 3
        Me.lblAño.Text = "Año:"
        '
        'cmbAño
        '
        Me.cmbAño.Enabled = False
        Me.cmbAño.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAño.ForeColor = System.Drawing.Color.Black
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(147, 55)
        Me.cmbAño.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(68, 25)
        Me.cmbAño.TabIndex = 2
        '
        'rdFiltro
        '
        Me.rdFiltro.AutoSize = True
        Me.rdFiltro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFiltro.ForeColor = System.Drawing.Color.Indigo
        Me.rdFiltro.Location = New System.Drawing.Point(7, 56)
        Me.rdFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdFiltro.Name = "rdFiltro"
        Me.rdFiltro.Size = New System.Drawing.Size(90, 21)
        Me.rdFiltro.TabIndex = 1
        Me.rdFiltro.Text = "Filtrar por:"
        Me.rdFiltro.UseVisualStyleBackColor = True
        '
        'rdHistorico
        '
        Me.rdHistorico.AutoSize = True
        Me.rdHistorico.Checked = True
        Me.rdHistorico.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdHistorico.ForeColor = System.Drawing.Color.Indigo
        Me.rdHistorico.Location = New System.Drawing.Point(7, 26)
        Me.rdHistorico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdHistorico.Name = "rdHistorico"
        Me.rdHistorico.Size = New System.Drawing.Size(81, 21)
        Me.rdHistorico.TabIndex = 0
        Me.rdHistorico.TabStop = True
        Me.rdHistorico.Text = "Histórico"
        Me.rdHistorico.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblLitros)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblDinero)
        Me.GroupBox3.Controls.Add(Me.lblDescargas)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox3.Location = New System.Drawing.Point(52, 118)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(729, 54)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESUMEN"
        '
        'lblLitros
        '
        Me.lblLitros.AutoSize = True
        Me.lblLitros.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitros.ForeColor = System.Drawing.Color.Indigo
        Me.lblLitros.Location = New System.Drawing.Point(667, 22)
        Me.lblLitros.Name = "lblLitros"
        Me.lblLitros.Size = New System.Drawing.Size(15, 17)
        Me.lblLitros.TabIndex = 25
        Me.lblLitros.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(529, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Litros descargados:"
        '
        'lblDinero
        '
        Me.lblDinero.AutoSize = True
        Me.lblDinero.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinero.ForeColor = System.Drawing.Color.Indigo
        Me.lblDinero.Location = New System.Drawing.Point(402, 22)
        Me.lblDinero.Name = "lblDinero"
        Me.lblDinero.Size = New System.Drawing.Size(15, 17)
        Me.lblDinero.TabIndex = 23
        Me.lblDinero.Text = "0"
        '
        'lblDescargas
        '
        Me.lblDescargas.AutoSize = True
        Me.lblDescargas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescargas.ForeColor = System.Drawing.Color.Indigo
        Me.lblDescargas.Location = New System.Drawing.Point(128, 22)
        Me.lblDescargas.Name = "lblDescargas"
        Me.lblDescargas.Size = New System.Drawing.Size(15, 17)
        Me.lblDescargas.TabIndex = 22
        Me.lblDescargas.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(259, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 17)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Monto descargado:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(43, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 17)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Descargas:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvDescargas)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(6, 180)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(821, 329)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DESCARGAS EFECTUADAS"
        '
        'dgvDescargas
        '
        Me.dgvDescargas.AllowUserToAddRows = False
        Me.dgvDescargas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgvDescargas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDescargas.AutoGenerateColumns = False
        Me.dgvDescargas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDescargas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDescargas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDescargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDescargas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PdFechaDataGridViewTextBoxColumn, Me.pdTipoVale, Me.pdUsuario, Me.PdMontoDataGridViewTextBoxColumn})
        Me.dgvDescargas.DataSource = Me.IDescargaBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDescargas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDescargas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDescargas.Location = New System.Drawing.Point(3, 24)
        Me.dgvDescargas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvDescargas.Name = "dgvDescargas"
        Me.dgvDescargas.ReadOnly = True
        Me.dgvDescargas.RowHeadersVisible = False
        Me.dgvDescargas.Size = New System.Drawing.Size(815, 301)
        Me.dgvDescargas.TabIndex = 14
        '
        'PdFechaDataGridViewTextBoxColumn
        '
        Me.PdFechaDataGridViewTextBoxColumn.DataPropertyName = "pdFecha"
        Me.PdFechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.PdFechaDataGridViewTextBoxColumn.Name = "PdFechaDataGridViewTextBoxColumn"
        Me.PdFechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdFechaDataGridViewTextBoxColumn.Width = 175
        '
        'pdTipoVale
        '
        Me.pdTipoVale.DataPropertyName = "pdTipoVale"
        Me.pdTipoVale.HeaderText = "Tipo"
        Me.pdTipoVale.Name = "pdTipoVale"
        Me.pdTipoVale.ReadOnly = True
        Me.pdTipoVale.Width = 75
        '
        'pdUsuario
        '
        Me.pdUsuario.DataPropertyName = "pdUsuario"
        Me.pdUsuario.HeaderText = "Usuario"
        Me.pdUsuario.Name = "pdUsuario"
        Me.pdUsuario.ReadOnly = True
        Me.pdUsuario.Width = 180
        '
        'PdMontoDataGridViewTextBoxColumn
        '
        Me.PdMontoDataGridViewTextBoxColumn.DataPropertyName = "pdMonto"
        Me.PdMontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.PdMontoDataGridViewTextBoxColumn.Name = "PdMontoDataGridViewTextBoxColumn"
        Me.PdMontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdMontoDataGridViewTextBoxColumn.Width = 75
        '
        'IDescargaBindingSource
        '
        Me.IDescargaBindingSource.DataSource = GetType(Entidades.Vales.iDescarga)
        '
        'tcEstadisticas
        '
        Me.tcEstadisticas.Controls.Add(Me.tpDescargas)
        Me.tcEstadisticas.Controls.Add(Me.tpEmisiones)
        Me.tcEstadisticas.Location = New System.Drawing.Point(17, 70)
        Me.tcEstadisticas.Name = "tcEstadisticas"
        Me.tcEstadisticas.SelectedIndex = 0
        Me.tcEstadisticas.Size = New System.Drawing.Size(841, 546)
        Me.tcEstadisticas.TabIndex = 25
        '
        'tpDescargas
        '
        Me.tpDescargas.Controls.Add(Me.GroupBox2)
        Me.tpDescargas.Controls.Add(Me.GroupBox3)
        Me.tpDescargas.Controls.Add(Me.GroupBox1)
        Me.tpDescargas.Location = New System.Drawing.Point(4, 26)
        Me.tpDescargas.Name = "tpDescargas"
        Me.tpDescargas.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDescargas.Size = New System.Drawing.Size(833, 516)
        Me.tpDescargas.TabIndex = 0
        Me.tpDescargas.Text = "Descargas"
        Me.tpDescargas.UseVisualStyleBackColor = True
        '
        'tpEmisiones
        '
        Me.tpEmisiones.Controls.Add(Me.GroupBox6)
        Me.tpEmisiones.Controls.Add(Me.GroupBox4)
        Me.tpEmisiones.Controls.Add(Me.GroupBox5)
        Me.tpEmisiones.Location = New System.Drawing.Point(4, 26)
        Me.tpEmisiones.Name = "tpEmisiones"
        Me.tpEmisiones.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEmisiones.Size = New System.Drawing.Size(833, 516)
        Me.tpEmisiones.TabIndex = 1
        Me.tpEmisiones.Text = "Emisiones"
        Me.tpEmisiones.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblLitrosEmitidos)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.lblMontoEmitido)
        Me.GroupBox6.Controls.Add(Me.lblEmisiones)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox6.Location = New System.Drawing.Point(52, 118)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(729, 54)
        Me.GroupBox6.TabIndex = 26
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "RESUMEN:"
        '
        'lblLitrosEmitidos
        '
        Me.lblLitrosEmitidos.AutoSize = True
        Me.lblLitrosEmitidos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitrosEmitidos.ForeColor = System.Drawing.Color.Indigo
        Me.lblLitrosEmitidos.Location = New System.Drawing.Point(667, 22)
        Me.lblLitrosEmitidos.Name = "lblLitrosEmitidos"
        Me.lblLitrosEmitidos.Size = New System.Drawing.Size(15, 17)
        Me.lblLitrosEmitidos.TabIndex = 25
        Me.lblLitrosEmitidos.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(559, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 17)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Litros Emitidos:"
        '
        'lblMontoEmitido
        '
        Me.lblMontoEmitido.AutoSize = True
        Me.lblMontoEmitido.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoEmitido.ForeColor = System.Drawing.Color.Indigo
        Me.lblMontoEmitido.Location = New System.Drawing.Point(402, 22)
        Me.lblMontoEmitido.Name = "lblMontoEmitido"
        Me.lblMontoEmitido.Size = New System.Drawing.Size(15, 17)
        Me.lblMontoEmitido.TabIndex = 23
        Me.lblMontoEmitido.Text = "0"
        '
        'lblEmisiones
        '
        Me.lblEmisiones.AutoSize = True
        Me.lblEmisiones.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmisiones.ForeColor = System.Drawing.Color.Indigo
        Me.lblEmisiones.Location = New System.Drawing.Point(128, 22)
        Me.lblEmisiones.Name = "lblEmisiones"
        Me.lblEmisiones.Size = New System.Drawing.Size(15, 17)
        Me.lblEmisiones.TabIndex = 22
        Me.lblEmisiones.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(289, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 17)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Monto Emitido:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(49, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 17)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Emisiones:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvEmisiones)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox4.Location = New System.Drawing.Point(6, 180)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(821, 329)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SERIES EMITIDAS"
        '
        'dgvEmisiones
        '
        Me.dgvEmisiones.AllowUserToAddRows = False
        Me.dgvEmisiones.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgvEmisiones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEmisiones.AutoGenerateColumns = False
        Me.dgvEmisiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEmisiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmisiones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvEmisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmisiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PdFechaEmisionDataGridViewTextBoxColumn, Me.PdNombreClienteDataGridViewTextBoxColumn, Me.PdTotalDataGridViewTextBoxColumn, Me.PdTipoDataGridViewTextBoxColumn})
        Me.dgvEmisiones.DataSource = Me.ISerieBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmisiones.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvEmisiones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmisiones.Location = New System.Drawing.Point(3, 24)
        Me.dgvEmisiones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvEmisiones.Name = "dgvEmisiones"
        Me.dgvEmisiones.ReadOnly = True
        Me.dgvEmisiones.RowHeadersVisible = False
        Me.dgvEmisiones.Size = New System.Drawing.Size(815, 301)
        Me.dgvEmisiones.TabIndex = 14
        '
        'PdFechaEmisionDataGridViewTextBoxColumn
        '
        Me.PdFechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "pdFechaEmision"
        Me.PdFechaEmisionDataGridViewTextBoxColumn.HeaderText = "Fecha emisión"
        Me.PdFechaEmisionDataGridViewTextBoxColumn.Name = "PdFechaEmisionDataGridViewTextBoxColumn"
        Me.PdFechaEmisionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdFechaEmisionDataGridViewTextBoxColumn.Width = 200
        '
        'PdNombreClienteDataGridViewTextBoxColumn
        '
        Me.PdNombreClienteDataGridViewTextBoxColumn.DataPropertyName = "pdNombreCliente"
        Me.PdNombreClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.PdNombreClienteDataGridViewTextBoxColumn.Name = "PdNombreClienteDataGridViewTextBoxColumn"
        Me.PdNombreClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdNombreClienteDataGridViewTextBoxColumn.Width = 250
        '
        'PdTotalDataGridViewTextBoxColumn
        '
        Me.PdTotalDataGridViewTextBoxColumn.DataPropertyName = "pdTotal"
        Me.PdTotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.PdTotalDataGridViewTextBoxColumn.Name = "PdTotalDataGridViewTextBoxColumn"
        Me.PdTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PdTipoDataGridViewTextBoxColumn
        '
        Me.PdTipoDataGridViewTextBoxColumn.DataPropertyName = "pdTipo"
        Me.PdTipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.PdTipoDataGridViewTextBoxColumn.Name = "PdTipoDataGridViewTextBoxColumn"
        Me.PdTipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdTipoDataGridViewTextBoxColumn.Width = 120
        '
        'ISerieBindingSource
        '
        Me.ISerieBindingSource.DataSource = GetType(Entidades.Vales.iSerie)
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnFiltrarEmisiones)
        Me.GroupBox5.Controls.Add(Me.cmbSemanEmisiones)
        Me.GroupBox5.Controls.Add(Me.cmbMesEmisiones)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.cmbAñoEmisiones)
        Me.GroupBox5.Controls.Add(Me.rdFiltroEmisiones)
        Me.GroupBox5.Controls.Add(Me.rdHistoricoEmisiones)
        Me.GroupBox5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox5.Location = New System.Drawing.Point(100, 7)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(633, 103)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "FILTRO"
        '
        'btnFiltrarEmisiones
        '
        Me.btnFiltrarEmisiones.BackColor = System.Drawing.Color.Transparent
        Me.btnFiltrarEmisiones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrarEmisiones.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnFiltrarEmisiones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnFiltrarEmisiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnFiltrarEmisiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrarEmisiones.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrarEmisiones.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnFiltrarEmisiones.Location = New System.Drawing.Point(553, 52)
        Me.btnFiltrarEmisiones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFiltrarEmisiones.Name = "btnFiltrarEmisiones"
        Me.btnFiltrarEmisiones.Size = New System.Drawing.Size(65, 30)
        Me.btnFiltrarEmisiones.TabIndex = 8
        Me.btnFiltrarEmisiones.Text = "Filtrar"
        Me.btnFiltrarEmisiones.UseVisualStyleBackColor = False
        '
        'cmbSemanEmisiones
        '
        Me.cmbSemanEmisiones.Enabled = False
        Me.cmbSemanEmisiones.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSemanEmisiones.ForeColor = System.Drawing.Color.Black
        Me.cmbSemanEmisiones.FormattingEnabled = True
        Me.cmbSemanEmisiones.Location = New System.Drawing.Point(445, 55)
        Me.cmbSemanEmisiones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbSemanEmisiones.Name = "cmbSemanEmisiones"
        Me.cmbSemanEmisiones.Size = New System.Drawing.Size(102, 25)
        Me.cmbSemanEmisiones.TabIndex = 7
        '
        'cmbMesEmisiones
        '
        Me.cmbMesEmisiones.Enabled = False
        Me.cmbMesEmisiones.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMesEmisiones.ForeColor = System.Drawing.Color.Black
        Me.cmbMesEmisiones.FormattingEnabled = True
        Me.cmbMesEmisiones.Items.AddRange(New Object() {"--Mes--", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbMesEmisiones.Location = New System.Drawing.Point(263, 55)
        Me.cmbMesEmisiones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbMesEmisiones.Name = "cmbMesEmisiones"
        Me.cmbMesEmisiones.Size = New System.Drawing.Size(105, 25)
        Me.cmbMesEmisiones.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(374, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Semana:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(221, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(103, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Año:"
        '
        'cmbAñoEmisiones
        '
        Me.cmbAñoEmisiones.Enabled = False
        Me.cmbAñoEmisiones.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAñoEmisiones.ForeColor = System.Drawing.Color.Black
        Me.cmbAñoEmisiones.FormattingEnabled = True
        Me.cmbAñoEmisiones.Location = New System.Drawing.Point(147, 55)
        Me.cmbAñoEmisiones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbAñoEmisiones.Name = "cmbAñoEmisiones"
        Me.cmbAñoEmisiones.Size = New System.Drawing.Size(68, 25)
        Me.cmbAñoEmisiones.TabIndex = 2
        '
        'rdFiltroEmisiones
        '
        Me.rdFiltroEmisiones.AutoSize = True
        Me.rdFiltroEmisiones.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFiltroEmisiones.ForeColor = System.Drawing.Color.Indigo
        Me.rdFiltroEmisiones.Location = New System.Drawing.Point(7, 56)
        Me.rdFiltroEmisiones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdFiltroEmisiones.Name = "rdFiltroEmisiones"
        Me.rdFiltroEmisiones.Size = New System.Drawing.Size(90, 21)
        Me.rdFiltroEmisiones.TabIndex = 1
        Me.rdFiltroEmisiones.Text = "Filtrar por:"
        Me.rdFiltroEmisiones.UseVisualStyleBackColor = True
        '
        'rdHistoricoEmisiones
        '
        Me.rdHistoricoEmisiones.AutoSize = True
        Me.rdHistoricoEmisiones.Checked = True
        Me.rdHistoricoEmisiones.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdHistoricoEmisiones.ForeColor = System.Drawing.Color.Indigo
        Me.rdHistoricoEmisiones.Location = New System.Drawing.Point(7, 26)
        Me.rdHistoricoEmisiones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdHistoricoEmisiones.Name = "rdHistoricoEmisiones"
        Me.rdHistoricoEmisiones.Size = New System.Drawing.Size(81, 21)
        Me.rdHistoricoEmisiones.TabIndex = 0
        Me.rdHistoricoEmisiones.TabStop = True
        Me.rdHistoricoEmisiones.Text = "Histórico"
        Me.rdHistoricoEmisiones.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(667, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(529, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Litros descargados:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(402, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(128, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(259, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Monto descargado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(43, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Descargas:"
        '
        'CtrlMensaje
        '
        Me.CtrlMensaje.BackColor = System.Drawing.Color.Transparent
        Me.CtrlMensaje.Location = New System.Drawing.Point(12, 13)
        Me.CtrlMensaje.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CtrlMensaje.Name = "CtrlMensaje"
        Me.CtrlMensaje.pdErrores = CType(resources.GetObject("CtrlMensaje.pdErrores"), System.Collections.Generic.List(Of String))
        Me.CtrlMensaje.pdMensaje = ""
        Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
        Me.CtrlMensaje.Size = New System.Drawing.Size(846, 50)
        Me.CtrlMensaje.TabIndex = 10
        '
        'frmEstadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.tcEstadisticas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmEstadisticas"
        Me.Text = "frmEstadisticas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDescargas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDescargaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcEstadisticas.ResumeLayout(False)
        Me.tpDescargas.ResumeLayout(False)
        Me.tpEmisiones.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvEmisiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISerieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrlMensaje As ValesRefinor.ctrlMensaje
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdFiltro As System.Windows.Forms.RadioButton
    Friend WithEvents rdHistorico As System.Windows.Forms.RadioButton
    Friend WithEvents lblAño As System.Windows.Forms.Label
    Friend WithEvents cmbAño As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents lblSemana As System.Windows.Forms.Label
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents cmbSemana As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLitros As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblDinero As System.Windows.Forms.Label
    Friend WithEvents lblDescargas As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDescargas As System.Windows.Forms.DataGridView
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents IDescargaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PdFechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pdTipoVale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pdUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdMontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tcEstadisticas As System.Windows.Forms.TabControl
    Friend WithEvents tpDescargas As System.Windows.Forms.TabPage
    Friend WithEvents tpEmisiones As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvEmisiones As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFiltrarEmisiones As System.Windows.Forms.Button
    Friend WithEvents cmbSemanEmisiones As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMesEmisiones As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbAñoEmisiones As System.Windows.Forms.ComboBox
    Friend WithEvents rdFiltroEmisiones As System.Windows.Forms.RadioButton
    Friend WithEvents rdHistoricoEmisiones As System.Windows.Forms.RadioButton
    Friend WithEvents ISerieBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLitrosEmitidos As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblMontoEmitido As System.Windows.Forms.Label
    Friend WithEvents lblEmisiones As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PdFechaEmisionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdNombreClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdTipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
