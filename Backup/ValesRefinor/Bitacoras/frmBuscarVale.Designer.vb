<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarVale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarVale))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.gbVale = New System.Windows.Forms.GroupBox
        Me.lblEstado = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pbImagen = New System.Windows.Forms.PictureBox
        Me.lblMonto = New System.Windows.Forms.Label
        Me.lblTipo = New System.Windows.Forms.Label
        Me.lblImporte = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblCliente = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.gbDescarga = New System.Windows.Forms.GroupBox
        Me.CtrlMensaje = New ValesRefinor.ctrlMensaje
        Me.dgvBitacoras = New System.Windows.Forms.DataGridView
        Me.IDescargaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PdFechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdMontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVale.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDescarga.SuspendLayout()
        CType(Me.dgvBitacoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDescargaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(243, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Código de vale (sin asteriscos):"
        '
        'txtCodigo
        '
        Me.txtCodigo.ForeColor = System.Drawing.Color.Indigo
        Me.txtCodigo.Location = New System.Drawing.Point(458, 77)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 23)
        Me.txtCodigo.TabIndex = 12
        Me.txtCodigo.Text = "ABCDEFGHI"
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnBuscar.Location = New System.Drawing.Point(565, 73)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(63, 30)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'gbVale
        '
        Me.gbVale.Controls.Add(Me.lblEstado)
        Me.gbVale.Controls.Add(Me.Label5)
        Me.gbVale.Controls.Add(Me.pbImagen)
        Me.gbVale.Controls.Add(Me.lblMonto)
        Me.gbVale.Controls.Add(Me.lblTipo)
        Me.gbVale.Controls.Add(Me.lblImporte)
        Me.gbVale.Controls.Add(Me.Label6)
        Me.gbVale.Controls.Add(Me.lblCliente)
        Me.gbVale.Controls.Add(Me.Label4)
        Me.gbVale.Controls.Add(Me.lblCodigo)
        Me.gbVale.Controls.Add(Me.Label2)
        Me.gbVale.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVale.ForeColor = System.Drawing.Color.SteelBlue
        Me.gbVale.Location = New System.Drawing.Point(106, 187)
        Me.gbVale.Margin = New System.Windows.Forms.Padding(4)
        Me.gbVale.Name = "gbVale"
        Me.gbVale.Padding = New System.Windows.Forms.Padding(4)
        Me.gbVale.Size = New System.Drawing.Size(659, 174)
        Me.gbVale.TabIndex = 14
        Me.gbVale.TabStop = False
        Me.gbVale.Text = "DETALLE DEL VALE:"
        Me.gbVale.Visible = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Indigo
        Me.lblEstado.Location = New System.Drawing.Point(175, 135)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(46, 21)
        Me.lblEstado.TabIndex = 11
        Me.lblEstado.Text = "$100"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(34, 137)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Estado:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.Color.Transparent
        Me.pbImagen.Image = Global.ValesRefinor.My.Resources.Resources.descargado
        Me.pbImagen.Location = New System.Drawing.Point(508, 29)
        Me.pbImagen.Margin = New System.Windows.Forms.Padding(4)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(137, 98)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 9
        Me.pbImagen.TabStop = False
        Me.pbImagen.Visible = False
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.Indigo
        Me.lblMonto.Location = New System.Drawing.Point(175, 105)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(46, 21)
        Me.lblMonto.TabIndex = 8
        Me.lblMonto.Text = "$100"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.Indigo
        Me.lblTipo.Location = New System.Drawing.Point(175, 78)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(62, 21)
        Me.lblTipo.TabIndex = 7
        Me.lblTipo.Text = "Monto"
        '
        'lblImporte
        '
        Me.lblImporte.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporte.ForeColor = System.Drawing.Color.DimGray
        Me.lblImporte.Location = New System.Drawing.Point(34, 107)
        Me.lblImporte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(133, 21)
        Me.lblImporte.TabIndex = 6
        Me.lblImporte.Text = "Disponible:"
        Me.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(129, 82)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tipo:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.Indigo
        Me.lblCliente.Location = New System.Drawing.Point(175, 52)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(94, 21)
        Me.lblCliente.TabIndex = 4
        Me.lblCliente.Text = "Juan Perez"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(109, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cliente:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.Indigo
        Me.lblCodigo.Location = New System.Drawing.Point(175, 25)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(110, 21)
        Me.lblCodigo.TabIndex = 2
        Me.lblCodigo.Text = "AXKKEOJDKZ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(52, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código de vale:"
        '
        'gbDescarga
        '
        Me.gbDescarga.Controls.Add(Me.dgvBitacoras)
        Me.gbDescarga.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDescarga.ForeColor = System.Drawing.Color.SteelBlue
        Me.gbDescarga.Location = New System.Drawing.Point(14, 369)
        Me.gbDescarga.Margin = New System.Windows.Forms.Padding(4)
        Me.gbDescarga.Name = "gbDescarga"
        Me.gbDescarga.Padding = New System.Windows.Forms.Padding(4)
        Me.gbDescarga.Size = New System.Drawing.Size(843, 246)
        Me.gbDescarga.TabIndex = 15
        Me.gbDescarga.TabStop = False
        Me.gbDescarga.Text = "DETALLE DE LA DESCARGA:"
        Me.gbDescarga.Visible = False
        '
        'CtrlMensaje
        '
        Me.CtrlMensaje.BackColor = System.Drawing.Color.Transparent
        Me.CtrlMensaje.Location = New System.Drawing.Point(13, 14)
        Me.CtrlMensaje.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CtrlMensaje.Name = "CtrlMensaje"
        Me.CtrlMensaje.pdErrores = CType(resources.GetObject("CtrlMensaje.pdErrores"), System.Collections.Generic.List(Of String))
        Me.CtrlMensaje.pdMensaje = ""
        Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
        Me.CtrlMensaje.Size = New System.Drawing.Size(843, 50)
        Me.CtrlMensaje.TabIndex = 10
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBitacoras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBitacoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBitacoras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PdFechaDataGridViewTextBoxColumn, Me.PdMontoDataGridViewTextBoxColumn, Me.PdUsuarioDataGridViewTextBoxColumn})
        Me.dgvBitacoras.DataSource = Me.IDescargaBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBitacoras.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBitacoras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBitacoras.Location = New System.Drawing.Point(4, 24)
        Me.dgvBitacoras.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBitacoras.Name = "dgvBitacoras"
        Me.dgvBitacoras.ReadOnly = True
        Me.dgvBitacoras.RowHeadersVisible = False
        Me.dgvBitacoras.Size = New System.Drawing.Size(835, 218)
        Me.dgvBitacoras.TabIndex = 14
        '
        'IDescargaBindingSource
        '
        Me.IDescargaBindingSource.DataSource = GetType(Entidades.Vales.iDescarga)
        '
        'PdFechaDataGridViewTextBoxColumn
        '
        Me.PdFechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PdFechaDataGridViewTextBoxColumn.DataPropertyName = "pdFecha"
        Me.PdFechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.PdFechaDataGridViewTextBoxColumn.Name = "PdFechaDataGridViewTextBoxColumn"
        Me.PdFechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdFechaDataGridViewTextBoxColumn.Width = 84
        '
        'PdMontoDataGridViewTextBoxColumn
        '
        Me.PdMontoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PdMontoDataGridViewTextBoxColumn.DataPropertyName = "pdMonto"
        Me.PdMontoDataGridViewTextBoxColumn.HeaderText = "Monto/lts"
        Me.PdMontoDataGridViewTextBoxColumn.Name = "PdMontoDataGridViewTextBoxColumn"
        Me.PdMontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdMontoDataGridViewTextBoxColumn.Width = 110
        '
        'PdUsuarioDataGridViewTextBoxColumn
        '
        Me.PdUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PdUsuarioDataGridViewTextBoxColumn.DataPropertyName = "pdUsuario"
        Me.PdUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.PdUsuarioDataGridViewTextBoxColumn.Name = "PdUsuarioDataGridViewTextBoxColumn"
        Me.PdUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdUsuarioDataGridViewTextBoxColumn.Width = 91
        '
        'frmBuscarVale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.Controls.Add(Me.gbDescarga)
        Me.Controls.Add(Me.gbVale)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBuscarVale"
        Me.Text = "frmBuscarVale"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVale.ResumeLayout(False)
        Me.gbVale.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDescarga.ResumeLayout(False)
        CType(Me.dgvBitacoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDescargaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CtrlMensaje As ValesRefinor.ctrlMensaje
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gbVale As System.Windows.Forms.GroupBox
    Friend WithEvents pbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbDescarga As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvBitacoras As System.Windows.Forms.DataGridView
    Friend WithEvents PdFechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdMontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdUsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDescargaBindingSource As System.Windows.Forms.BindingSource
End Class
