<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stats
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        LabelName = New Label()
        Panel2 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel7 = New Panel()
        Label4 = New Label()
        lblBalance = New Label()
        Panel6 = New Panel()
        lblExpense = New Label()
        Label6 = New Label()
        Panel5 = New Panel()
        Label5 = New Label()
        lblIncome = New Label()
        Panel4 = New Panel()
        dgvRecent = New DataGridView()
        Label7 = New Label()
        Button5 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvRecent, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightGray
        Label1.Font = New Font("Showcard Gothic", 17F)
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(127, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 36)
        Label1.TabIndex = 11
        Label1.Text = "Expense Tracker"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightGray
        PictureBox1.BackgroundImage = My.Resources.Resources.download__2__removebg_preview
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(47, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(86, 87)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Maroon
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1600, 31)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(2, 1, 2, 1)
        Button1.Size = New Size(100, 41)
        Button1.TabIndex = 8
        Button1.Text = "Logout"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.BackColor = Color.LightGray
        LabelName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LabelName.Location = New Point(1468, 37)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(114, 28)
        LabelName.TabIndex = 6
        LabelName.Text = "LabelName"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightGray
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 1088)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1837, 87)
        Panel2.TabIndex = 15
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.Maroon
        Button4.Location = New Point(1428, 0)
        Button4.Name = "Button4"
        Button4.Size = New Size(138, 87)
        Button4.TabIndex = 2
        Button4.Text = "Accounts"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Maroon
        Button3.Location = New Point(228, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(138, 87)
        Button3.TabIndex = 1
        Button3.Text = "Reports"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Maroon
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(819, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 87)
        Button2.TabIndex = 0
        Button2.Text = "Stats"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(LabelName)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1837, 87)
        Panel1.TabIndex = 14
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Panel7)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Label3)
        Panel3.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic)
        Panel3.Location = New Point(445, 159)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(917, 800)
        Panel3.TabIndex = 16
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(Label4)
        Panel7.Controls.Add(lblBalance)
        Panel7.Location = New Point(19, 60)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(877, 135)
        Panel7.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(13, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(218, 35)
        Label4.TabIndex = 0
        Label4.Text = "Current Balance :"
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Location = New Point(24, 69)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(140, 35)
        lblBalance.TabIndex = 1
        lblBalance.Text = "lblBalance"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(lblExpense)
        Panel6.Controls.Add(Label6)
        Panel6.Location = New Point(465, 219)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(431, 145)
        Panel6.TabIndex = 6
        ' 
        ' lblExpense
        ' 
        lblExpense.AutoSize = True
        lblExpense.Location = New Point(34, 68)
        lblExpense.Name = "lblExpense"
        lblExpense.Size = New Size(140, 35)
        lblExpense.TabIndex = 3
        lblExpense.Text = "lblExpense"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(20, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(202, 35)
        Label6.TabIndex = 2
        Label6.Text = "Total Expenses :"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(lblIncome)
        Panel5.Location = New Point(19, 219)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(431, 145)
        Panel5.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(182, 35)
        Label5.TabIndex = 1
        Label5.Text = "Total Income :"
        ' 
        ' lblIncome
        ' 
        lblIncome.AutoSize = True
        lblIncome.Location = New Point(24, 68)
        lblIncome.Name = "lblIncome"
        lblIncome.Size = New Size(131, 35)
        lblIncome.TabIndex = 2
        lblIncome.Text = "lblIncome"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(dgvRecent)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Button5)
        Panel4.Location = New Point(19, 385)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(872, 390)
        Panel4.TabIndex = 4
        ' 
        ' dgvRecent
        ' 
        dgvRecent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRecent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecent.GridColor = Color.Black
        dgvRecent.Location = New Point(28, 74)
        dgvRecent.Name = "dgvRecent"
        dgvRecent.RowHeadersWidth = 51
        dgvRecent.Size = New Size(816, 297)
        dgvRecent.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(13, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(264, 35)
        Label7.TabIndex = 2
        Label7.Text = "Recent Transactions :"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Maroon
        Button5.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(684, 14)
        Button5.Name = "Button5"
        Button5.Size = New Size(171, 47)
        Button5.TabIndex = 18
        Button5.Text = "Add Transactions"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(32, 2)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 46)
        Label3.TabIndex = 0
        Label3.Text = "Overview"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 17
        Label2.Text = "Label2"
        ' 
        ' Stats
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1837, 1175)
        Controls.Add(Label2)
        Controls.Add(Panel3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Stats"
        Text = "Stats"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvRecent, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblExpense As Label
    Friend WithEvents lblIncome As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents dgvRecent As DataGridView
End Class
