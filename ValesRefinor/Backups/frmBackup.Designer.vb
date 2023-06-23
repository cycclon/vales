<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackup))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.IBackupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbBases = New System.Windows.Forms.ComboBox
        Me.gbNuevo = New System.Windows.Forms.GroupBox
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.cmbUnidades = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnRestaurar = New System.Windows.Forms.Button
        Me.lblArchivo = New System.Windows.Forms.Label
        Me.btnSeleccionar = New System.Windows.Forms.Button
        Me.ofdBackup = New System.Windows.Forms.OpenFileDialog
        Me.CtrlMensaje = New Vales.ctrlMensaje
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IBackupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNuevo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Vales.My.Resources.Resources.Cuerpo
        Me.PictureBox1.Location = New System.Drawing.Point(657, 392)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'IBackupBindingSource
        '
        Me.IBackupBindingSource.DataSource = GetType(Entidades.CopiasDeRespaldo.iBackup)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(125, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Base:"
        '
        'cmbBases
        '
        Me.cmbBases.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBases.FormattingEnabled = True
        Me.cmbBases.Items.AddRange(New Object() {"Bitácoras", "Vales"})
        Me.cmbBases.Location = New System.Drawing.Point(172, 28)
        Me.cmbBases.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbBases.Name = "cmbBases"
        Me.cmbBases.Size = New System.Drawing.Size(138, 25)
        Me.cmbBases.TabIndex = 16
        '
        'gbNuevo
        '
        Me.gbNuevo.Controls.Add(Me.btnActualizar)
        Me.gbNuevo.Controls.Add(Me.cmbUnidades)
        Me.gbNuevo.Controls.Add(Me.Label2)
        Me.gbNuevo.Controls.Add(Me.btnGenerar)
        Me.gbNuevo.Controls.Add(Me.cmbBases)
        Me.gbNuevo.Controls.Add(Me.Label1)
        Me.gbNuevo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNuevo.ForeColor = System.Drawing.Color.SteelBlue
        Me.gbNuevo.Location = New System.Drawing.Point(223, 173)
        Me.gbNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbNuevo.Name = "gbNuevo"
        Me.gbNuevo.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbNuevo.Size = New System.Drawing.Size(425, 135)
        Me.gbNuevo.TabIndex = 17
        Me.gbNuevo.TabStop = False
        Me.gbNuevo.Text = "CREAR BACKUP"
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
        Me.btnActualizar.Location = New System.Drawing.Point(246, 55)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(170, 30)
        Me.btnActualizar.TabIndex = 20
        Me.btnActualizar.Text = "Actualizar Unidades"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'cmbUnidades
        '
        Me.cmbUnidades.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnidades.FormattingEnabled = True
        Me.cmbUnidades.Location = New System.Drawing.Point(172, 59)
        Me.cmbUnidades.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbUnidades.Name = "cmbUnidades"
        Me.cmbUnidades.Size = New System.Drawing.Size(68, 25)
        Me.cmbUnidades.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(38, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Grabar en unidad:"
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.Transparent
        Me.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnGenerar.Location = New System.Drawing.Point(334, 93)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(82, 30)
        Me.btnGenerar.TabIndex = 17
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRestaurar)
        Me.GroupBox1.Controls.Add(Me.lblArchivo)
        Me.GroupBox1.Controls.Add(Me.btnSeleccionar)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(130, 351)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(611, 104)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESTAURAR"
        '
        'btnRestaurar
        '
        Me.btnRestaurar.BackColor = System.Drawing.Color.Transparent
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Enabled = False
        Me.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnRestaurar.Location = New System.Drawing.Point(515, 66)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(90, 30)
        Me.btnRestaurar.TabIndex = 20
        Me.btnRestaurar.Text = "Restaurar"
        Me.btnRestaurar.UseVisualStyleBackColor = False
        '
        'lblArchivo
        '
        Me.lblArchivo.AutoSize = True
        Me.lblArchivo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArchivo.ForeColor = System.Drawing.Color.Indigo
        Me.lblArchivo.Location = New System.Drawing.Point(6, 35)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(169, 17)
        Me.lblArchivo.TabIndex = 19
        Me.lblArchivo.Text = "Archivo no seleccionado"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.Transparent
        Me.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnSeleccionar.Location = New System.Drawing.Point(442, 28)
        Me.btnSeleccionar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(163, 30)
        Me.btnSeleccionar.TabIndex = 18
        Me.btnSeleccionar.Text = "Seleccionar archivo..."
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'ofdBackup
        '
        Me.ofdBackup.FileName = "*.bak"
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
        Me.CtrlMensaje.TabIndex = 10
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 628)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbNuevo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CtrlMensaje)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmBackup"
        Me.Text = "frmBackup"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IBackupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNuevo.ResumeLayout(False)
        Me.gbNuevo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrlMensaje As Vales.ctrlMensaje
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBases As System.Windows.Forms.ComboBox
    Friend WithEvents IBackupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gbNuevo As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents cmbUnidades As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblArchivo As System.Windows.Forms.Label
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents ofdBackup As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
End Class
