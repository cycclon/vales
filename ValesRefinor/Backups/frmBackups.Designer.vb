<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackups
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackups))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.dgvBackups = New System.Windows.Forms.DataGridView
        Me.PdFechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pdNombreBase = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PdArchivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgbcRestaurar = New System.Windows.Forms.DataGridViewButtonColumn
        Me.dgvbcEliminar = New System.Windows.Forms.DataGridViewButtonColumn
        Me.IBackupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblBase = New System.Windows.Forms.Label
        Me.cmbBases = New System.Windows.Forms.ComboBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.CtrlInformacion1 = New ValesRefinor.ctrlInformacion
        Me.CtrlMensaje = New ValesRefinor.ctrlMensaje
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBackups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IBackupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ValesRefinor.My.Resources.Resources.Cuerpo
        Me.PictureBox1.Location = New System.Drawing.Point(456, 252)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'dgvBackups
        '
        Me.dgvBackups.AllowUserToAddRows = False
        Me.dgvBackups.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        Me.dgvBackups.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBackups.AutoGenerateColumns = False
        Me.dgvBackups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBackups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBackups.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBackups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PdFechaDataGridViewTextBoxColumn, Me.pdNombreBase, Me.PdArchivoDataGridViewTextBoxColumn, Me.dgbcRestaurar, Me.dgvbcEliminar})
        Me.dgvBackups.DataSource = Me.IBackupBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBackups.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBackups.Location = New System.Drawing.Point(20, 153)
        Me.dgvBackups.Name = "dgvBackups"
        Me.dgvBackups.ReadOnly = True
        Me.dgvBackups.RowHeadersVisible = False
        Me.dgvBackups.Size = New System.Drawing.Size(638, 268)
        Me.dgvBackups.TabIndex = 13
        '
        'PdFechaDataGridViewTextBoxColumn
        '
        Me.PdFechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PdFechaDataGridViewTextBoxColumn.DataPropertyName = "pdFecha"
        Me.PdFechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.PdFechaDataGridViewTextBoxColumn.Name = "PdFechaDataGridViewTextBoxColumn"
        Me.PdFechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdFechaDataGridViewTextBoxColumn.Width = 71
        '
        'pdNombreBase
        '
        Me.pdNombreBase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.pdNombreBase.DataPropertyName = "pdNombreBase"
        Me.pdNombreBase.HeaderText = "Base"
        Me.pdNombreBase.Name = "pdNombreBase"
        Me.pdNombreBase.ReadOnly = True
        Me.pdNombreBase.Width = 63
        '
        'PdArchivoDataGridViewTextBoxColumn
        '
        Me.PdArchivoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PdArchivoDataGridViewTextBoxColumn.DataPropertyName = "pdArchivo"
        Me.PdArchivoDataGridViewTextBoxColumn.HeaderText = "Archivo"
        Me.PdArchivoDataGridViewTextBoxColumn.Name = "PdArchivoDataGridViewTextBoxColumn"
        Me.PdArchivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PdArchivoDataGridViewTextBoxColumn.Width = 82
        '
        'dgbcRestaurar
        '
        Me.dgbcRestaurar.HeaderText = "Restaurar"
        Me.dgbcRestaurar.Name = "dgbcRestaurar"
        Me.dgbcRestaurar.ReadOnly = True
        '
        'dgvbcEliminar
        '
        Me.dgvbcEliminar.HeaderText = "Eliminar"
        Me.dgvbcEliminar.Name = "dgvbcEliminar"
        Me.dgvbcEliminar.ReadOnly = True
        '
        'IBackupBindingSource
        '
        Me.IBackupBindingSource.DataSource = GetType(Entidades.CopiasDeRespaldo.iBackup)
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.Transparent
        Me.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.btnGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(297, 27)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(199, 23)
        Me.btnGenerar.TabIndex = 11
        Me.btnGenerar.Text = "Generar Copia de Respaldo"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblBase)
        Me.GroupBox1.Controls.Add(Me.cmbBases)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(81, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 71)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.ForeColor = System.Drawing.Color.DimGray
        Me.lblBase.Location = New System.Drawing.Point(49, 32)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(93, 13)
        Me.lblBase.TabIndex = 14
        Me.lblBase.Text = "Base de datos:"
        '
        'cmbBases
        '
        Me.cmbBases.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBases.FormattingEnabled = True
        Me.cmbBases.Items.AddRange(New Object() {"Bitacoras", "Vales"})
        Me.cmbBases.Location = New System.Drawing.Point(148, 29)
        Me.cmbBases.Name = "cmbBases"
        Me.cmbBases.Size = New System.Drawing.Size(143, 21)
        Me.cmbBases.TabIndex = 13
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ValesRefinor.My.Resources.Resources.database30
        Me.PictureBox2.Location = New System.Drawing.Point(6, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'CtrlInformacion1
        '
        Me.CtrlInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlInformacion1.Location = New System.Drawing.Point(13, 427)
        Me.CtrlInformacion1.Name = "CtrlInformacion1"
        Me.CtrlInformacion1.pdInformacion = ""
        Me.CtrlInformacion1.Size = New System.Drawing.Size(645, 40)
        Me.CtrlInformacion1.TabIndex = 12
        '
        'CtrlMensaje
        '
        Me.CtrlMensaje.BackColor = System.Drawing.Color.Transparent
        Me.CtrlMensaje.Location = New System.Drawing.Point(12, 12)
        Me.CtrlMensaje.Name = "CtrlMensaje"
        Me.CtrlMensaje.pdErrores = CType(resources.GetObject("CtrlMensaje.pdErrores"), System.Collections.Generic.List(Of String))
        Me.CtrlMensaje.pdMensaje = ""
        Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
        Me.CtrlMensaje.Size = New System.Drawing.Size(646, 50)
        Me.CtrlMensaje.TabIndex = 15
        '
        'frmBackups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(670, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvBackups)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackups"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBackups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IBackupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CtrlInformacion1 As ValesRefinor.ctrlInformacion
    Friend WithEvents dgvBackups As System.Windows.Forms.DataGridView
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents IBackupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmbBases As System.Windows.Forms.ComboBox
    Friend WithEvents lblBase As System.Windows.Forms.Label
    Friend WithEvents PdFechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pdNombreBase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PdArchivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgbcRestaurar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgvbcEliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents CtrlMensaje As ValesRefinor.ctrlMensaje
End Class
