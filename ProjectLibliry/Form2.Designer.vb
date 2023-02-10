<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(users))
        Me.t_userNO = New System.Windows.Forms.TextBox()
        Me.t_dateREG = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.b_cansel = New System.Windows.Forms.Button()
        Me.b_save = New System.Windows.Forms.Button()
        Me.t_userPass = New System.Windows.Forms.TextBox()
        Me.t_userPhone = New System.Windows.Forms.TextBox()
        Me.t_userNN = New System.Windows.Forms.TextBox()
        Me.t_userName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.b_delete = New System.Windows.Forms.Button()
        Me.b_change = New System.Windows.Forms.Button()
        Me.b_add = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.t_search = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't_userNO
        '
        Me.t_userNO.Location = New System.Drawing.Point(186, 68)
        Me.t_userNO.Name = "t_userNO"
        Me.t_userNO.Size = New System.Drawing.Size(143, 20)
        Me.t_userNO.TabIndex = 1
        Me.t_userNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't_dateREG
        '
        Me.t_dateREG.Location = New System.Drawing.Point(186, 146)
        Me.t_dateREG.Name = "t_dateREG"
        Me.t_dateREG.Size = New System.Drawing.Size(143, 20)
        Me.t_dateREG.TabIndex = 4
        Me.t_dateREG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(352, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "رقم المستخدم"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(345, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "تاريخ الاضافه"
        '
        'b_cansel
        '
        Me.b_cansel.BackColor = System.Drawing.Color.AliceBlue
        Me.b_cansel.Location = New System.Drawing.Point(83, 242)
        Me.b_cansel.Name = "b_cansel"
        Me.b_cansel.Size = New System.Drawing.Size(96, 32)
        Me.b_cansel.TabIndex = 27
        Me.b_cansel.Text = "الغاء"
        Me.b_cansel.UseVisualStyleBackColor = False
        '
        'b_save
        '
        Me.b_save.BackColor = System.Drawing.Color.AliceBlue
        Me.b_save.Location = New System.Drawing.Point(328, 242)
        Me.b_save.Name = "b_save"
        Me.b_save.Size = New System.Drawing.Size(96, 32)
        Me.b_save.TabIndex = 26
        Me.b_save.Text = "حفظ"
        Me.b_save.UseVisualStyleBackColor = False
        '
        't_userPass
        '
        Me.t_userPass.Location = New System.Drawing.Point(186, 210)
        Me.t_userPass.Name = "t_userPass"
        Me.t_userPass.Size = New System.Drawing.Size(143, 20)
        Me.t_userPass.TabIndex = 6
        Me.t_userPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't_userPhone
        '
        Me.t_userPhone.Location = New System.Drawing.Point(186, 118)
        Me.t_userPhone.Name = "t_userPhone"
        Me.t_userPhone.Size = New System.Drawing.Size(143, 20)
        Me.t_userPhone.TabIndex = 3
        Me.t_userPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't_userNN
        '
        Me.t_userNN.Location = New System.Drawing.Point(186, 184)
        Me.t_userNN.Name = "t_userNN"
        Me.t_userNN.Size = New System.Drawing.Size(143, 20)
        Me.t_userNN.TabIndex = 5
        Me.t_userNN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't_userName
        '
        Me.t_userName.Location = New System.Drawing.Point(186, 94)
        Me.t_userName.Name = "t_userName"
        Me.t_userName.Size = New System.Drawing.Size(143, 20)
        Me.t_userName.TabIndex = 2
        Me.t_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(361, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "pass word"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(361, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "رقم التلفون"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(360, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "user name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "اسم المستخدم"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.b_delete)
        Me.Panel1.Controls.Add(Me.b_change)
        Me.Panel1.Controls.Add(Me.b_add)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(443, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 302)
        Me.Panel1.TabIndex = 16
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(94, 195)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 22)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(93, 133)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(94, 70)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'b_delete
        '
        Me.b_delete.BackColor = System.Drawing.Color.AliceBlue
        Me.b_delete.Location = New System.Drawing.Point(19, 190)
        Me.b_delete.Name = "b_delete"
        Me.b_delete.Size = New System.Drawing.Size(108, 32)
        Me.b_delete.TabIndex = 3
        Me.b_delete.Text = "حذف"
        Me.b_delete.UseVisualStyleBackColor = False
        '
        'b_change
        '
        Me.b_change.BackColor = System.Drawing.Color.AliceBlue
        Me.b_change.Location = New System.Drawing.Point(19, 127)
        Me.b_change.Name = "b_change"
        Me.b_change.Size = New System.Drawing.Size(108, 32)
        Me.b_change.TabIndex = 2
        Me.b_change.Text = "تعديل"
        Me.b_change.UseVisualStyleBackColor = False
        '
        'b_add
        '
        Me.b_add.BackColor = System.Drawing.Color.AliceBlue
        Me.b_add.Location = New System.Drawing.Point(22, 65)
        Me.b_add.Name = "b_add"
        Me.b_add.Size = New System.Drawing.Size(105, 32)
        Me.b_add.TabIndex = 1
        Me.b_add.Text = "اضافه"
        Me.b_add.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(61, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        't_search
        '
        Me.t_search.BackColor = System.Drawing.Color.White
        Me.t_search.Location = New System.Drawing.Point(59, 26)
        Me.t_search.Multiline = True
        Me.t_search.Name = "t_search"
        Me.t_search.Size = New System.Drawing.Size(365, 28)
        Me.t_search.TabIndex = 32
        Me.t_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Azure
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(178, 117)
        Me.DataGridView1.TabIndex = 34
        '
        'users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(593, 302)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.t_search)
        Me.Controls.Add(Me.t_userNO)
        Me.Controls.Add(Me.t_dateREG)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.b_cansel)
        Me.Controls.Add(Me.b_save)
        Me.Controls.Add(Me.t_userPass)
        Me.Controls.Add(Me.t_userPhone)
        Me.Controls.Add(Me.t_userNN)
        Me.Controls.Add(Me.t_userName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "users"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents t_userNO As System.Windows.Forms.TextBox
    Friend WithEvents t_dateREG As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents b_cansel As System.Windows.Forms.Button
    Friend WithEvents b_save As System.Windows.Forms.Button
    Friend WithEvents t_userPass As System.Windows.Forms.TextBox
    Friend WithEvents t_userPhone As System.Windows.Forms.TextBox
    Friend WithEvents t_userNN As System.Windows.Forms.TextBox
    Friend WithEvents t_userName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents b_delete As System.Windows.Forms.Button
    Friend WithEvents b_change As System.Windows.Forms.Button
    Friend WithEvents b_add As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents t_search As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
