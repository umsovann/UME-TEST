Public Class frmWebBrowser
    Private Sub WebView21_Click(sender As Object, e As EventArgs) Handles WebView21.Click

    End Sub

    Private Async Sub frmWebBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await WebView21.EnsureCoreWebView2Async(Nothing)
        'WebView21.CoreWebView2.Navigate("https://www.youtube.com/watch?v=t0yQAVpjiZc&list=RDt0yQAVpjiZc&start_radio=1")
    End Sub

    Private Sub btnclick_Click(sender As Object, e As EventArgs) Handles btnclick.Click
        Dim strweb As String
        strweb = txtweb.Text
        WebView21.CoreWebView2.Navigate("https://www." + strweb + ".com/")
    End Sub
End Class