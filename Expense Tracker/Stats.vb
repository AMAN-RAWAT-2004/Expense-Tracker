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

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Button5.BackColor = Color.White
        Button5.ForeColor = Color.Maroon


    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.Maroon
        Button5.ForeColor = Color.White


    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button2.BackColor = Color.Maroon
        Button2.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim AddTransaction As New transactionForm(currentUser)
        AddTransaction.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim home As New HomePage(currentUser)
        home.Show()
        Me.Hide()

    End Sub

    Private Sub lblBalance_Click(sender As Object, e As EventArgs) Handles lblBalance.Click

    End Sub

    Private Sub lblIncome_Click(sender As Object, e As EventArgs) Handles lblIncome.Click

    End Sub

    Private Sub lblExpense_Click(sender As Object, e As EventArgs) Handles lblExpense.Click

    End Sub
End Class