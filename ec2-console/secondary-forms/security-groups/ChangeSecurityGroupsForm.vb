Imports Amazon.EC2.Model

Public Class ChangeSecurityGroupsForm

    Public CurrentAccount As AwsAccount
    Public Instance As Instance
    Private MainTable As New DataTable

    Sub ShowAllSecurityGroups()

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

End Class