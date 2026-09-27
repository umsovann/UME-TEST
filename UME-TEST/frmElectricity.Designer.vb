<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElectricity
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
        Label2 = New Label()
        txtcustomer = New TextBox()
        Label3 = New Label()
        txtoldnumber = New TextBox()
        Label4 = New Label()
        txtnewnumber = New TextBox()
        Label5 = New Label()
        txttotalnumber = New TextBox()
        Label6 = New Label()
        txtpayment = New TextBox()
        btncalculate = New Button()
        btnExit = New Button()
        btncase = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Khmer OS Muol Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(274, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 41)
        Label1.TabIndex = 0
        Label1.Text = "អគ្គីសនីកម្ពុជា"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(107, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 36)
        Label2.TabIndex = 1
        Label2.Text = "ឈ្មោះអតិថិជន"
        ' 
        ' txtcustomer
        ' 
        txtcustomer.Location = New Point(276, 88)
        txtcustomer.Name = "txtcustomer"
        txtcustomer.Size = New Size(254, 27)
        txtcustomer.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(124, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 36)
        Label3.TabIndex = 1
        Label3.Text = "ទូរលេខចាស់"
        ' 
        ' txtoldnumber
        ' 
        txtoldnumber.Location = New Point(276, 132)
        txtoldnumber.Name = "txtoldnumber"
        txtoldnumber.Size = New Size(254, 27)
        txtoldnumber.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(150, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 36)
        Label4.TabIndex = 1
        Label4.Text = "ទូរលេខថ្មី"
        ' 
        ' txtnewnumber
        ' 
        txtnewnumber.Location = New Point(276, 179)
        txtnewnumber.Name = "txtnewnumber"
        txtnewnumber.Size = New Size(254, 27)
        txtnewnumber.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(148, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 36)
        Label5.TabIndex = 1
        Label5.Text = "ចំនួនគីឡូ"
        ' 
        ' txttotalnumber
        ' 
        txttotalnumber.Enabled = False
        txttotalnumber.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txttotalnumber.Location = New Point(276, 223)
        txttotalnumber.Name = "txttotalnumber"
        txttotalnumber.Size = New Size(254, 34)
        txttotalnumber.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(176, 264)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 36)
        Label6.TabIndex = 1
        Label6.Text = "បង់ថ្លៃ"
        ' 
        ' txtpayment
        ' 
        txtpayment.Enabled = False
        txtpayment.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpayment.Location = New Point(275, 269)
        txtpayment.Name = "txtpayment"
        txtpayment.Size = New Size(254, 38)
        txtpayment.TabIndex = 2
        ' 
        ' btncalculate
        ' 
        btncalculate.Font = New Font("Khmer OS Siemreap", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btncalculate.Location = New Point(267, 329)
        btncalculate.Name = "btncalculate"
        btncalculate.Size = New Size(119, 57)
        btncalculate.TabIndex = 3
        btncalculate.Text = "គណនា"
        btncalculate.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Khmer OS Siemreap", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(428, 329)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(115, 57)
        btnExit.TabIndex = 3
        btnExit.Text = "ចាកចេញ"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btncase
        ' 
        btncase.Location = New Point(123, 332)
        btncase.Name = "btncase"
        btncase.Size = New Size(116, 66)
        btncase.TabIndex = 4
        btncase.Text = "Case"
        btncase.UseVisualStyleBackColor = True
        ' 
        ' frmElectricity
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btncase)
        Controls.Add(btnExit)
        Controls.Add(btncalculate)
        Controls.Add(txtpayment)
        Controls.Add(Label6)
        Controls.Add(txttotalnumber)
        Controls.Add(Label5)
        Controls.Add(txtnewnumber)
        Controls.Add(Label4)
        Controls.Add(txtoldnumber)
        Controls.Add(Label3)
        Controls.Add(txtcustomer)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmElectricity"
        Text = "frmElectricity"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcustomer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtoldnumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnewnumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txttotalnumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpayment As TextBox
    Friend WithEvents btncalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btncase As Button
End Class
