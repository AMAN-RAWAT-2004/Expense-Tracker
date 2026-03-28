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

        Dim db As db = New db()
        Dim conn = db.OpenConn()

        Dim email As String = TextBox1.Text
        Dim password As String = HashPassword(TextBox2.Text)

        If email = "" Or password = "" Then
            MessageBox.Show("Please fill all fields")
            Exit Sub
        End If

        Dim query As String = "SELECT Name, Email,Password FROM Users WHERE email=@email AND password=@password"
        Dim cmd As New SqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@password", password)

        Try
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                MessageBox.Show("Login Successful!")

                ' Create session object
                Dim session As New UserSession()

                session.UserName = reader("Name").ToString()
                session.UserEmail = reader("Email").ToString()

                ' Pass session to HomePage
                Dim dashboard As New HomePage(session)
                dashboard.Show()

                Me.Hide()
            Else
                MessageBox.Show("Invalid Email or Password")
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
