<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelecCase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelecCase))
        Label1 = New Label()
        txtaverage = New TextBox()
        Label2 = New Label()
        txtmention = New TextBox()
        btnmention = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(79, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 0
        Label1.Text = "Average:"
        ' 
        ' txtaverage
        ' 
        txtaverage.Location = New Point(194, 61)
        txtaverage.Name = "txtaverage"
        txtaverage.Size = New Size(291, 27)
        txtaverage.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(79, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 0
        Label2.Text = "Mention:"
        ' 
        ' txtmention
        ' 
        txtmention.Location = New Point(194, 119)
        txtmention.Name = "txtmention"
        txtmention.Size = New Size(291, 27)
        txtmention.TabIndex = 1
        ' 
        ' btnmention
        ' 
        btnmention.Location = New Point(257, 166)
        btnmention.Name = "btnmention"
        btnmention.Size = New Size(173, 57)
        btnmention.TabIndex = 2
        btnmention.Text = "Mention"
        btnmention.UseVisualStyleBackColor = True
        ' 
        ' frmSelecCase
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnmention)
        Controls.Add(txtmention)
        Controls.Add(txtaverage)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmSelecCase"
        Text = "frmSelecCase"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtaverage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmention As TextBox
    Friend WithEvents btnmention As Button
End Class
