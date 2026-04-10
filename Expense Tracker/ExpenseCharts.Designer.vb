<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpenseCharts
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
        Dim SkDefaultLegend1 As LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend = New LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExpenseCharts))
        Dim Padding1 As LiveChartsCore.Drawing.Padding = New LiveChartsCore.Drawing.Padding()
        Dim SkDefaultTooltip1 As LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip = New LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip()
        Dim Padding2 As LiveChartsCore.Drawing.Padding = New LiveChartsCore.Drawing.Padding()
        Dim SkDefaultLegend2 As LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend = New LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend()
        Dim Padding3 As LiveChartsCore.Drawing.Padding = New LiveChartsCore.Drawing.Padding()
        Dim SkDefaultTooltip2 As LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip = New LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip()
        Dim Padding4 As LiveChartsCore.Drawing.Padding = New LiveChartsCore.Drawing.Padding()
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
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PieChart1 = New LiveChartsCore.SkiaSharpView.WinForms.PieChart()
        CartesianChart1 = New LiveChartsCore.SkiaSharpView.WinForms.CartesianChart()
        Label6 = New Label()
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
        ' Button4
        ' 
        Button4.BackColor = Color.Maroon
        Button4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(PieChart1)
        Panel3.Controls.Add(CartesianChart1)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(97, 93)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1640, 929)
        Panel3.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1279, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 31)
        Label5.TabIndex = 5
        Label5.Text = "Month"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(642, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(400, 60)
        Label4.TabIndex = 4
        Label4.Text = "Monthly Expenses"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(1070, 770)
        Label3.Name = "Label3"
        Label3.Size = New Size(330, 35)
        Label3.TabIndex = 3
        Label3.Text = "Overall Transactions Chart"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(379, 775)
        Label2.Name = "Label2"
        Label2.Size = New Size(181, 35)
        Label2.TabIndex = 2
        Label2.Text = "Expense Chart"
        ' 
        ' PieChart1
        ' 
        PieChart1.AutoUpdateEnabled = True
        PieChart1.BackColor = Color.White
        PieChart1.ChartTheme = Nothing
        PieChart1.ForeColor = Color.Black
        SkDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000")
        SkDefaultLegend1.Content = Nothing
        SkDefaultLegend1.IsValid = False
        SkDefaultLegend1.Opacity = 1F
        Padding1.Bottom = 0F
        Padding1.Left = 0F
        Padding1.Right = 0F
        Padding1.Top = 0F
        SkDefaultLegend1.Padding = Padding1
        SkDefaultLegend1.RemoveOnCompleted = False
        SkDefaultLegend1.RotateTransform = 0F
        SkDefaultLegend1.X = 0F
        SkDefaultLegend1.Y = 0F
        PieChart1.Legend = SkDefaultLegend1
        PieChart1.Location = New Point(276, 355)
        PieChart1.Name = "PieChart1"
        PieChart1.Size = New Size(400, 400)
        PieChart1.TabIndex = 1
        SkDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000")
        SkDefaultTooltip1.Content = Nothing
        SkDefaultTooltip1.IsValid = False
        SkDefaultTooltip1.Opacity = 1F
        Padding2.Bottom = 0F
        Padding2.Left = 0F
        Padding2.Right = 0F
        Padding2.Top = 0F
        SkDefaultTooltip1.Padding = Padding2
        SkDefaultTooltip1.RemoveOnCompleted = False
        SkDefaultTooltip1.RotateTransform = 0F
        SkDefaultTooltip1.Wedge = 10
        SkDefaultTooltip1.X = 0F
        SkDefaultTooltip1.Y = 0F
        PieChart1.Tooltip = SkDefaultTooltip1
        PieChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000")
        ' 
        ' CartesianChart1
        ' 
        CartesianChart1.AutoUpdateEnabled = True
        CartesianChart1.BackColor = Color.White
        CartesianChart1.ChartTheme = Nothing
        SkDefaultLegend2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000")
        SkDefaultLegend2.Content = Nothing
        SkDefaultLegend2.IsValid = False
        SkDefaultLegend2.Opacity = 1F
        Padding3.Bottom = 0F
        Padding3.Left = 0F
        Padding3.Right = 0F
        Padding3.Top = 0F
        SkDefaultLegend2.Padding = Padding3
        SkDefaultLegend2.RemoveOnCompleted = False
        SkDefaultLegend2.RotateTransform = 0F
        SkDefaultLegend2.X = 0F
        SkDefaultLegend2.Y = 0F
        CartesianChart1.Legend = SkDefaultLegend2
        CartesianChart1.Location = New Point(1020, 155)
        CartesianChart1.MatchAxesScreenDataRatio = False
        CartesianChart1.Name = "CartesianChart1"
        CartesianChart1.Size = New Size(400, 600)
        CartesianChart1.TabIndex = 0
        SkDefaultTooltip2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000")
        SkDefaultTooltip2.Content = Nothing
        SkDefaultTooltip2.IsValid = False
        SkDefaultTooltip2.Opacity = 1F
        Padding4.Bottom = 0F
        Padding4.Left = 0F
        Padding4.Right = 0F
        Padding4.Top = 0F
        SkDefaultTooltip2.Padding = Padding4
        SkDefaultTooltip2.RemoveOnCompleted = False
        SkDefaultTooltip2.RotateTransform = 0F
        SkDefaultTooltip2.Wedge = 10
        SkDefaultTooltip2.X = 0F
        SkDefaultTooltip2.Y = 0F
        CartesianChart1.Tooltip = SkDefaultTooltip2
        CartesianChart1.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic
        CartesianChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000")
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(1020, 111)
        Label6.Name = "Label6"
        Label6.Size = New Size(211, 31)
        Label6.TabIndex = 6
        Label6.Text = "Showing data for :"
        ' 
        ' ExpenseCharts
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1837, 1115)
        Controls.Add(Panel3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "ExpenseCharts"
        Text = "ExpenseCharts"
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
    Friend WithEvents CartesianChart1 As LiveChartsCore.SkiaSharpView.WinForms.CartesianChart
    Friend WithEvents PieChart1 As LiveChartsCore.SkiaSharpView.WinForms.PieChart
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
