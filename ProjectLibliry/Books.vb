Imports System.Data.SqlClient
Public Class Books
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=projectlibrary;Integrated Security=True;Pooling=False")
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim b As New BindingSource


    Private Sub Books_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            t_bookNO.Enabled = False
            t_bookName.Enabled = False
            c_authorName.Enabled = False
            c_type.Enabled = False
            t_copyNO.Enabled = False
            t_pop.Enabled = False
            b_save.Enabled = False
            b_cansel.Enabled = False
            ''''''''''''''''''''''''''''''''''''''''''''''''''''
            da.SelectCommand = New SqlCommand("select * from authors", con)
            da.Fill(ds2, "authors")
            c_authorName.DataSource = ds2.Tables("authors")
            c_authorName.DisplayMember = "author_name"
            c_authorName.ValueMember = "author_no"
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            da.SelectCommand = New SqlCommand("select * from types", con)
            da.Fill(ds3, "types")
            c_type.DataSource = ds3.Tables("types")
            c_type.DisplayMember = "type_name"
            c_type.ValueMember = "type_no"
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            da.SelectCommand = New SqlCommand("SELECT dbo.books.*, dbo.types.type_name, dbo.authors.author_name FROM dbo.authors INNER JOIN dbo.books ON dbo.authors.author_no = dbo.books.author_no INNER JOIN dbo.types ON dbo.books.book_type_no = dbo.types.type_no", con)
            da.Fill(ds, "books")
            b.DataSource = ds.Tables("books")
            DataGridView1.DataSource = b
            ' DataGridView1.Columns(1).HeaderText = "اسم الكتاب"
            DataGridView1.Columns(1).Width = 93
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            t_bookNO.DataBindings.Add("text", b, "book_no")
            t_bookName.DataBindings.Add("text", b, "book_name")
            c_type.DataBindings.Add("text", b, "type_name")
            c_authorName.DataBindings.Add("text", b, "author_name")
            t_pop.DataBindings.Add("text", b, "date_publiction")
            t_copyNO.DataBindings.Add("text", b, "copies")

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub B_b_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_add.Click
        Try
            t_bookNO.Enabled = True
            t_bookName.Enabled = True
            c_authorName.Enabled = True
            c_type.Enabled = True
            t_copyNO.Enabled = True
            t_pop.Enabled = True
            b_save.Enabled = True
            b_cansel.Enabled = True
            ''''''''''''''''''''''''''''''''''
            b.RemoveFilter()
            b.AddNew()
            If b.Count = 1 Then
                t_bookNO.Text = 1
            Else
                t_bookNO.Text = ds.Tables("books").Rows(b.Count - 2).Item(0) + 1
            End If
            t_bookName.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub B_b_change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_change.Click
        t_bookNO.Enabled = False
        t_bookName.Enabled = True
        c_authorName.Enabled = True
        c_type.Enabled = True
        t_copyNO.Enabled = True
        t_pop.Enabled = True
        b_save.Enabled = True
        b_cansel.Enabled = True
        b_save.Text = "تعديل"

    End Sub

    Private Sub B_b_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_delete.Click
        Try
            b.EndEdit()
            Dim no As Integer = t_bookNO.Text
            b.RemoveCurrent()
            If ds.HasChanges(DataRowState.Deleted) Then
                da.DeleteCommand = New SqlCommand("delete from books where book_no=" & no, con)
                da.Update(ds.Tables("books"))
                MsgBox("deleted")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub b_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_save.Click
        Try
            If b_save.Text = "حفظ" Then
                ' MsgBox("1")
                b.EndEdit()
                If ds.HasChanges(DataRowState.Added) Then
                    da.InsertCommand = New SqlCommand("insert into books values (@no,@name,@type,@author,@pop,@copy,@copy)", con)
                    With da.InsertCommand.Parameters
                        .Clear()
                        .AddWithValue("@no", t_bookNO.Text)
                        .AddWithValue("@name", t_bookName.Text)
                        .AddWithValue("@type", c_type.SelectedValue)
                        .AddWithValue("@author", c_authorName.SelectedValue)
                        .AddWithValue("@copy", t_copyNO.Text)
                        .AddWithValue("@pop", t_pop.Text)

                    End With
                    ' MsgBox("2")
                    da.Update(ds.Tables("books"))
                    MsgBox("saved")
                    Me.Refresh()
                    t_bookNO.Enabled = False
                    t_bookName.Enabled = False
                    c_authorName.Enabled = False
                    c_type.Enabled = False
                    t_copyNO.Enabled = False
                    t_pop.Enabled = False
                    b_save.Enabled = False
                    b_cansel.Enabled = False
                End If
            End If
            '''''''''''''########################################################''''''''''''''''''''''''''''''''''''''
            If b_save.Text = "تعديل" Then
                b.EndEdit()
                If empty.Checked = True Then


                    ' If ds.HasChanges(DataRowState.Modified) Then
                    da.UpdateCommand = New SqlCommand("update books set book_name=@name ,book_type_no=@type,author_no=@author,date_publiction=@pop where  book_no=@no ", con)
                    With da.UpdateCommand.Parameters
                        .Clear()
                        .AddWithValue("@no", t_bookNO.Text)
                        .AddWithValue("@name", t_bookName.Text)
                        .AddWithValue("@type", c_type.SelectedValue)
                        .AddWithValue("@author", c_authorName.SelectedValue)
                        '  .AddWithValue("@copy", t_copyNO.Text)
                        .AddWithValue("@pop", t_pop.Text)
                    End With
                    da.Update(ds.Tables("books"))
                    MsgBox("updated")

                    '''''''''''
                ElseIf plus.Checked = True Then
                    da.UpdateCommand = New SqlCommand("update books set book_name=@name ,book_type_no=@type,author_no=@author,date_publiction=@pop, copies=copies+@copy,number_copies=number_copies+@copy where  book_no=@no ", con)
                    With da.UpdateCommand.Parameters
                        .Clear()
                        .AddWithValue("@no", t_bookNO.Text)
                        .AddWithValue("@name", t_bookName.Text)
                        .AddWithValue("@type", c_type.SelectedValue)
                        .AddWithValue("@author", c_authorName.SelectedValue)
                        .AddWithValue("@copy", t_copyNO.Text)
                        .AddWithValue("@pop", t_pop.Text)
                    End With
                    da.Update(ds.Tables("books"))
                    MsgBox("تمت الزياده")

                    'da.UpdateCommand = New SqlCommand("update books set copies=copies+@copy,number_copies=number_copies+@copy  where  book_no=@no ", con)
                    'With da.UpdateCommand.Parameters
                    '    .Clear()
                    '    .AddWithValue("@no", t_bookNO.Text)
                    '    .AddWithValue("@copy", t_copyNO.Text)
                    'End With
                    'da.Update(ds.Tables("books"))
                    'MsgBox("تمت الزياده")

                ElseIf minus.Checked = True Then
                    da.UpdateCommand = New SqlCommand("update books set book_name=@name ,book_type_no=@type,author_no=@author,date_publiction=@pop, copies=copies-@copy,number_copies=number_copies-@copy where  book_no=@no ", con)
                    With da.UpdateCommand.Parameters
                        .Clear()
                        .AddWithValue("@no", t_bookNO.Text)
                        .AddWithValue("@name", t_bookName.Text)
                        .AddWithValue("@type", c_type.SelectedValue)
                        .AddWithValue("@author", c_authorName.SelectedValue)
                        .AddWithValue("@copy", t_copyNO.Text)
                        .AddWithValue("@pop", t_pop.Text)
                    End With
                    da.Update(ds.Tables("books"))
                    MsgBox("تم التقليل")
                    'da.UpdateCommand = New SqlCommand("update books set copies=copies-@copy,number_copies=number_copies-@copy  where  book_no=@no ", con)
                    'With da.UpdateCommand.Parameters
                    '    .Clear()
                    '    .AddWithValue("@no", t_bookNO.Text)
                    '    .AddWithValue("@copy", t_copyNO.Text)
                    'End With
                    'da.Update(ds.Tables("books"))
                    'MsgBox("تم التقليل")



                End If
                '''''''''''''''''''

                b_save.Text = "حفظ"
                Me.Refresh()
                t_bookNO.Enabled = False
                t_bookName.Enabled = False
                c_authorName.Enabled = False
                c_type.Enabled = False
                t_copyNO.Enabled = False
                t_pop.Enabled = False
                b_save.Enabled = False
                b_cansel.Enabled = False

                'End If

            End If
            ' End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub b_cansel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_cansel.Click
        Try
            If b_save.Text = "تعديل" Then
                b_save.Text = "حفظ"
                b.RemoveFilter()
                b.CancelEdit()
                t_bookNO.Enabled = False
                t_bookName.Enabled = False
                c_authorName.Enabled = False
                c_type.Enabled = False
                t_copyNO.Enabled = False
                t_pop.Enabled = False
                b_save.Enabled = False
                b_cansel.Enabled = False
            End If
            If b_save.Text = "حفظ" Then
                b.RemoveCurrent()
                t_bookNO.Enabled = False
                t_bookName.Enabled = False
                c_authorName.Enabled = False
                c_type.Enabled = False
                t_copyNO.Enabled = False
                t_pop.Enabled = False
                b_save.Enabled = False
                b_cansel.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub t_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_search.TextChanged
        b.Filter = "book_name like '" & (t_search.Text) & "%' "
    End Sub

End Class