Imports System.Data.SqlClient
Public Class authors
    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=projectlibrary;Integrated Security=True;Pooling=False")
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Dim dt2 As New DataTable
    Dim b As New BindingSource

    'Private Sub enbld()
    '    b_add.Enabled = True
    '    b_change.Enabled = True
    '    b_delete.Enabled = True
    '    t_search.Enabled = True
    '    t_authorNO.Enabled = False
    '    t_autherName.Enabled = False
    '    t_authorcity.Enabled = False
    '    b_cansel.Enabled = False
    '    b_save.Enabled = False
    '    For Each c As Control In Controls
    '        If TypeOf c Is TextBox Then c.Text = ""
    '    Next
    'End Sub
    'Private Sub unenbld()
    '    b_add.Enabled = False
    '    b_change.Enabled = False
    '    b_delete.Enabled = False
    '    t_search.Enabled = True
    '    t_authorNO.Enabled = True
    '    t_autherName.Enabled = True
    '    t_authorcity.Enabled = True
    '    b_cansel.Enabled = True
    '    b_save.Enabled = True
    '    For Each c As Control In Controls
    '        If TypeOf c Is TextBox Then c.Text = ""
    '    Next
    'End Sub
    Private Sub authors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        b_add.Enabled = True
        b_change.Enabled = True
        b_delete.Enabled = True
        t_search.Enabled = True
        t_authorNO.Enabled = False
        t_autherName.Enabled = False
        t_authorcity.Enabled = False
        b_cansel.Enabled = False
        b_save.Enabled = False
        da.SelectCommand = New SqlCommand("select * from authors", con)
        da.Fill(ds, "authors")
        b.DataSource = ds.Tables("authors")
        DataGridView1.DataSource = b
        DataGridView1.Columns(1).HeaderText = "الاسم"
        DataGridView1.Columns(1).Width = 93
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(2).Visible = False
        t_authorNO.DataBindings.Add("text", b, "author_no")
        t_autherName.DataBindings.Add("text", b, "author_name")
        t_authorcity.DataBindings.Add("text", b, "author_city")

    End Sub

   
    Private Sub b_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_add.Click
        Try
            b_add.Enabled = False
            b_change.Enabled = False
            b_delete.Enabled = False
            t_search.Enabled = True
            t_authorNO.Enabled = True
            t_autherName.Enabled = True
            t_authorcity.Enabled = True
            b_cansel.Enabled = True
            b_save.Enabled = True
            t_autherName.Focus()
            b.RemoveFilter()
            b.AddNew()
            If b.Count = 1 Then
                t_authorNO.Text = 1
            Else
                t_authorNO.Text = ds.Tables("authors").Rows(b.Count - 2).Item(0) + 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

  
    Private Sub b_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_save.Click
        Try
            If b_save.Text = "حفظ" Then
                b.EndEdit()
                If ds.HasChanges(DataRowState.Added) Then
                    da.InsertCommand = New SqlCommand("insert into authors values (@no,@name,@city)", con)
                    With da.InsertCommand.Parameters
                        .Clear()
                        .AddWithValue("@no", t_authorNO.Text)
                        .AddWithValue("@name", t_autherName.Text)
                        .AddWithValue("@city", t_authorcity.Text)
                    End With
                    da.Update(ds.Tables("authors"))
                    MsgBox("saved")
                    Me.Refresh()
                    b_add.Enabled = True
                    b_change.Enabled = True
                    b_delete.Enabled = True
                    t_search.Enabled = True
                    t_authorNO.Enabled = False
                    t_autherName.Enabled = False
                    t_authorcity.Enabled = False
                    b_cansel.Enabled = False
                    b_save.Enabled = False

                End If

            End If

            If b_save.Text = "تعديل" Then
                b.EndEdit()
                If ds.HasChanges(DataRowState.Modified) Then
                    da.UpdateCommand = New SqlCommand("update authors set author_name=@name ,author_city=@city where  author_no=@no ", con)
                    With da.UpdateCommand.Parameters
                        .Clear()
                        .AddWithValue("@no", t_authorNO.Text)
                        .AddWithValue("@city", t_authorcity.Text)
                        .AddWithValue("@name", t_autherName.Text)
                    End With
                    da.Update(ds.Tables("authors"))
                    MsgBox("updated")
                    b_add.Enabled = True
                    b_change.Enabled = True
                    b_delete.Enabled = True
                    t_search.Enabled = True
                    t_authorNO.Enabled = False
                    t_autherName.Enabled = False
                    t_authorcity.Enabled = False
                    b_cansel.Enabled = False
                    b_save.Enabled = False
                    b_save.Text = "حفظ"
                    Me.Refresh()

                End If
            End If
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
                b_add.Enabled = True
                b_change.Enabled = True
                b_delete.Enabled = True
                t_search.Enabled = True
                t_authorNO.Enabled = False
                t_autherName.Enabled = False
                t_authorcity.Enabled = False
                b_cansel.Enabled = False
                b_save.Enabled = False

            End If
            If b_save.Text = "حفظ" Then
                b.RemoveCurrent()
                b_add.Enabled = True
                b_change.Enabled = True
                b_delete.Enabled = True
                t_search.Enabled = True
                t_authorNO.Enabled = False
                t_autherName.Enabled = False
                t_authorcity.Enabled = False
                b_cansel.Enabled = False
                b_save.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

  
    Private Sub b_change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_change.Click
        b_save.Text = "تعديل"
        b_add.Enabled = False
        b_change.Enabled = False
        b_delete.Enabled = False
        t_search.Enabled = True
        t_authorNO.Enabled = True
        t_autherName.Enabled = True
        t_authorcity.Enabled = True
        b_cansel.Enabled = True
        b_save.Enabled = True
    End Sub

    Private Sub b_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_delete.Click
        Try
            b.EndEdit()
            Dim no As Integer = t_authorNO.Text
            b.RemoveCurrent()
            If ds.HasChanges(DataRowState.Deleted) Then
                da.DeleteCommand = New SqlCommand("delete from authors where author_no=" & no, con)
                da.Update(ds.Tables("authors"))
                MsgBox("deleted")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub t_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_search.TextChanged
        b.Filter = "author_name like '" & (t_search.Text) & "%' "
    End Sub


End Class