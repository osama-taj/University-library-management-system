Imports System.Data.SqlClient

Public Class users

    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=projectlibrary;Integrated Security=True;Pooling=False")
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim b As New BindingSource
    'Private Sub enbld()
    '    t_search.Enabled = True
    '    t_userNO.Enabled = False
    '    t_userName.Enabled = False
    '    t_userPhone.Enabled = False
    '    t_dateREG.Enabled = False
    '    t_userNN.Enabled = False
    '    t_userPass.Enabled = False
    '    b_save.Enabled = False
    '    b_cansel.Enabled = False
    '    b_add.Enabled = True
    '    b_delete.Enabled = True
    '    b_delete.Enabled = True
    '    b_save.Text = "حفظ"
    '    For Each c As Control In Controls
    '        If TypeOf c Is TextBox Then
    '            c.Text = ""
    '        End If
    '    Next
    'End Sub
    'Private Sub unenbld()
    '    t_search.Enabled = False
    '    t_userNO.Enabled = True
    '    t_userName.Enabled = True
    '    t_userPhone.Enabled = True
    '    t_dateREG.Enabled = True
    '    t_userNN.Enabled = True
    '    t_userPass.Enabled = True
    '    b_save.Enabled = True
    '    b_cansel.Enabled = True
    '    b_add.Enabled = False
    '    b_delete.Enabled = False
    '    b_delete.Enabled = False
    'End Sub



    Private Sub users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        t_search.Enabled = True
        t_userNO.Enabled = False
        t_userName.Enabled = False
        t_userPhone.Enabled = False
        t_dateREG.Enabled = False
        t_userNN.Enabled = False
        t_userPass.Enabled = False
        b_save.Enabled = False
        b_cansel.Enabled = False
        b_add.Enabled = True
        b_delete.Enabled = True
        b_delete.Enabled = True

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        da.SelectCommand = New SqlCommand("select * from users", con)
        da.Fill(ds, "users")
        b.DataSource = ds.Tables("users")
        DataGridView1.DataSource = b
        DataGridView1.Columns(1).HeaderText = "اسم المستخدم"
        DataGridView1.Columns(1).Width = 135
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        t_userNO.DataBindings.Add("text", b, "user_no")
        t_userName.DataBindings.Add("text", b, "user_name")
        t_userPhone.DataBindings.Add("text", b, "phone_no")
        t_dateREG.DataBindings.Add("text", b, "dateREG")
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub


    Private Sub b_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_add.Click

        b.RemoveFilter()
        b.AddNew()
        If b.Count = 1 Then
            t_userNO.Text = 1
        Else
            t_userNO.Text = ds.Tables("users").Rows(b.Count - 2).Item(0) + 1
        End If
        t_dateREG.Text = Today
        t_userName.Focus()
        '''''''''''''''''''''' 
        t_search.Enabled = False
        t_userName.Enabled = True
        t_userPhone.Enabled = True
        t_dateREG.Enabled = True
        t_userNN.Enabled = True
        t_userPass.Enabled = True
        b_save.Enabled = True
        b_cansel.Enabled = True
        b_add.Enabled = False
        b_delete.Enabled = False
        b_delete.Enabled = False

    End Sub

    Private Sub b_cansel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_cansel.Click
        If b_save.Text = "حفظ" Then
            b.RemoveCurrent()
        End If

        If b_save.Text = "تعديل" Then
            b_save.Text = "حفظ"
            b.RemoveFilter()
            b.CancelEdit()
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''
        t_search.Enabled = True
        t_userNO.Enabled = False
        t_userName.Enabled = False
        t_userPhone.Enabled = False
        t_dateREG.Enabled = False
        t_userNN.Enabled = False
        t_userPass.Enabled = False
        b_save.Enabled = False
        b_cansel.Enabled = False
        b_add.Enabled = True
        b_delete.Enabled = True
        b_delete.Enabled = True

    End Sub

    Private Sub b_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_save.Click
        If b_save.Text = "تعديل" Then
            b.EndEdit()
            'If ds.HasChanges(DataRowState.Modified) Then
            da.UpdateCommand = New SqlCommand("update users set user_no=@no,user_name=@name,phone_no=@phone,dateREG=@data where user_no=@no", con)
            With da.UpdateCommand.Parameters
                .Clear()
                .AddWithValue("@no", t_userNO.Text)
                .AddWithValue("@name", t_userName.Text)
                .AddWithValue("@phone", t_userPhone.Text)
                '.AddWithValue("@uname", t_userNN.Text)
                '.AddWithValue("@upass", t_userPass.Text)
                .AddWithValue("@data", t_dateREG.Text)
            End With

            da.Update(ds.Tables("users"))
            MsgBox("updated")
            b_save.Text = "حفظ"
            t_search.Enabled = True
            t_userNO.Enabled = False
            t_userName.Enabled = False
            t_userPhone.Enabled = False
            t_dateREG.Enabled = False
            t_userNN.Enabled = False
            t_userPass.Enabled = False
            b_save.Enabled = False
            b_cansel.Enabled = False
            b_add.Enabled = True
            b_delete.Enabled = True
            b_delete.Enabled = True
            'Call enbld()
            ' End If
        End If
        '####################################################################'
        If b_save.Text = "حفظ" Then
            b.EndEdit()
            'b.RemoveFilter()'''!!!!!!
            'b.MoveLast()
            If ds.HasChanges(DataRowState.Added) Then
                da.InsertCommand = New SqlCommand("insert into users values(@no,@name,@phone,@uname,@upass,@data)", con)
                With da.InsertCommand.Parameters
                    .Clear()
                    .AddWithValue("@no", t_userNO.Text)
                    .AddWithValue("@name", t_userName.Text)
                    .AddWithValue("@phone", t_userPhone.Text)
                    .AddWithValue("@uname", t_userNN.Text)
                    .AddWithValue("@upass", t_userPass.Text)
                    .AddWithValue("@data", t_dateREG.Text)
                End With
                da.Update(ds.Tables("users"))
                MsgBox("saved")
                ' b.RemoveFilter()!!!!!!!!!
                'Call enbld()
                Me.Refresh()
                t_userNN.Text = " "
                t_userPass.Text = " "
                t_search.Enabled = True
                t_userNO.Enabled = False
                t_userName.Enabled = False
                t_userPhone.Enabled = False
                t_dateREG.Enabled = False
                t_userNN.Enabled = False
                t_userPass.Enabled = False
                b_save.Enabled = False
                b_cansel.Enabled = False
                b_add.Enabled = True
                b_delete.Enabled = True
                b_delete.Enabled = True
            End If
        End If

    End Sub

    Private Sub t_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_search.TextChanged
        b.Filter = "user_name like '" & (t_search.Text) & "%' "
    End Sub

    Private Sub b_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_delete.Click
        b.EndEdit()
        Dim no As Integer = t_userNO.Text
        b.RemoveCurrent()
        If ds.HasChanges(DataRowState.Deleted) Then
            da.DeleteCommand = New SqlCommand("delete from users where user_no=" & no, con)
            da.Update(ds.Tables("users"))
            MsgBox("deleted")
        End If
    End Sub

    Private Sub b_change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_change.Click
        ' Call unenbld()
        b_save.Text = "تعديل"
        t_search.Enabled = False
        t_userName.Enabled = True
        t_userPhone.Enabled = True
        t_dateREG.Enabled = True
        t_userNN.Enabled = True
        t_userPass.Enabled = True
        b_save.Enabled = True
        b_cansel.Enabled = True
        b_add.Enabled = False
        b_delete.Enabled = False
        b_delete.Enabled = False

    End Sub
End Class