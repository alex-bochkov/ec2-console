﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelCurrentRegion = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RussianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageEC2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataListViewEC2 = New BrightIdeasSoftware.DataListView()
        Me.MenuStripInstanceFilter = New System.Windows.Forms.MenuStrip()
        Me.RefreshInstanceListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxFilterByTag = New System.Windows.Forms.ToolStripComboBox()
        Me.FilterByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFilterPresentation = New System.Windows.Forms.MenuStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageDetails = New System.Windows.Forms.TabPage()
        Me.TabPageNetworking = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonChangeSecurityGroups = New System.Windows.Forms.Button()
        Me.ListViewInstanceSG = New System.Windows.Forms.ListView()
        Me.ColumnHeaderInstanceSgId = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderInstanceSgName = New System.Windows.Forms.ColumnHeader()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListViewInstanceNetworkProperties = New System.Windows.Forms.ListView()
        Me.ColumnHeaderNetworkPropertyKey = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderNetworkPropertyValue = New System.Windows.Forms.ColumnHeader()
        Me.TabPageStorage = New System.Windows.Forms.TabPage()
        Me.ListViewInstanceVolumes = New System.Windows.Forms.ListView()
        Me.ColumnHeaderVolumeID = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderDeviceName = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderVolumeType = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderSize = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderAttachmentTime = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderEncrypted = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderKmsKeyId = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderDeleteOnTermination = New System.Windows.Forms.ColumnHeader()
        Me.TabPageStatusCheck = New System.Windows.Forms.TabPage()
        Me.TabPageMonitoring = New System.Windows.Forms.TabPage()
        Me.TabPageTags = New System.Windows.Forms.TabPage()
        Me.ButtonEditTags = New System.Windows.Forms.Button()
        Me.ListViewInstanceTags = New System.Windows.Forms.ListView()
        Me.ColumnHeaderKey = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderValue = New System.Windows.Forms.ColumnHeader()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStripMain.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPageEC2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataListViewEC2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripInstanceFilter.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageNetworking.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPageStorage.SuspendLayout()
        Me.TabPageTags.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelCurrentRegion})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 614)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(941, 22)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelCurrentRegion
        '
        Me.ToolStripStatusLabelCurrentRegion.Name = "ToolStripStatusLabelCurrentRegion"
        Me.ToolStripStatusLabelCurrentRegion.Size = New System.Drawing.Size(76, 20)
        Me.ToolStripStatusLabelCurrentRegion.Text = "< region >"
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountsToolStripMenuItem, Me.LanguageToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(941, 24)
        Me.MenuStripMain.TabIndex = 1
        Me.MenuStripMain.Text = "MenuStrip1"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.AccountsToolStripMenuItem.Text = "Add New Account"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishToolStripMenuItem, Me.RussianToolStripMenuItem})
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.LanguageToolStripMenuItem.Text = "Language"
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        Me.EnglishToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.EnglishToolStripMenuItem.Text = "English"
        '
        'RussianToolStripMenuItem
        '
        Me.RussianToolStripMenuItem.Name = "RussianToolStripMenuItem"
        Me.RussianToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.RussianToolStripMenuItem.Text = "Russian"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageEC2)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 24)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(941, 590)
        Me.TabControl.TabIndex = 4
        '
        'TabPageEC2
        '
        Me.TabPageEC2.Controls.Add(Me.Panel2)
        Me.TabPageEC2.Location = New System.Drawing.Point(4, 24)
        Me.TabPageEC2.Name = "TabPageEC2"
        Me.TabPageEC2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEC2.Size = New System.Drawing.Size(933, 562)
        Me.TabPageEC2.TabIndex = 0
        Me.TabPageEC2.Text = "Instances"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SplitContainer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(927, 556)
        Me.Panel2.TabIndex = 12
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataListViewEC2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuStripInstanceFilter)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuStripFilterPresentation)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(927, 556)
        Me.SplitContainer1.SplitterDistance = 279
        Me.SplitContainer1.TabIndex = 0
        '
        'DataListViewEC2
        '
        Me.DataListViewEC2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataListViewEC2.CellEditUseWholeCell = False
        Me.DataListViewEC2.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataListViewEC2.DataSource = Nothing
        Me.DataListViewEC2.FullRowSelect = True
        Me.DataListViewEC2.HideSelection = False
        Me.DataListViewEC2.IsSearchOnSortColumn = False
        Me.DataListViewEC2.Location = New System.Drawing.Point(3, 27)
        Me.DataListViewEC2.Name = "DataListViewEC2"
        Me.DataListViewEC2.ShowGroups = False
        Me.DataListViewEC2.Size = New System.Drawing.Size(921, 249)
        Me.DataListViewEC2.TabIndex = 9
        Me.DataListViewEC2.UseFiltering = True
        Me.DataListViewEC2.View = System.Windows.Forms.View.Details
        '
        'MenuStripInstanceFilter
        '
        Me.MenuStripInstanceFilter.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripInstanceFilter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshInstanceListToolStripMenuItem, Me.FilterByToolStripMenuItem, Me.ToolStripTextBoxFilterByTag})
        Me.MenuStripInstanceFilter.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripInstanceFilter.Name = "MenuStripInstanceFilter"
        Me.MenuStripInstanceFilter.Size = New System.Drawing.Size(377, 27)
        Me.MenuStripInstanceFilter.TabIndex = 10
        Me.MenuStripInstanceFilter.Text = "MenuStrip2"
        '
        'RefreshInstanceListToolStripMenuItem
        '
        Me.RefreshInstanceListToolStripMenuItem.Name = "RefreshInstanceListToolStripMenuItem"
        Me.RefreshInstanceListToolStripMenuItem.Size = New System.Drawing.Size(58, 23)
        Me.RefreshInstanceListToolStripMenuItem.Text = "Refresh"
        '
        'ToolStripTextBoxFilterByTag
        '
        Me.ToolStripTextBoxFilterByTag.Name = "ToolStripTextBoxFilterByTag"
        Me.ToolStripTextBoxFilterByTag.Size = New System.Drawing.Size(200, 23)
        Me.ToolStripTextBoxFilterByTag.ToolTipText = "Filter by Tag"
        '
        'FilterByToolStripMenuItem
        '
        Me.FilterByToolStripMenuItem.Name = "FilterByToolStripMenuItem"
        Me.FilterByToolStripMenuItem.Size = New System.Drawing.Size(109, 23)
        Me.FilterByToolStripMenuItem.Text = "Filter by Property"
        '
        'MenuStripFilterPresentation
        '
        Me.MenuStripFilterPresentation.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MenuStripFilterPresentation.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripFilterPresentation.Location = New System.Drawing.Point(377, 0)
        Me.MenuStripFilterPresentation.Name = "MenuStripFilterPresentation"
        Me.MenuStripFilterPresentation.Size = New System.Drawing.Size(128, 24)
        Me.MenuStripFilterPresentation.TabIndex = 11
        Me.MenuStripFilterPresentation.Text = "MenuStrip2"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPageDetails)
        Me.TabControl1.Controls.Add(Me.TabPageNetworking)
        Me.TabControl1.Controls.Add(Me.TabPageStorage)
        Me.TabControl1.Controls.Add(Me.TabPageStatusCheck)
        Me.TabControl1.Controls.Add(Me.TabPageMonitoring)
        Me.TabControl1.Controls.Add(Me.TabPageTags)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(928, 271)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageDetails
        '
        Me.TabPageDetails.Location = New System.Drawing.Point(4, 24)
        Me.TabPageDetails.Name = "TabPageDetails"
        Me.TabPageDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDetails.Size = New System.Drawing.Size(920, 243)
        Me.TabPageDetails.TabIndex = 0
        Me.TabPageDetails.Text = "Details"
        Me.TabPageDetails.UseVisualStyleBackColor = True
        '
        'TabPageNetworking
        '
        Me.TabPageNetworking.Controls.Add(Me.SplitContainer2)
        Me.TabPageNetworking.Location = New System.Drawing.Point(4, 24)
        Me.TabPageNetworking.Name = "TabPageNetworking"
        Me.TabPageNetworking.Size = New System.Drawing.Size(920, 243)
        Me.TabPageNetworking.TabIndex = 2
        Me.TabPageNetworking.Text = "Networking"
        Me.TabPageNetworking.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(920, 243)
        Me.SplitContainer2.SplitterDistance = 306
        Me.SplitContainer2.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonChangeSecurityGroups)
        Me.GroupBox1.Controls.Add(Me.ListViewInstanceSG)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 243)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Security Groups"
        '
        'ButtonChangeSecurityGroups
        '
        Me.ButtonChangeSecurityGroups.Location = New System.Drawing.Point(5, 18)
        Me.ButtonChangeSecurityGroups.Name = "ButtonChangeSecurityGroups"
        Me.ButtonChangeSecurityGroups.Size = New System.Drawing.Size(75, 23)
        Me.ButtonChangeSecurityGroups.TabIndex = 4
        Me.ButtonChangeSecurityGroups.Text = "Change"
        Me.ButtonChangeSecurityGroups.UseVisualStyleBackColor = True
        '
        'ListViewInstanceSG
        '
        Me.ListViewInstanceSG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewInstanceSG.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderInstanceSgId, Me.ColumnHeaderInstanceSgName})
        Me.ListViewInstanceSG.FullRowSelect = True
        Me.ListViewInstanceSG.GridLines = True
        Me.ListViewInstanceSG.HideSelection = False
        Me.ListViewInstanceSG.Location = New System.Drawing.Point(1, 47)
        Me.ListViewInstanceSG.Name = "ListViewInstanceSG"
        Me.ListViewInstanceSG.ShowGroups = False
        Me.ListViewInstanceSG.Size = New System.Drawing.Size(299, 190)
        Me.ListViewInstanceSG.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewInstanceSG.TabIndex = 3
        Me.ListViewInstanceSG.UseCompatibleStateImageBehavior = False
        Me.ListViewInstanceSG.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderInstanceSgId
        '
        Me.ColumnHeaderInstanceSgId.Text = "Security Group ID"
        Me.ColumnHeaderInstanceSgId.Width = 150
        '
        'ColumnHeaderInstanceSgName
        '
        Me.ColumnHeaderInstanceSgName.Text = "Name"
        Me.ColumnHeaderInstanceSgName.Width = 250
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListViewInstanceNetworkProperties)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 243)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Network Attributes"
        '
        'ListViewInstanceNetworkProperties
        '
        Me.ListViewInstanceNetworkProperties.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewInstanceNetworkProperties.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderNetworkPropertyKey, Me.ColumnHeaderNetworkPropertyValue})
        Me.ListViewInstanceNetworkProperties.FullRowSelect = True
        Me.ListViewInstanceNetworkProperties.GridLines = True
        Me.ListViewInstanceNetworkProperties.HideSelection = False
        Me.ListViewInstanceNetworkProperties.Location = New System.Drawing.Point(6, 47)
        Me.ListViewInstanceNetworkProperties.Name = "ListViewInstanceNetworkProperties"
        Me.ListViewInstanceNetworkProperties.ShowGroups = False
        Me.ListViewInstanceNetworkProperties.Size = New System.Drawing.Size(598, 190)
        Me.ListViewInstanceNetworkProperties.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewInstanceNetworkProperties.TabIndex = 2
        Me.ListViewInstanceNetworkProperties.UseCompatibleStateImageBehavior = False
        Me.ListViewInstanceNetworkProperties.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderNetworkPropertyKey
        '
        Me.ColumnHeaderNetworkPropertyKey.Text = "Property"
        Me.ColumnHeaderNetworkPropertyKey.Width = 200
        '
        'ColumnHeaderNetworkPropertyValue
        '
        Me.ColumnHeaderNetworkPropertyValue.Text = "Value"
        Me.ColumnHeaderNetworkPropertyValue.Width = 200
        '
        'TabPageStorage
        '
        Me.TabPageStorage.Controls.Add(Me.ListViewInstanceVolumes)
        Me.TabPageStorage.Location = New System.Drawing.Point(4, 24)
        Me.TabPageStorage.Name = "TabPageStorage"
        Me.TabPageStorage.Size = New System.Drawing.Size(920, 243)
        Me.TabPageStorage.TabIndex = 3
        Me.TabPageStorage.Text = "Storage"
        Me.TabPageStorage.UseVisualStyleBackColor = True
        '
        'ListViewInstanceVolumes
        '
        Me.ListViewInstanceVolumes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderVolumeID, Me.ColumnHeaderDeviceName, Me.ColumnHeaderVolumeType, Me.ColumnHeaderSize, Me.ColumnHeaderAttachmentTime, Me.ColumnHeaderEncrypted, Me.ColumnHeaderKmsKeyId, Me.ColumnHeaderDeleteOnTermination})
        Me.ListViewInstanceVolumes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewInstanceVolumes.FullRowSelect = True
        Me.ListViewInstanceVolumes.GridLines = True
        Me.ListViewInstanceVolumes.HideSelection = False
        Me.ListViewInstanceVolumes.Location = New System.Drawing.Point(0, 0)
        Me.ListViewInstanceVolumes.Name = "ListViewInstanceVolumes"
        Me.ListViewInstanceVolumes.ShowGroups = False
        Me.ListViewInstanceVolumes.Size = New System.Drawing.Size(920, 243)
        Me.ListViewInstanceVolumes.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewInstanceVolumes.TabIndex = 1
        Me.ListViewInstanceVolumes.UseCompatibleStateImageBehavior = False
        Me.ListViewInstanceVolumes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderVolumeID
        '
        Me.ColumnHeaderVolumeID.Text = "Volume ID"
        Me.ColumnHeaderVolumeID.Width = 150
        '
        'ColumnHeaderDeviceName
        '
        Me.ColumnHeaderDeviceName.Text = "Device Name"
        Me.ColumnHeaderDeviceName.Width = 100
        '
        'ColumnHeaderVolumeType
        '
        Me.ColumnHeaderVolumeType.Text = "Type"
        '
        'ColumnHeaderSize
        '
        Me.ColumnHeaderSize.Text = "Size"
        '
        'ColumnHeaderAttachmentTime
        '
        Me.ColumnHeaderAttachmentTime.Text = "Attachment time"
        Me.ColumnHeaderAttachmentTime.Width = 140
        '
        'ColumnHeaderEncrypted
        '
        Me.ColumnHeaderEncrypted.Text = "Encrypted"
        '
        'ColumnHeaderKmsKeyId
        '
        Me.ColumnHeaderKmsKeyId.Text = "KMS key ID"
        Me.ColumnHeaderKmsKeyId.Width = 100
        '
        'ColumnHeaderDeleteOnTermination
        '
        Me.ColumnHeaderDeleteOnTermination.Text = "Delete on Termination"
        Me.ColumnHeaderDeleteOnTermination.Width = 140
        '
        'TabPageStatusCheck
        '
        Me.TabPageStatusCheck.Location = New System.Drawing.Point(4, 24)
        Me.TabPageStatusCheck.Name = "TabPageStatusCheck"
        Me.TabPageStatusCheck.Size = New System.Drawing.Size(920, 243)
        Me.TabPageStatusCheck.TabIndex = 4
        Me.TabPageStatusCheck.Text = "Status Check"
        Me.TabPageStatusCheck.UseVisualStyleBackColor = True
        '
        'TabPageMonitoring
        '
        Me.TabPageMonitoring.Location = New System.Drawing.Point(4, 24)
        Me.TabPageMonitoring.Name = "TabPageMonitoring"
        Me.TabPageMonitoring.Size = New System.Drawing.Size(920, 243)
        Me.TabPageMonitoring.TabIndex = 5
        Me.TabPageMonitoring.Text = "Monitoring"
        Me.TabPageMonitoring.UseVisualStyleBackColor = True
        '
        'TabPageTags
        '
        Me.TabPageTags.Controls.Add(Me.ButtonEditTags)
        Me.TabPageTags.Controls.Add(Me.ListViewInstanceTags)
        Me.TabPageTags.Location = New System.Drawing.Point(4, 24)
        Me.TabPageTags.Name = "TabPageTags"
        Me.TabPageTags.Size = New System.Drawing.Size(920, 243)
        Me.TabPageTags.TabIndex = 6
        Me.TabPageTags.Text = "Tags"
        Me.TabPageTags.UseVisualStyleBackColor = True
        '
        'ButtonEditTags
        '
        Me.ButtonEditTags.Location = New System.Drawing.Point(0, 0)
        Me.ButtonEditTags.Name = "ButtonEditTags"
        Me.ButtonEditTags.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditTags.TabIndex = 1
        Me.ButtonEditTags.Text = "Edit Tags"
        Me.ButtonEditTags.UseVisualStyleBackColor = True
        '
        'ListViewInstanceTags
        '
        Me.ListViewInstanceTags.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewInstanceTags.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderKey, Me.ColumnHeaderValue})
        Me.ListViewInstanceTags.FullRowSelect = True
        Me.ListViewInstanceTags.GridLines = True
        Me.ListViewInstanceTags.HideSelection = False
        Me.ListViewInstanceTags.Location = New System.Drawing.Point(0, 26)
        Me.ListViewInstanceTags.Name = "ListViewInstanceTags"
        Me.ListViewInstanceTags.ShowGroups = False
        Me.ListViewInstanceTags.Size = New System.Drawing.Size(920, 217)
        Me.ListViewInstanceTags.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewInstanceTags.TabIndex = 0
        Me.ListViewInstanceTags.UseCompatibleStateImageBehavior = False
        Me.ListViewInstanceTags.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderKey
        '
        Me.ColumnHeaderKey.Text = "Key"
        Me.ColumnHeaderKey.Width = 200
        '
        'ColumnHeaderValue
        '
        Me.ColumnHeaderValue.Text = "Value"
        Me.ColumnHeaderValue.Width = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 636)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStripMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripMain
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AWS EC2 Console"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPageEC2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataListViewEC2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripInstanceFilter.ResumeLayout(False)
        Me.MenuStripInstanceFilter.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageNetworking.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPageStorage.ResumeLayout(False)
        Me.TabPageTags.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents MenuStripMain As MenuStrip
    Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPageEC2 As TabPage
    Friend WithEvents DataListViewEC2 As BrightIdeasSoftware.DataListView
    Friend WithEvents MenuStripInstanceFilter As MenuStrip
    Friend WithEvents FilterByToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStripFilterPresentation As MenuStrip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LanguageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RussianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabelCurrentRegion As ToolStripDropDownButton
    Friend WithEvents RefreshInstanceListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageDetails As TabPage
    Friend WithEvents TabPageNetworking As TabPage
    Friend WithEvents TabPageStorage As TabPage
    Friend WithEvents TabPageStatusCheck As TabPage
    Friend WithEvents TabPageMonitoring As TabPage
    Friend WithEvents TabPageTags As TabPage
    Friend WithEvents ListViewInstanceTags As ListView
    Friend WithEvents ColumnHeaderKey As ColumnHeader
    Friend WithEvents ColumnHeaderValue As ColumnHeader
    Friend WithEvents ListViewInstanceVolumes As ListView
    Friend WithEvents ColumnHeaderVolumeID As ColumnHeader
    Friend WithEvents ColumnHeaderDeviceName As ColumnHeader
    Friend WithEvents ColumnHeaderSize As ColumnHeader
    Friend WithEvents ColumnHeaderAttachmentTime As ColumnHeader
    Friend WithEvents ColumnHeaderEncrypted As ColumnHeader
    Friend WithEvents ColumnHeaderKmsKeyId As ColumnHeader
    Friend WithEvents ColumnHeaderDeleteOnTermination As ColumnHeader
    Friend WithEvents ListViewInstanceNetworkProperties As ListView
    Friend WithEvents ColumnHeaderNetworkPropertyKey As ColumnHeader
    Friend WithEvents ColumnHeaderNetworkPropertyValue As ColumnHeader
    Friend WithEvents ListViewInstanceSG As ListView
    Friend WithEvents ColumnHeaderInstanceSgId As ColumnHeader
    Friend WithEvents ColumnHeaderInstanceSgName As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonChangeSecurityGroups As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonEditTags As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents ColumnHeaderVolumeType As ColumnHeader
    Friend WithEvents ToolStripTextBoxFilterByTag As ToolStripComboBox
End Class
