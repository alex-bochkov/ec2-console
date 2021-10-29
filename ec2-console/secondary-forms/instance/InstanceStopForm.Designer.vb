<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstanceStopForm
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
        Me.ListViewInstancesToStop = New System.Windows.Forms.ListView()
        Me.ColumnHeaderInstance = New System.Windows.Forms.ColumnHeader()
        Me.CheckBoxUseForceStop = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(322, 234)
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
        'ListViewInstancesToStop
        '
        Me.ListViewInstancesToStop.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderInstance})
        Me.ListViewInstancesToStop.HideSelection = False
        Me.ListViewInstancesToStop.Location = New System.Drawing.Point(6, 28)
        Me.ListViewInstancesToStop.Name = "ListViewInstancesToStop"
        Me.ListViewInstancesToStop.Size = New System.Drawing.Size(483, 169)
        Me.ListViewInstancesToStop.TabIndex = 13
        Me.ListViewInstancesToStop.UseCompatibleStateImageBehavior = False
        Me.ListViewInstancesToStop.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderInstance
        '
        Me.ColumnHeaderInstance.Text = "Instance Description"
        Me.ColumnHeaderInstance.Width = 400
        '
        'CheckBoxUseForceStop
        '
        Me.CheckBoxUseForceStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxUseForceStop.AutoSize = True
        Me.CheckBoxUseForceStop.Location = New System.Drawing.Point(6, 204)
        Me.CheckBoxUseForceStop.Name = "CheckBoxUseForceStop"
        Me.CheckBoxUseForceStop.Size = New System.Drawing.Size(104, 19)
        Me.CheckBoxUseForceStop.TabIndex = 12
        Me.CheckBoxUseForceStop.Text = "Use Force Stop"
        Me.CheckBoxUseForceStop.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(483, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Do you want to stop these instances?"
        '
        'InstanceStopForm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(493, 269)
        Me.Controls.Add(Me.ListViewInstancesToStop)
        Me.Controls.Add(Me.CheckBoxUseForceStop)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InstanceStopForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "InstanceStopForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ListViewInstancesToStop As ListView
    Friend WithEvents ColumnHeaderInstance As ColumnHeader
    Friend WithEvents CheckBoxUseForceStop As CheckBox
    Friend WithEvents Label1 As Label
End Class
