Imports NLog
Imports System.Threading

Public Class DetachAndDeleteVolumeForm

    Public CurrentAccount As AwsAccount
    Public VolumeIds As List(Of String) = New List(Of String)
    Public Log As Logger = LogManager.GetCurrentClassLogger()

    Private Sub DetachAndDeleteVolumeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxVolumeIds.Text = String.Join(", ", VolumeIds)

    End Sub
    Private Sub ButtonDetachAndDelete_Click(sender As Object, e As EventArgs) Handles ButtonDetachAndDelete.Click

        Dim Parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        Parameters.Add("ForceDetach", CheckBoxForceDetach.Checked)
        Parameters.Add("DeleteDetachedVolumes", CheckBoxDeleteDetachedVolumes.Checked)
        Parameters.Add("VolumeIDs", VolumeIds)

        Dim t As New Thread(Sub()
                                AttachNewVolumes_Async(Parameters)
                            End Sub)
        t.Priority = Threading.ThreadPriority.Normal
        t.Start()

        LabelCurrentOperation.Text = "Process has started..."
        ButtonDetachAndDelete.Enabled = False

        'Dim Msg = String.Format("The {0} volume has been modified: type {1}, size {2}, iops {3}, throughput {4}",
        '                 VolumeId, VolumeType, VolumeSize, VolumeIops, VolumeThroughput)
        '
        'Dim eventInfo = New NLog.LogEventInfo(NLog.LogLevel.Info, Log.Name, Msg)
        'eventInfo.Properties.Add("Category", "ModifyVolume")
        '
        'Log.Info(eventInfo)
        '
        'Close()

    End Sub

    Sub AttachNewVolumes_Async(Parameters As Dictionary(Of String, Object))

        Dim VolumeIDs As List(Of String) = Parameters.Item("VolumeIDs")
        Dim DeleteDetachedVolumes As Boolean = Parameters.Item("DeleteDetachedVolumes")
        Dim ForceDetach As Boolean = Parameters.Item("ForceDetach")

        Dim Msg As String = ""
        Dim Percent As Integer = 0

        Dim VolumeNumber = 0
        Dim TotalVolumesToDetach = VolumeIDs.Count

        For Each VolumeID In VolumeIDs

            Msg = "Detaching: " + VolumeID
            ShowProgress(Msg, Percent)

            VolumeNumber += 1
            Percent = Math.Round(VolumeNumber / TotalVolumesToDetach * 100)

            Dim DetachedVolume = AmazonApi.DetachVolume(CurrentAccount, VolumeID, ForceDetach)

            Dim CheckStatusAttempts As Integer = 0
            While True

                Dim FilterListVolume = New List(Of String)
                FilterListVolume.Add(VolumeID)

                Dim UserFilterVolume = New Dictionary(Of String, List(Of String))
                UserFilterVolume.Add("volume-id", FilterListVolume)

                Dim Volumes = AmazonApi.ListVolumes(CurrentAccount, UserFilterVolume)

                If Volumes.Count = 1 Then

                    Dim Volume = Volumes.Item(0)

                    If Volume.State.Value = "available" Then
                        Exit While
                    End If

                End If

                Thread.Sleep(1000)

                CheckStatusAttempts += 1
                If CheckStatusAttempts > 60 Then
                    Throw New Exception("Volume did not get into 'available' state in 60 seconds. Operation was aborted")
                End If

            End While

            Msg = "Volume has been detached: " + VolumeID
            ShowProgress(Msg, Percent)

            If DeleteDetachedVolumes Then

                Dim VolumeDeletedSuccessfully = AmazonApi.DeleteVolume(CurrentAccount, VolumeID)

            End If

            Msg = "Volume " + VolumeID + " was deleted"
            ShowProgress(Msg, Percent)

        Next

        ShowProgress("Completed successfully", 100)

    End Sub

    Sub ShowProgress(Msg As String, Percent As Integer)

        Invoke(New Action(Sub()
                              UpdateProgress(Msg, Percent)
                          End Sub))

    End Sub


    Sub UpdateProgress(Msg As String, Percent As Integer)

        LabelCurrentOperation.Text = Msg
        ProgressBar.Value = Percent

    End Sub

End Class