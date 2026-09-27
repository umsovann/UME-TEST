Public Class frmCheckBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As String = ""
        If CheckBox1.Checked = True Then
            msg = vbCrLf & " Computer Desktop,"
        End If
        If CheckBox2.Checked = True Then
            msg = msg & vbCrLf & "Computer Labtop,"
        End If
        If CheckBox3.Checked = True Then
            msg = msg & vbCrLf & "Printer"
        End If

        If msg.Length > 0 Then
            Label1.Text = "You checked: " & msg
        Else
            Label1.Text = "No Checkbox selected "

        End If

    End Sub
End Class