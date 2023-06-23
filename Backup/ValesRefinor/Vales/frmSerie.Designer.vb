<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSerie))
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblCombustible = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblNombreCombustible = New System.Windows.Forms.Label
        Me.lblCantidadVales = New System.Windows.Forms.Label
        Me.lblVencimiento = New System.Windows.Forms.Label
        Me.lblSinDescargar = New System.Windows.Forms.Label
        Me.lblTotalSerie = New System.Windows.Forms.Label
        Me.lblTipoVale = New System.Windows.Forms.Label
        Me.lblCliente = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtVigencia = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.btnReportar = New System.Windows.Forms.Button
        Me.btnExtender = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CtrlInformacion1 = New ValesRefinor.ctrlInformacion
        Me.CtrlMensaje = New ValesRefinor.ctrlMensaje
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(97, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de vale:"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotal.Location = New System.Drawing.Point(55, 137)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(133, 17)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Total ($):"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(130, 50)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cliente:"
        '
        'lblCombustible
        '
        Me.lblCombustible.AutoSize = True
        Me.lblCombustible.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCombustible.ForeColor = System.Drawing.Color.DimGray
        Me.lblCombustible.Location = New System.Drawing.Point(486, 137)
        Me.lblCombustible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCombustible.Name = "lblCombustible"
        Me.lblCombustible.Size = New System.Drawing.Size(95, 17)
        Me.lblCombustible.TabIndex = 18
        Me.lblCombustible.Text = "Combustible:"
        Me.lblCombustible.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(424, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Fecha de vencimiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(448, 94)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Cantidad de vales:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(56, 181)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Total sin descargar:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNombreCombustible)
        Me.GroupBox1.Controls.Add(Me.lblCantidadVales)
        Me.GroupBox1.Controls.Add(Me.lblVencimiento)
        Me.GroupBox1.Controls.Add(Me.lblSinDescargar)
        Me.GroupBox1.Controls.Add(Me.lblTotalSerie)
        Me.GroupBox1.Controls.Add(Me.lblTipoVale)
        Me.GroupBox1.Controls.Add(Me.lblCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblCombustible)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(47, 330)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(776, 222)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION DE LA SERIE"
        '
        'lblNombreCombustible
        '
        Me.lblNombreCombustible.AutoSize = True
        Me.lblNombreCombustible.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCombustible.ForeColor = System.Drawing.Color.Indigo
        Me.lblNombreCombustible.Location = New System.Drawing.Point(589, 133)
        Me.lblNombreCombustible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreCombustible.Name = "lblNombreCombustible"
        Me.lblNombreCombustible.Size = New System.Drawing.Size(70, 21)
        Me.lblNombreCombustible.TabIndex = 32
        Me.lblNombreCombustible.Text = "Cliente:"
        Me.lblNombreCombustible.Visible = False
        '
        'lblCantidadVales
        '
        Me.lblCantidadVales.AutoSize = True
        Me.lblCantidadVales.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadVales.ForeColor = System.Drawing.Color.Indigo
        Me.lblCantidadVales.Location = New System.Drawing.Point(589, 90)
        Me.lblCantidadVales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantidadVales.Name = "lblCantidadVales"
        Me.lblCantidadVales.Size = New System.Drawing.Size(70, 21)
        Me.lblCantidadVales.TabIndex = 31
        Me.lblCantidadVales.Text = "Cliente:"
        '
        'lblVencimiento
        '
        Me.lblVencimiento.AutoSize = True
        Me.lblVencimiento.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVencimiento.ForeColor = System.Drawing.Color.Indigo
        Me.lblVencimiento.Location = New System.Drawing.Point(589, 46)
        Me.lblVencimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVencimiento.Name = "lblVencimiento"
        Me.lblVencimiento.Size = New System.Drawing.Size(70, 21)
        Me.lblVencimiento.TabIndex = 30
        Me.lblVencimiento.Text = "Cliente:"
        '
        'lblSinDescargar
        '
        Me.lblSinDescargar.AutoSize = True
        Me.lblSinDescargar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinDescargar.ForeColor = System.Drawing.Color.Indigo
        Me.lblSinDescargar.Location = New System.Drawing.Point(196, 177)
        Me.lblSinDescargar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSinDescargar.Name = "lblSinDescargar"
        Me.lblSinDescargar.Size = New System.Drawing.Size(70, 21)
        Me.lblSinDescargar.TabIndex = 29
        Me.lblSinDescargar.Text = "Cliente:"
        '
        'lblTotalSerie
        '
        Me.lblTotalSerie.AutoSize = True
        Me.lblTotalSerie.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSerie.ForeColor = System.Drawing.Color.Indigo
        Me.lblTotalSerie.Location = New System.Drawing.Point(196, 133)
        Me.lblTotalSerie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalSerie.Name = "lblTotalSerie"
        Me.lblTotalSerie.Size = New System.Drawing.Size(70, 21)
        Me.lblTotalSerie.TabIndex = 28
        Me.lblTotalSerie.Text = "Cliente:"
        '
        'lblTipoVale
        '
        Me.lblTipoVale.AutoSize = True
        Me.lblTipoVale.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoVale.ForeColor = System.Drawing.Color.Indigo
        Me.lblTipoVale.Location = New System.Drawing.Point(196, 89)
        Me.lblTipoVale.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoVale.Name = "lblTipoVale"
        Me.lblTipoVale.Size = New System.Drawing.Size(70, 21)
        Me.lblTipoVale.TabIndex = 27
        Me.lblTipoVale.Text = "Cliente:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.Indigo
        Me.lblCliente.Location = New System.Drawing.Point(196, 46)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(70, 21)
        Me.lblCliente.TabIndex = 26
        Me.lblCliente.Text = "Cliente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtVigencia)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.btnReportar)
        Me.GroupBox2.Controls.Add(Me.btnExtender)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnImprimir)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(240, 71)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(391, 222)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPCIONES:"
        '
        'txtVigencia
        '
        Me.txtVigencia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVigencia.Location = New System.Drawing.Point(196, 92)
        Me.txtVigencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVigencia.Name = "txtVigencia"
        Me.txtVigencia.Size = New System.Drawing.Size(87, 23)
        Me.txtVigencia.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(292, 95)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "días"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ValesRefinor.My.Resources.Resources.robo30
        Me.PictureBox3.Location = New System.Drawing.Point(62, 184)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'btnReportar
        '
        Me.btnReportar.BackColor = System.Drawing.Color.Transparent
        Me.btnReportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnReportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnReportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnReportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnReportar.Location = New System.Drawing.Point(100, 184)
        Me.btnReportar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReportar.Name = "btnReportar"
        Me.btnReportar.Size = New System.Drawing.Size(228, 30)
        Me.btnReportar.TabIndex = 32
        Me.btnReportar.Text = "Reportar Extravío / Robo"
        Me.btnReportar.UseVisualStyleBackColor = False
        '
        'btnExtender
        '
        Me.btnExtender.BackColor = System.Drawing.Color.Transparent
        Me.btnExtender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExtender.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnExtender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnExtender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnExtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtender.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtender.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnExtender.Location = New System.Drawing.Point(105, 127)
        Me.btnExtender.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExtender.Name = "btnExtender"
        Me.btnExtender.Size = New System.Drawing.Size(180, 30)
        Me.btnExtender.TabIndex = 31
        Me.btnExtender.Text = "Extender"
        Me.btnExtender.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(36, 95)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Extender vencimiento:"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnImprimir.Location = New System.Drawing.Point(124, 31)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(180, 30)
        Me.btnImprimir.TabIndex = 11
        Me.btnImprimir.Text = "Imprimir Vales"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ValesRefinor.My.Resources.Resources.impraz30
        Me.PictureBox2.Location = New System.Drawing.Point(86, 31)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
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
        'CtrlInformacion1
        '
        Me.CtrlInformacion1.BackColor = System.Drawing.Color.Transparent
        Me.CtrlInformacion1.Location = New System.Drawing.Point(13, 563)
        Me.CtrlInformacion1.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlInformacion1.Name = "CtrlInformacion1"
        Me.CtrlInformacion1.pdInformacion = "Para poder registrar vales, primero debe registrar un cliente. Si los vales a emi" & _
            "tir, son por una cantidad de litros de combustible. Primero deberá registrar el " & _
            "combustible deseado."
        Me.CtrlInformacion1.Size = New System.Drawing.Size(627, 52)
        Me.CtrlInformacion1.TabIndex = 20
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
        Me.CtrlMensaje.TabIndex = 17
        '
        'frmSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSerie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CtrlMensaje As ValesRefinor.ctrlMensaje
    Friend WithEvents lblCombustible As System.Windows.Forms.Label
    Friend WithEvents CtrlInformacion1 As ValesRefinor.ctrlInformacion
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblNombreCombustible As System.Windows.Forms.Label
    Friend WithEvents lblCantidadVales As System.Windows.Forms.Label
    Friend WithEvents lblVencimiento As System.Windows.Forms.Label
    Friend WithEvents lblSinDescargar As System.Windows.Forms.Label
    Friend WithEvents lblTotalSerie As System.Windows.Forms.Label
    Friend WithEvents lblTipoVale As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnExtender As System.Windows.Forms.Button
    Friend WithEvents btnReportar As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVigencia As System.Windows.Forms.TextBox
End Class
