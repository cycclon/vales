<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeries
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeries))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvVales = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PdTipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pdTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerDetalle = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ISerieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CtrlInformacion1 = New Vales.ctrlInformacion()
        Me.CtrlMensaje = New Vales.ctrlMensaje()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdInactivos = New System.Windows.Forms.RadioButton()
        Me.rdActivos = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISerieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgvVales
        '
        Me.dgvVales.AllowUserToAddRows = False
        Me.dgvVales.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgvVales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvVales.AutoGenerateColumns = False
        Me.dgvVales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvVales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvVales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.PdTipoDataGridViewTextBoxColumn, Me.pdTotal, Me.VerDetalle})
        Me.dgvVales.DataSource = Me.ISerieBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVales.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvVales.Location = New System.Drawing.Point(27, 139)
        Me.dgvVales.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvVales.Name = "dgvVales"
        Me.dgvVales.ReadOnly = True
        Me.dgvVales.RowHeadersVisible = False
        Me.dgvVales.Size = New System.Drawing.Size(830, 411)
        Me.dgvVales.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "pdFechaEmision"
        Me.Column1.HeaderText = "Fecha de emisión"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'PdTipoDataGridViewTextBoxColumn
        '
        Me.PdTipoDataGridViewTextBoxColumn.DataPropertyName = "pdTipo"
        Me.PdTipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.PdTipoDataGridViewTextBoxColumn.Name = "PdTipoDataGridViewTextBoxColumn"
        Me.PdTipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdTipoDataGridViewTextBoxColumn.Width = 120
        '
        'pdTotal
        '
        Me.pdTotal.DataPropertyName = "pdTotal"
        Me.pdTotal.HeaderText = "Total $ / lts."
        Me.pdTotal.Name = "pdTotal"
        Me.pdTotal.ReadOnly = True
        Me.pdTotal.Width = 130
        '
        'VerDetalle
        '
        Me.VerDetalle.HeaderText = "Ver Detalle"
        Me.VerDetalle.Name = "VerDetalle"
        Me.VerDetalle.ReadOnly = True
        '
        'ISerieBindingSource
        '
        Me.ISerieBindingSource.DataSource = GetType(Entidades.Vales.iSerie)
        '
        'IClienteBindingSource
        '
        Me.IClienteBindingSource.DataSource = GetType(Entidades.Clientes.iCliente)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(210, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Seleccionar por cliente:"
        '
        'CtrlInformacion1
        '
        Me.CtrlInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlInformacion1.Location = New System.Drawing.Point(13, 563)
        Me.CtrlInformacion1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlInformacion1.Name = "CtrlInformacion1"
        Me.CtrlInformacion1.pdInformacion = "Para ver los detalles de un cliente, haga click sobre su correspondiente botón ""V" &
    "er Detalles"""
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
        'cmbClientes
        '
        Me.cmbClientes.DataSource = Me.IClienteBindingSource
        Me.cmbClientes.DisplayMember = "pdNombreCompleto"
        Me.cmbClientes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(377, 71)
        Me.cmbClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(283, 25)
        Me.cmbClientes.TabIndex = 17
        Me.cmbClientes.ValueMember = "pdID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(253, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Seleccionar por estado:"
        '
        'rdInactivos
        '
        Me.rdInactivos.AutoSize = True
        Me.rdInactivos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdInactivos.ForeColor = System.Drawing.Color.Indigo
        Me.rdInactivos.Location = New System.Drawing.Point(503, 107)
        Me.rdInactivos.Margin = New System.Windows.Forms.Padding(4)
        Me.rdInactivos.Name = "rdInactivos"
        Me.rdInactivos.Size = New System.Drawing.Size(95, 21)
        Me.rdInactivos.TabIndex = 19
        Me.rdInactivos.TabStop = True
        Me.rdInactivos.Text = "Eliminadas"
        Me.rdInactivos.UseVisualStyleBackColor = True
        '
        'rdActivos
        '
        Me.rdActivos.AutoSize = True
        Me.rdActivos.Checked = True
        Me.rdActivos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdActivos.ForeColor = System.Drawing.Color.Indigo
        Me.rdActivos.Location = New System.Drawing.Point(422, 107)
        Me.rdActivos.Margin = New System.Windows.Forms.Padding(4)
        Me.rdActivos.Name = "rdActivos"
        Me.rdActivos.Size = New System.Drawing.Size(73, 21)
        Me.rdActivos.TabIndex = 18
        Me.rdActivos.TabStop = True
        Me.rdActivos.Text = "Activas"
        Me.rdActivos.UseVisualStyleBackColor = True
        '
        'frmSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdInactivos)
        Me.Controls.Add(Me.rdActivos)
        Me.Controls.Add(Me.cmbClientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvVales)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeries"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISerieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CtrlMensaje As Vales.ctrlMensaje
    Friend WithEvents CtrlInformacion1 As Vales.ctrlInformacion
    Friend WithEvents dgvVales As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents ISerieBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdTipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pdTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerDetalle As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents rdInactivos As RadioButton
    Friend WithEvents rdActivos As RadioButton
End Class
