Imports System.Windows.Forms

Public Class InstanceTypeForm

    Public CurrentAccount As AwsAccount
    Public InstanceType As String
    Public InstanceTypeInfo As Amazon.EC2.Model.InstanceTypeInfo = New Amazon.EC2.Model.InstanceTypeInfo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub InstanceTypeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxArchitecture.Text = String.Join(", ", InstanceTypeInfo.ProcessorInfo.SupportedArchitectures)
        TextBoxMemory.Text = String.Format("{0} Gb", InstanceTypeInfo.MemoryInfo.SizeInMiB / 1024)
        TextBoxLocalStorage.Text = String.Format("{0} Gb * {1} disks", InstanceTypeInfo.InstanceStorageInfo.TotalSizeInGB, InstanceTypeInfo.InstanceStorageInfo.Disks.Count)

        TextBoxInstanceType.DataBindings.Add("Text", InstanceTypeInfo, "InstanceType")
        TextBoxClockSpeed.DataBindings.Add("Text", InstanceTypeInfo, "ProcessorInfo.SustainedClockSpeedInGhz")
        TextBoxCores.DataBindings.Add("Text", InstanceTypeInfo, "VCpuInfo.DefaultCores")
        TextBoxNetworkPerformance.DataBindings.Add("Text", InstanceTypeInfo, "NetworkInfo.NetworkPerformance")

        Dim InstanceType = InstanceTypeInfo.InstanceType.Value

        Try

            'this API is fucking nightmare!
            Dim PricesJson = AmazonApi.GetPriceListForInstanceType(CurrentAccount, InstanceType)

            For Each PriceJson In PricesJson

                Dim parcedPrices As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.Linq.JObject.Parse(PriceJson)

                Dim operatingSystem = DirectCast(parcedPrices.SelectToken("product.attributes.operatingSystem"), Newtonsoft.Json.Linq.JValue).Value
                Dim CostDescription = DirectCast(parcedPrices.SelectToken("terms.OnDemand.*.priceDimensions.*.description"), Newtonsoft.Json.Linq.JValue).Value

                If operatingSystem = "Windows" Then
                    TextBoxPriceWindows.Text = CostDescription
                ElseIf operatingSystem = "Linux" Then
                    TextBoxPriceLinux.Text = CostDescription
                End If

            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub
End Class
