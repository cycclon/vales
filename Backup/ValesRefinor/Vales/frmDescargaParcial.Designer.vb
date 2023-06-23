<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescargaParcial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescargaParcial))
        Me.lblCod = New System.Windows.Forms.Label
        Me.btnDescargado = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pbImagen = New System.Windows.Forms.PictureBox
        Me.lblMonto = New System.Windows.Forms.Label
        Me.lblTipo = New System.Windows.Forms.Label
        Me.lblImporte = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblCliente = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDescargado = New System.Windows.Forms.Label
        Me.btnVer = New System.Windows.Forms.Button
        Me.pbIncorrecto = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblAyuda = New System.Windows.Forms.Label
        Me.tmrTarjeta = New System.Windows.Forms.Timer(Me.components)
        Me.lblCancelar = New System.Windows.Forms.Label
        Me.ctrlADescargado = New ValesRefinor.ctrlAyuda
        Me.CtrlInformacion1 = New ValesRefinor.ctrlInformacion
        Me.CtrlMensaje = New ValesRefinor.ctrlMensaje
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtDescargado = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIncorrecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod.ForeColor = System.Drawing.Color.DimGray
        Me.lblCod.Location = New System.Drawing.Point(173, 171)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(98, 13)
        Me.lblCod.TabIndex = 0
        Me.lblCod.Text = "Código de vale:"
        Me.lblCod.Visible = False
        '
        'btnDescargado
        '
        Me.btnDescargado.BackColor = System.Drawing.Color.Transparent
        Me.btnDescargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDescargado.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.btnDescargado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnDescargado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnDescargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescargado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescargado.Location = New System.Drawing.Point(558, 445)
        Me.btnDescargado.Name = "btnDescargado"
        Me.btnDescargado.Size = New System.Drawing.Size(100, 23)
        Me.btnDescargado.TabIndex = 7
        Me.btnDescargado.Text = "Descargar"
        Me.btnDescargado.UseVisualStyleBackColor = False
        Me.btnDescargado.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pbImagen)
        Me.GroupBox1.Controls.Add(Me.lblMonto)
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.lblImporte)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(65, 193)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 171)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle del Vale:"
        Me.GroupBox1.Visible = False
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.Color.Transparent
        Me.pbImagen.Image = Global.ValesRefinor.My.Resources.Resources.descargado
        Me.pbImagen.Location = New System.Drawing.Point(432, 90)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(103, 75)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 9
        Me.pbImagen.TabStop = False
        Me.pbImagen.Visible = False
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(373, 76)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(44, 16)
        Me.lblMonto.TabIndex = 8
        Me.lblMonto.Text = "$100"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(373, 40)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(53, 16)
        Me.lblTipo.TabIndex = 7
        Me.lblTipo.Text = "Monto"
        '
        'lblImporte
        '
        Me.lblImporte.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporte.ForeColor = System.Drawing.Color.DimGray
        Me.lblImporte.Location = New System.Drawing.Point(267, 76)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(100, 16)
        Me.lblImporte.TabIndex = 6
        Me.lblImporte.Text = "Disponible:"
        Me.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(325, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tipo:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(134, 76)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(87, 16)
        Me.lblCliente.TabIndex = 4
        Me.lblCliente.Text = "Juan Perez"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(69, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cliente:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(134, 40)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(101, 16)
        Me.lblCodigo.TabIndex = 2
        Me.lblCodigo.Text = "AXKKEOJDKZ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(17, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código de vale:"
        '
        'lblDescargado
        '
        Me.lblDescargado.AutoSize = True
        Me.lblDescargado.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescargado.ForeColor = System.Drawing.Color.DimGray
        Me.lblDescargado.Location = New System.Drawing.Point(67, 372)
        Me.lblDescargado.Name = "lblDescargado"
        Me.lblDescargado.Size = New System.Drawing.Size(136, 16)
        Me.lblDescargado.TabIndex = 10
        Me.lblDescargado.Text = "Monto descargado:"
        Me.lblDescargado.Visible = False
        '
        'btnVer
        '
        Me.btnVer.BackColor = System.Drawing.Color.Transparent
        Me.btnVer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVer.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.btnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVer.Location = New System.Drawing.Point(398, 166)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(100, 23)
        Me.btnVer.TabIndex = 10
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = False
        Me.btnVer.Visible = False
        '
        'pbIncorrecto
        '
        Me.pbIncorrecto.Image = Global.ValesRefinor.My.Resources.Resources.incorrecto
        Me.pbIncorrecto.Location = New System.Drawing.Point(202, 193)
        Me.pbIncorrecto.Name = "pbIncorrecto"
        Me.pbIncorrecto.Size = New System.Drawing.Size(267, 171)
        Me.pbIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbIncorrecto.TabIndex = 10
        Me.pbIncorrecto.TabStop = False
        Me.pbIncorrecto.Visible = False
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
        'lblAyuda
        '
        Me.lblAyuda.AutoSize = True
        Me.lblAyuda.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyuda.ForeColor = System.Drawing.Color.Green
        Me.lblAyuda.Location = New System.Drawing.Point(79, 97)
        Me.lblAyuda.Name = "lblAyuda"
        Me.lblAyuda.Size = New System.Drawing.Size(512, 21)
        Me.lblAyuda.TabIndex = 15
        Me.lblAyuda.Text = "Escanee su tarjeta de acceso con el lector de códigos de barras."
        '
        'tmrTarjeta
        '
        Me.tmrTarjeta.Interval = 1000
        '
        'lblCancelar
        '
        Me.lblCancelar.AutoSize = True
        Me.lblCancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelar.ForeColor = System.Drawing.Color.Green
        Me.lblCancelar.Location = New System.Drawing.Point(188, 118)
        Me.lblCancelar.Name = "lblCancelar"
        Me.lblCancelar.Size = New System.Drawing.Size(246, 16)
        Me.lblCancelar.TabIndex = 16
        Me.lblCancelar.Text = "Presione la tecla ""Esc"" para cancelar."
        Me.lblCancelar.Visible = False
        '
        'ctrlADescargado
        '
        Me.ctrlADescargado.BackColor = System.Drawing.Color.Transparent
        Me.ctrlADescargado.Cursor = System.Windows.Forms.Cursors.Help
        Me.ctrlADescargado.Location = New System.Drawing.Point(330, 369)
        Me.ctrlADescargado.Name = "ctrlADescargado"
        Me.ctrlADescargado.pdAyuda = ""
        Me.ctrlADescargado.Size = New System.Drawing.Size(250, 25)
        Me.ctrlADescargado.TabIndex = 12
        Me.ctrlADescargado.Visible = False
        '
        'CtrlInformacion1
        '
        Me.CtrlInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlInformacion1.Location = New System.Drawing.Point(12, 400)
        Me.CtrlInformacion1.Name = "CtrlInformacion1"
        Me.CtrlInformacion1.pdInformacion = "Si la sesión no fue iniciada, escanee su tarjeta de acceso. Luego escanee el vale" & _
            " e instroduzca el monto descargado en el campo correspondiente. Luego presione e" & _
            "l botón ""Descargar""."
        Me.CtrlInformacion1.Size = New System.Drawing.Size(438, 68)
        Me.CtrlInformacion1.TabIndex = 13
        '
        'CtrlMensaje
        '
        Me.CtrlMensaje.BackColor = System.Drawing.Color.Transparent
        Me.CtrlMensaje.Location = New System.Drawing.Point(12, 12)
        Me.CtrlMensaje.Name = "CtrlMensaje"
        Me.CtrlMensaje.pdErrores = CType(resources.GetObject("CtrlMensaje.pdErrores"), System.Collections.Generic.List(Of String))
        Me.CtrlMensaje.pdMensaje = ""
        Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
        Me.CtrlMensaje.Size = New System.Drawing.Size(646, 51)
        Me.CtrlMensaje.TabIndex = 11
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(277, 168)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(115, 21)
        Me.txtCodigo.TabIndex = 17
        '
        'txtDescargado
        '
        Me.txtDescargado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescargado.Location = New System.Drawing.Point(209, 371)
        Me.txtDescargado.Name = "txtDescargado"
        Me.txtDescargado.Size = New System.Drawing.Size(115, 21)
        Me.txtDescargado.TabIndex = 18
        '
        'frmDescargaParcial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(670, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDescargado)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCancelar)
        Me.Controls.Add(Me.lblAyuda)
        Me.Controls.Add(Me.ctrlADescargado)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.lblDescargado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnDescargado)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.pbIncorrecto)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDescargaParcial"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIncorrecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDescargado As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents CtrlMensaje As ValesRefinor.ctrlMensaje
    Friend WithEvents pbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents pbIncorrecto As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescargado As System.Windows.Forms.Label
    Friend WithEvents ctrlADescargado As ValesRefinor.ctrlAyuda
    Friend WithEvents CtrlInformacion1 As ValesRefinor.ctrlInformacion
    Friend WithEvents lblAyuda As System.Windows.Forms.Label
    Friend WithEvents tmrTarjeta As System.Windows.Forms.Timer
    Friend WithEvents lblCancelar As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescargado As System.Windows.Forms.TextBox
End Class
