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
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxInstanceType = New System.Windows.Forms.ComboBox()
        Me.ButtonScaleUp = New System.Windows.Forms.Button()
        Me.ButtonScaleDown = New System.Windows.Forms.Button()
        Me.CheckBoxStopAndRestart = New System.Windows.Forms.CheckBox()
        Me.LabelCurrentOperation = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListViewInstancesToModify = New System.Windows.Forms.ListView()
        Me.ColumnHeaderInstance = New System.Windows.Forms.ColumnHeader()
        Me.ButtonModifyInstanceType = New System.Windows.Forms.Button()
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
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(509, 378)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(194, 35)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.Location = New System.Drawing.Point(102, 3)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(87, 29)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Instance Type"
        '
        'ComboBoxInstanceType
        '
        Me.ComboBoxInstanceType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxInstanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxInstanceType.FormattingEnabled = True
        Me.ComboBoxInstanceType.Location = New System.Drawing.Point(110, 9)
        Me.ComboBoxInstanceType.Name = "ComboBoxInstanceType"
        Me.ComboBoxInstanceType.Size = New System.Drawing.Size(527, 24)
        Me.ComboBoxInstanceType.TabIndex = 3
        '
        'ButtonScaleUp
        '
        Me.ButtonScaleUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonScaleUp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonScaleUp.Location = New System.Drawing.Point(640, 9)
        Me.ButtonScaleUp.Name = "ButtonScaleUp"
        Me.ButtonScaleUp.Size = New System.Drawing.Size(27, 25)
        Me.ButtonScaleUp.TabIndex = 5
        Me.ButtonScaleUp.Text = "↑"
        Me.ButtonScaleUp.UseVisualStyleBackColor = True
        '
        'ButtonScaleDown
        '
        Me.ButtonScaleDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonScaleDown.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonScaleDown.Location = New System.Drawing.Point(670, 9)
        Me.ButtonScaleDown.Name = "ButtonScaleDown"
        Me.ButtonScaleDown.Size = New System.Drawing.Size(27, 25)
        Me.ButtonScaleDown.TabIndex = 6
        Me.ButtonScaleDown.Text = "↓"
        Me.ButtonScaleDown.UseVisualStyleBackColor = True
        '
        'CheckBoxStopAndRestart
        '
        Me.CheckBoxStopAndRestart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxStopAndRestart.AutoSize = True
        Me.CheckBoxStopAndRestart.Location = New System.Drawing.Point(9, 210)
        Me.CheckBoxStopAndRestart.Name = "CheckBoxStopAndRestart"
        Me.CheckBoxStopAndRestart.Size = New System.Drawing.Size(644, 20)
        Me.CheckBoxStopAndRestart.TabIndex = 8
        Me.CheckBoxStopAndRestart.Text = "Force Stop and Restart running instances (otherwise, all instances must be stoppe" &
    "d already)"
        Me.CheckBoxStopAndRestart.UseVisualStyleBackColor = True
        '
        'LabelCurrentOperation
        '
        Me.LabelCurrentOperation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelCurrentOperation.AutoSize = True
        Me.LabelCurrentOperation.Location = New System.Drawing.Point(15, 327)
        Me.LabelCurrentOperation.Name = "LabelCurrentOperation"
        Me.LabelCurrentOperation.Size = New System.Drawing.Size(150, 16)
        Me.LabelCurrentOperation.TabIndex = 22
        Me.LabelCurrentOperation.Text = "< current operation >"
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(14, 350)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(689, 25)
        Me.ProgressBar.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ListViewInstancesToModify)
        Me.GroupBox1.Controls.Add(Me.ButtonModifyInstanceType)
        Me.GroupBox1.Controls.Add(Me.CheckBoxStopAndRestart)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 284)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Instances to Modify"
        '
        'ListViewInstancesToModify
        '
        Me.ListViewInstancesToModify.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderInstance})
        Me.ListViewInstancesToModify.HideSelection = False
        Me.ListViewInstancesToModify.Location = New System.Drawing.Point(9, 23)
        Me.ListViewInstancesToModify.Name = "ListViewInstancesToModify"
        Me.ListViewInstancesToModify.Size = New System.Drawing.Size(678, 180)
        Me.ListViewInstancesToModify.TabIndex = 11
        Me.ListViewInstancesToModify.UseCompatibleStateImageBehavior = False
        Me.ListViewInstancesToModify.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderInstance
        '
        Me.ColumnHeaderInstance.Text = "Instance Description"
        Me.ColumnHeaderInstance.Width = 550
        '
        'ButtonModifyInstanceType
        '
        Me.ButtonModifyInstanceType.Location = New System.Drawing.Point(9, 237)
        Me.ButtonModifyInstanceType.Name = "ButtonModifyInstanceType"
        Me.ButtonModifyInstanceType.Size = New System.Drawing.Size(223, 41)
        Me.ButtonModifyInstanceType.TabIndex = 10
        Me.ButtonModifyInstanceType.Text = "Modify Instance Type"
        Me.ButtonModifyInstanceType.UseVisualStyleBackColor = True
        '
        'ChangeInstanceType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(707, 415)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelCurrentOperation)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.ButtonScaleDown)
        Me.Controls.Add(Me.ButtonScaleUp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxInstanceType)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangeInstanceType"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Instance Type"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxInstanceType As ComboBox
    Friend WithEvents ButtonScaleUp As Button
    Friend WithEvents ButtonScaleDown As Button
    Friend WithEvents CheckBoxStopAndRestart As CheckBox
    Friend WithEvents LabelCurrentOperation As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonModifyInstanceType As Button
    Friend WithEvents ListViewInstancesToModify As ListView
    Friend WithEvents ColumnHeaderInstance As ColumnHeader
End Class
