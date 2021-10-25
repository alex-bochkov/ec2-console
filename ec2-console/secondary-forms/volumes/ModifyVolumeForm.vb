Imports NLog

Public Class ModifyVolumeForm

    Public CurrentAccount As AwsAccount
    Public VolumeId As String
    Public Volume As Amazon.EC2.Model.Volume
    Public Log As Logger = LogManager.GetCurrentClassLogger()

    Private Sub EditVolume_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxVolumeId.Text = VolumeId

        Dim UserFilter = New Dictionary(Of String, List(Of String))
        UserFilter.Add("volume-id", New List(Of String))
        UserFilter.Item("volume-id").Add(VolumeId)

        Dim ListVolumes = AmazonApi.ListVolumes(CurrentAccount, UserFilter)

        If ListVolumes.Count = 1 Then

            Volume = ListVolumes.Item(0)

            NumericUpDownVolumeSize.Value = Volume.Size
            NumericUpDownVolumeSize.Minimum = Volume.Size

            NumericUpDownVolumeIops.Value = Volume.Iops
            NumericUpDownVolumeThroughput.Value = Volume.Throughput

            ComboBoxVolumeType.SelectedItem = Volume.VolumeType.Value

        End If

    End Sub
    Private Sub ComboBoxVolumeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVolumeType.SelectedIndexChanged

        Dim IopsVisible As Boolean = False
        Dim ThroughputVisible As Boolean = False

        Dim CurrentType As String = ComboBoxVolumeType.SelectedItem

        If CurrentType = "gp3" Then
            IopsVisible = True
            ThroughputVisible = True
        ElseIf CurrentType = "io1" Or CurrentType = "io2" Then
            IopsVisible = True
        End If

        NumericUpDownVolumeIops.Visible = IopsVisible
        NumericUpDownVolumeThroughput.Visible = ThroughputVisible

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim VolumeType = ComboBoxVolumeType.SelectedItem
        Dim VolumeSize = NumericUpDownVolumeSize.Value
        Dim VolumeIops = Nothing
        Dim VolumeThroughput = Nothing

        If VolumeType = "gp3" Then
            VolumeIops = NumericUpDownVolumeIops.Value
            VolumeThroughput = NumericUpDownVolumeThroughput.Value
        ElseIf VolumeType = "io1" Or VolumeType = "io2" Then
            VolumeIops = NumericUpDownVolumeIops.Value
        End If

        AmazonApi.ModifyVolume(CurrentAccount, VolumeId, VolumeSize, VolumeType, VolumeIops, VolumeThroughput)

        Dim Msg = String.Format("The {0} volume has been modified: type {1}, size {2}, iops {3}, throughput {4}",
                         VolumeId, VolumeType, VolumeSize, VolumeIops, VolumeThroughput)

        Dim eventInfo = New NLog.LogEventInfo(NLog.LogLevel.Info, Log.Name, Msg)
        eventInfo.Properties.Add("Category", "ModifyVolume")

        Log.Info(eventInfo)

        Close()

    End Sub

End Class