<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBitacoras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBitacoras))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.dgvBitacoras = New System.Windows.Forms.DataGridView
        Me.PdFechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdUsuarioGeneradorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdMensajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IBitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnVer = New System.Windows.Forms.Button
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.lblY = New System.Windows.Forms.Label
        Me.cmbUsuario = New System.Windows.Forms.ComboBox
        Me.dtpEntre = New System.Windows.Forms.DateTimePicker
        Me.lblEntre = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.rdFDesactivar = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.rdFActivar = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.CtrlInformacion1 = New Vales.ctrlInformacion
        Me.CtrlMensaje = New Vales.ctrlMensaje
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBitacoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IBitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'dgvBitacoras
        '
        Me.dgvBitacoras.AllowUserToAddRows = False
        Me.dgvBitacoras.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBitacoras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBitacoras.AutoGenerateColumns = False
        Me.dgvBitacoras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBitacoras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBitacoras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBitacoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBitacoras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PdFechaDataGridViewTextBoxColumn, Me.PdUsuarioGeneradorDataGridViewTextBoxColumn, Me.PdMensajeDataGridViewTextBoxColumn})
        Me.dgvBitacoras.DataSource = Me.IBitacoraBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBitacoras.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBitacoras.Location = New System.Drawing.Point(27, 231)
        Me.dgvBitacoras.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBitacoras.Name = "dgvBitacoras"
        Me.dgvBitacoras.ReadOnly = True
        Me.dgvBitacoras.RowHeadersVisible = False
        Me.dgvBitacoras.Size = New System.Drawing.Size(830, 324)
        Me.dgvBitacoras.TabIndex = 13
        '
        'PdFechaDataGridViewTextBoxColumn
        '
        Me.PdFechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PdFechaDataGridViewTextBoxColumn.DataPropertyName = "pdFecha"
        Me.PdFechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.PdFechaDataGridViewTextBoxColumn.Name = "PdFechaDataGridViewTextBoxColumn"
        Me.PdFechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdFechaDataGridViewTextBoxColumn.Width = 72
        '
        'PdUsuarioGeneradorDataGridViewTextBoxColumn
        '
        Me.PdUsuarioGeneradorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PdUsuarioGeneradorDataGridViewTextBoxColumn.DataPropertyName = "pdUsuarioGenerador"
        Me.PdUsuarioGeneradorDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.PdUsuarioGeneradorDataGridViewTextBoxColumn.Name = "PdUsuarioGeneradorDataGridViewTextBoxColumn"
        Me.PdUsuarioGeneradorDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdUsuarioGeneradorDataGridViewTextBoxColumn.Width = 79
        '
        'PdMensajeDataGridViewTextBoxColumn
        '
        Me.PdMensajeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PdMensajeDataGridViewTextBoxColumn.DataPropertyName = "pdMensaje"
        Me.PdMensajeDataGridViewTextBoxColumn.HeaderText = "Bitácora"
        Me.PdMensajeDataGridViewTextBoxColumn.Name = "PdMensajeDataGridViewTextBoxColumn"
        Me.PdMensajeDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdMensajeDataGridViewTextBoxColumn.Width = 87
        '
        'IBitacoraBindingSource
        '
        Me.IBitacoraBindingSource.DataSource = GetType(Entidades.Bitacoras.iBitacora)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnVer)
        Me.GroupBox1.Controls.Add(Me.dtpHasta)
        Me.GroupBox1.Controls.Add(Me.cmbTipo)
        Me.GroupBox1.Controls.Add(Me.lblY)
        Me.GroupBox1.Controls.Add(Me.cmbUsuario)
        Me.GroupBox1.Controls.Add(Me.dtpEntre)
        Me.GroupBox1.Controls.Add(Me.lblEntre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rdFDesactivar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rdFActivar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(27, 99)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(830, 124)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTRAR POR"
        '
        'btnVer
        '
        Me.btnVer.BackColor = System.Drawing.Color.Transparent
        Me.btnVer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVer.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVer.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnVer.Location = New System.Drawing.Point(759, 84)
        Me.btnVer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(63, 30)
        Me.btnVer.TabIndex = 11
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = False
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Location = New System.Drawing.Point(470, 86)
        Me.dtpHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(279, 23)
        Me.dtpHasta.TabIndex = 6
        Me.dtpHasta.Visible = False
        '
        'cmbTipo
        '
        Me.cmbTipo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(555, 26)
        Me.cmbTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(147, 25)
        Me.cmbTipo.TabIndex = 10
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.ForeColor = System.Drawing.Color.DimGray
        Me.lblY.Location = New System.Drawing.Point(444, 91)
        Me.lblY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(18, 17)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "y:"
        Me.lblY.Visible = False
        '
        'cmbUsuario
        '
        Me.cmbUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(194, 26)
        Me.cmbUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(184, 25)
        Me.cmbUsuario.TabIndex = 9
        '
        'dtpEntre
        '
        Me.dtpEntre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEntre.Location = New System.Drawing.Point(134, 86)
        Me.dtpEntre.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEntre.Name = "dtpEntre"
        Me.dtpEntre.Size = New System.Drawing.Size(281, 23)
        Me.dtpEntre.TabIndex = 4
        Me.dtpEntre.Visible = False
        '
        'lblEntre
        '
        Me.lblEntre.AutoSize = True
        Me.lblEntre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntre.ForeColor = System.Drawing.Color.DimGray
        Me.lblEntre.Location = New System.Drawing.Point(82, 91)
        Me.lblEntre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEntre.Name = "lblEntre"
        Me.lblEntre.Size = New System.Drawing.Size(44, 17)
        Me.lblEntre.TabIndex = 3
        Me.lblEntre.Text = "Entre:"
        Me.lblEntre.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(428, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo de bitácora:"
        '
        'rdFDesactivar
        '
        Me.rdFDesactivar.AutoSize = True
        Me.rdFDesactivar.Checked = True
        Me.rdFDesactivar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFDesactivar.ForeColor = System.Drawing.Color.Indigo
        Me.rdFDesactivar.Location = New System.Drawing.Point(357, 59)
        Me.rdFDesactivar.Margin = New System.Windows.Forms.Padding(4)
        Me.rdFDesactivar.Name = "rdFDesactivar"
        Me.rdFDesactivar.Size = New System.Drawing.Size(95, 21)
        Me.rdFDesactivar.TabIndex = 2
        Me.rdFDesactivar.TabStop = True
        Me.rdFDesactivar.Text = "Desactivar"
        Me.rdFDesactivar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(128, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Usuario:"
        '
        'rdFActivar
        '
        Me.rdFActivar.AutoSize = True
        Me.rdFActivar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFActivar.ForeColor = System.Drawing.Color.Indigo
        Me.rdFActivar.Location = New System.Drawing.Point(460, 59)
        Me.rdFActivar.Margin = New System.Windows.Forms.Padding(4)
        Me.rdFActivar.Name = "rdFActivar"
        Me.rdFActivar.Size = New System.Drawing.Size(72, 21)
        Me.rdFActivar.TabIndex = 1
        Me.rdFActivar.Text = "Activar"
        Me.rdFActivar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(298, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'CtrlInformacion1
        '
        Me.CtrlInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlInformacion1.Location = New System.Drawing.Point(13, 563)
        Me.CtrlInformacion1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlInformacion1.Name = "CtrlInformacion1"
        Me.CtrlInformacion1.pdInformacion = "Establezca los filtros y presione el botón ""Ver"" para obtener las bitácoras desea" & _
            "das."
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
        'frmBitacoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvBitacoras)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBitacoras"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBitacoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IBitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CtrlMensaje As Vales.ctrlMensaje
    Friend WithEvents CtrlInformacion1 As Vales.ctrlInformacion
    Friend WithEvents dgvBitacoras As System.Windows.Forms.DataGridView
    Friend WithEvents PdFechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdUsuarioGeneradorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdMensajeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IBitacoraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdFActivar As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents dtpEntre As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEntre As System.Windows.Forms.Label
    Friend WithEvents rdFDesactivar As System.Windows.Forms.RadioButton
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents btnVer As System.Windows.Forms.Button
End Class
