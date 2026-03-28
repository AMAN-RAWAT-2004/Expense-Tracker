<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        LabelName = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightGray
        PictureBox1.BackgroundImage = My.Resources.Resources.download__2__removebg_preview
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(47, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(86, 87)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
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
        Label1.TabIndex = 3
        Label1.Text = "Expense Tracker"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Silver
        Label2.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(424, 385)
        Label2.Name = "Label2"
        Label2.Size = New Size(1012, 62)
        Label2.TabIndex = 5
        Label2.Text = ChrW(8220) & "Track Every Expense. Build a Better Future." & ChrW(8221)
        Label2.TextAlign = ContentAlignment.MiddleCenter
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
        Panel1.TabIndex = 9
        ' 
        ' HomePage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1837, 846)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "HomePage"
        Text = "HomePage"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
