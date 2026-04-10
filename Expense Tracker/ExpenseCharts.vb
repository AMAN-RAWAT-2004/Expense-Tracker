Imports System.Data.SqlClient
Imports LiveChartsCore
Imports LiveChartsCore.SkiaSharpView
Imports LiveChartsCore.SkiaSharpView.Painting
Imports Microsoft.Data.SqlClient
Imports SkiaSharp

Public Class ExpenseCharts

    Private currentUser As UserSession

    Public Sub New(user As UserSession)
        InitializeComponent()
        currentUser = user
    End Sub

    Private Sub ExpenseCharts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelName.Text = currentUser.UserName

        LoadBarChart()
        LoadPieChart()

        ' 📅 Show current month
        Label5.Text = DateTime.Now.ToString("MMMM yyyy").ToUpper()
    End Sub

    ' 📊 BAR CHART → Income vs Expense (CURRENT MONTH)
    Private Sub LoadBarChart()

        Dim incomeTotal As Double = 0
        Dim expenseTotal As Double = 0

        Try
            Dim database As New db()
            Dim conn As SqlConnection = database.OpenConn()

            ' 🔵 Income
            Dim cmdIncome As New SqlCommand("
                SELECT ISNULL(SUM(Amount),0)
                FROM Transactions
                WHERE UserId=@uid 
                AND Type='Income'
                AND MONTH(Date)=MONTH(GETDATE())
                AND YEAR(Date)=YEAR(GETDATE())", conn)

            cmdIncome.Parameters.AddWithValue("@uid", currentUser.UserId)
            incomeTotal = Convert.ToDouble(cmdIncome.ExecuteScalar())

            ' 🔴 Expense
            Dim cmdExpense As New SqlCommand("
                SELECT ISNULL(SUM(Amount),0)
                FROM Transactions
                WHERE UserId=@uid 
                AND Type='Expense'
                AND MONTH(Date)=MONTH(GETDATE())
                AND YEAR(Date)=YEAR(GETDATE())", conn)

            cmdExpense.Parameters.AddWithValue("@uid", currentUser.UserId)
            expenseTotal = Convert.ToDouble(cmdExpense.ExecuteScalar())

            database.CloseConnection()

        Catch ex As Exception
            MessageBox.Show("Error (Bar Chart): " & ex.Message)
        End Try

        ' 🎨 Create series manually (fix for VB.NET error)
        Dim incomeSeries As New ColumnSeries(Of Double)
        incomeSeries.Name = "Income"
        incomeSeries.Values = New Double() {incomeTotal, 0}
        incomeSeries.Fill = New SolidColorPaint(SKColors.DodgerBlue)

        Dim expenseSeries As New ColumnSeries(Of Double)
        expenseSeries.Name = "Expense"
        expenseSeries.Values = New Double() {0, expenseTotal}
        expenseSeries.Fill = New SolidColorPaint(SKColors.IndianRed)

        CartesianChart1.Series = New ISeries() {incomeSeries, expenseSeries}

        CartesianChart1.XAxes = New Axis() {
    New Axis With {
        .Labels = New String() {"Income", "Expense"}
    }
}

    End Sub

    ' 🥧 PIE CHART → Expense Categories (CURRENT MONTH)
    Private Sub LoadPieChart()

        Dim seriesList As New List(Of ISeries)

        Try
            Dim database As New db()
            Dim conn As SqlConnection = database.OpenConn()

            Dim cmd As New SqlCommand("
                SELECT Category, SUM(Amount) as Total
                FROM Transactions
                WHERE UserId=@uid 
                AND Type='Expense'
                AND MONTH(Date)=MONTH(GETDATE())
                AND YEAR(Date)=YEAR(GETDATE())
                GROUP BY Category", conn)

            cmd.Parameters.AddWithValue("@uid", currentUser.UserId)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim category As String = reader("Category").ToString()
                Dim total As Double = Convert.ToDouble(reader("Total"))

                Dim pieSeries As New PieSeries(Of Double)
                pieSeries.Name = category
                pieSeries.Values = New Double() {total}

                seriesList.Add(pieSeries)
            End While

            database.CloseConnection()

        Catch ex As Exception
            MessageBox.Show("Error (Pie Chart): " & ex.Message)
        End Try

        PieChart1.Series = seriesList.ToArray()

    End Sub

    ' 🚪 Logout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As New Form1
        login.Show()
        Me.Close()
    End Sub

    ' 📊 Go to Stats Page
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stats As New Stats(currentUser)
        stats.Show()
        Me.Hide()
    End Sub

End Class