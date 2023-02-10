<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.l_userName = New System.Windows.Forms.Label()
        Me.p_userPic = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.type = New System.Windows.Forms.Button()
        Me.pb8 = New System.Windows.Forms.PictureBox()
        Me.pb7 = New System.Windows.Forms.PictureBox()
        Me.pb6 = New System.Windows.Forms.PictureBox()
        Me.pb5 = New System.Windows.Forms.PictureBox()
        Me.pb4 = New System.Windows.Forms.PictureBox()
        Me.pb3 = New System.Windows.Forms.PictureBox()
        Me.b_record = New System.Windows.Forms.Button()
        Me.b_pay = New System.Windows.Forms.Button()
        Me.b_returnandborrow = New System.Windows.Forms.Button()
        Me.b_student = New System.Windows.Forms.Button()
        Me.b_user = New System.Windows.Forms.Button()
        Me.b_aurther = New System.Windows.Forms.Button()
        Me.b_books = New System.Windows.Forms.Button()
        Me.rb_searchBook = New System.Windows.Forms.RadioButton()
        Me.rb_searchAuthor = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.t_search = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.p_userPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.t_search)
        Me.Panel2.Controls.Add(Me.Refresh)
        Me.Panel2.Controls.Add(Me.rb_searchAuthor)
        Me.Panel2.Controls.Add(Me.l_userName)
        Me.Panel2.Controls.Add(Me.rb_searchBook)
        Me.Panel2.Controls.Add(Me.p_userPic)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(972, 173)
        Me.Panel2.TabIndex = 1
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(12, 12)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(75, 23)
        Me.Refresh.TabIndex = 16
        Me.Refresh.Text = "Refresh"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'l_userName
        '
        Me.l_userName.AutoSize = True
        Me.l_userName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_userName.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.l_userName.Location = New System.Drawing.Point(715, 44)
        Me.l_userName.Name = "l_userName"
        Me.l_userName.Size = New System.Drawing.Size(83, 16)
        Me.l_userName.TabIndex = 1
        Me.l_userName.Text = "اسم المستخدم"
        Me.l_userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'p_userPic
        '
        Me.p_userPic.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.p_userPic.Image = CType(resources.GetObject("p_userPic.Image"), System.Drawing.Image)
        Me.p_userPic.Location = New System.Drawing.Point(815, 12)
        Me.p_userPic.Name = "p_userPic"
        Me.p_userPic.Size = New System.Drawing.Size(100, 72)
        Me.p_userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_userPic.TabIndex = 0
        Me.p_userPic.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(533, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(158, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.type)
        Me.Panel1.Controls.Add(Me.pb8)
        Me.Panel1.Controls.Add(Me.pb7)
        Me.Panel1.Controls.Add(Me.pb6)
        Me.Panel1.Controls.Add(Me.pb5)
        Me.Panel1.Controls.Add(Me.pb4)
        Me.Panel1.Controls.Add(Me.pb3)
        Me.Panel1.Controls.Add(Me.b_record)
        Me.Panel1.Controls.Add(Me.b_pay)
        Me.Panel1.Controls.Add(Me.b_returnandborrow)
        Me.Panel1.Controls.Add(Me.b_student)
        Me.Panel1.Controls.Add(Me.b_user)
        Me.Panel1.Controls.Add(Me.b_aurther)
        Me.Panel1.Controls.Add(Me.b_books)
        Me.Panel1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Panel1.Location = New System.Drawing.Point(767, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 437)
        Me.Panel1.TabIndex = 2
        '
        'type
        '
        Me.type.BackColor = System.Drawing.Color.AliceBlue
        Me.type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.type.Location = New System.Drawing.Point(13, 340)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(171, 37)
        Me.type.TabIndex = 21
        Me.type.Text = "الانواع"
        Me.type.UseVisualStyleBackColor = False
        '
        'pb8
        '
        Me.pb8.BackColor = System.Drawing.Color.AliceBlue
        Me.pb8.Image = CType(resources.GetObject("pb8.Image"), System.Drawing.Image)
        Me.pb8.Location = New System.Drawing.Point(146, 237)
        Me.pb8.Name = "pb8"
        Me.pb8.Size = New System.Drawing.Size(34, 30)
        Me.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb8.TabIndex = 20
        Me.pb8.TabStop = False
        '
        'pb7
        '
        Me.pb7.BackColor = System.Drawing.Color.AliceBlue
        Me.pb7.Image = CType(resources.GetObject("pb7.Image"), System.Drawing.Image)
        Me.pb7.Location = New System.Drawing.Point(149, 177)
        Me.pb7.Name = "pb7"
        Me.pb7.Size = New System.Drawing.Size(34, 30)
        Me.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb7.TabIndex = 19
        Me.pb7.TabStop = False
        '
        'pb6
        '
        Me.pb6.BackColor = System.Drawing.Color.AliceBlue
        Me.pb6.Image = CType(resources.GetObject("pb6.Image"), System.Drawing.Image)
        Me.pb6.Location = New System.Drawing.Point(146, 289)
        Me.pb6.Name = "pb6"
        Me.pb6.Size = New System.Drawing.Size(34, 30)
        Me.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb6.TabIndex = 18
        Me.pb6.TabStop = False
        '
        'pb5
        '
        Me.pb5.BackColor = System.Drawing.Color.AliceBlue
        Me.pb5.Image = CType(resources.GetObject("pb5.Image"), System.Drawing.Image)
        Me.pb5.Location = New System.Drawing.Point(149, 122)
        Me.pb5.Name = "pb5"
        Me.pb5.Size = New System.Drawing.Size(34, 30)
        Me.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb5.TabIndex = 17
        Me.pb5.TabStop = False
        '
        'pb4
        '
        Me.pb4.BackColor = System.Drawing.Color.AliceBlue
        Me.pb4.Image = CType(resources.GetObject("pb4.Image"), System.Drawing.Image)
        Me.pb4.Location = New System.Drawing.Point(151, 61)
        Me.pb4.Name = "pb4"
        Me.pb4.Size = New System.Drawing.Size(34, 30)
        Me.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb4.TabIndex = 16
        Me.pb4.TabStop = False
        '
        'pb3
        '
        Me.pb3.BackColor = System.Drawing.Color.AliceBlue
        Me.pb3.Image = CType(resources.GetObject("pb3.Image"), System.Drawing.Image)
        Me.pb3.Location = New System.Drawing.Point(151, 9)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(34, 30)
        Me.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb3.TabIndex = 15
        Me.pb3.TabStop = False
        '
        'b_record
        '
        Me.b_record.BackColor = System.Drawing.Color.AliceBlue
        Me.b_record.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_record.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.b_record.Location = New System.Drawing.Point(18, 57)
        Me.b_record.Name = "b_record"
        Me.b_record.Size = New System.Drawing.Size(171, 37)
        Me.b_record.TabIndex = 13
        Me.b_record.Text = "سجل الاستعاره"
        Me.b_record.UseVisualStyleBackColor = False
        '
        'b_pay
        '
        Me.b_pay.BackColor = System.Drawing.Color.AliceBlue
        Me.b_pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_pay.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.b_pay.Location = New System.Drawing.Point(14, 388)
        Me.b_pay.Name = "b_pay"
        Me.b_pay.Size = New System.Drawing.Size(171, 37)
        Me.b_pay.TabIndex = 12
        Me.b_pay.Text = " المخالفات و الغرامات"
        Me.b_pay.UseVisualStyleBackColor = False
        '
        'b_returnandborrow
        '
        Me.b_returnandborrow.BackColor = System.Drawing.Color.AliceBlue
        Me.b_returnandborrow.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_returnandborrow.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.b_returnandborrow.Location = New System.Drawing.Point(18, 5)
        Me.b_returnandborrow.Name = "b_returnandborrow"
        Me.b_returnandborrow.Size = New System.Drawing.Size(171, 37)
        Me.b_returnandborrow.TabIndex = 11
        Me.b_returnandborrow.Text = "استعاره _ اعاده"
        Me.b_returnandborrow.UseVisualStyleBackColor = False
        '
        'b_student
        '
        Me.b_student.BackColor = System.Drawing.Color.AliceBlue
        Me.b_student.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.b_student.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.b_student.Location = New System.Drawing.Point(18, 232)
        Me.b_student.Name = "b_student"
        Me.b_student.Size = New System.Drawing.Size(167, 37)
        Me.b_student.TabIndex = 10
        Me.b_student.Text = "الطلاب"
        Me.b_student.UseVisualStyleBackColor = False
        '
        'b_user
        '
        Me.b_user.BackColor = System.Drawing.Color.AliceBlue
        Me.b_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_user.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.b_user.Location = New System.Drawing.Point(13, 286)
        Me.b_user.Name = "b_user"
        Me.b_user.Size = New System.Drawing.Size(171, 37)
        Me.b_user.TabIndex = 9
        Me.b_user.Text = "المستخدمين"
        Me.b_user.UseVisualStyleBackColor = False
        '
        'b_aurther
        '
        Me.b_aurther.BackColor = System.Drawing.Color.AliceBlue
        Me.b_aurther.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.b_aurther.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.b_aurther.Location = New System.Drawing.Point(17, 173)
        Me.b_aurther.Name = "b_aurther"
        Me.b_aurther.Size = New System.Drawing.Size(172, 37)
        Me.b_aurther.TabIndex = 8
        Me.b_aurther.Text = "المؤلفين"
        Me.b_aurther.UseVisualStyleBackColor = False
        '
        'b_books
        '
        Me.b_books.BackColor = System.Drawing.Color.AliceBlue
        Me.b_books.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_books.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.b_books.Location = New System.Drawing.Point(18, 119)
        Me.b_books.Name = "b_books"
        Me.b_books.Size = New System.Drawing.Size(171, 37)
        Me.b_books.TabIndex = 7
        Me.b_books.Text = "الكتب"
        Me.b_books.UseVisualStyleBackColor = False
        '
        'rb_searchBook
        '
        Me.rb_searchBook.AutoSize = True
        Me.rb_searchBook.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_searchBook.ForeColor = System.Drawing.Color.White
        Me.rb_searchBook.Location = New System.Drawing.Point(152, 150)
        Me.rb_searchBook.Name = "rb_searchBook"
        Me.rb_searchBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rb_searchBook.Size = New System.Drawing.Size(94, 20)
        Me.rb_searchBook.TabIndex = 4
        Me.rb_searchBook.TabStop = True
        Me.rb_searchBook.Text = "بحث باسم الكتاب"
        Me.rb_searchBook.UseVisualStyleBackColor = True
        '
        'rb_searchAuthor
        '
        Me.rb_searchAuthor.AutoSize = True
        Me.rb_searchAuthor.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_searchAuthor.ForeColor = System.Drawing.Color.White
        Me.rb_searchAuthor.Location = New System.Drawing.Point(38, 150)
        Me.rb_searchAuthor.Name = "rb_searchAuthor"
        Me.rb_searchAuthor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rb_searchAuthor.Size = New System.Drawing.Size(94, 20)
        Me.rb_searchAuthor.TabIndex = 5
        Me.rb_searchAuthor.TabStop = True
        Me.rb_searchAuthor.Text = "بحث باسم الكاتب"
        Me.rb_searchAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rb_searchAuthor.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Azure
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 179)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.Size = New System.Drawing.Size(694, 328)
        Me.DataGridView1.TabIndex = 6
        '
        't_search
        '
        Me.t_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_search.Location = New System.Drawing.Point(292, 139)
        Me.t_search.Multiline = True
        Me.t_search.Name = "t_search"
        Me.t_search.Size = New System.Drawing.Size(457, 31)
        Me.t_search.TabIndex = 3
        Me.t_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(295, 141)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 537)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.p_userPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents l_userName As System.Windows.Forms.Label
    Friend WithEvents p_userPic As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rb_searchBook As System.Windows.Forms.RadioButton
    Friend WithEvents rb_searchAuthor As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents b_student As System.Windows.Forms.Button
    Friend WithEvents b_user As System.Windows.Forms.Button
    Friend WithEvents b_aurther As System.Windows.Forms.Button
    Friend WithEvents b_books As System.Windows.Forms.Button
    Friend WithEvents b_returnandborrow As System.Windows.Forms.Button
    Friend WithEvents b_pay As System.Windows.Forms.Button
    Friend WithEvents b_record As System.Windows.Forms.Button
    Friend WithEvents t_search As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pb6 As System.Windows.Forms.PictureBox
    Friend WithEvents pb5 As System.Windows.Forms.PictureBox
    Friend WithEvents pb4 As System.Windows.Forms.PictureBox
    Friend WithEvents pb3 As System.Windows.Forms.PictureBox
    Friend WithEvents pb8 As System.Windows.Forms.PictureBox
    Friend WithEvents pb7 As System.Windows.Forms.PictureBox
    Friend WithEvents type As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Refresh As System.Windows.Forms.Button
End Class
