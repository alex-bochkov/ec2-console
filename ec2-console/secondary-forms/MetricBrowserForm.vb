Imports System.Windows.Forms
Imports OxyPlot
Imports OxyPlot.Axes
Imports OxyPlot.Series

Public Class MetricBrowserForm

    Public CurrentAccount As AwsAccount
    Public ObjectIDs As List(Of String) = New List(Of String)
    Public ObjectType As String
    Private CloudWatchNamespace As String = ""
    Private DimensionName As String = ""

    Public MetricsInBytes As List(Of String) = New List(Of String)
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub InstanceMetricBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        ComboBoxMetricType.Items.Clear()

        If ObjectType = "instance" Then

            CloudWatchNamespace = "AWS/EC2"
            DimensionName = "InstanceId"

            ComboBoxMetricType.Items.Add("CPUUtilization")
            ComboBoxMetricType.Items.Add("NetworkOut")
            MetricsInBytes.Add("NetworkOut")
            ComboBoxMetricType.Items.Add("NetworkPacketsOut")
            ComboBoxMetricType.Items.Add("NetworkIn")
            MetricsInBytes.Add("NetworkIn")
            ComboBoxMetricType.Items.Add("NetworkPacketsIn")

            ComboBoxMetricType.Items.Add("EBSReadBytes")
            MetricsInBytes.Add("EBSReadBytes")
            ComboBoxMetricType.Items.Add("EBSReadOps")
            ComboBoxMetricType.Items.Add("EBSWriteBytes")
            MetricsInBytes.Add("EBSWriteBytes")
            ComboBoxMetricType.Items.Add("EBSWriteOps")

            ComboBoxMetricType.Items.Add("DiskReadBytes")
            MetricsInBytes.Add("DiskReadBytes")
            ComboBoxMetricType.Items.Add("DiskReadOps")
            ComboBoxMetricType.Items.Add("DiskWriteBytes")
            MetricsInBytes.Add("DiskWriteBytes")
            ComboBoxMetricType.Items.Add("DiskWriteOps")

            ComboBoxMetricType.Items.Add("StatusCheckFailed")
            ComboBoxMetricType.Items.Add("StatusCheckFailed_Instance")
            ComboBoxMetricType.Items.Add("StatusCheckFailed_System")

        ElseIf ObjectType = "volume" Then

            CloudWatchNamespace = "AWS/EBS"
            DimensionName = "VolumeId"

            ComboBoxMetricType.Items.Add("VolumeIdleTime")
            ComboBoxMetricType.Items.Add("VolumeQueueLength")
            ComboBoxMetricType.Items.Add("VolumeReadBytes")
            MetricsInBytes.Add("VolumeReadBytes")
            ComboBoxMetricType.Items.Add("VolumeReadOps")
            ComboBoxMetricType.Items.Add("VolumeTotalReadTime")
            ComboBoxMetricType.Items.Add("VolumeTotalWriteTime")
            ComboBoxMetricType.Items.Add("VolumeWriteBytes")
            MetricsInBytes.Add("VolumeWriteBytes")
            ComboBoxMetricType.Items.Add("VolumeWriteOps")
            ComboBoxMetricType.Items.Add("VolumeThroughputPercentage")
            ComboBoxMetricType.Items.Add("VolumeConsumedReadWriteOps")

        End If

        ComboBoxMetricType.SelectedIndex = 0
        ComboBoxGranularity.SelectedIndex = 0
        ComboBoxPeriod.SelectedIndex = 0
        ComboBoxStat.SelectedIndex = 0

        TextBoxObjectIds.Text = String.Join(", ", ObjectIDs)

        ShowGraph()

    End Sub
    Sub ShowGraph()

        If Not (ComboBoxMetricType.SelectedIndex > -1 And
            ComboBoxGranularity.SelectedIndex > -1 And
            ComboBoxPeriod.SelectedIndex > -1 And
            ComboBoxStat.SelectedIndex > -1) Then
            Exit Sub
        End If

        Dim HoursBack As Integer = 1
        If ComboBoxPeriod.SelectedItem = "1 hour" Then
            HoursBack = 1
        ElseIf ComboBoxPeriod.SelectedItem = "3 hours" Then
            HoursBack = 3
        ElseIf ComboBoxPeriod.SelectedItem = "12 hours" Then
            HoursBack = 12
        ElseIf ComboBoxPeriod.SelectedItem = "1 day" Then
            HoursBack = 24
        End If

        Dim StartDate As DateTime = Now.AddHours(-HoursBack)
        Dim EndDate As DateTime = Now

        Dim Metric As String = ComboBoxMetricType.SelectedItem
        Dim Stat As String = ComboBoxStat.SelectedItem

        Dim Granularity As Integer = 60
        If ComboBoxGranularity.SelectedItem = "1 minute" Then
            Granularity = 60
        ElseIf ComboBoxGranularity.SelectedItem = "5 minutes" Then
            Granularity = 300
        End If

        '********************************************************

        Dim plot = New PlotModel
        Dim Legend = New Legends.Legend
        Legend.LegendPlacement = Legends.LegendPlacement.Outside
        Legend.LegendPosition = Legends.LegendPosition.RightMiddle
        Legend.SelectionMode = OxyPlot.SelectionMode.Multiple
        Legend.AllowUseFullExtent = True

        plot.Legends.Add(Legend)

        Dim LinearAxis1 = New LinearAxis
        LinearAxis1.Position = AxisPosition.Left
        LinearAxis1.MajorGridlineStyle = LineStyle.Dot

        If Metric = "CPUUtilization" Then
            LinearAxis1.Maximum = 110
        ElseIf Metric = "VolumeIdleTime" Then
            LinearAxis1.Maximum = 110
        ElseIf Metric = "VolumeThroughputPercentage" Then
            LinearAxis1.Maximum = 110
        End If

        LinearAxis1.Minimum = 0
        LinearAxis1.AbsoluteMinimum = 0
        LinearAxis1.IsZoomEnabled = False
        'LinearAxis1.TickStyle = Axes.TickStyle.Inside
        plot.Axes.Add(LinearAxis1)


        Dim LinearAxis2 = New DateTimeAxis
        LinearAxis2.Position = AxisPosition.Bottom
        LinearAxis2.AbsoluteMinimum = DateTimeAxis.ToDouble(Now.AddHours(-HoursBack))
        LinearAxis2.AbsoluteMaximum = DateTimeAxis.ToDouble(Now)
        'LinearAxis2.TickStyle = Axes.TickStyle.Inside
        LinearAxis2.IntervalType = DateTimeIntervalType.Minutes

        plot.Axes.Add(LinearAxis2)

        For Each ObjectId In ObjectIDs

            Dim DetailedRecords = AmazonApi.GetMetricStatistics(CurrentAccount,
                                                                CloudWatchNamespace, DimensionName, ObjectId,
                                                                Granularity, Metric, Stat,
                                                                StartDate, EndDate)

            DetailedRecords.Sort(Function(elementA As Amazon.CloudWatch.Model.Datapoint, elementB As Amazon.CloudWatch.Model.Datapoint)

                                     Return elementA.Timestamp.CompareTo(elementB.Timestamp)

                                 End Function)

            Dim ls = New LineSeries With {.Title = ""}

            For Each DataPoint In DetailedRecords

                If plot.Subtitle = "" Then
                    plot.Subtitle = Metric + " / "
                    If Metric = "VolumeIdleTime" Then
                        plot.Subtitle += "%"
                    ElseIf MetricsInBytes.Contains(Metric) Then
                        plot.Subtitle += "MB"
                    Else
                        plot.Subtitle += DataPoint.Unit.Value
                    End If
                End If

                If ls.Title = "" Then
                    ls.Title = ObjectId
                End If

                Dim Val As Decimal = 0
                Select Case Stat
                    Case "Average"
                        Val = DataPoint.Average
                    Case "Maximum"
                        Val = DataPoint.Maximum
                    Case "Minimum"
                        Val = DataPoint.Minimum
                    Case "Sum"
                        Val = DataPoint.Sum
                End Select


                '********************************************************
                ' transformations
                If Metric = "VolumeIdleTime" Then

                    Val = Math.Round(Val / 60 * 100)

                ElseIf MetricsInBytes.Contains(Metric) Then

                    Val = Math.Round(Val / 1024 / 1024, 2)

                End If
                '********************************************************

                ls.Points.Add(New DataPoint(DateTimeAxis.ToDouble(DataPoint.Timestamp.ToLocalTime), Val))

            Next

            plot.Series.Add(ls)

        Next

        PlotView.Model = plot

    End Sub

    Private Sub ButtonShowGraph_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ShowGraph()

    End Sub

    Private Sub ComboBoxMetricType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMetricType.SelectedIndexChanged

        ShowGraph()

    End Sub

    Private Sub ComboBoxStat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxStat.SelectedIndexChanged

        ShowGraph()

    End Sub

    Private Sub ComboBoxGranularity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxGranularity.SelectedIndexChanged

        ShowGraph()

    End Sub

    Private Sub ComboBoxPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPeriod.SelectedIndexChanged

        ShowGraph()

    End Sub

    Private Sub TimerRefresh_Tick(sender As Object, e As EventArgs) Handles TimerRefresh.Tick

        ShowGraph()

        TimerProgressBar.Enabled = True
        TimerProgressBar.Start()

    End Sub

    Sub EnableTimer(Interval As Integer)

        TimerRefresh.Interval = Interval * 1000
        TimerRefresh.Enabled = True
        TimerRefresh.Start()

        ToolStripDropDownButtonAutorefreshInterval.Text = String.Format("Auto-Refresh (every {0} seconds)", Interval)

        ToolStripProgressBarRefresh.Maximum = Interval
        TimerProgressBar.Enabled = True
        TimerProgressBar.Start()

    End Sub

    Private Sub ToolStripMenuItem_10_seconds_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_10_seconds.Click

        EnableTimer(10)

    End Sub

    Private Sub ToolStripMenuItem_1_minute_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_1_minute.Click

        EnableTimer(60)

    End Sub

    Private Sub ToolStripMenuItem_5_minutes_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_5_minutes.Click

        EnableTimer(300)

    End Sub

    Private Sub ToolStripDropDownButtonAutorefreshInterval_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButtonAutorefreshInterval.Click

        If TimerRefresh.Enabled Then

            TimerRefresh.Enabled = False
            TimerRefresh.Stop()

            ToolStripDropDownButtonAutorefreshInterval.Text = "Auto-Refresh"

        End If

        If TimerProgressBar.Enabled Then

            TimerProgressBar.Enabled = False
            TimerProgressBar.Stop()

            ToolStripProgressBarRefresh.Value = 0

        End If

    End Sub

    Private Sub TimerProgressBar_Tick(sender As Object, e As EventArgs) Handles TimerProgressBar.Tick

        ToolStripProgressBarRefresh.Value += 1

        If ToolStripProgressBarRefresh.Value = ToolStripProgressBarRefresh.Maximum Then

            TimerProgressBar.Enabled = False
            TimerProgressBar.Stop()

            ToolStripProgressBarRefresh.Value = 0

        End If

    End Sub


End Class

