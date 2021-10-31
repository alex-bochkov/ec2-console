Imports System.Windows.Forms
Imports Newtonsoft.Json.Linq

Public Class ObjectHistoryForm

    Public CurrentAccount As AwsAccount
    Public ResourceId As String
    Dim AllVersions As List(Of Amazon.ConfigService.Model.ConfigurationItem)
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ObjectHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AllVersions = AmazonApi.GetResourceConfigHistory(CurrentAccount, ResourceId)

        If AllVersions.Count > 1 Then
            For i = 1 To AllVersions.Count - 1

                Dim Version1 = AllVersions.Item(i - 1)
                Dim Version2 = AllVersions.Item(i)

                Dim Diff = FindJsonDiff(JToken.Parse(Version1.Configuration), JToken.Parse(Version2.Configuration))

                Dim DiffString = Newtonsoft.Json.JsonConvert.SerializeObject(Diff, Newtonsoft.Json.Formatting.Indented)

                DataGridViewVersions.Rows.Add(DiffString)

                '                foreach(ManagementObject share In shares.Get()) {
                '  dgv.Rows.Add(New String[] { share["Name"].ToString(),
                '                              share["Path"].ToString() + "\n" + "AAAA" });
                '}

                '                Dim LVGroup As ListViewGroup = New ListViewGroup(Version2.ConfigurationItemCaptureTime.ToString)
                '                ListViewVersion.Groups.Add(LVGroup)



                '                Dim LVItem As ListViewItem = New ListViewItem(DiffString, LVGroup)

                '                'LVItem.SubItems.Add("2")

                '                ListViewVersion.Items.Add(LVItem)

            Next

        End If

    End Sub


    Function FindJsonDiff(Current As JToken, Model As JToken) As JObject

        Dim diff = New JObject()

        If (JToken.DeepEquals(Current, Model)) Then Return diff

        Select Case Current.Type
            Case JTokenType.Object

                Dim addedKeys = Current.Select(Function(c) c.Path).Except(Model.Select(Function(c) c.Path))
                Dim removedKeys = Model.Select(Function(c) c.Path).Except(Current.Select(Function(c) c.Path))

                'Private unchangedKeys As JToken = Current.Properties().Where(c >= JToken.DeepEquals(c.Value, Model(c.Name))).[Select](c >= c.Name)
                'JToken unchangedKeys = Current.Properties().Where(c >= JToken.DeepEquals(c.Value, Model[c.Name])).Select(c >= c.Name);

                For Each k In addedKeys
                    Dim NewKey As JObject = New JObject
                    NewKey.Add("+", Current.Item(k))
                    diff.Add(k, NewKey)
                Next

                For Each k In removedKeys
                    Dim NewKey As JObject = New JObject
                    NewKey.Add("-", Model.Item(k))
                    diff.Add(k, NewKey)
                Next

                Dim potentiallyModifiedKeys = Current.Select(Function(c) c.Path).Except(addedKeys)

                For Each k In potentiallyModifiedKeys

                    Dim foundDiff = FindJsonDiff(Current.Item(k), Model.Item(k))
                    If (foundDiff.HasValues) Then diff.Add(k, foundDiff)

                Next

            Case JTokenType.Array

                Dim plus = New JArray(Current.Except(Model, New JTokenEqualityComparer()))
                Dim minus = New JArray(Model.Except(Current, New JTokenEqualityComparer()))

                If (plus.HasValues) Then diff.Add("+", plus)
                If (minus.HasValues) Then diff.Add("-", minus)

            Case Else

                diff.Add("+", Current)
                diff.Add("-", Model)

        End Select

        Return diff

    End Function

End Class
