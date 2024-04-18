Imports MySql.Data.MySqlClient

Public Class Form3

    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim id As Integer

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "server=localhost; port=3306; database = database; username=root; password = ''; convert zero datetime=true "
        If con.State = ConnectionState.Open Then
            constring.Close()
        End If
        con.Open()

        disp_data()






    End Sub

    Public Sub disp_data()

        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from customer"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CustomerNameTextBox.TextChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'SAVE

        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into customer values('" + CustomerNameTextBox.Text + "','" + CustomerIDTextBox.Text + "','" + DOBDateTimePicker.Text + "','" + DepartmentComboBox.Text + "','" + LoanAmountTextBox.Text + "','" + LoanTermComboBox.Text + "','" + LoanTypeComboBox.Text + "','" + LoanAppDateDateTimePicker.Text + "','" + MonthlyInsatalmentTextBox.Text + "')"
        cmd.ExecuteNonQuery()

        CustomerNameTextBox.Text = ""
        CustomerIDTextBox.Text = ""
        DOBDateTimePicker.Text = ""
        DepartmentComboBox.Text = ""
        LoanTermComboBox.Text = ""
        LoanAmountTextBox.Text = ""
        LoanTypeComboBox.Text = ""
        LoanAppDateDateTimePicker.Text = ""
        MonthlyInsatalmentTextBox.Text = ""

        disp_data()

        MessageBox.Show("record saved successfully")




    End Sub

    'SEARCH

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from customer where id = '" + CustomerIDTextBox.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()




        DataGridView1.SelectedCells.Item(0).Value.ToString()
        cmd = con.CreateCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from customer where ID = " & CustomerIDTextBox.Text & ""
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read

            CustomerNameTextBox.Text = dr.GetString(1).ToString()
            CustomerIDTextBox.Text = dr.GetString(2).ToString()
            DOBDateTimePicker.Text = dr.GetString(3).ToString()
            DepartmentComboBox.Text = dr.GetString(4).ToString()
            LoanAmountTextBox.Text = dr.GetString(5).ToString()
            LoanTermComboBox.Text = dr.GetString(6).ToString()
            LoanTypeComboBox.Text = dr.GetString(7).ToString()
            LoanAppDateDateTimePicker.Text = dr.GetString(8).ToString()
            MonthlyInsatalmentTextBox.Text = dr.GetString(9).ToString()



        End While

        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'RESET
        CustomerNameTextBox.Text = ""
        CustomerIDTextBox.Text = ""
        DOBDateTimePicker.Text = ""
        DepartmentComboBox.Text = ""
        LoanTermComboBox.Text = ""
        LoanAmountTextBox.Text = ""
        LoanTypeComboBox.Text = ""
        LoanAppDateDateTimePicker.Text = ""
        MonthlyInsatalmentTextBox.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Hide()
        Form2.Show()



    End Sub

    Private Sub numbersOnly(sender As Object, e As KeyPressEventArgs) Handles LoanAmountTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class