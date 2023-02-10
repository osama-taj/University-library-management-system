<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Books
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Books))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.b_delete = New System.Windows.Forms.Button()
        Me.b_change = New System.Windows.Forms.Button()
        Me.b_add = New System.Windows.Forms.Button()
        Me.t_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t_bookName = New System.Windows.Forms.TextBox()
        Me.t_copyNO = New System.Windows.Forms.TextBox()
        Me.b_save = New System.Windows.Forms.Button()
        Me.b_cansel = New System.Windows.Forms.Button()
        Me.t_bookNO = New System.Windows.Forms.TextBox()
        Me.t_pop = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.c_type = New System.Windows.Forms.ComboBox()
        Me.c_authorName = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.empty = New System.Windows.Forms.RadioButton()
        Me.minus = New System.Windows.Forms.RadioButton()
        Me.plus = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.b_delete)
        Me.Panel1.Controls.Add(Me.b_change)
        Me.Panel1.Controls.Add(Me.b_add)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(454, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 309)
        Me.Panel1.TabIndex = 0
        '
        'b_delete
        '
        Me.b_delete.BackColor = System.Drawing.Color.AliceBlue
        Me.b_delete.Location = New System.Drawing.Point(30, 194)
        Me.b_delete.Name = "b_delete"
        Me.b_delete.Size = New System.Drawing.Size(96, 32)
        Me.b_delete.TabIndex = 3
        Me.b_delete.Text = "حذف"
        Me.b_delete.UseVisualStyleBackColor = False
        '
        'b_change
        '
        Me.b_change.BackColor = System.Drawing.Color.AliceBlue
        Me.b_change.Location = New System.Drawing.Point(30, 131)
        Me.b_change.Name = "b_change"
        Me.b_change.Size = New System.Drawing.Size(96, 32)
        Me.b_change.TabIndex = 2
        Me.b_change.Text = "تعديل"
        Me.b_change.UseVisualStyleBackColor = False
        '
        'b_add
        '
        Me.b_add.BackColor = System.Drawing.Color.AliceBlue
        Me.b_add.Location = New System.Drawing.Point(33, 69)
        Me.b_add.Name = "b_add"
        Me.b_add.Size = New System.Drawing.Size(96, 32)
        Me.b_add.TabIndex = 1
        Me.b_add.Text = "اضافة"
        Me.b_add.UseVisualStyleBackColor = False
        '
        't_search
        '
        Me.t_search.BackColor = System.Drawing.Color.White
        Me.t_search.Location = New System.Drawing.Point(37, 12)
        Me.t_search.Multiline = True
        Me.t_search.Name = "t_search"
        Me.t_search.Size = New System.Drawing.Size(365, 28)
        Me.t_search.TabIndex = 1
        Me.t_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(386, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "اسم الكتاب"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(153, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "اسم المؤلف"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(151, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "نوع الكتاب"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(155, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "عدد النسخ"
        '
        't_bookName
        '
        Me.t_bookName.Location = New System.Drawing.Point(222, 73)
        Me.t_bookName.Name = "t_bookName"
        Me.t_bookName.Size = New System.Drawing.Size(143, 20)
        Me.t_bookName.TabIndex = 16
        '
        't_copyNO
        '
        Me.t_copyNO.Location = New System.Drawing.Point(6, 32)
        Me.t_copyNO.Name = "t_copyNO"
        Me.t_copyNO.Size = New System.Drawing.Size(143, 20)
        Me.t_copyNO.TabIndex = 19
        '
        'b_save
        '
        Me.b_save.BackColor = System.Drawing.Color.AliceBlue
        Me.b_save.Location = New System.Drawing.Point(300, 265)
        Me.b_save.Name = "b_save"
        Me.b_save.Size = New System.Drawing.Size(96, 32)
        Me.b_save.TabIndex = 21
        Me.b_save.Text = "حفظ"
        Me.b_save.UseVisualStyleBackColor = False
        '
        'b_cansel
        '
        Me.b_cansel.BackColor = System.Drawing.Color.AliceBlue
        Me.b_cansel.Location = New System.Drawing.Point(55, 265)
        Me.b_cansel.Name = "b_cansel"
        Me.b_cansel.Size = New System.Drawing.Size(96, 32)
        Me.b_cansel.TabIndex = 11
        Me.b_cansel.Text = "الغاء"
        Me.b_cansel.UseVisualStyleBackColor = False
        '
        't_bookNO
        '
        Me.t_bookNO.Location = New System.Drawing.Point(222, 47)
        Me.t_bookNO.Name = "t_bookNO"
        Me.t_bookNO.Size = New System.Drawing.Size(143, 20)
        Me.t_bookNO.TabIndex = 15
        '
        't_pop
        '
        Me.t_pop.Location = New System.Drawing.Point(11, 104)
        Me.t_pop.Name = "t_pop"
        Me.t_pop.Size = New System.Drawing.Size(126, 20)
        Me.t_pop.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(388, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "رقم الكتاب"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(153, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "تاريخ النشر"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'c_type
        '
        Me.c_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.c_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.c_type.FormattingEnabled = True
        Me.c_type.Location = New System.Drawing.Point(11, 50)
        Me.c_type.Name = "c_type"
        Me.c_type.Size = New System.Drawing.Size(121, 21)
        Me.c_type.TabIndex = 17
        '
        'c_authorName
        '
        Me.c_authorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.c_authorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.c_authorName.FormattingEnabled = True
        Me.c_authorName.Location = New System.Drawing.Point(11, 73)
        Me.c_authorName.Name = "c_authorName"
        Me.c_authorName.Size = New System.Drawing.Size(121, 21)
        Me.c_authorName.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Azure
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 175)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(355, 84)
        Me.DataGridView1.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.empty)
        Me.GroupBox1.Controls.Add(Me.minus)
        Me.GroupBox1.Controls.Add(Me.plus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.t_copyNO)
        Me.GroupBox1.Location = New System.Drawing.Point(222, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(226, 59)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تعديل عدد النسخ"
        '
        'empty
        '
        Me.empty.AutoSize = True
        Me.empty.Checked = True
        Me.empty.Location = New System.Drawing.Point(169, 13)
        Me.empty.Name = "empty"
        Me.empty.Size = New System.Drawing.Size(53, 17)
        Me.empty.TabIndex = 22
        Me.empty.TabStop = True
        Me.empty.Text = "لا شي"
        Me.empty.UseVisualStyleBackColor = True
        '
        'minus
        '
        Me.minus.AutoSize = True
        Me.minus.Location = New System.Drawing.Point(27, 13)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(45, 17)
        Me.minus.TabIndex = 21
        Me.minus.Text = "نقص"
        Me.minus.UseVisualStyleBackColor = True
        '
        'plus
        '
        Me.plus.AutoSize = True
        Me.plus.Location = New System.Drawing.Point(100, 13)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(49, 17)
        Me.plus.TabIndex = 20
        Me.plus.Text = "زياده"
        Me.plus.UseVisualStyleBackColor = True
        '
        'Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(604, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.c_authorName)
        Me.Controls.Add(Me.c_type)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.t_bookNO)
        Me.Controls.Add(Me.t_pop)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.b_cansel)
        Me.Controls.Add(Me.b_save)
        Me.Controls.Add(Me.t_bookName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.t_search)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Books"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Books"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents b_delete As System.Windows.Forms.Button
    Friend WithEvents b_change As System.Windows.Forms.Button
    Friend WithEvents b_add As System.Windows.Forms.Button
    Friend WithEvents t_search As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents t_bookName As System.Windows.Forms.TextBox
    Friend WithEvents t_copyNO As System.Windows.Forms.TextBox
    Friend WithEvents b_save As System.Windows.Forms.Button
    Friend WithEvents b_cansel As System.Windows.Forms.Button
    Friend WithEvents t_bookNO As System.Windows.Forms.TextBox
    Friend WithEvents t_pop As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents c_type As System.Windows.Forms.ComboBox
    Friend WithEvents c_authorName As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents minus As System.Windows.Forms.RadioButton
    Friend WithEvents plus As System.Windows.Forms.RadioButton
    Friend WithEvents empty As System.Windows.Forms.RadioButton
End Class
