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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxInstanceType = New System.Windows.Forms.ComboBox()
        Me.ButtonScaleUp = New System.Windows.Forms.Button()
        Me.ButtonScaleDown = New System.Windows.Forms.Button()
        Me.CheckBoxStopAndRestart = New System.Windows.Forms.CheckBox()
        Me.LabelCurrentOperation = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBoxInstancesToModify = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(448, 296)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 33)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 3)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(77, 27)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.Location = New System.Drawing.Point(89, 3)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(77, 27)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Instance Type"
        '
        'ComboBoxInstanceType
        '
        Me.ComboBoxInstanceType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxInstanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxInstanceType.FormattingEnabled = True
        Me.ComboBoxInstanceType.Location = New System.Drawing.Point(96, 8)
        Me.ComboBoxInstanceType.Name = "ComboBoxInstanceType"
        Me.ComboBoxInstanceType.Size = New System.Drawing.Size(465, 23)
        Me.ComboBoxInstanceType.TabIndex = 3
        '
        'ButtonScaleUp
        '
        Me.ButtonScaleUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonScaleUp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonScaleUp.Location = New System.Drawing.Point(563, 8)
        Me.ButtonScaleUp.Name = "ButtonScaleUp"
        Me.ButtonScaleUp.Size = New System.Drawing.Size(24, 23)
        Me.ButtonScaleUp.TabIndex = 5
        Me.ButtonScaleUp.Text = "↑"
        Me.ButtonScaleUp.UseVisualStyleBackColor = True
        '
        'ButtonScaleDown
        '
        Me.ButtonScaleDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonScaleDown.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonScaleDown.Location = New System.Drawing.Point(589, 8)
        Me.ButtonScaleDown.Name = "ButtonScaleDown"
        Me.ButtonScaleDown.Size = New System.Drawing.Size(24, 23)
        Me.ButtonScaleDown.TabIndex = 6
        Me.ButtonScaleDown.Text = "↓"
        Me.ButtonScaleDown.UseVisualStyleBackColor = True
        '
        'CheckBoxStopAndRestart
        '
        Me.CheckBoxStopAndRestart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxStopAndRestart.AutoSize = True
        Me.CheckBoxStopAndRestart.Enabled = False
        Me.CheckBoxStopAndRestart.Location = New System.Drawing.Point(7, 181)
        Me.CheckBoxStopAndRestart.Name = "CheckBoxStopAndRestart"
        Me.CheckBoxStopAndRestart.Size = New System.Drawing.Size(486, 19)
        Me.CheckBoxStopAndRestart.TabIndex = 8
        Me.CheckBoxStopAndRestart.Text = "Stop and Restart running instances (otherwise, only stopped instances will be mod" &
    "ified)"
        Me.CheckBoxStopAndRestart.UseVisualStyleBackColor = True
        '
        'LabelCurrentOperation
        '
        Me.LabelCurrentOperation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelCurrentOperation.AutoSize = True
        Me.LabelCurrentOperation.Location = New System.Drawing.Point(13, 249)
        Me.LabelCurrentOperation.Name = "LabelCurrentOperation"
        Me.LabelCurrentOperation.Size = New System.Drawing.Size(121, 15)
        Me.LabelCurrentOperation.TabIndex = 22
        Me.LabelCurrentOperation.Text = "< current operation >"
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(12, 270)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(606, 23)
        Me.ProgressBar.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ListBoxInstancesToModify)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStopAndRestart)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 208)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Instances to Modify"
        '
        'ListBoxInstancesToModify
        '
        Me.ListBoxInstancesToModify.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxInstancesToModify.FormattingEnabled = True
        Me.ListBoxInstancesToModify.ItemHeight = 15
        Me.ListBoxInstancesToModify.Location = New System.Drawing.Point(8, 22)
        Me.ListBoxInstancesToModify.Name = "ListBoxInstancesToModify"
        Me.ListBoxInstancesToModify.Size = New System.Drawing.Size(596, 154)
        Me.ListBoxInstancesToModify.TabIndex = 9
        '
        'ChangeInstanceType
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(622, 331)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelCurrentOperation)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.ButtonScaleDown)
        Me.Controls.Add(Me.ButtonScaleUp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxInstanceType)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangeInstanceType"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ChangeInstanceType"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxInstanceType As ComboBox
    Friend WithEvents ButtonScaleUp As Button
    Friend WithEvents ButtonScaleDown As Button
    Friend WithEvents CheckBoxStopAndRestart As CheckBox
    Friend WithEvents LabelCurrentOperation As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBoxInstancesToModify As ListBox
End Class
