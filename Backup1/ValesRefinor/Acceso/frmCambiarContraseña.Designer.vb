<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambiarContraseña))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblPass2 = New System.Windows.Forms.Label
        Me.CtrlInformacion1 = New Vales.ctrlInformacion
        Me.ctrlAPassActual = New Vales.ctrlAyuda
        Me.ctrlAPassword = New Vales.ctrlAyuda
        Me.CtrlMensaje = New Vales.ctrlMensaje
        Me.CtrlMensaje1 = New Vales.ctrlMensaje
        Me.txtPassActual = New System.Windows.Forms.TextBox
        Me.txtPassNueva = New System.Windows.Forms.TextBox
        Me.txtPassNueva2 = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(325, 275)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña Actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(327, 306)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nueva contraseña:"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.Transparent
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnActualizar.Location = New System.Drawing.Point(724, 585)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(133, 30)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Cambiar"
        Me.btnActualizar.UseVisualStyleBackColor = False
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
        Me.lblPass2.Location = New System.Drawing.Point(264, 337)
        Me.lblPass2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass2.Name = "lblPass2"
        Me.lblPass2.Size = New System.Drawing.Size(195, 17)
        Me.lblPass2.TabIndex = 13
        Me.lblPass2.Text = "Repetir la nueva contraseña:"
        '
        'CtrlInformacion1
        '
        Me.CtrlInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlInformacion1.Location = New System.Drawing.Point(13, 563)
        Me.CtrlInformacion1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlInformacion1.Name = "CtrlInformacion1"
        Me.CtrlInformacion1.pdInformacion = "Ingrese su contraseña actual y la nueva contraseña por duplicado. Presione el bot" & _
            "ón ""Cambiar"" para actualizarla."
        Me.CtrlInformacion1.Size = New System.Drawing.Size(636, 52)
        Me.CtrlInformacion1.TabIndex = 12
        '
        'ctrlAPassActual
        '
        Me.ctrlAPassActual.BackColor = System.Drawing.Color.Transparent
        Me.ctrlAPassActual.Cursor = System.Windows.Forms.Cursors.Help
        Me.ctrlAPassActual.Location = New System.Drawing.Point(615, 272)
        Me.ctrlAPassActual.Margin = New System.Windows.Forms.Padding(4)
        Me.ctrlAPassActual.Name = "ctrlAPassActual"
        Me.ctrlAPassActual.pdAyuda = ""
        Me.ctrlAPassActual.Size = New System.Drawing.Size(242, 34)
        Me.ctrlAPassActual.TabIndex = 10
        '
        'ctrlAPassword
        '
        Me.ctrlAPassword.BackColor = System.Drawing.Color.Transparent
        Me.ctrlAPassword.Cursor = System.Windows.Forms.Cursors.Help
        Me.ctrlAPassword.Location = New System.Drawing.Point(615, 303)
        Me.ctrlAPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.ctrlAPassword.Name = "ctrlAPassword"
        Me.ctrlAPassword.pdAyuda = ""
        Me.ctrlAPassword.Size = New System.Drawing.Size(242, 33)
        Me.ctrlAPassword.TabIndex = 11
        '
        'CtrlMensaje
        '
        Me.CtrlMensaje.BackColor = System.Drawing.Color.Transparent
        Me.CtrlMensaje.Location = New System.Drawing.Point(27, 26)
        Me.CtrlMensaje.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlMensaje.Name = "CtrlMensaje"
        Me.CtrlMensaje.pdErrores = CType(resources.GetObject("CtrlMensaje.pdErrores"), System.Collections.Generic.List(Of String))
        Me.CtrlMensaje.pdMensaje = ""
        Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
        Me.CtrlMensaje.Size = New System.Drawing.Size(840, 65)
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
        'txtPassActual
        '
        Me.txtPassActual.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassActual.Location = New System.Drawing.Point(467, 272)
        Me.txtPassActual.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassActual.Name = "txtPassActual"
        Me.txtPassActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassActual.Size = New System.Drawing.Size(140, 23)
        Me.txtPassActual.TabIndex = 14
        '
        'txtPassNueva
        '
        Me.txtPassNueva.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassNueva.Location = New System.Drawing.Point(467, 303)
        Me.txtPassNueva.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassNueva.Name = "txtPassNueva"
        Me.txtPassNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassNueva.Size = New System.Drawing.Size(140, 23)
        Me.txtPassNueva.TabIndex = 15
        '
        'txtPassNueva2
        '
        Me.txtPassNueva2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassNueva2.Location = New System.Drawing.Point(467, 334)
        Me.txtPassNueva2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassNueva2.Name = "txtPassNueva2"
        Me.txtPassNueva2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassNueva2.Size = New System.Drawing.Size(140, 23)
        Me.txtPassNueva2.TabIndex = 16
        '
        'frmCambiarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtPassNueva2)
        Me.Controls.Add(Me.txtPassNueva)
        Me.Controls.Add(Me.txtPassActual)
        Me.Controls.Add(Me.lblPass2)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.ctrlAPassActual)
        Me.Controls.Add(Me.ctrlAPassword)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambiarContraseña"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents CtrlMensaje As Vales.ctrlMensaje
    Friend WithEvents CtrlMensaje1 As Vales.ctrlMensaje
    Friend WithEvents ctrlAPassActual As Vales.ctrlAyuda
    Friend WithEvents ctrlAPassword As Vales.ctrlAyuda
    Friend WithEvents CtrlInformacion1 As Vales.ctrlInformacion
    Friend WithEvents lblPass2 As System.Windows.Forms.Label
    Friend WithEvents txtPassActual As System.Windows.Forms.TextBox
    Friend WithEvents txtPassNueva As System.Windows.Forms.TextBox
    Friend WithEvents txtPassNueva2 As System.Windows.Forms.TextBox
End Class
