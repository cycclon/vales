<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTurnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTurnos))
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDia = New System.Windows.Forms.DateTimePicker
        Me.lstTurnos = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvDescargas = New System.Windows.Forms.DataGridView
        Me.PdMontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pdTipoVale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDescargaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnImprimirTurno = New System.Windows.Forms.Button
        Me.lblLitrosTurno = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblDineroTurno = New System.Windows.Forms.Label
        Me.lblDescargasTurno = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.btnImprimirDia = New System.Windows.Forms.Button
        Me.lblLitrosDia = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblDineroDia = New System.Windows.Forms.Label
        Me.lblDescargasDia = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CtrlInformacion1 = New ValesRefinor.ctrlInformacion
        Me.CtrlMensaje = New ValesRefinor.ctrlMensaje
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDescargas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDescargaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(189, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Seleccionar día de trabajo:"
        '
        'dtpDia
        '
        Me.dtpDia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDia.Location = New System.Drawing.Point(381, 71)
        Me.dtpDia.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDia.Name = "dtpDia"
        Me.dtpDia.Size = New System.Drawing.Size(300, 23)
        Me.dtpDia.TabIndex = 17
        '
        'lstTurnos
        '
        Me.lstTurnos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTurnos.FormattingEnabled = True
        Me.lstTurnos.ItemHeight = 17
        Me.lstTurnos.Location = New System.Drawing.Point(13, 231)
        Me.lstTurnos.Margin = New System.Windows.Forms.Padding(4)
        Me.lstTurnos.Name = "lstTurnos"
        Me.lstTurnos.Size = New System.Drawing.Size(279, 123)
        Me.lstTurnos.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(13, 210)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Turnos del día:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvDescargas)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(301, 178)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(556, 377)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DESCARGAS EFECTUADAS"
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
        Me.dgvDescargas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PdMontoDataGridViewTextBoxColumn, Me.pdTipoVale, Me.pdUsuario})
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
        Me.dgvDescargas.Location = New System.Drawing.Point(4, 24)
        Me.dgvDescargas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDescargas.Name = "dgvDescargas"
        Me.dgvDescargas.ReadOnly = True
        Me.dgvDescargas.RowHeadersVisible = False
        Me.dgvDescargas.Size = New System.Drawing.Size(548, 349)
        Me.dgvDescargas.TabIndex = 14
        '
        'PdMontoDataGridViewTextBoxColumn
        '
        Me.PdMontoDataGridViewTextBoxColumn.DataPropertyName = "pdMonto"
        Me.PdMontoDataGridViewTextBoxColumn.HeaderText = "Monto ($ / lts.)"
        Me.PdMontoDataGridViewTextBoxColumn.Name = "PdMontoDataGridViewTextBoxColumn"
        Me.PdMontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdMontoDataGridViewTextBoxColumn.Width = 130
        '
        'pdTipoVale
        '
        Me.pdTipoVale.DataPropertyName = "pdTipoVale"
        Me.pdTipoVale.HeaderText = "Tipo"
        Me.pdTipoVale.Name = "pdTipoVale"
        Me.pdTipoVale.ReadOnly = True
        '
        'pdUsuario
        '
        Me.pdUsuario.DataPropertyName = "pdUsuario"
        Me.pdUsuario.HeaderText = "Usuario"
        Me.pdUsuario.Name = "pdUsuario"
        Me.pdUsuario.ReadOnly = True
        Me.pdUsuario.Width = 180
        '
        'IDescargaBindingSource
        '
        Me.IDescargaBindingSource.DataSource = GetType(Entidades.Vales.iDescarga)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.btnImprimirTurno)
        Me.GroupBox2.Controls.Add(Me.lblLitrosTurno)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblDineroTurno)
        Me.GroupBox2.Controls.Add(Me.lblDescargasTurno)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(13, 364)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(279, 187)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESUMEN DEL TURNO"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ValesRefinor.My.Resources.Resources.impraz30
        Me.PictureBox2.Location = New System.Drawing.Point(97, 149)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'btnImprimirTurno
        '
        Me.btnImprimirTurno.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimirTurno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimirTurno.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnImprimirTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnImprimirTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnImprimirTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirTurno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirTurno.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnImprimirTurno.Location = New System.Drawing.Point(138, 149)
        Me.btnImprimirTurno.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimirTurno.Name = "btnImprimirTurno"
        Me.btnImprimirTurno.Size = New System.Drawing.Size(133, 30)
        Me.btnImprimirTurno.TabIndex = 26
        Me.btnImprimirTurno.Text = "Imprimir"
        Me.btnImprimirTurno.UseVisualStyleBackColor = False
        '
        'lblLitrosTurno
        '
        Me.lblLitrosTurno.AutoSize = True
        Me.lblLitrosTurno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitrosTurno.ForeColor = System.Drawing.Color.Indigo
        Me.lblLitrosTurno.Location = New System.Drawing.Point(157, 105)
        Me.lblLitrosTurno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLitrosTurno.Name = "lblLitrosTurno"
        Me.lblLitrosTurno.Size = New System.Drawing.Size(15, 17)
        Me.lblLitrosTurno.TabIndex = 25
        Me.lblLitrosTurno.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(17, 105)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Litros descargados:"
        '
        'lblDineroTurno
        '
        Me.lblDineroTurno.AutoSize = True
        Me.lblDineroTurno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDineroTurno.ForeColor = System.Drawing.Color.Indigo
        Me.lblDineroTurno.Location = New System.Drawing.Point(157, 71)
        Me.lblDineroTurno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDineroTurno.Name = "lblDineroTurno"
        Me.lblDineroTurno.Size = New System.Drawing.Size(15, 17)
        Me.lblDineroTurno.TabIndex = 23
        Me.lblDineroTurno.Text = "0"
        '
        'lblDescargasTurno
        '
        Me.lblDescargasTurno.AutoSize = True
        Me.lblDescargasTurno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescargasTurno.ForeColor = System.Drawing.Color.Indigo
        Me.lblDescargasTurno.Location = New System.Drawing.Point(158, 38)
        Me.lblDescargasTurno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescargasTurno.Name = "lblDescargasTurno"
        Me.lblDescargasTurno.Size = New System.Drawing.Size(15, 17)
        Me.lblDescargasTurno.TabIndex = 22
        Me.lblDescargasTurno.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(12, 71)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Monto descargado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(71, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Descargas:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Controls.Add(Me.btnImprimirDia)
        Me.GroupBox3.Controls.Add(Me.lblLitrosDia)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblDineroDia)
        Me.GroupBox3.Controls.Add(Me.lblDescargasDia)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox3.Location = New System.Drawing.Point(13, 102)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(844, 68)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESUMEN DEL DIA"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ValesRefinor.My.Resources.Resources.impraz30
        Me.PictureBox3.Location = New System.Drawing.Point(665, 19)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'btnImprimirDia
        '
        Me.btnImprimirDia.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimirDia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimirDia.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.btnImprimirDia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnImprimirDia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnImprimirDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirDia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirDia.Location = New System.Drawing.Point(703, 19)
        Me.btnImprimirDia.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimirDia.Name = "btnImprimirDia"
        Me.btnImprimirDia.Size = New System.Drawing.Size(133, 30)
        Me.btnImprimirDia.TabIndex = 26
        Me.btnImprimirDia.Text = "Imprimir"
        Me.btnImprimirDia.UseVisualStyleBackColor = False
        '
        'lblLitrosDia
        '
        Me.lblLitrosDia.AutoSize = True
        Me.lblLitrosDia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitrosDia.ForeColor = System.Drawing.Color.Indigo
        Me.lblLitrosDia.Location = New System.Drawing.Point(423, 39)
        Me.lblLitrosDia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLitrosDia.Name = "lblLitrosDia"
        Me.lblLitrosDia.Size = New System.Drawing.Size(15, 17)
        Me.lblLitrosDia.TabIndex = 25
        Me.lblLitrosDia.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(283, 39)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Litros descargados:"
        '
        'lblDineroDia
        '
        Me.lblDineroDia.AutoSize = True
        Me.lblDineroDia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDineroDia.ForeColor = System.Drawing.Color.Indigo
        Me.lblDineroDia.Location = New System.Drawing.Point(423, 17)
        Me.lblDineroDia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDineroDia.Name = "lblDineroDia"
        Me.lblDineroDia.Size = New System.Drawing.Size(15, 17)
        Me.lblDineroDia.TabIndex = 23
        Me.lblDineroDia.Text = "0"
        '
        'lblDescargasDia
        '
        Me.lblDescargasDia.AutoSize = True
        Me.lblDescargasDia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescargasDia.ForeColor = System.Drawing.Color.Indigo
        Me.lblDescargasDia.Location = New System.Drawing.Point(112, 27)
        Me.lblDescargasDia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescargasDia.Name = "lblDescargasDia"
        Me.lblDescargasDia.Size = New System.Drawing.Size(15, 17)
        Me.lblDescargasDia.TabIndex = 22
        Me.lblDescargasDia.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(278, 17)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.Label14.Location = New System.Drawing.Point(25, 27)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 17)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Descargas:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ValesRefinor.My.Resources.Resources.Cuerpo
        Me.PictureBox1.Location = New System.Drawing.Point(657, 392)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'CtrlInformacion1
        '
        Me.CtrlInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlInformacion1.Location = New System.Drawing.Point(13, 563)
        Me.CtrlInformacion1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlInformacion1.Name = "CtrlInformacion1"
        Me.CtrlInformacion1.pdInformacion = "Seleccione una fecha pasada para ver los turnos trabajados."
        Me.CtrlInformacion1.Size = New System.Drawing.Size(636, 52)
        Me.CtrlInformacion1.TabIndex = 12
        '
        'CtrlMensaje
        '
        Me.CtrlMensaje.BackColor = System.Drawing.Color.Transparent
        Me.CtrlMensaje.Location = New System.Drawing.Point(13, 13)
        Me.CtrlMensaje.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlMensaje.Name = "CtrlMensaje"
        Me.CtrlMensaje.pdErrores = CType(resources.GetObject("CtrlMensaje.pdErrores"), System.Collections.Generic.List(Of String))
        Me.CtrlMensaje.pdMensaje = ""
        Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
        Me.CtrlMensaje.Size = New System.Drawing.Size(844, 50)
        Me.CtrlMensaje.TabIndex = 9
        '
        'frmTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstTurnos)
        Me.Controls.Add(Me.dtpDia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTurnos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDescargas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDescargaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CtrlMensaje As ValesRefinor.ctrlMensaje
    Friend WithEvents CtrlInformacion1 As ValesRefinor.ctrlInformacion
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDia As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstTurnos As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDescargas As System.Windows.Forms.DataGridView
    Friend WithEvents IDescargaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLitrosTurno As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDineroTurno As System.Windows.Forms.Label
    Friend WithEvents lblDescargasTurno As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnImprimirTurno As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnImprimirDia As System.Windows.Forms.Button
    Friend WithEvents lblLitrosDia As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblDineroDia As System.Windows.Forms.Label
    Friend WithEvents lblDescargasDia As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PdMontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pdTipoVale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pdUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
