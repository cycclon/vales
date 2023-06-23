<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlAyuda
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pbAyuda = New System.Windows.Forms.PictureBox
        Me.lblAyuda = New System.Windows.Forms.Label
        CType(Me.pbAyuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbAyuda
        '
        Me.pbAyuda.Image = Global.Vales.My.Resources.Resources.ayuaztumb
        Me.pbAyuda.Location = New System.Drawing.Point(0, 0)
        Me.pbAyuda.Name = "pbAyuda"
        Me.pbAyuda.Size = New System.Drawing.Size(25, 25)
        Me.pbAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbAyuda.TabIndex = 0
        Me.pbAyuda.TabStop = False
        '
        'lblAyuda
        '
        Me.lblAyuda.AutoSize = True
        Me.lblAyuda.BackColor = System.Drawing.Color.Transparent
        Me.lblAyuda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyuda.ForeColor = System.Drawing.Color.DarkGray
        Me.lblAyuda.Location = New System.Drawing.Point(31, 0)
        Me.lblAyuda.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblAyuda.Name = "lblAyuda"
        Me.lblAyuda.Size = New System.Drawing.Size(192, 51)
        Me.lblAyuda.TabIndex = 1
        Me.lblAyuda.Text = "Caracteres permitidos:  --------------------------------------------. Máximo 3, m" & _
            "ínimo 200"
        Me.lblAyuda.Visible = False
        '
        'ctrlAyuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lblAyuda)
        Me.Controls.Add(Me.pbAyuda)
        Me.Cursor = System.Windows.Forms.Cursors.Help
        Me.Name = "ctrlAyuda"
        Me.Size = New System.Drawing.Size(250, 25)
        CType(Me.pbAyuda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbAyuda As System.Windows.Forms.PictureBox
    Friend WithEvents lblAyuda As System.Windows.Forms.Label

End Class
