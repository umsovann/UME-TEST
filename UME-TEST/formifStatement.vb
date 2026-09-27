Public Class formifStatement
    'Globle Variable
    Dim a = 5
    Dim b = 2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim raise, sum, modolus As Integer
        Dim divide, divideInt As Double


        raise = a ^ b
        sum = a + b
        divide = a / b
        divideInt = a \ b
        modolus = a Mod b

        MessageBox.Show("A = 5 " &
                        Environment.NewLine & "B = 2 " &
                        Environment.NewLine & "A ^ B = " & raise &
                        Environment.NewLine & "A + B = " & sum &
                        Environment.NewLine & "A / B = " & divide &
                        Environment.NewLine & "A \ B = " & divideInt &
                        Environment.NewLine & "A Mod B = " & modolus
                        )

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("A = 5 " &
                        Environment.NewLine & "B = 2" &
                        Environment.NewLine & "A = B => " & (a = b) &
                        Environment.NewLine & "A <> B => " & (a <> b) &
                        Environment.NewLine & "A > B => " & (a > b) &
                        Environment.NewLine & "A >= B => " & (a >= b) &
                        Environment.NewLine & "A < B => " & (a < b) &
                        Environment.NewLine & "A <= B => " & (a <= b)
                        )
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim c As Integer
        Dim d As Integer = 4
        Dim f As Integer = 4
        Dim str As String = "Hello "

        c = a + b
        d += a 'd=d+a 'd=4+5 9
        f *= b 'f=f*b 'f=4*2 =8
        str += "world."
        str += "Welcome to VB.net."

        MessageBox.Show("A = 5 " & Environment.NewLine & "b  =2 " &
                       Environment.NewLine & " C = A + B => " & c &
                       Environment.NewLine & "D += A => " & d &
                       Environment.NewLine & "D + A => " & d &
                       Environment.NewLine & "F*= B => " & f &
                       Environment.NewLine & "STR  => " & str
                       )

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        b += 5


        If (a > b) Then
            MessageBox.Show("a is greater than b.")
        ElseIf (a < b) Then
            MessageBox.Show("a less than b.")
        ElseIf (a = b) Then
            MessageBox.Show("a is equal to b")
        End If
    End Sub
End Class