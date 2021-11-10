Imports System.ComponentModel

<DefaultPropertyAttribute("Description")>
Public Class AwsAccount

    Public Enum CredentialTypeEnum
        CredentialsProfile
        SSO
    End Enum

    Public ID As Guid

    Public Description As String = ""

    '------------------------------------
    ' one day I'll do it properly ..
    'Private Const m_DefaultEmptyString As String = ""
    'Private m_Description As String = ""
    '
    '<Bindable(BindableSupport.Yes, BindingDirection.TwoWay)>
    '<DefaultValue(m_DefaultEmptyString)>
    'Public Property Description() As String
    '    Get
    '        Return m_Description
    '    End Get
    '    Set(ByVal Value As String)
    '        m_Description = Value
    '    End Set
    'End Property
    '------------------------------------

    Public Region As String = ""
    Public DefaultInstanceFilter As String = ""
    Public EnabledRegions As List(Of String) = New List(Of String)
    Public BackgroundColor As Color = SystemColors.Control
    Public KeyPairs As List(Of KeyPairClass) = New List(Of KeyPairClass)
    Public CredentialType As CredentialTypeEnum = CredentialTypeEnum.CredentialsProfile
    Public CredentialProfile As String = ""

    Public SSOAWSCredentials As Amazon.Runtime.SSOAWSCredentials

    Public SSO_AccountId As String = ""
    Public SSO_Region As String = ""
    Public SSO_RoleName As String = ""
    Public SSO_StartUrl As String = ""

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
