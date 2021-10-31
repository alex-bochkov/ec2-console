Imports System.Windows.Forms

Public Class ImageForm

    Public CurrentAccount As AwsAccount
    Public ImageID As String
    Public Image As Amazon.EC2.Model.Image = New Amazon.EC2.Model.Image

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ImageForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim Images = AmazonApi.DescribeImages(CurrentAccount, AmazonApi.CreateSimpleFilter("image-id", ImageID))

        If Images.Count = 1 Then
            Image = Images.Item(0)
        End If

        TextBoxImageName.DataBindings.Add("Text", Image, "Name")
        TextBoxImageId.DataBindings.Add("Text", Image, "ImageId")
        TextBoxImageDescription.DataBindings.Add("Text", Image, "Description")
        TextBoxImageCreationDate.DataBindings.Add("Text", Image, "CreationDate")
        TextBoxImageDeprecationTime.DataBindings.Add("Text", Image, "DeprecationTime")
        TextBoxImageStatus.DataBindings.Add("Text", Image, "State")
        TextBoxImagePlatform.DataBindings.Add("Text", Image, "Platform")
        TextBoxImagePlatformDetails.DataBindings.Add("Text", Image, "PlatformDetails")
        TextBoxImageType.DataBindings.Add("Text", Image, "ImageType")


    End Sub

End Class
