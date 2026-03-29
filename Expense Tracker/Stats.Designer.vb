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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
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
        Panel2.Location = New Point(0, 759)
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
        Button2.BackColor = Color.Transparent
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Maroon
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
        ' Stats
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1837, 846)
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
End Class
