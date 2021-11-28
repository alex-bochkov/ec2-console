Public Class CreateInstanceImageForm

    Public CurrentAccount As AwsAccount
    Public InstanceIDs As List(Of String) = New List(Of String)
    Public Instances As List(Of Amazon.EC2.Model.Instance) = New List(Of Amazon.EC2.Model.Instance)
    Public Log As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()

    Private Sub CreateInstanceImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim UserFilter = New Dictionary(Of String, List(Of String))
        UserFilter.Add("instance-id", InstanceIDs)
        Instances = AmazonApi.ListEc2Instances(CurrentAccount, UserFilter)

        For Each Instance In Instances

            Dim Text As String = Instance.InstanceId + " / " + Instance.State.Name.Value

            For Each InstanceTag In Instance.Tags

                If InstanceTag.Key = "Name" Then
                    Text = Text + " / " + InstanceTag.Value
                End If

            Next

            Dim Item = ListViewInstancesToModify.Items.Add(Text)
            Item.Tag = Instance.InstanceId

        Next

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ButtonCreateInstanceImage_Click(sender As Object, e As EventArgs) Handles ButtonCreateInstanceImage.Click

        For Each InstanceId In InstanceIDs

            AmazonApi.CreateInstanceImage_Quick(CurrentAccount, InstanceId)

        Next

        Me.Close()

    End Sub


End Class
