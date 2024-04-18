Public Class Form2

    Dim p As Double
    Dim t As Integer
    Dim r As Double


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ADDNEWLOANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDNEWLOANToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub AFFORDABILITYCALCULATORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AFFORDABILITYCALCULATORToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
        MessageBox.Show("logout successful")

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub SEARCHCUSTOMERINFOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEARCHCUSTOMERINFOToolStripMenuItem.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)


    End Sub
End Class