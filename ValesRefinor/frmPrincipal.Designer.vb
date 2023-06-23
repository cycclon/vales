<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbUsuario = New System.Windows.Forms.PictureBox()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.pbEncabezado = New System.Windows.Forms.PictureBox()
        Me.CtrlMenu1 = New Vales.ctrlMenu()
        Me.Panel1.SuspendLayout()
        CType(Me.pbUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbUsuario)
        Me.Panel1.Controls.Add(Me.btnUsuario)
        Me.Panel1.Controls.Add(Me.btnCerrarSesion)
        Me.Panel1.Controls.Add(Me.pbEncabezado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 75)
        Me.Panel1.TabIndex = 3
        '
        'pbUsuario
        '
        Me.pbUsuario.BackColor = System.Drawing.Color.Transparent
        Me.pbUsuario.Image = Global.Vales.My.Resources.Resources.useraztumb
        Me.pbUsuario.Location = New System.Drawing.Point(641, 32)
        Me.pbUsuario.Name = "pbUsuario"
        Me.pbUsuario.Size = New System.Drawing.Size(20, 20)
        Me.pbUsuario.TabIndex = 26
        Me.pbUsuario.TabStop = False
        Me.pbUsuario.Visible = False
        '
        'btnUsuario
        '
        Me.btnUsuario.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Bisque
        Me.btnUsuario.FlatAppearance.BorderSize = 0
        Me.btnUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.ForeColor = System.Drawing.Color.Silver
        Me.btnUsuario.Location = New System.Drawing.Point(664, 27)
        Me.btnUsuario.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(100, 30)
        Me.btnUsuario.TabIndex = 25
        Me.btnUsuario.Text = "Cerrar Sesión"
        Me.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuario.UseVisualStyleBackColor = False
        Me.btnUsuario.Visible = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Bisque
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.Silver
        Me.btnCerrarSesion.Location = New System.Drawing.Point(775, 27)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(100, 30)
        Me.btnCerrarSesion.TabIndex = 24
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        Me.btnCerrarSesion.Visible = False
        '
        'pbEncabezado
        '
        Me.pbEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.pbEncabezado.Name = "pbEncabezado"
        Me.pbEncabezado.Size = New System.Drawing.Size(998, 75)
        Me.pbEncabezado.TabIndex = 0
        Me.pbEncabezado.TabStop = False
        '
        'CtrlMenu1
        '
        Me.CtrlMenu1.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrlMenu1.Location = New System.Drawing.Point(0, 75)
        Me.CtrlMenu1.Name = "CtrlMenu1"
        Me.CtrlMenu1.Size = New System.Drawing.Size(125, 632)
        Me.CtrlMenu1.TabIndex = 6
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 707)
        Me.Controls.Add(Me.CtrlMenu1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Melipal S.A. - Vales"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbEncabezado As System.Windows.Forms.PictureBox
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents CtrlMenu1 As Vales.ctrlMenu
    Friend WithEvents pbUsuario As System.Windows.Forms.PictureBox
    Friend WithEvents btnUsuario As System.Windows.Forms.Button

End Class
