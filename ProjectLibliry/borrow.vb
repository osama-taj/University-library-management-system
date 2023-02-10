Imports System.Data.SqlClient
Public Class borrow
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=projectlibrary;Integrated Security=True;Pooling=False")
    Dim da As New SqlDataAdapter
    Dim da2 As New SqlDataAdapter
    Dim ds As New DataSet
    Dim ds1 As New DataSet
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim b As New BindingSource
    Dim cmd As New SqlCommand

    Private Sub borrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            c_stu_name.Enabled = False
            c_book_name.Enabled = False
            t_start_date.Enabled = False
            t_back_date.Enabled = False
            t_end_date.Enabled = False
            l_note.Enabled = False
            b_ok.Enabled = False

            ' '''''''''''''''''''''''''''جلب اسامي الطلاب'''''''''''''''''''
            da.SelectCommand = New SqlCommand("select * from students", con)
            da.Fill(ds2, "students")
            c_stu_name.DataSource = ds2.Tables("students")
            c_stu_name.DisplayMember = "student_name"
            c_stu_name.ValueMember = "student_no"

            ''''''''''''''''''''''جلب اسامي الكتب''''''''''''''''''''''
            da.SelectCommand = New SqlCommand("select * from books", con)
            da.Fill(ds3, "books")
            c_book_name.DataSource = ds3.Tables("books")
            c_book_name.DisplayMember = "book_name"
            c_book_name.ValueMember = "book_no"

            '''''''''''''''''''''''''''''''''''''''''''
            'da.SelectCommand = New SqlCommand("select * from student_book", con)
            'da.Fill(ds1, "student_book")
            'b.DataSource = ds1.Tables("student_book")

            ''''''''''''''''''''''''''جالب الجدول الاساسي''''''''''''''''''''''''
            da.SelectCommand = New SqlCommand("SELECT dbo.student_book.*, dbo.students.student_name, dbo.books.book_name FROM dbo.books INNER JOIN dbo.student_book ON dbo.books.book_no = dbo.student_book.book_no INNER JOIN dbo.students ON dbo.student_book.student_no = dbo.students.student_no", con)
            da.Fill(ds, "student_book")
            b.DataSource = ds.Tables("student_book")
            DataGridView1.DataSource = b
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            c_stu_name.DataBindings.Add("text", b, "student_name")
            c_book_name.DataBindings.Add("text", b, "book_name")
            t_start_date.DataBindings.Add("text", b, "start_date")
            t_end_date.DataBindings.Add("text", b, "final_date")
            t_back_date.DataBindings.Add("text", b, "delivery_date")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub b_borrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_borrow.Click
        Try
            b.AddNew()
            t_start_date.Text = Today
            t_end_date.Text = Today.AddDays(7)
            t_state.Text = 0

            c_stu_name.Enabled = True
            c_book_name.Enabled = True
            l_note.Enabled = True
            b_ok.Enabled = True

            b_borrow.Enabled = False
            b_return.Enabled = False


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Private Sub b_return_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_return.Click
        c_stu_name.Enabled = True
        c_book_name.Enabled = True
        t_back_date.Text = Today.AddDays(20)
        b_ok.Enabled = True
        b_ok.Text = "تم."
        t_state.Text = 0

    End Sub



    Private Sub b_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ok.Click
        Try
            If b_ok.Text = "تم" Then
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd.CommandText = "select count(*) from student_book where student_no =@no and cheack_state=@st "
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@no", c_stu_name.SelectedValue)
                    .AddWithValue("@st", t_state.Text)
                End With
                cmd.Connection = con
                Dim no As Int16
                no = cmd.ExecuteScalar
                MsgBox(no)
                If (no >= 3) Then
                    'l_note.DisplayMember = "لا يمكنك استعاره كتاب . تجاوزت الحد لديك ثلاثه كتب"
                    MsgBox("لا يمكنك استعاره كتاب . تجاوزت الحد")
                    b.EndEdit()
                    b.RemoveCurrent()
                    c_stu_name.Enabled = False
                    c_book_name.Enabled = False
                    l_note.Enabled = False
                    b_ok.Enabled = False

                    b_borrow.Enabled = True
                    b_return.Enabled = True
                Else


                    b.EndEdit()
                    If ds.HasChanges(DataRowState.Added) Then
                        da.InsertCommand = New SqlCommand("insert into student_book values (@stu_no,@b_no,@s_date,@f_date,@d_date,@state)", con)
                        With da.InsertCommand.Parameters
                            .Clear()
                            .AddWithValue("@stu_no", c_stu_name.SelectedValue)
                            .AddWithValue("@b_no", c_book_name.SelectedValue)
                            .AddWithValue("@s_date", t_start_date.Text)
                            .AddWithValue("@f_date", t_end_date.Text)
                            .AddWithValue("@d_date", t_back_date.Text)
                            .AddWithValue("@state", t_state.Text)
                        End With
                        da.Update(ds.Tables("student_book"))
                        MsgBox("saved")
                    End If

                    ''''''''''تعديل جدول الكتب''''
                    'If con.State = ConnectionState.Open Then
                    '    con.Close()
                    'End If
                    'con.Open()
                    'cmd.CommandText = "select number_copies from books where book_no= " & c_book_name.SelectedValue
                    'cmd.Connection = con
                    'Dim b_no As Integer
                    'b_no = cmd.ExecuteScalar
                    'b_no = b_no - 1
                    ''''''
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    cmd = New SqlCommand("update books set number_copies=number_copies-1 where book_no=@no", con)
                    With cmd.Parameters
                        .Clear()
                        '    .AddWithValue("@b_no", b_no)
                        .AddWithValue("@no", c_book_name.SelectedValue)
                    End With
                    cmd.ExecuteNonQuery()
                    MsgBox("books updeted")
                    c_stu_name.Enabled = False
                    c_book_name.Enabled = False
                    l_note.Enabled = False
                    b_ok.Enabled = False

                    b_borrow.Enabled = True
                    b_return.Enabled = True
                End If
            End If
            '###################################################################################################''''''''''''''''''''''''''''''''''''''''''''''''''''
            If b_ok.Text = "تم." Then


                '''''''''''''''''''تعديل جدول الغرامات''''''''''''''''''''
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd.CommandText = "select final_date from student_book where student_no =@no and book_no=@bookno and cheack_state=@st "
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@no", c_stu_name.SelectedValue)
                    .AddWithValue("@bookno", c_book_name.SelectedValue)
                    .AddWithValue("@st", t_state.Text)
                End With
                cmd.Connection = con
                Dim fd As Date
                Dim td As Date
                Dim re As Long
                fd = cmd.ExecuteScalar
                td = Today.AddDays(10)
                re = DateDiff(DateInterval.Day, td, fd)
                If re >= 0 Then
                    MsgBox("لا توجد غرامه ")
                End If

                If re < 0 Then
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    cmd.CommandText = "select count(*) from notcommitted_student where student_no =@no "
                    With cmd.Parameters
                        .Clear()
                        .AddWithValue("@no", c_stu_name.SelectedValue)
                    End With
                    cmd.Connection = con
                    Dim no As Int16 = 0
                    no = cmd.ExecuteScalar
                    If no > 0 Then
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd = New SqlCommand("update notcommitted_student set monyshoudpay=monyshoudpay+1000,times=times+1 where student_no=@no", con)
                        With cmd.Parameters
                            .Clear()
                            .AddWithValue("@no", c_stu_name.SelectedValue)
                        End With
                        cmd.ExecuteNonQuery()
                        MsgBox("الغرامه سجلت")
                    Else
                        If con.State = ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.CommandText = "insert into notcommitted_student values( @no , @time , @money)"
                        With cmd.Parameters
                            .Clear()
                            .AddWithValue("@no", c_stu_name.SelectedValue)
                            .AddWithValue("@time", 1)
                            .AddWithValue("@money", 1000)
                        End With
                        cmd.Connection = con
                        cmd.ExecuteNonQuery()
                        MsgBox("اول غرامه لك سجلت")
                    End If

                End If

                ''''''''''تعديل جدول student book '''''''''''''''''''''''''''''
                t_state.Text = 1
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd = New SqlCommand("update student_book set cheack_state=@st,delivery_date=@date where book_no=@no and student_no=@stu_no", con)
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("@st", t_state.Text)
                    .AddWithValue("@date", t_back_date.Text)
                    .AddWithValue("@no", c_book_name.SelectedValue)
                    .AddWithValue("@stu_no", c_stu_name.SelectedValue)
                End With
                cmd.ExecuteNonQuery()
                MsgBox("تم ارجاع الكتاب")
                ''''''''''''''''''تعديل جدول books''''''''''''''''''''
                'If con.State = ConnectionState.Open Then
                '    con.Close()
                'End If
                'con.Open()
                'cmd.CommandText = "select number_copies from books where book_no= " & c_book_name.SelectedValue
                'cmd.Connection = con
                'Dim b_no As Integer
                'b_no = cmd.ExecuteScalar
                'b_no = b_no + 1

                ''''''
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd = New SqlCommand("update books set number_copies=number_copies+1 where book_no=@no", con)
                With cmd.Parameters
                    .Clear()
                    '.AddWithValue("@b_no", b_no)
                    .AddWithValue("@no", c_book_name.SelectedValue)
                End With
                cmd.ExecuteNonQuery()
                MsgBox("تم تعديل جدول الكتب")

                ''''''
                b_borrow.Enabled = True
                b_return.Enabled = True
                b_ok.Text = "تم"
                c_stu_name.Enabled = False
                c_book_name.Enabled = False



                ''''main if end
            End If
            '''''''''
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(c_book_name.SelectedValue)
    End Sub

    Private Sub l_note_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_note.SelectedIndexChanged

    End Sub
End Class