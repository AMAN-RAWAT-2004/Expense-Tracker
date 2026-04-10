<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactionForm
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
        LabelName = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        AddTransactionBTN = New Button()
        Description = New Label()
        TextBox2 = New TextBox()
        Category = New Label()
        cmbCategory = New ComboBox()
        cmbType = New ComboBox()
        Type = New Label()
        Amount = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
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
        ' Button2
        ' 
        Button2.BackColor = Color.Maroon
        Button2.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(819, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(138, 87)
        Button2.TabIndex = 0
        Button2.Text = "Stats"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Maroon
        Button3.Location = New Point(228, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(138, 87)
        Button3.TabIndex = 1
        Button3.Text = "Reports"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.Maroon
        Button4.Location = New Point(1428, 0)
        Button4.Name = "Button4"
        Button4.Size = New Size(138, 87)
        Button4.TabIndex = 2
        Button4.Text = "Monthly expenses"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightGray
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 1028)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1837, 87)
        Panel2.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightGray
        Label1.Font = New Font("Showcard Gothic", 17.0F)
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.Controls.Add(AddTransactionBTN)
        Panel3.Controls.Add(Description)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Category)
        Panel3.Controls.Add(cmbCategory)
        Panel3.Controls.Add(cmbType)
        Panel3.Controls.Add(Type)
        Panel3.Controls.Add(Amount)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(548, 115)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(791, 882)
        Panel3.TabIndex = 16
        ' 
        ' AddTransactionBTN
        ' 
        AddTransactionBTN.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddTransactionBTN.ForeColor = Color.Maroon
        AddTransactionBTN.Location = New Point(322, 679)
        AddTransactionBTN.Name = "AddTransactionBTN"
        AddTransactionBTN.Size = New Size(207, 48)
        AddTransactionBTN.TabIndex = 19
        AddTransactionBTN.Text = "Add Transaction"
        AddTransactionBTN.UseVisualStyleBackColor = True
        ' 
        ' Description
        ' 
        Description.AutoSize = True
        Description.BackColor = Color.Transparent
        Description.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Description.ForeColor = Color.White
        Description.Location = New Point(108, 493)
        Description.Name = "Description"
        Description.Size = New Size(115, 28)
        Description.TabIndex = 18
        Description.Text = "Description"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(246, 457)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "   transaction details..."
        TextBox2.Size = New Size(415, 132)
        TextBox2.TabIndex = 17
        ' 
        ' Category
        ' 
        Category.AutoSize = True
        Category.BackColor = Color.Transparent
        Category.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Category.ForeColor = Color.White
        Category.Location = New Point(108, 394)
        Category.Name = "Category"
        Category.Size = New Size(94, 28)
        Category.TabIndex = 16
        Category.Text = "Category"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(246, 394)
        cmbCategory.MaxDropDownItems = 2
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(415, 28)
        cmbCategory.TabIndex = 15
        ' 
        ' cmbType
        ' 
        cmbType.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbType.FormattingEnabled = True
        cmbType.Location = New Point(246, 328)
        cmbType.MaxDropDownItems = 2
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(415, 28)
        cmbType.TabIndex = 14
        ' 
        ' Type
        ' 
        Type.AutoSize = True
        Type.BackColor = Color.Transparent
        Type.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Type.ForeColor = Color.White
        Type.Location = New Point(108, 324)
        Type.Name = "Type"
        Type.Size = New Size(61, 28)
        Type.TabIndex = 13
        Type.Text = "Type "
        ' 
        ' Amount
        ' 
        Amount.AutoSize = True
        Amount.BackColor = Color.Transparent
        Amount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Amount.ForeColor = Color.White
        Amount.Location = New Point(108, 262)
        Amount.Name = "Amount"
        Amount.Size = New Size(92, 28)
        Amount.TabIndex = 12
        Amount.Text = "Amount "
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(246, 263)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "   eg.800 Rs..."
        TextBox1.Size = New Size(415, 27)
        TextBox1.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Rounded MT Bold", 24F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(129, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(270, 46)
        Label4.TabIndex = 10
        Label4.Text = "👤Welcome ,"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Rounded MT Bold", 24F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(395, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(266, 46)
        Label3.TabIndex = 9
        Label3.Text = "CurrentUser"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(261, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(263, 41)
        Label2.TabIndex = 0
        Label2.Text = "Add Transactions"
        ' 
        ' transactionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1837, 1115)
        Controls.Add(Panel3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "transactionForm"
        Text = "transactionForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Amount As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents Type As Label
    Friend WithEvents Category As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents AddTransactionBTN As Button
    Friend WithEvents Description As Label
    Friend WithEvents TextBox2 As TextBox
End Class
