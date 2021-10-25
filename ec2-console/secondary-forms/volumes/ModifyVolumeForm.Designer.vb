<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyVolumeForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxVolumeId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxVolumeType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.NumericUpDownVolumeSize = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownVolumeIops = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownVolumeThroughput = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDownVolumeSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownVolumeIops, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownVolumeThroughput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Volume ID"
        '
        'TextBoxVolumeId
        '
        Me.TextBoxVolumeId.Location = New System.Drawing.Point(128, 10)
        Me.TextBoxVolumeId.Name = "TextBoxVolumeId"
        Me.TextBoxVolumeId.ReadOnly = True
        Me.TextBoxVolumeId.Size = New System.Drawing.Size(209, 23)
        Me.TextBoxVolumeId.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Volume Type"
        '
        'ComboBoxVolumeType
        '
        Me.ComboBoxVolumeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVolumeType.FormattingEnabled = True
        Me.ComboBoxVolumeType.Items.AddRange(New Object() {"gp2", "gp3", "io1", "io2", "sc1", "st1", "standard"})
        Me.ComboBoxVolumeType.Location = New System.Drawing.Point(128, 39)
        Me.ComboBoxVolumeType.Name = "ComboBoxVolumeType"
        Me.ComboBoxVolumeType.Size = New System.Drawing.Size(209, 23)
        Me.ComboBoxVolumeType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Size"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "IOPS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Throughput (MB/s)"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(128, 155)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(208, 33)
        Me.ButtonSave.TabIndex = 10
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'NumericUpDownVolumeSize
        '
        Me.NumericUpDownVolumeSize.Location = New System.Drawing.Point(128, 69)
        Me.NumericUpDownVolumeSize.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
        Me.NumericUpDownVolumeSize.Name = "NumericUpDownVolumeSize"
        Me.NumericUpDownVolumeSize.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDownVolumeSize.TabIndex = 11
        Me.NumericUpDownVolumeSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownVolumeSize.ThousandsSeparator = True
        '
        'NumericUpDownVolumeIops
        '
        Me.NumericUpDownVolumeIops.Location = New System.Drawing.Point(128, 98)
        Me.NumericUpDownVolumeIops.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
        Me.NumericUpDownVolumeIops.Name = "NumericUpDownVolumeIops"
        Me.NumericUpDownVolumeIops.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDownVolumeIops.TabIndex = 12
        Me.NumericUpDownVolumeIops.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownVolumeIops.ThousandsSeparator = True
        '
        'NumericUpDownVolumeThroughput
        '
        Me.NumericUpDownVolumeThroughput.Location = New System.Drawing.Point(128, 127)
        Me.NumericUpDownVolumeThroughput.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
        Me.NumericUpDownVolumeThroughput.Name = "NumericUpDownVolumeThroughput"
        Me.NumericUpDownVolumeThroughput.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDownVolumeThroughput.TabIndex = 13
        Me.NumericUpDownVolumeThroughput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownVolumeThroughput.ThousandsSeparator = True
        '
        'ModifyVolumeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 193)
        Me.Controls.Add(Me.NumericUpDownVolumeThroughput)
        Me.Controls.Add(Me.NumericUpDownVolumeIops)
        Me.Controls.Add(Me.NumericUpDownVolumeSize)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxVolumeType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxVolumeId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModifyVolumeForm"
        Me.Text = "Modify Volume"
        CType(Me.NumericUpDownVolumeSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownVolumeIops, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownVolumeThroughput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxVolumeId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxVolumeType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents NumericUpDownVolumeSize As NumericUpDown
    Friend WithEvents NumericUpDownVolumeIops As NumericUpDown
    Friend WithEvents NumericUpDownVolumeThroughput As NumericUpDown
End Class
