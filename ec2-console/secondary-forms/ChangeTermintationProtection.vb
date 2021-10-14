Public Class ChangeTermintationProtection

    Public CurrentAccount As AwsAccount
    Public InstanceId As String

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Ec2Instances.UpdateTerminationProtection(CurrentAccount, InstanceId, CheckBoxTerminationProtection.Checked)

        Close()

    End Sub

    Private Sub ChangeTermintationProtection_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim CurrentValue = Ec2Instances.GetTerminationProtection(CurrentAccount, InstanceId)

        CheckBoxTerminationProtection.Checked = CurrentValue

    End Sub

End Class