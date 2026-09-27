<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmweekday
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmweekday))
        Label1 = New Label()
        ComboBox1 = New System.Windows.Forms.ComboBox()
        Label2 = New Label()
        ComboBox2 = New System.Windows.Forms.ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(126, 28)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 27)
        Label1.TabIndex = 0
        Label1.Text = "Weekdays"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.ForeColor = SystemColors.HotTrack
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(126, 77)
        ComboBox1.Margin = New Padding(4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(283, 35)
        ComboBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(126, 170)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 27)
        Label2.TabIndex = 0
        Label2.Text = "Year"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.ForeColor = SystemColors.HotTrack
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(118, 225)
        ComboBox2.Margin = New Padding(4)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(286, 35)
        ComboBox2.TabIndex = 2
        ' 
        ' frmweekday
        ' 
        AutoScaleDimensions = New SizeF(12F, 27F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(568, 424)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Blue
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "frmweekday"
        Text = "frmweekday"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
