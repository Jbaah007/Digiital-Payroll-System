
Imports MySql.Data.MySqlClient
Public Class Form6


    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim id As Integer
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.ConnectionString = "server=localhost; port=3306; database = database; username=root; password = ''; convert zero datetime=true "
        If con.State = ConnectionState.Open Then
            constring.Close()
        End If
        con.Open()


        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from customer"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

    End Sub
End Class