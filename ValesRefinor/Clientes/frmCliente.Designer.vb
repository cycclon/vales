<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        Me.lblTipoUsuario = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnDetalleCuenta = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.lblSaldoLitros = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblSaldoPesos = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbOpciones = New System.Windows.Forms.GroupBox
        Me.btnOpcion = New System.Windows.Forms.Button
        Me.pbOpcion = New System.Windows.Forms.PictureBox
        Me.pbEstado = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CtrlInformacion1 = New Vales.ctrlInformacion
        Me.CtrlMensaje = New Vales.ctrlMensaje
        Me.CtrlMensaje1 = New Vales.ctrlMensaje
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOpciones.SuspendLayout()
        CType(Me.pbOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTipoUsuario
        '
        Me.lblTipoUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoUsuario.ForeColor = System.Drawing.Color.DimGray
        Me.lblTipoUsuario.Location = New System.Drawing.Point(141, 158)
        Me.lblTipoUsuario.Name = "lblTipoUsuario"
        Me.lblTipoUsuario.Size = New System.Drawing.Size(117, 16)
        Me.lblTipoUsuario.TabIndex = 14
        Me.lblTipoUsuario.Text = "Cliente:"
        Me.lblTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Indigo
        Me.lblNombre.Location = New System.Drawing.Point(264, 158)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(132, 17)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Nombre Completo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.lblSaldoLitros)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblSaldoPesos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(59, 263)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(752, 164)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CUENTA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDetalleCuenta)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(487, 37)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(259, 90)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'btnDetalleCuenta
        '
        Me.btnDetalleCuenta.BackColor = System.Drawing.Color.Transparent
        Me.btnDetalleCuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDetalleCuenta.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnDetalleCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnDetalleCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnDetalleCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalleCuenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalleCuenta.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnDetalleCuenta.Location = New System.Drawing.Point(62, 31)
        Me.btnDetalleCuenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDetalleCuenta.Name = "btnDetalleCuenta"
        Me.btnDetalleCuenta.Size = New System.Drawing.Size(180, 28)
        Me.btnDetalleCuenta.TabIndex = 27
        Me.btnDetalleCuenta.Text = "Detalle de cuenta"
        Me.btnDetalleCuenta.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Vales.My.Resources.Resources.cajgri50
        Me.PictureBox2.Location = New System.Drawing.Point(6, 20)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Vales.My.Resources.Resources.nafver50
        Me.PictureBox4.Location = New System.Drawing.Point(8, 83)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Vales.My.Resources.Resources.monam50
        Me.PictureBox3.Location = New System.Drawing.Point(8, 25)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'lblSaldoLitros
        '
        Me.lblSaldoLitros.AutoSize = True
        Me.lblSaldoLitros.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoLitros.ForeColor = System.Drawing.Color.Indigo
        Me.lblSaldoLitros.Location = New System.Drawing.Point(233, 94)
        Me.lblSaldoLitros.Name = "lblSaldoLitros"
        Me.lblSaldoLitros.Size = New System.Drawing.Size(53, 24)
        Me.lblSaldoLitros.TabIndex = 23
        Me.lblSaldoLitros.Text = "0 lts."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(64, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Saldo en litros:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSaldoPesos
        '
        Me.lblSaldoPesos.AutoSize = True
        Me.lblSaldoPesos.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoPesos.ForeColor = System.Drawing.Color.Indigo
        Me.lblSaldoPesos.Location = New System.Drawing.Point(233, 37)
        Me.lblSaldoPesos.Name = "lblSaldoPesos"
        Me.lblSaldoPesos.Size = New System.Drawing.Size(34, 24)
        Me.lblSaldoPesos.TabIndex = 21
        Me.lblSaldoPesos.Text = "$0"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(64, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Saldo en pesos:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbOpciones
        '
        Me.gbOpciones.Controls.Add(Me.btnOpcion)
        Me.gbOpciones.Controls.Add(Me.pbOpcion)
        Me.gbOpciones.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOpciones.ForeColor = System.Drawing.Color.SteelBlue
        Me.gbOpciones.Location = New System.Drawing.Point(618, 101)
        Me.gbOpciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbOpciones.Name = "gbOpciones"
        Me.gbOpciones.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbOpciones.Size = New System.Drawing.Size(240, 74)
        Me.gbOpciones.TabIndex = 18
        Me.gbOpciones.TabStop = False
        Me.gbOpciones.Text = "OPCIONES"
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
        Me.btnOpcion.Location = New System.Drawing.Point(49, 28)
        Me.btnOpcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(180, 28)
        Me.btnOpcion.TabIndex = 19
        Me.btnOpcion.Text = "Desactivar"
        Me.btnOpcion.UseVisualStyleBackColor = False
        '
        'pbOpcion
        '
        Me.pbOpcion.Location = New System.Drawing.Point(7, 25)
        Me.pbOpcion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbOpcion.Name = "pbOpcion"
        Me.pbOpcion.Size = New System.Drawing.Size(35, 37)
        Me.pbOpcion.TabIndex = 19
        Me.pbOpcion.TabStop = False
        '
        'pbEstado
        '
        Me.pbEstado.Location = New System.Drawing.Point(77, 141)
        Me.pbEstado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbEstado.Name = "pbEstado"
        Me.pbEstado.Size = New System.Drawing.Size(58, 62)
        Me.pbEstado.TabIndex = 16
        Me.pbEstado.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Vales.My.Resources.Resources.Cuerpo
        Me.PictureBox1.Location = New System.Drawing.Point(657, 392)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'CtrlInformacion1
        '
        Me.CtrlInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlInformacion1.Location = New System.Drawing.Point(12, 566)
        Me.CtrlInformacion1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CtrlInformacion1.Name = "CtrlInformacion1"
        Me.CtrlInformacion1.pdInformacion = "Ficha de cliente. El color azul en el ícono indica que el cliente se encuentra ac" & _
            "tivo. El color rojo indica inactividad."
        Me.CtrlInformacion1.Size = New System.Drawing.Size(639, 49)
        Me.CtrlInformacion1.TabIndex = 12
        '
        'CtrlMensaje
        '
        Me.CtrlMensaje.BackColor = System.Drawing.Color.Transparent
        Me.CtrlMensaje.Location = New System.Drawing.Point(12, 13)
        Me.CtrlMensaje.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CtrlMensaje.Name = "CtrlMensaje"
        Me.CtrlMensaje.pdErrores = CType(resources.GetObject("CtrlMensaje.pdErrores"), System.Collections.Generic.List(Of String))
        Me.CtrlMensaje.pdMensaje = ""
        Me.CtrlMensaje.pdTipo = Vales.ctrlMensaje.enTipoMensaje.msgError
        Me.CtrlMensaje.Size = New System.Drawing.Size(846, 50)
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
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbOpciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbEstado)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTipoUsuario)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOpciones.ResumeLayout(False)
        CType(Me.pbOpcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CtrlMensaje As Vales.ctrlMensaje
    Friend WithEvents CtrlMensaje1 As Vales.ctrlMensaje
    Friend WithEvents CtrlInformacion1 As Vales.ctrlInformacion
    Friend WithEvents lblTipoUsuario As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents pbEstado As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnOpcion As System.Windows.Forms.Button
    Friend WithEvents pbOpcion As System.Windows.Forms.PictureBox
    Friend WithEvents lblSaldoPesos As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSaldoLitros As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDetalleCuenta As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
