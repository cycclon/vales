<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoCliente))
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblApellido = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.rdPersona = New System.Windows.Forms.RadioButton
        Me.rdEntidad = New System.Windows.Forms.RadioButton
        Me.ctrlATipo = New ValesRefinor.ctrlAyuda
        Me.CtrlInformacion1 = New ValesRefinor.ctrlInformacion
        Me.ctrlANombre = New ValesRefinor.ctrlAyuda
        Me.ctrlAApellido = New ValesRefinor.ctrlAyuda
        Me.CtrlMensaje = New ValesRefinor.ctrlMensaje
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtApellido = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.DimGray
        Me.lblNombre.Location = New System.Drawing.Point(284, 307)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(133, 17)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.Color.DimGray
        Me.lblApellido.Location = New System.Drawing.Point(352, 338)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(65, 17)
        Me.lblApellido.TabIndex = 1
        Me.lblApellido.Text = "Apellido:"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAceptar.Location = New System.Drawing.Point(724, 585)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(133, 30)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(311, 272)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Tipo de cliente:"
        '
        'rdPersona
        '
        Me.rdPersona.AutoSize = True
        Me.rdPersona.Checked = True
        Me.rdPersona.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPersona.ForeColor = System.Drawing.Color.Indigo
        Me.rdPersona.Location = New System.Drawing.Point(425, 270)
        Me.rdPersona.Margin = New System.Windows.Forms.Padding(4)
        Me.rdPersona.Name = "rdPersona"
        Me.rdPersona.Size = New System.Drawing.Size(77, 21)
        Me.rdPersona.TabIndex = 18
        Me.rdPersona.TabStop = True
        Me.rdPersona.Text = "Persona"
        Me.rdPersona.UseVisualStyleBackColor = True
        '
        'rdEntidad
        '
        Me.rdEntidad.AutoSize = True
        Me.rdEntidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdEntidad.ForeColor = System.Drawing.Color.Indigo
        Me.rdEntidad.Location = New System.Drawing.Point(510, 270)
        Me.rdEntidad.Margin = New System.Windows.Forms.Padding(4)
        Me.rdEntidad.Name = "rdEntidad"
        Me.rdEntidad.Size = New System.Drawing.Size(76, 21)
        Me.rdEntidad.TabIndex = 0
        Me.rdEntidad.Text = "Entidad"
        Me.rdEntidad.UseVisualStyleBackColor = True
        '
        'ctrlATipo
        '
        Me.ctrlATipo.BackColor = System.Drawing.Color.Transparent
        Me.ctrlATipo.Cursor = System.Windows.Forms.Cursors.Help
        Me.ctrlATipo.Location = New System.Drawing.Point(594, 270)
        Me.ctrlATipo.Margin = New System.Windows.Forms.Padding(4)
        Me.ctrlATipo.Name = "ctrlATipo"
        Me.ctrlATipo.pdAyuda = ""
        Me.ctrlATipo.Size = New System.Drawing.Size(263, 34)
        Me.ctrlATipo.TabIndex = 20
        '
        'CtrlInformacion1
        '
        Me.CtrlInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlInformacion1.Location = New System.Drawing.Point(13, 563)
        Me.CtrlInformacion1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlInformacion1.Name = "CtrlInformacion1"
        Me.CtrlInformacion1.pdInformacion = "Complete los campos y presione el botón ""Aceptar"" para registrar el nuevo usuario" & _
            "."
        Me.CtrlInformacion1.Size = New System.Drawing.Size(636, 52)
        Me.CtrlInformacion1.TabIndex = 12
        '
        'ctrlANombre
        '
        Me.ctrlANombre.BackColor = System.Drawing.Color.Transparent
        Me.ctrlANombre.Cursor = System.Windows.Forms.Cursors.Help
        Me.ctrlANombre.Location = New System.Drawing.Point(594, 304)
        Me.ctrlANombre.Margin = New System.Windows.Forms.Padding(4)
        Me.ctrlANombre.Name = "ctrlANombre"
        Me.ctrlANombre.pdAyuda = ""
        Me.ctrlANombre.Size = New System.Drawing.Size(263, 34)
        Me.ctrlANombre.TabIndex = 10
        '
        'ctrlAApellido
        '
        Me.ctrlAApellido.BackColor = System.Drawing.Color.Transparent
        Me.ctrlAApellido.Cursor = System.Windows.Forms.Cursors.Help
        Me.ctrlAApellido.Location = New System.Drawing.Point(594, 335)
        Me.ctrlAApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.ctrlAApellido.Name = "ctrlAApellido"
        Me.ctrlAApellido.pdAyuda = ""
        Me.ctrlAApellido.Size = New System.Drawing.Size(263, 33)
        Me.ctrlAApellido.TabIndex = 11
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
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(425, 304)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(140, 23)
        Me.txtNombre.TabIndex = 23
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(425, 335)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(140, 23)
        Me.txtApellido.TabIndex = 24
        '
        'frmNuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.ctrlATipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdPersona)
        Me.Controls.Add(Me.rdEntidad)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.ctrlANombre)
        Me.Controls.Add(Me.ctrlAApellido)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevoCliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents CtrlMensaje As ValesRefinor.ctrlMensaje
    Friend WithEvents ctrlANombre As ValesRefinor.ctrlAyuda
    Friend WithEvents ctrlAApellido As ValesRefinor.ctrlAyuda
    Friend WithEvents CtrlInformacion1 As ValesRefinor.ctrlInformacion
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdPersona As System.Windows.Forms.RadioButton
    Friend WithEvents rdEntidad As System.Windows.Forms.RadioButton
    Friend WithEvents ctrlATipo As ValesRefinor.ctrlAyuda
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
End Class
