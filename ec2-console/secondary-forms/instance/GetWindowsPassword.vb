Public Class GetWindowsPassword

    Public CurrentAccount As AwsAccount
    Public InstanceId As String
    Public InstanceKey As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Dim password = AmazonApi.GetWindowsPassword(CurrentAccount, InstanceId, ComboBoxKeyPairs.SelectedItem)

            TextBoxDecryptedPassword.Text = password

        Catch ex As Exception

            MsgBox("Unable to get or decrypt the password. Wrong key?")

        End Try


    End Sub

    Private Sub GetWindowsPassword_Load(sender As Object, e As EventArgs) Handles Me.Load

        For Each KeyPair In CurrentAccount.KeyPairs
            ComboBoxKeyPairs.Items.Add(KeyPair)
        Next

        If CurrentAccount.KeyPairs.Count > 0 Then
            ComboBoxKeyPairs.SelectedItem = CurrentAccount.KeyPairs.Item(0)
        End If

        TextBoxInstanceKey.Text = InstanceKey

    End Sub

    Private Sub ButtonCopyToClipboard_Click(sender As Object, e As EventArgs) Handles ButtonCopyToClipboard.Click

        System.Windows.Forms.Clipboard.SetText(TextBoxDecryptedPassword.Text)

    End Sub

End Class