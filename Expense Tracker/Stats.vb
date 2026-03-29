Public Class Stats

    Private currentUser As UserSession

    Public Sub New(user As UserSession)
        InitializeComponent()
        currentUser = user
    End Sub

    Private Sub Stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If currentUser IsNot Nothing Then
            LabelName.Text = currentUser.UserName
            'LoadStats()
        Else
            MessageBox.Show("Session expired")
        End If

    End Sub

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As New Form1()
        login.Show()
        Me.Hide()
    End Sub

End Class