﻿
Imports System.Configuration

Namespace My

    'This class allows you to handle specific events on the settings class:
    ' The SettingChanging event is raised before a setting's value is changed.
    ' The PropertyChanged event is raised after a setting's value is changed.
    ' The SettingsLoaded event is raised after the setting values are loaded.
    ' The SettingsSaving event is raised before the setting values are saved.

    Partial Friend NotInheritable Class MySettings
        Class LocalizedMessage
            Public id As String
            Public en_US As String
            Public ru_RU As String
        End Class

        Public LocalizedMessages As Dictionary(Of String, LocalizedMessage) = New Dictionary(Of String, LocalizedMessage)

        Private Sub MySettings_SettingChanging(sender As Object, e As SettingChangingEventArgs) Handles Me.SettingChanging

        End Sub

    End Class

End Namespace
