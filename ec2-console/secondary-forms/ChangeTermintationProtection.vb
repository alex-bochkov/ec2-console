Public Class ChangeTermintationProtection

    Public CurrentAccount As AwsAccount
    Public InstanceId As String

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        AmazonApi.UpdateTerminationProtection(CurrentAccount, InstanceId, CheckBoxTerminationProtection.Checked)

        Close()

    End Sub

    Private Sub ChangeTermintationProtection_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim CurrentValue = AmazonApi.GetTerminationProtection(CurrentAccount, InstanceId)

        CheckBoxTerminationProtection.Checked = CurrentValue

    End Sub

End Class