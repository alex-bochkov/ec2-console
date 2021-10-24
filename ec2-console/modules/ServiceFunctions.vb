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

                Dim request = WebRequest.Create("https://api.github.com/repos/alekseybochkov/ec2-console/releases/latest")
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

End Namespace


