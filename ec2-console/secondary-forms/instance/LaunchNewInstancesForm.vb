Public Class LaunchNewInstancesForm

    Public CurrentAccount As AwsAccount
    Public InstanceIdTemplate As String

    Private Sub LaunchNewInstancesForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dim AllImages = AmazonApi.DescribeImages(CurrentAccount)

        Dim a = Amazon.EC2.Util.ImageUtilities.WINDOWS_2016_BASE

        Dim ImageIds = New List(Of String) From {"ami-5731123e"}

    End Sub

End Class