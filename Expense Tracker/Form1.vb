Imports Microsoft.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

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

        Me.Hide()
        register.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim db As New db()
        Dim conn = db.OpenConn()

        Dim email As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        ' Validation
        If email = "" Or password = "" Then
            MessageBox.Show("Please fill all fields")
            Exit Sub
        End If

        ' Hash password
        Dim hashedPassword As String = HashPassword(password)

        ' UPDATED QUERY 🔥
        Dim query As String = "SELECT Id, Username, Email 
                          FROM Users 
                          WHERE Email=@Email AND PasswordHash=@PasswordHash"

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@Email", email)
        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword)

        Try
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                MessageBox.Show("Login Successful!")

                ' Create session object
                Dim session As New UserSession()

                session.UserId = Convert.ToInt32(reader("Id"))   ' 🔥 important
                session.UserName = reader("Username").ToString()
                session.UserEmail = reader("Email").ToString()

                reader.Close()

                ' Open dashboard
                Dim dashboard As New HomePage(session)
                dashboard.Show()
                Me.Hide()

            Else
                MessageBox.Show("Invalid Email or Password")
                reader.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
