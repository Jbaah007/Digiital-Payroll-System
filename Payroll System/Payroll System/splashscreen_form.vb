Public Class splashscreen_form

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar.Increment(1)
        If ProgressBar.Value = 100 Then
            Timer1.Stop()
            Form1.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub splashscreen_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

