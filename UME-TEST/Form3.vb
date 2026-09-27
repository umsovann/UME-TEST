Public Class Form3
    Dim starttime
    Dim endtime
    Dim duration


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = TimeOfDay
    End Sub

    Private Sub lbltime_Click(sender As Object, e As EventArgs) Handles lbltime.Click


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1000
        'MessageBox.show("Form Load")
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        starttime = TimeOfDay
        lblstart.Text = FormatDateTime(starttime, DateFormat.LongTime)
        lblduration.Text = ""
        lblend.Text = ""

    End Sub

    Private Sub btnstop_Click(sender As Object, e As EventArgs) Handles btnstop.Click
        endtime = TimeOfDay
        duration = endtime - starttime
        lblduration.Text = duration.ToString()

        lblend.Text = FormatDateTime(endtime, DateFormat.LongTime)
    End Sub
End Class