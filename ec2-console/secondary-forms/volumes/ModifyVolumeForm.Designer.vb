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
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Volume ID"
        '
        'TextBoxVolumeId
        '
        Me.TextBoxVolumeId.Location = New System.Drawing.Point(146, 11)
        Me.TextBoxVolumeId.Name = "TextBoxVolumeId"
        Me.TextBoxVolumeId.ReadOnly = True
        Me.TextBoxVolumeId.Size = New System.Drawing.Size(238, 23)
        Me.TextBoxVolumeId.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Volume Type"
        '
        'ComboBoxVolumeType
        '
        Me.ComboBoxVolumeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVolumeType.FormattingEnabled = True
        Me.ComboBoxVolumeType.Items.AddRange(New Object() {"gp2", "gp3", "io1", "io2", "sc1", "st1", "standard"})
        Me.ComboBoxVolumeType.Location = New System.Drawing.Point(146, 42)
        Me.ComboBoxVolumeType.Name = "ComboBoxVolumeType"
        Me.ComboBoxVolumeType.Size = New System.Drawing.Size(238, 24)
        Me.ComboBoxVolumeType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Size"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "IOPS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Throughput (MB/s)"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(146, 165)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(238, 35)
        Me.ButtonSave.TabIndex = 10
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'NumericUpDownVolumeSize
        '
        Me.NumericUpDownVolumeSize.Location = New System.Drawing.Point(146, 74)
        Me.NumericUpDownVolumeSize.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
        Me.NumericUpDownVolumeSize.Name = "NumericUpDownVolumeSize"
        Me.NumericUpDownVolumeSize.Size = New System.Drawing.Size(137, 23)
        Me.NumericUpDownVolumeSize.TabIndex = 11
        Me.NumericUpDownVolumeSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownVolumeSize.ThousandsSeparator = True
        '
        'NumericUpDownVolumeIops
        '
        Me.NumericUpDownVolumeIops.Location = New System.Drawing.Point(146, 105)
        Me.NumericUpDownVolumeIops.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
        Me.NumericUpDownVolumeIops.Name = "NumericUpDownVolumeIops"
        Me.NumericUpDownVolumeIops.Size = New System.Drawing.Size(137, 23)
        Me.NumericUpDownVolumeIops.TabIndex = 12
        Me.NumericUpDownVolumeIops.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownVolumeIops.ThousandsSeparator = True
        '
        'NumericUpDownVolumeThroughput
        '
        Me.NumericUpDownVolumeThroughput.Location = New System.Drawing.Point(146, 135)
        Me.NumericUpDownVolumeThroughput.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
        Me.NumericUpDownVolumeThroughput.Name = "NumericUpDownVolumeThroughput"
        Me.NumericUpDownVolumeThroughput.Size = New System.Drawing.Size(137, 23)
        Me.NumericUpDownVolumeThroughput.TabIndex = 13
        Me.NumericUpDownVolumeThroughput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownVolumeThroughput.ThousandsSeparator = True
        '
        'ModifyVolumeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 206)
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
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
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
