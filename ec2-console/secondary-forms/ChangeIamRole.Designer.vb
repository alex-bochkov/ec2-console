<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeIamRole
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxCurrentIamRole = New System.Windows.Forms.TextBox()
        Me.ComboBoxNewInstanceProfile = New System.Windows.Forms.ComboBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxCurrentIamRole
        '
        Me.TextBoxCurrentIamRole.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCurrentIamRole.Location = New System.Drawing.Point(213, 6)
        Me.TextBoxCurrentIamRole.Name = "TextBoxCurrentIamRole"
        Me.TextBoxCurrentIamRole.ReadOnly = True
        Me.TextBoxCurrentIamRole.Size = New System.Drawing.Size(342, 23)
        Me.TextBoxCurrentIamRole.TabIndex = 0
        '
        'ComboBoxNewInstanceProfile
        '
        Me.ComboBoxNewInstanceProfile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxNewInstanceProfile.FormattingEnabled = True
        Me.ComboBoxNewInstanceProfile.Location = New System.Drawing.Point(213, 37)
        Me.ComboBoxNewInstanceProfile.Name = "ComboBoxNewInstanceProfile"
        Me.ComboBoxNewInstanceProfile.Size = New System.Drawing.Size(342, 24)
        Me.ComboBoxNewInstanceProfile.TabIndex = 1
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Location = New System.Drawing.Point(559, 36)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(91, 25)
        Me.ButtonSave.TabIndex = 2
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Current IAM Instance Profile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "New IAM Instance Profile"
        '
        'ChangeIamRole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 69)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ComboBoxNewInstanceProfile)
        Me.Controls.Add(Me.TextBoxCurrentIamRole)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "ChangeIamRole"
        Me.Text = "ChangeIamRole"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxCurrentIamRole As TextBox
    Friend WithEvents ComboBoxNewInstanceProfile As ComboBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
