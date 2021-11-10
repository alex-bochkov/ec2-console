Imports System.Windows.Forms

Public Class ChangeInstanceDetailedMonitoring

    Public CurrentAccount As AwsAccount
    Public InstanceId As String

    Private Sub ChangeInstanceDetailedMonitoring_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim CurrentInstance = AmazonApi.GetEc2Instance(CurrentAccount, InstanceId)

        CheckBoxEnableDetailedMonitoring.Checked = (CurrentInstance.Monitoring.State.Value = "enabled")

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        AmazonApi.ModifyInstanceMonitoring_DetailedMonitoring(CurrentAccount, InstanceId, CheckBoxEnableDetailedMonitoring.Checked)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


End Class
