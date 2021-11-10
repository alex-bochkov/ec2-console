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
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
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
            ComboBoxMetricType.Items.Add("NetworkPacketsOut")
            ComboBoxMetricType.Items.Add("NetworkIn")
            ComboBoxMetricType.Items.Add("NetworkPacketsIn")
            ComboBoxMetricType.Items.Add("EBSReadBytes")
            ComboBoxMetricType.Items.Add("EBSReadOps")
            ComboBoxMetricType.Items.Add("EBSWriteBytes")
            ComboBoxMetricType.Items.Add("EBSWriteOps")

        ElseIf ObjectType = "volume" Then

            CloudWatchNamespace = "AWS/EBS"
            DimensionName = "VolumeId"

            ComboBoxMetricType.Items.Add("VolumeIdleTime")
            ComboBoxMetricType.Items.Add("VolumeQueueLength")
            ComboBoxMetricType.Items.Add("VolumeReadBytes")
            ComboBoxMetricType.Items.Add("VolumeReadOps")
            ComboBoxMetricType.Items.Add("VolumeTotalReadTime")
            ComboBoxMetricType.Items.Add("VolumeTotalWriteTime")
            ComboBoxMetricType.Items.Add("VolumeWriteBytes")
            ComboBoxMetricType.Items.Add("VolumeWriteOps")

        End If

        ComboBoxMetricType.SelectedIndex = 0
        ComboBoxGranularity.SelectedIndex = 0
        ComboBoxPeriod.SelectedIndex = 0
        ComboBoxStat.SelectedIndex = 0

        TextBoxObjectIds.Text = String.Join(", ", ObjectIDs)

        ShowGraph()

    End Sub
    Sub ShowGraph()

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

        Dim plot = New PlotModel With {.Subtitle = Metric}
        Dim Legend = New Legends.Legend
        Legend.LegendPlacement = Legends.LegendPlacement.Inside
        Legend.LegendPosition = Legends.LegendPosition.RightTop
        Legend.SelectionMode = OxyPlot.SelectionMode.Multiple

        plot.Legends.Add(Legend)

        Dim LinearAxis1 = New LinearAxis
        LinearAxis1.Position = AxisPosition.Left
        LinearAxis1.MajorGridlineStyle = LineStyle.Dot

        If Metric = "CPUUtilization" Then
            LinearAxis1.Maximum = 110
        ElseIf Metric = "VolumeIdleTime" Then
            LinearAxis1.Maximum = 110
        End If

            LinearAxis1.Minimum = 0
        LinearAxis1.AbsoluteMinimum = 0
        LinearAxis1.IsZoomEnabled = False
        'LinearAxis1.TickStyle = Axes.TickStyle.Inside
        plot.Axes.Add(LinearAxis1)


        Dim LinearAxis2 = New DateTimeAxis
        LinearAxis2.Position = AxisPosition.Bottom
        LinearAxis2.Minimum = DateTimeAxis.ToDouble(Now.AddHours(-HoursBack))
        LinearAxis2.Maximum = DateTimeAxis.ToDouble(Now)
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

                If ls.Title = "" Then
                    ls.Title = DataPoint.Unit.Value + " / " + ObjectId
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

End Class
