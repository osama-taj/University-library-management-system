<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borrow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(borrow))
        Me.b_borrow = New System.Windows.Forms.Button()
        Me.b_return = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.t_start_date = New System.Windows.Forms.TextBox()
        Me.t_end_date = New System.Windows.Forms.TextBox()
        Me.t_back_date = New System.Windows.Forms.TextBox()
        Me.b_ok = New System.Windows.Forms.Button()
        Me.l_note = New System.Windows.Forms.ListBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.c_stu_name = New System.Windows.Forms.ComboBox()
        Me.c_book_name = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.t_state = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_borrow
        '
        Me.b_borrow.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.b_borrow.ForeColor = System.Drawing.Color.White
        Me.b_borrow.Location = New System.Drawing.Point(343, 25)
        Me.b_borrow.Name = "b_borrow"
        Me.b_borrow.Size = New System.Drawing.Size(120, 42)
        Me.b_borrow.TabIndex = 0
        Me.b_borrow.Text = "استعاره"
        Me.b_borrow.UseVisualStyleBackColor = False
        '
        'b_return
        '
        Me.b_return.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.b_return.ForeColor = System.Drawing.Color.White
        Me.b_return.Location = New System.Drawing.Point(125, 25)
        Me.b_return.Name = "b_return"
        Me.b_return.Size = New System.Drawing.Size(126, 42)
        Me.b_return.TabIndex = 1
        Me.b_return.Text = "اعاده"
        Me.b_return.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(533, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "اسم الكتاب"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(533, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "اسم الطالب"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(511, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "تاريخ الاستعاره"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(515, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "الموعد النهائي"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(520, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "تاريخ الارجاع"
        '
        't_start_date
        '
        Me.t_start_date.Location = New System.Drawing.Point(330, 144)
        Me.t_start_date.Name = "t_start_date"
        Me.t_start_date.ReadOnly = True
        Me.t_start_date.Size = New System.Drawing.Size(160, 20)
        Me.t_start_date.TabIndex = 9
        Me.t_start_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't_end_date
        '
        Me.t_end_date.Location = New System.Drawing.Point(329, 174)
        Me.t_end_date.Name = "t_end_date"
        Me.t_end_date.ReadOnly = True
        Me.t_end_date.Size = New System.Drawing.Size(160, 20)
        Me.t_end_date.TabIndex = 10
        Me.t_end_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't_back_date
        '
        Me.t_back_date.Location = New System.Drawing.Point(329, 205)
        Me.t_back_date.Name = "t_back_date"
        Me.t_back_date.Size = New System.Drawing.Size(160, 20)
        Me.t_back_date.TabIndex = 11
        Me.t_back_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'b_ok
        '
        Me.b_ok.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.b_ok.ForeColor = System.Drawing.Color.White
        Me.b_ok.Location = New System.Drawing.Point(330, 263)
        Me.b_ok.Name = "b_ok"
        Me.b_ok.Size = New System.Drawing.Size(74, 29)
        Me.b_ok.TabIndex = 12
        Me.b_ok.Text = "تم"
        Me.b_ok.UseVisualStyleBackColor = False
        '
        'l_note
        '
        Me.l_note.FormattingEnabled = True
        Me.l_note.Location = New System.Drawing.Point(12, 89)
        Me.l_note.Name = "l_note"
        Me.l_note.Size = New System.Drawing.Size(263, 134)
        Me.l_note.TabIndex = 13
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(423, 31)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(210, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'c_stu_name
        '
        Me.c_stu_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.c_stu_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.c_stu_name.FormattingEnabled = True
        Me.c_stu_name.Location = New System.Drawing.Point(330, 85)
        Me.c_stu_name.Name = "c_stu_name"
        Me.c_stu_name.Size = New System.Drawing.Size(160, 21)
        Me.c_stu_name.TabIndex = 18
        '
        'c_book_name
        '
        Me.c_book_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.c_book_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.c_book_name.FormattingEnabled = True
        Me.c_book_name.Location = New System.Drawing.Point(330, 117)
        Me.c_book_name.Name = "c_book_name"
        Me.c_book_name.Size = New System.Drawing.Size(160, 21)
        Me.c_book_name.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(517, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "state"
        Me.Label6.Visible = False
        '
        't_state
        '
        Me.t_state.Location = New System.Drawing.Point(423, 231)
        Me.t_state.Name = "t_state"
        Me.t_state.Size = New System.Drawing.Size(67, 20)
        Me.t_state.TabIndex = 23
        Me.t_state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.t_state.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-2, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(304, 117)
        Me.DataGridView1.TabIndex = 20
        Me.DataGridView1.Visible = False
        '
        'borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(615, 304)
        Me.Controls.Add(Me.t_state)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.c_book_name)
        Me.Controls.Add(Me.c_stu_name)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.l_note)
        Me.Controls.Add(Me.b_ok)
        Me.Controls.Add(Me.t_back_date)
        Me.Controls.Add(Me.t_end_date)
        Me.Controls.Add(Me.t_start_date)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.b_return)
        Me.Controls.Add(Me.b_borrow)
        Me.Name = "borrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "borrow"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_borrow As System.Windows.Forms.Button
    Friend WithEvents b_return As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents t_start_date As System.Windows.Forms.TextBox
    Friend WithEvents t_end_date As System.Windows.Forms.TextBox
    Friend WithEvents t_back_date As System.Windows.Forms.TextBox
    Friend WithEvents b_ok As System.Windows.Forms.Button
    Friend WithEvents l_note As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents c_stu_name As System.Windows.Forms.ComboBox
    Friend WithEvents c_book_name As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents t_state As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
