Imports System.Net
Imports Newtonsoft.Json

Namespace ServiceFunctions
    Module VersionCheck

        Class GitHubReleaseResponse
            Public name As String
            Public published_at As String
            Public tag_name As String
        End Class

        Function GetTheMostRecentReleaseFromGithub() As GitHubReleaseResponse

            Dim LatestVersion As GitHubReleaseResponse = New GitHubReleaseResponse With {.tag_name = "1.0.0"}

            Try

                Dim webClient As New System.Net.WebClient

                Dim request = WebRequest.Create("https://api.github.com/repos/alex-bochkov/ec2-console/releases/latest")
                request.Headers.Set("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.54 Safari/537.36")

                Dim response As WebResponse = request.GetResponse()

                Dim reader = New System.IO.StreamReader(response.GetResponseStream(), System.Text.ASCIIEncoding.ASCII)

                Dim responseText = reader.ReadToEnd()

                Dim resultObject = JsonConvert.DeserializeObject(Of GitHubReleaseResponse)(responseText)

                Return resultObject

            Catch ex As Exception

                Dim b = ex.Message

            End Try

            Return LatestVersion

        End Function

    End Module

    Module ManualLocalization
        Class AllMessages
            Public Messages As List(Of My.MySettings.LocalizedMessage)
        End Class

        Sub LoadAllLocalizedMessagesInMemory()

            Dim Dict As Dictionary(Of String, My.MySettings.LocalizedMessage) = New Dictionary(Of String, My.MySettings.LocalizedMessage)

            Dim a = My.Resources.LocalizedMessages

            Dim resultObject = JsonConvert.DeserializeObject(Of AllMessages)(a)

            For Each Msg In resultObject.Messages
                My.Settings.LocalizedMessages.Add(Msg.id, Msg)
            Next

        End Sub

        Function GetLocalizedMessage(MessageCode As String) As String

            Dim resultString As My.MySettings.LocalizedMessage = Nothing

            My.Settings.LocalizedMessages.TryGetValue(MessageCode, resultString)

            If My.Settings.Language = "en-US" Then
                Return resultString.en_US
            ElseIf My.Settings.Language = "ru-RU" Then
                Return resultString.ru_RU
            Else
                Return resultString.en_US
            End If

        End Function

    End Module

    Module EmbeddedButtons

        Function AddEmbeddedButton_Open(TextBoxTarget As TextBox) As Button

            Dim btn = New Button()
            btn.Text = ".."
            btn.Size = New Size(25, TextBoxTarget.ClientSize.Height + 2)
            btn.Location = New Point(TextBoxTarget.ClientSize.Width - btn.Width, -1)
            btn.Cursor = Cursors.Default
            'btn.Image = Properties.Resources.star
            AddHandler btn.Click, AddressOf Form1.EmbeddedButtonOpenClick
            TextBoxTarget.Controls.Add(btn)

            Return btn

        End Function

        Function AddEmbeddedButton_Copy(TextBoxTarget As TextBox) As Button

            Dim btn = New Button()
            'btn.Text = ".."
            btn.BackgroundImage = My.Resources.ButtonCopy
            btn.BackgroundImageLayout = ImageLayout.Zoom
            btn.Size = New Size(25, TextBoxTarget.ClientSize.Height + 2)
            btn.Location = New Point(TextBoxTarget.ClientSize.Width - btn.Width, -1)
            btn.Cursor = Cursors.Default
            'btn.Image = Properties.Resources.star
            AddHandler btn.Click, AddressOf Form1.EmbeddedButtonCopyClick
            TextBoxTarget.Controls.Add(btn)

            Return btn

        End Function

    End Module

End Namespace


