<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.dgvClientes = New System.Windows.Forms.DataGridView
        Me.PdTipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdNombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VerDetalle = New System.Windows.Forms.DataGridViewButtonColumn
        Me.IClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rdActivos = New System.Windows.Forms.RadioButton
        Me.rdInactivos = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.CtrlInformacion1 = New ValesRefinor.ctrlInformacion
        Me.CtrlMensaje = New ValesRefinor.ctrlMensaje
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgvClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvClientes.AutoGenerateColumns = False
        Me.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PdTipoDataGridViewTextBoxColumn, Me.PdNombreCompletoDataGridViewTextBoxColumn, Me.VerDetalle})
        Me.dgvClientes.DataSource = Me.IClienteBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvClientes.Location = New System.Drawing.Point(13, 101)
        Me.dgvClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.Size = New System.Drawing.Size(844, 449)
        Me.dgvClientes.TabIndex = 13
        '
        'PdTipoDataGridViewTextBoxColumn
        '
        Me.PdTipoDataGridViewTextBoxColumn.DataPropertyName = "pdTipo"
        Me.PdTipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.PdTipoDataGridViewTextBoxColumn.Name = "PdTipoDataGridViewTextBoxColumn"
        Me.PdTipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PdNombreCompletoDataGridViewTextBoxColumn
        '
        Me.PdNombreCompletoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PdNombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "pdNombreCompleto"
        Me.PdNombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.PdNombreCompletoDataGridViewTextBoxColumn.Name = "PdNombreCompletoDataGridViewTextBoxColumn"
        Me.PdNombreCompletoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdNombreCompletoDataGridViewTextBoxColumn.Width = 86
        '
        'VerDetalle
        '
        Me.VerDetalle.HeaderText = "Ver Detalle"
        Me.VerDetalle.Name = "VerDetalle"
        Me.VerDetalle.ReadOnly = True
        '
        'IClienteBindingSource
        '
        Me.IClienteBindingSource.DataSource = GetType(Entidades.Clientes.iCliente)
        '
        'rdActivos
        '
        Me.rdActivos.AutoSize = True
        Me.rdActivos.Checked = True
        Me.rdActivos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdActivos.ForeColor = System.Drawing.Color.Indigo
        Me.rdActivos.Location = New System.Drawing.Point(428, 71)
        Me.rdActivos.Margin = New System.Windows.Forms.Padding(4)
        Me.rdActivos.Name = "rdActivos"
        Me.rdActivos.Size = New System.Drawing.Size(81, 21)
        Me.rdActivos.TabIndex = 0
        Me.rdActivos.TabStop = True
        Me.rdActivos.Text = "Actuales"
        Me.rdActivos.UseVisualStyleBackColor = True
        '
        'rdInactivos
        '
        Me.rdInactivos.AutoSize = True
        Me.rdInactivos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdInactivos.ForeColor = System.Drawing.Color.Indigo
        Me.rdInactivos.Location = New System.Drawing.Point(517, 71)
        Me.rdInactivos.Margin = New System.Windows.Forms.Padding(4)
        Me.rdInactivos.Name = "rdInactivos"
        Me.rdInactivos.Size = New System.Drawing.Size(94, 21)
        Me.rdInactivos.TabIndex = 1
        Me.rdInactivos.TabStop = True
        Me.rdInactivos.Text = "Ex Clientes"
        Me.rdInactivos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(259, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Seleccionar por estado:"
        '
        'CtrlInformacion1
        '
        Me.CtrlInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlInformacion1.Location = New System.Drawing.Point(13, 563)
        Me.CtrlInformacion1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlInformacion1.Name = "CtrlInformacion1"
        Me.CtrlInformacion1.pdInformacion = "Para ver los detalles de un cliente, haga click sobre su correspondiente botón ""V" & _
            "er Detalles"""
        Me.CtrlInformacion1.Size = New System.Drawing.Size(573, 52)
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
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdInactivos)
        Me.Controls.Add(Me.rdActivos)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClientes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CtrlMensaje As ValesRefinor.ctrlMensaje
    Friend WithEvents CtrlInformacion1 As ValesRefinor.ctrlInformacion
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents rdActivos As System.Windows.Forms.RadioButton
    Friend WithEvents rdInactivos As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PdTipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdNombreCompletoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerDetalle As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents IClienteBindingSource As System.Windows.Forms.BindingSource
End Class
