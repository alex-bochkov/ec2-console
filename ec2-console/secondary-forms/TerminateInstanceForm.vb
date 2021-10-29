Imports System.Threading
Imports NLog
Public Class TerminateInstanceForm

    Public CurrentAccount As AwsAccount
    Public InstanceIds As List(Of String)
    Public Instances As List(Of Amazon.EC2.Model.Instance)
    Public Log As Logger = LogManager.GetCurrentClassLogger()
    Private Sub TerminateInstanceForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim UserFilter = New Dictionary(Of String, List(Of String))
        UserFilter.Add("instance-id", InstanceIds)

        Instances = AmazonApi.ListEc2Instances(CurrentAccount, UserFilter)

        For Each Instance In Instances

            Dim NewLine = TreeViewInstances.Nodes.Add(Instance.InstanceId)

            For Each InstanceTag In Instance.Tags

                If InstanceTag.Key = "Name" Then
                    NewLine.Text = NewLine.Text + " / " + InstanceTag.Value
                Else
                    NewLine.Nodes.Add(InstanceTag.Key + " = " + InstanceTag.Value)
                End If

            Next

        Next

        ButtonTerminateInstances.Text = "Terminate " + Instances.Count.ToString + " instances"

        'TreeViewInstances.ExpandAll()

    End Sub

    Sub ShowRedWarning()

        If CheckBoxDisableTerminationProtection.Checked Then
            CheckBoxDisableTerminationProtection.ForeColor = System.Drawing.Color.Red
        Else
            CheckBoxDisableTerminationProtection.ForeColor = SystemColors.ControlText
        End If

    End Sub

    Private Sub CheckBoxDisableTerminationProtection_CheckedChanged(sender As Object, e As EventArgs) _
        Handles CheckBoxDisableTerminationProtection.CheckedChanged

        ShowRedWarning()

    End Sub

    Private Sub ButtonCancelClose_Click(sender As Object, e As EventArgs) Handles ButtonCancelClose.Click

        Close()

    End Sub
    Private Sub ButtonTerminateInstances_Click(sender As Object, e As EventArgs) Handles ButtonTerminateInstances.Click

        Dim Rez = MsgBox("Do you want to terminate selected instances?", MsgBoxStyle.YesNo, "TERMINATE instances")

        If Not Rez = MsgBoxResult.Yes Then
            Exit Sub
        End If

        If Not CheckBoxDisableTerminationProtection.Checked Then

            For Each Instance In Instances

                Dim TerminationProtectionEnabled = AmazonApi.GetTerminationProtection(CurrentAccount, Instance.InstanceId)

                If TerminationProtectionEnabled Then
                    MsgBox(" Cannot continue because termination protection is enabled " + vbCrLf _
                           + " for one or more of the selected instances.", MsgBoxStyle.Critical, "Operation cancelled")
                    Exit Sub
                End If

            Next

        End If

        LabelCurrentOperation.Text = "Process has started..."
        ButtonTerminateInstances.Enabled = False

        TerminateInstances()

        Close()

    End Sub

    Sub TerminateInstances()


        Dim i = 1
        For Each Instance In Instances

            ProgressBar.Value = i / Instances.Count * 100

            LabelCurrentOperation.Text = "Disabled termination protection for " + Instance.InstanceId
            AmazonApi.UpdateTerminationProtection(CurrentAccount, Instance.InstanceId, False)

            LabelCurrentOperation.Text = "Terminating " + Instance.InstanceId
            AmazonApi.TerminateInstance(CurrentAccount, Instance.InstanceId)

            i += 1

        Next

        LabelCurrentOperation.Text = "Process has completed."
        ProgressBar.Value = 100

    End Sub



End Class