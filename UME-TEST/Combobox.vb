Public Class Combobox
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Combobox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add item to Combox
        ComboBox1.Items.Add("Monday")
        ComboBox1.Items.Add("Tuesday")
        ComboBox1.Items.Add("Wednesday")
        ComboBox1.Items.Add("Thurday")
        ComboBox1.Items.Add("Friday")
        ComboBox1.Items.Add("Saturday")
        ComboBox1.Items.Add("Sunday")

        'Set the selectd item in Cmbobox
        ComboBox1.SelectedItem = "Monday"
        'or
        ComboBox1.SelectedItem = ComboBox1.Items(2)
        'or
        ComboBox1.SelectedIndex = ComboBox1.FindStringExact("Friday")

        'Remove an item from Cambobox
        ComboBox1.Items.RemoveAt(2)
        'or
        ComboBox1.Items.Remove("Monday")

    End Sub
End Class