
Imports Amazon.EC2.Model
Imports NLog

Public Class Form1

    Private AllAccounts As List(Of AwsAccount)
    Private CurrentAccount As AwsAccount
    Private NextToken As String = Nothing

    Private InstanceTable As Hashtable = New Hashtable
    Private InstanceStatusTable As Hashtable = New Hashtable
    Private InstanceVolumesTable As Hashtable = New Hashtable

    Private InstanceTypesTable As SortedDictionary(Of String, SortedDictionary(Of String, SortedDictionary(Of String, InstanceTypeInfo))) = New SortedDictionary(Of String, SortedDictionary(Of String, SortedDictionary(Of String, InstanceTypeInfo)))

    Private UserFilterForInstances As Dictionary(Of String, List(Of String)) = New Dictionary(Of String, List(Of String))

    Public Log As Logger = LogManager.GetCurrentClassLogger()

    Sub ConfigureLogging()

        Dim Config = New NLog.Config.LoggingConfiguration()

        ' Targets where to log to File And Console
        Dim logFile = New NLog.Targets.FileTarget("logfile") With {.FileName = "${basedir}/log.txt"}

        Config.AddRuleForAllLevels(logFile)

        NLog.LogManager.Configuration = Config

        Log.Info("The application has started")

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Dim Rez = GetAccountAttributes(CurrentAccount)

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

            Dim AllKeys As String = UserFilterObject.Value.Aggregate(Function(First, nextString) First + ", " + nextString)

            Dim FilterText = UserFilterObject.Key + " = " + AllKeys

            Dim NewElement = MenuStripFilterPresentation.Items.Add(FilterText, Nothing, AddressOf onClickClearFilter)

            NewElement.Tag = UserFilterObject.Key

        Next

    End Sub

    Private Sub AddFilterByAZ(AZ As AvailabilityZone)

        If Not UserFilterForInstances.ContainsKey("availability-zone") Then
            UserFilterForInstances.Item("availability-zone") = New List(Of String)
        End If

        UserFilterForInstances.Item("availability-zone").Add(AZ.ZoneName)

    End Sub

    Private Sub AddFilterByInstanceState(InstanceState As InstanceState)

        If Not UserFilterForInstances.ContainsKey("instance-state-name") Then
            UserFilterForInstances.Item("instance-state-name") = New List(Of String)
        End If

        UserFilterForInstances.Item("instance-state-name").Add(InstanceState.Name)

    End Sub

    Private Sub onClickClearFilter(sender As Object, e As EventArgs)

        If UserFilterForInstances.ContainsKey(sender.tag) Then
            UserFilterForInstances.Remove(sender.tag)
        End If

        'UserFilterForInstances.Clear()

        RefreshFilterRepresentation()

        FillInstanceList()

    End Sub

    Private Sub onClickFilter(sender As Object, e As EventArgs)

        If TypeOf sender.tag Is AvailabilityZone Then

            AddFilterByAZ(sender.tag)

        ElseIf TypeOf sender.tag Is InstanceState Then

            AddFilterByInstanceState(sender.tag)

        Else

            'MsgBox("Click")

        End If

        RefreshFilterRepresentation()

        FillInstanceList()

    End Sub

    Sub PopulateFilterMenu()

        FilterByToolStripMenuItem.DropDownItems.Clear()

        Dim azMenu As ToolStripDropDownItem = FilterByToolStripMenuItem.DropDownItems.Add("filter-availability-zone")
        For Each AZ In Ec2Instances.ListAvailabilityZones(CurrentAccount)
            Dim a = azMenu.DropDownItems.Add(AZ.ZoneName, Nothing, AddressOf onClickFilter)
            a.Tag = AZ
        Next

        Dim tag As ToolStripDropDownItem = FilterByToolStripMenuItem.DropDownItems.Add("filter-tag")
        Dim tags = Ec2Instances.ListTags(CurrentAccount)
        For Each instanceTagDescription In tags

            Dim a As ToolStripDropDownItem = tag.DropDownItems.Add(instanceTagDescription.Key, Nothing, AddressOf onClickFilter)

        Next

        '-----------------------------------------------------------------
        Dim instanceTypes As ToolStripDropDownItem = FilterByToolStripMenuItem.DropDownItems.Add("filter-instance-type")

        InstanceTypesTable.Clear()

        'For Each instanceTypeDescription In Ec2Instances.ListInstanceTypes(CurrentAccount)

        '    Dim InstanceFirstLetter = instanceTypeDescription.InstanceType.Value.Substring(0, 1)
        '    Dim InstanceFamily = instanceTypeDescription.InstanceType.Value.Substring(0, instanceTypeDescription.InstanceType.Value.IndexOf("."))

        '    If Not InstanceTypesTable.ContainsKey(InstanceFirstLetter) Then
        '        InstanceTypesTable.Add(InstanceFirstLetter, New SortedDictionary(Of String, SortedDictionary(Of String, InstanceTypeInfo)))
        '    End If

        '    If Not InstanceTypesTable.Item(InstanceFirstLetter).ContainsKey(InstanceFamily) Then
        '        InstanceTypesTable.Item(InstanceFirstLetter).Add(InstanceFamily, New SortedDictionary(Of String, InstanceTypeInfo))
        '    End If

        '    InstanceTypesTable.Item(InstanceFirstLetter).Item(InstanceFamily).Add(instanceTypeDescription.InstanceType.Value, instanceTypeDescription)

        'Next

        For Each instanceFamilyDescription In InstanceTypesTable.Keys

            Dim a As ToolStripDropDownItem = instanceTypes.DropDownItems.Add(instanceFamilyDescription.ToString, Nothing, AddressOf onClickFilter)

            For Each instanceTypeDescription In InstanceTypesTable.Item(instanceFamilyDescription).Keys

                Dim b As ToolStripDropDownItem = a.DropDownItems.Add(instanceTypeDescription.ToString, Nothing, AddressOf onClickFilter)

                For Each instanceTypeDescription2 In InstanceTypesTable.Item(instanceFamilyDescription).Item(instanceTypeDescription)
                    b.DropDownItems.Add(instanceTypeDescription2.Key, Nothing, AddressOf onClickFilter)
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

        Dim vpc = FilterByToolStripMenuItem.DropDownItems.Add("filter-vpc")

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

        Dim InstanceList = Ec2Instances.ListEc2Instances(CurrentAccount, UserFilterForInstances, NextToken)

        If InstanceList.Count > 0 Then

            For Each instance In InstanceList
                InstanceVolumesTable.Add(instance.InstanceId, New List(Of Volume))
            Next

            Dim UserFilter = New Dictionary(Of String, List(Of String))
            UserFilter.Add("volume-id", New List(Of String))
            For Each Instance In InstanceList
                For Each BlockDeviceMappings In Instance.BlockDeviceMappings
                    Dim Volume = BlockDeviceMappings.Ebs.VolumeId
                    UserFilter.Item("volume-id").Add(Volume)
                Next
            Next

            Dim ListVolumes = Ec2Instances.ListVolumes(CurrentAccount, UserFilter)

            For Each Volume In ListVolumes
                InstanceVolumesTable.Item(Volume.Attachments.Item(0).InstanceId).Add(Volume)
            Next
            'Dim ListStatuses = Ec2Instances.ListEc2InstanceStatuses(CurrentAccount, List)

            'For Each Status In ListStatuses
            '    InstanceStatusTable.Add(Status.InstanceId, Status)
            'Next

            'LabelNextToken.Text = "Next Token: " + NextToken

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
        'Tags.NodeFont = New Font("Courier New", 9)
        'ListBoxTags.Items.Clear()
        For Each InstanceTag In Instance.Tags

            Tags.Nodes.Add(InstanceTag.Key, InstanceTag.Key + ": " + InstanceTag.Value)
            'ListBoxTags.Items.Add(InstanceTag.Key & ": " & InstanceTag.Value)

        Next

        Dim SG = TreeViewInstanceProperties.Nodes.Add("security-groups", "Security Groups")
        For Each InstanceSG In Instance.SecurityGroups
            SG.Nodes.Add(InstanceSG.GroupId, InstanceSG.GroupName & "(" & InstanceSG.GroupId & ")")
        Next

        Dim VolumeNode = TreeViewInstanceProperties.Nodes.Add("volumes", "Volumes")
        Dim Volumes = InstanceVolumesTable.Item(InstanceID)
        For Each Volume As Volume In Volumes
            VolumeNode.Nodes.Add(Volume.VolumeId, Volume.VolumeType.Value & " / " & Volume.Size.ToString & " Gb / " & Volume.Iops.ToString & " IOPS / " & Volume.Throughput & " MiB/s")
        Next

        TreeViewInstanceProperties.ExpandAll()

        'PropertyGridInstance.SelectedObject = Instance

    End Sub

    Private Sub DataListViewEC2_MouseDown(sender As Object, e As MouseEventArgs) Handles DataListViewEC2.MouseDown

        If (e.Button = MouseButtons.Right) Then

            Dim hti = DataListViewEC2.HitTest(e.X, e.Y)

            If Not hti.Item Is Nothing Then

                'DataGridEc2.ClearSelection()
                'DataGridEc2.Rows(hti.RowIndex).Selected = True

                Dim m As ContextMenuStrip = New ContextMenuStrip()
                m.Items.Add(New ToolStripMenuItem("Start", My.Resources.Play.ToBitmap, AddressOf StartInstance))
                m.Items.Add(New ToolStripMenuItem("Stop", My.Resources.StopRed.ToBitmap, AddressOf StopInstance))
                m.Items.Add(New ToolStripMenuItem("Reboot", My.Resources.Reboot.ToBitmap, AddressOf RebootInstance))
                m.Items.Add(New ToolStripMenuItem("Edit Security Groups", Nothing, AddressOf EditSecurityGroups))
                m.Items.Add(New ToolStripMenuItem("Get Windows Password", Nothing, AddressOf GetWindowsPasswordForm))
                m.Items.Add(New ToolStripMenuItem("Get Console Screenshot", Nothing, AddressOf GetConsoleScreenshot))
                m.Items.Add(New ToolStripMenuItem("Change Termination Protection", Nothing, AddressOf ChangeTerminationProtection))
                m.Items.Add(New ToolStripMenuItem("Change IAM Role", Nothing, AddressOf ChangeIamRole))
                ' m.Items.Add(New ToolStripMenuItem("Paste"))

                'm.Items.Add(New ToolStripMenuItem(String.Format("Do something to row {0}", hti.RowIndex.ToString())))

                m.Show(Cursor.Position)

            End If

        End If

    End Sub
    Function GetSelectedInstanceId() As String

        Dim ColumnNumber = 3

        Dim InstanceId As String = DataListViewEC2.FocusedItem.SubItems.Item(ColumnNumber).Text

        Return InstanceId

    End Function

    Sub StartInstance()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Rez = MsgBox("Start instance: " + InstanceID + "?", MsgBoxStyle.YesNo, "Start instance")

        If Rez = MsgBoxResult.Yes Then

            Ec2Instances.StartInstance(CurrentAccount, InstanceID)

        End If

    End Sub

    Sub StopInstance()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Rez = MsgBox("Stop instance: " + InstanceID + "?", MsgBoxStyle.YesNo, "Stop instance")

        If Rez = MsgBoxResult.Yes Then

            Ec2Instances.StopInstance(CurrentAccount, InstanceID)

        End If

    End Sub

    Sub RebootInstance()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Rez = MsgBox("Reboot instance: " + InstanceID + "?", MsgBoxStyle.YesNo, "Reboot instance")

        If Rez = MsgBoxResult.Yes Then

            Ec2Instances.RebootInstance(CurrentAccount, InstanceID)

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
                'TreeViewInstanceProperties.Rows(hti.RowIndex).Selected = True

                'Dim IconAdd = AmbientProperties.
                'My.Resources.AddObject.ToBitmap()

                Dim m As ContextMenuStrip = New ContextMenuStrip()

                If Not hti.Node.Parent Is Nothing Then

                    If hti.Node.Parent.Name = "security-groups" Then
                        m.Items.Add(New ToolStripMenuItem("Edit Security Groups...", My.Resources.AddObject.ToBitmap, AddressOf EditSecurityGroups))
                        m.Items.Add(New ToolStripMenuItem("Remove this SG", My.Resources.DeleteObject.ToBitmap))
                    ElseIf hti.Node.Parent.Name = "tags" Then
                        m.Items.Add(New ToolStripMenuItem("Edit Tags"))
                        m.Items.Add(New ToolStripMenuItem("Remove this tag", My.Resources.DeleteObject.ToBitmap))
                    ElseIf hti.Node.Parent.Name = "volumes" Then

                        Dim mVolume As ToolStripItem = New ToolStripMenuItem("Modify Volume", Nothing, AddressOf EditVolume)
                        mVolume.Tag = hti.Node.Name
                        m.Items.Add(mVolume)

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
