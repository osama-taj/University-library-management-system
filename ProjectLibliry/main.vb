Imports System.Data.SqlClient

Public Class main
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=projectlibrary;Integrated Security=True;Pooling=False")
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim b As New BindingSource

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_returnandborrow.Click
        borrow.Show()
    End Sub

    Private Sub b_books_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_books.Click
        Books.Show()
    End Sub


    Private Sub b_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_record.Click
        records.Show()
    End Sub

    Private Sub b_aurther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_aurther.Click
        authors.Show()
    End Sub

    Private Sub b_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_user.Click
        users.Show()
    End Sub

    Private Sub b_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_pay.Click
        violations.Show()
    End Sub

    Private Sub type_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles type.Click
        types.Show()
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'DataGridView1.Refresh()
            'DataGridView1.DataSource = Nothing
            'DataGridView1.DataSource = ""
            'DataGridView1.ClearSelection()

            ' l_userName.Text = user_name


            ds.Clear()

            da.SelectCommand = New SqlCommand("SELECT dbo.books.book_no, dbo.books.book_name, dbo.types.type_name, dbo.authors.author_name, dbo.books.date_publiction, dbo.books.number_copies FROM dbo.books INNER JOIN dbo.authors ON dbo.books.author_no = dbo.authors.author_no INNER JOIN dbo.types ON dbo.books.book_type_no = dbo.types.type_no", con)
            da.Fill(ds, "books")
            b.DataSource = ds.Tables("books")
            DataGridView1.DataSource = b
            DataGridView1.Columns(0).HeaderText = "رقم الكتاب"
            DataGridView1.Columns(1).HeaderText = "اسم الكتاب"
            DataGridView1.Columns(2).HeaderText = "نوع الكاب"
            DataGridView1.Columns(3).HeaderText = "اسم المؤلف"
            DataGridView1.Columns(4).HeaderText = "تاريخ النشر"
            DataGridView1.Columns(5).HeaderText = "النسخ المتبقيه"
            DataGridView1.Columns(0).Width = 80
            DataGridView1.Columns(1).Width = 100
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 170
            DataGridView1.Columns(4).Width = 100
            DataGridView1.Columns(5).Width = 100


            l_userName.Text = user_name
            'DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub t_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_search.TextChanged
        Try

        
        If (rb_searchBook.Checked = True) Then
            If (t_search.Text <> "") Then
                b.Filter = "book_name like '" & (t_search.Text) & "%' "
            Else
                b.RemoveFilter()
            End If
        Else
            If (rb_searchAuthor.Checked = True) Then
                b.Filter = "author_name like '" & (t_search.Text) & "%' "
            End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    'Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try


    '        If (TextBox1.Text <> "") Then
    '            b.Filter = "book_name like '" & (TextBox1.Text) & "%' "
    '        Else
    '            b.RemoveFilter()
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)

    '    End Try
    'End Sub

    Private Sub b_returnandborrow_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_returnandborrow.MouseEnter
        b_returnandborrow.BackColor = Color.PowderBlue
        pb3.BackColor = Color.PowderBlue
        b_returnandborrow.ForeColor = Color.Black
    End Sub

    Private Sub b_returnandborrow_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_returnandborrow.MouseLeave
        b_returnandborrow.BackColor = Color.AliceBlue
        pb3.BackColor = Color.AliceBlue
        b_returnandborrow.ForeColor = Color.LightSeaGreen
    End Sub


    Private Sub b_record_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_record.MouseEnter
        b_record.BackColor = Color.PowderBlue
        pb4.BackColor = Color.PowderBlue
        b_record.ForeColor = Color.Black
    End Sub

    Private Sub b_record_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_record.MouseLeave
        b_record.BackColor = Color.AliceBlue
        pb4.BackColor = Color.AliceBlue
        b_record.ForeColor = Color.LightSeaGreen
    End Sub

    Private Sub b_books_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_books.MouseEnter
        b_books.BackColor = Color.PowderBlue
        pb5.BackColor = Color.PowderBlue
        b_books.ForeColor = Color.Black
    End Sub

    Private Sub b_books_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_books.MouseLeave
        b_books.BackColor = Color.AliceBlue
        pb5.BackColor = Color.AliceBlue
        b_books.ForeColor = Color.LightSeaGreen
    End Sub

    Private Sub b_aurther_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_aurther.MouseEnter
        b_aurther.BackColor = Color.PowderBlue
        pb7.BackColor = Color.PowderBlue
        b_aurther.ForeColor = Color.Black
    End Sub

    Private Sub b_aurther_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_aurther.MouseLeave
        b_aurther.BackColor = Color.AliceBlue
        pb7.BackColor = Color.AliceBlue
        b_aurther.ForeColor = Color.LightSeaGreen
    End Sub


    Private Sub b_student_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_student.MouseEnter
        b_student.BackColor = Color.PowderBlue
        pb8.BackColor = Color.PowderBlue
        b_student.ForeColor = Color.Black
    End Sub

    Private Sub b_student_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_student.MouseLeave
        b_student.BackColor = Color.AliceBlue
        pb8.BackColor = Color.AliceBlue
        b_student.ForeColor = Color.LightSeaGreen
    End Sub

    Private Sub types_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles type.MouseEnter
        type.BackColor = Color.PowderBlue
        type.ForeColor = Color.Black
    End Sub

    Private Sub types_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles type.MouseLeave
        type.BackColor = Color.AliceBlue
        type.ForeColor = Color.LightSeaGreen
    End Sub

    Private Sub b_user_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_user.MouseEnter
        b_user.BackColor = Color.PowderBlue
        pb6.BackColor = Color.PowderBlue
        b_user.ForeColor = Color.Black
    End Sub

    Private Sub b_user_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_user.MouseLeave
        b_user.BackColor = Color.AliceBlue
        pb6.BackColor = Color.AliceBlue
        b_user.ForeColor = Color.LightSeaGreen
    End Sub

    Private Sub b_pay_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_pay.MouseEnter
        b_pay.BackColor = Color.PowderBlue
        b_pay.ForeColor = Color.Black
    End Sub

    Private Sub b_pay_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_pay.MouseLeave
        b_pay.BackColor = Color.AliceBlue
        b_pay.ForeColor = Color.LightSeaGreen
    End Sub

    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click, Refresh.Click
        'Me.Refresh()
        'Me.Hide()
        'Me.Show()
        Call main_Load(sender, e)


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rb_searchAuthor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_searchAuthor.CheckedChanged

    End Sub
End Class