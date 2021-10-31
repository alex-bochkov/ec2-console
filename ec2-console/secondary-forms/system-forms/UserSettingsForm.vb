Imports System.Windows.Forms

Public Class UserSettingsForm

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        My.Settings.MaxInstancesToLoad = NumericUpDownMaxNumberOfInstances.Value

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub UserSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NumericUpDownMaxNumberOfInstances.Value = My.Settings.MaxInstancesToLoad

    End Sub

End Class
