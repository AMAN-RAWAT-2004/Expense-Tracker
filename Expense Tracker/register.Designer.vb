<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.download__1_
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(733, 225)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(420, 636)
        Panel1.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gainsboro
        TextBox1.Location = New Point(93, 167)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "enter your name..."
        TextBox1.Size = New Size(231, 27)
        TextBox1.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.Maroon
        Label7.Location = New Point(91, 144)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 20)
        Label7.TabIndex = 9
        Label7.Text = "Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(150, 375)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 20)
        Label5.TabIndex = 7
        Label5.Text = "Already have an "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(148, 390)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 20)
        Label6.TabIndex = 8
        Label6.Text = "account?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Location = New Point(211, 389)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(43, 20)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "login"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Maroon
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(154, 323)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 38)
        Button1.TabIndex = 5
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Impact", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Maroon
        Label4.Location = New Point(151, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 42)
        Label4.TabIndex = 4
        Label4.Text = "Register"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Gainsboro
        TextBox3.Location = New Point(93, 278)
        TextBox3.Name = "TextBox3"
        TextBox3.PasswordChar = "*"c
        TextBox3.PlaceholderText = "enter your password..."
        TextBox3.Size = New Size(231, 27)
        TextBox3.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.Maroon
        Label3.Location = New Point(91, 255)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gainsboro
        TextBox2.Location = New Point(92, 220)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "enter your email..."
        TextBox2.Size = New Size(231, 27)
        TextBox2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(90, 197)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 20)
        Label2.TabIndex = 0
        Label2.Text = "Email"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.download__2__removebg_preview
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(55, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(86, 87)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 17F)
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(135, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 36)
        Label1.TabIndex = 4
        Label1.Text = "Expense Tracker"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1763, 846)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "register"
        Text = "register"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
End Class
