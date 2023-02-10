<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class types
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(types))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.b_delete = New System.Windows.Forms.Button()
        Me.b_change = New System.Windows.Forms.Button()
        Me.b_add = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.t_search = New System.Windows.Forms.TextBox()
        Me.t_typeno = New System.Windows.Forms.TextBox()
        Me.t_typename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.b_save = New System.Windows.Forms.Button()
        Me.b_cancel = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.b_delete)
        Me.Panel1.Controls.Add(Me.b_change)
        Me.Panel1.Controls.Add(Me.b_add)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(374, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(110, 234)
        Me.Panel1.TabIndex = 17
        '
        'b_delete
        '
        Me.b_delete.BackColor = System.Drawing.Color.AliceBlue
        Me.b_delete.Location = New System.Drawing.Point(15, 154)
        Me.b_delete.Name = "b_delete"
        Me.b_delete.Size = New System.Drawing.Size(85, 32)
        Me.b_delete.TabIndex = 3
        Me.b_delete.Text = "حذف"
        Me.b_delete.UseVisualStyleBackColor = False
        '
        'b_change
        '
        Me.b_change.BackColor = System.Drawing.Color.AliceBlue
        Me.b_change.Location = New System.Drawing.Point(15, 91)
        Me.b_change.Name = "b_change"
        Me.b_change.Size = New System.Drawing.Size(85, 32)
        Me.b_change.TabIndex = 2
        Me.b_change.Text = "تعديل"
        Me.b_change.UseVisualStyleBackColor = False
        '
        'b_add
        '
        Me.b_add.BackColor = System.Drawing.Color.AliceBlue
        Me.b_add.Location = New System.Drawing.Point(15, 29)
        Me.b_add.Name = "b_add"
        Me.b_add.Size = New System.Drawing.Size(85, 32)
        Me.b_add.TabIndex = 1
        Me.b_add.Text = "اضافه"
        Me.b_add.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        't_search
        '
        Me.t_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_search.Location = New System.Drawing.Point(24, 12)
        Me.t_search.Multiline = True
        Me.t_search.Name = "t_search"
        Me.t_search.Size = New System.Drawing.Size(329, 31)
        Me.t_search.TabIndex = 18
        Me.t_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't_typeno
        '
        Me.t_typeno.Location = New System.Drawing.Point(222, 77)
        Me.t_typeno.Name = "t_typeno"
        Me.t_typeno.Size = New System.Drawing.Size(100, 20)
        Me.t_typeno.TabIndex = 20
        Me.t_typeno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        't_typename
        '
        Me.t_typename.Location = New System.Drawing.Point(222, 104)
        Me.t_typename.Name = "t_typename"
        Me.t_typename.Size = New System.Drawing.Size(100, 20)
        Me.t_typename.TabIndex = 21
        Me.t_typename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(329, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "الرقم"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(329, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "النوع"
        '
        'b_save
        '
        Me.b_save.BackColor = System.Drawing.Color.AliceBlue
        Me.b_save.Location = New System.Drawing.Point(254, 177)
        Me.b_save.Name = "b_save"
        Me.b_save.Size = New System.Drawing.Size(76, 32)
        Me.b_save.TabIndex = 24
        Me.b_save.Text = "حفظ"
        Me.b_save.UseVisualStyleBackColor = False
        '
        'b_cancel
        '
        Me.b_cancel.BackColor = System.Drawing.Color.AliceBlue
        Me.b_cancel.Location = New System.Drawing.Point(113, 177)
        Me.b_cancel.Name = "b_cancel"
        Me.b_cancel.Size = New System.Drawing.Size(76, 32)
        Me.b_cancel.TabIndex = 25
        Me.b_cancel.Text = "الغاء"
        Me.b_cancel.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Azure
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(186, 87)
        Me.DataGridView1.TabIndex = 26
        '
        'types
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 234)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.b_cancel)
        Me.Controls.Add(Me.b_save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.t_typename)
        Me.Controls.Add(Me.t_typeno)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.t_search)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "types"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "types"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents b_delete As System.Windows.Forms.Button
    Friend WithEvents b_change As System.Windows.Forms.Button
    Friend WithEvents b_add As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents t_search As System.Windows.Forms.TextBox
    Friend WithEvents t_typeno As System.Windows.Forms.TextBox
    Friend WithEvents t_typename As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents b_save As System.Windows.Forms.Button
    Friend WithEvents b_cancel As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
