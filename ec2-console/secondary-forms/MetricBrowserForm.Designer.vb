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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PlotView = New OxyPlot.WindowsForms.PlotView()
        Me.ComboBoxMetricType = New System.Windows.Forms.ComboBox()
        Me.ComboBoxGranularity = New System.Windows.Forms.ComboBox()
        Me.ComboBoxStat = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPeriod = New System.Windows.Forms.ComboBox()
        Me.TextBoxObjectIds = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(857, 5)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(194, 35)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.Location = New System.Drawing.Point(102, 3)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(87, 29)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Close"
        '
        'PlotView
        '
        Me.PlotView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlotView.BackColor = System.Drawing.Color.White
        Me.PlotView.Location = New System.Drawing.Point(14, 66)
        Me.PlotView.Name = "PlotView"
        Me.PlotView.PanCursor = System.Windows.Forms.Cursors.Hand
        Me.PlotView.Size = New System.Drawing.Size(1038, 505)
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
        Me.ComboBoxMetricType.Location = New System.Drawing.Point(15, 36)
        Me.ComboBoxMetricType.Name = "ComboBoxMetricType"
        Me.ComboBoxMetricType.Size = New System.Drawing.Size(179, 24)
        Me.ComboBoxMetricType.TabIndex = 2
        '
        'ComboBoxGranularity
        '
        Me.ComboBoxGranularity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGranularity.FormattingEnabled = True
        Me.ComboBoxGranularity.Items.AddRange(New Object() {"1 minute", "5 minutes"})
        Me.ComboBoxGranularity.Location = New System.Drawing.Point(201, 36)
        Me.ComboBoxGranularity.Name = "ComboBoxGranularity"
        Me.ComboBoxGranularity.Size = New System.Drawing.Size(135, 24)
        Me.ComboBoxGranularity.TabIndex = 3
        '
        'ComboBoxStat
        '
        Me.ComboBoxStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStat.FormattingEnabled = True
        Me.ComboBoxStat.Items.AddRange(New Object() {"Average", "Minimum", "Maximum", "Sum"})
        Me.ComboBoxStat.Location = New System.Drawing.Point(344, 36)
        Me.ComboBoxStat.Name = "ComboBoxStat"
        Me.ComboBoxStat.Size = New System.Drawing.Size(135, 24)
        Me.ComboBoxStat.TabIndex = 4
        '
        'ComboBoxPeriod
        '
        Me.ComboBoxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPeriod.FormattingEnabled = True
        Me.ComboBoxPeriod.Items.AddRange(New Object() {"1 hour", "3 hours", "12 hours", "1 day"})
        Me.ComboBoxPeriod.Location = New System.Drawing.Point(487, 36)
        Me.ComboBoxPeriod.Name = "ComboBoxPeriod"
        Me.ComboBoxPeriod.Size = New System.Drawing.Size(135, 24)
        Me.ComboBoxPeriod.TabIndex = 5
        '
        'TextBoxObjectIds
        '
        Me.TextBoxObjectIds.Location = New System.Drawing.Point(15, 5)
        Me.TextBoxObjectIds.Name = "TextBoxObjectIds"
        Me.TextBoxObjectIds.ReadOnly = True
        Me.TextBoxObjectIds.Size = New System.Drawing.Size(607, 23)
        Me.TextBoxObjectIds.TabIndex = 6
        '
        'MetricBrowserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1058, 574)
        Me.Controls.Add(Me.TextBoxObjectIds)
        Me.Controls.Add(Me.ComboBoxPeriod)
        Me.Controls.Add(Me.ComboBoxStat)
        Me.Controls.Add(Me.ComboBoxGranularity)
        Me.Controls.Add(Me.ComboBoxMetricType)
        Me.Controls.Add(Me.PlotView)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MetricBrowserForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Basic Metric Browser"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PlotView As OxyPlot.WindowsForms.PlotView
    Friend WithEvents ComboBoxMetricType As ComboBox
    Friend WithEvents ComboBoxGranularity As ComboBox
    Friend WithEvents ComboBoxStat As ComboBox
    Friend WithEvents ComboBoxPeriod As ComboBox
    Friend WithEvents TextBoxObjectIds As TextBox
    Friend WithEvents Button1 As Button
End Class
