<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuenta))
        Me.lblNombre = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvUltimosMovimientos = New System.Windows.Forms.DataGridView
        Me.PdTipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdFechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdMontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdTipoValeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMovimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDetalleCuenta = New System.Windows.Forms.Button
        Me.lblSaldoLitros = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblSaldoPesos = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbOpciones = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnOpcion = New System.Windows.Forms.Button
        Me.pbOpcion = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.pbEstado = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lstDetalleCombustibles = New System.Windows.Forms.ListBox
        Me.IDisponibilidadCombustibleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtrlInformacion1 = New Vales.ctrlInformacion
        Me.CtrlMensaje = New Vales.ctrlMensaje
        Me.CtrlMensaje1 = New Vales.ctrlMensaje
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvUltimosMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMovimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpciones.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.IDisponibilidadCombustibleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Indigo
        Me.lblNombre.Location = New System.Drawing.Point(196, 143)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(132, 17)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Nombre Completo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvUltimosMovimientos)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(17, 262)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(575, 293)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MOVIMIENTOS"
        '
        'dgvUltimosMovimientos
        '
        Me.dgvUltimosMovimientos.AllowUserToAddRows = False
        Me.dgvUltimosMovimientos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        Me.dgvUltimosMovimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUltimosMovimientos.AutoGenerateColumns = False
        Me.dgvUltimosMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvUltimosMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUltimosMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUltimosMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUltimosMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PdTipoDataGridViewTextBoxColumn, Me.PdFechaDataGridViewTextBoxColumn, Me.PdMontoDataGridViewTextBoxColumn, Me.PdTipoValeDataGridViewTextBoxColumn})
        Me.dgvUltimosMovimientos.DataSource = Me.IMovimientoBindingSource
        Me.dgvUltimosMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUltimosMovimientos.Location = New System.Drawing.Point(4, 24)
        Me.dgvUltimosMovimientos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvUltimosMovimientos.Name = "dgvUltimosMovimientos"
        Me.dgvUltimosMovimientos.ReadOnly = True
        Me.dgvUltimosMovimientos.RowHeadersVisible = False
        Me.dgvUltimosMovimientos.Size = New System.Drawing.Size(567, 265)
        Me.dgvUltimosMovimientos.TabIndex = 27
        '
        'PdTipoDataGridViewTextBoxColumn
        '
        Me.PdTipoDataGridViewTextBoxColumn.DataPropertyName = "pdTipo"
        Me.PdTipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.PdTipoDataGridViewTextBoxColumn.Name = "PdTipoDataGridViewTextBoxColumn"
        Me.PdTipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdTipoDataGridViewTextBoxColumn.Width = 70
        '
        'PdFechaDataGridViewTextBoxColumn
        '
        Me.PdFechaDataGridViewTextBoxColumn.DataPropertyName = "pdFecha"
        Me.PdFechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.PdFechaDataGridViewTextBoxColumn.Name = "PdFechaDataGridViewTextBoxColumn"
        Me.PdFechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdFechaDataGridViewTextBoxColumn.Width = 150
        '
        'PdMontoDataGridViewTextBoxColumn
        '
        Me.PdMontoDataGridViewTextBoxColumn.DataPropertyName = "pdMonto"
        Me.PdMontoDataGridViewTextBoxColumn.HeaderText = "$ / Lts."
        Me.PdMontoDataGridViewTextBoxColumn.Name = "PdMontoDataGridViewTextBoxColumn"
        Me.PdMontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdMontoDataGridViewTextBoxColumn.Width = 80
        '
        'PdTipoValeDataGridViewTextBoxColumn
        '
        Me.PdTipoValeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PdTipoValeDataGridViewTextBoxColumn.DataPropertyName = "pdTipoVale"
        Me.PdTipoValeDataGridViewTextBoxColumn.HeaderText = "Tipo de Vale"
        Me.PdTipoValeDataGridViewTextBoxColumn.Name = "PdTipoValeDataGridViewTextBoxColumn"
        Me.PdTipoValeDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdTipoValeDataGridViewTextBoxColumn.Width = 120
        '
        'IMovimientoBindingSource
        '
        Me.IMovimientoBindingSource.DataSource = GetType(Entidades.Cuentas.iMovimiento)
        '
        'btnDetalleCuenta
        '
        Me.btnDetalleCuenta.BackColor = System.Drawing.Color.Transparent
        Me.btnDetalleCuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDetalleCuenta.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnDetalleCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnDetalleCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnDetalleCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalleCuenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalleCuenta.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnDetalleCuenta.Location = New System.Drawing.Point(46, 66)
        Me.btnDetalleCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDetalleCuenta.Name = "btnDetalleCuenta"
        Me.btnDetalleCuenta.Size = New System.Drawing.Size(205, 30)
        Me.btnDetalleCuenta.TabIndex = 27
        Me.btnDetalleCuenta.Text = "Detalle de Movimientos"
        Me.btnDetalleCuenta.UseVisualStyleBackColor = False
        '
        'lblSaldoLitros
        '
        Me.lblSaldoLitros.AutoSize = True
        Me.lblSaldoLitros.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoLitros.ForeColor = System.Drawing.Color.Indigo
        Me.lblSaldoLitros.Location = New System.Drawing.Point(181, 211)
        Me.lblSaldoLitros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldoLitros.Name = "lblSaldoLitros"
        Me.lblSaldoLitros.Size = New System.Drawing.Size(64, 30)
        Me.lblSaldoLitros.TabIndex = 23
        Me.lblSaldoLitros.Text = "0 lts."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(72, 223)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Saldo en litros:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSaldoPesos
        '
        Me.lblSaldoPesos.AutoSize = True
        Me.lblSaldoPesos.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoPesos.ForeColor = System.Drawing.Color.Indigo
        Me.lblSaldoPesos.Location = New System.Drawing.Point(181, 172)
        Me.lblSaldoPesos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldoPesos.Name = "lblSaldoPesos"
        Me.lblSaldoPesos.Size = New System.Drawing.Size(39, 30)
        Me.lblSaldoPesos.TabIndex = 21
        Me.lblSaldoPesos.Text = "$0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(65, 184)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Saldo en pesos:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnDetalleCuenta)
        Me.gbOpciones.Controls.Add(Me.PictureBox2)
        Me.gbOpciones.Controls.Add(Me.btnOpcion)
        Me.gbOpciones.Controls.Add(Me.pbOpcion)
        Me.gbOpciones.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOpciones.ForeColor = System.Drawing.Color.SteelBlue
        Me.gbOpciones.Location = New System.Drawing.Point(595, 111)
        Me.gbOpciones.Margin = New System.Windows.Forms.Padding(4)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Padding = New System.Windows.Forms.Padding(4)
        Me.gbOpciones.Size = New System.Drawing.Size(262, 128)
        Me.gbOpciones.TabIndex = 18
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "OPCIONES"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Vales.My.Resources.Resources.inoutver30
        Me.PictureBox2.Location = New System.Drawing.Point(8, 66)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'btnOpcion
        '
        Me.btnOpcion.BackColor = System.Drawing.Color.Transparent
        Me.btnOpcion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpcion.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnOpcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnOpcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpcion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcion.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnOpcion.Location = New System.Drawing.Point(46, 28)
        Me.btnOpcion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(205, 30)
        Me.btnOpcion.TabIndex = 19
        Me.btnOpcion.Text = "Ver Cliente"
        Me.btnOpcion.UseVisualStyleBackColor = False
        '
        'pbOpcion
        '
        Me.pbOpcion.Image = Global.Vales.My.Resources.Resources.cliaz30
        Me.pbOpcion.Location = New System.Drawing.Point(8, 28)
        Me.pbOpcion.Margin = New System.Windows.Forms.Padding(4)
        Me.pbOpcion.Name = "pbOpcion"
        Me.pbOpcion.Size = New System.Drawing.Size(30, 30)
        Me.pbOpcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbOpcion.TabIndex = 19
        Me.pbOpcion.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(159, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Detalle de cuenta del cliente:"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Vales.My.Resources.Resources.nafver30
        Me.PictureBox4.Location = New System.Drawing.Point(27, 214)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Vales.My.Resources.Resources.monam30
        Me.PictureBox3.Location = New System.Drawing.Point(27, 173)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'pbEstado
        '
        Me.pbEstado.Image = Global.Vales.My.Resources.Resources.cajgri50
        Me.pbEstado.Location = New System.Drawing.Point(27, 99)
        Me.pbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.pbEstado.Name = "pbEstado"
        Me.pbEstado.Size = New System.Drawing.Size(50, 50)
        Me.pbEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbEstado.TabIndex = 16
        Me.pbEstado.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Vales.My.Resources.Resources.Cuerpo
        Me.PictureBox1.Location = New System.Drawing.Point(657, 392)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstDetalleCombustibles)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(600, 262)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(257, 293)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETALLE DE COMBUSTIBLES"
        '
        'lstDetalleCombustibles
        '
        Me.lstDetalleCombustibles.DataSource = Me.IDisponibilidadCombustibleBindingSource
        Me.lstDetalleCombustibles.DisplayMember = "pdResumen"
        Me.lstDetalleCombustibles.FormattingEnabled = True
        Me.lstDetalleCombustibles.ItemHeight = 21
        Me.lstDetalleCombustibles.Location = New System.Drawing.Point(9, 27)
        Me.lstDetalleCombustibles.Margin = New System.Windows.Forms.Padding(4)
        Me.lstDetalleCombustibles.Name = "lstDetalleCombustibles"
        Me.lstDetalleCombustibles.Size = New System.Drawing.Size(236, 235)
        Me.lstDetalleCombustibles.TabIndex = 0
        '
        'IDisponibilidadCombustibleBindingSource
        '
        Me.IDisponibilidadCombustibleBindingSource.DataSource = GetType(Entidades.Cuentas.iDisponibilidadCombustible)
        '
        'CtrlInformacion1
        '
        Me.CtrlInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlInformacion1.Location = New System.Drawing.Point(13, 563)
        Me.CtrlInformacion1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlInformacion1.Name = "CtrlInformacion1"
        Me.CtrlInformacion1.pdInformacion = "Detalle de la cuenta de un cliente. Se muestran los saldos disponibles y los últi" & _
            "mos 10 movimientos. Para ver todos los movimientos realizados, presione el botón" & _
            " ""Detalle de Movimientos""."
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
        Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
        Me.CtrlMensaje.Size = New System.Drawing.Size(844, 50)
        Me.CtrlMensaje.TabIndex = 9
        '
        'CtrlMensaje1
        '
        Me.CtrlMensaje1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlMensaje1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtrlMensaje1.Location = New System.Drawing.Point(0, 0)
        Me.CtrlMensaje1.Name = "CtrlMensaje1"
        Me.CtrlMensaje1.pdErrores = CType(resources.GetObject("CtrlMensaje1.pdErrores"), System.Collections.Generic.List(Of String))
        Me.CtrlMensaje1.pdMensaje = ""
        Me.CtrlMensaje1.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
        Me.CtrlMensaje1.Size = New System.Drawing.Size(670, 50)
        Me.CtrlMensaje1.TabIndex = 9
        '
        'frmCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.lblSaldoLitros)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbEstado)
        Me.Controls.Add(Me.lblSaldoPesos)
        Me.Controls.Add(Me.lblNombre)
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
        Me.Name = "frmCuenta"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvUltimosMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMovimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbOpciones.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOpcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.IDisponibilidadCombustibleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CtrlMensaje As Vales.ctrlMensaje
    Friend WithEvents CtrlMensaje1 As Vales.ctrlMensaje
    Friend WithEvents CtrlInformacion1 As Vales.ctrlInformacion
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents pbEstado As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents pbOpcion As System.Windows.Forms.PictureBox
    Friend WithEvents lblSaldoPesos As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSaldoLitros As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDetalleCuenta As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvUltimosMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents IMovimientoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PdTipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdFechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdMontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdTipoValeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstDetalleCombustibles As System.Windows.Forms.ListBox
    Friend WithEvents IDisponibilidadCombustibleBindingSource As System.Windows.Forms.BindingSource
End Class
