Imports System.Data.SqlClient

Public Class types

    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=projectlibrary;Integrated Security=True;Pooling=False")
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim b As New BindingSource
    Dim cmd As New SqlCommandBuilder

    Private Sub enbld()
        t_typeno.Enabled = False
        t_typename.Enabled = False
        b_save.Enabled = False
        b_cancel.Enabled = False
        b_add.Enabled = True
        b_change.Enabled = True
        b_delete.Enabled = True

    End Sub
    Private Sub unenbld()
        t_typeno.Enabled = True
        t_typename.Enabled = True
        b_save.Enabled = True
        b_cancel.Enabled = True
        b_add.Enabled = False
        b_change.Enabled = False
        b_delete.Enabled = False
    End Sub

    Private Sub types_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call enbld()
            da.SelectCommand = New SqlCommand("select * from types", con)
            da.Fill(ds, "types")
            b.DataSource = ds.Tables("types")
            DataGridView1.DataSource = b
            DataGridView1.Columns(1).HeaderText = "النوع"
            DataGridView1.Columns(1).Width = 125
            DataGridView1.Columns(0).Visible = False
            t_typeno.DataBindings.Add("text", b, "type_no")
            t_typename.DataBindings.Add("text", b, "type_name")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub b_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_add.Click
        Try
            b.RemoveFilter()
            b.AddNew()
            If b.Count = 1 Then
                t_typeno.Text = 1
            Else
                t_typeno.Text = ds.Tables("types").Rows(b.Count - 2).Item(0) + 1
            End If
            Call unenbld()
            t_typename.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub b_change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_change.Click
        b_save.Text = "تعديل"
        Call unenbld()

    End Sub

    Private Sub b_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_save.Click
        Try
            If b_save.Text = "حفظ" Then
                b.EndEdit()
                If ds.HasChanges(DataRowState.Added) Then
                    da.InsertCommand = New SqlCommand("insert into types values (@no,@name)", con)
                    With da.InsertCommand.Parameters
                        .Clear()
                        .AddWithValue("@no", t_typeno.Text)
                        .AddWithValue("@name", t_typename.Text)
                    End With
                    da.Update(ds.Tables("types"))
                    MsgBox("saved")
                    Call enbld()
                End If

            End If
            If b_save.Text = "تعديل" Then
                b.EndEdit()
                If ds.HasChanges(DataRowState.Modified) Then
                    da.UpdateCommand = New SqlCommand("update types set type_no=@no,type_name=@name where  type_no=@no ", con)
                    With da.UpdateCommand.Parameters
                        .Clear()
                        .AddWithValue("@no", t_typeno.Text)
                        .AddWithValue("@name", t_typename.Text)
                    End With

                    da.Update(ds.Tables("types"))
                    MsgBox("updated")
                    Call enbld()
                    b_save.Text = "حفظ"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub b_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_cancel.Click
        Try
            If b_save.Text = "تعديل" Then
                b_save.Text = "حفظ"
                Call enbld()

            End If
            If b_save.Text = "حفظ" Then
                b.RemoveCurrent()
                Call enbld()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub b_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_delete.Click
        Try
            b.EndEdit()
            Dim no As Integer = t_typeno.Text
            b.RemoveCurrent()
            If ds.HasChanges(DataRowState.Deleted) Then
                da.DeleteCommand = New SqlCommand("delete from types where type_no=" & no, con)
                da.Update(ds.Tables("types"))
                MsgBox("deleted")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

   
    Private Sub t_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_search.TextChanged
        b.Filter = "type_name like '" & (t_search.Text) & "%' "
    End Sub
End Class