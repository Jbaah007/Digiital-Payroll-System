Public Class Form4
    Dim duration As Integer
    Dim imonthlypayment, iTotalPayment As String
    Dim InterestRate, monthlyInterestRate, LoanAmount, MonthlyPayment, TotalPayment As Double

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GrossTextBox.Text = ""
        IncomeTaxTextBox.Text = ""
        SSNITTextBox.Text = ""
        ThirdPartyTextBox.Text = ""
        affordabilityTextBox.Text = ""

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        loanAmountTextBox.Text = ""
        DurationTextBox.Text = ""
        InterestRateTextBox.Text = ""
        MonthlyPaymentTextBox.Text = ""
        TotalPaymentTextBox.Text = ""
        GrossTextBox.Text = ""
        IncomeTaxTextBox.Text = ""
        SSNITTextBox.Text = ""
        ThirdPartyTextBox.Text = ""
        affordabilityTextBox.Text = ""
        CustomerIDTextBox.Text = ""
        CustomernameTextBox.Text = ""
    End Sub

    Private Sub numbersOnly(sender As Object, e As KeyPressEventArgs) Handles ThirdPartyTextBox.KeyPress, SSNITTextBox.KeyPress, MyBase.KeyPress, loanAmountTextBox.KeyPress, IncomeTaxTextBox.KeyPress, GrossTextBox.KeyPress, DurationTextBox.KeyPress, CustomerIDTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CustomerIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerIDTextBox.TextChanged

    End Sub

    Private Sub loanAmountTextBox_TextChanged(sender As Object, e As EventArgs) Handles loanAmountTextBox.TextChanged

    End Sub

    Private Sub DurationTextBox_TextChanged(sender As Object, e As EventArgs) Handles DurationTextBox.TextChanged

    End Sub

    Private Sub InterestRateTextBox_TextChanged(sender As Object, e As EventArgs) Handles InterestRateTextBox.TextChanged

    End Sub

    Private Sub GrossTextBox_TextChanged(sender As Object, e As EventArgs) Handles GrossTextBox.TextChanged

    End Sub

    Private Sub IncomeTaxTextBox_TextChanged(sender As Object, e As EventArgs) Handles IncomeTaxTextBox.TextChanged

    End Sub

    Private Sub SSNITTextBox_TextChanged(sender As Object, e As EventArgs) Handles SSNITTextBox.TextChanged

    End Sub

    Private Sub ThirdPartyTextBox_TextChanged(sender As Object, e As EventArgs) Handles ThirdPartyTextBox.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReceiptTextBox.AppendText(vbTab + "Loan Management System" + vbNewLine)
        ReceiptTextBox.AppendText(vbTab + vbTab + "-------------------------------------------------------" + vbNewLine)
        ReceiptTextBox.AppendText("--" + vbTab + CustomernameTextBox.Text + vbNewLine)
        ReceiptTextBox.AppendText("Staff ID" + vbTab + CustomerIDTextBox.Text + vbNewLine)
        ReceiptTextBox.AppendText("Loan Amount:" + vbTab + loanAmountTextBox.Text + vbNewLine)
        ReceiptTextBox.AppendText("Loan Duration (years) " + vbTab + DurationTextBox.Text + vbNewLine)
        ReceiptTextBox.AppendText("Interest Rate:" + vbTab + vbTab + InterestRateTextBox.Text + vbNewLine)
        ReceiptTextBox.AppendText("Monthly Payment:" + vbTab + vbTab + MonthlyPaymentTextBox.Text + vbNewLine)
        ReceiptTextBox.AppendText("Total Payment" + vbTab + vbTab + vbTab + TotalPaymentTextBox.Text + vbNewLine)
        ReceiptTextBox.AppendText("-----------------------------------------------------------" + vbNewLine)
        ReceiptTextBox.AppendText("----------------------------Thank You----------------------" + vbNewLine)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(ReceiptTextBox.Text, ReceiptTextBox.Font, Brushes.Black, 100, 100)
    End Sub

    Dim gross, incomeTax, ssnit, thirdpartyDed, affordabilityAmnt As Double
    Dim iaffordabilityAmnt As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        gross = Convert.ToDecimal(GrossTextBox.Text)
        incomeTax = Convert.ToDecimal(IncomeTaxTextBox.Text)
        ssnit = Convert.ToDecimal(SSNITTextBox.Text)
        thirdpartyDed = Convert.ToDecimal(ThirdPartyTextBox.Text)

        affordabilityAmnt = ((((gross - (incomeTax + ssnit)) / 2) - (thirdpartyDed)) - 10)

        iaffordabilityAmnt = Convert.ToString(affordabilityAmnt)
        iaffordabilityAmnt = FormatCurrency(iaffordabilityAmnt)
        affordabilityTextBox.Text = (iaffordabilityAmnt)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loanAmountTextBox.Text = ""
        DurationTextBox.Text = ""
        InterestRateTextBox.Text = ""
        MonthlyPaymentTextBox.Text = ""
        TotalPaymentTextBox.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InterestRate = Convert.ToDouble(InterestRateTextBox.Text)
        monthlyInterestRate = InterestRate / 1200
        duration = Convert.ToInt32(DurationTextBox.Text)
        LoanAmount = Convert.ToDouble(loanAmountTextBox.Text)

        MonthlyPayment = LoanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, duration * 12))

        imonthlypayment = Convert.ToString(MonthlyPayment)
        imonthlypayment = FormatCurrency(imonthlypayment)
        MonthlyPaymentTextBox.Text = (imonthlypayment)

        TotalPayment = MonthlyPayment * duration * 12
        iTotalPayment = FormatCurrency(TotalPayment)
        TotalPaymentTextBox.Text = (iTotalPayment)

        loanAmountTextBox.Text = FormatCurrency(loanAmountTextBox.Text)




    End Sub
End Class