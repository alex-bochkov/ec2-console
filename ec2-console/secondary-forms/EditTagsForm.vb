Imports System.Windows.Forms

Public Class EditTagsForm

    Public CurrentAccount As AwsAccount
    Public InstanceId As String
    Public Instance As Amazon.EC2.Model.Instance
    Public Log As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()

    Private ExistingTags As SortedDictionary(Of String, String) = New SortedDictionary(Of String, String)


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        SaveTags()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub EditTagsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim NextToken As String = ""

        Dim FilterList = New List(Of String)
        FilterList.Add(InstanceId)

        Dim UserFilter = New Dictionary(Of String, List(Of String))
        UserFilter.Add("instance-id", FilterList)

        Dim Instances = AmazonApi.ListEc2Instances(CurrentAccount, UserFilter, NextToken)

        If Instances.Count = 1 Then

            Instance = Instances.Item(0)

            For Each InstanceTag In Instance.Tags

                DataGridViewTags.Rows.Add(New String() {InstanceTag.Key, InstanceTag.Value})

                ExistingTags.Add(InstanceTag.Key, InstanceTag.Value)

            Next

            Text = "Exit Object Tags - " + Instance.InstanceId

        End If


    End Sub

    Sub SaveTags()

        Dim NewTags = New Dictionary(Of String, String)

        For i = 0 To DataGridViewTags.Rows.Count - 1

            Dim TagKey As String = DataGridViewTags.Item(0, i).Value
            Dim TagValue As String = DataGridViewTags.Item(1, i).Value

            If Not TagKey Is Nothing Then
                NewTags.Add(TagKey, TagValue)
            End If

        Next

        '*****************************************************************

        Dim TagsToAdd = New List(Of Amazon.EC2.Model.Tag)
        Dim TagsToDelete = New List(Of Amazon.EC2.Model.Tag)

        '*****************************************************************

        For Each NewTagKey In NewTags.Keys

            If Not ExistingTags.ContainsKey(NewTagKey) Then
            ElseIf ExistingTags.Item(NewTagKey) <> NewTags.Item(NewTagKey) Then
            Else
                Continue For
            End If

            Dim NewTag = New Amazon.EC2.Model.Tag
            NewTag.Key = NewTagKey
            NewTag.Value = NewTags.Item(NewTagKey)
            TagsToAdd.Add(NewTag)

        Next

        '*****************************************************************

        For Each OldTagKey In ExistingTags.Keys

            If NewTags.ContainsKey(OldTagKey) Then
                Continue For
            End If

            Dim NewTag = New Amazon.EC2.Model.Tag
            NewTag.Key = OldTagKey
            NewTag.Value = ExistingTags.Item(OldTagKey)
            TagsToDelete.Add(NewTag)

        Next

        'DataGridViewTags

        If TagsToAdd.Count > 0 Then

            AmazonApi.CreateTags(CurrentAccount, InstanceId, TagsToAdd)

            For Each TagToAdd In TagsToAdd

                Dim Msg = String.Format("Added tag to {0} instance: {1} = {2}",
                           InstanceId, TagToAdd.Key, TagToAdd.Value)

                Dim eventInfo = New NLog.LogEventInfo(NLog.LogLevel.Info, Log.Name, Msg)
                eventInfo.Properties.Add("Category", "AddObjectTag")

                Log.Info(eventInfo)

            Next

        End If


        If TagsToDelete.Count > 0 Then

            AmazonApi.DeleteTags(CurrentAccount, InstanceId, TagsToDelete)

            For Each TagToDelete In TagsToDelete

                Dim Msg = String.Format("Deleted tag to {0} instance: {1} = {2}",
                           InstanceId, TagToDelete.Key, TagToDelete.Value)

                Dim eventInfo = New NLog.LogEventInfo(NLog.LogLevel.Info, Log.Name, Msg)
                eventInfo.Properties.Add("Category", "DeleteObjectTag")

                Log.Info(eventInfo)

            Next

        End If


    End Sub

End Class
