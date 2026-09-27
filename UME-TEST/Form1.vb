Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnanswer.Click
        Dim network, dbms, oop, linux, isa As Integer
        Dim totalscore As Integer
        Dim average As Double

        network = txtnetwork.Text
        dbms = txtdbms.Text
        oop = txtoop.Text
        linux = txtlinux.Text
        isa = txtisa.Text

        totalscore = network + dbms + oop + linux + isa
        average = totalscore / 5

        txttotalscore.Text = totalscore
        txtaverage.Text = average

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnetwork.Clear()
        txtdbms.Clear()
        txtoop.Clear()
        txtlinux.Clear()
        txtisa.Clear()
        txtnetwork.Focus()

        txttotalscore.Clear()
        txtaverage.Clear()



    End Sub
End Class
