Imports System.ComponentModel

<DefaultPropertyAttribute("Description")>
Public Class AwsAccount

    Public ID As Guid
    Public Description As String
    Public AccessKey As String
    Public SecretKey As String
    Public Region As String
    Public DefaultInstanceFilter As String = ""
    Public EnabledRegions As List(Of String) = New List(Of String)
    Public BackgroundColor As Color = SystemColors.Control
    Public KeyPairs As List(Of KeyPairClass)

    Public Overrides Function ToString() As String
        Return Description
    End Function

    Class KeyPairClass

        Public Name As String
        Public PublicKey As String

        Public Overrides Function ToString() As String
            Return Name
        End Function

    End Class

    Public Sub New()

        KeyPairs = New List(Of KeyPairClass)
        ID = Guid.NewGuid()

    End Sub

End Class
