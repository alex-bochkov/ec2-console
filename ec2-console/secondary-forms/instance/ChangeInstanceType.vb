Public Class ChangeInstanceType

    Public InstanceTypeList As List(Of Amazon.EC2.Model.InstanceTypeInfo)
    Public CurrentAccount As AwsAccount
    Public InstanceIDs As List(Of String) = New List(Of String)
    Public Instances As List(Of Amazon.EC2.Model.Instance) = New List(Of Amazon.EC2.Model.Instance)
    Public Log As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()

    Private Sub ChangeInstanceType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'sort it properly - by the instance family first, by the size next
        InstanceTypeList.Sort(
            Function(elementA As Amazon.EC2.Model.InstanceTypeInfo, elementB As Amazon.EC2.Model.InstanceTypeInfo)

                Dim instanceTypeA = elementA.InstanceType.Value
                Dim instanceTypeB = elementB.InstanceType.Value

                Dim instanceFamilyA = instanceTypeA.Substring(0, instanceTypeA.IndexOf("."))
                Dim instanceFamilyB = instanceTypeB.Substring(0, instanceTypeB.IndexOf("."))

                If instanceFamilyA = instanceFamilyB Then

                    Dim vCpuInfoA = elementA.VCpuInfo.DefaultCores
                    Dim vCpuInfoB = elementB.VCpuInfo.DefaultCores

                    Return vCpuInfoA.CompareTo(vCpuInfoB)

                Else
                    Return instanceFamilyA.CompareTo(instanceFamilyB)
                End If

            End Function)


        Dim UserFilter = New Dictionary(Of String, List(Of String))
        UserFilter.Add("instance-id", InstanceIDs)
        Instances = AmazonApi.ListEc2Instances(CurrentAccount, UserFilter)

        For Each Instance In Instances

            Dim Text As String = Instance.InstanceId + " / " + Instance.State.Name.Value + " / " + Instance.InstanceType.Value

            Dim Item = ListViewInstancesToModify.Items.Add(Text)
            Item.Tag = Instance.InstanceId

        Next

        For Each InstanceType In InstanceTypeList

            ComboBoxInstanceType.Items.Add(InstanceType.InstanceType.Value)

        Next

        If Instances.Count > 0 Then
            ComboBoxInstanceType.SelectedItem = Instances.Item(0).InstanceType.Value
        End If

    End Sub

    Private Sub ModifyInstanceType_Async(Parameters As Dictionary(Of String, Object))

        Dim StopAndRestart As Boolean = Parameters.Item("StopAndRestart")
        Dim InstanceIds As List(Of String) = Parameters.Item("InstanceIds")
        Dim NewInstanceType As String = Parameters.Item("InstanceType")


        Dim UserFilter = New Dictionary(Of String, List(Of String))
        UserFilter.Add("instance-id", InstanceIds)
        Dim AllInstances = AmazonApi.ListEc2Instances(CurrentAccount, UserFilter, Nothing)

        Dim InstancesToStart As List(Of String) = New List(Of String)


        If StopAndRestart Then
            'stop currently running instances
            For Each Instance In AllInstances
                If Instance.State.Name = "running" Then

                    InstancesToStart.Add(Instance.InstanceId)

                    AmazonApi.StopInstance(CurrentAccount, Instance.InstanceId, Force:=True)

                End If
            Next
        End If

        For i = 1 To 300

            Dim CompletedInstances As List(Of String) = New List(Of String)

            For Each InstanceId In InstanceIds

                Dim CurrentInstance = AmazonApi.GetEc2Instance(CurrentAccount, InstanceId)

                Dim CurrentInstanceType = CurrentInstance.InstanceType.Value

                If CurrentInstance.State.Name = "stopped" And CurrentInstanceType <> NewInstanceType Then

                    AmazonApi.ModifyInstanceType(CurrentAccount, InstanceId, NewInstanceType)

                    'Dim Msg = String.Format("The instance type for {0} instance has been modified: {1} -> {2}",
                    'InstanceId, InstanceTypeOld, InstanceType)

                    ' Dim eventInfo = New NLog.LogEventInfo(NLog.LogLevel.Info, Log.Name, Msg)
                    'eventInfo.Properties.Add("Category", "ModifyInstanceType")

                    'Log.Info(eventInfo)


                    If InstancesToStart.Contains(InstanceId) Then
                        AmazonApi.StartInstance(CurrentAccount, InstanceId)
                    End If

                    CurrentInstanceType = NewInstanceType

                End If

                If CurrentInstanceType = NewInstanceType Then
                    CompletedInstances.Add(InstanceId)
                End If


            Next

            Dim Msg As String = CompletedInstances.Count.ToString + " instances modified.."
            Dim Percent As Integer = CompletedInstances.Count / InstanceIds.Count * 100

            Invoke(New Action(Sub()
                                  UpdateProgress(Msg, Percent, CompletedInstances)
                              End Sub))

            If CompletedInstances.Count = InstanceIds.Count Then
                Exit For
            Else
                Threading.Thread.Sleep(1000)
            End If

        Next

    End Sub

    Sub UpdateProgress(Msg As String, Percent As Integer, CompletedInstances As List(Of String))

        ProgressBar.Value = Percent

        LabelCurrentOperation.Text = Msg

        If Percent = 100 Then
            LabelCurrentOperation.Text = Msg + " DONE"
        End If

        For Each CompletedInstance In CompletedInstances

            For Each Item As ListViewItem In ListViewInstancesToModify.Items
                If Item.Tag = CompletedInstance Then
                    If Not Item.Text.EndsWith(" - DONE") Then
                        Item.Text = Item.Text + " - DONE"
                    End If
                End If
            Next

        Next

    End Sub

    Private Function AllInstancesAreStopped() As Boolean

        For Each Instance In Instances
            If Instance.State.Name <> "stopped" Then
                Return False
            End If
        Next

        Return True

    End Function

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ButtonScaleUp_Click(sender As Object, e As EventArgs) Handles ButtonScaleUp.Click

        If ComboBoxInstanceType.SelectedIndex < ComboBoxInstanceType.Items.Count - 1 Then
            ComboBoxInstanceType.SelectedIndex = ComboBoxInstanceType.SelectedIndex + 1
        End If

    End Sub

    Private Sub ButtonScaleDown_Click(sender As Object, e As EventArgs) Handles ButtonScaleDown.Click

        If ComboBoxInstanceType.SelectedIndex > 0 Then
            ComboBoxInstanceType.SelectedIndex = ComboBoxInstanceType.SelectedIndex - 1
        End If

    End Sub

    Private Sub ButtonModifyInstanceType_Click(sender As Object, e As EventArgs) Handles ButtonModifyInstanceType.Click

        If AllInstancesAreStopped() Or CheckBoxStopAndRestart.Checked Then

            Dim InstanceType = ComboBoxInstanceType.SelectedItem

            Dim Parameters As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

            Parameters.Add("StopAndRestart", CheckBoxStopAndRestart.Checked)
            Parameters.Add("InstanceIds", InstanceIDs)
            Parameters.Add("InstanceType", InstanceType)

            Dim t As New Threading.Thread(Sub()
                                              ModifyInstanceType_Async(Parameters)
                                          End Sub)
            t.Priority = Threading.ThreadPriority.Normal
            t.Start()

            LabelCurrentOperation.Text = "Process has started..."
            ButtonModifyInstanceType.Enabled = False

        Else

            MsgBox("Not all instances were stopped. Can't change the instance type.")

            Exit Sub

        End If

    End Sub

End Class
