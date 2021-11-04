<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ToolStripStatusLabelCurrentVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemLaunchNewInstances = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RussianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageEC2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataListViewEC2 = New BrightIdeasSoftware.DataListView()
        Me.MenuStripFilterPresentation = New System.Windows.Forms.MenuStrip()
        Me.MenuStripInstanceFilter = New System.Windows.Forms.MenuStrip()
        Me.RefreshInstanceListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxFilterByTag = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripTextBoxFilterByTagValue = New System.Windows.Forms.ToolStripComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageDetails = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxInstanceSystemStatus = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxInstanceStatus = New System.Windows.Forms.TextBox()
        Me.TextBoxInstanceType = New System.Windows.Forms.TextBox()
        Me.TextBoxInstanceEbsOptimization = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxInstanceDetailedMonitoring = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxInstanceKeyName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ButtonOpenInstanceTypeForm = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxInstancevCPU = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxInstanceTenancy = New System.Windows.Forms.TextBox()
        Me.TextBoxInstanceAMI = New System.Windows.Forms.TextBox()
        Me.TextBoxInstancePlatformDetails = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxInstancePlatform = New System.Windows.Forms.TextBox()
        Me.ButtonOpenAmiForm = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxInstanceId = New System.Windows.Forms.TextBox()
        Me.ButtonCopyInstanceID = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxInstanceIamRole = New System.Windows.Forms.TextBox()
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
        Me.ButtonAddNewVolumes = New System.Windows.Forms.Button()
        Me.ListViewInstanceVolumes = New System.Windows.Forms.ListView()
        Me.ColumnHeaderVolumeID = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderDeviceName = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderVolumeType = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderSize = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderVolumeIOPS = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderVolumeThroughput = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderAttachmentTime = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderDeleteOnTermination = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderEncrypted = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderKmsKeyId = New System.Windows.Forms.ColumnHeader()
        Me.TabPageMonitoring = New System.Windows.Forms.TabPage()
        Me.PlotViewInstanceCPU = New OxyPlot.WindowsForms.PlotView()
        Me.TabPageTags = New System.Windows.Forms.TabPage()
        Me.ButtonEditTags = New System.Windows.Forms.Button()
        Me.ListViewInstanceTags = New System.Windows.Forms.ListView()
        Me.ColumnHeaderKey = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderValue = New System.Windows.Forms.ColumnHeader()
        Me.ButtonMetricBrowser = New System.Windows.Forms.Button()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStripMain.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPageEC2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataListViewEC2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripInstanceFilter.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageDetails.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPageNetworking.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPageStorage.SuspendLayout()
        Me.TabPageMonitoring.SuspendLayout()
        Me.TabPageTags.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelCurrentRegion, Me.ToolStripStatusLabelCurrentVersion})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 691)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1060, 25)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelCurrentRegion
        '
        Me.ToolStripStatusLabelCurrentRegion.Name = "ToolStripStatusLabelCurrentRegion"
        Me.ToolStripStatusLabelCurrentRegion.Size = New System.Drawing.Size(88, 23)
        Me.ToolStripStatusLabelCurrentRegion.Text = "< region >"
        '
        'ToolStripStatusLabelCurrentVersion
        '
        Me.ToolStripStatusLabelCurrentVersion.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabelCurrentVersion.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusLabelCurrentVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabelCurrentVersion.Name = "ToolStripStatusLabelCurrentVersion"
        Me.ToolStripStatusLabelCurrentVersion.Size = New System.Drawing.Size(112, 20)
        Me.ToolStripStatusLabelCurrentVersion.Text = "Current Version"
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountsToolStripMenuItem, Me.ActionsToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.LanguageToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStripMain.Size = New System.Drawing.Size(1060, 24)
        Me.MenuStripMain.TabIndex = 1
        Me.MenuStripMain.Text = "MenuStrip1"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(137, 20)
        Me.AccountsToolStripMenuItem.Text = "Add New Account"
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemLaunchNewInstances})
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ActionsToolStripMenuItem.Text = "Actions"
        '
        'ToolStripMenuItemLaunchNewInstances
        '
        Me.ToolStripMenuItemLaunchNewInstances.Name = "ToolStripMenuItemLaunchNewInstances"
        Me.ToolStripMenuItemLaunchNewInstances.Size = New System.Drawing.Size(224, 22)
        Me.ToolStripMenuItemLaunchNewInstances.Text = "Launch New Instances"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishToolStripMenuItem, Me.RussianToolStripMenuItem})
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.LanguageToolStripMenuItem.Text = "Language"
        Me.LanguageToolStripMenuItem.Visible = False
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        Me.EnglishToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.EnglishToolStripMenuItem.Text = "English"
        '
        'RussianToolStripMenuItem
        '
        Me.RussianToolStripMenuItem.Name = "RussianToolStripMenuItem"
        Me.RussianToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.RussianToolStripMenuItem.Text = "Russian"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageEC2)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 24)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1060, 667)
        Me.TabControl.TabIndex = 4
        '
        'TabPageEC2
        '
        Me.TabPageEC2.Controls.Add(Me.Panel2)
        Me.TabPageEC2.Location = New System.Drawing.Point(4, 25)
        Me.TabPageEC2.Name = "TabPageEC2"
        Me.TabPageEC2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEC2.Size = New System.Drawing.Size(1052, 638)
        Me.TabPageEC2.TabIndex = 0
        Me.TabPageEC2.Text = "Instances"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1046, 632)
        Me.Panel2.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.DataListViewEC2)
        Me.Panel3.Controls.Add(Me.MenuStripFilterPresentation)
        Me.Panel3.Controls.Add(Me.MenuStripInstanceFilter)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1040, 343)
        Me.Panel3.TabIndex = 2
        '
        'DataListViewEC2
        '
        Me.DataListViewEC2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataListViewEC2.CellEditUseWholeCell = False
        Me.DataListViewEC2.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataListViewEC2.DataSource = Nothing
        Me.DataListViewEC2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DataListViewEC2.FullRowSelect = True
        Me.DataListViewEC2.GridLines = True
        Me.DataListViewEC2.HideSelection = False
        Me.DataListViewEC2.IsSearchOnSortColumn = False
        Me.DataListViewEC2.Location = New System.Drawing.Point(3, 27)
        Me.DataListViewEC2.Name = "DataListViewEC2"
        Me.DataListViewEC2.ShowGroups = False
        Me.DataListViewEC2.Size = New System.Drawing.Size(1033, 313)
        Me.DataListViewEC2.TabIndex = 9
        Me.DataListViewEC2.UseFiltering = True
        Me.DataListViewEC2.View = System.Windows.Forms.View.Details
        '
        'MenuStripFilterPresentation
        '
        Me.MenuStripFilterPresentation.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MenuStripFilterPresentation.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripFilterPresentation.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MenuStripFilterPresentation.Location = New System.Drawing.Point(596, 0)
        Me.MenuStripFilterPresentation.Name = "MenuStripFilterPresentation"
        Me.MenuStripFilterPresentation.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStripFilterPresentation.Size = New System.Drawing.Size(202, 24)
        Me.MenuStripFilterPresentation.TabIndex = 11
        Me.MenuStripFilterPresentation.Text = "MenuStrip2"
        '
        'MenuStripInstanceFilter
        '
        Me.MenuStripInstanceFilter.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripInstanceFilter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MenuStripInstanceFilter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshInstanceListToolStripMenuItem, Me.FilterByToolStripMenuItem, Me.ToolStripTextBoxFilterByTag, Me.ToolStripTextBoxFilterByTagValue})
        Me.MenuStripInstanceFilter.Location = New System.Drawing.Point(2, 0)
        Me.MenuStripInstanceFilter.Name = "MenuStripInstanceFilter"
        Me.MenuStripInstanceFilter.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStripInstanceFilter.Size = New System.Drawing.Size(581, 28)
        Me.MenuStripInstanceFilter.TabIndex = 10
        Me.MenuStripInstanceFilter.Text = "MenuStrip2"
        '
        'RefreshInstanceListToolStripMenuItem
        '
        Me.RefreshInstanceListToolStripMenuItem.Name = "RefreshInstanceListToolStripMenuItem"
        Me.RefreshInstanceListToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.RefreshInstanceListToolStripMenuItem.Text = "Refresh"
        '
        'FilterByToolStripMenuItem
        '
        Me.FilterByToolStripMenuItem.Name = "FilterByToolStripMenuItem"
        Me.FilterByToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.FilterByToolStripMenuItem.Text = "Filter by Property"
        '
        'ToolStripTextBoxFilterByTag
        '
        Me.ToolStripTextBoxFilterByTag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ToolStripTextBoxFilterByTag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ToolStripTextBoxFilterByTag.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ToolStripTextBoxFilterByTag.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripTextBoxFilterByTag.Name = "ToolStripTextBoxFilterByTag"
        Me.ToolStripTextBoxFilterByTag.Size = New System.Drawing.Size(228, 24)
        Me.ToolStripTextBoxFilterByTag.ToolTipText = "Filter by Tag"
        '
        'ToolStripTextBoxFilterByTagValue
        '
        Me.ToolStripTextBoxFilterByTagValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ToolStripTextBoxFilterByTagValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ToolStripTextBoxFilterByTagValue.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ToolStripTextBoxFilterByTagValue.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripTextBoxFilterByTagValue.Name = "ToolStripTextBoxFilterByTagValue"
        Me.ToolStripTextBoxFilterByTagValue.Size = New System.Drawing.Size(138, 24)
        Me.ToolStripTextBoxFilterByTagValue.Sorted = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(5, 352)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1038, 277)
        Me.Panel1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageDetails)
        Me.TabControl1.Controls.Add(Me.TabPageNetworking)
        Me.TabControl1.Controls.Add(Me.TabPageStorage)
        Me.TabControl1.Controls.Add(Me.TabPageMonitoring)
        Me.TabControl1.Controls.Add(Me.TabPageTags)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1038, 277)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageDetails
        '
        Me.TabPageDetails.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPageDetails.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPageDetails.Location = New System.Drawing.Point(4, 25)
        Me.TabPageDetails.Name = "TabPageDetails"
        Me.TabPageDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDetails.Size = New System.Drawing.Size(1030, 248)
        Me.TabPageDetails.TabIndex = 0
        Me.TabPageDetails.Text = "Details"
        Me.TabPageDetails.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxInstanceSystemStatus, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxInstanceStatus, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxInstanceType, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxInstanceEbsOptimization, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxInstanceDetailedMonitoring, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxInstanceKeyName, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox7, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonOpenInstanceTypeForm, 2, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(508, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(526, 247)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TextBoxInstanceSystemStatus
        '
        Me.TextBoxInstanceSystemStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInstanceSystemStatus.Location = New System.Drawing.Point(142, 148)
        Me.TextBoxInstanceSystemStatus.Name = "TextBoxInstanceSystemStatus"
        Me.TextBoxInstanceSystemStatus.ReadOnly = True
        Me.TextBoxInstanceSystemStatus.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxInstanceSystemStatus.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 29)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "System Status"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxInstanceStatus
        '
        Me.TextBoxInstanceStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInstanceStatus.Location = New System.Drawing.Point(142, 119)
        Me.TextBoxInstanceStatus.Name = "TextBoxInstanceStatus"
        Me.TextBoxInstanceStatus.ReadOnly = True
        Me.TextBoxInstanceStatus.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxInstanceStatus.TabIndex = 7
        '
        'TextBoxInstanceType
        '
        Me.TextBoxInstanceType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInstanceType.Location = New System.Drawing.Point(142, 90)
        Me.TextBoxInstanceType.Name = "TextBoxInstanceType"
        Me.TextBoxInstanceType.ReadOnly = True
        Me.TextBoxInstanceType.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxInstanceType.TabIndex = 6
        '
        'TextBoxInstanceEbsOptimization
        '
        Me.TextBoxInstanceEbsOptimization.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInstanceEbsOptimization.Location = New System.Drawing.Point(142, 61)
        Me.TextBoxInstanceEbsOptimization.Name = "TextBoxInstanceEbsOptimization"
        Me.TextBoxInstanceEbsOptimization.ReadOnly = True
        Me.TextBoxInstanceEbsOptimization.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxInstanceEbsOptimization.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 29)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Detailed Monitoring"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 29)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "EBS Optimization"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 29)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Instance Type"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 29)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Instance Status"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxInstanceDetailedMonitoring
        '
        Me.TextBoxInstanceDetailedMonitoring.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInstanceDetailedMonitoring.Location = New System.Drawing.Point(142, 32)
        Me.TextBoxInstanceDetailedMonitoring.Name = "TextBoxInstanceDetailedMonitoring"
        Me.TextBoxInstanceDetailedMonitoring.ReadOnly = True
        Me.TextBoxInstanceDetailedMonitoring.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxInstanceDetailedMonitoring.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 29)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Key Name"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxInstanceKeyName
        '
        Me.TextBoxInstanceKeyName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInstanceKeyName.Location = New System.Drawing.Point(142, 3)
        Me.TextBoxInstanceKeyName.Name = "TextBoxInstanceKeyName"
        Me.TextBoxInstanceKeyName.ReadOnly = True
        Me.TextBoxInstanceKeyName.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxInstanceKeyName.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(133, 29)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "IAM Role"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.Location = New System.Drawing.Point(142, 177)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(322, 23)
        Me.TextBox7.TabIndex = 15
        Me.TextBox7.Visible = False
        '
        'ButtonOpenInstanceTypeForm
        '
        Me.ButtonOpenInstanceTypeForm.Location = New System.Drawing.Point(470, 90)
        Me.ButtonOpenInstanceTypeForm.Name = "ButtonOpenInstanceTypeForm"
        Me.ButtonOpenInstanceTypeForm.Size = New System.Drawing.Size(52, 23)
        Me.ButtonOpenInstanceTypeForm.TabIndex = 16
        Me.ButtonOpenInstanceTypeForm.Text = "Open"
        Me.ButtonOpenInstanceTypeForm.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxInstancevCPU, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxInstanceTenancy, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxInstanceAMI, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxInstancePlatformDetails, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxInstancePlatform, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonOpenAmiForm, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxInstanceId, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonCopyInstanceID, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxInstanceIamRole, 1, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(502, 262)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TextBoxInstancevCPU
        '
        Me.TextBoxInstancevCPU.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInstancevCPU.Location = New System.Drawing.Point(119, 148)
        Me.TextBoxInstancevCPU.Name = "TextBoxInstancevCPU"
        Me.TextBoxInstancevCPU.ReadOnly = True
        Me.TextBoxInstancevCPU.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxInstancevCPU.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "# of vCPUs"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxInstanceTenancy
        '
        Me.TextBoxInstanceTenancy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInstanceTenancy.Location = New System.Drawing.Point(119, 119)
        Me.TextBoxInstanceTenancy.Name = "TextBoxInstanceTenancy"
        Me.TextBoxInstanceTenancy.ReadOnly = True
        Me.TextBoxInstanceTenancy.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxInstanceTenancy.TabIndex = 7
        '
        'TextBoxInstanceAMI
        '
        Me.TextBoxInstanceAMI.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInstanceAMI.Location = New System.Drawing.Point(119, 90)
        Me.TextBoxInstanceAMI.Name = "TextBoxInstanceAMI"
        Me.TextBoxInstanceAMI.ReadOnly = True
        Me.TextBoxInstanceAMI.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxInstanceAMI.TabIndex = 6
        '
        'TextBoxInstancePlatformDetails
        '
        Me.TextBoxInstancePlatformDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInstancePlatformDetails.Location = New System.Drawing.Point(119, 61)
        Me.TextBoxInstancePlatformDetails.Name = "TextBoxInstancePlatformDetails"
        Me.TextBoxInstancePlatformDetails.ReadOnly = True
        Me.TextBoxInstancePlatformDetails.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxInstancePlatformDetails.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Platform"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Platform Details"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "AMI ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tenancy"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxInstancePlatform
        '
        Me.TextBoxInstancePlatform.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInstancePlatform.Location = New System.Drawing.Point(119, 32)
        Me.TextBoxInstancePlatform.Name = "TextBoxInstancePlatform"
        Me.TextBoxInstancePlatform.ReadOnly = True
        Me.TextBoxInstancePlatform.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxInstancePlatform.TabIndex = 4
        '
        'ButtonOpenAmiForm
        '
        Me.ButtonOpenAmiForm.Location = New System.Drawing.Point(447, 90)
        Me.ButtonOpenAmiForm.Name = "ButtonOpenAmiForm"
        Me.ButtonOpenAmiForm.Size = New System.Drawing.Size(52, 23)
        Me.ButtonOpenAmiForm.TabIndex = 10
        Me.ButtonOpenAmiForm.Text = "Open"
        Me.ButtonOpenAmiForm.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Instance ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxInstanceId
        '
        Me.TextBoxInstanceId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInstanceId.Location = New System.Drawing.Point(119, 3)
        Me.TextBoxInstanceId.Name = "TextBoxInstanceId"
        Me.TextBoxInstanceId.ReadOnly = True
        Me.TextBoxInstanceId.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxInstanceId.TabIndex = 12
        '
        'ButtonCopyInstanceID
        '
        Me.ButtonCopyInstanceID.Location = New System.Drawing.Point(447, 3)
        Me.ButtonCopyInstanceID.Name = "ButtonCopyInstanceID"
        Me.ButtonCopyInstanceID.Size = New System.Drawing.Size(52, 23)
        Me.ButtonCopyInstanceID.TabIndex = 13
        Me.ButtonCopyInstanceID.Text = "Copy"
        Me.ButtonCopyInstanceID.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 29)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "IAM Role"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxInstanceIamRole
        '
        Me.TextBoxInstanceIamRole.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInstanceIamRole.Location = New System.Drawing.Point(119, 177)
        Me.TextBoxInstanceIamRole.Name = "TextBoxInstanceIamRole"
        Me.TextBoxInstanceIamRole.ReadOnly = True
        Me.TextBoxInstanceIamRole.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxInstanceIamRole.TabIndex = 15
        '
        'TabPageNetworking
        '
        Me.TabPageNetworking.Controls.Add(Me.SplitContainer2)
        Me.TabPageNetworking.Location = New System.Drawing.Point(4, 25)
        Me.TabPageNetworking.Name = "TabPageNetworking"
        Me.TabPageNetworking.Size = New System.Drawing.Size(1030, 248)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1030, 248)
        Me.SplitContainer2.SplitterDistance = 432
        Me.SplitContainer2.SplitterWidth = 5
        Me.SplitContainer2.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonChangeSecurityGroups)
        Me.GroupBox1.Controls.Add(Me.ListViewInstanceSG)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 248)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Security Groups"
        '
        'ButtonChangeSecurityGroups
        '
        Me.ButtonChangeSecurityGroups.Location = New System.Drawing.Point(6, 19)
        Me.ButtonChangeSecurityGroups.Name = "ButtonChangeSecurityGroups"
        Me.ButtonChangeSecurityGroups.Size = New System.Drawing.Size(86, 25)
        Me.ButtonChangeSecurityGroups.TabIndex = 4
        Me.ButtonChangeSecurityGroups.Text = "Change"
        Me.ButtonChangeSecurityGroups.UseVisualStyleBackColor = True
        '
        'ListViewInstanceSG
        '
        Me.ListViewInstanceSG.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListViewInstanceSG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewInstanceSG.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderInstanceSgId, Me.ColumnHeaderInstanceSgName})
        Me.ListViewInstanceSG.FullRowSelect = True
        Me.ListViewInstanceSG.GridLines = True
        Me.ListViewInstanceSG.HideSelection = False
        Me.ListViewInstanceSG.Location = New System.Drawing.Point(1, 50)
        Me.ListViewInstanceSG.Name = "ListViewInstanceSG"
        Me.ListViewInstanceSG.ShowGroups = False
        Me.ListViewInstanceSG.Size = New System.Drawing.Size(423, 193)
        Me.ListViewInstanceSG.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewInstanceSG.TabIndex = 3
        Me.ListViewInstanceSG.UseCompatibleStateImageBehavior = False
        Me.ListViewInstanceSG.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderInstanceSgId
        '
        Me.ColumnHeaderInstanceSgId.Text = "Security Group ID"
        Me.ColumnHeaderInstanceSgId.Width = 170
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
        Me.GroupBox2.Size = New System.Drawing.Size(593, 248)
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
        Me.ListViewInstanceNetworkProperties.Location = New System.Drawing.Point(7, 50)
        Me.ListViewInstanceNetworkProperties.Name = "ListViewInstanceNetworkProperties"
        Me.ListViewInstanceNetworkProperties.ShowGroups = False
        Me.ListViewInstanceNetworkProperties.Size = New System.Drawing.Size(579, 193)
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
        Me.TabPageStorage.Controls.Add(Me.ButtonAddNewVolumes)
        Me.TabPageStorage.Controls.Add(Me.ListViewInstanceVolumes)
        Me.TabPageStorage.Location = New System.Drawing.Point(4, 25)
        Me.TabPageStorage.Name = "TabPageStorage"
        Me.TabPageStorage.Size = New System.Drawing.Size(1030, 248)
        Me.TabPageStorage.TabIndex = 3
        Me.TabPageStorage.Text = "Storage"
        Me.TabPageStorage.UseVisualStyleBackColor = True
        '
        'ButtonAddNewVolumes
        '
        Me.ButtonAddNewVolumes.Location = New System.Drawing.Point(3, -1)
        Me.ButtonAddNewVolumes.Name = "ButtonAddNewVolumes"
        Me.ButtonAddNewVolumes.Size = New System.Drawing.Size(138, 25)
        Me.ButtonAddNewVolumes.TabIndex = 2
        Me.ButtonAddNewVolumes.Text = "Add New Volumes"
        Me.ButtonAddNewVolumes.UseVisualStyleBackColor = True
        '
        'ListViewInstanceVolumes
        '
        Me.ListViewInstanceVolumes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewInstanceVolumes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderVolumeID, Me.ColumnHeaderDeviceName, Me.ColumnHeaderVolumeType, Me.ColumnHeaderSize, Me.ColumnHeaderVolumeIOPS, Me.ColumnHeaderVolumeThroughput, Me.ColumnHeaderAttachmentTime, Me.ColumnHeaderDeleteOnTermination, Me.ColumnHeaderEncrypted, Me.ColumnHeaderKmsKeyId})
        Me.ListViewInstanceVolumes.FullRowSelect = True
        Me.ListViewInstanceVolumes.GridLines = True
        Me.ListViewInstanceVolumes.HideSelection = False
        Me.ListViewInstanceVolumes.Location = New System.Drawing.Point(0, 25)
        Me.ListViewInstanceVolumes.Name = "ListViewInstanceVolumes"
        Me.ListViewInstanceVolumes.ShowGroups = False
        Me.ListViewInstanceVolumes.Size = New System.Drawing.Size(1030, 234)
        Me.ListViewInstanceVolumes.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewInstanceVolumes.TabIndex = 1
        Me.ListViewInstanceVolumes.UseCompatibleStateImageBehavior = False
        Me.ListViewInstanceVolumes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderVolumeID
        '
        Me.ColumnHeaderVolumeID.Text = "Volume ID"
        Me.ColumnHeaderVolumeID.Width = 180
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
        Me.ColumnHeaderSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeaderVolumeIOPS
        '
        Me.ColumnHeaderVolumeIOPS.Text = "IOPS"
        Me.ColumnHeaderVolumeIOPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeaderVolumeThroughput
        '
        Me.ColumnHeaderVolumeThroughput.Text = "Throughput (MB/s)"
        Me.ColumnHeaderVolumeThroughput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeaderVolumeThroughput.Width = 140
        '
        'ColumnHeaderAttachmentTime
        '
        Me.ColumnHeaderAttachmentTime.Text = "Attachment Time"
        Me.ColumnHeaderAttachmentTime.Width = 180
        '
        'ColumnHeaderDeleteOnTermination
        '
        Me.ColumnHeaderDeleteOnTermination.Text = "Delete on Termination"
        Me.ColumnHeaderDeleteOnTermination.Width = 160
        '
        'ColumnHeaderEncrypted
        '
        Me.ColumnHeaderEncrypted.Text = "Encrypted"
        Me.ColumnHeaderEncrypted.Width = 80
        '
        'ColumnHeaderKmsKeyId
        '
        Me.ColumnHeaderKmsKeyId.Text = "KMS key ID"
        Me.ColumnHeaderKmsKeyId.Width = 150
        '
        'TabPageMonitoring
        '
        Me.TabPageMonitoring.Controls.Add(Me.ButtonMetricBrowser)
        Me.TabPageMonitoring.Controls.Add(Me.PlotViewInstanceCPU)
        Me.TabPageMonitoring.Location = New System.Drawing.Point(4, 25)
        Me.TabPageMonitoring.Name = "TabPageMonitoring"
        Me.TabPageMonitoring.Size = New System.Drawing.Size(1030, 248)
        Me.TabPageMonitoring.TabIndex = 5
        Me.TabPageMonitoring.Text = "Monitoring"
        Me.TabPageMonitoring.UseVisualStyleBackColor = True
        '
        'PlotViewInstanceCPU
        '
        Me.PlotViewInstanceCPU.BackColor = System.Drawing.Color.White
        Me.PlotViewInstanceCPU.Location = New System.Drawing.Point(3, 33)
        Me.PlotViewInstanceCPU.Name = "PlotViewInstanceCPU"
        Me.PlotViewInstanceCPU.PanCursor = System.Windows.Forms.Cursors.Hand
        Me.PlotViewInstanceCPU.Size = New System.Drawing.Size(295, 212)
        Me.PlotViewInstanceCPU.TabIndex = 0
        Me.PlotViewInstanceCPU.Text = "PlotViewInstanceCPU"
        Me.PlotViewInstanceCPU.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE
        Me.PlotViewInstanceCPU.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.PlotViewInstanceCPU.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS
        '
        'TabPageTags
        '
        Me.TabPageTags.Controls.Add(Me.ButtonEditTags)
        Me.TabPageTags.Controls.Add(Me.ListViewInstanceTags)
        Me.TabPageTags.Location = New System.Drawing.Point(4, 25)
        Me.TabPageTags.Name = "TabPageTags"
        Me.TabPageTags.Size = New System.Drawing.Size(1030, 248)
        Me.TabPageTags.TabIndex = 6
        Me.TabPageTags.Text = "Tags"
        Me.TabPageTags.UseVisualStyleBackColor = True
        '
        'ButtonEditTags
        '
        Me.ButtonEditTags.Location = New System.Drawing.Point(0, 0)
        Me.ButtonEditTags.Name = "ButtonEditTags"
        Me.ButtonEditTags.Size = New System.Drawing.Size(86, 25)
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
        Me.ListViewInstanceTags.Location = New System.Drawing.Point(0, 28)
        Me.ListViewInstanceTags.Name = "ListViewInstanceTags"
        Me.ListViewInstanceTags.ShowGroups = False
        Me.ListViewInstanceTags.Size = New System.Drawing.Size(1030, 228)
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
        'ButtonMetricBrowser
        '
        Me.ButtonMetricBrowser.Location = New System.Drawing.Point(3, 0)
        Me.ButtonMetricBrowser.Name = "ButtonMetricBrowser"
        Me.ButtonMetricBrowser.Size = New System.Drawing.Size(134, 23)
        Me.ButtonMetricBrowser.TabIndex = 1
        Me.ButtonMetricBrowser.Text = "Metric Browser"
        Me.ButtonMetricBrowser.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 716)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStripMain)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataListViewEC2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripInstanceFilter.ResumeLayout(False)
        Me.MenuStripInstanceFilter.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageDetails.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPageNetworking.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPageStorage.ResumeLayout(False)
        Me.TabPageMonitoring.ResumeLayout(False)
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageDetails As TabPage
    Friend WithEvents TabPageNetworking As TabPage
    Friend WithEvents TabPageStorage As TabPage
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
    Friend WithEvents ColumnHeaderVolumeIOPS As ColumnHeader
    Friend WithEvents ColumnHeaderVolumeThroughput As ColumnHeader
    Friend WithEvents ButtonAddNewVolumes As Button
    Friend WithEvents ToolStripTextBoxFilterByTagValue As ToolStripComboBox
    Friend WithEvents ToolStripStatusLabelCurrentVersion As ToolStripStatusLabel
    Friend WithEvents ActionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemLaunchNewInstances As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBoxInstancevCPU As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxInstanceTenancy As TextBox
    Friend WithEvents TextBoxInstanceAMI As TextBox
    Friend WithEvents TextBoxInstancePlatformDetails As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxInstancePlatform As TextBox
    Friend WithEvents ButtonOpenAmiForm As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxInstanceId As TextBox
    Friend WithEvents ButtonCopyInstanceID As Button
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxInstanceIamRole As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBoxInstanceSystemStatus As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxInstanceStatus As TextBox
    Friend WithEvents TextBoxInstanceType As TextBox
    Friend WithEvents TextBoxInstanceEbsOptimization As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxInstanceDetailedMonitoring As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxInstanceKeyName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents ButtonOpenInstanceTypeForm As Button
    Friend WithEvents PlotViewInstanceCPU As OxyPlot.WindowsForms.PlotView
    Friend WithEvents ButtonMetricBrowser As Button
End Class
