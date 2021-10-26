<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AwsAccountsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AwsAccountsForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListViewAccounts = New System.Windows.Forms.ListView()
        Me.AccountDescription = New System.Windows.Forms.ColumnHeader()
        Me.AccountAccessKey = New System.Windows.Forms.ColumnHeader()
        Me.AccountRegion = New System.Windows.Forms.ColumnHeader()
        Me.AccountKeyPairs = New System.Windows.Forms.ColumnHeader()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonBackgroundColor = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonSaveAccount = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonDeleteKeyPair = New System.Windows.Forms.Button()
        Me.ButtonAddKeyPair = New System.Windows.Forms.Button()
        Me.ListBoxKeyPairs = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxAccountSecretKey = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxAccountAccessKey = New System.Windows.Forms.TextBox()
        Me.ComboBoxAccountRegion = New System.Windows.Forms.ComboBox()
        Me.TextBoxAccountDescription = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonDeleteAccount = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialogKeyPair = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialogBackgroundColor = New System.Windows.Forms.ColorDialog()
        Me.CheckedListBoxEnabledRegions = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListViewAccounts, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 482)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ListViewAccounts
        '
        Me.ListViewAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.AccountDescription, Me.AccountAccessKey, Me.AccountRegion, Me.AccountKeyPairs})
        Me.ListViewAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewAccounts.FullRowSelect = True
        Me.ListViewAccounts.GridLines = True
        Me.ListViewAccounts.HideSelection = False
        Me.ListViewAccounts.Location = New System.Drawing.Point(3, 3)
        Me.ListViewAccounts.Name = "ListViewAccounts"
        Me.ListViewAccounts.Size = New System.Drawing.Size(598, 476)
        Me.ListViewAccounts.TabIndex = 0
        Me.ListViewAccounts.UseCompatibleStateImageBehavior = False
        Me.ListViewAccounts.View = System.Windows.Forms.View.Details
        '
        'AccountDescription
        '
        Me.AccountDescription.Text = "Description"
        Me.AccountDescription.Width = 200
        '
        'AccountAccessKey
        '
        Me.AccountAccessKey.Text = "AccessKey"
        Me.AccountAccessKey.Width = 200
        '
        'AccountRegion
        '
        Me.AccountRegion.Text = "Region"
        Me.AccountRegion.Width = 100
        '
        'AccountKeyPairs
        '
        Me.AccountKeyPairs.Text = "Key Pairs"
        Me.AccountKeyPairs.Width = 100
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CheckedListBoxEnabledRegions)
        Me.Panel1.Controls.Add(Me.ButtonBackgroundColor)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ButtonSaveAccount)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBoxAccountSecretKey)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBoxAccountAccessKey)
        Me.Panel1.Controls.Add(Me.ComboBoxAccountRegion)
        Me.Panel1.Controls.Add(Me.TextBoxAccountDescription)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(607, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(398, 476)
        Me.Panel1.TabIndex = 1
        '
        'ButtonBackgroundColor
        '
        Me.ButtonBackgroundColor.Location = New System.Drawing.Point(109, 242)
        Me.ButtonBackgroundColor.Name = "ButtonBackgroundColor"
        Me.ButtonBackgroundColor.Size = New System.Drawing.Size(116, 23)
        Me.ButtonBackgroundColor.TabIndex = 11
        Me.ButtonBackgroundColor.Text = "Pick Color"
        Me.ButtonBackgroundColor.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Background Color"
        '
        'ButtonSaveAccount
        '
        Me.ButtonSaveAccount.Location = New System.Drawing.Point(5, 424)
        Me.ButtonSaveAccount.Name = "ButtonSaveAccount"
        Me.ButtonSaveAccount.Size = New System.Drawing.Size(182, 47)
        Me.ButtonSaveAccount.TabIndex = 3
        Me.ButtonSaveAccount.Text = "Save Account Changes"
        Me.ButtonSaveAccount.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonDeleteKeyPair)
        Me.GroupBox1.Controls.Add(Me.ButtonAddKeyPair)
        Me.GroupBox1.Controls.Add(Me.ListBoxKeyPairs)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 142)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Key Pairs"
        '
        'ButtonDeleteKeyPair
        '
        Me.ButtonDeleteKeyPair.Location = New System.Drawing.Point(88, 107)
        Me.ButtonDeleteKeyPair.Name = "ButtonDeleteKeyPair"
        Me.ButtonDeleteKeyPair.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDeleteKeyPair.TabIndex = 2
        Me.ButtonDeleteKeyPair.Text = "Delete"
        Me.ButtonDeleteKeyPair.UseVisualStyleBackColor = True
        '
        'ButtonAddKeyPair
        '
        Me.ButtonAddKeyPair.Location = New System.Drawing.Point(7, 107)
        Me.ButtonAddKeyPair.Name = "ButtonAddKeyPair"
        Me.ButtonAddKeyPair.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddKeyPair.TabIndex = 1
        Me.ButtonAddKeyPair.Text = "Add"
        Me.ButtonAddKeyPair.UseVisualStyleBackColor = True
        '
        'ListBoxKeyPairs
        '
        Me.ListBoxKeyPairs.FormattingEnabled = True
        Me.ListBoxKeyPairs.ItemHeight = 15
        Me.ListBoxKeyPairs.Location = New System.Drawing.Point(7, 22)
        Me.ListBoxKeyPairs.Name = "ListBoxKeyPairs"
        Me.ListBoxKeyPairs.Size = New System.Drawing.Size(379, 79)
        Me.ListBoxKeyPairs.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Default Region"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Secret Key"
        '
        'TextBoxAccountSecretKey
        '
        Me.TextBoxAccountSecretKey.Location = New System.Drawing.Point(109, 66)
        Me.TextBoxAccountSecretKey.Name = "TextBoxAccountSecretKey"
        Me.TextBoxAccountSecretKey.Size = New System.Drawing.Size(286, 23)
        Me.TextBoxAccountSecretKey.TabIndex = 6
        Me.TextBoxAccountSecretKey.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Access Key"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Description"
        '
        'TextBoxAccountAccessKey
        '
        Me.TextBoxAccountAccessKey.Location = New System.Drawing.Point(109, 37)
        Me.TextBoxAccountAccessKey.Name = "TextBoxAccountAccessKey"
        Me.TextBoxAccountAccessKey.Size = New System.Drawing.Size(286, 23)
        Me.TextBoxAccountAccessKey.TabIndex = 2
        '
        'ComboBoxAccountRegion
        '
        Me.ComboBoxAccountRegion.FormattingEnabled = True
        Me.ComboBoxAccountRegion.Items.AddRange(New Object() {"us-east-1", "us-east-2", "us-west-1", "us-west-2", "af-south-1", "ap-east-1", "ap-south-1", "ap-northeast-3", "ap-northeast-2", "ap-southeast-1", "ap-southeast-2", "ap-northeast-1", "ca-central-1", "eu-central-1", "eu-west-1", "eu-west-2", "eu-south-1", "eu-west-3", "eu-north-1", "me-south-1", "sa-east-1", "us-gov-east-1", "us-gov-west-1"})
        Me.ComboBoxAccountRegion.Location = New System.Drawing.Point(109, 95)
        Me.ComboBoxAccountRegion.Name = "ComboBoxAccountRegion"
        Me.ComboBoxAccountRegion.Size = New System.Drawing.Size(286, 23)
        Me.ComboBoxAccountRegion.TabIndex = 1
        '
        'TextBoxAccountDescription
        '
        Me.TextBoxAccountDescription.Location = New System.Drawing.Point(109, 7)
        Me.TextBoxAccountDescription.Name = "TextBoxAccountDescription"
        Me.TextBoxAccountDescription.Size = New System.Drawing.Size(286, 23)
        Me.TextBoxAccountDescription.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButtonDeleteAccount})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1032, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripButton1.Text = "Add New Account"
        '
        'ToolStripButtonDeleteAccount
        '
        Me.ToolStripButtonDeleteAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonDeleteAccount.Image = CType(resources.GetObject("ToolStripButtonDeleteAccount.Image"), System.Drawing.Image)
        Me.ToolStripButtonDeleteAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDeleteAccount.Name = "ToolStripButtonDeleteAccount"
        Me.ToolStripButtonDeleteAccount.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripButtonDeleteAccount.Text = "Delete"
        '
        'OpenFileDialogKeyPair
        '
        Me.OpenFileDialogKeyPair.FileName = "OpenFileDialog1"
        '
        'CheckedListBoxEnabledRegions
        '
        Me.CheckedListBoxEnabledRegions.FormattingEnabled = True
        Me.CheckedListBoxEnabledRegions.Location = New System.Drawing.Point(109, 124)
        Me.CheckedListBoxEnabledRegions.Name = "CheckedListBoxEnabledRegions"
        Me.CheckedListBoxEnabledRegions.Size = New System.Drawing.Size(286, 112)
        Me.CheckedListBoxEnabledRegions.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Enabled Regions"
        '
        'AwsAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 522)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AwsAccountsForm"
        Me.Text = "AwsAccountsForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ListViewAccounts As ListView
    Friend WithEvents AccountDescription As ColumnHeader
    Friend WithEvents AccountAccessKey As ColumnHeader
    Friend WithEvents AccountRegion As ColumnHeader
    Friend WithEvents AccountKeyPairs As ColumnHeader
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButtonDeleteAccount As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxAccountSecretKey As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxAccountAccessKey As TextBox
    Friend WithEvents ComboBoxAccountRegion As ComboBox
    Friend WithEvents TextBoxAccountDescription As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonDeleteKeyPair As Button
    Friend WithEvents ButtonAddKeyPair As Button
    Friend WithEvents ListBoxKeyPairs As ListBox
    Friend WithEvents ButtonSaveAccount As Button
    Friend WithEvents OpenFileDialogKeyPair As OpenFileDialog
    Friend WithEvents ButtonBackgroundColor As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ColorDialogBackgroundColor As ColorDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckedListBoxEnabledRegions As CheckedListBox
End Class
