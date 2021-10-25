Imports System.Threading
Imports NLog

Public Class Form1

    Private AllAccounts As List(Of AwsAccount)
    Private CurrentAccount As AwsAccount
    Private NextToken As String = Nothing

    Private InstanceTable As Hashtable = New Hashtable
    Private InstanceStatusTable As Hashtable = New Hashtable
    Private InstanceVolumesTable As Hashtable = New Hashtable

    Private InstanceTypesList As List(Of Amazon.EC2.Model.InstanceTypeInfo)

    Private InstanceTypesTable As SortedDictionary(Of String, SortedDictionary(Of String, SortedDictionary(Of String, Amazon.EC2.Model.InstanceTypeInfo))) =
        New SortedDictionary(Of String, SortedDictionary(Of String, SortedDictionary(Of String, Amazon.EC2.Model.InstanceTypeInfo)))

    Private UserFilterForInstances As Dictionary(Of String, List(Of String)) = New Dictionary(Of String, List(Of String))

    Public Log As Logger = LogManager.GetCurrentClassLogger()

    Sub ConfigureLogging()

        Dim Config = New NLog.Config.LoggingConfiguration()

        Dim logFile = New NLog.Targets.FileTarget("logfile") With {.FileName = "${basedir}/log.txt"}
        logFile.Layout = "${longdate}|${level:uppercase=true}|${event-properties:item=Category}|${message}"

        Config.AddRuleForAllLevels(logFile)

        NLog.LogManager.Configuration = Config

        Dim eventInfo = New LogEventInfo(LogLevel.Info, Log.Name, "The application has started")
        eventInfo.Properties.Add("Category", "Common")
        Log.Info(eventInfo)

    End Sub

    Sub CheckForTheAppUpdates_Async()

        Dim LatestRelease = ServiceFunctions.GetTheMostRecentReleaseFromGithub()

        Dim LatestVersion As Version = Version.Parse(LatestRelease.tag_name)

        Dim CurrentVersionNumber = My.Application.Info.Version

        If CurrentVersionNumber.CompareTo(LatestVersion) < 0 Then

            Dim msg = "New Version Available " + LatestRelease.tag_name

            Invoke(New Action(Sub()
                                  AddUpdateButton(msg)
                              End Sub))

        End If

    End Sub

    Sub AddUpdateButton(msg As String)

        Dim mVer = New ToolStripButton(msg, Nothing, AddressOf GoToDownloadPage)
        StatusStrip.Items.Add(mVer)
        StatusStrip.Items.Add(New ToolStripSeparator)

    End Sub

    Sub GoToDownloadPage()

        'this one doesn't work in .NET Core
        'Process.Start("https://github.com/alekseybochkov/ec2-console/releases")

        Process.Start(New ProcessStartInfo("cmd", $"/c start https://github.com/alekseybochkov/ec2-console/releases") With {.CreateNoWindow = True})

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim t As New Thread(New ThreadStart(AddressOf CheckForTheAppUpdates_Async))
        t.Priority = Threading.ThreadPriority.Normal
        t.Start()

        ConfigureLogging()

        SetFirstCurrentAccount()

    End Sub

    Sub SetFirstCurrentAccount()

        AllAccounts = AccountManagement.GetAllAccounts()

        If AllAccounts.Count > 0 Then
            CurrentAccount = AllAccounts.Item(0)
        End If

        RefreshAccountsMenu()

        If Not CurrentAccount Is Nothing Then

            SetCurrentAccount()

        End If

    End Sub

    Sub SetCurrentAccount()

        AccountsToolStripMenuItem.Text = "Active account: " + CurrentAccount.Description

        StatusStrip.BackColor = CurrentAccount.BackgroundColor

        FillInstanceList()

        PopulateFilterMenu()

        ShowAccountAttributes()

    End Sub

    Sub ShowAccountAttributes()

        Dim Rez = AmazonApi.GetAccountAttributes(CurrentAccount)

        Text = "AWS EC2 Console / Current User = " + Rez.Arn

    End Sub


    Sub ChangeAccount(sender As Object, e As EventArgs)

        If TypeOf sender.tag Is AwsAccount Then

            CurrentAccount = sender.tag

            SetCurrentAccount()

        End If

    End Sub


    Sub RefreshAccountsMenu()

        If AllAccounts.Count() = 0 Then

            AccountsToolStripMenuItem.Text = "(no accounts saved)"

        Else

            AccountsToolStripMenuItem.Text = "Active account: " + CurrentAccount.Description
            AccountsToolStripMenuItem.BackColor = SystemColors.ActiveCaption

            AccountsToolStripMenuItem.DropDownItems.Clear()

            For Each Account In AllAccounts
                Dim NewAccountMenuItem = AccountsToolStripMenuItem.DropDownItems.Add(Account.Description, Nothing, AddressOf ChangeAccount)
                NewAccountMenuItem.Tag = Account
            Next

        End If

        AccountsToolStripMenuItem.DropDownItems.Add(New ToolStripSeparator)
        Dim NewAccountManageMenuItem = AccountsToolStripMenuItem.DropDownItems.Add(" * Manage Accounts * ", Nothing, AddressOf OpenAccountManagementForm)

    End Sub


    Private Sub OpenAccountManagementForm()

        Dim FormAccounts = New AwsAccountsForm
        FormAccounts.StartPosition = FormStartPosition.CenterParent
        FormAccounts.ShowDialog()

        SetFirstCurrentAccount()

    End Sub

    Private Sub RefreshFilterRepresentation()

        MenuStripFilterPresentation.Items.Clear()

        For Each UserFilterObject In UserFilterForInstances

            If UserFilterObject.Value.Count > 0 Then

                Dim AllKeys As String = UserFilterObject.Value.Aggregate(Function(First, nextString) First + ", " + nextString)
                If AllKeys.Length > 50 Then
                    AllKeys = AllKeys.Substring(0, 10) + "..."
                End If

                Dim FilterText = UserFilterObject.Key + " = " + AllKeys

                Dim NewElement As ToolStripDropDownItem = MenuStripFilterPresentation.Items.Add(FilterText) ', Nothing, AddressOf onClickClearFilter)
                NewElement.Tag = UserFilterObject.Key

                For Each FilterValue In UserFilterObject.Value
                    NewElement.DropDownItems.Add(FilterValue)
                Next

                NewElement.DropDownItems.Add(New ToolStripSeparator)

                Dim ClearFilterElement = New ToolStripMenuItem("Clear filter", Nothing, AddressOf onClickClearFilter)
                ClearFilterElement.Tag = UserFilterObject.Key
                NewElement.DropDownItems.Add(ClearFilterElement)

            End If

        Next

    End Sub

    Private Sub AddFilterByAZ(AZ As Amazon.EC2.Model.AvailabilityZone)

        If Not UserFilterForInstances.ContainsKey("availability-zone") Then
            UserFilterForInstances.Item("availability-zone") = New List(Of String)
        End If

        UserFilterForInstances.Item("availability-zone").Add(AZ.ZoneName)

    End Sub

    Private Sub AddFilterByInstanceState(InstanceState As Amazon.EC2.Model.InstanceState)

        If Not UserFilterForInstances.ContainsKey("instance-state-name") Then
            UserFilterForInstances.Item("instance-state-name") = New List(Of String)
        End If

        UserFilterForInstances.Item("instance-state-name").Add(InstanceState.Name)

    End Sub

    Private Sub AddFilterByInstanceType(InstanceTypeSubstring As String)

        If Not UserFilterForInstances.ContainsKey("instance-type") Then
            UserFilterForInstances.Item("instance-type") = New List(Of String)
        End If

        For Each InstanceType In InstanceTypesList

            If InstanceType.InstanceType.Value.StartsWith(InstanceTypeSubstring) Then
                UserFilterForInstances.Item("instance-type").Add(InstanceType.InstanceType.Value)
            End If

        Next

    End Sub

    Private Sub AddFilterByVpc(vpc As Amazon.EC2.Model.Vpc)

        If Not UserFilterForInstances.ContainsKey("vpc-id") Then
            UserFilterForInstances.Item("vpc-id") = New List(Of String)
        End If

        UserFilterForInstances.Item("vpc-id").Add(vpc.VpcId)

    End Sub

    Private Sub AddFilterBySubnet(subnet As Amazon.EC2.Model.Subnet)

        If Not UserFilterForInstances.ContainsKey("subnet-id") Then
            UserFilterForInstances.Item("subnet-id") = New List(Of String)
        End If

        UserFilterForInstances.Item("subnet-id").Add(subnet.SubnetId)

    End Sub
    Private Sub onClickClearFilter(sender As Object, e As EventArgs)

        If UserFilterForInstances.ContainsKey(sender.tag) Then
            UserFilterForInstances.Remove(sender.tag)
        End If

        RefreshFilterRepresentation()

        FillInstanceList()

    End Sub

    Private Sub onClickFilter(sender As Object, e As EventArgs)

        If TypeOf sender.tag Is Amazon.EC2.Model.AvailabilityZone Then

            AddFilterByAZ(sender.tag)

        ElseIf TypeOf sender.tag Is Amazon.EC2.Model.InstanceState Then

            AddFilterByInstanceState(sender.tag)

        ElseIf TypeOf sender.tag Is Amazon.EC2.Model.Vpc Then

            AddFilterByVpc(sender.tag)

        ElseIf TypeOf sender.tag Is Amazon.EC2.Model.Subnet Then

            AddFilterBySubnet(sender.tag)

        ElseIf TypeOf sender.tag Is String _
                        And sender.tag = "filter-instance-type" Then

            AddFilterByInstanceType(sender.text)

        Else

            'MsgBox("Click")

        End If

        RefreshFilterRepresentation()

        FillInstanceList()

    End Sub

    Sub PopulateFilterMenu()

        FilterByToolStripMenuItem.DropDownItems.Clear()

        Dim azMenu As ToolStripDropDownItem = FilterByToolStripMenuItem.DropDownItems.Add("filter-availability-zone")
        For Each AZ In AmazonApi.ListAvailabilityZones(CurrentAccount)
            Dim a = azMenu.DropDownItems.Add(AZ.ZoneName, Nothing, AddressOf onClickFilter)
            a.Tag = AZ
        Next

        Dim tag As ToolStripDropDownItem = FilterByToolStripMenuItem.DropDownItems.Add("filter-tag")
        Dim tags = AmazonApi.ListTags(CurrentAccount)
        For Each instanceTagDescription In tags

            Dim a As ToolStripDropDownItem = tag.DropDownItems.Add(instanceTagDescription.Key, Nothing, AddressOf onClickFilter)

        Next

        '-----------------------------------------------------------------
        Dim instanceTypes As ToolStripDropDownItem = FilterByToolStripMenuItem.DropDownItems.Add("filter-instance-type")

        InstanceTypesList = AmazonApi.ListInstanceTypes(CurrentAccount)

        InstanceTypesTable.Clear()

        For Each instanceTypeDescription In InstanceTypesList

            Dim InstanceFirstLetter = instanceTypeDescription.InstanceType.Value.Substring(0, 1)
            Dim InstanceFamily = instanceTypeDescription.InstanceType.Value.Substring(0, instanceTypeDescription.InstanceType.Value.IndexOf("."))

            If Not InstanceTypesTable.ContainsKey(InstanceFirstLetter) Then
                InstanceTypesTable.Add(InstanceFirstLetter, New SortedDictionary(Of String, SortedDictionary(Of String, Amazon.EC2.Model.InstanceTypeInfo)))
            End If

            If Not InstanceTypesTable.Item(InstanceFirstLetter).ContainsKey(InstanceFamily) Then
                InstanceTypesTable.Item(InstanceFirstLetter).Add(InstanceFamily, New SortedDictionary(Of String, Amazon.EC2.Model.InstanceTypeInfo))
            End If

            InstanceTypesTable.Item(InstanceFirstLetter).Item(InstanceFamily).TryAdd(instanceTypeDescription.InstanceType.Value, instanceTypeDescription)

        Next

        For Each instanceFamilyDescription In InstanceTypesTable.Keys

            Dim a As ToolStripDropDownItem = instanceTypes.DropDownItems.Add(instanceFamilyDescription.ToString, Nothing, AddressOf onClickFilter)
            a.Tag = "filter-instance-type"

            For Each instanceTypeDescription In InstanceTypesTable.Item(instanceFamilyDescription).Keys

                Dim b As ToolStripDropDownItem = a.DropDownItems.Add(instanceTypeDescription.ToString, Nothing, AddressOf onClickFilter)
                b.Tag = "filter-instance-type"

                For Each instanceTypeDescription2 In InstanceTypesTable.Item(instanceFamilyDescription).Item(instanceTypeDescription)
                    Dim c As ToolStripDropDownItem = b.DropDownItems.Add(instanceTypeDescription2.Key, Nothing, AddressOf onClickFilter)
                    c.Tag = "filter-instance-type"
                Next

            Next

        Next
        '-----------------------------------------------------------------

        'Dim a = New Amazon.EC2.Model.InstanceState()

        Dim instanceState As ToolStripDropDownItem = FilterByToolStripMenuItem.DropDownItems.Add("filter-instance-state-name")
        instanceState.DropDownItems.Add("pending", Nothing, AddressOf onClickFilter).Tag = New Amazon.EC2.Model.InstanceState With {.Name = "pending"}
        instanceState.DropDownItems.Add("running", Nothing, AddressOf onClickFilter).Tag = New Amazon.EC2.Model.InstanceState With {.Name = "running"}
        instanceState.DropDownItems.Add("shutting-down", Nothing, AddressOf onClickFilter).Tag = New Amazon.EC2.Model.InstanceState With {.Name = "shutting-down"}
        instanceState.DropDownItems.Add("terminated", Nothing, AddressOf onClickFilter).Tag = New Amazon.EC2.Model.InstanceState With {.Name = "terminated"}
        instanceState.DropDownItems.Add("stopping", Nothing, AddressOf onClickFilter).Tag = New Amazon.EC2.Model.InstanceState With {.Name = "stopping"}
        instanceState.DropDownItems.Add("stopped", Nothing, AddressOf onClickFilter).Tag = New Amazon.EC2.Model.InstanceState With {.Name = "stopped"}

        '-----------------------------------------------------------------
        Dim vpcFilter As ToolStripDropDownItem = FilterByToolStripMenuItem.DropDownItems.Add("filter-vpc")
        Dim allVpcs = AmazonApi.DescribeVpcs(CurrentAccount)
        For Each vpcDescription In allVpcs

            Dim MenuText = vpcDescription.VpcId

            For Each vpcTag In vpcDescription.Tags
                If vpcTag.Key = "Name" Then
                    MenuText += " / " + vpcTag.Value
                End If
            Next

            Dim a As ToolStripDropDownItem = vpcFilter.DropDownItems.Add(MenuText, Nothing, AddressOf onClickFilter)
            a.Tag = vpcDescription

        Next
        '-----------------------------------------------------------------
        Dim subnetFilter As ToolStripDropDownItem = FilterByToolStripMenuItem.DropDownItems.Add("filter-subnet")
        Dim allSubnets = AmazonApi.DescribeSubnets(CurrentAccount)
        For Each subnetDescription In allSubnets

            Dim MenuText = subnetDescription.SubnetId

            For Each subnetTag In subnetDescription.Tags
                If subnetTag.Key = "Name" Then
                    MenuText += " / " + subnetTag.Value
                End If
            Next

            Dim a As ToolStripDropDownItem = subnetFilter.DropDownItems.Add(MenuText, Nothing, AddressOf onClickFilter)
            a.Tag = subnetDescription

        Next

    End Sub

    Private Sub FillInstanceList()

        Dim table As New DataTable
        'table.Columns.Add("RowSelected", GetType(Boolean))
        table.Columns.Add("#", GetType(Integer))
        table.Columns.Add("Name", GetType(String))
        table.Columns.Add("State", GetType(String))
        table.Columns.Add("InstanceId", GetType(String))
        table.Columns.Add("InstanceType", GetType(String))
        table.Columns.Add("PrivateIpAddress", GetType(String))
        table.Columns.Add("PlatformDetails", GetType(String))
        table.Columns.Add("LaunchTime", GetType(DateTime))

        InstanceTable.Clear()
        InstanceStatusTable.Clear()
        InstanceVolumesTable.Clear()

        Dim InstanceList = AmazonApi.ListEc2Instances(CurrentAccount, UserFilterForInstances, NextToken)

        If InstanceList.Count > 0 Then

            For Each instance In InstanceList
                'not sure what it failing on duplicates here
                If InstanceVolumesTable.ContainsKey(instance.InstanceId) Then
                    InstanceVolumesTable.Remove(instance.InstanceId)
                End If
                InstanceVolumesTable.Add(instance.InstanceId, New List(Of Amazon.EC2.Model.Volume))
            Next

            Dim UserFilter = New Dictionary(Of String, List(Of String))
            UserFilter.Add("volume-id", New List(Of String))
            For Each Instance In InstanceList
                For Each BlockDeviceMappings In Instance.BlockDeviceMappings
                    Dim Volume = BlockDeviceMappings.Ebs.VolumeId
                    UserFilter.Item("volume-id").Add(Volume)
                Next
            Next

            Dim ListVolumes = AmazonApi.ListVolumes(CurrentAccount, UserFilter)

            For Each Volume In ListVolumes
                InstanceVolumesTable.Item(Volume.Attachments.Item(0).InstanceId).Add(Volume)
            Next
            'Dim ListStatuses = Ec2Instances.ListEc2InstanceStatuses(CurrentAccount, List)

            'For Each Status In ListStatuses
            '    InstanceStatusTable.Add(Status.InstanceId, Status)
            'Next

            Dim i = 0

            For Each instance In InstanceList

                i = i + 1

                Dim RowRepresentation As DataRow = table.NewRow()
                RowRepresentation.Item("#") = i.ToString

                For Each InstanceTag In instance.Tags

                    If InstanceTag.Key = "Name" Then
                        RowRepresentation.Item("Name") = InstanceTag.Value
                    End If

                Next

                'Dim Status As Amazon.EC2.Model.InstanceStatus = InstanceStatusTable.Item(instance.InstanceId)
                'If Not Status Is Nothing Then
                '    RowRepresentation.Item("State") = Status.InstanceState.Name.Value & " (" & Status.SystemStatus.Status.Value & ")"
                'End If

                RowRepresentation.Item("State") = instance.State.Name.Value
                RowRepresentation.Item("InstanceId") = instance.InstanceId
                RowRepresentation.Item("InstanceType") = instance.InstanceType
                RowRepresentation.Item("PrivateIpAddress") = instance.PrivateIpAddress
                RowRepresentation.Item("PlatformDetails") = instance.PlatformDetails
                RowRepresentation.Item("LaunchTime") = instance.LaunchTime

                table.Rows.Add(RowRepresentation)

                'not sure what it failing on duplicates here
                If InstanceTable.ContainsKey(instance.InstanceId) Then
                    InstanceTable.Remove(instance.InstanceId)
                End If
                InstanceTable.Add(instance.InstanceId, instance)

            Next

        End If

        DataListViewEC2.DataSource = table
        DataListViewEC2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

    End Sub

    Sub PopulateInstanceProperties()

        TreeViewInstanceProperties.Nodes.Clear()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Instance As Amazon.EC2.Model.Instance = InstanceTable.Item(InstanceID)

        If Instance Is Nothing Then
            Exit Sub
        End If

        TreeViewInstanceProperties.Nodes.Add("_1", "AZ       : " + Instance.Placement.AvailabilityZone)
        TreeViewInstanceProperties.Nodes.Add("_2", "Launched : " + Instance.LaunchTime.ToString)
        TreeViewInstanceProperties.Nodes.Add("_3", "AMI      : " + Instance.ImageId)

        Dim Tags = TreeViewInstanceProperties.Nodes.Add("tags", "Instance Tags")

        For Each InstanceTag In Instance.Tags

            Tags.Nodes.Add(InstanceTag.Key, InstanceTag.Key + ": " + InstanceTag.Value)

        Next

        Dim SG = TreeViewInstanceProperties.Nodes.Add("security-groups", "Security Groups")
        For Each InstanceSG In Instance.SecurityGroups
            SG.Nodes.Add(InstanceSG.GroupId, InstanceSG.GroupName & "(" & InstanceSG.GroupId & ")")
        Next

        Dim VolumeNode = TreeViewInstanceProperties.Nodes.Add("volumes", "Volumes")
        Dim Volumes = InstanceVolumesTable.Item(InstanceID)
        For Each Volume As Amazon.EC2.Model.Volume In Volumes
            VolumeNode.Nodes.Add(Volume.VolumeId, Volume.VolumeType.Value & " / " & Volume.Size.ToString & " Gb / " & Volume.Iops.ToString & " IOPS / " & Volume.Throughput & " MiB/s")
        Next

        TreeViewInstanceProperties.ExpandAll()

    End Sub

    Private Sub DataListViewEC2_MouseDown(sender As Object, e As MouseEventArgs) Handles DataListViewEC2.MouseDown

        If (e.Button = MouseButtons.Right) Then

            Dim hti = DataListViewEC2.HitTest(e.X, e.Y)

            If Not hti.Item Is Nothing Then

                Dim m As ContextMenuStrip = New ContextMenuStrip()
                m.Items.Add(New ToolStripMenuItem("Stop instance", My.Resources.StopRed.ToBitmap, AddressOf StopInstance))
                m.Items.Add(New ToolStripMenuItem("Start instance", My.Resources.Play.ToBitmap, AddressOf StartInstance))
                m.Items.Add(New ToolStripMenuItem("Reboot instance", My.Resources.Reboot.ToBitmap, AddressOf RebootInstance))
                m.Items.Add(New ToolStripMenuItem("Terminate instance", Nothing, AddressOf TerminateInstance))


                Dim m1 = New ToolStripMenuItem("Instance settings")
                m1.DropDownItems.Add(New ToolStripMenuItem("Change instance type", Nothing, AddressOf ChangeInstanceType))
                m1.DropDownItems.Add(New ToolStripMenuItem("Change termination protection", Nothing, AddressOf ChangeTerminationProtection))
                m1.DropDownItems.Add(New ToolStripMenuItem("Manage tags", Nothing, AddressOf EditTags))
                m.Items.Add(m1)

                Dim m2 = New ToolStripMenuItem("Networking")
                m.Items.Add(m2)

                Dim m3 = New ToolStripMenuItem("Security")
                m3.DropDownItems.Add(New ToolStripMenuItem("Change security groups", Nothing, AddressOf EditSecurityGroups))
                m3.DropDownItems.Add(New ToolStripMenuItem("Get Windows password", Nothing, AddressOf GetWindowsPasswordForm))
                m3.DropDownItems.Add(New ToolStripMenuItem("Modify IAM Role", Nothing, AddressOf ChangeIamRole))
                m.Items.Add(m3)

                Dim m4 = New ToolStripMenuItem("Image and templates")

                m.Items.Add(m4)

                Dim m5 = New ToolStripMenuItem("Monitor and troubleshoot")
                m5.DropDownItems.Add(New ToolStripMenuItem("Get instance screenshot", Nothing, AddressOf GetConsoleScreenshot))
                m.Items.Add(m5)

                'm.Items.Add(New ToolStripMenuItem(String.Format("Do something to row {0}", hti.RowIndex.ToString())))

                m.Items.Add(New ToolStripMenuItem("Instance config history", My.Resources.Timeline.ToBitmap, AddressOf GetInstanceConfigHistory))
                m.Show(Cursor.Position)

            End If

        End If

    End Sub
    Function GetSelectedInstanceId() As String

        Dim ColumnNumber = 3

        Dim InstanceId As String = DataListViewEC2.FocusedItem.SubItems.Item(ColumnNumber).Text

        Return InstanceId

    End Function

    Sub GetInstanceConfigHistory()

        Dim InstanceID = GetSelectedInstanceId()

        OpenConfigHistporyForm(InstanceID)

    End Sub

    Sub GetVolumeConfigHistory(sender As Object, e As EventArgs)

        Dim VolumeId = sender.tag

        OpenConfigHistporyForm(VolumeId)

    End Sub

    Sub OpenConfigHistporyForm(ResourceId As String)

        Dim FormWP = New ObjectHistoryForm
        FormWP.CurrentAccount = CurrentAccount
        FormWP.ResourceId = ResourceId
        FormWP.StartPosition = FormStartPosition.CenterParent
        FormWP.ShowDialog()

    End Sub

    Sub TerminateInstance()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Rez = MsgBox("Do you want to terminate " + InstanceID + "?", MsgBoxStyle.YesNo, "TERMINATE instance")

        If Rez = MsgBoxResult.Yes Then

            AmazonApi.TerminateInstance(CurrentAccount, InstanceID)

        End If

    End Sub

    Sub StartInstance()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Rez = MsgBox("Start instance: " + InstanceID + "?", MsgBoxStyle.YesNo, "Start instance")

        If Rez = MsgBoxResult.Yes Then

            AmazonApi.StartInstance(CurrentAccount, InstanceID)

        End If

    End Sub

    Sub StopInstance()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Rez = MsgBox("Stop instance: " + InstanceID + "?", MsgBoxStyle.YesNo, "Stop instance")

        If Rez = MsgBoxResult.Yes Then

            AmazonApi.StopInstance(CurrentAccount, InstanceID)

        End If

    End Sub

    Sub RebootInstance()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Rez = MsgBox("Reboot instance: " + InstanceID + "?", MsgBoxStyle.YesNo, "Reboot instance")

        If Rez = MsgBoxResult.Yes Then

            AmazonApi.RebootInstance(CurrentAccount, InstanceID)

        End If

    End Sub

    Sub GetWindowsPasswordForm()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Instance As Amazon.EC2.Model.Instance = InstanceTable.Item(InstanceID)

        Dim FormWP = New GetWindowsPassword
        FormWP.CurrentAccount = CurrentAccount
        FormWP.InstanceId = InstanceID
        FormWP.InstanceKey = Instance.KeyName
        FormWP.StartPosition = FormStartPosition.CenterParent
        FormWP.ShowDialog()

    End Sub

    Sub ChangeIamRole()

        Dim InstanceID = GetSelectedInstanceId()

        'Dim Instance As Amazon.EC2.Model.Instance = InstanceTable.Item(InstanceID)

        Dim FormWP = New ChangeIamRole
        FormWP.CurrentAccount = CurrentAccount
        FormWP.InstanceId = InstanceID
        FormWP.StartPosition = FormStartPosition.CenterParent
        FormWP.ShowDialog()

    End Sub

    Sub ChangeInstanceType()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Instance As Amazon.EC2.Model.Instance = InstanceTable.Item(InstanceID)

        Dim FormWP = New ChangeInstanceType
        FormWP.CurrentAccount = CurrentAccount
        FormWP.Instance = Instance
        FormWP.InstanceTypeList = InstanceTypesList
        FormWP.StartPosition = FormStartPosition.CenterParent
        FormWP.ShowDialog()

    End Sub

    Sub ChangeTerminationProtection()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Instance As Amazon.EC2.Model.Instance = InstanceTable.Item(InstanceID)

        Dim FormWP = New ChangeTermintationProtection
        FormWP.CurrentAccount = CurrentAccount
        FormWP.InstanceId = InstanceID
        FormWP.StartPosition = FormStartPosition.CenterParent
        FormWP.ShowDialog()

    End Sub

    Sub GetConsoleScreenshot()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Instance As Amazon.EC2.Model.Instance = InstanceTable.Item(InstanceID)

        Dim FormWP = New GetConsoleScreenshot
        FormWP.CurrentAccount = CurrentAccount
        FormWP.InstanceId = InstanceID
        FormWP.StartPosition = FormStartPosition.CenterParent
        FormWP.ShowDialog()

    End Sub

    Sub EditSecurityGroups()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Instance As Amazon.EC2.Model.Instance = InstanceTable.Item(InstanceID)

        Dim FormSG = New ChangeSecurityGroupsForm
        FormSG.CurrentAccount = CurrentAccount
        FormSG.Instance = Instance
        FormSG.StartPosition = FormStartPosition.CenterParent
        FormSG.ShowDialog()

    End Sub

    Sub EditTags()

        Dim InstanceID = GetSelectedInstanceId()

        Dim FormSG = New EditTagsForm
        FormSG.CurrentAccount = CurrentAccount
        FormSG.InstanceId = InstanceID
        FormSG.StartPosition = FormStartPosition.CenterParent
        FormSG.ShowDialog()

    End Sub

    Sub EditVolume(sender As Object, e As EventArgs)

        Dim InstanceID = GetSelectedInstanceId()

        Dim Instance As Amazon.EC2.Model.Instance = InstanceTable.Item(InstanceID)

        Dim FormSG = New ModifyVolumeForm
        FormSG.CurrentAccount = CurrentAccount
        FormSG.VolumeId = sender.tag
        FormSG.StartPosition = FormStartPosition.CenterParent
        FormSG.ShowDialog()

    End Sub


    Private Sub DataListViewEC2_SelectionChanged(sender As Object, e As EventArgs) Handles DataListViewEC2.SelectionChanged

        If Not DataListViewEC2.SelectedItem Is Nothing Then

            PopulateInstanceProperties()

        End If

    End Sub

    Private Sub TreeViewInstanceProperties_MouseDown(sender As Object, e As MouseEventArgs) Handles TreeViewInstanceProperties.MouseDown

        If (e.Button = MouseButtons.Right) Then

            Dim hti = TreeViewInstanceProperties.HitTest(e.X, e.Y)

            If Not hti.Node Is Nothing Then

                TreeViewInstanceProperties.SelectedNode = hti.Node

                Dim m As ContextMenuStrip = New ContextMenuStrip()

                If Not hti.Node.Parent Is Nothing Then

                    If hti.Node.Parent.Name = "security-groups" Then

                        m.Items.Add(New ToolStripMenuItem("Edit Security Groups...", My.Resources.AddObject.ToBitmap, AddressOf EditSecurityGroups))
                        m.Items.Add(New ToolStripMenuItem("Remove this SG", My.Resources.DeleteObject.ToBitmap))

                    ElseIf hti.Node.Parent.Name = "tags" Then

                        m.Items.Add(New ToolStripMenuItem("Edit Tags"))
                        m.Items.Add(New ToolStripMenuItem("Remove this tag", My.Resources.DeleteObject.ToBitmap))

                    ElseIf hti.Node.Parent.Name = "volumes" Then

                        Dim mVolume1 As ToolStripItem = New ToolStripMenuItem("Modify Volume", Nothing, AddressOf EditVolume)
                        mVolume1.Tag = hti.Node.Name
                        m.Items.Add(mVolume1)

                        Dim mVolume2 As ToolStripItem = New ToolStripMenuItem("Volume Config History", My.Resources.Timeline.ToBitmap, AddressOf GetVolumeConfigHistory)
                        mVolume2.Tag = hti.Node.Name
                        m.Items.Add(mVolume2)

                    End If

                End If

                If m.Items.Count > 0 Then
                    m.Show(Cursor.Position)
                End If


            End If

        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Dim FormAbout = New AboutBox
        FormAbout.StartPosition = FormStartPosition.CenterParent
        FormAbout.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItemRefreshInstanceList_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemRefreshInstanceList.Click

        FillInstanceList()

    End Sub


End Class
