<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTipoUsuario = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView
        Me.PdFechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pdMensaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IBitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbOpciones = New System.Windows.Forms.GroupBox
        Me.btnTarjeta = New System.Windows.Forms.Button
        Me.btnRestablecer = New System.Windows.Forms.Button
        Me.pbAcceso = New System.Windows.Forms.PictureBox
        Me.pbRestablecer = New System.Windows.Forms.PictureBox
        Me.btnOpcion = New System.Windows.Forms.Button
        Me.pbOpcion = New System.Windows.Forms.PictureBox
        Me.pbEstado = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CtrlInformacion1 = New Vales.ctrlInformacion
        Me.CtrlMensaje = New Vales.ctrlMensaje
        Me.CtrlMensaje1 = New Vales.ctrlMensaje
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IBitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpciones.SuspendLayout()
        CType(Me.pbAcceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRestablecer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.Indigo
        Me.lblUsuario.Location = New System.Drawing.Point(351, 154)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(54, 17)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(207, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre de Usuario:"
        '
        'lblTipoUsuario
        '
        Me.lblTipoUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoUsuario.ForeColor = System.Drawing.Color.DimGray
        Me.lblTipoUsuario.Location = New System.Drawing.Point(210, 128)
        Me.lblTipoUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoUsuario.Name = "lblTipoUsuario"
        Me.lblTipoUsuario.Size = New System.Drawing.Size(133, 17)
        Me.lblTipoUsuario.TabIndex = 14
        Me.lblTipoUsuario.Text = "Administrador:"
        Me.lblTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Indigo
        Me.lblNombre.Location = New System.Drawing.Point(351, 128)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(132, 17)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Nombre Completo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvUsuarios)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(17, 227)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(840, 328)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ULTIMAS BITACORAS"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dgvUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvUsuarios.AutoGenerateColumns = False
        Me.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PdFechaDataGridViewTextBoxColumn, Me.pdMensaje})
        Me.dgvUsuarios.DataSource = Me.IBitacoraBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsuarios.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuarios.Location = New System.Drawing.Point(4, 24)
        Me.dgvUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.Size = New System.Drawing.Size(832, 300)
        Me.dgvUsuarios.TabIndex = 18
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
        'pdMensaje
        '
        Me.pdMensaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.pdMensaje.DataPropertyName = "pdMensaje"
        Me.pdMensaje.HeaderText = "Mensaje"
        Me.pdMensaje.Name = "pdMensaje"
        Me.pdMensaje.ReadOnly = True
        '
        'IBitacoraBindingSource
        '
        Me.IBitacoraBindingSource.DataSource = GetType(Entidades.Bitacoras.iBitacora)
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnTarjeta)
        Me.gbOpciones.Controls.Add(Me.btnRestablecer)
        Me.gbOpciones.Controls.Add(Me.pbAcceso)
        Me.gbOpciones.Controls.Add(Me.pbRestablecer)
        Me.gbOpciones.Controls.Add(Me.btnOpcion)
        Me.gbOpciones.Controls.Add(Me.pbOpcion)
        Me.gbOpciones.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOpciones.ForeColor = System.Drawing.Color.SteelBlue
        Me.gbOpciones.Location = New System.Drawing.Point(594, 71)
        Me.gbOpciones.Margin = New System.Windows.Forms.Padding(4)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Padding = New System.Windows.Forms.Padding(4)
        Me.gbOpciones.Size = New System.Drawing.Size(263, 148)
        Me.gbOpciones.TabIndex = 18
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "OPCIONES"
        '
        'btnTarjeta
        '
        Me.btnTarjeta.BackColor = System.Drawing.Color.Transparent
        Me.btnTarjeta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTarjeta.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnTarjeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTarjeta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTarjeta.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnTarjeta.Location = New System.Drawing.Point(46, 102)
        Me.btnTarjeta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTarjeta.Name = "btnTarjeta"
        Me.btnTarjeta.Size = New System.Drawing.Size(203, 30)
        Me.btnTarjeta.TabIndex = 19
        Me.btnTarjeta.Text = "Crear Tarjeta de Acceso"
        Me.btnTarjeta.UseVisualStyleBackColor = False
        '
        'btnRestablecer
        '
        Me.btnRestablecer.BackColor = System.Drawing.Color.Transparent
        Me.btnRestablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestablecer.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnRestablecer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnRestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestablecer.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestablecer.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnRestablecer.Location = New System.Drawing.Point(46, 65)
        Me.btnRestablecer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(203, 30)
        Me.btnRestablecer.TabIndex = 21
        Me.btnRestablecer.Text = "Reestablecer Contraseña"
        Me.btnRestablecer.UseVisualStyleBackColor = False
        Me.btnRestablecer.Visible = False
        '
        'pbAcceso
        '
        Me.pbAcceso.Image = Global.Vales.My.Resources.Resources.card30
        Me.pbAcceso.Location = New System.Drawing.Point(8, 102)
        Me.pbAcceso.Margin = New System.Windows.Forms.Padding(4)
        Me.pbAcceso.Name = "pbAcceso"
        Me.pbAcceso.Size = New System.Drawing.Size(30, 30)
        Me.pbAcceso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbAcceso.TabIndex = 19
        Me.pbAcceso.TabStop = False
        '
        'pbRestablecer
        '
        Me.pbRestablecer.Image = Global.Vales.My.Resources.Resources.llavenar30tach
        Me.pbRestablecer.Location = New System.Drawing.Point(8, 64)
        Me.pbRestablecer.Margin = New System.Windows.Forms.Padding(4)
        Me.pbRestablecer.Name = "pbRestablecer"
        Me.pbRestablecer.Size = New System.Drawing.Size(30, 30)
        Me.pbRestablecer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbRestablecer.TabIndex = 20
        Me.pbRestablecer.TabStop = False
        Me.pbRestablecer.Visible = False
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
        Me.btnOpcion.Location = New System.Drawing.Point(46, 27)
        Me.btnOpcion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(203, 30)
        Me.btnOpcion.TabIndex = 19
        Me.btnOpcion.Text = "Desactivar"
        Me.btnOpcion.UseVisualStyleBackColor = False
        '
        'pbOpcion
        '
        Me.pbOpcion.Location = New System.Drawing.Point(8, 26)
        Me.pbOpcion.Margin = New System.Windows.Forms.Padding(4)
        Me.pbOpcion.Name = "pbOpcion"
        Me.pbOpcion.Size = New System.Drawing.Size(30, 30)
        Me.pbOpcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbOpcion.TabIndex = 19
        Me.pbOpcion.TabStop = False
        '
        'pbEstado
        '
        Me.pbEstado.Location = New System.Drawing.Point(132, 118)
        Me.pbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.pbEstado.Name = "pbEstado"
        Me.pbEstado.Size = New System.Drawing.Size(67, 65)
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
        'CtrlInformacion1
        '
        Me.CtrlInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlInformacion1.Location = New System.Drawing.Point(13, 563)
        Me.CtrlInformacion1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlInformacion1.Name = "CtrlInformacion1"
        Me.CtrlInformacion1.pdInformacion = "Ficha de usuario. El color azul en el ícono indica que el usuario se encuentra ac" & _
            "tivo. El color rojo indica inactividad."
        Me.CtrlInformacion1.Size = New System.Drawing.Size(622, 52)
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
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbEstado)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTipoUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuario"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IBitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpciones.ResumeLayout(False)
        Me.gbOpciones.PerformLayout()
        CType(Me.pbAcceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRestablecer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOpcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CtrlMensaje As Vales.ctrlMensaje
    Friend WithEvents CtrlMensaje1 As Vales.ctrlMensaje
    Friend WithEvents CtrlInformacion1 As Vales.ctrlInformacion
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTipoUsuario As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents pbEstado As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents IBitacoraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents pbOpcion As System.Windows.Forms.PictureBox
    Friend WithEvents PdFechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pdMensaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pbRestablecer As System.Windows.Forms.PictureBox
    Friend WithEvents btnRestablecer As System.Windows.Forms.Button
    Friend WithEvents btnTarjeta As System.Windows.Forms.Button
    Friend WithEvents pbAcceso As System.Windows.Forms.PictureBox
End Class
