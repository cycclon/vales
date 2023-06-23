<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.CtrlMensaje = New ValesRefinor.ctrlMensaje
        Me.CtrlMensaje1 = New ValesRefinor.ctrlMensaje
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblCombustibleRestante = New System.Windows.Forms.Label
        Me.lblDineroRestante = New System.Windows.Forms.Label
        Me.lblCombustible = New System.Windows.Forms.Label
        Me.lblDinero = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblPromedioDinero = New System.Windows.Forms.Label
        Me.lblPromedioCombustible = New System.Windows.Forms.Label
        Me.lblDia = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblEmpleadoMayorDescarga = New System.Windows.Forms.Label
        Me.lblEmpleados = New System.Windows.Forms.Label
        Me.lblAdministradores = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CtrlMensaje
        '
        Me.CtrlMensaje.BackColor = System.Drawing.Color.Transparent
        Me.CtrlMensaje.Location = New System.Drawing.Point(27, 26)
        Me.CtrlMensaje.Margin = New System.Windows.Forms.Padding(4)
        Me.CtrlMensaje.Name = "CtrlMensaje"
        Me.CtrlMensaje.pdErrores = CType(resources.GetObject("CtrlMensaje.pdErrores"), System.Collections.Generic.List(Of String))
        Me.CtrlMensaje.pdMensaje = ""
        Me.CtrlMensaje.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
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
        Me.CtrlMensaje1.pdTipo = ValesRefinor.ctrlMensaje.enTipoMensaje.msgError
        Me.CtrlMensaje1.Size = New System.Drawing.Size(670, 50)
        Me.CtrlMensaje1.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCombustibleRestante)
        Me.GroupBox1.Controls.Add(Me.lblDineroRestante)
        Me.GroupBox1.Controls.Add(Me.lblCombustible)
        Me.GroupBox1.Controls.Add(Me.lblDinero)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(16, 99)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(841, 131)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VALES:"
        '
        'lblCombustibleRestante
        '
        Me.lblCombustibleRestante.AutoSize = True
        Me.lblCombustibleRestante.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCombustibleRestante.ForeColor = System.Drawing.Color.Indigo
        Me.lblCombustibleRestante.Location = New System.Drawing.Point(416, 91)
        Me.lblCombustibleRestante.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCombustibleRestante.Name = "lblCombustibleRestante"
        Me.lblCombustibleRestante.Size = New System.Drawing.Size(19, 21)
        Me.lblCombustibleRestante.TabIndex = 11
        Me.lblCombustibleRestante.Text = "0"
        '
        'lblDineroRestante
        '
        Me.lblDineroRestante.AutoSize = True
        Me.lblDineroRestante.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDineroRestante.ForeColor = System.Drawing.Color.Indigo
        Me.lblDineroRestante.Location = New System.Drawing.Point(416, 71)
        Me.lblDineroRestante.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDineroRestante.Name = "lblDineroRestante"
        Me.lblDineroRestante.Size = New System.Drawing.Size(19, 21)
        Me.lblDineroRestante.TabIndex = 10
        Me.lblDineroRestante.Text = "0"
        '
        'lblCombustible
        '
        Me.lblCombustible.AutoSize = True
        Me.lblCombustible.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCombustible.ForeColor = System.Drawing.Color.Indigo
        Me.lblCombustible.Location = New System.Drawing.Point(416, 50)
        Me.lblCombustible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCombustible.Name = "lblCombustible"
        Me.lblCombustible.Size = New System.Drawing.Size(19, 21)
        Me.lblCombustible.TabIndex = 9
        Me.lblCombustible.Text = "0"
        '
        'lblDinero
        '
        Me.lblDinero.AutoSize = True
        Me.lblDinero.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinero.ForeColor = System.Drawing.Color.Indigo
        Me.lblDinero.Location = New System.Drawing.Point(416, 29)
        Me.lblDinero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDinero.Name = "lblDinero"
        Me.lblDinero.Size = New System.Drawing.Size(19, 21)
        Me.lblDinero.TabIndex = 8
        Me.lblDinero.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(184, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Litros restantes por canejar:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(179, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dinero restante por canjear:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(23, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad de litros de combustible emitido en vales:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(116, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad de dinero emitido en vales:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ValesRefinor.My.Resources.Resources.monam50
        Me.PictureBox2.Location = New System.Drawing.Point(784, 28)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPromedioDinero)
        Me.GroupBox2.Controls.Add(Me.lblPromedioCombustible)
        Me.GroupBox2.Controls.Add(Me.lblDia)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(16, 263)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(841, 131)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DIAS Y TURNOS:"
        '
        'lblPromedioDinero
        '
        Me.lblPromedioDinero.AutoSize = True
        Me.lblPromedioDinero.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromedioDinero.ForeColor = System.Drawing.Color.Indigo
        Me.lblPromedioDinero.Location = New System.Drawing.Point(416, 80)
        Me.lblPromedioDinero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPromedioDinero.Name = "lblPromedioDinero"
        Me.lblPromedioDinero.Size = New System.Drawing.Size(19, 21)
        Me.lblPromedioDinero.TabIndex = 12
        Me.lblPromedioDinero.Text = "0"
        '
        'lblPromedioCombustible
        '
        Me.lblPromedioCombustible.AutoSize = True
        Me.lblPromedioCombustible.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromedioCombustible.ForeColor = System.Drawing.Color.Indigo
        Me.lblPromedioCombustible.Location = New System.Drawing.Point(416, 59)
        Me.lblPromedioCombustible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPromedioCombustible.Name = "lblPromedioCombustible"
        Me.lblPromedioCombustible.Size = New System.Drawing.Size(19, 21)
        Me.lblPromedioCombustible.TabIndex = 11
        Me.lblPromedioCombustible.Text = "0"
        '
        'lblDia
        '
        Me.lblDia.AutoSize = True
        Me.lblDia.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDia.ForeColor = System.Drawing.Color.Indigo
        Me.lblDia.Location = New System.Drawing.Point(416, 38)
        Me.lblDia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(53, 21)
        Me.lblDia.TabIndex = 9
        Me.lblDia.Text = "Lunes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(85, 84)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(283, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Promedio de descargas de dinero por día:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(46, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(322, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Promedio de descargas de combustible por día:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(54, 42)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(314, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Día de la semana que mas vales se descargan:"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ValesRefinor.My.Resources.Resources.calemarr50
        Me.PictureBox4.Location = New System.Drawing.Point(784, 28)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblEmpleadoMayorDescarga)
        Me.GroupBox3.Controls.Add(Me.lblEmpleados)
        Me.GroupBox3.Controls.Add(Me.lblAdministradores)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox3.Location = New System.Drawing.Point(16, 426)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(841, 131)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "USUARIOS:"
        '
        'lblEmpleadoMayorDescarga
        '
        Me.lblEmpleadoMayorDescarga.AutoSize = True
        Me.lblEmpleadoMayorDescarga.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleadoMayorDescarga.ForeColor = System.Drawing.Color.Indigo
        Me.lblEmpleadoMayorDescarga.Location = New System.Drawing.Point(416, 78)
        Me.lblEmpleadoMayorDescarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpleadoMayorDescarga.Name = "lblEmpleadoMayorDescarga"
        Me.lblEmpleadoMayorDescarga.Size = New System.Drawing.Size(98, 21)
        Me.lblEmpleadoMayorDescarga.TabIndex = 15
        Me.lblEmpleadoMayorDescarga.Text = "Perez, Juan"
        '
        'lblEmpleados
        '
        Me.lblEmpleados.AutoSize = True
        Me.lblEmpleados.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleados.ForeColor = System.Drawing.Color.Indigo
        Me.lblEmpleados.Location = New System.Drawing.Point(416, 58)
        Me.lblEmpleados.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(19, 21)
        Me.lblEmpleados.TabIndex = 14
        Me.lblEmpleados.Text = "0"
        '
        'lblAdministradores
        '
        Me.lblAdministradores.AutoSize = True
        Me.lblAdministradores.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdministradores.ForeColor = System.Drawing.Color.Indigo
        Me.lblAdministradores.Location = New System.Drawing.Point(416, 37)
        Me.lblAdministradores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdministradores.Name = "lblAdministradores"
        Me.lblAdministradores.Size = New System.Drawing.Size(19, 21)
        Me.lblAdministradores.TabIndex = 13
        Me.lblAdministradores.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(127, 82)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(241, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Empleado que más vales descarga:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(195, 62)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 17)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Cantidad de empleados:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(165, 41)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(203, 17)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Cantidad de administradores:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ValesRefinor.My.Resources.Resources.userazmed
        Me.PictureBox3.Location = New System.Drawing.Point(783, 28)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
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
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CtrlMensaje As ValesRefinor.ctrlMensaje
    Friend WithEvents CtrlMensaje1 As ValesRefinor.ctrlMensaje
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblCombustibleRestante As System.Windows.Forms.Label
    Friend WithEvents lblDineroRestante As System.Windows.Forms.Label
    Friend WithEvents lblCombustible As System.Windows.Forms.Label
    Friend WithEvents lblDinero As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblPromedioDinero As System.Windows.Forms.Label
    Friend WithEvents lblPromedioCombustible As System.Windows.Forms.Label
    Friend WithEvents lblDia As System.Windows.Forms.Label
    Friend WithEvents lblEmpleadoMayorDescarga As System.Windows.Forms.Label
    Friend WithEvents lblEmpleados As System.Windows.Forms.Label
    Friend WithEvents lblAdministradores As System.Windows.Forms.Label
End Class
