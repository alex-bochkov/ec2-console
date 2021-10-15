<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeInstanceType
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
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ComboBoxInstanceType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(108, 33)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(120, 23)
        Me.ButtonSave.TabIndex = 0
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ComboBoxInstanceType
        '
        Me.ComboBoxInstanceType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxInstanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxInstanceType.FormattingEnabled = True
        Me.ComboBoxInstanceType.Location = New System.Drawing.Point(108, 6)
        Me.ComboBoxInstanceType.Name = "ComboBoxInstanceType"
        Me.ComboBoxInstanceType.Size = New System.Drawing.Size(206, 23)
        Me.ComboBoxInstanceType.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Instance Type"
        '
        'ChangeInstanceType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 60)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxInstanceType)
        Me.Controls.Add(Me.ButtonSave)
        Me.Name = "ChangeInstanceType"
        Me.Text = "ChangeInstanceType"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSave As Button
    Friend WithEvents ComboBoxInstanceType As ComboBox
    Friend WithEvents Label1 As Label
End Class
