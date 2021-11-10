<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AwsAccountsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AwsAccountsForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListViewAccounts = New System.Windows.Forms.ListView()
        Me.AccountDescription = New System.Windows.Forms.ColumnHeader()
        Me.AccountCredType = New System.Windows.Forms.ColumnHeader()
        Me.AccountRegion = New System.Windows.Forms.ColumnHeader()
        Me.AccountKeyPairs = New System.Windows.Forms.ColumnHeader()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxNewCredProfileSecretKey = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxNewCredProfileAccessKey = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxNewCredProfileName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonAddNewCredentialProfile = New System.Windows.Forms.Button()
        Me.ButtonDeleteSelecetedCredentialProfile = New System.Windows.Forms.Button()
        Me.ButtonRefreshCredentialProfiles = New System.Windows.Forms.Button()
        Me.ComboBoxCredentialProfile = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBoxSSO_StartUrl = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxSSO_RoleName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxSSO_Region = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxSSO_AccountId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxCredentialType = New System.Windows.Forms.ComboBox()
        Me.TextBoxDefaultInstanceFilter = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBoxEnabledRegions = New System.Windows.Forms.CheckedListBox()
        Me.TextBoxAccountDescription = New System.Windows.Forms.TextBox()
        Me.ButtonSaveAccount = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonDeleteKeyPair = New System.Windows.Forms.Button()
        Me.ButtonAddKeyPair = New System.Windows.Forms.Button()
        Me.ListBoxKeyPairs = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonBackgroundColor = New System.Windows.Forms.Button()
        Me.ComboBoxAccountRegion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonDeleteAccount = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialogKeyPair = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialogBackgroundColor = New System.Windows.Forms.ColorDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListViewAccounts, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.16107!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.83893!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1030, 596)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ListViewAccounts
        '
        Me.ListViewAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.AccountDescription, Me.AccountCredType, Me.AccountRegion, Me.AccountKeyPairs})
        Me.ListViewAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewAccounts.FullRowSelect = True
        Me.ListViewAccounts.GridLines = True
        Me.ListViewAccounts.HideSelection = False
        Me.ListViewAccounts.Location = New System.Drawing.Point(3, 3)
        Me.ListViewAccounts.Name = "ListViewAccounts"
        Me.ListViewAccounts.Size = New System.Drawing.Size(1024, 137)
        Me.ListViewAccounts.TabIndex = 0
        Me.ListViewAccounts.UseCompatibleStateImageBehavior = False
        Me.ListViewAccounts.View = System.Windows.Forms.View.Details
        '
        'AccountDescription
        '
        Me.AccountDescription.Text = "Description"
        Me.AccountDescription.Width = 200
        '
        'AccountCredType
        '
        Me.AccountCredType.Text = "Credential Type"
        Me.AccountCredType.Width = 200
        '
        'AccountRegion
        '
        Me.AccountRegion.Text = "Region"
        Me.AccountRegion.Width = 100
        '
        'AccountKeyPairs
        '
        Me.AccountKeyPairs.Text = "Key Pairs"
        Me.AccountKeyPairs.Width = 100
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ComboBoxCredentialType)
        Me.Panel1.Controls.Add(Me.TextBoxDefaultInstanceFilter)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.TextBoxAccountDescription)
        Me.Panel1.Controls.Add(Me.ButtonSaveAccount)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ButtonBackgroundColor)
        Me.Panel1.Controls.Add(Me.ComboBoxAccountRegion)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 447)
        Me.Panel1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(17, 68)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(669, 178)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.ButtonDeleteSelecetedCredentialProfile)
        Me.TabPage1.Controls.Add(Me.ButtonRefreshCredentialProfiles)
        Me.TabPage1.Controls.Add(Me.ComboBoxCredentialProfile)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(661, 149)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CredentialsProfile"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxNewCredProfileSecretKey)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TextBoxNewCredProfileAccessKey)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TextBoxNewCredProfileName)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.ButtonAddNewCredentialProfile)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(632, 110)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add New Profile"
        '
        'TextBoxNewCredProfileSecretKey
        '
        Me.TextBoxNewCredProfileSecretKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNewCredProfileSecretKey.Location = New System.Drawing.Point(119, 64)
        Me.TextBoxNewCredProfileSecretKey.Name = "TextBoxNewCredProfileSecretKey"
        Me.TextBoxNewCredProfileSecretKey.Size = New System.Drawing.Size(265, 23)
        Me.TextBoxNewCredProfileSecretKey.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Secret Key"
        '
        'TextBoxNewCredProfileAccessKey
        '
        Me.TextBoxNewCredProfileAccessKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNewCredProfileAccessKey.Location = New System.Drawing.Point(119, 38)
        Me.TextBoxNewCredProfileAccessKey.Name = "TextBoxNewCredProfileAccessKey"
        Me.TextBoxNewCredProfileAccessKey.Size = New System.Drawing.Size(265, 23)
        Me.TextBoxNewCredProfileAccessKey.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Access Key"
        '
        'TextBoxNewCredProfileName
        '
        Me.TextBoxNewCredProfileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNewCredProfileName.Location = New System.Drawing.Point(119, 14)
        Me.TextBoxNewCredProfileName.Name = "TextBoxNewCredProfileName"
        Me.TextBoxNewCredProfileName.Size = New System.Drawing.Size(265, 23)
        Me.TextBoxNewCredProfileName.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 16)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Name"
        '
        'ButtonAddNewCredentialProfile
        '
        Me.ButtonAddNewCredentialProfile.Location = New System.Drawing.Point(401, 31)
        Me.ButtonAddNewCredentialProfile.Name = "ButtonAddNewCredentialProfile"
        Me.ButtonAddNewCredentialProfile.Size = New System.Drawing.Size(173, 56)
        Me.ButtonAddNewCredentialProfile.TabIndex = 23
        Me.ButtonAddNewCredentialProfile.Text = "Save Into NetSDKCredentialsFile"
        Me.ButtonAddNewCredentialProfile.UseVisualStyleBackColor = True
        '
        'ButtonDeleteSelecetedCredentialProfile
        '
        Me.ButtonDeleteSelecetedCredentialProfile.Location = New System.Drawing.Point(393, 4)
        Me.ButtonDeleteSelecetedCredentialProfile.Name = "ButtonDeleteSelecetedCredentialProfile"
        Me.ButtonDeleteSelecetedCredentialProfile.Size = New System.Drawing.Size(126, 23)
        Me.ButtonDeleteSelecetedCredentialProfile.TabIndex = 24
        Me.ButtonDeleteSelecetedCredentialProfile.Text = "Delete Selected"
        Me.ButtonDeleteSelecetedCredentialProfile.UseVisualStyleBackColor = True
        '
        'ButtonRefreshCredentialProfiles
        '
        Me.ButtonRefreshCredentialProfiles.Location = New System.Drawing.Point(312, 4)
        Me.ButtonRefreshCredentialProfiles.Name = "ButtonRefreshCredentialProfiles"
        Me.ButtonRefreshCredentialProfiles.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefreshCredentialProfiles.TabIndex = 22
        Me.ButtonRefreshCredentialProfiles.Text = "Refresh"
        Me.ButtonRefreshCredentialProfiles.UseVisualStyleBackColor = True
        '
        'ComboBoxCredentialProfile
        '
        Me.ComboBoxCredentialProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCredentialProfile.FormattingEnabled = True
        Me.ComboBoxCredentialProfile.Location = New System.Drawing.Point(119, 3)
        Me.ComboBoxCredentialProfile.Name = "ComboBoxCredentialProfile"
        Me.ComboBoxCredentialProfile.Size = New System.Drawing.Size(187, 24)
        Me.ComboBoxCredentialProfile.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Profile Name"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBoxSSO_StartUrl)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.TextBoxSSO_RoleName)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.TextBoxSSO_Region)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TextBoxSSO_AccountId)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(661, 149)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SSO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBoxSSO_StartUrl
        '
        Me.TextBoxSSO_StartUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSSO_StartUrl.Location = New System.Drawing.Point(108, 85)
        Me.TextBoxSSO_StartUrl.Name = "TextBoxSSO_StartUrl"
        Me.TextBoxSSO_StartUrl.Size = New System.Drawing.Size(223, 23)
        Me.TextBoxSSO_StartUrl.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Start Url"
        '
        'TextBoxSSO_RoleName
        '
        Me.TextBoxSSO_RoleName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSSO_RoleName.Location = New System.Drawing.Point(108, 58)
        Me.TextBoxSSO_RoleName.Name = "TextBoxSSO_RoleName"
        Me.TextBoxSSO_RoleName.Size = New System.Drawing.Size(223, 23)
        Me.TextBoxSSO_RoleName.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Role Name"
        '
        'TextBoxSSO_Region
        '
        Me.TextBoxSSO_Region.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSSO_Region.Location = New System.Drawing.Point(108, 29)
        Me.TextBoxSSO_Region.Name = "TextBoxSSO_Region"
        Me.TextBoxSSO_Region.Size = New System.Drawing.Size(223, 23)
        Me.TextBoxSSO_Region.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Region"
        '
        'TextBoxSSO_AccountId
        '
        Me.TextBoxSSO_AccountId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSSO_AccountId.Location = New System.Drawing.Point(108, 0)
        Me.TextBoxSSO_AccountId.Name = "TextBoxSSO_AccountId"
        Me.TextBoxSSO_AccountId.Size = New System.Drawing.Size(223, 23)
        Me.TextBoxSSO_AccountId.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Account Id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Authentication Type"
        '
        'ComboBoxCredentialType
        '
        Me.ComboBoxCredentialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCredentialType.FormattingEnabled = True
        Me.ComboBoxCredentialType.Location = New System.Drawing.Point(170, 38)
        Me.ComboBoxCredentialType.Name = "ComboBoxCredentialType"
        Me.ComboBoxCredentialType.Size = New System.Drawing.Size(174, 24)
        Me.ComboBoxCredentialType.TabIndex = 17
        '
        'TextBoxDefaultInstanceFilter
        '
        Me.TextBoxDefaultInstanceFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDefaultInstanceFilter.Location = New System.Drawing.Point(175, 252)
        Me.TextBoxDefaultInstanceFilter.Name = "TextBoxDefaultInstanceFilter"
        Me.TextBoxDefaultInstanceFilter.Size = New System.Drawing.Size(509, 23)
        Me.TextBoxDefaultInstanceFilter.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Default Instance Filter"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.CheckedListBoxEnabledRegions)
        Me.GroupBox2.Location = New System.Drawing.Point(689, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 395)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enabled Regions"
        '
        'CheckedListBoxEnabledRegions
        '
        Me.CheckedListBoxEnabledRegions.CheckOnClick = True
        Me.CheckedListBoxEnabledRegions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBoxEnabledRegions.FormattingEnabled = True
        Me.CheckedListBoxEnabledRegions.Location = New System.Drawing.Point(3, 19)
        Me.CheckedListBoxEnabledRegions.Name = "CheckedListBoxEnabledRegions"
        Me.CheckedListBoxEnabledRegions.Size = New System.Drawing.Size(324, 373)
        Me.CheckedListBoxEnabledRegions.Sorted = True
        Me.CheckedListBoxEnabledRegions.TabIndex = 12
        '
        'TextBoxAccountDescription
        '
        Me.TextBoxAccountDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAccountDescription.Location = New System.Drawing.Point(170, 8)
        Me.TextBoxAccountDescription.Name = "TextBoxAccountDescription"
        Me.TextBoxAccountDescription.Size = New System.Drawing.Size(509, 23)
        Me.TextBoxAccountDescription.TabIndex = 0
        '
        'ButtonSaveAccount
        '
        Me.ButtonSaveAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSaveAccount.Location = New System.Drawing.Point(9, 404)
        Me.ButtonSaveAccount.Name = "ButtonSaveAccount"
        Me.ButtonSaveAccount.Size = New System.Drawing.Size(199, 36)
        Me.ButtonSaveAccount.TabIndex = 3
        Me.ButtonSaveAccount.Text = "Save Account Changes"
        Me.ButtonSaveAccount.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ButtonDeleteKeyPair)
        Me.GroupBox1.Controls.Add(Me.ButtonAddKeyPair)
        Me.GroupBox1.Controls.Add(Me.ListBoxKeyPairs)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 121)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Key Pairs"
        '
        'ButtonDeleteKeyPair
        '
        Me.ButtonDeleteKeyPair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDeleteKeyPair.Location = New System.Drawing.Point(101, 86)
        Me.ButtonDeleteKeyPair.Name = "ButtonDeleteKeyPair"
        Me.ButtonDeleteKeyPair.Size = New System.Drawing.Size(86, 25)
        Me.ButtonDeleteKeyPair.TabIndex = 2
        Me.ButtonDeleteKeyPair.Text = "Delete"
        Me.ButtonDeleteKeyPair.UseVisualStyleBackColor = True
        '
        'ButtonAddKeyPair
        '
        Me.ButtonAddKeyPair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddKeyPair.Location = New System.Drawing.Point(8, 86)
        Me.ButtonAddKeyPair.Name = "ButtonAddKeyPair"
        Me.ButtonAddKeyPair.Size = New System.Drawing.Size(86, 25)
        Me.ButtonAddKeyPair.TabIndex = 1
        Me.ButtonAddKeyPair.Text = "Add"
        Me.ButtonAddKeyPair.UseVisualStyleBackColor = True
        '
        'ListBoxKeyPairs
        '
        Me.ListBoxKeyPairs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxKeyPairs.FormattingEnabled = True
        Me.ListBoxKeyPairs.ItemHeight = 16
        Me.ListBoxKeyPairs.Location = New System.Drawing.Point(6, 22)
        Me.ListBoxKeyPairs.Name = "ListBoxKeyPairs"
        Me.ListBoxKeyPairs.Size = New System.Drawing.Size(335, 52)
        Me.ListBoxKeyPairs.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Description"
        '
        'ButtonBackgroundColor
        '
        Me.ButtonBackgroundColor.Location = New System.Drawing.Point(522, 363)
        Me.ButtonBackgroundColor.Name = "ButtonBackgroundColor"
        Me.ButtonBackgroundColor.Size = New System.Drawing.Size(133, 25)
        Me.ButtonBackgroundColor.TabIndex = 11
        Me.ButtonBackgroundColor.Text = "Pick Color"
        Me.ButtonBackgroundColor.UseVisualStyleBackColor = True
        '
        'ComboBoxAccountRegion
        '
        Me.ComboBoxAccountRegion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxAccountRegion.FormattingEnabled = True
        Me.ComboBoxAccountRegion.Location = New System.Drawing.Point(509, 304)
        Me.ComboBoxAccountRegion.Name = "ComboBoxAccountRegion"
        Me.ComboBoxAccountRegion.Size = New System.Drawing.Size(146, 24)
        Me.ComboBoxAccountRegion.Sorted = True
        Me.ComboBoxAccountRegion.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(361, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Background Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(380, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Default Region"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButtonDeleteAccount})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1030, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripButton1.Text = "Add New Account"
        '
        'ToolStripButtonDeleteAccount
        '
        Me.ToolStripButtonDeleteAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonDeleteAccount.Image = CType(resources.GetObject("ToolStripButtonDeleteAccount.Image"), System.Drawing.Image)
        Me.ToolStripButtonDeleteAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDeleteAccount.Name = "ToolStripButtonDeleteAccount"
        Me.ToolStripButtonDeleteAccount.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripButtonDeleteAccount.Text = "Delete"
        '
        'OpenFileDialogKeyPair
        '
        Me.OpenFileDialogKeyPair.FileName = "OpenFileDialog1"
        '
        'AwsAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 623)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "AwsAccountsForm"
        Me.Text = "AwsAccountsForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ListViewAccounts As ListView
    Friend WithEvents AccountDescription As ColumnHeader
    Friend WithEvents AccountCredType As ColumnHeader
    Friend WithEvents AccountRegion As ColumnHeader
    Friend WithEvents AccountKeyPairs As ColumnHeader
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButtonDeleteAccount As ToolStripButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxAccountRegion As ComboBox
    Friend WithEvents TextBoxAccountDescription As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonDeleteKeyPair As Button
    Friend WithEvents ButtonAddKeyPair As Button
    Friend WithEvents ListBoxKeyPairs As ListBox
    Friend WithEvents ButtonSaveAccount As Button
    Friend WithEvents OpenFileDialogKeyPair As OpenFileDialog
    Friend WithEvents ButtonBackgroundColor As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ColorDialogBackgroundColor As ColorDialog
    Friend WithEvents CheckedListBoxEnabledRegions As CheckedListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxDefaultInstanceFilter As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxCredentialType As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBoxSSO_StartUrl As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxSSO_RoleName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxSSO_Region As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxSSO_AccountId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxCredentialProfile As ComboBox
    Friend WithEvents ButtonAddNewCredentialProfile As Button
    Friend WithEvents ButtonRefreshCredentialProfiles As Button
    Friend WithEvents ButtonDeleteSelecetedCredentialProfile As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBoxNewCredProfileSecretKey As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxNewCredProfileAccessKey As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxNewCredProfileName As TextBox
    Friend WithEvents Label11 As Label
End Class
