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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TotalPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.MonthlyPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.InterestRateTextBox = New System.Windows.Forms.TextBox()
        Me.DurationTextBox = New System.Windows.Forms.TextBox()
        Me.loanAmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CustomernameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ReceiptTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.affordabilityTextBox = New System.Windows.Forms.TextBox()
        Me.ThirdPartyTextBox = New System.Windows.Forms.TextBox()
        Me.SSNITTextBox = New System.Windows.Forms.TextBox()
        Me.IncomeTaxTextBox = New System.Windows.Forms.TextBox()
        Me.GrossTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(14, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(949, 43)
        Me.Panel1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(945, 37)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "AFFORDABILITY AND INSTALLMENT CALCULATOR"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Loan Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Loan Duration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Interest Rate %"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Monthly Payment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total Payment"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TotalPaymentTextBox)
        Me.GroupBox1.Controls.Add(Me.MonthlyPaymentTextBox)
        Me.GroupBox1.Controls.Add(Me.InterestRateTextBox)
        Me.GroupBox1.Controls.Add(Me.DurationTextBox)
        Me.GroupBox1.Controls.Add(Me.loanAmountTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 250)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Instalment Calculator"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.TabStop = False
        Me.Button2.Text = "Calculate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(203, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.TabStop = False
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TotalPaymentTextBox
        '
        Me.TotalPaymentTextBox.Location = New System.Drawing.Point(199, 173)
        Me.TotalPaymentTextBox.Name = "TotalPaymentTextBox"
        Me.TotalPaymentTextBox.ReadOnly = True
        Me.TotalPaymentTextBox.Size = New System.Drawing.Size(97, 20)
        Me.TotalPaymentTextBox.TabIndex = 3
        Me.TotalPaymentTextBox.TabStop = False
        '
        'MonthlyPaymentTextBox
        '
        Me.MonthlyPaymentTextBox.Location = New System.Drawing.Point(199, 132)
        Me.MonthlyPaymentTextBox.Name = "MonthlyPaymentTextBox"
        Me.MonthlyPaymentTextBox.ReadOnly = True
        Me.MonthlyPaymentTextBox.Size = New System.Drawing.Size(97, 20)
        Me.MonthlyPaymentTextBox.TabIndex = 3
        Me.MonthlyPaymentTextBox.TabStop = False
        '
        'InterestRateTextBox
        '
        Me.InterestRateTextBox.Location = New System.Drawing.Point(199, 94)
        Me.InterestRateTextBox.Name = "InterestRateTextBox"
        Me.InterestRateTextBox.Size = New System.Drawing.Size(97, 20)
        Me.InterestRateTextBox.TabIndex = 3
        '
        'DurationTextBox
        '
        Me.DurationTextBox.Location = New System.Drawing.Point(199, 59)
        Me.DurationTextBox.Name = "DurationTextBox"
        Me.DurationTextBox.Size = New System.Drawing.Size(97, 20)
        Me.DurationTextBox.TabIndex = 3
        '
        'loanAmountTextBox
        '
        Me.loanAmountTextBox.Location = New System.Drawing.Point(199, 19)
        Me.loanAmountTextBox.Name = "loanAmountTextBox"
        Me.loanAmountTextBox.Size = New System.Drawing.Size(97, 20)
        Me.loanAmountTextBox.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Customer Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Staff ID"
        '
        'CustomernameTextBox
        '
        Me.CustomernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CustomernameTextBox.Location = New System.Drawing.Point(134, 61)
        Me.CustomernameTextBox.Multiline = True
        Me.CustomernameTextBox.Name = "CustomernameTextBox"
        Me.CustomernameTextBox.Size = New System.Drawing.Size(302, 29)
        Me.CustomernameTextBox.TabIndex = 5
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(134, 96)
        Me.CustomerIDTextBox.Multiline = True
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(136, 29)
        Me.CustomerIDTextBox.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ReceiptTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(468, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(495, 433)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Receipt"
        '
        'ReceiptTextBox
        '
        Me.ReceiptTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiptTextBox.Location = New System.Drawing.Point(16, 19)
        Me.ReceiptTextBox.Multiline = True
        Me.ReceiptTextBox.Name = "ReceiptTextBox"
        Me.ReceiptTextBox.ReadOnly = True
        Me.ReceiptTextBox.Size = New System.Drawing.Size(473, 408)
        Me.ReceiptTextBox.TabIndex = 6
        Me.ReceiptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.affordabilityTextBox)
        Me.GroupBox3.Controls.Add(Me.ThirdPartyTextBox)
        Me.GroupBox3.Controls.Add(Me.SSNITTextBox)
        Me.GroupBox3.Controls.Add(Me.IncomeTaxTextBox)
        Me.GroupBox3.Controls.Add(Me.GrossTextBox)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 400)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 198)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Affordability"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(199, 169)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(92, 169)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.TabStop = False
        Me.Button3.Text = "Calculate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'affordabilityTextBox
        '
        Me.affordabilityTextBox.Location = New System.Drawing.Point(217, 133)
        Me.affordabilityTextBox.Name = "affordabilityTextBox"
        Me.affordabilityTextBox.ReadOnly = True
        Me.affordabilityTextBox.Size = New System.Drawing.Size(109, 20)
        Me.affordabilityTextBox.TabIndex = 1
        '
        'ThirdPartyTextBox
        '
        Me.ThirdPartyTextBox.Location = New System.Drawing.Point(217, 102)
        Me.ThirdPartyTextBox.Name = "ThirdPartyTextBox"
        Me.ThirdPartyTextBox.Size = New System.Drawing.Size(109, 20)
        Me.ThirdPartyTextBox.TabIndex = 1
        '
        'SSNITTextBox
        '
        Me.SSNITTextBox.Location = New System.Drawing.Point(217, 74)
        Me.SSNITTextBox.Name = "SSNITTextBox"
        Me.SSNITTextBox.Size = New System.Drawing.Size(109, 20)
        Me.SSNITTextBox.TabIndex = 1
        '
        'IncomeTaxTextBox
        '
        Me.IncomeTaxTextBox.Location = New System.Drawing.Point(217, 46)
        Me.IncomeTaxTextBox.Name = "IncomeTaxTextBox"
        Me.IncomeTaxTextBox.Size = New System.Drawing.Size(109, 20)
        Me.IncomeTaxTextBox.TabIndex = 1
        '
        'GrossTextBox
        '
        Me.GrossTextBox.Location = New System.Drawing.Point(217, 16)
        Me.GrossTextBox.Name = "GrossTextBox"
        Me.GrossTextBox.Size = New System.Drawing.Size(109, 20)
        Me.GrossTextBox.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Affordability Amount"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Third-Party Ded."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "SSNIT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Income Tax"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gross"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(401, 533)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(162, 36)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Generate Receipt"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(569, 532)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 36)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Reset All"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(874, 537)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 27)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "<< Go Back"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(703, 532)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(131, 36)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Print Receipt"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 610)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Me.CustomernameTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TotalPaymentTextBox As TextBox
    Friend WithEvents MonthlyPaymentTextBox As TextBox
    Friend WithEvents InterestRateTextBox As TextBox
    Friend WithEvents DurationTextBox As TextBox
    Friend WithEvents loanAmountTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CustomernameTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ReceiptTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents affordabilityTextBox As TextBox
    Friend WithEvents ThirdPartyTextBox As TextBox
    Friend WithEvents SSNITTextBox As TextBox
    Friend WithEvents IncomeTaxTextBox As TextBox
    Friend WithEvents GrossTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
