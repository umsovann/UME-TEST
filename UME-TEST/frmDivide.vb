Public Class frmDivide
    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        Dim val1, val2, result As Integer
        val1 = txtvalue1.Text
        val2 = txtvalue2.Text
        If (val2 = 0) Then
            MessageBox.Show("Cannot divide a number by zero.")
        ElseIf val2 <> 0 Then
            result = val1 / val2
            txtresult.Text = result
        End If

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        'Me.Close()
        Application.Exit()
    End Sub

    Private Sub txtresult_TextChanged(sender As Object, e As EventArgs) Handles txtresult.TextChanged

    End Sub
End Class