Imports System.Threading
Imports NLog
Imports OxyPlot
Imports OxyPlot.Axes
Imports OxyPlot.Series

Public Class Form1

    Private AllAccounts As List(Of AwsAccount)
    Private CurrentAccount As AwsAccount

    Dim InstanceDataSource As DataTable = New DataTable

    Private InstanceTable As Hashtable = New Hashtable
    Private InstanceVolumesTable As Hashtable = New Hashtable
    Private InstanceStatusTable As Dictionary(Of String, Amazon.EC2.Model.InstanceStatus) = New Dictionary(Of String, Amazon.EC2.Model.InstanceStatus)

    Private InstanceTypesList As List(Of Amazon.EC2.Model.InstanceTypeInfo)

    Private InstanceTypesTable As SortedDictionary(Of String, SortedDictionary(Of String, SortedDictionary(Of String, Amazon.EC2.Model.InstanceTypeInfo))) =
        New SortedDictionary(Of String, SortedDictionary(Of String, SortedDictionary(Of String, Amazon.EC2.Model.InstanceTypeInfo)))

    Private UserFilterForInstances As Dictionary(Of String, List(Of String)) = New Dictionary(Of String, List(Of String))

    Private AggregatedTags As SortedDictionary(Of String, List(Of String)) = New SortedDictionary(Of String, List(Of String))

    Private Log As Logger = LogManager.GetCurrentClassLogger()

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

    Sub CheckForTheAppUpdatesAndtrackUsage_Async()

        Try

            Dim LatestRelease = ServiceFunctions.GetTheMostRecentReleaseFromGithub()

            Dim LatestVersion As Version = Version.Parse(LatestRelease.tag_name)

            Dim CurrentVersionNumber = My.Application.Info.Version

            If CurrentVersionNumber.CompareTo(LatestVersion) < 0 Then

                Dim msg = String.Format(ServiceFunctions.GetLocalizedMessage("please-download-new-version"), LatestRelease.tag_name, LatestRelease.published_at)

                Invoke(New Action(Sub()
                                      AddUpdateButton(msg)
                                  End Sub))

            End If

        Catch ex As Exception

        End Try

        'send tracking API request
        Try

            'just to test that it works
            Dim TrackingURL = "https://x4w5djqv79.execute-api.us-west-2.amazonaws.com/prod/ping"
            Dim request As Net.HttpWebRequest = Net.WebRequest.Create(TrackingURL)
            request.Method = "PUT"
            request.ContentType = "application/json"

            Dim webStream As IO.Stream = request.GetRequestStream()
            Dim requestWriter As IO.StreamWriter = New IO.StreamWriter(webStream, System.Text.Encoding.ASCII)
            requestWriter.Write("Hello!")

            Try

                Dim webResponse As Net.WebResponse = request.GetResponse()
                Dim webStreamResponse As IO.Stream = webResponse.GetResponseStream()
                Dim responseReader As IO.StreamReader = New IO.StreamReader(webStreamResponse)
                Dim response As String = responseReader.ReadToEnd()
                Dim a = 0

            Catch ex As Exception

            End Try

        Catch ex As Exception

        End Try

    End Sub

    Sub AddUpdateButton(msg As String)

        Dim mVer = New ToolStripButton(msg, Nothing, AddressOf GoToDownloadPage)
        StatusStrip.Items.Add(mVer)
        StatusStrip.Items.Add(New ToolStripSeparator)

    End Sub

    Sub GoToDownloadPage()

        'this one doesn't work in .NET Core
        'Process.Start("https://github.com/alex-bochkov/ec2-console/releases")

        Process.Start(New ProcessStartInfo("cmd", $"/c start https://github.com/alex-bochkov/ec2-console/releases") With {.CreateNoWindow = True})

    End Sub

    Sub CreateInstanceDataSource()

        'table.Columns.Add("RowSelected", GetType(Boolean))
        InstanceDataSource.Columns.Clear()

        InstanceDataSource.Columns.Add("#", GetType(Integer))
        InstanceDataSource.Columns.Add("Name", GetType(String))
        InstanceDataSource.Columns.Add("State", GetType(String))
        InstanceDataSource.Columns.Add("StatusCheck", GetType(String))
        InstanceDataSource.Columns.Add("InstanceId", GetType(String))
        InstanceDataSource.Columns.Add("InstanceType", GetType(String))
        InstanceDataSource.Columns.Add("PrivateIpAddress", GetType(String))
        InstanceDataSource.Columns.Add("PlatformDetails", GetType(String))
        InstanceDataSource.Columns.Add("LaunchTime", GetType(DateTime))
        'InstanceDataSource.Columns.Add("AverageCpuUtilizationPastHour", GetType(Integer))
        InstanceDataSource.Columns.Add("NumberOfVolumes", GetType(Integer))
        InstanceDataSource.Columns.Add("NumberOfSecurityGroups", GetType(Integer))
        InstanceDataSource.Columns.Add("NumberOfTags", GetType(Integer))
        InstanceDataSource.Columns.Add("NumberOfCores", GetType(Integer))

        DataListViewEC2.DataSource = InstanceDataSource

        For Each Column As ColumnHeader In DataListViewEC2.Columns

            Select Case Column.Name
                Case "#"
                    Column.Width = 50

                Case "Name"
                    Column.Width = 300

                Case "State"
                    Column.Width = 80

                Case "StatusCheck"
                    Column.Width = 120
                    Column.Text = "Status Check"

                Case "InstanceId"
                    Column.Width = 180

                Case "InstanceType"
                    Column.Width = 120

                Case "PrivateIpAddress"
                    Column.Width = 150

                Case "PlatformDetails"
                    Column.Width = 150

                Case "LaunchTime"
                    Column.Width = 200

                Case "AverageCpuUtilizationPastHour"
                    Column.Width = 100
                    Column.Text = "avg CPU %"
                    Column.TextAlign = HorizontalAlignment.Right

                Case "NumberOfVolumes"
                    Column.Width = 60
                    Column.Text = "# vol."
                    Column.TextAlign = HorizontalAlignment.Right

                Case "NumberOfSecurityGroups"
                    Column.Width = 60
                    Column.Text = "# SGs"
                    Column.TextAlign = HorizontalAlignment.Right

                Case "NumberOfTags"
                    Column.Width = 60
                    Column.Text = "# tags"
                    Column.TextAlign = HorizontalAlignment.Right

                Case "NumberOfCores"
                    Column.Width = 70
                    Column.Text = "# cores"
                    Column.TextAlign = HorizontalAlignment.Right

                Case Else
                    Column.Width = 100
            End Select

        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CreateInstanceDataSource()

        ToolStripStatusLabelCurrentVersion.Text = "Current Version: " + My.Application.Info.Version.ToString

        LocalizeInterface()

        Dim t As New Thread(New ThreadStart(AddressOf CheckForTheAppUpdatesAndtrackUsage_Async))
        t.Priority = Threading.ThreadPriority.Normal
        t.Start()

        ConfigureLogging()

        Try

            SetFirstCurrentAccount()

        Catch ex As Exception

            Dim errorMessage As String = ex.Message

        End Try

    End Sub
    Sub ShowAllRegions()

        ToolStripStatusLabelCurrentRegion.DropDownItems.Clear()

        If CurrentAccount IsNot Nothing Then

            For Each AwsRegion In AmazonApi.GetAllAwsRegions()

                If CurrentAccount.EnabledRegions.Contains(AwsRegion.SystemName) Or CurrentAccount.EnabledRegions.Count = 0 Then

                    Dim ItemText = AwsRegion.SystemName + " / " + AwsRegion.DisplayName

                    Dim Item = ToolStripStatusLabelCurrentRegion.DropDownItems.Add(ItemText, Nothing, AddressOf ToolStripMenuItemRegion_Click)
                    Item.Tag = AwsRegion

                End If


            Next

        End If

    End Sub

    Private Sub ToolStripMenuItemRegion_Click(sender As Object, e As EventArgs)

        ChangeRegion(sender.tag)

    End Sub

    Sub ChangeRegion(AwsRegion As Amazon.RegionEndpoint)

        CurrentAccount.Region = AwsRegion.SystemName

        SetCurrentAccount()

    End Sub

    Sub ApplyDefaultInstanceFilter()

        Try

            UserFilterForInstances.Clear()

            Dim FilterText As String = CurrentAccount.DefaultInstanceFilter.Trim

            If FilterText > "" Then

                For Each FilterElement In FilterText.Split("|")
                    Dim FilterKey As String = FilterElement.Split("=").GetValue(0)
                    Dim FilterValues As String = FilterElement.Split("=").GetValue(1)

                    Dim List = New List(Of String)
                    For Each FilterValue In FilterValues.Split(",")
                        List.Add(FilterValue)
                    Next

                    UserFilterForInstances.Add(FilterKey, List)

                Next


            End If

        Catch ex As Exception

        End Try



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

        ApplyDefaultInstanceFilter()

        RefreshFilterRepresentation()

        AccountsToolStripMenuItem.Text = ServiceFunctions.GetLocalizedMessage("active-account") + ": " + CurrentAccount.Description

        Dim AwsRegion = Amazon.RegionEndpoint.GetBySystemName(CurrentAccount.Region)

        ToolStripStatusLabelCurrentRegion.Text = AwsRegion.SystemName + " / " + AwsRegion.DisplayName

        StatusStrip.BackColor = CurrentAccount.BackgroundColor

        FillInstanceList()

        PopulateFilterMenu()

        ShowAccountAttributes()

        ShowAllRegions()

    End Sub

    Sub ShowAccountAttributes()

        Dim Rez = AmazonApi.GetAccountAttributes(CurrentAccount)

        Text = ServiceFunctions.GetLocalizedMessage("app-title") + " / " _
            + ServiceFunctions.GetLocalizedMessage("current-user") + " = " + Rez.Arn

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

                Dim NewElement As ToolStripDropDownItem = MenuStripFilterPresentation.Items.Add(FilterText)
                NewElement.Tag = UserFilterObject.Key

                For Each FilterValue In UserFilterObject.Value

                    Dim NewSubElement = NewElement.DropDownItems.Add(FilterValue, Nothing, AddressOf onClickClearFilter_SingleObject)
                    NewSubElement.Tag = New Dictionary(Of String, String)
                    NewSubElement.Tag.Add(UserFilterObject.Key, FilterValue)

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

    Private Sub AddFilterByPlatform(Platform As String)

        If Not UserFilterForInstances.ContainsKey("platform") Then
            UserFilterForInstances.Item("platform") = New List(Of String)
        End If

        UserFilterForInstances.Item("platform").Add(Platform)

    End Sub

    Private Sub AddFilterByTenancy(Tenancy As String)

        If Not UserFilterForInstances.ContainsKey("tenancy") Then
            UserFilterForInstances.Item("tenancy") = New List(Of String)
        End If

        UserFilterForInstances.Item("tenancy").Add(Tenancy)

    End Sub

    Private Sub AddFilterByDetailedMonitoring(DetailedMonitoring As String)

        If Not UserFilterForInstances.ContainsKey("monitoring-state") Then
            UserFilterForInstances.Item("monitoring-state") = New List(Of String)
        End If

        UserFilterForInstances.Item("monitoring-state").Add(DetailedMonitoring)

    End Sub

    Private Sub AddFilterByTag(TagKey As String, TagValue As String)

        Dim FilterKey As String = "tag:" + TagKey

        If Not UserFilterForInstances.ContainsKey(FilterKey) Then
            UserFilterForInstances.Item(FilterKey) = New List(Of String)
        End If

        UserFilterForInstances.Item(FilterKey).Add(TagValue)

    End Sub

    Private Sub onClickClearFilter_SingleObject(sender As Object, e As EventArgs)

        Dim FilterElements As Dictionary(Of String, String) = sender.tag

        For Each FilterElement In FilterElements
            If UserFilterForInstances.ContainsKey(FilterElement.Key) Then
                If UserFilterForInstances.Item(FilterElement.Key).Contains(FilterElement.Value) Then
                    UserFilterForInstances.Item(FilterElement.Key).Remove(FilterElement.Value)
                End If
            End If
        Next

        RefreshFilterRepresentation()

        FillInstanceList()

    End Sub
    Private Sub onClickClearFilter(sender As Object, e As EventArgs)

        If UserFilterForInstances.ContainsKey(sender.tag) Then
            UserFilterForInstances.Remove(sender.tag)
        End If

        RefreshFilterRepresentation()

        FillInstanceList()

    End Sub

    Private Sub onClickFilter(sender As Object, e As EventArgs)

        If TypeOf sender Is Amazon.EC2.Model.TagDescription Then

            Dim TagDescription As Amazon.EC2.Model.TagDescription = sender

            AddFilterByTag(TagDescription.Key, TagDescription.Value)

        ElseIf TypeOf sender.tag Is Amazon.EC2.Model.AvailabilityZone Then

            AddFilterByAZ(sender.tag)

        ElseIf TypeOf sender.tag Is Amazon.EC2.Model.InstanceState Then

            AddFilterByInstanceState(sender.tag)

        ElseIf TypeOf sender.tag Is Amazon.EC2.Model.Vpc Then

            AddFilterByVpc(sender.tag)

        ElseIf TypeOf sender.tag Is Amazon.EC2.Model.Subnet Then

            AddFilterBySubnet(sender.tag)

        ElseIf TypeOf sender.tag Is String Then

            If sender.tag = "filter-instance-type" Then

                AddFilterByInstanceType(sender.text)

            ElseIf sender.tag = "filter-platform" Then

                AddFilterByPlatform(sender.text)

            ElseIf sender.tag = "filter-tenancy" Then

                AddFilterByTenancy(sender.text)

            ElseIf sender.tag = "filter-detailed-monitoring" Then

                AddFilterByDetailedMonitoring(sender.text)

            End If

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

        'Dim tag As ToolStripDropDownItem = FilterByToolStripMenuItem.DropDownItems.Add("filter-tag")
        Dim tags = AmazonApi.ListInstanceTags(CurrentAccount)

        For Each instanceTagDescription In tags

            If Not AggregatedTags.ContainsKey(instanceTagDescription.Key) Then
                AggregatedTags.Add(instanceTagDescription.Key, New List(Of String))
            End If

            If Not AggregatedTags.Item(instanceTagDescription.Key).Contains(instanceTagDescription.Value) Then
                AggregatedTags.Item(instanceTagDescription.Key).Add(instanceTagDescription.Value)
            End If

        Next

        For Each instanceTagDescription In AggregatedTags

            ToolStripTextBoxFilterByTag.Items.Add(instanceTagDescription.Key) ', Nothing, AddressOf onClickFilter)

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
        Dim detailedMonitoringFilter As ToolStripDropDownItem = FilterByToolStripMenuItem.DropDownItems.Add("filter-detailed-monitoring")
        detailedMonitoringFilter.DropDownItems.Add("disabled", Nothing, AddressOf onClickFilter).Tag = "filter-detailed-monitoring"
        detailedMonitoringFilter.DropDownItems.Add("enabled", Nothing, AddressOf onClickFilter).Tag = "filter-detailed-monitoring"

        '-----------------------------------------------------------------
        Dim platformFilter As ToolStripDropDownItem = FilterByToolStripMenuItem.DropDownItems.Add("filter-platform")
        platformFilter.DropDownItems.Add("windows", Nothing, AddressOf onClickFilter).Tag = "filter-platform"

        '-----------------------------------------------------------------
        Dim tenancyFilter As ToolStripDropDownItem = FilterByToolStripMenuItem.DropDownItems.Add("filter-tenancy")
        tenancyFilter.DropDownItems.Add("default", Nothing, AddressOf onClickFilter).Tag = "filter-tenancy"
        tenancyFilter.DropDownItems.Add("dedicated", Nothing, AddressOf onClickFilter).Tag = "filter-tenancy"
        tenancyFilter.DropDownItems.Add("host", Nothing, AddressOf onClickFilter).Tag = "filter-tenancy"

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
        '-----------------------------------------------------------------

    End Sub

    Private Sub FillInstanceList()

        DataListViewEC2.DataSource = Nothing
        InstanceDataSource.Rows.Clear()

        InstanceTable.Clear()
        InstanceStatusTable.Clear()
        InstanceVolumesTable.Clear()

        Dim InstanceList = AmazonApi.ListEc2Instances(CurrentAccount, UserFilterForInstances)

        If InstanceList.Count > 0 Then

            Dim ListRunningInstances As List(Of String) = New List(Of String)

            For Each instance In InstanceList
                'not sure what it failing on duplicates here
                If InstanceVolumesTable.ContainsKey(instance.InstanceId) Then
                    InstanceVolumesTable.Remove(instance.InstanceId)
                End If
                InstanceVolumesTable.Add(instance.InstanceId, New List(Of Amazon.EC2.Model.Volume))

                If instance.State.Name.Value = "running" Then
                    ListRunningInstances.Add(instance.InstanceId)
                End If

            Next


            Dim UserFilter = New Dictionary(Of String, List(Of String))
            UserFilter.Add("volume-id", New List(Of String))

            For Each Instance In InstanceList
                For Each BlockDeviceMappings In Instance.BlockDeviceMappings

                    Dim Volume = BlockDeviceMappings.Ebs.VolumeId
                    UserFilter.Item("volume-id").Add(Volume)


                    If UserFilter.Item("volume-id").Count = 200 Then

                        Dim ListVolumes = AmazonApi.ListVolumes(CurrentAccount, UserFilter)

                        For Each InstanceVolume In ListVolumes
                            For Each InstanceVolumeAttachment In InstanceVolume.Attachments
                                InstanceVolumesTable.Item(InstanceVolumeAttachment.InstanceId).Add(InstanceVolume)
                            Next
                        Next

                        UserFilter.Item("volume-id").Clear()

                    End If


                Next
            Next

            If UserFilter.Item("volume-id").Count > 0 Then

                Dim ListVolumes = AmazonApi.ListVolumes(CurrentAccount, UserFilter)

                For Each InstanceVolume In ListVolumes
                    For Each InstanceVolumeAttachment In InstanceVolume.Attachments
                        InstanceVolumesTable.Item(InstanceVolumeAttachment.InstanceId).Add(InstanceVolume)
                    Next
                Next

            End If

            InstanceStatusTable = AmazonApi.ListEc2InstanceStatuses(CurrentAccount, ListRunningInstances)

            'Dim AverageCPU = AmazonApi.GetCpuUtilizationPerInstance(CurrentAccount, ListRunningInstances)

            Dim i = 0
            For Each instance In InstanceList

                i = i + 1

                Dim RowRepresentation As DataRow = InstanceDataSource.NewRow()
                RowRepresentation.Item("#") = i.ToString

                For Each InstanceTag In instance.Tags

                    If InstanceTag.Key = "Name" Then
                        RowRepresentation.Item("Name") = InstanceTag.Value
                    End If

                Next

                Dim InstanceStatus As Amazon.EC2.Model.InstanceStatus = Nothing

                If InstanceStatusTable.TryGetValue(instance.InstanceId, InstanceStatus) Then

                    Dim a1 = InstanceStatus.Status.Status.Value
                    Dim a2 = InstanceStatus.SystemStatus.Status.Value

                    'TODO
                    RowRepresentation.Item("StatusCheck") = a1 + "/" + a2

                End If

                ' Dim AvgCPU As Integer = 0
                ' If AverageCPU.TryGetValue(instance.InstanceId, AvgCPU) Then
                '     RowRepresentation.Item("AverageCpuUtilizationPastHour") = AvgCPU
                ' End If

                RowRepresentation.Item("State") = instance.State.Name.Value
                RowRepresentation.Item("InstanceId") = instance.InstanceId
                RowRepresentation.Item("InstanceType") = instance.InstanceType
                RowRepresentation.Item("PrivateIpAddress") = instance.PrivateIpAddress
                RowRepresentation.Item("PlatformDetails") = instance.PlatformDetails
                RowRepresentation.Item("LaunchTime") = instance.LaunchTime

                RowRepresentation.Item("NumberOfVolumes") = instance.BlockDeviceMappings.Count
                RowRepresentation.Item("NumberOfSecurityGroups") = instance.SecurityGroups.Count
                RowRepresentation.Item("NumberOfTags") = instance.Tags.Count
                RowRepresentation.Item("NumberOfCores") = instance.CpuOptions.CoreCount

                InstanceDataSource.Rows.Add(RowRepresentation)

                'not sure what it failing on duplicates here
                If InstanceTable.ContainsKey(instance.InstanceId) Then
                    InstanceTable.Remove(instance.InstanceId)
                End If
                InstanceTable.Add(instance.InstanceId, instance)

            Next

        End If

        DataListViewEC2.DataSource = InstanceDataSource

        TabPageEC2.Text = String.Format("Instances ({0})", InstanceDataSource.Rows.Count)

    End Sub

    Sub PopulateInstanceProperties()

        Dim InstanceID = GetSelectedInstanceId()

        Dim Instance As Amazon.EC2.Model.Instance = InstanceTable.Item(InstanceID)

        If Instance Is Nothing Then
            Exit Sub
        End If

        ShowInstanceCpuUtilization(InstanceID, Instance.Monitoring.State.Value)

        '*****************************************************************
        ' Tab - Details
        TextBoxInstanceId.Text = InstanceID
        TextBoxInstanceAMI.Text = Instance.ImageId
        TextBoxInstancePlatform.Text = Instance.Platform
        TextBoxInstancePlatformDetails.Text = Instance.PlatformDetails
        TextBoxInstanceTenancy.Text = Instance.Placement.Tenancy.Value
        TextBoxInstancevCPU.Text = Instance.CpuOptions.CoreCount.ToString + " cores / " + Instance.CpuOptions.ThreadsPerCore.ToString + " threads"
        TextBoxInstanceKeyName.Text = Instance.KeyName
        TextBoxInstanceDetailedMonitoring.Text = Instance.Monitoring.State.Value
        TextBoxInstanceEbsOptimization.Text = Instance.EbsOptimized.ToString
        TextBoxInstanceType.Text = Instance.InstanceType.Value

        '*****************************************************************
        ' instance status check
        Dim InstanceStatusText As String = ""
        Dim InstanceSystemStatusText As String = ""

        Dim InstanceStatus As Amazon.EC2.Model.InstanceStatus = Nothing
        If InstanceStatusTable.TryGetValue(Instance.InstanceId, InstanceStatus) Then

            For Each StatusDetail In InstanceStatus.Status.Details
                InstanceStatusText += StatusDetail.Status.Value
                If StatusDetail.Status.Value <> "passed" Then
                    InstanceStatusText += String.Format(" ({0})", StatusDetail.ImpairedSince)
                End If
            Next
            For Each StatusDetail In InstanceStatus.SystemStatus.Details
                InstanceSystemStatusText += StatusDetail.Status.Value
                If StatusDetail.Status.Value <> "passed" Then
                    InstanceSystemStatusText += String.Format(" ({0})", StatusDetail.ImpairedSince)
                End If
            Next

        End If

        TextBoxInstanceStatus.Text = InstanceStatusText
        TextBoxInstanceSystemStatus.Text = InstanceSystemStatusText
        '*****************************************************************

        If Instance.IamInstanceProfile IsNot Nothing Then
            TextBoxInstanceIamRole.Text = Instance.IamInstanceProfile.Arn.Substring(Instance.IamInstanceProfile.Arn.IndexOf("/") + 1)
        End If
        '*****************************************************************
        ' Tab - Network
        ListViewInstanceSG.Items.Clear()
        For Each InstanceSG In Instance.SecurityGroups

            Dim ListViewItemSG As ListViewItem = New ListViewItem(InstanceSG.GroupId)
            ListViewItemSG.SubItems.Add(InstanceSG.GroupName)
            ListViewItemSG.Tag = InstanceSG

            ListViewInstanceSG.Items.Add(ListViewItemSG)

        Next

        ListViewInstanceNetworkProperties.Items.Clear()
        ListViewInstanceNetworkProperties.Items.Add(New ListViewItem({"PrivateDnsName", Instance.PrivateDnsName}))
        ListViewInstanceNetworkProperties.Items.Add(New ListViewItem({"PrivateIpAddress", Instance.PrivateIpAddress}))
        ListViewInstanceNetworkProperties.Items.Add(New ListViewItem({"VpcId", Instance.VpcId}))
        ListViewInstanceNetworkProperties.Items.Add(New ListViewItem({"SubnetId", Instance.SubnetId}))
        ListViewInstanceNetworkProperties.Items.Add(New ListViewItem({"AvailabilityZone", Instance.Placement.AvailabilityZone}))

        '*****************************************************************
        ' Tab - Storage

        Dim UserFilterVolume = New Dictionary(Of String, List(Of String))
        UserFilterVolume.Add("volume-id", New List(Of String))

        For Each InstanceVolume In Instance.BlockDeviceMappings
            UserFilterVolume.Item("volume-id").Add(InstanceVolume.Ebs.VolumeId)
        Next

        Dim Dict As Dictionary(Of String, Amazon.EC2.Model.Volume) = New Dictionary(Of String, Amazon.EC2.Model.Volume)
        Dim ListAttachedVolumes = AmazonApi.ListVolumes(CurrentAccount, UserFilterVolume)
        For Each AttachedVolume In ListAttachedVolumes
            Dict.Add(AttachedVolume.VolumeId, AttachedVolume)
        Next

        '--------------------------
        ListViewInstanceVolumes.Items.Clear()
        For Each InstanceVolumeMapping In Instance.BlockDeviceMappings

            Dim InstanceVolume = Dict.GetValueOrDefault(InstanceVolumeMapping.Ebs.VolumeId)

            If InstanceVolume IsNot Nothing Then

                Dim ListViewItemVolume As ListViewItem = New ListViewItem(InstanceVolumeMapping.Ebs.VolumeId)
                ListViewItemVolume.SubItems.Add(InstanceVolumeMapping.DeviceName)
                ListViewItemVolume.SubItems.Add(InstanceVolume.VolumeType.Value)
                ListViewItemVolume.SubItems.Add(InstanceVolume.Size)
                ListViewItemVolume.SubItems.Add(InstanceVolume.Iops)
                ListViewItemVolume.SubItems.Add(InstanceVolume.Throughput)
                ListViewItemVolume.SubItems.Add(InstanceVolumeMapping.Ebs.AttachTime.ToString)
                ListViewItemVolume.SubItems.Add(InstanceVolume.Encrypted.ToString)
                ListViewItemVolume.SubItems.Add(InstanceVolume.KmsKeyId)
                ListViewItemVolume.SubItems.Add(InstanceVolumeMapping.Ebs.DeleteOnTermination)
                ListViewItemVolume.Tag = InstanceVolumeMapping.Ebs.VolumeId

                ListViewInstanceVolumes.Items.Add(ListViewItemVolume)

            End If


        Next

        If Instance.BlockDeviceMappings.Count = 0 Then
            TabPageStorage.Text = "Storage (none)"
        Else
            TabPageStorage.Text = String.Format("Storage ({0})", Instance.BlockDeviceMappings.Count)
        End If


        '*****************************************************************
        ' Tab - Tags
        ListViewInstanceTags.Items.Clear()
        For Each InstanceTag In Instance.Tags

            Dim ListViewItemTag As ListViewItem = New ListViewItem(InstanceTag.Key)
            ListViewItemTag.SubItems.Add(InstanceTag.Value)

            ListViewInstanceTags.Items.Add(ListViewItemTag)

        Next

        If Instance.Tags.Count = 0 Then
            TabPageTags.Text = "Tags (none)"
        Else
            TabPageTags.Text = String.Format("Tags ({0})", Instance.Tags.Count)
        End If

        '*****************************************************************



    End Sub

    Sub ShowInstanceCpuUtilization(InstanceID As String, DetailedMonitoring As String)

        Dim plot = New PlotModel With {.Subtitle = "CPU Utilization for the past hour"}

        Dim LinearAxis1 = New LinearAxis
        LinearAxis1.Position = AxisPosition.Left
        LinearAxis1.Minimum = 0
        LinearAxis1.Maximum = 100
        LinearAxis1.MajorStep = 50
        LinearAxis1.MinorStep = 10
        LinearAxis1.TickStyle = TickStyle.Inside
        plot.Axes.Add(LinearAxis1)

        'Dim LinearAxis2 = New LinearAxis
        Dim LinearAxis2 = New DateTimeAxis
        LinearAxis2.Position = AxisPosition.Bottom
        LinearAxis2.Minimum = DateTimeAxis.ToDouble(Now.AddHours(-1))
        LinearAxis2.Maximum = DateTimeAxis.ToDouble(Now)
        'LinearAxis2.MajorStep = 60
        'LinearAxis2.MinorStep = 15
        LinearAxis2.TickStyle = TickStyle.Inside
        LinearAxis2.IntervalType = DateTimeIntervalType.Minutes
        plot.Axes.Add(LinearAxis2)


        Dim DetailedMonitoringEnabled As Boolean = DetailedMonitoring = "enabled"

        Dim StartDate As DateTime = Now.AddHours(-1)
        Dim EndDate As DateTime = Now

        Dim Period As Integer = 300
        If DetailedMonitoring = "enabled" Then
            Period = 60
        End If

        Dim Past60Minutes = AmazonApi.GetMetricStatistics(CurrentAccount,
                                                          "AWS/EC2", "InstanceId", InstanceID,
                                                          Period, "CPUUtilization", "Maximum", StartDate, EndDate)

        Past60Minutes.Sort(Function(elementA As Amazon.CloudWatch.Model.Datapoint, elementB As Amazon.CloudWatch.Model.Datapoint)

                               Return elementA.Timestamp.CompareTo(elementB.Timestamp)

                           End Function)

        Dim ls = New LineSeries With {.Title = String.Format("Max CPU per minute")}
        For Each DataPoint In Past60Minutes
            ls.Points.Add(New DataPoint(DateTimeAxis.ToDouble(DataPoint.Timestamp.ToLocalTime), DataPoint.Maximum))

        Next

        plot.Series.Add(ls)

        PlotViewInstanceCPU.Model = plot

    End Sub
    Private Sub ListViewInstanceVolumes_MouseDown(sender As Object, e As MouseEventArgs) Handles ListViewInstanceVolumes.MouseDown

        If (e.Button = MouseButtons.Right) Then

            Dim hti = ListViewInstanceVolumes.HitTest(e.X, e.Y)

            If Not hti.Item Is Nothing Then

                Dim m As ContextMenuStrip = New ContextMenuStrip()

                Dim mVolume1 As ToolStripItem = New ToolStripMenuItem("Modify Volume", Nothing, AddressOf EditVolume)
                mVolume1.Tag = hti.Item.Tag
                m.Items.Add(mVolume1)

                Dim mVolume2 As ToolStripItem = New ToolStripMenuItem("Volume Config History", My.Resources.Timeline.ToBitmap, AddressOf GetVolumeConfigHistory)
                mVolume2.Tag = hti.Item.Tag
                m.Items.Add(mVolume2)

                Dim mVolume3 As ToolStripItem = New ToolStripMenuItem("CloudWatch Metrics", Nothing, AddressOf OpenMetricBrowserFormVolume)
                mVolume3.Tag = hti.Item.Tag
                m.Items.Add(mVolume3)

                m.Show(Cursor.Position)

            End If

        End If

    End Sub

    Private Sub ButtonChangeSecurityGroups_Click(sender As Object, e As EventArgs) Handles ButtonChangeSecurityGroups.Click

        EditSecurityGroups()

    End Sub

    Private Sub ButtonEditTags_Click(sender As Object, e As EventArgs) Handles ButtonEditTags.Click

        EditTags()

    End Sub

    Private Sub DataListViewEC2_MouseDown(sender As Object, e As MouseEventArgs) Handles DataListViewEC2.MouseDown

        If (e.Button = MouseButtons.Right) Then

            Dim hti = DataListViewEC2.HitTest(e.X, e.Y)

            Dim OneInstanceSelected As Boolean = DataListViewEC2.SelectedItems.Count = 1

            If Not hti.Item Is Nothing Then

                Dim m As ContextMenuStrip = New ContextMenuStrip()
                m.Items.Add(New ToolStripMenuItem("Stop instance", My.Resources.StopRed.ToBitmap, AddressOf StopInstances))
                m.Items.Add(New ToolStripMenuItem("Start instance", My.Resources.Play.ToBitmap, AddressOf StartInstances))
                m.Items.Add(New ToolStripMenuItem("Reboot instance", My.Resources.Reboot.ToBitmap, AddressOf RebootInstances))
                m.Items.Add(New ToolStripMenuItem("Terminate instance", Nothing, AddressOf TerminateInstances))


                Dim m1 = New ToolStripMenuItem("Instance settings")
                m1.DropDownItems.Add(New ToolStripMenuItem("Change instance type", Nothing, AddressOf ChangeInstanceType))
                m1.DropDownItems.Add(New ToolStripMenuItem("Change termination protection", Nothing, AddressOf ChangeTerminationProtection))
                If OneInstanceSelected Then
                    m1.DropDownItems.Add(New ToolStripMenuItem("Manage tags", Nothing, AddressOf EditTags))
                End If
                m.Items.Add(m1)

                Dim m2 = New ToolStripMenuItem("Networking")
                m.Items.Add(m2)

                Dim m3 = New ToolStripMenuItem("Security")
                If OneInstanceSelected Then
                    m3.DropDownItems.Add(New ToolStripMenuItem("Change security groups", Nothing, AddressOf EditSecurityGroups))
                    m3.DropDownItems.Add(New ToolStripMenuItem("Get Windows password", Nothing, AddressOf GetWindowsPasswordForm))
                End If

                m3.DropDownItems.Add(New ToolStripMenuItem("Modify IAM Role", Nothing, AddressOf ChangeIamRole))
                m.Items.Add(m3)

                Dim m4 = New ToolStripMenuItem("Image and templates")

                m.Items.Add(m4)

                Dim m5 = New ToolStripMenuItem("Monitor and troubleshoot")
                If OneInstanceSelected Then
                    m5.DropDownItems.Add(New ToolStripMenuItem("Get instance screenshot", Nothing, AddressOf GetConsoleScreenshot))
                End If
                m.Items.Add(m5)

                Dim m6 = New ToolStripMenuItem("Storage")
                m6.DropDownItems.Add(New ToolStripMenuItem("Add New Volumes", Nothing, AddressOf OpenAddNewVolumesForm))
                m.Items.Add(m6)

                'm.Items.Add(New ToolStripMenuItem(String.Format("Do something to row {0}", hti.RowIndex.ToString())))

                m.Items.Add(New ToolStripMenuItem("Metric Browser", Nothing, AddressOf OpenMetricBrowserForm))
                If OneInstanceSelected Then
                    m.Items.Add(New ToolStripMenuItem("Instance config history", My.Resources.Timeline.ToBitmap, AddressOf GetInstanceConfigHistory))
                    m.Items.Add(New ToolStripMenuItem("Launch more like this", Nothing, AddressOf CopySelectedInstance))
                End If

                m.Show(Cursor.Position)

            End If

        End If

    End Sub
    Function GetAllSelectedInstanceIds() As List(Of String)

        Dim ResultList As List(Of String) = New List(Of String)

        Dim ColumnNumber = 4

        For Each SelectedInstance As System.Data.DataRowView In DataListViewEC2.SelectedObjects
            ResultList.Add(SelectedInstance.Row.ItemArray.GetValue(ColumnNumber))
        Next

        Return ResultList

    End Function
    Function GetSelectedInstanceId() As String

        Dim ColumnNumber = 4

        Dim InstanceId As String = DataListViewEC2.FocusedItem.SubItems.Item(ColumnNumber).Text

        Return InstanceId

    End Function

    Sub GetInstanceConfigHistory()

        Dim InstanceID = GetSelectedInstanceId()

        OpenConfigHistoryForm(InstanceID)

    End Sub

    Sub OpenMetricBrowserFormVolume(sender As Object, e As EventArgs)

        Dim VolumeList = New List(Of String)

        For Each SelectedVolume In ListViewInstanceVolumes.SelectedItems
            VolumeList.Add(SelectedVolume.tag)
        Next

        OpenMetricBrowserForm_WithVolumeIDs(VolumeList)

    End Sub

    Sub OpenMetricBrowserForm_WithVolumeIDs(VolumeIDs As List(Of String))

        Dim FormInstanceType = New MetricBrowserForm
        FormInstanceType.CurrentAccount = CurrentAccount
        FormInstanceType.ObjectType = "volume"
        FormInstanceType.ObjectIDs = VolumeIDs
        FormInstanceType.StartPosition = FormStartPosition.CenterScreen
        FormInstanceType.Show()

    End Sub

    Sub CopySelectedInstance(sender As Object, e As EventArgs)

        OpenLaunchNewInstancesForm(True)

    End Sub

    Sub GetVolumeConfigHistory(sender As Object, e As EventArgs)

        Dim VolumeId = sender.tag

        OpenConfigHistoryForm(VolumeId)

    End Sub
    Sub GetSecurityGroupConfigHistory(sender As Object, e As EventArgs)

        Dim SecurityGroupId = sender.tag

        OpenConfigHistoryForm(SecurityGroupId)

    End Sub


    Sub OpenConfigHistoryForm(ResourceId As String)

        Dim FormWP = New ObjectHistoryForm
        FormWP.CurrentAccount = CurrentAccount
        FormWP.ResourceId = ResourceId
        FormWP.StartPosition = FormStartPosition.CenterParent
        FormWP.ShowDialog()

    End Sub

    Sub TerminateInstances()

        Dim FormTerminate = New TerminateInstanceForm
        FormTerminate.CurrentAccount = CurrentAccount
        FormTerminate.InstanceIds = GetAllSelectedInstanceIds()
        FormTerminate.StartPosition = FormStartPosition.CenterScreen
        FormTerminate.Show()

    End Sub

    Sub StartInstances()

        Dim InstanceIDs = GetAllSelectedInstanceIds()

        Dim TextAllIds = vbCrLf
        For Each InstanceId In InstanceIDs
            TextAllIds += InstanceId + vbCrLf
        Next

        Dim Rez = MsgBox("Start instance: " + TextAllIds + "?", MsgBoxStyle.YesNo, "Start instance")

        If Rez = MsgBoxResult.Yes Then

            For Each InstanceId In InstanceIDs
                AmazonApi.StartInstance(CurrentAccount, InstanceId)
            Next

        End If

    End Sub

    Sub StopInstances()

        Dim InstanceIDs = GetAllSelectedInstanceIds()

        Dim FormAddVolumes = New InstanceStopForm
        FormAddVolumes.CurrentAccount = CurrentAccount
        FormAddVolumes.InstanceIDs = InstanceIDs
        'FormAddVolumes.Parent = Me
        FormAddVolumes.StartPosition = FormStartPosition.CenterScreen
        FormAddVolumes.Show()

    End Sub

    Sub RebootInstances()

        Dim InstanceIDs = GetAllSelectedInstanceIds()

        Dim TextAllIds = vbCrLf
        For Each InstanceId In InstanceIDs
            TextAllIds += InstanceId + vbCrLf
        Next

        Dim Rez = MsgBox("Reboot instance: " + TextAllIds + "?", MsgBoxStyle.YesNo, "Reboot instance")

        If Rez = MsgBoxResult.Yes Then

            For Each InstanceID In InstanceIDs
                AmazonApi.RebootInstance(CurrentAccount, InstanceID)
            Next

        End If

    End Sub
    Sub OpenAddNewVolumesForm()

        Dim InstanceID = GetSelectedInstanceId()

        Dim FormAddVolumes = New AttachNewVolumesToTheInstance
        FormAddVolumes.CurrentAccount = CurrentAccount
        FormAddVolumes.InstanceId = InstanceID
        FormAddVolumes.StartPosition = FormStartPosition.CenterScreen
        FormAddVolumes.Show()

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

        Dim InstanceIDs = GetAllSelectedInstanceIds()

        Dim FormWP = New ChangeInstanceType
        FormWP.CurrentAccount = CurrentAccount
        FormWP.InstanceIDs = InstanceIDs
        FormWP.InstanceTypeList = InstanceTypesList
        FormWP.StartPosition = FormStartPosition.CenterParent
        FormWP.Show()

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

        Dim FormEditVolume = New ModifyVolumeForm
        FormEditVolume.CurrentAccount = CurrentAccount
        FormEditVolume.VolumeId = sender.tag
        FormEditVolume.StartPosition = FormStartPosition.CenterParent
        FormEditVolume.ShowDialog()

    End Sub

    Sub EditSecurityGroup(sender As Object, e As EventArgs)

        Dim FormEditVolume = New SecurityGroupForm
        FormEditVolume.CurrentAccount = CurrentAccount
        FormEditVolume.SecurityGroupID = sender.tag
        FormEditVolume.StartPosition = FormStartPosition.CenterParent
        FormEditVolume.ShowDialog()

    End Sub

    Private Sub DataListViewEC2_SelectionChanged(sender As Object, e As EventArgs) Handles DataListViewEC2.SelectionChanged

        If Not DataListViewEC2.SelectedItem Is Nothing Then

            PopulateInstanceProperties()

        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Dim FormAbout = New AboutBox
        FormAbout.StartPosition = FormStartPosition.CenterParent
        FormAbout.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItemRefreshInstanceList_Click(sender As Object, e As EventArgs)

        FillInstanceList()

    End Sub

    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click

        ChangeUiLanguage("en-US")

    End Sub
    Private Sub RussianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RussianToolStripMenuItem.Click

        ChangeUiLanguage("ru-RU")

    End Sub

    Sub ChangeUiLanguage(Language As String)

        My.Settings.Language = Language

        LocalizeInterface()

        Dim msg = ServiceFunctions.GetLocalizedMessage("restart-the-app-language")

        MsgBox(msg)

    End Sub

    Sub LocalizeInterface()

        LanguageToolStripMenuItem.Text = ServiceFunctions.GetLocalizedMessage("language")
        EnglishToolStripMenuItem.Text = ServiceFunctions.GetLocalizedMessage("language-name-english")
        RussianToolStripMenuItem.Text = ServiceFunctions.GetLocalizedMessage("language-name-russian")

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles RefreshInstanceListToolStripMenuItem.Click

        'DataListViewEC2.DataSource = Nothing

        InstanceDataSource.Rows.Clear()

        FillInstanceList()

    End Sub

    Private Sub ButtonAddNewVolumes_Click(sender As Object, e As EventArgs) Handles ButtonAddNewVolumes.Click

        OpenAddNewVolumesForm()

    End Sub

    Private Sub ToolStripTextBoxFilterByTag_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripTextBoxFilterByTag.SelectedIndexChanged

        ToolStripTextBoxFilterByTagValue.Items.Clear()
        ToolStripTextBoxFilterByTagValue.Text = ""

        Dim TagValues = AggregatedTags.GetValueOrDefault(ToolStripTextBoxFilterByTag.SelectedItem)
        For Each TagValue In TagValues
            ToolStripTextBoxFilterByTagValue.Items.Add(TagValue)
        Next

        ToolStripTextBoxFilterByTagValue.DroppedDown = True

    End Sub

    Private Sub ToolStripTextBoxFilterByTagValue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripTextBoxFilterByTagValue.SelectedIndexChanged

        Dim TagKey As String = ToolStripTextBoxFilterByTag.SelectedItem
        Dim TagValue As String = ToolStripTextBoxFilterByTagValue.SelectedItem

        If TagValue <> "" Then

            Dim Tag = New Amazon.EC2.Model.TagDescription
            Tag.Key = TagKey
            Tag.Value = TagValue

            onClickFilter(Tag, Nothing)

        End If

    End Sub

    Private Sub ToolStripMenuItemLaunchNewInstances_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemLaunchNewInstances.Click

        OpenLaunchNewInstancesForm(False)

    End Sub

    Sub OpenLaunchNewInstancesForm(CopySelected As String)

        Dim FormLaunchNew = New LaunchNewInstancesForm
        FormLaunchNew.CurrentAccount = CurrentAccount

        If CopySelected Then
            FormLaunchNew.InstanceIdTemplate = GetSelectedInstanceId()
        End If

        FormLaunchNew.StartPosition = FormStartPosition.CenterScreen
        FormLaunchNew.Show()

    End Sub

    Private Sub ListViewInstanceSG_MouseDown(sender As Object, e As MouseEventArgs) Handles ListViewInstanceSG.MouseDown

        If (e.Button = MouseButtons.Right) Then

            Dim hti = ListViewInstanceSG.HitTest(e.X, e.Y)

            If Not hti.Item Is Nothing Then

                Dim m As ContextMenuStrip = New ContextMenuStrip()

                Dim mSG1 As ToolStripItem = New ToolStripMenuItem("Modify Security Group", Nothing, AddressOf EditSecurityGroup)
                mSG1.Tag = hti.Item.Tag.GroupID
                m.Items.Add(mSG1)

                Dim mSG2 As ToolStripItem = New ToolStripMenuItem("Security Group Config History", My.Resources.Timeline.ToBitmap, AddressOf GetSecurityGroupConfigHistory)
                mSG2.Tag = hti.Item.Tag.GroupID
                m.Items.Add(mSG2)

                m.Show(Cursor.Position)

            End If

        End If

    End Sub

    Private Sub ButtonOpenAmiForm_Click(sender As Object, e As EventArgs) Handles ButtonOpenAmiForm.Click

        Dim FormAmi = New ImageForm
        FormAmi.CurrentAccount = CurrentAccount
        FormAmi.ImageID = TextBoxInstanceAMI.Text
        FormAmi.StartPosition = FormStartPosition.CenterScreen
        FormAmi.ShowDialog()

    End Sub

    Private Sub ButtonCopyInstanceID_Click(sender As Object, e As EventArgs) Handles ButtonCopyInstanceID.Click

        My.Computer.Clipboard.SetText(TextBoxInstanceId.Text)

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

        Dim FormUserSettings = New UserSettingsForm
        FormUserSettings.StartPosition = FormStartPosition.CenterScreen
        FormUserSettings.ShowDialog()

    End Sub

    Private Sub ButtonOpenInstanceTypeForm_Click(sender As Object, e As EventArgs) Handles ButtonOpenInstanceTypeForm.Click

        For Each InstanceTypeInfo In InstanceTypesList
            If InstanceTypeInfo.InstanceType.Value = TextBoxInstanceType.Text Then

                Dim FormInstanceType = New InstanceTypeForm
                FormInstanceType.CurrentAccount = CurrentAccount
                FormInstanceType.InstanceType = TextBoxInstanceType.Text
                FormInstanceType.InstanceTypeInfo = InstanceTypeInfo
                FormInstanceType.StartPosition = FormStartPosition.CenterScreen
                FormInstanceType.ShowDialog()

                Exit For
            End If
        Next



    End Sub
    Private Sub ButtonMetricBrowser_Click(sender As Object, e As EventArgs) Handles ButtonMetricBrowser.Click

        OpenMetricBrowserForm_WithInstanceIDs(New List(Of String) From {GetSelectedInstanceId()})

    End Sub

    Sub OpenMetricBrowserForm()

        OpenMetricBrowserForm_WithInstanceIDs(GetAllSelectedInstanceIds())

    End Sub

    Sub OpenMetricBrowserForm_WithInstanceIDs(InstanceIDs As List(Of String))

        Dim FormInstanceType = New MetricBrowserForm
        FormInstanceType.CurrentAccount = CurrentAccount
        FormInstanceType.ObjectType = "instance"
        FormInstanceType.ObjectIDs = InstanceIDs
        FormInstanceType.StartPosition = FormStartPosition.CenterScreen
        FormInstanceType.Show()

    End Sub

End Class
