Imports System.ComponentModel

<DefaultPropertyAttribute("Description")>
Public Class AwsAccount

    Implements System.ComponentModel.INotifyPropertyChanged

    Class KeyPairClass

        Public Name As String
        Public PublicKey As String

        Public Overrides Function ToString() As String
            Return Name
        End Function

    End Class

    Public Enum CredentialTypeEnum
        CredentialProfile
        SSO
    End Enum

    Public Overrides Function ToString() As String
        Return Description
    End Function

    Public Sub New()

        KeyPairs = New List(Of KeyPairClass)
        ID = Guid.NewGuid()

    End Sub
    '------------------------------------
    Public ID As Guid

    '------------------------------------
    Private Const m_DefaultEmptyString As String = ""
    '------------------------------------
    Private m_Description As String = ""

    <Bindable(BindableSupport.Yes, BindingDirection.TwoWay)>
    <DefaultValue(m_DefaultEmptyString)>
    Public Property Description() As String
        Get
            Return m_Description
        End Get
        Set(ByVal Value As String)
            m_Description = Value
            RaiseEvent PropertyChanged(Me,
               New System.ComponentModel.PropertyChangedEventArgs("AwsAccount"))
        End Set
    End Property
    '------------------------------------
    Private m_Region As String = ""

    <Bindable(BindableSupport.Yes, BindingDirection.TwoWay)>
    <DefaultValue(m_DefaultEmptyString)>
    Public Property Region() As String
        Get
            Return m_Region
        End Get
        Set(ByVal Value As String)
            m_Region = Value
        End Set
    End Property
    '------------------------------------
    Private m_DefaultInstanceFilter As String = ""

    <Bindable(BindableSupport.Yes, BindingDirection.TwoWay)>
    <DefaultValue(m_DefaultEmptyString)>
    Public Property DefaultInstanceFilter() As String
        Get
            Return m_DefaultInstanceFilter
        End Get
        Set(ByVal Value As String)
            m_DefaultInstanceFilter = Value
        End Set
    End Property
    '------------------------------------
    Private m_BackgroundColor As Color = SystemColors.Control

    '<DefaultValue(SystemColors.Control)>
    <Bindable(BindableSupport.Yes, BindingDirection.TwoWay)>
    Public Property BackgroundColor() As Color
        Get
            Return m_BackgroundColor
        End Get
        Set(ByVal Value As Color)
            m_BackgroundColor = Value
        End Set
    End Property
    '------------------------------------
    Private m_CredentialProfile As String = ""

    <Bindable(BindableSupport.Yes, BindingDirection.TwoWay)>
    <DefaultValue(m_DefaultEmptyString)>
    Public Property CredentialProfile() As String
        Get
            Return m_CredentialProfile
        End Get
        Set(ByVal Value As String)
            m_CredentialProfile = Value
        End Set
    End Property
    '------------------------------------
    Private m_SharedCredentialProfile As String = ""

    <Bindable(BindableSupport.Yes, BindingDirection.TwoWay)>
    <DefaultValue(m_DefaultEmptyString)>
    Public Property SharedCredentialProfile() As String
        Get
            Return m_SharedCredentialProfile
        End Get
        Set(ByVal Value As String)
            m_SharedCredentialProfile = Value
        End Set
    End Property
    '------------------------------------
    Private m_CredentialType As CredentialTypeEnum

    <Bindable(BindableSupport.Yes, BindingDirection.TwoWay)>
    <DefaultValue(CredentialTypeEnum.CredentialProfile)>
    Public Property CredentialType() As CredentialTypeEnum
        Get
            Return m_CredentialType
        End Get
        Set(ByVal Value As CredentialTypeEnum)
            m_CredentialType = Value
        End Set
    End Property
    '------------------------------------
    Private m_EnabledRegions As List(Of String) = New List(Of String)

    '<DefaultValue(New List(Of String))>
    <Bindable(BindableSupport.Yes, BindingDirection.TwoWay)>
    Public Property EnabledRegions() As List(Of String)
        Get
            Return m_EnabledRegions
        End Get
        Set(ByVal Value As List(Of String))
            m_EnabledRegions = Value
        End Set
    End Property
    '------------------------------------

    Public Event PropertyChanged(sender As Object,
        e As System.ComponentModel.PropertyChangedEventArgs) _
        Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    '------------------------------------

    Public KeyPairs As List(Of KeyPairClass) = New List(Of KeyPairClass)

    Public SSOAWSCredentials As Amazon.Runtime.SSOAWSCredentials

End Class
