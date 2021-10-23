Imports System.Windows.Forms

Public Class ObjectHistoryForm

    Public CurrentAccount As AwsAccount
    Public ResourceId As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ObjectHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim a = AmazonApi.GetResourceConfigHistory(CurrentAccount, ResourceId)
        'TBD
        For Each aa In a
            ListBoxVersions.Items.Add(aa)
        Next

    End Sub

End Class
