Public Class GetConsoleScreenshot

    Public CurrentAccount As AwsAccount
    Public InstanceId As String
    Private Sub ConsoleScreenshot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ShowScreemshot()

    End Sub

    Sub ShowScreemshot()

        Dim result = AmazonApi.GetConsoleScreenshot(CurrentAccount, InstanceId)

        Dim bytes = Convert.FromBase64String(result.ImageData)

        Dim TempFile = My.Computer.FileSystem.GetTempFileName()

        My.Computer.FileSystem.WriteAllBytes(TempFile, bytes, False)

        PictureBox.Load(TempFile)

    End Sub

    Private Sub ButtonRefreshScreenshot_Click(sender As Object, e As EventArgs) Handles ButtonRefreshScreenshot.Click

        ShowScreemshot()

    End Sub

End Class