Imports System.Security.Cryptography
Imports System.Text
Imports Newtonsoft.Json

Module AccountManagement

    Public Function GetAllAccounts() As List(Of AwsAccount)

        Try

            Dim ListOfCreds = New List(Of AwsAccount)

            If Not My.Settings.SavedAccounts = "" Then

                Dim SavedAccountsSecureStringByte As Byte() = Convert.FromBase64String(My.Settings.SavedAccounts)

                Dim UnprotectedBytes As Byte() = ProtectedData.Unprotect(SavedAccountsSecureStringByte, Nothing, DataProtectionScope.CurrentUser)

                Dim JsonRepresentation As String = Encoding.Unicode.GetString(UnprotectedBytes)

                ListOfCreds = JsonConvert.DeserializeObject(Of List(Of AwsAccount))(JsonRepresentation)

            End If

            Return ListOfCreds

        Catch ex As Exception

            MsgBox(ex.Message)

            Return New List(Of AwsAccount)

        End Try

    End Function

    Public Sub AddNewAccount(AwsAccount As AwsAccount)

        Dim ExistingAccounts As List(Of AwsAccount) = GetAllAccounts()

        Dim existingIndex As Integer = -1
        For i = -(ExistingAccounts.Count - 1) To 0
            If ExistingAccounts.Item(-i).ID = AwsAccount.ID Then
                existingIndex = -i
            End If
        Next

        If existingIndex > -1 Then
            ExistingAccounts.Item(existingIndex) = AwsAccount
        Else
            ExistingAccounts.Add(AwsAccount)
        End If

        Dim JsonRepresentation As String = JsonConvert.SerializeObject(ExistingAccounts)

        Dim SavedAccountsSecureString As Byte() = ProtectedData.Protect(Encoding.Unicode.GetBytes(JsonRepresentation), Nothing, DataProtectionScope.CurrentUser)

        My.Settings.SavedAccounts = Convert.ToBase64String(SavedAccountsSecureString)
        My.Settings.Save()

    End Sub

    Public Sub DeleteSavedAccount(AwsAccount As AwsAccount)

        Dim ExistingAccounts As List(Of AwsAccount) = GetAllAccounts()

        For i = -(ExistingAccounts.Count - 1) To 0
            If ExistingAccounts.Item(-i).ID = AwsAccount.ID Then
                ExistingAccounts.Remove(ExistingAccounts.Item(-i))
            End If
        Next

        Dim JsonRepresentation As String = JsonConvert.SerializeObject(ExistingAccounts)

        Dim SavedAccountsSecureString As Byte() = ProtectedData.Protect(Encoding.Unicode.GetBytes(JsonRepresentation), Nothing, DataProtectionScope.CurrentUser)

        My.Settings.SavedAccounts = Convert.ToBase64String(SavedAccountsSecureString)
        My.Settings.Save()

    End Sub

End Module
