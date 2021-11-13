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
        Me.OpenFileDialogKeyPair = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialogBackgroundColor = New System.Windows.Forms.ColorDialog()
        Me.ComboBoxAllAccounts = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxAccountRegion = New System.Windows.Forms.ComboBox()
        Me.ButtonBackgroundColor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonDeleteKeyPair = New System.Windows.Forms.Button()
        Me.ButtonAddKeyPair = New System.Windows.Forms.Button()
        Me.ButtonSaveAccount = New System.Windows.Forms.Button()
        Me.TextBoxAccountDescription = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBoxEnabledRegions = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDefaultInstanceFilter = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxNewCredProfileSecretKey = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxNewCredProfileAccessKey = New System.Windows.Forms.TextBox()
        Me.TextBoxNewCredProfileName = New System.Windows.Forms.TextBox()
        Me.ButtonAddNewCredentialProfile = New System.Windows.Forms.Button()
        Me.ButtonDeleteSelecetedCredentialProfile = New System.Windows.Forms.Button()
        Me.ButtonRefreshCredentialProfiles = New System.Windows.Forms.Button()
        Me.ComboBoxCredentialProfile = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxSSO_StartUrl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxSSO_RoleName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxSSO_AccountId = New System.Windows.Forms.TextBox()
        Me.TextBoxSSO_Region = New System.Windows.Forms.TextBox()
        Me.GroupBoxSavedAccounts = New System.Windows.Forms.GroupBox()
        Me.ButtonDeleteThisAccount = New System.Windows.Forms.Button()
        Me.ButtonAddNewAccount = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControlSecurity = New System.Windows.Forms.TabControl()
        Me.TabPageSecurity = New System.Windows.Forms.TabPage()
        Me.TabControlCredentials = New System.Windows.Forms.TabControl()
        Me.TabPageCredentialProfiles = New System.Windows.Forms.TabPage()
        Me.TabPageSSO = New System.Windows.Forms.TabPage()
        Me.TabPageKeyPairs = New System.Windows.Forms.TabPage()
        Me.ListBoxKeyPairs = New System.Windows.Forms.ListBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBoxSavedAccounts.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControlSecurity.SuspendLayout()
        Me.TabPageSecurity.SuspendLayout()
        Me.TabControlCredentials.SuspendLayout()
        Me.TabPageCredentialProfiles.SuspendLayout()
        Me.TabPageSSO.SuspendLayout()
        Me.TabPageKeyPairs.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialogKeyPair
        '
        Me.OpenFileDialogKeyPair.FileName = "OpenFileDialog1"
        '
        'ComboBoxAllAccounts
        '
        Me.ComboBoxAllAccounts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxAllAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAllAccounts.FormattingEnabled = True
        Me.ComboBoxAllAccounts.Location = New System.Drawing.Point(6, 19)
        Me.ComboBoxAllAccounts.Name = "ComboBoxAllAccounts"
        Me.ComboBoxAllAccounts.Size = New System.Drawing.Size(561, 24)
        Me.ComboBoxAllAccounts.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 30)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Default Region"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 31)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Background Color"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxAccountRegion
        '
        Me.ComboBoxAccountRegion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxAccountRegion.FormattingEnabled = True
        Me.ComboBoxAccountRegion.Location = New System.Drawing.Point(164, 32)
        Me.ComboBoxAccountRegion.Name = "ComboBoxAccountRegion"
        Me.ComboBoxAccountRegion.Size = New System.Drawing.Size(458, 24)
        Me.ComboBoxAccountRegion.Sorted = True
        Me.ComboBoxAccountRegion.TabIndex = 1
        '
        'ButtonBackgroundColor
        '
        Me.ButtonBackgroundColor.Location = New System.Drawing.Point(164, 91)
        Me.ButtonBackgroundColor.Name = "ButtonBackgroundColor"
        Me.ButtonBackgroundColor.Size = New System.Drawing.Size(133, 25)
        Me.ButtonBackgroundColor.TabIndex = 11
        Me.ButtonBackgroundColor.Text = "Pick Color"
        Me.ButtonBackgroundColor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Description"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonDeleteKeyPair
        '
        Me.ButtonDeleteKeyPair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDeleteKeyPair.Location = New System.Drawing.Point(97, 176)
        Me.ButtonDeleteKeyPair.Name = "ButtonDeleteKeyPair"
        Me.ButtonDeleteKeyPair.Size = New System.Drawing.Size(86, 25)
        Me.ButtonDeleteKeyPair.TabIndex = 2
        Me.ButtonDeleteKeyPair.Text = "Delete"
        Me.ButtonDeleteKeyPair.UseVisualStyleBackColor = True
        '
        'ButtonAddKeyPair
        '
        Me.ButtonAddKeyPair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddKeyPair.Location = New System.Drawing.Point(4, 176)
        Me.ButtonAddKeyPair.Name = "ButtonAddKeyPair"
        Me.ButtonAddKeyPair.Size = New System.Drawing.Size(86, 25)
        Me.ButtonAddKeyPair.TabIndex = 1
        Me.ButtonAddKeyPair.Text = "Add"
        Me.ButtonAddKeyPair.UseVisualStyleBackColor = True
        '
        'ButtonSaveAccount
        '
        Me.ButtonSaveAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSaveAccount.Location = New System.Drawing.Point(8, 649)
        Me.ButtonSaveAccount.Name = "ButtonSaveAccount"
        Me.ButtonSaveAccount.Size = New System.Drawing.Size(158, 60)
        Me.ButtonSaveAccount.TabIndex = 3
        Me.ButtonSaveAccount.Text = "Save Account Changes"
        Me.ButtonSaveAccount.UseVisualStyleBackColor = True
        '
        'TextBoxAccountDescription
        '
        Me.TextBoxAccountDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAccountDescription.Location = New System.Drawing.Point(164, 3)
        Me.TextBoxAccountDescription.Name = "TextBoxAccountDescription"
        Me.TextBoxAccountDescription.Size = New System.Drawing.Size(458, 23)
        Me.TextBoxAccountDescription.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.CheckedListBoxEnabledRegions)
        Me.GroupBox2.Location = New System.Drawing.Point(637, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 645)
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
        Me.CheckedListBoxEnabledRegions.Size = New System.Drawing.Size(271, 623)
        Me.CheckedListBoxEnabledRegions.Sorted = True
        Me.CheckedListBoxEnabledRegions.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 29)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Default Instance Filter"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxDefaultInstanceFilter
        '
        Me.TextBoxDefaultInstanceFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDefaultInstanceFilter.Location = New System.Drawing.Point(164, 62)
        Me.TextBoxDefaultInstanceFilter.Name = "TextBoxDefaultInstanceFilter"
        Me.TextBoxDefaultInstanceFilter.Size = New System.Drawing.Size(458, 23)
        Me.TextBoxDefaultInstanceFilter.TabIndex = 15
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox3.Controls.Add(Me.ButtonAddNewCredentialProfile)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(582, 129)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add New Profile to encrypted .NET SDK Credentials File"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxNewCredProfileSecretKey, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxNewCredProfileAccessKey, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxNewCredProfileName, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(1, 22)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(359, 90)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TextBoxNewCredProfileSecretKey
        '
        Me.TextBoxNewCredProfileSecretKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNewCredProfileSecretKey.Location = New System.Drawing.Point(92, 61)
        Me.TextBoxNewCredProfileSecretKey.Name = "TextBoxNewCredProfileSecretKey"
        Me.TextBoxNewCredProfileSecretKey.Size = New System.Drawing.Size(264, 23)
        Me.TextBoxNewCredProfileSecretKey.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 29)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 29)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Access Key"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 32)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Secret Key"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxNewCredProfileAccessKey
        '
        Me.TextBoxNewCredProfileAccessKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNewCredProfileAccessKey.Location = New System.Drawing.Point(92, 32)
        Me.TextBoxNewCredProfileAccessKey.Name = "TextBoxNewCredProfileAccessKey"
        Me.TextBoxNewCredProfileAccessKey.Size = New System.Drawing.Size(264, 23)
        Me.TextBoxNewCredProfileAccessKey.TabIndex = 26
        '
        'TextBoxNewCredProfileName
        '
        Me.TextBoxNewCredProfileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNewCredProfileName.Location = New System.Drawing.Point(92, 3)
        Me.TextBoxNewCredProfileName.Name = "TextBoxNewCredProfileName"
        Me.TextBoxNewCredProfileName.Size = New System.Drawing.Size(264, 23)
        Me.TextBoxNewCredProfileName.TabIndex = 24
        '
        'ButtonAddNewCredentialProfile
        '
        Me.ButtonAddNewCredentialProfile.Location = New System.Drawing.Point(366, 22)
        Me.ButtonAddNewCredentialProfile.Name = "ButtonAddNewCredentialProfile"
        Me.ButtonAddNewCredentialProfile.Size = New System.Drawing.Size(162, 84)
        Me.ButtonAddNewCredentialProfile.TabIndex = 23
        Me.ButtonAddNewCredentialProfile.Text = "Save to NetSDKCredentialsFile"
        Me.ButtonAddNewCredentialProfile.UseVisualStyleBackColor = True
        '
        'ButtonDeleteSelecetedCredentialProfile
        '
        Me.ButtonDeleteSelecetedCredentialProfile.Location = New System.Drawing.Point(392, 4)
        Me.ButtonDeleteSelecetedCredentialProfile.Name = "ButtonDeleteSelecetedCredentialProfile"
        Me.ButtonDeleteSelecetedCredentialProfile.Size = New System.Drawing.Size(130, 26)
        Me.ButtonDeleteSelecetedCredentialProfile.TabIndex = 24
        Me.ButtonDeleteSelecetedCredentialProfile.Text = "Delete Selected"
        Me.ButtonDeleteSelecetedCredentialProfile.UseVisualStyleBackColor = True
        '
        'ButtonRefreshCredentialProfiles
        '
        Me.ButtonRefreshCredentialProfiles.Location = New System.Drawing.Point(311, 4)
        Me.ButtonRefreshCredentialProfiles.Name = "ButtonRefreshCredentialProfiles"
        Me.ButtonRefreshCredentialProfiles.Size = New System.Drawing.Size(75, 26)
        Me.ButtonRefreshCredentialProfiles.TabIndex = 22
        Me.ButtonRefreshCredentialProfiles.Text = "Refresh"
        Me.ButtonRefreshCredentialProfiles.UseVisualStyleBackColor = True
        '
        'ComboBoxCredentialProfile
        '
        Me.ComboBoxCredentialProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCredentialProfile.FormattingEnabled = True
        Me.ComboBoxCredentialProfile.Location = New System.Drawing.Point(118, 6)
        Me.ComboBoxCredentialProfile.Name = "ComboBoxCredentialProfile"
        Me.ComboBoxCredentialProfile.Size = New System.Drawing.Size(187, 24)
        Me.ComboBoxCredentialProfile.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Profile Name"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxSSO_StartUrl, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxSSO_RoleName, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxSSO_AccountId, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxSSO_Region, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(599, 118)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TextBoxSSO_StartUrl
        '
        Me.TextBoxSSO_StartUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSSO_StartUrl.Location = New System.Drawing.Point(90, 90)
        Me.TextBoxSSO_StartUrl.Name = "TextBoxSSO_StartUrl"
        Me.TextBoxSSO_StartUrl.Size = New System.Drawing.Size(506, 23)
        Me.TextBoxSSO_StartUrl.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 29)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Account ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 31)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Start URL"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 29)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Region"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxSSO_RoleName
        '
        Me.TextBoxSSO_RoleName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSSO_RoleName.Location = New System.Drawing.Point(90, 61)
        Me.TextBoxSSO_RoleName.Name = "TextBoxSSO_RoleName"
        Me.TextBoxSSO_RoleName.Size = New System.Drawing.Size(506, 23)
        Me.TextBoxSSO_RoleName.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 29)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Role Name"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxSSO_AccountId
        '
        Me.TextBoxSSO_AccountId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSSO_AccountId.Location = New System.Drawing.Point(90, 3)
        Me.TextBoxSSO_AccountId.Name = "TextBoxSSO_AccountId"
        Me.TextBoxSSO_AccountId.Size = New System.Drawing.Size(506, 23)
        Me.TextBoxSSO_AccountId.TabIndex = 21
        '
        'TextBoxSSO_Region
        '
        Me.TextBoxSSO_Region.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSSO_Region.Location = New System.Drawing.Point(90, 32)
        Me.TextBoxSSO_Region.Name = "TextBoxSSO_Region"
        Me.TextBoxSSO_Region.Size = New System.Drawing.Size(506, 23)
        Me.TextBoxSSO_Region.TabIndex = 23
        '
        'GroupBoxSavedAccounts
        '
        Me.GroupBoxSavedAccounts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSavedAccounts.Controls.Add(Me.ButtonDeleteThisAccount)
        Me.GroupBoxSavedAccounts.Controls.Add(Me.ButtonAddNewAccount)
        Me.GroupBoxSavedAccounts.Controls.Add(Me.ComboBoxAllAccounts)
        Me.GroupBoxSavedAccounts.Location = New System.Drawing.Point(8, 5)
        Me.GroupBoxSavedAccounts.Name = "GroupBoxSavedAccounts"
        Me.GroupBoxSavedAccounts.Size = New System.Drawing.Size(907, 53)
        Me.GroupBoxSavedAccounts.TabIndex = 22
        Me.GroupBoxSavedAccounts.TabStop = False
        Me.GroupBoxSavedAccounts.Text = "Saved Accounts"
        '
        'ButtonDeleteThisAccount
        '
        Me.ButtonDeleteThisAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDeleteThisAccount.Location = New System.Drawing.Point(727, 19)
        Me.ButtonDeleteThisAccount.Name = "ButtonDeleteThisAccount"
        Me.ButtonDeleteThisAccount.Size = New System.Drawing.Size(173, 23)
        Me.ButtonDeleteThisAccount.TabIndex = 3
        Me.ButtonDeleteThisAccount.Text = "Delete This Account"
        Me.ButtonDeleteThisAccount.UseVisualStyleBackColor = True
        '
        'ButtonAddNewAccount
        '
        Me.ButtonAddNewAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddNewAccount.Location = New System.Drawing.Point(573, 19)
        Me.ButtonAddNewAccount.Name = "ButtonAddNewAccount"
        Me.ButtonAddNewAccount.Size = New System.Drawing.Size(148, 23)
        Me.ButtonAddNewAccount.TabIndex = 2
        Me.ButtonAddNewAccount.Text = "Add New Account"
        Me.ButtonAddNewAccount.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxAccountDescription, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxAccountRegion, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonBackgroundColor, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxDefaultInstanceFilter, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 64)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(625, 126)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'TabControlSecurity
        '
        Me.TabControlSecurity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlSecurity.Controls.Add(Me.TabPageSecurity)
        Me.TabControlSecurity.Controls.Add(Me.TabPageKeyPairs)
        Me.TabControlSecurity.Location = New System.Drawing.Point(7, 196)
        Me.TabControlSecurity.Name = "TabControlSecurity"
        Me.TabControlSecurity.SelectedIndex = 0
        Me.TabControlSecurity.Size = New System.Drawing.Size(627, 236)
        Me.TabControlSecurity.TabIndex = 24
        '
        'TabPageSecurity
        '
        Me.TabPageSecurity.Controls.Add(Me.TabControlCredentials)
        Me.TabPageSecurity.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSecurity.Name = "TabPageSecurity"
        Me.TabPageSecurity.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSecurity.Size = New System.Drawing.Size(619, 207)
        Me.TabPageSecurity.TabIndex = 0
        Me.TabPageSecurity.Text = "Security"
        Me.TabPageSecurity.UseVisualStyleBackColor = True
        '
        'TabControlCredentials
        '
        Me.TabControlCredentials.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControlCredentials.Controls.Add(Me.TabPageCredentialProfiles)
        Me.TabControlCredentials.Controls.Add(Me.TabPageSSO)
        Me.TabControlCredentials.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControlCredentials.Location = New System.Drawing.Point(3, 3)
        Me.TabControlCredentials.Name = "TabControlCredentials"
        Me.TabControlCredentials.SelectedIndex = 0
        Me.TabControlCredentials.Size = New System.Drawing.Size(613, 199)
        Me.TabControlCredentials.TabIndex = 25
        '
        'TabPageCredentialProfiles
        '
        Me.TabPageCredentialProfiles.Controls.Add(Me.GroupBox3)
        Me.TabPageCredentialProfiles.Controls.Add(Me.Label8)
        Me.TabPageCredentialProfiles.Controls.Add(Me.ButtonDeleteSelecetedCredentialProfile)
        Me.TabPageCredentialProfiles.Controls.Add(Me.ComboBoxCredentialProfile)
        Me.TabPageCredentialProfiles.Controls.Add(Me.ButtonRefreshCredentialProfiles)
        Me.TabPageCredentialProfiles.Location = New System.Drawing.Point(4, 28)
        Me.TabPageCredentialProfiles.Name = "TabPageCredentialProfiles"
        Me.TabPageCredentialProfiles.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCredentialProfiles.Size = New System.Drawing.Size(605, 167)
        Me.TabPageCredentialProfiles.TabIndex = 0
        Me.TabPageCredentialProfiles.Text = "Credential Profile"
        Me.TabPageCredentialProfiles.UseVisualStyleBackColor = True
        '
        'TabPageSSO
        '
        Me.TabPageSSO.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPageSSO.Location = New System.Drawing.Point(4, 28)
        Me.TabPageSSO.Name = "TabPageSSO"
        Me.TabPageSSO.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSSO.Size = New System.Drawing.Size(605, 167)
        Me.TabPageSSO.TabIndex = 1
        Me.TabPageSSO.Text = "Amazon Single Sign-on"
        Me.TabPageSSO.UseVisualStyleBackColor = True
        '
        'TabPageKeyPairs
        '
        Me.TabPageKeyPairs.Controls.Add(Me.ButtonDeleteKeyPair)
        Me.TabPageKeyPairs.Controls.Add(Me.ListBoxKeyPairs)
        Me.TabPageKeyPairs.Controls.Add(Me.ButtonAddKeyPair)
        Me.TabPageKeyPairs.Location = New System.Drawing.Point(4, 25)
        Me.TabPageKeyPairs.Name = "TabPageKeyPairs"
        Me.TabPageKeyPairs.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageKeyPairs.Size = New System.Drawing.Size(619, 207)
        Me.TabPageKeyPairs.TabIndex = 1
        Me.TabPageKeyPairs.Text = "Key Pairs"
        Me.TabPageKeyPairs.UseVisualStyleBackColor = True
        '
        'ListBoxKeyPairs
        '
        Me.ListBoxKeyPairs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxKeyPairs.FormattingEnabled = True
        Me.ListBoxKeyPairs.ItemHeight = 16
        Me.ListBoxKeyPairs.Location = New System.Drawing.Point(2, 4)
        Me.ListBoxKeyPairs.Name = "ListBoxKeyPairs"
        Me.ListBoxKeyPairs.Size = New System.Drawing.Size(607, 164)
        Me.ListBoxKeyPairs.TabIndex = 0
        '
        'AwsAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 715)
        Me.Controls.Add(Me.TabControlSecurity)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBoxSavedAccounts)
        Me.Controls.Add(Me.ButtonSaveAccount)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "AwsAccountsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Saved AWS Accounts"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBoxSavedAccounts.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabControlSecurity.ResumeLayout(False)
        Me.TabPageSecurity.ResumeLayout(False)
        Me.TabControlCredentials.ResumeLayout(False)
        Me.TabPageCredentialProfiles.ResumeLayout(False)
        Me.TabPageCredentialProfiles.PerformLayout()
        Me.TabPageSSO.ResumeLayout(False)
        Me.TabPageKeyPairs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialogKeyPair As OpenFileDialog
    Friend WithEvents ColorDialogBackgroundColor As ColorDialog
    Friend WithEvents ComboBoxAllAccounts As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxAccountRegion As ComboBox
    Friend WithEvents ButtonBackgroundColor As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonDeleteKeyPair As Button
    Friend WithEvents ButtonAddKeyPair As Button
    Friend WithEvents ButtonSaveAccount As Button
    Friend WithEvents TextBoxAccountDescription As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckedListBoxEnabledRegions As CheckedListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxDefaultInstanceFilter As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBoxNewCredProfileSecretKey As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxNewCredProfileAccessKey As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxNewCredProfileName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ButtonAddNewCredentialProfile As Button
    Friend WithEvents ButtonDeleteSelecetedCredentialProfile As Button
    Friend WithEvents ButtonRefreshCredentialProfiles As Button
    Friend WithEvents ComboBoxCredentialProfile As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxSSO_StartUrl As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxSSO_RoleName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxSSO_Region As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxSSO_AccountId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBoxSavedAccounts As GroupBox
    Friend WithEvents ButtonAddNewAccount As Button
    Friend WithEvents ButtonDeleteThisAccount As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControlSecurity As TabControl
    Friend WithEvents TabPageSecurity As TabPage
    Friend WithEvents TabPageKeyPairs As TabPage
    Friend WithEvents ListBoxKeyPairs As ListBox
    Friend WithEvents TabControlCredentials As TabControl
    Friend WithEvents TabPageCredentialProfiles As TabPage
    Friend WithEvents TabPageSSO As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
End Class
