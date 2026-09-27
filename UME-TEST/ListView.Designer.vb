<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListView
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
        Dim ListViewItem2 As ListViewItem = New ListViewItem("")
        ListView1 = New System.Windows.Forms.ListView()
        Label1 = New Label()
        Label2 = New Label()
        txtid = New TextBox()
        Label3 = New Label()
        txtname = New TextBox()
        Label4 = New Label()
        txtqty = New TextBox()
        Label5 = New Label()
        txtprice = New TextBox()
        btnadd = New Button()
        btnedit = New Button()
        btnremove = New Button()
        btnclear = New Button()
        lblamount = New Label()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Items.AddRange(New ListViewItem() {ListViewItem2})
        ListView1.Location = New Point(105, 244)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(581, 342)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label1.Location = New Point(220, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(307, 41)
        Label1.TabIndex = 1
        Label1.Text = "Product Information"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(58, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 25)
        Label2.TabIndex = 2
        Label2.Text = "ProductID"
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(207, 91)
        txtid.Name = "txtid"
        txtid.Size = New Size(307, 27)
        txtid.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(58, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 25)
        Label3.TabIndex = 2
        Label3.Text = "ProductName"
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(207, 124)
        txtname.Name = "txtname"
        txtname.Size = New Size(307, 27)
        txtname.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(58, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 25)
        Label4.TabIndex = 2
        Label4.Text = "Quantity"
        ' 
        ' txtqty
        ' 
        txtqty.Location = New Point(207, 157)
        txtqty.Name = "txtqty"
        txtqty.Size = New Size(307, 27)
        txtqty.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F)
        Label5.Location = New Point(58, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 25)
        Label5.TabIndex = 2
        Label5.Text = "Price"
        ' 
        ' txtprice
        ' 
        txtprice.Location = New Point(207, 190)
        txtprice.Name = "txtprice"
        txtprice.Size = New Size(307, 27)
        txtprice.TabIndex = 3
        ' 
        ' btnadd
        ' 
        btnadd.Location = New Point(580, 96)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(106, 29)
        btnadd.TabIndex = 4
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(580, 127)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(106, 29)
        btnedit.TabIndex = 4
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' btnremove
        ' 
        btnremove.Location = New Point(580, 162)
        btnremove.Name = "btnremove"
        btnremove.Size = New Size(106, 29)
        btnremove.TabIndex = 4
        btnremove.Text = "Remove"
        btnremove.UseVisualStyleBackColor = True
        ' 
        ' btnclear
        ' 
        btnclear.Location = New Point(580, 197)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(106, 29)
        btnclear.TabIndex = 4
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = True
        ' 
        ' lblamount
        ' 
        lblamount.AutoSize = True
        lblamount.Font = New Font("Segoe UI", 11F)
        lblamount.Location = New Point(516, 589)
        lblamount.Name = "lblamount"
        lblamount.Size = New Size(79, 25)
        lblamount.TabIndex = 2
        lblamount.Text = "Amount"
        ' 
        ' ListView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 707)
        Controls.Add(btnclear)
        Controls.Add(btnremove)
        Controls.Add(btnedit)
        Controls.Add(btnadd)
        Controls.Add(txtprice)
        Controls.Add(lblamount)
        Controls.Add(Label5)
        Controls.Add(txtqty)
        Controls.Add(Label4)
        Controls.Add(txtname)
        Controls.Add(Label3)
        Controls.Add(txtid)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListView1)
        Name = "ListView"
        Text = "ListView"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnremove As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents lblamount As Label
End Class
