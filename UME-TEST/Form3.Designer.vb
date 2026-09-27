<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        lbltime = New Label()
        Timer1 = New Timer(components)
        Label3 = New Label()
        lblstart = New Label()
        Label5 = New Label()
        lblduration = New Label()
        Label7 = New Label()
        lblend = New Label()
        btnstart = New Button()
        btnstop = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(247, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 31)
        Label1.TabIndex = 0
        Label1.Text = "Timer Application"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(379, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 31)
        Label2.TabIndex = 0
        Label2.Text = "Time:"
        ' 
        ' lbltime
        ' 
        lbltime.AutoSize = True
        lbltime.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltime.ForeColor = Color.Black
        lbltime.Location = New Point(481, 108)
        lbltime.Name = "lbltime"
        lbltime.Size = New Size(149, 31)
        lbltime.TabIndex = 0
        lbltime.Text = "Label_Timer"
        ' 
        ' Timer1
        ' 
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Palatino Linotype", 13.8F)
        Label3.Location = New Point(128, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 31)
        Label3.TabIndex = 1
        Label3.Text = "Start Time"
        ' 
        ' lblstart
        ' 
        lblstart.AutoSize = True
        lblstart.Font = New Font("Palatino Linotype", 13.8F)
        lblstart.ForeColor = Color.Blue
        lblstart.Location = New Point(281, 192)
        lblstart.Name = "lblstart"
        lblstart.Size = New Size(195, 31)
        lblstart.TabIndex = 2
        lblstart.Text = "Label_Start_Time"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Palatino Linotype", 13.8F)
        Label5.Location = New Point(128, 239)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 31)
        Label5.TabIndex = 1
        Label5.Text = "Duration"
        ' 
        ' lblduration
        ' 
        lblduration.AutoSize = True
        lblduration.Font = New Font("Palatino Linotype", 13.8F)
        lblduration.ForeColor = Color.Blue
        lblduration.Location = New Point(281, 239)
        lblduration.Name = "lblduration"
        lblduration.Size = New Size(176, 31)
        lblduration.TabIndex = 2
        lblduration.Text = "Label_Duration"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Palatino Linotype", 13.8F)
        Label7.Location = New Point(128, 280)
        Label7.Name = "Label7"
        Label7.Size = New Size(113, 31)
        Label7.TabIndex = 1
        Label7.Text = "End Time"
        ' 
        ' lblend
        ' 
        lblend.AutoSize = True
        lblend.Font = New Font("Palatino Linotype", 13.8F)
        lblend.ForeColor = Color.Blue
        lblend.Location = New Point(281, 280)
        lblend.Name = "lblend"
        lblend.Size = New Size(187, 31)
        lblend.TabIndex = 2
        lblend.Text = "Label_End_Time"
        ' 
        ' btnstart
        ' 
        btnstart.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnstart.Location = New Point(224, 357)
        btnstart.Name = "btnstart"
        btnstart.Size = New Size(94, 43)
        btnstart.TabIndex = 3
        btnstart.Text = "Start"
        btnstart.UseVisualStyleBackColor = True
        ' 
        ' btnstop
        ' 
        btnstop.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnstop.Location = New Point(382, 357)
        btnstop.Name = "btnstop"
        btnstop.Size = New Size(94, 43)
        btnstop.TabIndex = 3
        btnstop.Text = "Stop"
        btnstop.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnstop)
        Controls.Add(btnstart)
        Controls.Add(lblend)
        Controls.Add(lblduration)
        Controls.Add(lblstart)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(lbltime)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents lblstart As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblduration As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblend As Label
    Friend WithEvents btnstart As Button
    Friend WithEvents btnstop As Button
End Class
