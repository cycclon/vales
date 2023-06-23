<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignar))
        Me.btnAsignar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CtrlInformacion1 = New Vales.ctrlInformacion
        Me.CtrlMensaje = New Vales.ctrlMensaje
        Me.CtrlMensaje1 = New Vales.ctrlMensaje
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnQuitarEmpleado = New System.Windows.Forms.Button
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.lstAsignados = New System.Windows.Forms.ListBox
        Me.IUsuarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.lstSinAsignar = New System.Windows.Forms.ListBox
        Me.IUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chkSábado = New System.Windows.Forms.CheckBox
        Me.chkViernes = New System.Windows.Forms.CheckBox
        Me.chkJueves = New System.Windows.Forms.CheckBox
        Me.chkMiercoles = New System.Windows.Forms.CheckBox
        Me.chkMartes = New System.Windows.Forms.CheckBox
        Me.chkLunes = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkDomingo = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.nudMFinal = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.nudHFinal = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.nudMInicio = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.nudhInicio = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnQuitarTurno = New System.Windows.Forms.Button
        Me.lstEmpleados = New System.Windows.Forms.ListBox
        Me.IUsuarioBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstTurnos = New System.Windows.Forms.ListBox
        Me.ITurnoActualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.IUsuarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudhInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.IUsuarioBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITurnoActualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAsignar
        '
        Me.btnAsignar.BackColor = System.Drawing.Color.Transparent
        Me.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAsignar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnAsignar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnAsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsignar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAsignar.Location = New System.Drawing.Point(748, 222)
        Me.btnAsignar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(88, 30)
        Me.btnAsignar.TabIndex = 2
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = False
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
        Me.CtrlInformacion1.pdInformacion = "Estableza los horarios de inicio y final del turno. Seleccione los días de la sem" & _
            "ana y los empleados. Luego presione el botón asignar para registrar el turno."
        Me.CtrlInformacion1.Size = New System.Drawing.Size(636, 52)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnQuitarEmpleado)
        Me.GroupBox1.Controls.Add(Me.btnAgregarEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lstAsignados)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lstSinAsignar)
        Me.GroupBox1.Controls.Add(Me.chkSábado)
        Me.GroupBox1.Controls.Add(Me.chkViernes)
        Me.GroupBox1.Controls.Add(Me.chkJueves)
        Me.GroupBox1.Controls.Add(Me.chkMiercoles)
        Me.GroupBox1.Controls.Add(Me.btnAsignar)
        Me.GroupBox1.Controls.Add(Me.chkMartes)
        Me.GroupBox1.Controls.Add(Me.chkLunes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkDomingo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.nudMFinal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.nudHFinal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.nudMInicio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.nudhInicio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(13, 71)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(844, 260)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CREAR TURNOS"
        '
        'btnQuitarEmpleado
        '
        Me.btnQuitarEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnQuitarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnQuitarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnQuitarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarEmpleado.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnQuitarEmpleado.Location = New System.Drawing.Point(356, 208)
        Me.btnQuitarEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQuitarEmpleado.Name = "btnQuitarEmpleado"
        Me.btnQuitarEmpleado.Size = New System.Drawing.Size(36, 30)
        Me.btnQuitarEmpleado.TabIndex = 38
        Me.btnQuitarEmpleado.Text = "<<"
        Me.btnQuitarEmpleado.UseVisualStyleBackColor = False
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnAgregarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnAgregarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEmpleado.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(356, 170)
        Me.btnAgregarEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(36, 30)
        Me.btnAgregarEmpleado.TabIndex = 37
        Me.btnAgregarEmpleado.Text = ">>"
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(396, 124)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(235, 17)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Empleados asignados a este turno:"
        '
        'lstAsignados
        '
        Me.lstAsignados.DataSource = Me.IUsuarioBindingSource1
        Me.lstAsignados.DisplayMember = "pdNombreCompleto"
        Me.lstAsignados.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAsignados.FormattingEnabled = True
        Me.lstAsignados.ItemHeight = 17
        Me.lstAsignados.Location = New System.Drawing.Point(400, 145)
        Me.lstAsignados.Margin = New System.Windows.Forms.Padding(4)
        Me.lstAsignados.Name = "lstAsignados"
        Me.lstAsignados.Size = New System.Drawing.Size(340, 106)
        Me.lstAsignados.TabIndex = 35
        Me.lstAsignados.ValueMember = "pdID"
        '
        'IUsuarioBindingSource1
        '
        Me.IUsuarioBindingSource1.DataSource = GetType(Entidades.Acceso.iUsuario)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(5, 125)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 17)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Empleados:"
        '
        'lstSinAsignar
        '
        Me.lstSinAsignar.DataSource = Me.IUsuarioBindingSource
        Me.lstSinAsignar.DisplayMember = "pdNombreCompleto"
        Me.lstSinAsignar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSinAsignar.FormattingEnabled = True
        Me.lstSinAsignar.ItemHeight = 17
        Me.lstSinAsignar.Location = New System.Drawing.Point(8, 146)
        Me.lstSinAsignar.Margin = New System.Windows.Forms.Padding(4)
        Me.lstSinAsignar.Name = "lstSinAsignar"
        Me.lstSinAsignar.Size = New System.Drawing.Size(340, 106)
        Me.lstSinAsignar.TabIndex = 33
        Me.lstSinAsignar.ValueMember = "pdNombreCompleto"
        '
        'IUsuarioBindingSource
        '
        Me.IUsuarioBindingSource.DataSource = GetType(Entidades.Acceso.iUsuario)
        '
        'chkSábado
        '
        Me.chkSábado.AutoSize = True
        Me.chkSábado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSábado.ForeColor = System.Drawing.Color.Indigo
        Me.chkSábado.Location = New System.Drawing.Point(673, 89)
        Me.chkSábado.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSábado.Name = "chkSábado"
        Me.chkSábado.Size = New System.Drawing.Size(78, 21)
        Me.chkSábado.TabIndex = 32
        Me.chkSábado.Text = "Sábado"
        Me.chkSábado.UseVisualStyleBackColor = True
        '
        'chkViernes
        '
        Me.chkViernes.AutoSize = True
        Me.chkViernes.Checked = True
        Me.chkViernes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkViernes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViernes.ForeColor = System.Drawing.Color.Indigo
        Me.chkViernes.Location = New System.Drawing.Point(573, 89)
        Me.chkViernes.Margin = New System.Windows.Forms.Padding(4)
        Me.chkViernes.Name = "chkViernes"
        Me.chkViernes.Size = New System.Drawing.Size(72, 21)
        Me.chkViernes.TabIndex = 31
        Me.chkViernes.Text = "Viernes"
        Me.chkViernes.UseVisualStyleBackColor = True
        '
        'chkJueves
        '
        Me.chkJueves.AutoSize = True
        Me.chkJueves.Checked = True
        Me.chkJueves.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkJueves.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJueves.ForeColor = System.Drawing.Color.Indigo
        Me.chkJueves.Location = New System.Drawing.Point(479, 89)
        Me.chkJueves.Margin = New System.Windows.Forms.Padding(4)
        Me.chkJueves.Name = "chkJueves"
        Me.chkJueves.Size = New System.Drawing.Size(70, 21)
        Me.chkJueves.TabIndex = 30
        Me.chkJueves.Text = "Jueves"
        Me.chkJueves.UseVisualStyleBackColor = True
        '
        'chkMiercoles
        '
        Me.chkMiercoles.AutoSize = True
        Me.chkMiercoles.Checked = True
        Me.chkMiercoles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMiercoles.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMiercoles.ForeColor = System.Drawing.Color.Indigo
        Me.chkMiercoles.Location = New System.Drawing.Point(365, 89)
        Me.chkMiercoles.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMiercoles.Name = "chkMiercoles"
        Me.chkMiercoles.Size = New System.Drawing.Size(86, 21)
        Me.chkMiercoles.TabIndex = 29
        Me.chkMiercoles.Text = "Miércoles"
        Me.chkMiercoles.UseVisualStyleBackColor = True
        '
        'chkMartes
        '
        Me.chkMartes.AutoSize = True
        Me.chkMartes.Checked = True
        Me.chkMartes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMartes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMartes.ForeColor = System.Drawing.Color.Indigo
        Me.chkMartes.Location = New System.Drawing.Point(272, 89)
        Me.chkMartes.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMartes.Name = "chkMartes"
        Me.chkMartes.Size = New System.Drawing.Size(69, 21)
        Me.chkMartes.TabIndex = 28
        Me.chkMartes.Text = "Martes"
        Me.chkMartes.UseVisualStyleBackColor = True
        '
        'chkLunes
        '
        Me.chkLunes.AutoSize = True
        Me.chkLunes.Checked = True
        Me.chkLunes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLunes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLunes.ForeColor = System.Drawing.Color.Indigo
        Me.chkLunes.Location = New System.Drawing.Point(185, 89)
        Me.chkLunes.Margin = New System.Windows.Forms.Padding(4)
        Me.chkLunes.Name = "chkLunes"
        Me.chkLunes.Size = New System.Drawing.Size(62, 21)
        Me.chkLunes.TabIndex = 27
        Me.chkLunes.Text = "Lunes"
        Me.chkLunes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(76, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Aplicar a:"
        '
        'chkDomingo
        '
        Me.chkDomingo.AutoSize = True
        Me.chkDomingo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDomingo.ForeColor = System.Drawing.Color.Indigo
        Me.chkDomingo.Location = New System.Drawing.Point(75, 89)
        Me.chkDomingo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(88, 21)
        Me.chkDomingo.TabIndex = 25
        Me.chkDomingo.Text = "Domingo"
        Me.chkDomingo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(771, 34)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "min."
        '
        'nudMFinal
        '
        Me.nudMFinal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMFinal.Location = New System.Drawing.Point(690, 31)
        Me.nudMFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.nudMFinal.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMFinal.Name = "nudMFinal"
        Me.nudMFinal.Size = New System.Drawing.Size(73, 23)
        Me.nudMFinal.TabIndex = 23
        Me.nudMFinal.Value = New Decimal(New Integer() {59, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(656, 34)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Hs."
        '
        'nudHFinal
        '
        Me.nudHFinal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHFinal.Location = New System.Drawing.Point(575, 31)
        Me.nudHFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.nudHFinal.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nudHFinal.Name = "nudHFinal"
        Me.nudHFinal.Size = New System.Drawing.Size(73, 23)
        Me.nudHFinal.TabIndex = 21
        Me.nudHFinal.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(472, 34)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Hora de final:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(332, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "min."
        '
        'nudMInicio
        '
        Me.nudMInicio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMInicio.Location = New System.Drawing.Point(251, 31)
        Me.nudMInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.nudMInicio.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMInicio.Name = "nudMInicio"
        Me.nudMInicio.Size = New System.Drawing.Size(73, 23)
        Me.nudMInicio.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(217, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Hs."
        '
        'nudhInicio
        '
        Me.nudhInicio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudhInicio.Location = New System.Drawing.Point(136, 31)
        Me.nudhInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.nudhInicio.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nudhInicio.Name = "nudhInicio"
        Me.nudhInicio.Size = New System.Drawing.Size(73, 23)
        Me.nudhInicio.TabIndex = 16
        Me.nudhInicio.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(26, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Hora de inicio:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.btnQuitarTurno)
        Me.GroupBox2.Controls.Add(Me.lstEmpleados)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lstTurnos)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(13, 339)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(844, 216)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TURNOS ASIGNADOS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(493, 30)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 17)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Empleados asignados:"
        '
        'btnQuitarTurno
        '
        Me.btnQuitarTurno.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitarTurno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitarTurno.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnQuitarTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnQuitarTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnQuitarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarTurno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarTurno.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnQuitarTurno.Location = New System.Drawing.Point(172, 178)
        Me.btnQuitarTurno.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQuitarTurno.Name = "btnQuitarTurno"
        Me.btnQuitarTurno.Size = New System.Drawing.Size(196, 30)
        Me.btnQuitarTurno.TabIndex = 29
        Me.btnQuitarTurno.Text = "Eliminar Seleccionado"
        Me.btnQuitarTurno.UseVisualStyleBackColor = False
        '
        'lstEmpleados
        '
        Me.lstEmpleados.DataSource = Me.IUsuarioBindingSource2
        Me.lstEmpleados.DisplayMember = "pdNombreCompleto"
        Me.lstEmpleados.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEmpleados.FormattingEnabled = True
        Me.lstEmpleados.ItemHeight = 17
        Me.lstEmpleados.Location = New System.Drawing.Point(496, 51)
        Me.lstEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.lstEmpleados.Name = "lstEmpleados"
        Me.lstEmpleados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstEmpleados.Size = New System.Drawing.Size(340, 157)
        Me.lstEmpleados.TabIndex = 28
        Me.lstEmpleados.ValueMember = "pdID"
        '
        'IUsuarioBindingSource2
        '
        Me.IUsuarioBindingSource2.DataSource = GetType(Entidades.Acceso.iUsuario)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(8, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Turnos:"
        '
        'lstTurnos
        '
        Me.lstTurnos.DataSource = Me.ITurnoActualBindingSource
        Me.lstTurnos.DisplayMember = "Turno"
        Me.lstTurnos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTurnos.FormattingEnabled = True
        Me.lstTurnos.ItemHeight = 17
        Me.lstTurnos.Location = New System.Drawing.Point(8, 49)
        Me.lstTurnos.Margin = New System.Windows.Forms.Padding(4)
        Me.lstTurnos.Name = "lstTurnos"
        Me.lstTurnos.Size = New System.Drawing.Size(360, 123)
        Me.lstTurnos.TabIndex = 0
        Me.lstTurnos.ValueMember = "pdID"
        '
        'ITurnoActualBindingSource
        '
        Me.ITurnoActualBindingSource.DataSource = GetType(Entidades.Turnos.iTurnoActual)
        '
        'frmAsignar
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
        Me.Name = "frmAsignar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.IUsuarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudhInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.IUsuarioBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITurnoActualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents CtrlMensaje As Vales.ctrlMensaje
    Friend WithEvents CtrlMensaje1 As Vales.ctrlMensaje
    Friend WithEvents CtrlInformacion1 As Vales.ctrlInformacion
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nudMInicio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudhInicio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nudMFinal As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nudHFinal As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkLunes As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkDomingo As System.Windows.Forms.CheckBox
    Friend WithEvents chkSábado As System.Windows.Forms.CheckBox
    Friend WithEvents chkViernes As System.Windows.Forms.CheckBox
    Friend WithEvents chkJueves As System.Windows.Forms.CheckBox
    Friend WithEvents chkMiercoles As System.Windows.Forms.CheckBox
    Friend WithEvents chkMartes As System.Windows.Forms.CheckBox
    Friend WithEvents lstTurnos As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lstAsignados As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lstSinAsignar As System.Windows.Forms.ListBox
    Friend WithEvents lstEmpleados As System.Windows.Forms.ListBox
    Friend WithEvents btnQuitarEmpleado As System.Windows.Forms.Button
    Friend WithEvents btnAgregarEmpleado As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnQuitarTurno As System.Windows.Forms.Button
    Friend WithEvents IUsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IUsuarioBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ITurnoActualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IUsuarioBindingSource2 As System.Windows.Forms.BindingSource
End Class
