Public Class AwsAccountsForm

    Private Sub AwsAccountsForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        GetAllSavedCredentialProfiles()

        RefreshAccountList()

    End Sub

    Sub RefreshAccountList()

        Dim AllAccounts = AccountManagement.GetAllAccounts()

        ComboBoxAllAccounts.Items.Clear()

        ComboBoxAllAccounts.Items.AddRange(AllAccounts.ToArray)

        If ComboBoxAllAccounts.Items.Count = 0 Then
            ComboBoxAllAccounts.Items.Add(New AwsAccount)
        End If

        ComboBoxAllAccounts.SelectedIndex = 0

        GroupBoxSavedAccounts.Text = String.Format("Saved Accounts ({0})", AllAccounts.Count)

    End Sub

    Private Sub ComboBoxAllAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAllAccounts.SelectedIndexChanged

        TextBoxAccountDescription.DataBindings.Clear()
        TextBoxAccountDescription.DataBindings.Add("Text", ComboBoxAllAccounts.SelectedItem, "Description")

        TextBoxDefaultInstanceFilter.DataBindings.Clear()
        TextBoxDefaultInstanceFilter.DataBindings.Add("Text", ComboBoxAllAccounts.SelectedItem, "DefaultInstanceFilter")

        ComboBoxAccountRegion.DataBindings.Clear()
        ComboBoxAccountRegion.DataBindings.Add("Text", ComboBoxAllAccounts.SelectedItem, "Region")

        ButtonBackgroundColor.DataBindings.Clear()
        ButtonBackgroundColor.DataBindings.Add("BackColor", ComboBoxAllAccounts.SelectedItem, "BackgroundColor")

        ComboBoxCredentialProfile.DataBindings.Clear()
        ComboBoxCredentialProfile.DataBindings.Add("SelectedItem", ComboBoxAllAccounts.SelectedItem, "CredentialProfile")

        ComboBoxSharedProfile.DataBindings.Clear()
        ComboBoxSharedProfile.DataBindings.Add("SelectedItem", ComboBoxAllAccounts.SelectedItem, "SharedCredentialProfile")

        ShowAccountDetails()

        TabPageKeyPairs.Text = String.Format("Key Pairs ({0})", ListBoxKeyPairs.Items.Count)

    End Sub

    Private Sub ShowAccountDetails()

        Dim SelectedAccount As AwsAccount = ComboBoxAllAccounts.SelectedItem

        ListBoxKeyPairs.Items.Clear()
        For Each KeyPair In SelectedAccount.KeyPairs
            ListBoxKeyPairs.Items.Add(KeyPair)
        Next

        ComboBoxAccountRegion.Items.Clear()
        CheckedListBoxEnabledRegions.Items.Clear()
        For Each AwsRegion In AmazonApi.GetAllAwsRegions()

            Dim Checked As Boolean = SelectedAccount.EnabledRegions.Contains(AwsRegion.SystemName)

            CheckedListBoxEnabledRegions.Items.Add(AwsRegion, Checked)

            ComboBoxAccountRegion.Items.Add(AwsRegion.SystemName)

        Next

        If SelectedAccount.CredentialType = AwsAccount.CredentialTypeEnum.SSO Then
            TabControlCredentials.SelectedTab = TabPageSSO
        ElseIf SelectedAccount.CredentialType = AwsAccount.CredentialTypeEnum.CredentialProfile Then
            TabControlCredentials.SelectedTab = TabPageCredentialProfiles
        End If

    End Sub

    Sub GetAllSavedCredentialProfiles()

        Dim AllProfiles = AmazonApi.GetAllSavedCredentialProfiles()

        ComboBoxCredentialProfile.Items.Clear()

        ComboBoxCredentialProfile.Items.Add("")
        ComboBoxCredentialProfile.SelectedIndex = 0

        ComboBoxCredentialProfile.Items.AddRange(AllProfiles.ToArray)


        ' shared profiles
        Dim AllSharedProfiles = AmazonApi.GetAllSavedSharedCredentialProfiles()
        ComboBoxSharedProfile.Items.Clear()

        ComboBoxSharedProfile.Items.Add("")
        ComboBoxSharedProfile.SelectedIndex = 0

        ComboBoxSharedProfile.Items.AddRange(AllSharedProfiles.ToArray)

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

    Private Sub ButtonAddNewAccount_Click(sender As Object, e As EventArgs) Handles ButtonAddNewAccount.Click

        ComboBoxAllAccounts.Items.Add(New AwsAccount With {.Description = "New Account"})

        ComboBoxAllAccounts.SelectedIndex = ComboBoxAllAccounts.Items.Count - 1

    End Sub

    Private Sub ButtonSaveAccount_Click(sender As Object, e As EventArgs) Handles ButtonSaveAccount.Click

        Dim SelectedAccount As AwsAccount = ComboBoxAllAccounts.SelectedItem

        SelectedAccount.KeyPairs.Clear()
        For Each KeyPair As AwsAccount.KeyPairClass In ListBoxKeyPairs.Items
            SelectedAccount.KeyPairs.Add(KeyPair)
        Next

        SelectedAccount.EnabledRegions.Clear()
        For Each AwsRegion As Amazon.RegionEndpoint In CheckedListBoxEnabledRegions.CheckedItems
            SelectedAccount.EnabledRegions.Add(AwsRegion.SystemName)
        Next

        If TabControlCredentials.SelectedTab Is TabPageSSO Then
            SelectedAccount.CredentialType = AwsAccount.CredentialTypeEnum.SSO
        ElseIf TabControlCredentials.SelectedTab Is TabPageCredentialProfiles Then
            SelectedAccount.CredentialType = AwsAccount.CredentialTypeEnum.CredentialProfile
        End If

        AccountManagement.AddNewAccount(SelectedAccount)

        RefreshAccountList()

    End Sub

    Private Sub ButtonDeleteThisAccount_Click(sender As Object, e As EventArgs) Handles ButtonDeleteThisAccount.Click

        Dim SelectedAccount As AwsAccount = ComboBoxAllAccounts.SelectedItem

        AccountManagement.DeleteSavedAccount(SelectedAccount)

        RefreshAccountList()

    End Sub

End Class