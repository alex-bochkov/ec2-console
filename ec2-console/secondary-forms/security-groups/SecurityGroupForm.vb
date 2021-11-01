Public Class SecurityGroupForm

    Public CurrentAccount As AwsAccount
    Public SecurityGroupID As String
    Public SecurityGroup As Amazon.EC2.Model.SecurityGroup = New Amazon.EC2.Model.SecurityGroup

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SecurityGroupForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim SecurityGroupList = AmazonApi.DescribeSecurityGroups(CurrentAccount, AmazonApi.CreateSimpleFilter("group-id", SecurityGroupID))

        If SecurityGroupList.Count = 1 Then
            SecurityGroup = SecurityGroupList.Item(0)
        End If

        TextBoxSGName.DataBindings.Add("Text", SecurityGroup, "GroupName")
        TextBoxSGId.DataBindings.Add("Text", SecurityGroup, "GroupId")
        TextBoxSGDescription.DataBindings.Add("Text", SecurityGroup, "Description")
        TextBoxSGVPCId.DataBindings.Add("Text", SecurityGroup, "VpcId")


        For Each SgTag In SecurityGroup.Tags

            Dim ListViewItemTag As ListViewItem = New ListViewItem(SgTag.Key)
            ListViewItemTag.SubItems.Add(SgTag.Value)

            ListViewTags.Items.Add(ListViewItemTag)

        Next


        TabPageTags.Text = String.Format("Tags ({0})", SecurityGroup.Tags.Count)
        TabPageInbound.Text = String.Format("Inbound Roles ({0})", SecurityGroup.IpPermissions.Count)
        TabPageOutbound.Text = String.Format("Outbound Roles ({0})", SecurityGroup.IpPermissionsEgress.Count)

        For Each InboundPermission In SecurityGroup.IpPermissions

            For Each Ipv4Range In InboundPermission.Ipv4Ranges

                Dim ListViewItemInbound As ListViewItem = New ListViewItem("")
                ListViewItemInbound.SubItems.Add("") 'rule name
                ListViewItemInbound.SubItems.Add("IPv4")
                ListViewItemInbound.SubItems.Add("")
                ListViewItemInbound.SubItems.Add(InboundPermission.IpProtocol)
                ListViewItemInbound.SubItems.Add(InboundPermission.FromPort)
                ListViewItemInbound.SubItems.Add(Ipv4Range.CidrIp)
                ListViewItemInbound.SubItems.Add(Ipv4Range.Description)

                ListViewInbound.Items.Add(ListViewItemInbound)

            Next

        Next


        For Each OutboundPermission In SecurityGroup.IpPermissionsEgress

            For Each Ipv4Range In OutboundPermission.Ipv4Ranges

                Dim ListViewItemOutbound As ListViewItem = New ListViewItem("")
                ListViewItemOutbound.SubItems.Add("") 'rule name
                ListViewItemOutbound.SubItems.Add("IPv4")
                ListViewItemOutbound.SubItems.Add("")
                ListViewItemOutbound.SubItems.Add(OutboundPermission.IpProtocol)
                ListViewItemOutbound.SubItems.Add(OutboundPermission.FromPort)
                ListViewItemOutbound.SubItems.Add(Ipv4Range.CidrIp)
                ListViewItemOutbound.SubItems.Add(Ipv4Range.Description)

                ListViewOutbound.Items.Add(ListViewItemOutbound)

            Next

        Next


    End Sub

End Class
