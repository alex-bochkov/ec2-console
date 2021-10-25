Imports System.Threading
Imports NLog
Public Class AttachNewVolumesToTheInstance

    Public CurrentAccount As AwsAccount
    Public InstanceId As String
    Public Log As Logger = LogManager.GetCurrentClassLogger()

    Private Sub AttachNewVolumeToTheInstance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxInstanceId.Text = InstanceId
        ComboBoxVolumeType.SelectedItem = "gp3"

    End Sub

    Private Sub ButtonCreateAndAttach_Click(sender As Object, e As EventArgs) Handles ButtonCreateAndAttach.Click

        Dim Parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

        Parameters.Add("TotalVolumesToCreate", NumericUpDownVolumeCount.Value)
        Parameters.Add("VolumeType", ComboBoxVolumeType.SelectedItem)
        Parameters.Add("VolumeSize", NumericUpDownVolumeSize.Value)
        Parameters.Add("VolumeEncrypted", CheckBoxVolumeEncrypted.Checked)

        Dim t As New Thread(Sub()
                                AttachNewVolumes_Async(Parameters)
                            End Sub)
        t.Priority = Threading.ThreadPriority.Normal
        t.Start()

        LabelCurrentOperation.Text = "Process has started..."
        ButtonCreateAndAttach.Enabled = False

    End Sub


    Sub UpdateProgress(Msg As String, Percent As Integer)

        LabelCurrentOperation.Text = Msg
        ProgressBar.Value = Percent

    End Sub

    Sub AttachNewVolumes_Async(Parameters As Dictionary(Of String, Object))

        Dim TotalVolumesToCreate As Integer = Parameters.Item("TotalVolumesToCreate")
        Dim VolumeType As String = Parameters.Item("VolumeType")
        Dim VolumeSize As Integer = Parameters.Item("VolumeSize")
        Dim VolumeEncrypted As Boolean = Parameters.Item("VolumeEncrypted")

        Dim Msg As String = ""
        Dim Percent As Integer = 50

        Dim FilterList = New List(Of String)
        FilterList.Add(InstanceId)

        Dim UserFilter = New Dictionary(Of String, List(Of String))
        UserFilter.Add("instance-id", FilterList)

        For VolumeNumber = 1 To TotalVolumesToCreate

            Dim Instances = AmazonApi.ListEc2Instances(CurrentAccount, UserFilter, Nothing)

            Percent = Math.Round(VolumeNumber / TotalVolumesToCreate * 100)

            If Instances.Count = 1 Then

                Dim Instance As Amazon.EC2.Model.Instance = Instances.Item(0)
                Dim VolumeAZ = Instance.Placement.AvailabilityZone

                Dim NewVolume = AmazonApi.CreateVolume(CurrentAccount, VolumeAZ, VolumeType, VolumeSize, VolumeEncrypted)
                Dim VolumeId = NewVolume.VolumeId

                Msg = "New volume has been created: " + VolumeId
                ShowProgress(Msg, Percent)

                Thread.Sleep(100)

                Dim CheckStatusAttempts_1 As Integer = 0
                While True

                    Dim FilterListVolume = New List(Of String)
                    FilterListVolume.Add(VolumeId)

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

                    CheckStatusAttempts_1 += 1
                    If CheckStatusAttempts_1 > 60 Then
                        Throw New Exception("Volume did not get into available state in 60 seconds. Operation was aborted")
                    End If

                End While

                Msg = "Volume " + VolumeId + " is available"
                ShowProgress(Msg, Percent)

                '------------------------------------------------------------------
                '- Attach volume to the instance
                '- use xvd[f-z] * addresses
                '- TODO - this probably works different for Linux and Windows.. need to figure it out

                Dim DeviceNameFound As Boolean = False
                Dim DeviceName As String = Nothing

                For FirstCharIndex = 65 To 90

                    Dim FirstChar As String = Chr(FirstCharIndex).ToString

                    For SecondCharIndex = 65 To 90

                        Dim SecondChar As String = Chr(SecondCharIndex).ToString

                        DeviceName = "xvd" + FirstChar.ToLower + SecondChar.ToLower

                        Dim DeviceTaken As Boolean = False

                        For Each a In Instance.BlockDeviceMappings
                            If a.DeviceName = DeviceName Then
                                DeviceTaken = True
                                Exit For
                            End If
                        Next

                        If Not DeviceTaken Then
                            DeviceNameFound = True
                            Exit For
                        End If

                    Next

                    If DeviceNameFound Then
                        Exit For
                    End If

                Next

                If DeviceName Is Nothing Then
                    Throw New Exception("No available devices found. Operation was aborted")
                End If

                Msg = "Attaching " + VolumeId + " volume to " + DeviceName
                ShowProgress(Msg, Percent)

                Dim VolumeAttachment = AmazonApi.AttachVolume(CurrentAccount, VolumeId, InstanceId, DeviceName)

                Dim CheckStatusAttempts_2 As Integer = 0
                While True

                    Dim FilterListVolume = New List(Of String)
                    FilterListVolume.Add(VolumeId)

                    Dim UserFilterVolume = New Dictionary(Of String, List(Of String))
                    UserFilterVolume.Add("volume-id", FilterListVolume)

                    Dim Volumes = AmazonApi.ListVolumes(CurrentAccount, UserFilterVolume)

                    If Volumes.Count = 1 Then

                        Dim Volume = Volumes.Item(0)

                        If Volume.State.Value = "in-use" Then
                            Exit While
                        End If

                    End If

                    Thread.Sleep(1000)

                    CheckStatusAttempts_2 += 1
                    If CheckStatusAttempts_2 > 60 Then
                        Throw New Exception("Volume did not get into attached state in 60 seconds. Operation was aborted")
                    End If

                End While

                Msg = "Volume " + VolumeId + " is attached"
                ShowProgress(Msg, Percent)

            End If


        Next



        ShowProgress("Completed successfully", 100)

    End Sub
    Sub ShowProgress(Msg As String, Percent As Integer)

        Invoke(New Action(Sub()
                              UpdateProgress(Msg, Percent)
                          End Sub))

    End Sub



End Class