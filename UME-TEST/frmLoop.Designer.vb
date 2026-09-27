<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoop
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
        btnwhileloop = New Button()
        txtwhileloop = New TextBox()
        btndowhileloop = New Button()
        txtdowhileloop = New TextBox()
        btndoloop = New Button()
        txtdoloop = New TextBox()
        btndountilloop = New Button()
        txtdountilloop = New TextBox()
        btnfornextloop = New Button()
        txtfornextloop = New TextBox()
        SuspendLayout()
        ' 
        ' btnwhileloop
        ' 
        btnwhileloop.Location = New Point(6, 0)
        btnwhileloop.Name = "btnwhileloop"
        btnwhileloop.Size = New Size(141, 66)
        btnwhileloop.TabIndex = 0
        btnwhileloop.Text = "While Loop"
        btnwhileloop.UseVisualStyleBackColor = True
        ' 
        ' txtwhileloop
        ' 
        txtwhileloop.Location = New Point(7, 75)
        txtwhileloop.Multiline = True
        txtwhileloop.Name = "txtwhileloop"
        txtwhileloop.Size = New Size(140, 360)
        txtwhileloop.TabIndex = 1
        ' 
        ' btndowhileloop
        ' 
        btndowhileloop.Location = New Point(153, 0)
        btndowhileloop.Name = "btndowhileloop"
        btndowhileloop.Size = New Size(141, 66)
        btndowhileloop.TabIndex = 0
        btndowhileloop.Text = "Do While Loop"
        btndowhileloop.UseVisualStyleBackColor = True
        ' 
        ' txtdowhileloop
        ' 
        txtdowhileloop.Location = New Point(154, 75)
        txtdowhileloop.Multiline = True
        txtdowhileloop.Name = "txtdowhileloop"
        txtdowhileloop.Size = New Size(140, 360)
        txtdowhileloop.TabIndex = 1
        ' 
        ' btndoloop
        ' 
        btndoloop.Location = New Point(300, 0)
        btndoloop.Name = "btndoloop"
        btndoloop.Size = New Size(141, 66)
        btndoloop.TabIndex = 0
        btndoloop.Text = "Do Loop"
        btndoloop.UseVisualStyleBackColor = True
        ' 
        ' txtdoloop
        ' 
        txtdoloop.Location = New Point(301, 75)
        txtdoloop.Multiline = True
        txtdoloop.Name = "txtdoloop"
        txtdoloop.Size = New Size(140, 360)
        txtdoloop.TabIndex = 1
        ' 
        ' btndountilloop
        ' 
        btndountilloop.Location = New Point(447, 0)
        btndountilloop.Name = "btndountilloop"
        btndountilloop.Size = New Size(141, 66)
        btndountilloop.TabIndex = 0
        btndountilloop.Text = "Do Until Loop"
        btndountilloop.UseVisualStyleBackColor = True
        ' 
        ' txtdountilloop
        ' 
        txtdountilloop.Location = New Point(448, 75)
        txtdountilloop.Multiline = True
        txtdountilloop.Name = "txtdountilloop"
        txtdountilloop.Size = New Size(140, 360)
        txtdountilloop.TabIndex = 1
        ' 
        ' btnfornextloop
        ' 
        btnfornextloop.Location = New Point(594, 0)
        btnfornextloop.Name = "btnfornextloop"
        btnfornextloop.Size = New Size(141, 66)
        btnfornextloop.TabIndex = 0
        btnfornextloop.Text = "For Next Loop"
        btnfornextloop.UseVisualStyleBackColor = True
        ' 
        ' txtfornextloop
        ' 
        txtfornextloop.Location = New Point(595, 75)
        txtfornextloop.Multiline = True
        txtfornextloop.Name = "txtfornextloop"
        txtfornextloop.Size = New Size(140, 360)
        txtfornextloop.TabIndex = 1
        ' 
        ' frmLoop
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(756, 450)
        Controls.Add(txtfornextloop)
        Controls.Add(txtdountilloop)
        Controls.Add(txtdoloop)
        Controls.Add(txtdowhileloop)
        Controls.Add(txtwhileloop)
        Controls.Add(btnfornextloop)
        Controls.Add(btndountilloop)
        Controls.Add(btndoloop)
        Controls.Add(btndowhileloop)
        Controls.Add(btnwhileloop)
        Name = "frmLoop"
        Text = "frmLoop"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnwhileloop As Button
    Friend WithEvents txtwhileloop As TextBox
    Friend WithEvents btndowhileloop As Button
    Friend WithEvents txtdowhileloop As TextBox
    Friend WithEvents btndoloop As Button
    Friend WithEvents txtdoloop As TextBox
    Friend WithEvents btndountilloop As Button
    Friend WithEvents txtdountilloop As TextBox
    Friend WithEvents btnfornextloop As Button
    Friend WithEvents txtfornextloop As TextBox
End Class
