<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TerminateInstanceForm
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
        Me.LabelCurrentOperation = New System.Windows.Forms.Label()
        Me.ButtonTerminateInstances = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TreeViewInstances = New System.Windows.Forms.TreeView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxDisableTerminationProtection = New System.Windows.Forms.CheckBox()
        Me.ButtonCancelClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelCurrentOperation
        '
        Me.LabelCurrentOperation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelCurrentOperation.AutoSize = True
        Me.LabelCurrentOperation.Location = New System.Drawing.Point(13, 371)
        Me.LabelCurrentOperation.Name = "LabelCurrentOperation"
        Me.LabelCurrentOperation.Size = New System.Drawing.Size(121, 15)
        Me.LabelCurrentOperation.TabIndex = 23
        Me.LabelCurrentOperation.Text = "< current operation >"
        '
        'ButtonTerminateInstances
        '
        Me.ButtonTerminateInstances.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonTerminateInstances.Location = New System.Drawing.Point(9, 323)
        Me.ButtonTerminateInstances.Name = "ButtonTerminateInstances"
        Me.ButtonTerminateInstances.Size = New System.Drawing.Size(226, 45)
        Me.ButtonTerminateInstances.TabIndex = 22
        Me.ButtonTerminateInstances.Text = "Terminate Instances"
        Me.ButtonTerminateInstances.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(12, 392)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(533, 23)
        Me.ProgressBar.TabIndex = 21
        '
        'TreeViewInstances
        '
        Me.TreeViewInstances.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeViewInstances.Location = New System.Drawing.Point(6, 17)
        Me.TreeViewInstances.Name = "TreeViewInstances"
        Me.TreeViewInstances.Size = New System.Drawing.Size(524, 257)
        Me.TreeViewInstances.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CheckBoxDisableTerminationProtection)
        Me.GroupBox1.Controls.Add(Me.TreeViewInstances)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 313)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Instances to terminate"
        '
        'CheckBoxDisableTerminationProtection
        '
        Me.CheckBoxDisableTerminationProtection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxDisableTerminationProtection.AutoSize = True
        Me.CheckBoxDisableTerminationProtection.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxDisableTerminationProtection.Location = New System.Drawing.Point(6, 283)
        Me.CheckBoxDisableTerminationProtection.Name = "CheckBoxDisableTerminationProtection"
        Me.CheckBoxDisableTerminationProtection.Size = New System.Drawing.Size(188, 19)
        Me.CheckBoxDisableTerminationProtection.TabIndex = 25
        Me.CheckBoxDisableTerminationProtection.Text = "Disable Termination Protection"
        Me.CheckBoxDisableTerminationProtection.UseVisualStyleBackColor = True
        '
        'ButtonCancelClose
        '
        Me.ButtonCancelClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancelClose.Location = New System.Drawing.Point(319, 323)
        Me.ButtonCancelClose.Name = "ButtonCancelClose"
        Me.ButtonCancelClose.Size = New System.Drawing.Size(226, 45)
        Me.ButtonCancelClose.TabIndex = 26
        Me.ButtonCancelClose.Text = "Cancel and Close"
        Me.ButtonCancelClose.UseVisualStyleBackColor = True
        '
        'TerminateInstanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 424)
        Me.Controls.Add(Me.ButtonCancelClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelCurrentOperation)
        Me.Controls.Add(Me.ButtonTerminateInstances)
        Me.Controls.Add(Me.ProgressBar)
        Me.Name = "TerminateInstanceForm"
        Me.Text = "TerminateInstanceForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCurrentOperation As Label
    Friend WithEvents ButtonTerminateInstances As Button
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents TreeViewInstances As TreeView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxDisableTerminationProtection As CheckBox
    Friend WithEvents ButtonCancelClose As Button
End Class
