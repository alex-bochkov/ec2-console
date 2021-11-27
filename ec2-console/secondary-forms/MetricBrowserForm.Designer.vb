<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetricBrowserForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MetricBrowserForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PlotView = New OxyPlot.WindowsForms.PlotView()
        Me.ComboBoxMetricType = New System.Windows.Forms.ComboBox()
        Me.ComboBoxGranularity = New System.Windows.Forms.ComboBox()
        Me.ComboBoxStat = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPeriod = New System.Windows.Forms.ComboBox()
        Me.TextBoxObjectIds = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TimerRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButtonAutorefreshInterval = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem_5_minutes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_1_minute = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_10_seconds = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripProgressBarRefresh = New System.Windows.Forms.ToolStripProgressBar()
        Me.TimerProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(891, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 24)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlotView
        '
        Me.PlotView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlotView.BackColor = System.Drawing.Color.White
        Me.PlotView.Location = New System.Drawing.Point(14, 69)
        Me.PlotView.Name = "PlotView"
        Me.PlotView.PanCursor = System.Windows.Forms.Cursors.Hand
        Me.PlotView.Size = New System.Drawing.Size(1038, 480)
        Me.PlotView.TabIndex = 1
        Me.PlotView.Text = "PlotView"
        Me.PlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE
        Me.PlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.PlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS
        '
        'ComboBoxMetricType
        '
        Me.ComboBoxMetricType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMetricType.FormattingEnabled = True
        Me.ComboBoxMetricType.Items.AddRange(New Object() {"CPUUtilization", "NetworkOut", "NetworkPacketsOut", "NetworkIn", "NetworkPacketsIn", "EBSReadBytes", "EBSReadOps", "EBSWriteBytes", "EBSWriteOps"})
        Me.ComboBoxMetricType.Location = New System.Drawing.Point(61, 3)
        Me.ComboBoxMetricType.Name = "ComboBoxMetricType"
        Me.ComboBoxMetricType.Size = New System.Drawing.Size(161, 24)
        Me.ComboBoxMetricType.TabIndex = 2
        '
        'ComboBoxGranularity
        '
        Me.ComboBoxGranularity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGranularity.FormattingEnabled = True
        Me.ComboBoxGranularity.Items.AddRange(New Object() {"1 minute", "5 minutes"})
        Me.ComboBoxGranularity.Location = New System.Drawing.Point(514, 3)
        Me.ComboBoxGranularity.Name = "ComboBoxGranularity"
        Me.ComboBoxGranularity.Size = New System.Drawing.Size(135, 24)
        Me.ComboBoxGranularity.TabIndex = 3
        '
        'ComboBoxStat
        '
        Me.ComboBoxStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStat.FormattingEnabled = True
        Me.ComboBoxStat.Items.AddRange(New Object() {"Average", "Minimum", "Maximum", "Sum"})
        Me.ComboBoxStat.Location = New System.Drawing.Point(312, 3)
        Me.ComboBoxStat.Name = "ComboBoxStat"
        Me.ComboBoxStat.Size = New System.Drawing.Size(135, 24)
        Me.ComboBoxStat.TabIndex = 4
        '
        'ComboBoxPeriod
        '
        Me.ComboBoxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPeriod.FormattingEnabled = True
        Me.ComboBoxPeriod.Items.AddRange(New Object() {"1 hour", "3 hours", "12 hours", "1 day"})
        Me.ComboBoxPeriod.Location = New System.Drawing.Point(750, 3)
        Me.ComboBoxPeriod.Name = "ComboBoxPeriod"
        Me.ComboBoxPeriod.Size = New System.Drawing.Size(135, 24)
        Me.ComboBoxPeriod.TabIndex = 5
        '
        'TextBoxObjectIds
        '
        Me.TextBoxObjectIds.Location = New System.Drawing.Point(91, 5)
        Me.TextBoxObjectIds.Name = "TextBoxObjectIds"
        Me.TextBoxObjectIds.ReadOnly = True
        Me.TextBoxObjectIds.Size = New System.Drawing.Size(961, 23)
        Me.TextBoxObjectIds.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Object(s)"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComboBoxMetricType)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComboBoxStat)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComboBoxGranularity)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComboBoxPeriod)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 34)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1040, 29)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Metric"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(228, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Statistics"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(453, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Period"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(655, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Time Range"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TimerRefresh
        '
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButtonAutorefreshInterval, Me.ToolStripProgressBarRefresh})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 552)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1058, 22)
        Me.StatusStrip.TabIndex = 9
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripDropDownButtonAutorefreshInterval
        '
        Me.ToolStripDropDownButtonAutorefreshInterval.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButtonAutorefreshInterval.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_5_minutes, Me.ToolStripMenuItem_1_minute, Me.ToolStripMenuItem_10_seconds})
        Me.ToolStripDropDownButtonAutorefreshInterval.Image = CType(resources.GetObject("ToolStripDropDownButtonAutorefreshInterval.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButtonAutorefreshInterval.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButtonAutorefreshInterval.Name = "ToolStripDropDownButtonAutorefreshInterval"
        Me.ToolStripDropDownButtonAutorefreshInterval.Size = New System.Drawing.Size(90, 20)
        Me.ToolStripDropDownButtonAutorefreshInterval.Text = "Auto-Refresh"
        '
        'ToolStripMenuItem_5_minutes
        '
        Me.ToolStripMenuItem_5_minutes.Name = "ToolStripMenuItem_5_minutes"
        Me.ToolStripMenuItem_5_minutes.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripMenuItem_5_minutes.Text = "5 minutes"
        '
        'ToolStripMenuItem_1_minute
        '
        Me.ToolStripMenuItem_1_minute.Name = "ToolStripMenuItem_1_minute"
        Me.ToolStripMenuItem_1_minute.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripMenuItem_1_minute.Text = "1 minute"
        '
        'ToolStripMenuItem_10_seconds
        '
        Me.ToolStripMenuItem_10_seconds.Name = "ToolStripMenuItem_10_seconds"
        Me.ToolStripMenuItem_10_seconds.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripMenuItem_10_seconds.Text = "10 seconds"
        '
        'ToolStripProgressBarRefresh
        '
        Me.ToolStripProgressBarRefresh.Name = "ToolStripProgressBarRefresh"
        Me.ToolStripProgressBarRefresh.Size = New System.Drawing.Size(100, 16)
        '
        'TimerProgressBar
        '
        Me.TimerProgressBar.Interval = 1000
        '
        'MetricBrowserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 574)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxObjectIds)
        Me.Controls.Add(Me.PlotView)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MetricBrowserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Basic Metric Browser"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlotView As OxyPlot.WindowsForms.PlotView
    Friend WithEvents ComboBoxMetricType As ComboBox
    Friend WithEvents ComboBoxGranularity As ComboBox
    Friend WithEvents ComboBoxStat As ComboBox
    Friend WithEvents ComboBoxPeriod As ComboBox
    Friend WithEvents TextBoxObjectIds As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TimerRefresh As Timer
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripDropDownButtonAutorefreshInterval As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem_5_minutes As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_10_seconds As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_1_minute As ToolStripMenuItem
    Friend WithEvents TimerProgressBar As Timer
    Friend WithEvents ToolStripProgressBarRefresh As ToolStripProgressBar
End Class
