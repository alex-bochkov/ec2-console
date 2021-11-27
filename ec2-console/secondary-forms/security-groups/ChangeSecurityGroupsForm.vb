Public Class ChangeSecurityGroupsForm

    Public CurrentAccount As AwsAccount
    Public InstanceId As String
    Private MainTable As New DataTable

    Sub ShowAllSecurityGroups()

        Dim Instance As Amazon.EC2.Model.Instance = AmazonApi.GetEc2Instance(CurrentAccount, InstanceId)

        Dim UserFilters As Dictionary(Of String, List(Of String)) = New Dictionary(Of String, List(Of String))
        UserFilters.Add("vpc-id", New List(Of String) From {Instance.VpcId})

        Dim AllSGs = AmazonApi.DescribeSecurityGroups(CurrentAccount, UserFilters)

        Dim ExistingSG = New Hashtable
        For Each SG In Instance.SecurityGroups
            ExistingSG.Add(SG.GroupId, 1)
        Next

        MainTable.Clear()
        MainTable.Columns.Add("isUsed", GetType(Boolean))
        MainTable.Columns.Add("SecurityGroupId", GetType(String))
        MainTable.Columns.Add("SecurityGroupName", GetType(String))
        MainTable.Columns.Add("SecurityGroupDescription", GetType(String))


        For Each SG In AllSGs

            Dim RowRepresentation As DataRow = MainTable.NewRow()
            If ExistingSG.ContainsKey(SG.GroupId) Then
                RowRepresentation.Item("isUsed") = True
            Else
                RowRepresentation.Item("isUsed") = False
            End If
            RowRepresentation.Item("SecurityGroupId") = SG.GroupId
            RowRepresentation.Item("SecurityGroupName") = SG.GroupName
            RowRepresentation.Item("SecurityGroupDescription") = SG.Description




            MainTable.Rows.Add(RowRepresentation)

        Next

        Dim dv As DataView = New DataView(MainTable, "", "isUsed Desc, SecurityGroupName Asc", DataViewRowState.CurrentRows)

        DataGridSecurityGroups.DataSource = dv

        For Each Column In DataGridSecurityGroups.Columns
            Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

    End Sub

    Private Sub ChangeSecurityGroups_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ShowAllSecurityGroups()


    End Sub

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilter.Click

        Dim dv As DataView

        Dim Condition As String = "isUsed = 1" +
                                    " OR SecurityGroupName Like '%" + TextBoxQuickSearch.Text + "%' " +
                                    " OR SecurityGroupDescription Like '%" + TextBoxQuickSearch.Text + "%'"

        dv = New DataView(MainTable, Condition, "isUsed Desc, SecurityGroupName Asc", DataViewRowState.CurrentRows)

        DataGridSecurityGroups.DataSource = dv

    End Sub

    Private Sub ButtonSaveChanges_Click(sender As Object, e As EventArgs) Handles ButtonSaveChanges.Click

        Dim Instance As Amazon.EC2.Model.Instance = AmazonApi.GetEc2Instance(CurrentAccount, InstanceId)

        Dim NewSGs = New List(Of String)
        For Each Record As DataRow In MainTable.Rows
            If Record.Item("isUsed") Then
                NewSGs.Add(Record.Item("SecurityGroupId"))
            End If
        Next

        Dim DeleteSGs = New List(Of String)
        Dim AddSGs = New List(Of String)

        Dim ExistingSGs = New List(Of String)
        For Each SG In Instance.SecurityGroups
            ExistingSGs.Add(SG.GroupId)

            If Not NewSGs.Contains(SG.GroupId) Then
                DeleteSGs.Add(SG.GroupId)
            End If
        Next

        For Each NewSG In NewSGs
            If Not ExistingSGs.Contains(NewSG) Then
                AddSGs.Add(NewSG)
            End If
        Next

        Dim Msg As String = "Do you want to: " + Environment.NewLine
        If AddSGs.Count > 0 Then
            Msg += " add " + String.Join(", ", AddSGs) + Environment.NewLine
        End If
        If DeleteSGs.Count > 0 Then
            Msg += " delete " + String.Join(", ", DeleteSGs) + Environment.NewLine
        End If
        Msg += "?"

        Dim Rez = MsgBox(Msg, MsgBoxStyle.YesNo, "Save changes")

        If Rez = MsgBoxResult.Yes Then

            AmazonApi.ModifyInstanceSecurityGroups(CurrentAccount, InstanceId, NewSGs)

            Close()

        End If

    End Sub

End Class