Imports System.Windows.Forms
Imports OxyPlot
Imports OxyPlot.Axes
Imports OxyPlot.Series

Public Class InstanceMetricBrowserForm

    Public CurrentAccount As AwsAccount
    Public InstanceIDs As List(Of String) = New List(Of String)
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub InstanceMetricBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxMetricType.SelectedIndex = 0
        ComboBoxGranularity.SelectedIndex = 0
        ComboBoxPeriod.SelectedIndex = 0
        ComboBoxStat.SelectedIndex = 0

        TextBoxInstanceId.Text = String.Join(", ", InstanceIDs)

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

        Dim LinearAxis1 = New LinearAxis
        LinearAxis1.Position = AxisPosition.Left
        LinearAxis1.Minimum = 0
        LinearAxis1.AbsoluteMinimum = 0
        LinearAxis1.IsZoomEnabled = False
        LinearAxis1.TickStyle = Axes.TickStyle.Inside
        plot.Axes.Add(LinearAxis1)


        Dim LinearAxis2 = New DateTimeAxis
        LinearAxis2.Position = AxisPosition.Bottom
        LinearAxis2.Minimum = DateTimeAxis.ToDouble(Now.AddHours(-HoursBack))
        LinearAxis2.Maximum = DateTimeAxis.ToDouble(Now)
        LinearAxis2.TickStyle = Axes.TickStyle.Inside
        LinearAxis2.IntervalType = DateTimeIntervalType.Minutes

        plot.Axes.Add(LinearAxis2)

        For Each InstanceId In InstanceIDs

            Dim DetailedRecords = AmazonApi.GetCpuUtilizationPerInstance(CurrentAccount, InstanceId, Granularity, Metric, Stat, StartDate, EndDate)

            DetailedRecords.Sort(Function(elementA As Amazon.CloudWatch.Model.Datapoint, elementB As Amazon.CloudWatch.Model.Datapoint)

                                     Return elementA.Timestamp.CompareTo(elementB.Timestamp)

                                 End Function)

            Dim ls = New LineSeries With {.Title = ""}

            For Each DataPoint In DetailedRecords

                If ls.Title = "" Then
                    ls.Title = DataPoint.Unit.Value + " / " + InstanceId
                End If

                Dim Val As Int64 = 0
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
