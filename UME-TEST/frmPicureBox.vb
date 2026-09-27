Public Class frmPicureBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "*.jpg|*.jpg|*bmp|*.bmp"
        OpenFileDialog1.ShowDialog()
        Dim path As String = OpenFileDialog1.FileName
        'MessageBox.Show(path)
        PictureBox1.Image = Image.FromFile(path)

    End Sub

End Class