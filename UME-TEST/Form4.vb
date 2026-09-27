Public Class Form4
    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        Dim correctuser As String = "Admin"
        Dim correctpass As String = "admin@123"

        Dim inputuser As String
        Dim inputpass As String
        inputuser = txtuser.Text
        inputpass = txtpasswd.Text

        If inputuser = correctuser And inputpass = correctpass Then
            MessageBox.Show("Login Successfully")
        Else
            MessageBox.Show("Incorrect User or Password")

        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub
End Class