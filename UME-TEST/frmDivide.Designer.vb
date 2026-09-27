<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDivide
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
        txtvalue1 = New TextBox()
        Label2 = New Label()
        txtvalue2 = New TextBox()
        Label3 = New Label()
        txtresult = New TextBox()
        btndivide = New Button()
        btnexit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(68, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 20)
        Label1.TabIndex = 0
        Label1.Text = "Value 1"
        ' 
        ' txtvalue1
        ' 
        txtvalue1.Location = New Point(164, 38)
        txtvalue1.Name = "txtvalue1"
        txtvalue1.Size = New Size(193, 27)
        txtvalue1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(68, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 0
        Label2.Text = "Value 2"
        ' 
        ' txtvalue2
        ' 
        txtvalue2.Location = New Point(164, 90)
        txtvalue2.Name = "txtvalue2"
        txtvalue2.Size = New Size(193, 27)
        txtvalue2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(68, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 0
        Label3.Text = "Result"
        ' 
        ' txtresult
        ' 
        txtresult.Location = New Point(164, 137)
        txtresult.Name = "txtresult"
        txtresult.Size = New Size(193, 27)
        txtresult.TabIndex = 1
        ' 
        ' btndivide
        ' 
        btndivide.Location = New Point(115, 221)
        btndivide.Name = "btndivide"
        btndivide.Size = New Size(94, 29)
        btndivide.TabIndex = 2
        btndivide.Text = "Divide"
        btndivide.UseVisualStyleBackColor = True
        ' 
        ' btnexit
        ' 
        btnexit.Location = New Point(263, 221)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(94, 29)
        btnexit.TabIndex = 2
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' frmDivide
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 367)
        Controls.Add(btnexit)
        Controls.Add(btndivide)
        Controls.Add(txtresult)
        Controls.Add(Label3)
        Controls.Add(txtvalue2)
        Controls.Add(Label2)
        Controls.Add(txtvalue1)
        Controls.Add(Label1)
        Name = "frmDivide"
        Text = "frmDivide"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtvalue1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtvalue2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtresult As TextBox
    Friend WithEvents btndivide As Button
    Friend WithEvents btnexit As Button
End Class
