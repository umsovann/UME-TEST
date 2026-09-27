Public Class frmweekday
    Private Sub frmweekday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Weekdays")
        ComboBox1.Items.Add("Year")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        If ComboBox1.SelectedItem = "Weekdays" Then
            ComboBox2.Items.Add("Sunday")
            ComboBox2.Items.Add("Monday")
            ComboBox2.Items.Add("Tuesday")
        ElseIf ComboBox1.selecteditem = "Year" Then
            ComboBox2.Items.Add("2024")
            ComboBox2.Items.Add("2025")
            ComboBox2.Items.Add("2026")


        End If
    End Sub
End Class