<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        btnclear = New Button()
        btnanswer = New Button()
        txtaverage = New TextBox()
        txttotalscore = New TextBox()
        txtisa = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        txtlinux = New TextBox()
        Label5 = New Label()
        txtoop = New TextBox()
        Label4 = New Label()
        txtdbms = New TextBox()
        Label3 = New Label()
        txtnetwork = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnclear)
        GroupBox1.Controls.Add(btnanswer)
        GroupBox1.Controls.Add(txtaverage)
        GroupBox1.Controls.Add(txttotalscore)
        GroupBox1.Controls.Add(txtisa)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtlinux)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtoop)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtdbms)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtnetwork)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(6, 8)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(788, 437)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' btnclear
        ' 
        btnclear.Location = New Point(476, 307)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(120, 33)
        btnclear.TabIndex = 3
        btnclear.Text = "CLEAR"
        btnclear.UseVisualStyleBackColor = True
        ' 
        ' btnanswer
        ' 
        btnanswer.BackColor = SystemColors.Control
        btnanswer.ForeColor = SystemColors.ActiveCaptionText
        btnanswer.Location = New Point(323, 307)
        btnanswer.Name = "btnanswer"
        btnanswer.Size = New Size(120, 33)
        btnanswer.TabIndex = 3
        btnanswer.Text = "ANSWER"
        btnanswer.UseVisualStyleBackColor = False
        ' 
        ' txtaverage
        ' 
        txtaverage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtaverage.BackColor = SystemColors.Info
        txtaverage.Location = New Point(476, 260)
        txtaverage.Name = "txtaverage"
        txtaverage.Size = New Size(158, 27)
        txtaverage.TabIndex = 2
        txtaverage.TextAlign = HorizontalAlignment.Center
        ' 
        ' txttotalscore
        ' 
        txttotalscore.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txttotalscore.BackColor = SystemColors.Info
        txttotalscore.Location = New Point(285, 260)
        txttotalscore.Name = "txttotalscore"
        txttotalscore.Size = New Size(158, 27)
        txttotalscore.TabIndex = 2
        txttotalscore.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtisa
        ' 
        txtisa.Location = New Point(285, 197)
        txtisa.Name = "txtisa"
        txtisa.Size = New Size(349, 27)
        txtisa.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(318, 237)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 20)
        Label7.TabIndex = 1
        Label7.Text = "TOTAL SCORE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(523, 237)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 20)
        Label8.TabIndex = 1
        Label8.Text = "AVERAGE"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(177, 197)
        Label6.Name = "Label6"
        Label6.Size = New Size(31, 20)
        Label6.TabIndex = 1
        Label6.Text = "ISA"
        ' 
        ' txtlinux
        ' 
        txtlinux.Location = New Point(285, 164)
        txtlinux.Name = "txtlinux"
        txtlinux.Size = New Size(349, 27)
        txtlinux.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(177, 164)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 20)
        Label5.TabIndex = 1
        Label5.Text = "LINUX"
        ' 
        ' txtoop
        ' 
        txtoop.Location = New Point(285, 131)
        txtoop.Name = "txtoop"
        txtoop.Size = New Size(349, 27)
        txtoop.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(177, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 20)
        Label4.TabIndex = 1
        Label4.Text = "OOP"
        ' 
        ' txtdbms
        ' 
        txtdbms.Location = New Point(285, 98)
        txtdbms.Name = "txtdbms"
        txtdbms.Size = New Size(349, 27)
        txtdbms.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(177, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 1
        Label3.Text = "DBMS"
        ' 
        ' txtnetwork
        ' 
        txtnetwork.Location = New Point(285, 65)
        txtnetwork.Name = "txtnetwork"
        txtnetwork.Size = New Size(349, 27)
        txtnetwork.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(177, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 1
        Label2.Text = "NETWORK"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Khmer OS Muol Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(127, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(539, 33)
        Label1.TabIndex = 0
        Label1.Text = "ចូរសរសេរកម្មវិធីបូកពិន្ទុ និងគណនាមធ្យមភាគតាមមុខវិជ្ជា"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnetwork As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents btnanswer As Button
    Friend WithEvents txtaverage As TextBox
    Friend WithEvents txttotalscore As TextBox
    Friend WithEvents txtisa As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtlinux As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtoop As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdbms As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label

End Class
