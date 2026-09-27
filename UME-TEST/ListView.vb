Public Class ListView
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtid.Text = ListView1.SelectedItems(0).Text
            txtname.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtqty.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtprice.Text = ListView1.SelectedItems(0).SubItems(3).Text

        End If


    End Sub

    Private Sub ListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("ProductID", 100)
        ListView1.Columns.Add("ProductName", 120)
        ListView1.Columns.Add("Quantity", 100)
        ListView1.Columns.Add("Price", 100)
        ListView1.Columns.Add("Total", 100)
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True
    End Sub



    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim total As Integer
        Static amount As Integer = 0
        Dim lstitem As ListViewItem

        lstitem = ListView1.Items.Add(txtid.Text)
        lstitem.SubItems.Add(txtname.Text)
        lstitem.SubItems.Add(txtqty.Text)
        lstitem.SubItems.Add(txtprice.Text)
        total = txtqty.Text * txtprice.Text
        lstitem.SubItems.Add(Format(total, "#,##0.00"))
        amount += total
        lblamount.Text = "Amount: " + Format(amount, "#,##0.00")

    End Sub

    Private Sub lblamount_Click(sender As Object, e As EventArgs) Handles lblamount.Click

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        On Error Resume Next
        If ListView1.SelectedIndices.Count = 0 Then
            MessageBox.Show("Please selectrecord to Edit")

        End If
        ListView1.SelectedItems(0).Text = txtid.Text
        ListView1.SelectedItems(0).SubItems(1).Text = txtname.Text
        ListView1.SelectedItems(0).SubItems(2).Text = txtqty.Text
        ListView1.SelectedItems(0).SubItems(3).Text = txtprice.Text


    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtid.Clear()
        txtname.Clear()
        txtqty.Clear()
        txtprice.Clear()

    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        ' MessageBox.Show(ListView1.SelectedIndices(0))
        ' MessageBox.Show(ListView1.SelectedIndices.Count)
        If ListView1.SelectedIndices.Count > 0 Then
            Dim i As Integer = ListView1.SelectedIndices(0)
            ListView1.Items.RemoveAt(i)

        End If
    End Sub
End Class