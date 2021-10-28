Public Class ChangeInstanceType

    Public InstanceTypeList As List(Of Amazon.EC2.Model.InstanceTypeInfo)
    Public CurrentAccount As AwsAccount
    Public InstanceIDs As List(Of String) = New List(Of String)
    Public Instances As List(Of Amazon.EC2.Model.Instance) = New List(Of Amazon.EC2.Model.Instance)
    Public Log As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()

    Private Sub ChangeInstanceType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'sort it properly - by the instance family first, by the size next
        InstanceTypeList.Sort(
            Function(elementA As Amazon.EC2.Model.InstanceTypeInfo, elementB As Amazon.EC2.Model.InstanceTypeInfo)

                Dim instanceTypeA = elementA.InstanceType.Value
                Dim instanceTypeB = elementB.InstanceType.Value

                Dim instanceFamilyA = instanceTypeA.Substring(0, instanceTypeA.IndexOf("."))
                Dim instanceFamilyB = instanceTypeB.Substring(0, instanceTypeB.IndexOf("."))

                If instanceFamilyA = instanceFamilyB Then

                    Dim vCpuInfoA = elementA.VCpuInfo.DefaultCores
                    Dim vCpuInfoB = elementB.VCpuInfo.DefaultCores

                    Return vCpuInfoA.CompareTo(vCpuInfoB)

                Else
                    Return instanceFamilyA.CompareTo(instanceFamilyB)
                End If

            End Function)

        For Each InstanceID In InstanceIDs
            ListBoxInstancesToModify.Items.Add(InstanceID)
        Next

        Dim UserFilter = New Dictionary(Of String, List(Of String))
        UserFilter.Add("instance-id", InstanceIDs)

        Instances = AmazonApi.ListEc2Instances(CurrentAccount, UserFilter, Nothing)

        For Each InstanceType In InstanceTypeList

            ComboBoxInstanceType.Items.Add(InstanceType.InstanceType.Value)

        Next

        If Instances.Count > 0 Then
            ComboBoxInstanceType.SelectedItem = Instances.Item(0).InstanceType.Value
        End If

    End Sub

    Private Sub ModifyInstanceType()

        Dim InstanceType = ComboBoxInstanceType.SelectedItem

        For Each Instance In Instances

            Dim InstanceId = Instance.InstanceId
            Dim InstanceTypeOld = Instance.InstanceType.Value

            AmazonApi.ModifyInstanceType(CurrentAccount, Instance.InstanceId, InstanceType)

            Dim Msg = String.Format("The instance type for {0} instance has been modified: {1} -> {2}",
                            InstanceId, InstanceTypeOld, InstanceType)

            Dim eventInfo = New NLog.LogEventInfo(NLog.LogLevel.Info, Log.Name, Msg)
            eventInfo.Properties.Add("Category", "ModifyInstanceType")

            Log.Info(eventInfo)

        Next


        Close()

    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        ModifyInstanceType()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ButtonScaleUp_Click(sender As Object, e As EventArgs) Handles ButtonScaleUp.Click

        If ComboBoxInstanceType.SelectedIndex < ComboBoxInstanceType.Items.Count - 1 Then
            ComboBoxInstanceType.SelectedIndex = ComboBoxInstanceType.SelectedIndex + 1
        End If

    End Sub

    Private Sub ButtonScaleDown_Click(sender As Object, e As EventArgs) Handles ButtonScaleDown.Click

        If ComboBoxInstanceType.SelectedIndex > 0 Then
            ComboBoxInstanceType.SelectedIndex = ComboBoxInstanceType.SelectedIndex - 1
        End If

    End Sub

End Class
