Public Class frmElectricity
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click

    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        Dim oldnum, newnum, totalnum, payment As Integer
        oldnum = Val(txtoldnumber.Text)
        newnum = Val(txtnewnumber.Text)
        totalnum = newnum - oldnum

        If totalnum < 0 Then
            MessageBox.Show("New number must greter than old number.")
        Else
            If totalnum < 50 Then
                payment = totalnum * 500
            Else
                payment = totalnum * 400

            End If
            txttotalnumber.Text = totalnum & " Kilowat"
            txtpayment.Text = Format(payment, "#,##0.00Riel")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btncase_Click(sender As Object, e As EventArgs) Handles btncase.Click
        'Dim x As Integer = 15
        'Select Case x
        '    Case 10
        '        MsgBox("x Value is 10")
        '    Case 15
        '        MsgBox("x Value is 15")
        '        MsgBox("x Value is 10")
        '    Case 20
        '        MsgBox("Value is 20")
        '    Case Else
        '        MsgBox("Not know")

        'End Select

        Dim numofday As Integer = 2
        Select Case numofday
            Case 1
                MsgBox("Monday")
            Case 2
                MsgBox("tueday")
            Case 3
                MsgBox("Monday")
            Case 4
                MsgBox("Wednesday")
            Case 5
                MsgBox("Thueday")
            Case 6
                MsgBox("Sathuday")
            Case 7
                MsgBox("Sunday")


        End Select



    End Sub
End Class