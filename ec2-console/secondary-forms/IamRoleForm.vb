Imports Newtonsoft.Json.Linq

Public Class IamRoleForm

    Public CurrentAccount As AwsAccount
    Public RoleName As String
    'Public Image As Amazon.EC2.Model.Image = New Amazon.EC2.Model.Image

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ImageForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim Role = AmazonApi.GetRole(CurrentAccount, RoleName)
        TextBoxRoleName.DataBindings.Add("Text", Role, "RoleName")
        TextBoxRoleArn.DataBindings.Add("Text", Role, "Arn")
        TextBoxRoleDescription.DataBindings.Add("Text", Role, "Description")
        TextBoxRoleCreationDate.DataBindings.Add("Text", Role, "CreateDate")

        Dim AllPolicies = AmazonApi.ListAttachedRolePolicies(CurrentAccount, RoleName)

        For Each SelectedPolicy In AllPolicies

            Dim Policy = AmazonApi.GetPolicy(CurrentAccount, SelectedPolicy.PolicyArn)

            Dim PolicyVersion = AmazonApi.GetPolicyVersion(CurrentAccount, SelectedPolicy.PolicyArn, Policy.DefaultVersionId)

            Dim Doc = System.Web.HttpUtility.UrlDecode(PolicyVersion.Document)

            RichTextBoxPermissions.Text +=
                "---------------------------------------" + Environment.NewLine _
                + "- Created     : " + Policy.UpdateDate.ToString + Environment.NewLine _
                + "- Policy Name : " + Policy.PolicyName + Environment.NewLine _
                + JObject.Parse(Doc).ToString() + Environment.NewLine

        Next

        Text = String.Format("Role {0} - attached {1} policies", RoleName, AllPolicies.Count)

    End Sub

End Class
