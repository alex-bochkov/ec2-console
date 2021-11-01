Public Class AwsAccountsForm

    Private AllAccounts As List(Of AwsAccount)

    Private SelectedAccount As AwsAccount = New AwsAccount
    Private Sub AwsAccountsForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        AllAccounts = AccountManagement.GetAllAccounts()

        RefreshAccountList()

    End Sub

    Private Sub RefreshAccountList()

        ListViewAccounts.Items.Clear()

        For Each Account In AllAccounts

            Dim Item = ListViewAccounts.Items.Add(Account.Description)
            Item.SubItems.Add(Account.AccessKey)
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
        TextBoxAccountAccessKey.Text = SelectedAccount.AccessKey
        TextBoxAccountSecretKey.Text = SelectedAccount.SecretKey
        ComboBoxAccountRegion.Text = SelectedAccount.Region
        ButtonBackgroundColor.BackColor = SelectedAccount.BackgroundColor

        TextBoxDefaultInstanceFilter.Text = SelectedAccount.DefaultInstanceFilter

        For Each KeyPair In SelectedAccount.KeyPairs

            ListBoxKeyPairs.Items.Add(KeyPair)

        Next

        ComboBoxAccountRegion.Items.Clear()
        CheckedListBoxEnabledRegions.Items.Clear()
        For Each AwsRegion In AmazonApi.GetAllAwsRegions()

            Dim Checked As Boolean = SelectedAccount.EnabledRegions.Contains(AwsRegion.SystemName) _
                Or SelectedAccount.EnabledRegions.Count = 0

            CheckedListBoxEnabledRegions.Items.Add(AwsRegion, Checked)

            ComboBoxAccountRegion.Items.Add(AwsRegion.SystemName)

        Next


    End Sub

    Private Sub ButtonSaveAccount_Click(sender As Object, e As EventArgs) Handles ButtonSaveAccount.Click

        SelectedAccount.Description = TextBoxAccountDescription.Text
        SelectedAccount.AccessKey = TextBoxAccountAccessKey.Text
        SelectedAccount.SecretKey = TextBoxAccountSecretKey.Text
        SelectedAccount.Region = ComboBoxAccountRegion.Text
        SelectedAccount.BackgroundColor = ButtonBackgroundColor.BackColor
        SelectedAccount.DefaultInstanceFilter = TextBoxDefaultInstanceFilter.Text

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


End Class