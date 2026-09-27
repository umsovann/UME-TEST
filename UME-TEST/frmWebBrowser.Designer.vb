<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebBrowser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        btnclick = New Button()
        txtweb = New TextBox()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' WebView21
        ' 
        WebView21.AllowExternalDrop = True
        WebView21.CreationProperties = Nothing
        WebView21.DefaultBackgroundColor = Color.White
        WebView21.Location = New Point(115, 112)
        WebView21.Name = "WebView21"
        WebView21.Size = New Size(534, 279)
        WebView21.TabIndex = 0
        WebView21.ZoomFactor = 1R
        ' 
        ' btnclick
        ' 
        btnclick.Location = New Point(115, 53)
        btnclick.Name = "btnclick"
        btnclick.Size = New Size(117, 53)
        btnclick.TabIndex = 1
        btnclick.Text = "Click"
        btnclick.UseVisualStyleBackColor = True
        ' 
        ' txtweb
        ' 
        txtweb.Location = New Point(248, 66)
        txtweb.Name = "txtweb"
        txtweb.Size = New Size(369, 27)
        txtweb.TabIndex = 2
        ' 
        ' frmWebBrowser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtweb)
        Controls.Add(btnclick)
        Controls.Add(WebView21)
        Name = "frmWebBrowser"
        Text = "frmWebBrowser"
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents btnclick As Button
    Friend WithEvents txtweb As TextBox
End Class
