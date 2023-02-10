<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pay
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
        Me.t_userName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.t_amount = New System.Windows.Forms.TextBox()
        Me.t_datePay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b_back = New System.Windows.Forms.Button()
        Me.b_save = New System.Windows.Forms.Button()
        Me.c_stuName = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't_userName
        '
        Me.t_userName.Location = New System.Drawing.Point(4, 75)
        Me.t_userName.Name = "t_userName"
        Me.t_userName.Size = New System.Drawing.Size(143, 20)
        Me.t_userName.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Location = New System.Drawing.Point(416, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "اسم الطالب"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label6.Location = New System.Drawing.Point(178, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "المستخدم"
        '
        't_amount
        '
        Me.t_amount.Location = New System.Drawing.Point(4, 47)
        Me.t_amount.Name = "t_amount"
        Me.t_amount.Size = New System.Drawing.Size(143, 20)
        Me.t_amount.TabIndex = 35
        '
        't_datePay
        '
        Me.t_datePay.Location = New System.Drawing.Point(250, 73)
        Me.t_datePay.Name = "t_datePay"
        Me.t_datePay.Size = New System.Drawing.Size(143, 20)
        Me.t_datePay.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label3.Location = New System.Drawing.Point(194, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "المبلغ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(414, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "تاريخ الدفع"
        '
        'b_back
        '
        Me.b_back.BackColor = System.Drawing.Color.DarkGray
        Me.b_back.Location = New System.Drawing.Point(389, 12)
        Me.b_back.Name = "b_back"
        Me.b_back.Size = New System.Drawing.Size(75, 23)
        Me.b_back.TabIndex = 40
        Me.b_back.Text = "back >>"
        Me.b_back.UseVisualStyleBackColor = False
        '
        'b_save
        '
        Me.b_save.BackColor = System.Drawing.Color.DarkGray
        Me.b_save.Location = New System.Drawing.Point(4, 207)
        Me.b_save.Name = "b_save"
        Me.b_save.Size = New System.Drawing.Size(75, 23)
        Me.b_save.TabIndex = 41
        Me.b_save.Text = "حفظ"
        Me.b_save.UseVisualStyleBackColor = False
        '
        'c_stuName
        '
        Me.c_stuName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.c_stuName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.c_stuName.FormattingEnabled = True
        Me.c_stuName.Location = New System.Drawing.Point(250, 49)
        Me.c_stuName.Name = "c_stuName"
        Me.c_stuName.Size = New System.Drawing.Size(143, 21)
        Me.c_stuName.TabIndex = 42
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(464, 100)
        Me.DataGridView1.TabIndex = 43
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.Location = New System.Drawing.Point(12, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(491, 242)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.c_stuName)
        Me.Controls.Add(Me.b_save)
        Me.Controls.Add(Me.b_back)
        Me.Controls.Add(Me.t_userName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.t_amount)
        Me.Controls.Add(Me.t_datePay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pay"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents t_userName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents t_amount As System.Windows.Forms.TextBox
    Friend WithEvents t_datePay As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b_back As System.Windows.Forms.Button
    Friend WithEvents b_save As System.Windows.Forms.Button
    Friend WithEvents c_stuName As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
