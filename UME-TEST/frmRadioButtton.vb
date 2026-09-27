Imports System.Diagnostics.Eventing.Reader

Public Class frmRadioButtton
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            BackColor = Color.Red
            Exit Sub
        ElseIf RadioButton2.checked = True Then
            BackColor = Color.Blue
            Exit Sub
        Else
            BackColor = Color.Green
            Exit Sub

        End If


    End Sub
End Class