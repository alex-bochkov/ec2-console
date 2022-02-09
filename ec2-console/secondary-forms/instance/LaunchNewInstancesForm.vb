Imports OxyPlot
Imports OxyPlot.Axes
Imports OxyPlot.Series

Public Class LaunchNewInstancesForm

    Public CurrentAccount As AwsAccount
    Public InstanceIdTemplate As String

    Private Sub LaunchNewInstancesForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim AllImages = AmazonApi.GetMostRecentWindowsImages(CurrentAccount)

        For Each Image In AllImages
            Dim val = Image.Value + " / " + Image.Name.Replace("/aws/service/ami-windows-latest/", "")
            ComboBoxImages.Items.Add(val)
        Next

    End Sub


End Class