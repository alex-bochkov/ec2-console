Public Class GetConsoleScreenshot

    Public CurrentAccount As AwsAccount
    Public InstanceId As String
    Private Sub ConsoleScreenshot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim result = Ec2Instances.GetConsoleScreenshot(CurrentAccount, InstanceId)

        Dim bytes = Convert.FromBase64String(result.ImageData)

        Dim TempFile = My.Computer.FileSystem.GetTempFileName()

        My.Computer.FileSystem.WriteAllBytes(TempFile, bytes, False)

        PictureBox.Load(TempFile)

    End Sub

End Class