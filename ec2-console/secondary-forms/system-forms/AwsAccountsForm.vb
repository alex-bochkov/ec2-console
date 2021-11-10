Public Class AwsAccountsForm

    Private AllAccounts As List(Of AwsAccount)

    Private SelectedAccount As AwsAccount = New AwsAccount
    Private Sub AwsAccountsForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        ComboBoxCredentialType.Items.Add(AwsAccount.CredentialTypeEnum.CredentialsProfile)
        ComboBoxCredentialType.Items.Add(AwsAccount.CredentialTypeEnum.SSO)

        GetAllSavedCredentialProfiles()

        AllAccounts = AccountManagement.GetAllAccounts()

        RefreshAccountList()

    End Sub

    Sub GetAllSavedCredentialProfiles()

        Dim AllProfiles = AmazonApi.GetAllSavedCredentialProfiles()

        ComboBoxCredentialProfile.Items.Clear()

        ComboBoxCredentialProfile.Items.AddRange(AllProfiles.ToArray)

    End Sub

    Private Sub RefreshAccountList()

        ListViewAccounts.Items.Clear()

        For Each Account In AllAccounts

            Dim Item = ListViewAccounts.Items.Add(Account.Description)
            Item.SubItems.Add(Account.CredentialType.ToString)
            Item.SubItems.Add(Account.Region)
            Item.SubItems.Add(Account.KeyPairs.Count.ToString)
            Item.Tag = Account

        Next

        ShowAccountDetails()

    End Sub
    Private Sub ListViewAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewAccounts.SelectedIndexChanged

        If ListViewAccounts.SelectedItems.Count = 1 Then

            SelectedAccount = ListViewAccounts.SelectedItems.Item(0).Tag

            ShowAccountDetails()

        End If

    End Sub

    Private Sub ShowAccountDetails()

        ListBoxKeyPairs.Items.Clear()

        TextBoxAccountDescription.Text = SelectedAccount.Description
        ComboBoxAccountRegion.Text = SelectedAccount.Region
        ButtonBackgroundColor.BackColor = SelectedAccount.BackgroundColor
        TextBoxDefaultInstanceFilter.Text = SelectedAccount.DefaultInstanceFilter

        ComboBoxCredentialType.SelectedItem = SelectedAccount.CredentialType

        ComboBoxCredentialProfile.SelectedItem = SelectedAccount.CredentialProfile

        TextBoxSSO_AccountId.Text = SelectedAccount.SSO_AccountId
        TextBoxSSO_Region.Text = SelectedAccount.SSO_Region
        TextBoxSSO_RoleName.Text = SelectedAccount.SSO_RoleName
        TextBoxSSO_StartUrl.Text = SelectedAccount.SSO_StartUrl

        For Each KeyPair In SelectedAccount.KeyPairs

            ListBoxKeyPairs.Items.Add(KeyPair)

        Next

        ComboBoxAccountRegion.Items.Clear()
        CheckedListBoxEnabledRegions.Items.Clear()
        For Each AwsRegion In AmazonApi.GetAllAwsRegions()

            Dim Checked As Boolean = SelectedAccount.EnabledRegions.Contains(AwsRegion.SystemName) 'Or SelectedAccount.EnabledRegions.Count = 0

            CheckedListBoxEnabledRegions.Items.Add(AwsRegion, Checked)

            ComboBoxAccountRegion.Items.Add(AwsRegion.SystemName)

        Next


    End Sub

    Private Sub ButtonSaveAccount_Click(sender As Object, e As EventArgs) Handles ButtonSaveAccount.Click

        SelectedAccount.Description = TextBoxAccountDescription.Text
        SelectedAccount.Region = ComboBoxAccountRegion.Text
        SelectedAccount.BackgroundColor = ButtonBackgroundColor.BackColor
        SelectedAccount.DefaultInstanceFilter = TextBoxDefaultInstanceFilter.Text

        SelectedAccount.CredentialType = ComboBoxCredentialType.SelectedItem

        SelectedAccount.CredentialProfile = ComboBoxCredentialProfile.SelectedItem

        SelectedAccount.SSO_AccountId = TextBoxSSO_AccountId.Text
        SelectedAccount.SSO_Region = TextBoxSSO_Region.Text
        SelectedAccount.SSO_RoleName = TextBoxSSO_RoleName.Text
        SelectedAccount.SSO_StartUrl = TextBoxSSO_StartUrl.Text

        SelectedAccount.KeyPairs.Clear()

        For Each KeyPair As AwsAccount.KeyPairClass In ListBoxKeyPairs.Items

            SelectedAccount.KeyPairs.Add(KeyPair)

        Next

        SelectedAccount.EnabledRegions.Clear()
        For Each AwsRegion As Amazon.RegionEndpoint In CheckedListBoxEnabledRegions.CheckedItems
            SelectedAccount.EnabledRegions.Add(AwsRegion.SystemName)
        Next

        AccountManagement.AddNewAccount(SelectedAccount)

        AllAccounts = AccountManagement.GetAllAccounts()

        RefreshAccountList()

    End Sub

    Private Sub ButtonAddKeyPair_Click(sender As Object, e As EventArgs) Handles ButtonAddKeyPair.Click

        OpenFileDialogKeyPair.Title = "Please select the AWS Key Pair Public Key"
        OpenFileDialogKeyPair.Filter = "Key Pair Public Key|*.pem"

        If OpenFileDialogKeyPair.ShowDialog() = DialogResult.OK Then

            Dim File = OpenFileDialogKeyPair.FileName

            Dim KeyName As String = OpenFileDialogKeyPair.SafeFileName
            Dim KeyText As String = My.Computer.FileSystem.ReadAllText(File)

            Dim NewKeyPair = New AwsAccount.KeyPairClass
            NewKeyPair.Name = KeyName
            NewKeyPair.PublicKey = KeyText

            ListBoxKeyPairs.Items.Add(NewKeyPair)

        End If

    End Sub

    Private Sub ButtonDeleteKeyPair_Click(sender As Object, e As EventArgs) Handles ButtonDeleteKeyPair.Click

        If ListBoxKeyPairs.SelectedIndex > -1 Then
            ListBoxKeyPairs.Items.RemoveAt(ListBoxKeyPairs.SelectedIndex)
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        AllAccounts.Add(New AwsAccount With {.Description = "New Access Key"})

        RefreshAccountList()

    End Sub

    Private Sub ToolStripButtonDeleteAccount_Click(sender As Object, e As EventArgs) Handles ToolStripButtonDeleteAccount.Click

        If ListViewAccounts.SelectedItems.Count = 1 Then

            SelectedAccount = ListViewAccounts.SelectedItems.Item(0).Tag

            AccountManagement.DeleteSavedAccount(SelectedAccount)

            AllAccounts = AccountManagement.GetAllAccounts()

            RefreshAccountList()

        End If

    End Sub

    Private Sub ButtonBackgroundColor_Click(sender As Object, e As EventArgs) Handles ButtonBackgroundColor.Click

        If ColorDialogBackgroundColor.ShowDialog = DialogResult.OK Then

            ButtonBackgroundColor.BackColor = ColorDialogBackgroundColor.Color

        End If

    End Sub

    Private Sub ButtonRefreshCredentialProfiles_Click(sender As Object, e As EventArgs) Handles ButtonRefreshCredentialProfiles.Click

        GetAllSavedCredentialProfiles()

    End Sub

    Private Sub ButtonAddNewCredentialProfile_Click(sender As Object, e As EventArgs) Handles ButtonAddNewCredentialProfile.Click

        AmazonApi.AddNewCredentialProfile(TextBoxNewCredProfileName.Text, TextBoxNewCredProfileAccessKey.Text, TextBoxNewCredProfileSecretKey.Text)

        TextBoxNewCredProfileName.Text = ""
        TextBoxNewCredProfileAccessKey.Text = ""
        TextBoxNewCredProfileSecretKey.Text = ""

        GetAllSavedCredentialProfiles()

        ComboBoxCredentialProfile.DroppedDown = True

    End Sub

    Private Sub ButtonDeleteSelectedCredentialProfile_Click(sender As Object, e As EventArgs) Handles ButtonDeleteSelecetedCredentialProfile.Click

        AmazonApi.DeleteCredentialProfile(ComboBoxCredentialProfile.SelectedItem.ToString)

        GetAllSavedCredentialProfiles()

        ComboBoxCredentialProfile.DroppedDown = True

    End Sub

End Class