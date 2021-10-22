Public Class ChangeIamRole

    Public CurrentAccount As AwsAccount
    Public InstanceId As String
    Public Instance As Amazon.EC2.Model.Instance

    Private Sub ChangeIamRole_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim NextToken As String = ""

        Dim FilterList = New List(Of String)
        FilterList.Add(InstanceId)

        Dim UserFilter = New Dictionary(Of String, List(Of String))
        UserFilter.Add("instance-id", FilterList)

        Dim Instances = AmazonApi.ListEc2Instances(CurrentAccount, UserFilter, NextToken)

        If Instances.Count > 0 Then
            Instance = Instances.Item(0)
        End If

        If Not Instance.IamInstanceProfile Is Nothing Then

            Dim Arn As String = Instance.IamInstanceProfile.Arn

            TextBoxCurrentIamRole.Text = Arn.Substring(Arn.IndexOf("/")) 'show only the role name

        End If

        '*******************************************************

        Dim Profiles = AmazonApi.ListInstanceProfiles(CurrentAccount)

        For Each Profile In Profiles

            ComboBoxNewInstanceProfile.Items.Add(Profile.Arn)

        Next

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim CurrentAssosiations = AmazonApi.GetInstanceProfileAssociation(CurrentAccount, InstanceId)

        If (CurrentAssosiations.Count > 0) Then

            AmazonApi.RemoveInstanceProfileAssociation(CurrentAccount, CurrentAssosiations.Item(0).AssociationId)

        End If


        Dim Iam = New Amazon.EC2.Model.IamInstanceProfileSpecification
        Iam.Arn = ComboBoxNewInstanceProfile.Text
        Dim Result = AmazonApi.AddInstanceProfileAssociation(CurrentAccount, InstanceId, Iam)

        Close()

    End Sub


End Class