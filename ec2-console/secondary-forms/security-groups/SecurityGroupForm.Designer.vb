<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SecurityGroupForm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxSGVPCId = New System.Windows.Forms.TextBox()
        Me.TextBoxSGDescription = New System.Windows.Forms.TextBox()
        Me.TextBoxSGId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxSGName = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageInbound = New System.Windows.Forms.TabPage()
        Me.ListViewInbound = New System.Windows.Forms.ListView()
        Me.ColumnHeaderSGRuleId = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderRuleName = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderIPVersion = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderRuleType = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderRuleProtocol = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderPortRange = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderSource = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderRuleDescription = New System.Windows.Forms.ColumnHeader()
        Me.TabPageOutbound = New System.Windows.Forms.TabPage()
        Me.ListViewOutbound = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader()
        Me.TabPageTags = New System.Windows.Forms.TabPage()
        Me.ListViewTags = New System.Windows.Forms.ListView()
        Me.ColumnHeaderTagKey = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeaderTageValue = New System.Windows.Forms.ColumnHeader()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageInbound.SuspendLayout()
        Me.TabPageOutbound.SuspendLayout()
        Me.TabPageTags.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(758, 460)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(194, 35)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(5, 3)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(87, 29)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.Location = New System.Drawing.Point(102, 3)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(87, 29)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxSGVPCId, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxSGDescription, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxSGId, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBoxSGName, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(944, 124)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TextBoxSGVPCId
        '
        Me.TextBoxSGVPCId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSGVPCId.Location = New System.Drawing.Point(155, 90)
        Me.TextBoxSGVPCId.Name = "TextBoxSGVPCId"
        Me.TextBoxSGVPCId.ReadOnly = True
        Me.TextBoxSGVPCId.Size = New System.Drawing.Size(786, 23)
        Me.TextBoxSGVPCId.TabIndex = 7
        '
        'TextBoxSGDescription
        '
        Me.TextBoxSGDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSGDescription.Location = New System.Drawing.Point(155, 61)
        Me.TextBoxSGDescription.Name = "TextBoxSGDescription"
        Me.TextBoxSGDescription.Size = New System.Drawing.Size(786, 23)
        Me.TextBoxSGDescription.TabIndex = 6
        '
        'TextBoxSGId
        '
        Me.TextBoxSGId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSGId.Location = New System.Drawing.Point(155, 32)
        Me.TextBoxSGId.Name = "TextBoxSGId"
        Me.TextBoxSGId.ReadOnly = True
        Me.TextBoxSGId.Size = New System.Drawing.Size(786, 23)
        Me.TextBoxSGId.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Security Group Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Security Group ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Description"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "VPC ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxSGName
        '
        Me.TextBoxSGName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSGName.Location = New System.Drawing.Point(155, 3)
        Me.TextBoxSGName.Name = "TextBoxSGName"
        Me.TextBoxSGName.ReadOnly = True
        Me.TextBoxSGName.Size = New System.Drawing.Size(786, 23)
        Me.TextBoxSGName.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPageInbound)
        Me.TabControl1.Controls.Add(Me.TabPageOutbound)
        Me.TabControl1.Controls.Add(Me.TabPageTags)
        Me.TabControl1.Location = New System.Drawing.Point(15, 142)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(941, 314)
        Me.TabControl1.TabIndex = 2
        '
        'TabPageInbound
        '
        Me.TabPageInbound.Controls.Add(Me.ListViewInbound)
        Me.TabPageInbound.Location = New System.Drawing.Point(4, 25)
        Me.TabPageInbound.Name = "TabPageInbound"
        Me.TabPageInbound.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInbound.Size = New System.Drawing.Size(933, 285)
        Me.TabPageInbound.TabIndex = 0
        Me.TabPageInbound.Text = "Inbound Rules"
        Me.TabPageInbound.UseVisualStyleBackColor = True
        '
        'ListViewInbound
        '
        Me.ListViewInbound.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderSGRuleId, Me.ColumnHeaderRuleName, Me.ColumnHeaderIPVersion, Me.ColumnHeaderRuleType, Me.ColumnHeaderRuleProtocol, Me.ColumnHeaderPortRange, Me.ColumnHeaderSource, Me.ColumnHeaderRuleDescription})
        Me.ListViewInbound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewInbound.HideSelection = False
        Me.ListViewInbound.Location = New System.Drawing.Point(3, 3)
        Me.ListViewInbound.Name = "ListViewInbound"
        Me.ListViewInbound.Size = New System.Drawing.Size(927, 279)
        Me.ListViewInbound.TabIndex = 0
        Me.ListViewInbound.UseCompatibleStateImageBehavior = False
        Me.ListViewInbound.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderSGRuleId
        '
        Me.ColumnHeaderSGRuleId.Text = "Rule ID"
        '
        'ColumnHeaderRuleName
        '
        Me.ColumnHeaderRuleName.Text = "Rule Name"
        Me.ColumnHeaderRuleName.Width = 120
        '
        'ColumnHeaderIPVersion
        '
        Me.ColumnHeaderIPVersion.Text = "IP version"
        Me.ColumnHeaderIPVersion.Width = 80
        '
        'ColumnHeaderRuleType
        '
        Me.ColumnHeaderRuleType.Text = "Type"
        '
        'ColumnHeaderRuleProtocol
        '
        Me.ColumnHeaderRuleProtocol.Text = "Protocol"
        Me.ColumnHeaderRuleProtocol.Width = 80
        '
        'ColumnHeaderPortRange
        '
        Me.ColumnHeaderPortRange.Text = "Port Range"
        Me.ColumnHeaderPortRange.Width = 150
        '
        'ColumnHeaderSource
        '
        Me.ColumnHeaderSource.Text = "Source"
        Me.ColumnHeaderSource.Width = 120
        '
        'ColumnHeaderRuleDescription
        '
        Me.ColumnHeaderRuleDescription.Text = "Description"
        Me.ColumnHeaderRuleDescription.Width = 250
        '
        'TabPageOutbound
        '
        Me.TabPageOutbound.Controls.Add(Me.ListViewOutbound)
        Me.TabPageOutbound.Location = New System.Drawing.Point(4, 25)
        Me.TabPageOutbound.Name = "TabPageOutbound"
        Me.TabPageOutbound.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageOutbound.Size = New System.Drawing.Size(933, 285)
        Me.TabPageOutbound.TabIndex = 1
        Me.TabPageOutbound.Text = "Outbound Rules"
        Me.TabPageOutbound.UseVisualStyleBackColor = True
        '
        'ListViewOutbound
        '
        Me.ListViewOutbound.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListViewOutbound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewOutbound.HideSelection = False
        Me.ListViewOutbound.Location = New System.Drawing.Point(3, 3)
        Me.ListViewOutbound.Name = "ListViewOutbound"
        Me.ListViewOutbound.Size = New System.Drawing.Size(927, 279)
        Me.ListViewOutbound.TabIndex = 1
        Me.ListViewOutbound.UseCompatibleStateImageBehavior = False
        Me.ListViewOutbound.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Rule Name"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Rule ID"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "IP version"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Type"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Protocol"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Port Range"
        Me.ColumnHeader6.Width = 200
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Source"
        Me.ColumnHeader7.Width = 120
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Description"
        Me.ColumnHeader8.Width = 120
        '
        'TabPageTags
        '
        Me.TabPageTags.Controls.Add(Me.ListViewTags)
        Me.TabPageTags.Location = New System.Drawing.Point(4, 25)
        Me.TabPageTags.Name = "TabPageTags"
        Me.TabPageTags.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTags.Size = New System.Drawing.Size(933, 285)
        Me.TabPageTags.TabIndex = 2
        Me.TabPageTags.Text = "Tags"
        Me.TabPageTags.UseVisualStyleBackColor = True
        '
        'ListViewTags
        '
        Me.ListViewTags.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderTagKey, Me.ColumnHeaderTageValue})
        Me.ListViewTags.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewTags.HideSelection = False
        Me.ListViewTags.Location = New System.Drawing.Point(3, 3)
        Me.ListViewTags.Name = "ListViewTags"
        Me.ListViewTags.Size = New System.Drawing.Size(927, 279)
        Me.ListViewTags.TabIndex = 0
        Me.ListViewTags.UseCompatibleStateImageBehavior = False
        Me.ListViewTags.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderTagKey
        '
        Me.ColumnHeaderTagKey.Text = "Key"
        Me.ColumnHeaderTagKey.Width = 240
        '
        'ColumnHeaderTageValue
        '
        Me.ColumnHeaderTageValue.Text = "Value"
        Me.ColumnHeaderTageValue.Width = 400
        '
        'SecurityGroupForm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(960, 501)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SecurityGroupForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SecurityGroupForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageInbound.ResumeLayout(False)
        Me.TabPageOutbound.ResumeLayout(False)
        Me.TabPageTags.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBoxSGVPCId As TextBox
    Friend WithEvents TextBoxSGDescription As TextBox
    Friend WithEvents TextBoxSGId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxSGName As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageInbound As TabPage
    Friend WithEvents TabPageOutbound As TabPage
    Friend WithEvents TabPageTags As TabPage
    Friend WithEvents ListViewInbound As ListView
    Friend WithEvents ColumnHeaderRuleName As ColumnHeader
    Friend WithEvents ColumnHeaderSGRuleId As ColumnHeader
    Friend WithEvents ColumnHeaderIPVersion As ColumnHeader
    Friend WithEvents ColumnHeaderRuleType As ColumnHeader
    Friend WithEvents ColumnHeaderRuleProtocol As ColumnHeader
    Friend WithEvents ColumnHeaderPortRange As ColumnHeader
    Friend WithEvents ColumnHeaderSource As ColumnHeader
    Friend WithEvents ColumnHeaderRuleDescription As ColumnHeader
    Friend WithEvents ListViewTags As ListView
    Friend WithEvents ColumnHeaderTagKey As ColumnHeader
    Friend WithEvents ColumnHeaderTageValue As ColumnHeader
    Friend WithEvents ListViewOutbound As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
