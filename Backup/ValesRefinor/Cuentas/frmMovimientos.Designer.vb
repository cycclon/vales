<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos))
        Me.lblNombre = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvUltimosMovimientos = New System.Windows.Forms.DataGridView
        Me.PdTipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdFechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdMontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdTipoValeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMovimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbOpciones = New System.Windows.Forms.GroupBox
        Me.btnOpcion = New System.Windows.Forms.Button
        Me.pbOpcion = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CtrlInformacion1 = New ValesRefinor.ctrlInformacion
        Me.CtrlMensaje = New ValesRefinor.ctrlMensaje
        Me.CtrlMensaje1 = New ValesRefinor.ctrlMensaje
        Me.pbEstado = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvUltimosMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMovimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpciones.SuspendLayout()
        CType(Me.pbOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Indigo
        Me.lblNombre.Location = New System.Drawing.Point(216, 95)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(132, 17)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Nombre Completo"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvUltimosMovimientos)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(13, 159)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(844, 391)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MOVIMIENTOS"
        '
        'dgvUltimosMovimientos
        '
        Me.dgvUltimosMovimientos.AllowUserToAddRows = False
        Me.dgvUltimosMovimientos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgvUltimosMovimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUltimosMovimientos.AutoGenerateColumns = False
        Me.dgvUltimosMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvUltimosMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUltimosMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUltimosMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUltimosMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PdTipoDataGridViewTextBoxColumn, Me.PdFechaDataGridViewTextBoxColumn, Me.PdMontoDataGridViewTextBoxColumn, Me.PdTipoValeDataGridViewTextBoxColumn})
        Me.dgvUltimosMovimientos.DataSource = Me.IMovimientoBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUltimosMovimientos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUltimosMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUltimosMovimientos.Location = New System.Drawing.Point(4, 24)
        Me.dgvUltimosMovimientos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvUltimosMovimientos.Name = "dgvUltimosMovimientos"
        Me.dgvUltimosMovimientos.ReadOnly = True
        Me.dgvUltimosMovimientos.RowHeadersVisible = False
        Me.dgvUltimosMovimientos.Size = New System.Drawing.Size(836, 363)
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
        Me.PdFechaDataGridViewTextBoxColumn.Width = 200
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
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnOpcion)
        Me.gbOpciones.Controls.Add(Me.pbOpcion)
        Me.gbOpciones.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOpciones.ForeColor = System.Drawing.Color.SteelBlue
        Me.gbOpciones.Location = New System.Drawing.Point(594, 71)
        Me.gbOpciones.Margin = New System.Windows.Forms.Padding(4)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Padding = New System.Windows.Forms.Padding(4)
        Me.gbOpciones.Size = New System.Drawing.Size(263, 80)
        Me.gbOpciones.TabIndex = 18
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "OPCIONES"
        '
        'btnOpcion
        '
        Me.btnOpcion.BackColor = System.Drawing.Color.Transparent
        Me.btnOpcion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpcion.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.btnOpcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnOpcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpcion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpcion.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnOpcion.Location = New System.Drawing.Point(46, 28)
        Me.btnOpcion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(205, 30)
        Me.btnOpcion.TabIndex = 19
        Me.btnOpcion.Text = "Ver Cuenta"
        Me.btnOpcion.UseVisualStyleBackColor = False
        '
        'pbOpcion
        '
        Me.pbOpcion.Image = Global.ValesRefinor.My.Resources.Resources.cajgri30
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
        Me.Label2.Location = New System.Drawing.Point(121, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Detalle de movimientos de la cuenta del cliente:"
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
        Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
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
        Me.CtrlMensaje1.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
        Me.CtrlMensaje1.Size = New System.Drawing.Size(670, 50)
        Me.CtrlMensaje1.TabIndex = 9
        '
        'pbEstado
        '
        Me.pbEstado.Image = Global.ValesRefinor.My.Resources.Resources.inoutver50
        Me.pbEstado.Location = New System.Drawing.Point(31, 71)
        Me.pbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.pbEstado.Name = "pbEstado"
        Me.pbEstado.Size = New System.Drawing.Size(50, 50)
        Me.pbEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbEstado.TabIndex = 16
        Me.pbEstado.TabStop = False
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
        'frmMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbEstado)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovimientos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvUltimosMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMovimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbOpciones.PerformLayout()
        CType(Me.pbOpcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CtrlMensaje As ValesRefinor.ctrlMensaje
    Friend WithEvents CtrlMensaje1 As ValesRefinor.ctrlMensaje
    Friend WithEvents CtrlInformacion1 As ValesRefinor.ctrlInformacion
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents pbEstado As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents pbOpcion As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvUltimosMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents IMovimientoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PdTipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdFechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdMontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdTipoValeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
