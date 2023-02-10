Imports System.Data.SqlClient
Public Class violations
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=projectlibrary;Integrated Security=True;Pooling=False")
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim b As New BindingSource
    Private Sub b_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_pay.Click
        pay.Show()
        Me.Hide()
    End Sub

    Private Sub violations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds.Clear()

        da.SelectCommand = New SqlCommand("SELECT dbo.students.student_name, dbo.notcommitted_student.times, dbo.notcommitted_student.monyshoudpay FROM dbo.notcommitted_student INNER JOIN dbo.students ON dbo.notcommitted_student.student_no = dbo.students.student_no", con)
        da.Fill(ds, "notcommitted_student")
        b.DataSource = ds.Tables("notcommitted_student")
        DataGridView1.DataSource = b
        DataGridView1.Columns(0).HeaderText = "اسم الطالب"
        DataGridView1.Columns(1).HeaderText = "عدد المخالفات"
        DataGridView1.Columns(2).HeaderText = "المبلغ"
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
    End Sub

    Private Sub t_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_search.TextChanged
        b.Filter = "student_name like '" & (t_search.Text) & "%' "
    End Sub

    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click
        Call violations_Load(sender, e)

    End Sub
End Class