Public Class Form2
    Dim x As String = "x is Globle Variable" 'Globle Variable'
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim money As Integer  'Local Variable
        If txtmoney.Text = "" Then
            money = 0
            Dim y As String = "Local Variable : Please input your money."
            MessageBox.Show(y)
        Else
            money = txtmoney.Text
        End If


        ' MessageBox.Show(x)
        txt100.Text = (money \ 100).ToString
        txt50.Text = (money Mod 100) \ 50
        txt20.Text = ((money Mod 100) Mod 50) \ 20
        txt10.Text = (((money Mod 100) Mod 50) Mod 20) \ 10
        txt5.Text = ((((money Mod 100) Mod 50) Mod 20) Mod 10) \ 5
        txt1.Text = ((((money Mod 100) Mod 50) Mod 20) Mod 10) Mod 5 \ 1

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        'Me.Close()
        Application.Exit()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtmoney.Clear()
        txt100.Clear()
        txt50.Clear()
        txt20.Clear()
        txt10.Clear()
        txt5.Clear()
        txt1.Clear()
        txtmoney.Focus()
        'MessageBox.Show(x)

    End Sub
End Class