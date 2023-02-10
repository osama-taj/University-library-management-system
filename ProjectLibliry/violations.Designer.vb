<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class violations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(violations))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.b_pay = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.t_search = New System.Windows.Forms.TextBox()
        Me.Refresh = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.Size = New System.Drawing.Size(424, 198)
        Me.DataGridView1.TabIndex = 7
        '
        'b_pay
        '
        Me.b_pay.Location = New System.Drawing.Point(24, 39)
        Me.b_pay.Name = "b_pay"
        Me.b_pay.Size = New System.Drawing.Size(75, 23)
        Me.b_pay.TabIndex = 9
        Me.b_pay.Text = "دفع غرامه"
        Me.b_pay.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(143, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        't_search
        '
        Me.t_search.BackColor = System.Drawing.Color.White
        Me.t_search.Location = New System.Drawing.Point(141, 36)
        Me.t_search.Multiline = True
        Me.t_search.Name = "t_search"
        Me.t_search.Size = New System.Drawing.Size(328, 28)
        Me.t_search.TabIndex = 17
        Me.t_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(2, 0)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(75, 23)
        Me.Refresh.TabIndex = 19
        Me.Refresh.Text = "Refresh"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'violations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(481, 299)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.t_search)
        Me.Controls.Add(Me.b_pay)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "violations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "violations"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents b_pay As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents t_search As System.Windows.Forms.TextBox
    Friend WithEvents Refresh As System.Windows.Forms.Button
End Class
