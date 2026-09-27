<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Combobox
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
        ComboBox1 = New System.Windows.Forms.ComboBox()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(138, 53)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(407, 28)
        ComboBox1.TabIndex = 0
        ' 
        ' Combobox
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBox1)
        Name = "Combobox"
        Text = "Combobox"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
