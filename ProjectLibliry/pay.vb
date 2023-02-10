Imports System.Data.SqlClient
Public Class pay
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=projectlibrary;Integrated Security=True;Pooling=False")
    Dim da As New SqlDataAdapter
    Dim da2 As New SqlDataAdapter
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim b As New BindingSource
    Dim cmd As New SqlCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_back.Click
        Me.Hide()
        violations.Show()
    End Sub

    Private Sub pay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c_stuName.Enabled = False
        t_amount.Enabled = False
        t_datePay.Enabled = False
        t_userName.Enabled = False
        b_save.Enabled = False

        Try
            ''''''''''''''''''''''''''''''''''''''''''''
            da.SelectCommand = New SqlCommand("SELECT dbo.students.student_name, dbo.notcommitted_student.student_no FROM dbo.notcommitted_student INNER JOIN dbo.students ON dbo.notcommitted_student.student_no = dbo.students.student_no", con)
            da.Fill(ds2, "students")
            c_stuName.DataSource = ds2.Tables("students")
            c_stuName.DisplayMember = "student_name"
            c_stuName.ValueMember = "student_no"
            '''''''''''''''''''''''''''''''''''
            da.SelectCommand = New SqlCommand("SELECT students.student_name, payment.money_payed, payment.date FROM payment INNER JOIN students ON payment.student_no = students.student_no", con)
            da.Fill(ds, "payment")
            b.DataSource = ds.Tables("payment")
            DataGridView1.DataSource = b
            DataGridView1.Columns(0).HeaderText = "اسم الطالب"
            DataGridView1.Columns(1).HeaderText = "المبلغ"
            DataGridView1.Columns(2).HeaderText = "التاريخ"
            DataGridView1.Columns(0).Width = 200
            DataGridView1.Columns(1).Width = 100
            DataGridView1.Columns(2).Width = 100
            c_stuName.DataBindings.Add("text", b, "student_name")
            t_amount.DataBindings.Add("text", b, "money_payed")
            t_datePay.DataBindings.Add("text", b, "date")
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'da2.SelectCommand = New SqlCommand("select * from notcommitted_student ", con)
            'da2.Fill(ds3, "notcommitted_student")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        b.AddNew()
        t_datePay.Text = Today
        c_stuName.Enabled = True
        t_amount.Enabled = True
        t_datePay.Enabled = True
        't_userName.Enabled = True
        b_save.Enabled = True
        t_userName.Text = user_name
    End Sub

    Private Sub b_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_save.Click
        Try
            ''''''''''''''''''''''''''''''''''''''''''''''
            b.EndEdit()
            If ds.HasChanges(DataRowState.Added) Then
                da.InsertCommand = New SqlCommand("insert into payment values (@no,@mo,@da,@u_no)", con)
                With da.InsertCommand.Parameters
                    .Clear()
                    .AddWithValue("@no", c_stuName.SelectedValue)
                    .AddWithValue("@da", t_datePay.Text)
                    .AddWithValue("@mo", t_amount.Text)
                    .AddWithValue("@u_no", auto_no)

                End With
                da.Update(ds.Tables("payment"))
                MsgBox("saved")
                Me.Refresh()
            End If
            ''''''''''''''''''''''''''''''''''''''''''
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim m As Int16
            cmd.CommandText = "select monyshoudpay from notcommitted_student where student_no= " & c_stuName.SelectedValue
            cmd.Connection = con
            m = cmd.ExecuteScalar
            con.Close()
            MsgBox(m)
            m = m - t_amount.Text
            MsgBox("m after " & m)


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'da2.SelectCommand = New SqlCommand("select * from notcommitted_student where student_no=" & c_stuName.SelectedValue, con)
            'da2.Fill(ds3, "notcommitted_student")
            'If ds3.HasChanges(DataRowState.Modified) Then


            '    da2.UpdateCommand = New SqlCommand("update notcommitted_student set monyshoudpay=@m where  student_no=@no ", con)
            '    With da2.UpdateCommand.Parameters
            '        .Clear()
            '        .AddWithValue("@m", m)
            '        .AddWithValue("@no", c_stuName.SelectedValue)
            '    End With
            '    da2.Update(ds3.Tables("notcommitted_student"))
            '    MsgBox("notcommitted_student updated")
            '    Me.Refresh()
            '    violations.Refresh()
            'End If
            ''''''''''''''''''''''''''''''''''''
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New SqlCommand("update notcommitted_student set  monyshoudpay=@m where  student_no=@no ", con)
            With cmd.Parameters
                .AddWithValue("@m", m)
                .AddWithValue("@no", c_stuName.SelectedValue)
            End With
            cmd.ExecuteNonQuery()
            MsgBox("notcommitted_student updeted")
            ''''''''''''''''''''''''''''''''''''''''''''''''''''
            c_stuName.Enabled = False
            t_amount.Enabled = False
            t_datePay.Enabled = False
            t_userName.Enabled = False
            b_save.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class