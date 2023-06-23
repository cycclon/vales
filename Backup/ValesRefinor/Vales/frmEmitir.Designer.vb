<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmitir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmitir))
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnEmitir = New System.Windows.Forms.Button
        Me.rdDinero = New System.Windows.Forms.RadioButton
        Me.rdCombustible = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.lstCliente = New System.Windows.Forms.ComboBox
        Me.IClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtValor = New System.Windows.Forms.TextBox
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.ctrlAValor = New ValesRefinor.ctrlAyuda
        Me.ctrlACantidad = New ValesRefinor.ctrlAyuda
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblRestante = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblTotalDistribucion = New System.Windows.Forms.Label
        Me.btnAgregarSerie = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnQuitarSerie = New System.Windows.Forms.Button
        Me.lstDistribucion = New System.Windows.Forms.ListBox
        Me.CtrlMensaje = New ValesRefinor.ctrlMensaje
        Me.lblCombustible = New System.Windows.Forms.Label
        Me.lstCombustible = New System.Windows.Forms.ComboBox
        Me.ICombustibleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CtrlInformacion1 = New ValesRefinor.ctrlInformacion
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.ctrlAVigencia = New ValesRefinor.ctrlAyuda
        Me.ctrlATotal = New ValesRefinor.ctrlAyuda
        Me.txtVigencia = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ICombustibleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(49, 155)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de vale:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotal.Location = New System.Drawing.Point(77, 185)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(63, 17)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Total ($):"
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
        'btnEmitir
        '
        Me.btnEmitir.BackColor = System.Drawing.Color.Transparent
        Me.btnEmitir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmitir.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnEmitir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnEmitir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnEmitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmitir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmitir.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnEmitir.Location = New System.Drawing.Point(724, 585)
        Me.btnEmitir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEmitir.Name = "btnEmitir"
        Me.btnEmitir.Size = New System.Drawing.Size(133, 30)
        Me.btnEmitir.TabIndex = 7
        Me.btnEmitir.Text = "Emitir"
        Me.btnEmitir.UseVisualStyleBackColor = False
        '
        'rdDinero
        '
        Me.rdDinero.AutoSize = True
        Me.rdDinero.Checked = True
        Me.rdDinero.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDinero.ForeColor = System.Drawing.Color.Indigo
        Me.rdDinero.Location = New System.Drawing.Point(148, 153)
        Me.rdDinero.Margin = New System.Windows.Forms.Padding(4)
        Me.rdDinero.Name = "rdDinero"
        Me.rdDinero.Size = New System.Drawing.Size(68, 21)
        Me.rdDinero.TabIndex = 9
        Me.rdDinero.TabStop = True
        Me.rdDinero.Text = "Dinero"
        Me.rdDinero.UseVisualStyleBackColor = True
        '
        'rdCombustible
        '
        Me.rdCombustible.AutoSize = True
        Me.rdCombustible.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCombustible.ForeColor = System.Drawing.Color.Indigo
        Me.rdCombustible.Location = New System.Drawing.Point(224, 152)
        Me.rdCombustible.Margin = New System.Windows.Forms.Padding(4)
        Me.rdCombustible.Name = "rdCombustible"
        Me.rdCombustible.Size = New System.Drawing.Size(109, 21)
        Me.rdCombustible.TabIndex = 10
        Me.rdCombustible.Text = "Combustible"
        Me.rdCombustible.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(82, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cliente:"
        '
        'lstCliente
        '
        Me.lstCliente.DataSource = Me.IClienteBindingSource
        Me.lstCliente.DisplayMember = "pdNombreCompleto"
        Me.lstCliente.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCliente.FormattingEnabled = True
        Me.lstCliente.Location = New System.Drawing.Point(148, 120)
        Me.lstCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCliente.Name = "lstCliente"
        Me.lstCliente.Size = New System.Drawing.Size(256, 25)
        Me.lstCliente.TabIndex = 12
        Me.lstCliente.ValueMember = "pdID"
        '
        'IClienteBindingSource
        '
        Me.IClienteBindingSource.DataSource = GetType(Entidades.Clientes.iCliente)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.ctrlAValor)
        Me.GroupBox1.Controls.Add(Me.ctrlACantidad)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnAgregarSerie)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnQuitarSerie)
        Me.GroupBox1.Controls.Add(Me.lstDistribucion)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(20, 286)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(837, 265)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMA DE EMISION"
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(109, 64)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(132, 23)
        Me.txtValor.TabIndex = 30
        Me.txtValor.Text = "0"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(109, 33)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(132, 23)
        Me.txtCantidad.TabIndex = 29
        Me.txtCantidad.Text = "0"
        '
        'ctrlAValor
        '
        Me.ctrlAValor.BackColor = System.Drawing.Color.Transparent
        Me.ctrlAValor.Cursor = System.Windows.Forms.Cursors.Help
        Me.ctrlAValor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctrlAValor.Location = New System.Drawing.Point(250, 64)
        Me.ctrlAValor.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ctrlAValor.Name = "ctrlAValor"
        Me.ctrlAValor.pdAyuda = ""
        Me.ctrlAValor.Size = New System.Drawing.Size(378, 33)
        Me.ctrlAValor.TabIndex = 28
        '
        'ctrlACantidad
        '
        Me.ctrlACantidad.BackColor = System.Drawing.Color.Transparent
        Me.ctrlACantidad.Cursor = System.Windows.Forms.Cursors.Help
        Me.ctrlACantidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctrlACantidad.Location = New System.Drawing.Point(250, 33)
        Me.ctrlACantidad.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ctrlACantidad.Name = "ctrlACantidad"
        Me.ctrlACantidad.pdAyuda = ""
        Me.ctrlACantidad.Size = New System.Drawing.Size(378, 33)
        Me.ctrlACantidad.TabIndex = 27
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblRestante)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(313, 144)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(267, 95)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESTANTE"
        '
        'lblRestante
        '
        Me.lblRestante.AutoSize = True
        Me.lblRestante.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestante.ForeColor = System.Drawing.Color.Indigo
        Me.lblRestante.Location = New System.Drawing.Point(81, 37)
        Me.lblRestante.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRestante.Name = "lblRestante"
        Me.lblRestante.Size = New System.Drawing.Size(34, 24)
        Me.lblRestante.TabIndex = 24
        Me.lblRestante.Text = "$0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalDistribucion)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 144)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(267, 95)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TOTAL DE LA DISTRIBUCION"
        '
        'lblTotalDistribucion
        '
        Me.lblTotalDistribucion.AutoSize = True
        Me.lblTotalDistribucion.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDistribucion.ForeColor = System.Drawing.Color.Indigo
        Me.lblTotalDistribucion.Location = New System.Drawing.Point(81, 37)
        Me.lblTotalDistribucion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalDistribucion.Name = "lblTotalDistribucion"
        Me.lblTotalDistribucion.Size = New System.Drawing.Size(34, 24)
        Me.lblTotalDistribucion.TabIndex = 24
        Me.lblTotalDistribucion.Text = "$0"
        '
        'btnAgregarSerie
        '
        Me.btnAgregarSerie.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarSerie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarSerie.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnAgregarSerie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnAgregarSerie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnAgregarSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarSerie.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarSerie.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarSerie.Location = New System.Drawing.Point(109, 95)
        Me.btnAgregarSerie.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarSerie.Name = "btnAgregarSerie"
        Me.btnAgregarSerie.Size = New System.Drawing.Size(133, 30)
        Me.btnAgregarSerie.TabIndex = 22
        Me.btnAgregarSerie.Text = "Agregar"
        Me.btnAgregarSerie.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(55, 67)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Valor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(26, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Cantidad:"
        '
        'btnQuitarSerie
        '
        Me.btnQuitarSerie.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitarSerie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitarSerie.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnQuitarSerie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnQuitarSerie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnQuitarSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarSerie.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarSerie.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnQuitarSerie.Location = New System.Drawing.Point(640, 227)
        Me.btnQuitarSerie.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQuitarSerie.Name = "btnQuitarSerie"
        Me.btnQuitarSerie.Size = New System.Drawing.Size(189, 30)
        Me.btnQuitarSerie.TabIndex = 17
        Me.btnQuitarSerie.Text = "Quitar Seleccionado"
        Me.btnQuitarSerie.UseVisualStyleBackColor = False
        '
        'lstDistribucion
        '
        Me.lstDistribucion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDistribucion.FormattingEnabled = True
        Me.lstDistribucion.ItemHeight = 17
        Me.lstDistribucion.Location = New System.Drawing.Point(641, 28)
        Me.lstDistribucion.Margin = New System.Windows.Forms.Padding(4)
        Me.lstDistribucion.Name = "lstDistribucion"
        Me.lstDistribucion.Size = New System.Drawing.Size(188, 191)
        Me.lstDistribucion.TabIndex = 16
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
        'lblCombustible
        '
        Me.lblCombustible.AutoSize = True
        Me.lblCombustible.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCombustible.ForeColor = System.Drawing.Color.DimGray
        Me.lblCombustible.Location = New System.Drawing.Point(45, 216)
        Me.lblCombustible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCombustible.Name = "lblCombustible"
        Me.lblCombustible.Size = New System.Drawing.Size(95, 17)
        Me.lblCombustible.TabIndex = 18
        Me.lblCombustible.Text = "Combustible:"
        Me.lblCombustible.Visible = False
        '
        'lstCombustible
        '
        Me.lstCombustible.DataSource = Me.ICombustibleBindingSource
        Me.lstCombustible.DisplayMember = "pdNombre"
        Me.lstCombustible.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCombustible.FormattingEnabled = True
        Me.lstCombustible.Location = New System.Drawing.Point(148, 213)
        Me.lstCombustible.Margin = New System.Windows.Forms.Padding(4)
        Me.lstCombustible.Name = "lstCombustible"
        Me.lstCombustible.Size = New System.Drawing.Size(256, 25)
        Me.lstCombustible.TabIndex = 19
        Me.lstCombustible.ValueMember = "pdID"
        Me.lstCombustible.Visible = False
        '
        'ICombustibleBindingSource
        '
        Me.ICombustibleBindingSource.DataSource = GetType(Entidades.Combustibles.iCombustible)
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
        Me.CtrlInformacion1.Size = New System.Drawing.Size(635, 52)
        Me.CtrlInformacion1.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(477, 156)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "A partir del:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(440, 123)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Días de vigencia:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Location = New System.Drawing.Point(568, 151)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(289, 23)
        Me.dtpFechaInicio.TabIndex = 24
        '
        'ctrlAVigencia
        '
        Me.ctrlAVigencia.BackColor = System.Drawing.Color.Transparent
        Me.ctrlAVigencia.Cursor = System.Windows.Forms.Cursors.Help
        Me.ctrlAVigencia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctrlAVigencia.Location = New System.Drawing.Point(634, 120)
        Me.ctrlAVigencia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ctrlAVigencia.Name = "ctrlAVigencia"
        Me.ctrlAVigencia.pdAyuda = ""
        Me.ctrlAVigencia.Size = New System.Drawing.Size(223, 33)
        Me.ctrlAVigencia.TabIndex = 25
        '
        'ctrlATotal
        '
        Me.ctrlATotal.BackColor = System.Drawing.Color.Transparent
        Me.ctrlATotal.Cursor = System.Windows.Forms.Cursors.Help
        Me.ctrlATotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctrlATotal.Location = New System.Drawing.Point(289, 178)
        Me.ctrlATotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ctrlATotal.Name = "ctrlATotal"
        Me.ctrlATotal.pdAyuda = ""
        Me.ctrlATotal.Size = New System.Drawing.Size(568, 33)
        Me.ctrlATotal.TabIndex = 26
        '
        'txtVigencia
        '
        Me.txtVigencia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVigencia.Location = New System.Drawing.Point(568, 120)
        Me.txtVigencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVigencia.Name = "txtVigencia"
        Me.txtVigencia.Size = New System.Drawing.Size(58, 23)
        Me.txtVigencia.TabIndex = 27
        Me.txtVigencia.Text = "30"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(148, 182)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(132, 23)
        Me.txtTotal.TabIndex = 28
        Me.txtTotal.Text = "0"
        '
        'frmEmitir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtVigencia)
        Me.Controls.Add(Me.ctrlATotal)
        Me.Controls.Add(Me.ctrlAVigencia)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CtrlInformacion1)
        Me.Controls.Add(Me.lstCombustible)
        Me.Controls.Add(Me.lblCombustible)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdCombustible)
        Me.Controls.Add(Me.rdDinero)
        Me.Controls.Add(Me.btnEmitir)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmitir"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ICombustibleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEmitir As System.Windows.Forms.Button
    Friend WithEvents rdDinero As System.Windows.Forms.RadioButton
    Friend WithEvents rdCombustible As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstCliente As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuitarSerie As System.Windows.Forms.Button
    Friend WithEvents lstDistribucion As System.Windows.Forms.ListBox
    Friend WithEvents btnAgregarSerie As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDistribucion As System.Windows.Forms.Label
    Friend WithEvents CtrlMensaje As ValesRefinor.ctrlMensaje
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCombustible As System.Windows.Forms.Label
    Friend WithEvents lstCombustible As System.Windows.Forms.ComboBox
    Friend WithEvents IClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ICombustibleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRestante As System.Windows.Forms.Label
    Friend WithEvents CtrlInformacion1 As ValesRefinor.ctrlInformacion
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ctrlAValor As ValesRefinor.ctrlAyuda
    Friend WithEvents ctrlACantidad As ValesRefinor.ctrlAyuda
    Friend WithEvents ctrlAVigencia As ValesRefinor.ctrlAyuda
    Friend WithEvents ctrlATotal As ValesRefinor.ctrlAyuda
    Friend WithEvents txtVigencia As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
End Class
