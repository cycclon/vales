<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescargar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescargar))
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
        Me.pbIncorrecto = New System.Windows.Forms.PictureBox
        Me.btnVer = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblAyuda = New System.Windows.Forms.Label
        Me.tmrTarjeta = New System.Windows.Forms.Timer(Me.components)
        Me.lblCancelar = New System.Windows.Forms.Label
        Me.lstVales = New System.Windows.Forms.ListBox
        Me.lblTTotal = New System.Windows.Forms.Label
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.CtrlInformacion1 = New Vales.ctrlInformacion
        Me.CtrlMensaje = New Vales.ctrlMensaje
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIncorrecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod.ForeColor = System.Drawing.Color.DimGray
        Me.lblCod.Location = New System.Drawing.Point(227, 157)
        Me.lblCod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(115, 17)
        Me.lblCod.TabIndex = 0
        Me.lblCod.Text = "Código de vale:"
        Me.lblCod.Visible = False
        '
        'btnDescargado
        '
        Me.btnDescargado.BackColor = System.Drawing.Color.Transparent
        Me.btnDescargado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDescargado.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnDescargado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnDescargado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnDescargado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescargado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescargado.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnDescargado.Location = New System.Drawing.Point(724, 585)
        Me.btnDescargado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDescargado.Name = "btnDescargado"
        Me.btnDescargado.Size = New System.Drawing.Size(133, 30)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(16, 190)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(659, 135)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETALLE DEL VALE ESCANEADO"
        Me.GroupBox1.Visible = False
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.Color.Transparent
        Me.pbImagen.Image = Global.Vales.My.Resources.Resources.descargado
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
        'pbIncorrecto
        '
        Me.pbIncorrecto.Image = Global.Vales.My.Resources.Resources.incorrecto
        Me.pbIncorrecto.Location = New System.Drawing.Point(351, 190)
        Me.pbIncorrecto.Margin = New System.Windows.Forms.Padding(4)
        Me.pbIncorrecto.Name = "pbIncorrecto"
        Me.pbIncorrecto.Size = New System.Drawing.Size(196, 126)
        Me.pbIncorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIncorrecto.TabIndex = 10
        Me.pbIncorrecto.TabStop = False
        Me.pbIncorrecto.Visible = False
        '
        'btnVer
        '
        Me.btnVer.BackColor = System.Drawing.Color.Transparent
        Me.btnVer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVer.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVer.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVer.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnVer.Location = New System.Drawing.Point(510, 150)
        Me.btnVer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(133, 30)
        Me.btnVer.TabIndex = 10
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = False
        Me.btnVer.Visible = False
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
        'lblAyuda
        '
        Me.lblAyuda.AutoSize = True
        Me.lblAyuda.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyuda.ForeColor = System.Drawing.Color.Green
        Me.lblAyuda.Location = New System.Drawing.Point(180, 67)
        Me.lblAyuda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.lblCancelar.Location = New System.Drawing.Point(325, 95)
        Me.lblCancelar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCancelar.Name = "lblCancelar"
        Me.lblCancelar.Size = New System.Drawing.Size(246, 16)
        Me.lblCancelar.TabIndex = 16
        Me.lblCancelar.Text = "Presione la tecla ""Esc"" para cancelar."
        Me.lblCancelar.Visible = False
        '
        'lstVales
        '
        Me.lstVales.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVales.FormattingEnabled = True
        Me.lstVales.ItemHeight = 17
        Me.lstVales.Location = New System.Drawing.Point(16, 332)
        Me.lstVales.Margin = New System.Windows.Forms.Padding(4)
        Me.lstVales.Name = "lstVales"
        Me.lstVales.Size = New System.Drawing.Size(841, 174)
        Me.lstVales.TabIndex = 17
        Me.lstVales.Visible = False
        '
        'lblTTotal
        '
        Me.lblTTotal.AutoSize = True
        Me.lblTTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTTotal.ForeColor = System.Drawing.Color.DimGray
        Me.lblTTotal.Location = New System.Drawing.Point(759, 214)
        Me.lblTTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTTotal.Name = "lblTTotal"
        Me.lblTTotal.Size = New System.Drawing.Size(43, 17)
        Me.lblTTotal.TabIndex = 18
        Me.lblTTotal.Text = "Total:"
        Me.lblTTotal.Visible = False
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.Indigo
        Me.lblSubTotal.Location = New System.Drawing.Point(695, 242)
        Me.lblSubTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(162, 47)
        Me.lblSubTotal.TabIndex = 19
        Me.lblSubTotal.Text = "$0,00"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSubTotal.Visible = False
        '
        'CtrlInformacion1
        '
        Me.CtrlInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlInformacion1.Location = New System.Drawing.Point(13, 526)
        Me.CtrlInformacion1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlInformacion1.Name = "CtrlInformacion1"
        Me.CtrlInformacion1.pdInformacion = "Escanee su tarjeta de acceso y a continuación escanee los vales que desea descarg" & _
            "ar. Una vez que escanee todos los vales, presione el botón ""Descargar""."
        Me.CtrlInformacion1.Size = New System.Drawing.Size(636, 89)
        Me.CtrlInformacion1.TabIndex = 13
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
        Me.CtrlMensaje.TabIndex = 11
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(350, 154)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(152, 23)
        Me.txtCodigo.TabIndex = 20
        Me.txtCodigo.Visible = False
        '
        'frmDescargar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblTTotal)
        Me.Controls.Add(Me.lstVales)
        Me.Controls.Add(Me.lblCancelar)
        Me.Controls.Add(Me.lblAyuda)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnDescargado)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.pbIncorrecto)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDescargar"
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
    Friend WithEvents CtrlMensaje As Vales.ctrlMensaje
    Friend WithEvents pbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents pbIncorrecto As System.Windows.Forms.PictureBox
    Friend WithEvents CtrlInformacion1 As Vales.ctrlInformacion
    Friend WithEvents lblAyuda As System.Windows.Forms.Label
    Friend WithEvents tmrTarjeta As System.Windows.Forms.Timer
    Friend WithEvents lblCancelar As System.Windows.Forms.Label
    Friend WithEvents lstVales As System.Windows.Forms.ListBox
    Friend WithEvents lblTTotal As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
End Class
