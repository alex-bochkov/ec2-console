<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GetWindowsPassword
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
        Me.ComboBoxKeyPairs = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDecryptedPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxInstanceKey = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonCopyToClipboard = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxKeyPairs
        '
        Me.ComboBoxKeyPairs.FormattingEnabled = True
        Me.ComboBoxKeyPairs.Location = New System.Drawing.Point(102, 35)
        Me.ComboBoxKeyPairs.Name = "ComboBoxKeyPairs"
        Me.ComboBoxKeyPairs.Size = New System.Drawing.Size(253, 23)
        Me.ComboBoxKeyPairs.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(361, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Get Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Key Pair"
        '
        'TextBoxDecryptedPassword
        '
        Me.TextBoxDecryptedPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxDecryptedPassword.Location = New System.Drawing.Point(6, 20)
        Me.TextBoxDecryptedPassword.Name = "TextBoxDecryptedPassword"
        Me.TextBoxDecryptedPassword.Size = New System.Drawing.Size(337, 29)
        Me.TextBoxDecryptedPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Instance Key"
        '
        'TextBoxInstanceKey
        '
        Me.TextBoxInstanceKey.Location = New System.Drawing.Point(102, 6)
        Me.TextBoxInstanceKey.Name = "TextBoxInstanceKey"
        Me.TextBoxInstanceKey.ReadOnly = True
        Me.TextBoxInstanceKey.Size = New System.Drawing.Size(253, 23)
        Me.TextBoxInstanceKey.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonCopyToClipboard)
        Me.GroupBox1.Controls.Add(Me.TextBoxDecryptedPassword)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 61)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Decrypted Password"
        '
        'ButtonCopyToClipboard
        '
        Me.ButtonCopyToClipboard.Location = New System.Drawing.Point(349, 22)
        Me.ButtonCopyToClipboard.Name = "ButtonCopyToClipboard"
        Me.ButtonCopyToClipboard.Size = New System.Drawing.Size(114, 26)
        Me.ButtonCopyToClipboard.TabIndex = 4
        Me.ButtonCopyToClipboard.Text = "Copy"
        Me.ButtonCopyToClipboard.UseVisualStyleBackColor = True
        '
        'GetWindowsPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 131)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxInstanceKey)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxKeyPairs)
        Me.Name = "GetWindowsPassword"
        Me.Text = "Get Windows Password for Local Administrator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxKeyPairs As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDecryptedPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxInstanceKey As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonCopyToClipboard As Button
End Class
