<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetachAndDeleteVolumeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxVolumeIds = New System.Windows.Forms.TextBox()
        Me.ButtonDetachAndDelete = New System.Windows.Forms.Button()
        Me.CheckBoxForceDetach = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDeleteDetachedVolumes = New System.Windows.Forms.CheckBox()
        Me.LabelCurrentOperation = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Volume IDs"
        '
        'TextBoxVolumeIds
        '
        Me.TextBoxVolumeIds.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxVolumeIds.Location = New System.Drawing.Point(146, 11)
        Me.TextBoxVolumeIds.Name = "TextBoxVolumeIds"
        Me.TextBoxVolumeIds.ReadOnly = True
        Me.TextBoxVolumeIds.Size = New System.Drawing.Size(413, 23)
        Me.TextBoxVolumeIds.TabIndex = 1
        '
        'ButtonDetachAndDelete
        '
        Me.ButtonDetachAndDelete.Location = New System.Drawing.Point(11, 96)
        Me.ButtonDetachAndDelete.Name = "ButtonDetachAndDelete"
        Me.ButtonDetachAndDelete.Size = New System.Drawing.Size(238, 35)
        Me.ButtonDetachAndDelete.TabIndex = 10
        Me.ButtonDetachAndDelete.Text = "Detach and Delete Volumes"
        Me.ButtonDetachAndDelete.UseVisualStyleBackColor = True
        '
        'CheckBoxForceDetach
        '
        Me.CheckBoxForceDetach.AutoSize = True
        Me.CheckBoxForceDetach.Location = New System.Drawing.Point(15, 42)
        Me.CheckBoxForceDetach.Name = "CheckBoxForceDetach"
        Me.CheckBoxForceDetach.Size = New System.Drawing.Size(115, 20)
        Me.CheckBoxForceDetach.TabIndex = 11
        Me.CheckBoxForceDetach.Text = "Force Detach"
        Me.CheckBoxForceDetach.UseVisualStyleBackColor = True
        '
        'CheckBoxDeleteDetachedVolumes
        '
        Me.CheckBoxDeleteDetachedVolumes.AutoSize = True
        Me.CheckBoxDeleteDetachedVolumes.Location = New System.Drawing.Point(15, 70)
        Me.CheckBoxDeleteDetachedVolumes.Name = "CheckBoxDeleteDetachedVolumes"
        Me.CheckBoxDeleteDetachedVolumes.Size = New System.Drawing.Size(194, 20)
        Me.CheckBoxDeleteDetachedVolumes.TabIndex = 12
        Me.CheckBoxDeleteDetachedVolumes.Text = "Delete Detached Volumes"
        Me.CheckBoxDeleteDetachedVolumes.UseVisualStyleBackColor = True
        '
        'LabelCurrentOperation
        '
        Me.LabelCurrentOperation.AutoSize = True
        Me.LabelCurrentOperation.Location = New System.Drawing.Point(8, 134)
        Me.LabelCurrentOperation.Name = "LabelCurrentOperation"
        Me.LabelCurrentOperation.Size = New System.Drawing.Size(150, 16)
        Me.LabelCurrentOperation.TabIndex = 22
        Me.LabelCurrentOperation.Text = "< current operation >"
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(7, 157)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(550, 25)
        Me.ProgressBar.TabIndex = 21
        '
        'DetachAndDeleteVolumeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 193)
        Me.Controls.Add(Me.LabelCurrentOperation)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.CheckBoxDeleteDetachedVolumes)
        Me.Controls.Add(Me.CheckBoxForceDetach)
        Me.Controls.Add(Me.ButtonDetachAndDelete)
        Me.Controls.Add(Me.TextBoxVolumeIds)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "DetachAndDeleteVolumeForm"
        Me.Text = "Detach and Delete Volumes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxVolumeIds As TextBox
    Friend WithEvents ButtonDetachAndDelete As Button
    Friend WithEvents CheckBoxForceDetach As CheckBox
    Friend WithEvents CheckBoxDeleteDetachedVolumes As CheckBox
    Friend WithEvents LabelCurrentOperation As Label
    Friend WithEvents ProgressBar As ProgressBar
End Class
