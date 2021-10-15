Public Class ChangeInstanceType

    Public CurrentAccount As AwsAccount
    Public Instance As Amazon.EC2.Model.Instance
    Public Log As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()

    Public InstanceTypeList As List(Of Amazon.EC2.Model.InstanceTypeInfo)
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

        For Each InstanceType In InstanceTypeList

            ComboBoxInstanceType.Items.Add(InstanceType.InstanceType.Value)

        Next

        ComboBoxInstanceType.SelectedItem = Instance.InstanceType.Value

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim InstanceType = ComboBoxInstanceType.SelectedItem
        Dim InstanceId = Instance.InstanceId
        Dim InstanceTypeOld = Instance.InstanceType.Value

        Ec2Instances.ModifyInstanceType(CurrentAccount, Instance.InstanceId, InstanceType)

        Dim Msg = String.Format("The instance type for {0} instance has been modified: {1} -> {2}",
                        InstanceId, InstanceTypeOld, InstanceType)

        Dim eventInfo = New NLog.LogEventInfo(NLog.LogLevel.Info, Log.Name, Msg)
        eventInfo.Properties.Add("Category", "ModifyInstanceType")

        Log.Info(eventInfo)

        Close()

    End Sub

End Class