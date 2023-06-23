<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlBotonMenu
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
        Me.btnBoton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnBoton
        '
        Me.btnBoton.BackColor = System.Drawing.Color.Transparent
        Me.btnBoton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBoton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBoton.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.btnBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnBoton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btnBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBoton.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnBoton.Location = New System.Drawing.Point(0, 0)
        Me.btnBoton.Name = "btnBoton"
        Me.btnBoton.Size = New System.Drawing.Size(125, 30)
        Me.btnBoton.TabIndex = 25
        Me.btnBoton.Text = "Emitir"
        Me.btnBoton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBoton.UseVisualStyleBackColor = False
        '
        'ctrlBotonMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnBoton)
        Me.Name = "ctrlBotonMenu"
        Me.Size = New System.Drawing.Size(125, 30)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBoton As System.Windows.Forms.Button

End Class
