Public Class HomePage
    Private currentUser As UserSession

    ' Constructor
    Public Sub New(user As UserSession)
        InitializeComponent()
        currentUser = user
    End Sub
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelName.Text = currentUser.UserName
        'LabelEmail.Text = currentUser.UserEmail
    End Sub

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As New Form1
        login.Show()
        Close()
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Maroon
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Maroon
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stats As New Stats(currentUser)
        stats.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.Maroon
        Button2.ForeColor = Color.White
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Transparent
        Button2.ForeColor = Color.Maroon

    End Sub
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.Maroon
        Button3.ForeColor = Color.White
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.Transparent
        Button3.ForeColor = Color.Maroon

    End Sub
    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.BackColor = Color.Maroon
        Button4.ForeColor = Color.White
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.Transparent
        Button4.ForeColor = Color.Maroon

    End Sub
End Class