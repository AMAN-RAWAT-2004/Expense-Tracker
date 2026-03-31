Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class transactionForm
    Private currentUser As UserSession

    ' ✅ Category lists
    Dim expenseCategories As String() = {
        "Food", "Travel", "Bills", "Shopping", "Entertainment", "Other"
    }

    Dim incomeCategories As String() = {
        "Salary", "Business", "Freelance", "Gift", "Other"
    }

    Public Sub New(user As UserSession)
        InitializeComponent()
        currentUser = user
    End Sub

    Private Sub transactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If currentUser IsNot Nothing Then
            LabelName.Text = currentUser.UserName
            Label3.Text = currentUser.UserName
        Else
            MessageBox.Show("Session expired")
        End If

        ' ✅ Setup Type dropdown
        cmbType.Items.Clear()
        cmbType.Items.AddRange(New String() {"Income", "Expense"})
        cmbType.SelectedIndex = 0

    End Sub

    ' ✅ 🔥 Dynamic Category Logic
    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged

        cmbCategory.Items.Clear()

        If cmbType.Text = "Expense" Then
            cmbCategory.Items.AddRange(expenseCategories)

        ElseIf cmbType.Text = "Income" Then
            cmbCategory.Items.AddRange(incomeCategories)
        End If

        If cmbCategory.Items.Count > 0 Then
            cmbCategory.SelectedIndex = 0
        End If

    End Sub

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As New Form1()
        login.Show()
        Me.Hide()
    End Sub

    ' 🎨 Button hover effect
    Private Sub AddTransactionBTN_MouseHover(sender As Object, e As EventArgs) Handles AddTransactionBTN.MouseHover
        AddTransactionBTN.BackColor = Color.Maroon
        AddTransactionBTN.ForeColor = Color.White
    End Sub

    Private Sub AddTransactionBTN_MouseLeave(sender As Object, e As EventArgs) Handles AddTransactionBTN.MouseLeave
        AddTransactionBTN.BackColor = Color.White
        AddTransactionBTN.ForeColor = Color.Maroon
    End Sub

    ' ✅ 🔥 FINAL DB INSERT LOGIC
    Private Sub AddTransactionBTN_Click(sender As Object, e As EventArgs) Handles AddTransactionBTN.Click

        ' ✅ Validation
        If TextBox1.Text = "" Or cmbType.Text = "" Or cmbCategory.Text = "" Then
            MessageBox.Show("Please fill all fields")
            Return
        End If

        Dim amount As Decimal
        If Not Decimal.TryParse(TextBox1.Text, amount) Then
            MessageBox.Show("Enter valid amount")
            Return
        End If

        Try
            Dim database As New db()
            Dim conn As SqlConnection = database.OpenConn()

            Dim query As String = "
            INSERT INTO Transactions (UserId, Amount, Category, Type, Date, Description)
            VALUES (@uid, @amt, @cat, @type, @date, @desc)"

            Using cmd As New SqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@uid", currentUser.UserId)
                cmd.Parameters.AddWithValue("@amt", amount)
                cmd.Parameters.AddWithValue("@cat", cmbCategory.Text)
                cmd.Parameters.AddWithValue("@type", cmbType.Text)
                cmd.Parameters.AddWithValue("@date", Date.Now)
                cmd.Parameters.AddWithValue("@desc", TextBox2.Text)

                cmd.ExecuteNonQuery()
            End Using

            database.CloseConnection()

            MessageBox.Show("Transaction Added Successfully ✅")

            ClearFields()

            Dim stats As New Stats(currentUser)
            stats.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    ' ✅ Clear form after insert
    Private Sub ClearFields()
        TextBox1.Clear()
        cmbCategory.SelectedIndex = -1
        cmbType.SelectedIndex = 0
        TextBox2.Clear()
        'Date.Value = DateTime.Now
    End Sub

End Class