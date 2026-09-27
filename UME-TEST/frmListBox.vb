Imports System.Transactions

Public Class frmListBox
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        MessageBox.Show(ListBox1.SelectedIndex)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter any item...")
            TextBox1.Focus()
        Else
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Clear()
            TextBox1.Focus()

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex < 0 Then
            MessageBox.Show("No Item to delete...")
        Else
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

        End If
    End Sub
End Class