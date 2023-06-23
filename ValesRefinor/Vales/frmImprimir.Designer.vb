<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImprimir))
        Me.ppcVales = New System.Windows.Forms.PrintPreviewControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblHojas = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.nudPagina = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtHasta = New System.Windows.Forms.TextBox
        Me.txtPaginaInicio = New System.Windows.Forms.TextBox
        CType(Me.nudPagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ppcVales
        '
        Me.ppcVales.AutoZoom = False
        Me.ppcVales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ppcVales.Location = New System.Drawing.Point(0, 110)
        Me.ppcVales.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ppcVales.Name = "ppcVales"
        Me.ppcVales.Size = New System.Drawing.Size(1008, 528)
        Me.ppcVales.TabIndex = 0
        Me.ppcVales.Zoom = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hojas necesarias:"
        '
        'lblHojas
        '
        Me.lblHojas.AutoSize = True
        Me.lblHojas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHojas.ForeColor = System.Drawing.Color.Indigo
        Me.lblHojas.Location = New System.Drawing.Point(139, 8)
        Me.lblHojas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHojas.Name = "lblHojas"
        Me.lblHojas.Size = New System.Drawing.Size(15, 17)
        Me.lblHojas.TabIndex = 2
        Me.lblHojas.Text = "0"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew
        Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnImprimir.Location = New System.Drawing.Point(602, 2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(100, 30)
        Me.btnImprimir.TabIndex = 8
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'nudPagina
        '
        Me.nudPagina.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPagina.Location = New System.Drawing.Point(924, 7)
        Me.nudPagina.Name = "nudPagina"
        Me.nudPagina.Size = New System.Drawing.Size(72, 23)
        Me.nudPagina.TabIndex = 9
        Me.nudPagina.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(834, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Ver Página:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Vales.My.Resources.Resources.impraz30
        Me.PictureBox2.Location = New System.Drawing.Point(566, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(307, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Imprimir Pág:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(462, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Hasta:"
        '
        'txtHasta
        '
        Me.txtHasta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHasta.Location = New System.Drawing.Point(513, 5)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(47, 23)
        Me.txtHasta.TabIndex = 19
        Me.txtHasta.Text = "1"
        Me.txtHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPaginaInicio
        '
        Me.txtPaginaInicio.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaginaInicio.Location = New System.Drawing.Point(408, 5)
        Me.txtPaginaInicio.Name = "txtPaginaInicio"
        Me.txtPaginaInicio.Size = New System.Drawing.Size(47, 23)
        Me.txtPaginaInicio.TabIndex = 18
        Me.txtPaginaInicio.Text = "1"
        Me.txtPaginaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 638)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtPaginaInicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudPagina)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblHojas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ppcVales)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmImprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vales Refinor - Imprimir Vales"
        Me.TopMost = True
        CType(Me.nudPagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ppcVales As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHojas As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents nudPagina As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHasta As System.Windows.Forms.TextBox
    Friend WithEvents txtPaginaInicio As System.Windows.Forms.TextBox
End Class
