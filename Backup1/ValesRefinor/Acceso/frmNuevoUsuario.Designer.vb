<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoUsuario))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblPass2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.rdEmpleado = New System.Windows.Forms.RadioButton
        Me.rdAdministrador = New System.Windows.Forms.RadioButton
        Me.ctrlAUsuario = New Vales.ctrlAyuda
        Me.ctrlATipo = New Vales.ctrlAyuda
        Me.CtrlInformacion1 = New Vales.ctrlInformacion
        Me.ctrlANombre = New Vales.ctrlAyuda
        Me.ctrlAApellido = New Vales.ctrlAyuda
        Me.CtrlMensaje = New Vales.ctrlMensaje
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(312, 292)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(312, 323)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido:"
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
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
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
        'lblPass2
        '
        Me.lblPass2.AutoSize = True
        Me.lblPass2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass2.ForeColor = System.Drawing.Color.DimGray
        Me.lblPass2.Location = New System.Drawing.Point(319, 354)
        Me.lblPass2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass2.Name = "lblPass2"
        Me.lblPass2.Size = New System.Drawing.Size(58, 17)
        Me.lblPass2.TabIndex = 13
        Me.lblPass2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(268, 257)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Tipo de usuario:"
        '
        'rdEmpleado
        '
        Me.rdEmpleado.AutoSize = True
        Me.rdEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdEmpleado.ForeColor = System.Drawing.Color.Indigo
        Me.rdEmpleado.Location = New System.Drawing.Point(509, 255)
        Me.rdEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.rdEmpleado.Name = "rdEmpleado"
        Me.rdEmpleado.Size = New System.Drawing.Size(93, 21)
        Me.rdEmpleado.TabIndex = 18
        Me.rdEmpleado.TabStop = True
        Me.rdEmpleado.Text = "Empleado"
        Me.rdEmpleado.UseVisualStyleBackColor = True
        '
        'rdAdministrador
        '
        Me.rdAdministrador.AutoSize = True
        Me.rdAdministrador.Checked = True
        Me.rdAdministrador.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdAdministrador.ForeColor = System.Drawing.Color.Indigo
        Me.rdAdministrador.Location = New System.Drawing.Point(385, 255)
        Me.rdAdministrador.Margin = New System.Windows.Forms.Padding(4)
        Me.rdAdministrador.Name = "rdAdministrador"
        Me.rdAdministrador.Size = New System.Drawing.Size(116, 21)
        Me.rdAdministrador.TabIndex = 0
        Me.rdAdministrador.TabStop = True
        Me.rdAdministrador.Text = "Administrador"
        Me.rdAdministrador.UseVisualStyleBackColor = True
        '
        'ctrlAUsuario
        '
        Me.ctrlAUsuario.BackColor = System.Drawing.Color.Transparent
        Me.ctrlAUsuario.Cursor = System.Windows.Forms.Cursors.Help
        Me.ctrlAUsuario.Location = New System.Drawing.Point(533, 351)
        Me.ctrlAUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.ctrlAUsuario.Name = "ctrlAUsuario"
        Me.ctrlAUsuario.pdAyuda = ""
        Me.ctrlAUsuario.Size = New System.Drawing.Size(333, 33)
        Me.ctrlAUsuario.TabIndex = 21
        '
        'ctrlATipo
        '
        Me.ctrlATipo.BackColor = System.Drawing.Color.Transparent
        Me.ctrlATipo.Cursor = System.Windows.Forms.Cursors.Help
        Me.ctrlATipo.Location = New System.Drawing.Point(610, 255)
        Me.ctrlATipo.Margin = New System.Windows.Forms.Padding(4)
        Me.ctrlATipo.Name = "ctrlATipo"
        Me.ctrlATipo.pdAyuda = ""
        Me.ctrlATipo.Size = New System.Drawing.Size(333, 34)
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
        Me.ctrlANombre.Location = New System.Drawing.Point(533, 289)
        Me.ctrlANombre.Margin = New System.Windows.Forms.Padding(4)
        Me.ctrlANombre.Name = "ctrlANombre"
        Me.ctrlANombre.pdAyuda = ""
        Me.ctrlANombre.Size = New System.Drawing.Size(333, 34)
        Me.ctrlANombre.TabIndex = 10
        '
        'ctrlAApellido
        '
        Me.ctrlAApellido.BackColor = System.Drawing.Color.Transparent
        Me.ctrlAApellido.Cursor = System.Windows.Forms.Cursors.Help
        Me.ctrlAApellido.Location = New System.Drawing.Point(533, 320)
        Me.ctrlAApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.ctrlAApellido.Name = "ctrlAApellido"
        Me.ctrlAApellido.pdAyuda = ""
        Me.ctrlAApellido.Size = New System.Drawing.Size(333, 33)
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
        Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
        Me.CtrlMensaje.Size = New System.Drawing.Size(845, 50)
        Me.CtrlMensaje.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(385, 289)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(140, 23)
        Me.txtNombre.TabIndex = 22
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(385, 320)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(140, 23)
        Me.txtApellido.TabIndex = 23
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(385, 351)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(140, 23)
        Me.txtUsuario.TabIndex = 24
        '
        'frmNuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.ctrlAUsuario)
        Me.Controls.Add(Me.ctrlATipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdEmpleado)
        Me.Controls.Add(Me.rdAdministrador)
        Me.Controls.Add(Me.lblPass2)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.ctrlANombre)
        Me.Controls.Add(Me.ctrlAApellido)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuevoUsuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents CtrlMensaje As Vales.ctrlMensaje
    Friend WithEvents ctrlANombre As Vales.ctrlAyuda
    Friend WithEvents ctrlAApellido As Vales.ctrlAyuda
    Friend WithEvents CtrlInformacion1 As Vales.ctrlInformacion
    Friend WithEvents lblPass2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdEmpleado As System.Windows.Forms.RadioButton
    Friend WithEvents rdAdministrador As System.Windows.Forms.RadioButton
    Friend WithEvents ctrlATipo As Vales.ctrlAyuda
    Friend WithEvents ctrlAUsuario As Vales.ctrlAyuda
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
End Class
