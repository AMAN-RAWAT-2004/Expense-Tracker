Imports Microsoft.Data.SqlClient

Public Class register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim db As New db()
        Dim conn = db.OpenConn()

        Dim username As String = TextBox1.Text.Trim()
        Dim email As String = TextBox2.Text.Trim()
        Dim password As String = TextBox3.Text.Trim()

        ' Validation
        If username = "" Or email = "" Or password = "" Then
            MessageBox.Show("Please fill all fields")
            Exit Sub
        End If

        ' Hash password
        Dim hashedPassword As String = HashPassword(password)

        ' Check if user already exists
        Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Username=@Username OR Email=@Email"
        Dim checkCmd As New SqlCommand(checkQuery, conn)
        checkCmd.Parameters.AddWithValue("@Username", username)
        checkCmd.Parameters.AddWithValue("@Email", email)

        Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

        If exists > 0 Then
            MessageBox.Show("Username or Email already exists")
            Exit Sub
        End If

        ' Insert query (UPDATED 🔥)
        Dim query As String = "INSERT INTO Users (Username, Email, PasswordHash) 
                          VALUES (@Username, @Email, @PasswordHash)"

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@Username", username)
        cmd.Parameters.AddWithValue("@Email", email)
        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Registration Successful!")

            ' Go to login form
            Dim login As New Form1()
            login.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Maroon


    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave

        Button1.BackColor = Color.Maroon
        Button1.ForeColor = Color.White

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Form1.Show()
        'Me.Hide()

    End Sub
End Class