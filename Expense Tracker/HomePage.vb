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

End Class