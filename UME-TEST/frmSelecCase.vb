Public Class frmSelecCase
    Private Sub btnmention_Click(sender As Object, e As EventArgs) Handles btnmention.Click
        Dim average As Integer
        average = Val(txtaverage.Text)
        Select Case average
            Case Is > 100
                txtmention.Text = "Invalid"
            Case 95 To 100
                txtmention.Text = "Excellence"
            Case Is >= 85
                txtmention.Text = "Very Good"
            Case 75 To 84
                txtmention.Text = "Good"
            Case Is >= 65
                txtmention.Text = "Fair"
            Case Is >= 50
                txtmention.Text = "Medium"
            Case Else
                txtmention.Text = "Weak"

        End Select
    End Sub
End Class