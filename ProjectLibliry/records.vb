Imports System.Data.SqlClient
Public Class records
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=projectlibrary;Integrated Security=True;Pooling=False")
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim b As New BindingSource
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_back.Click
        Me.Hide()
        main.Show()
    End Sub

    Private Sub records_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand = New SqlCommand("SELECT dbo.students.student_name, dbo.books.book_name, dbo.student_book.start_date, dbo.student_book.final_date, dbo.student_book.delivery_date FROM dbo.books INNER JOIN dbo.student_book ON dbo.books.book_no = dbo.student_book.book_no INNER JOIN dbo.students ON dbo.student_book.student_no = dbo.students.student_no", con)
        da.Fill(ds, "student_book")
        b.DataSource = ds.Tables("student_book")
        DataGridView1.DataSource = b
    End Sub

    Private Sub t_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_search.TextChanged
        If (t_search.Text <> "") Then
            b.Filter = "student_name like '" & (t_search.Text) & "%' "
        Else
            b.RemoveFilter()
        End If
    End Sub
End Class