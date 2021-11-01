Public Class InstanceStopForm

    Public CurrentAccount As AwsAccount
    Public InstanceIDs As List(Of String) = New List(Of String)

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        AmazonApi.StopInstances(CurrentAccount, InstanceIDs, CheckBoxUseForceStop.Checked)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub InstanceStopForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim UserFilter = New Dictionary(Of String, List(Of String))
        UserFilter.Add("instance-id", InstanceIDs)
        Dim Instances = AmazonApi.ListEc2Instances(CurrentAccount, UserFilter)

        For Each Instance In Instances

            Dim Text As String = Instance.InstanceId + " / " + Instance.State.Name.Value + " / " + Instance.InstanceType.Value

            Dim Item = ListViewInstancesToStop.Items.Add(Text)
            Item.Tag = Instance.InstanceId

        Next

    End Sub

End Class
