Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class Reports
    Private currentUser As UserSession

    ' Constructor
    Public Sub New(user As UserSession)
        InitializeComponent()
        currentUser = user
    End Sub
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelName.Text = currentUser.UserName
        'LabelEmail.Text = currentUser.UserEmail
        LoadTransactions()
        Label3.Text = DateTime.Now.ToString("MMMM yyyy").ToUpper()
    End Sub

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As New Form1
        login.Show()
        Close()
    End Sub
    Private Sub LoadTransactions()

        Try
            Dim database As New db()
            Dim conn As SqlConnection = database.OpenConn()

            Dim query As String = "
    SELECT 
        Amount,
        Type,
        Category,
        Date,
        Description
    FROM Transactions
    WHERE UserId = @uid
    AND MONTH(Date) = MONTH(GETDATE())
    AND YEAR(Date) = YEAR(GETDATE())
    ORDER BY Date DESC"

            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", currentUser.UserId)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)

            DataGridView1.DataSource = table

            ' 🟢 Format amount as currency
            DataGridView1.Columns("Amount").DefaultCellStyle.Format = "C"

            ' 📏 Auto size columns
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' 🎨 Color rows based on Type
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("Type").Value IsNot Nothing Then
                    If row.Cells("Type").Value.ToString() = "Expense" Then
                        row.DefaultCellStyle.ForeColor = Color.Red
                    Else
                        row.DefaultCellStyle.ForeColor = Color.Green
                    End If
                End If
            Next

            database.CloseConnection()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub StatsPage_Open(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stats As New Stats(currentUser)
        stats.Show()
        Me.Hide()
    End Sub

    Private Sub MonthlyExpensesPage_Opening(sender As Object, e As EventArgs) Handles Button4.Click
        Dim monthlyExpenses As New ExpenseCharts(currentUser)
        monthlyExpenses.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim home As New HomePage(currentUser)
        home.Show()
        Me.Hide()
    End Sub


End Class