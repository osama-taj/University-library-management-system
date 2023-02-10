Imports System.Data.SqlClient

Public Class Form1

    Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=projectlibrary;Integrated Security=True;Pooling=False")


    Private Sub b_logIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_logIN.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Dim cmd As New SqlCommand("select * from users where userName='" & t_userName.Text & " ' ", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            dr.Read()
            If dr.Item(4) = t_passWord.Text Then
                user_name = dr.Item(1)
                auto_no = dr.Item(0)

                MsgBox(" welcom " + user_name)

                main.Show()
               
                Me.Hide()
                Exit Sub

            Else
                MsgBox("wrong passWord")
                t_passWord.Focus()
            End If
        Else
            MsgBox("wrong userName")
            t_userName.Focus()
        End If




    End Sub

    Private Sub l_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_close.Click
        Me.Close()
    End Sub
End Class
