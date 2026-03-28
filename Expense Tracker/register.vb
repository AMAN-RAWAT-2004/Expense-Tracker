Imports Microsoft.Data.SqlClient

Public Class register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim db As db = New db()
        Dim conn = db.OpenConn()

        Dim name As String = TextBox1.Text
        Dim email As String = TextBox2.Text
        Dim password As String = HashPassword(TextBox3.Text)


        If name = "" Or email = "" Or password = "" Then
            MessageBox.Show("Please fill all fields")
            Exit Sub
        End If


        Dim query As String = "INSERT INTO Users (name, email, password) VALUES (@name, @email, @password)"
        Dim cmd As New SqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@password", password)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Registration Successful!")

            ' Go back to login
            Dim login As New Form1
            login.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Form1.Show()
        'Me.Hide()

    End Sub
End Class