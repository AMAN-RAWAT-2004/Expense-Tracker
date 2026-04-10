Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Stats

    Private currentUser As UserSession

    Public Sub New(user As UserSession)
        InitializeComponent()
        currentUser = user
    End Sub

    Private Sub Stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If currentUser IsNot Nothing Then
            LabelName.Text = currentUser.UserName

            LoadSummary(currentUser.UserId)   ' 🔥 Income, Expense, Balance
            LoadRecent(currentUser.UserId)    ' 🔥 Recent Transactions

        Else
            MessageBox.Show("Session expired")
        End If

    End Sub

    '  LOAD SUMMARY (MONTHLY)
    Public Sub LoadSummary(userId As Integer)

        Dim database As New db()
        Dim conn As SqlConnection = database.OpenConn()

        Dim query As String = "
        SELECT 
            SUM(CASE WHEN Type='Income' THEN Amount ELSE 0 END) AS Income,
            SUM(CASE WHEN Type='Expense' THEN Amount ELSE 0 END) AS Expense
        FROM Transactions
        WHERE UserId=@uid 
        AND MONTH(Date)=MONTH(GETDATE()) 
        AND YEAR(Date)=YEAR(GETDATE())"

        Using cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", userId)

            Dim reader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim income As Decimal = If(IsDBNull(reader("Income")), 0, Convert.ToDecimal(reader("Income")))
                Dim expense As Decimal = If(IsDBNull(reader("Expense")), 0, Convert.ToDecimal(reader("Expense")))

                lblIncome.Text = "Income: ₹" & income
                lblExpense.Text = "Expense: ₹" & expense
                lblBalance.Text = "Balance: ₹" & (income - expense)

                ' 🎨 Color balance
                If (income - expense) >= 0 Then
                    lblBalance.ForeColor = Color.Green
                Else
                    lblBalance.ForeColor = Color.Red
                End If
            End If

        End Using

        database.CloseConnection()

    End Sub

    ' ===============================
    ' 📊 LOAD RECENT TRANSACTIONS
    ' ===============================
    Public Sub LoadRecent(userId As Integer)

        Dim database As New db()
        Dim conn As SqlConnection = database.OpenConn()

        Dim query As String = "
        SELECT TOP 5 Amount, Category, Type, Date
        FROM Transactions
        WHERE UserId=@uid
        ORDER BY Date DESC"

        Using cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", userId)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            dgvRecent.DataSource = table
        End Using

        database.CloseConnection()

        SetupGrid()

    End Sub

    '  GRID UI SETTINGS

    Private Sub SetupGrid()

        dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecent.ReadOnly = True
        dgvRecent.AllowUserToAddRows = False
        dgvRecent.RowHeadersVisible = False

        dgvRecent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRecent.GridColor = Color.LightGray

        ' Headers
        dgvRecent.EnableHeadersVisualStyles = False
        dgvRecent.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon
        dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        ' Rename columns
        dgvRecent.Columns("Amount").HeaderText = "Amount 💰"
        dgvRecent.Columns("Category").HeaderText = "Category"
        dgvRecent.Columns("Type").HeaderText = "Type"
        dgvRecent.Columns("Date").HeaderText = "Date"

        ' Format date
        dgvRecent.Columns("Date").DefaultCellStyle.Format = "dd MMM yyyy"

        ' Color rows
        For Each row As DataGridViewRow In dgvRecent.Rows
            If row.Cells("Type").Value.ToString() = "Income" Then
                row.DefaultCellStyle.ForeColor = Color.Green
            Else
                row.DefaultCellStyle.ForeColor = Color.Red
            End If
        Next

    End Sub


    '  NAVIGATION

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As New Form1()
        login.Show()
        Me.Hide()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim monthlyExpenses As New ExpenseCharts(currentUser)
        monthlyExpenses.Show()
        Me.Hide()

    End Sub
End Class