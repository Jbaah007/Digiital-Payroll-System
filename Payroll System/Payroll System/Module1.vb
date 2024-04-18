Imports MySql.Data.MySqlClient

Module Module1
    Public constring As MySqlConnection
    Public cm As MySqlCommand

    Sub connection()

        Try
            constring = New MySqlConnection("server=localhost; port=3306; database = database; username=root")
            constring.Open()
            MsgBox("connected to database succesfully")


        Catch ex As Exception
            MsgBox("connnection failed")

        End Try
    End Sub
End Module
