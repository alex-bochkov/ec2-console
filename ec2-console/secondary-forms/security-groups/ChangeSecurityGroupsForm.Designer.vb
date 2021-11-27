<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeSecurityGroupsForm
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
        Me.DataGridSecurityGroups = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxQuickSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonFilter = New System.Windows.Forms.Button()
        Me.ButtonSaveChanges = New System.Windows.Forms.Button()
        CType(Me.DataGridSecurityGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridSecurityGroups
        '
        Me.DataGridSecurityGroups.AllowUserToAddRows = False
        Me.DataGridSecurityGroups.AllowUserToDeleteRows = False
        Me.DataGridSecurityGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSecurityGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridSecurityGroups.Location = New System.Drawing.Point(0, 0)
        Me.DataGridSecurityGroups.Name = "DataGridSecurityGroups"
        Me.DataGridSecurityGroups.RowTemplate.Height = 25
        Me.DataGridSecurityGroups.Size = New System.Drawing.Size(1047, 369)
        Me.DataGridSecurityGroups.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.DataGridSecurityGroups)
        Me.Panel1.Location = New System.Drawing.Point(6, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1047, 369)
        Me.Panel1.TabIndex = 1
        '
        'TextBoxQuickSearch
        '
        Me.TextBoxQuickSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxQuickSearch.Location = New System.Drawing.Point(99, 4)
        Me.TextBoxQuickSearch.Name = "TextBoxQuickSearch"
        Me.TextBoxQuickSearch.Size = New System.Drawing.Size(858, 23)
        Me.TextBoxQuickSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Quick Search"
        '
        'ButtonFilter
        '
        Me.ButtonFilter.Location = New System.Drawing.Point(965, 4)
        Me.ButtonFilter.Name = "ButtonFilter"
        Me.ButtonFilter.Size = New System.Drawing.Size(86, 25)
        Me.ButtonFilter.TabIndex = 4
        Me.ButtonFilter.Text = "Filter"
        Me.ButtonFilter.UseVisualStyleBackColor = True
        '
        'ButtonSaveChanges
        '
        Me.ButtonSaveChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSaveChanges.Location = New System.Drawing.Point(6, 409)
        Me.ButtonSaveChanges.Name = "ButtonSaveChanges"
        Me.ButtonSaveChanges.Size = New System.Drawing.Size(159, 39)
        Me.ButtonSaveChanges.TabIndex = 5
        Me.ButtonSaveChanges.Text = "Save Changes"
        Me.ButtonSaveChanges.UseVisualStyleBackColor = True
        '
        'ChangeSecurityGroupsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 450)
        Me.Controls.Add(Me.ButtonSaveChanges)
        Me.Controls.Add(Me.ButtonFilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxQuickSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "ChangeSecurityGroupsForm"
        Me.Text = "ChangeSecurityGroups"
        CType(Me.DataGridSecurityGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridSecurityGroups As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxQuickSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonFilter As Button
    Friend WithEvents ButtonSaveChanges As Button
End Class
