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

        Label5.Text = DateTime.Now.ToString("MMMM yyyy").ToUpper()
    End Sub


    Private Sub LoadBarChart()

        Dim incomeTotal As Double = 0
        Dim expenseTotal As Double = 0

        Try
            Dim database As New db()
            Dim conn As SqlConnection = database.OpenConn()

            ' Income
            Dim cmdIncome As New SqlCommand("
                SELECT ISNULL(SUM(Amount),0)
                FROM Transactions
                WHERE UserId=@uid 
                AND Type='Income'
                AND MONTH(Date)=MONTH(GETDATE())
                AND YEAR(Date)=YEAR(GETDATE())", conn)

            cmdIncome.Parameters.AddWithValue("@uid", currentUser.UserId)
            incomeTotal = Convert.ToDouble(cmdIncome.ExecuteScalar())

            ' Expense
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

        ' 📊 SERIES
        Dim incomeSeries As New ColumnSeries(Of Double)
        incomeSeries.Name = "Income"
        incomeSeries.Values = New Double() {incomeTotal, 0}
        incomeSeries.Fill = New SolidColorPaint(SKColors.SeaGreen)
        incomeSeries.Rx = 8
        incomeSeries.Ry = 8

        Dim expenseSeries As New ColumnSeries(Of Double)
        expenseSeries.Name = "Expense"
        expenseSeries.Values = New Double() {0, expenseTotal}
        expenseSeries.Fill = New SolidColorPaint(SKColors.IndianRed)
        expenseSeries.Rx = 8
        expenseSeries.Ry = 8

        CartesianChart1.Series = New ISeries() {incomeSeries, expenseSeries}

        ' 📊 X AXIS (SAFE)
        Dim xAxis As New Axis()
        xAxis.Labels = New String() {"Income", "Expense"}

        CartesianChart1.XAxes = New Axis() {xAxis}

        ' 📈 Y AXIS (SAFE + GRID)
        Dim maxValue As Double = Math.Max(incomeTotal, expenseTotal)

        Dim yAxis As New Axis()
        yAxis.MinLimit = 0
        yAxis.MaxLimit = maxValue * 1.2

        ' Grid lines
        yAxis.SeparatorsPaint = New SolidColorPaint(SKColors.LightGray)

        CartesianChart1.YAxes = New Axis() {yAxis}

    End Sub

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

                ' Labels
                pieSeries.DataLabelsPaint = New SolidColorPaint(SKColors.Black)
                pieSeries.DataLabelsSize = 14

                pieSeries.DataLabelsFormatter = Function(point As LiveChartsCore.Kernel.ChartPoint)
                                                    Return category & " " & vbLf & " " &
                                                           Math.Round(point.StackedValue.Share * 100, 1) & "%"
                                                End Function

                seriesList.Add(pieSeries)
            End While

            database.CloseConnection()

        Catch ex As Exception
            MessageBox.Show("Error (Pie Chart): " & ex.Message)
        End Try

        PieChart1.Series = seriesList.ToArray()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As New Form1
        login.Show()
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stats As New Stats(currentUser)
        stats.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ReportsPage As New Reports(currentUser)
        ReportsPage.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim home As New HomePage(currentUser)
        home.Show()
        Me.Hide()
    End Sub

End Class