


Public Class Form1




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ex As DialogResult

        ex = MessageBox.Show("Are you sure you want to exit?", "Payroll System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)


        If ex = DialogResult.Yes Then
            Me.Close()

        End If



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Enter username and password")
        ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "admin" Then
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Username and Password")

        End If



    End Sub


End Class
