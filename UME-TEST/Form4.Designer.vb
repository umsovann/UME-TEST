<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label1 = New Label()
        txtuser = New TextBox()
        Label2 = New Label()
        txtpasswd = New TextBox()
        btnlog = New Button()
        btnexit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(91, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 0
        Label1.Text = "User Name"
        ' 
        ' txtuser
        ' 
        txtuser.Location = New Point(192, 29)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(366, 27)
        txtuser.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(91, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 0
        Label2.Text = "Password"
        ' 
        ' txtpasswd
        ' 
        txtpasswd.Location = New Point(192, 76)
        txtpasswd.Name = "txtpasswd"
        txtpasswd.PasswordChar = "*"c
        txtpasswd.Size = New Size(366, 27)
        txtpasswd.TabIndex = 1
        ' 
        ' btnlog
        ' 
        btnlog.Location = New Point(214, 140)
        btnlog.Name = "btnlog"
        btnlog.Size = New Size(154, 51)
        btnlog.TabIndex = 2
        btnlog.Text = "Login"
        btnlog.UseVisualStyleBackColor = True
        ' 
        ' btnexit
        ' 
        btnexit.Location = New Point(404, 140)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(154, 51)
        btnexit.TabIndex = 2
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(682, 422)
        Controls.Add(btnexit)
        Controls.Add(btnlog)
        Controls.Add(txtpasswd)
        Controls.Add(Label2)
        Controls.Add(txtuser)
        Controls.Add(Label1)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpasswd As TextBox
    Friend WithEvents btnlog As Button
    Friend WithEvents btnexit As Button
End Class
