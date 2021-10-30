<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttachNewVolumesToTheInstance
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownVolumeSize = New System.Windows.Forms.NumericUpDown()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxVolumeType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownVolumeCount = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxInstanceId = New System.Windows.Forms.TextBox()
        Me.ButtonCreateAndAttach = New System.Windows.Forms.Button()
        Me.LabelCurrentOperation = New System.Windows.Forms.Label()
        Me.CheckBoxVolumeEncrypted = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownVolumeThroughput = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownVolumeIops = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBoxDeleteOnTermitation = New System.Windows.Forms.CheckBox()
        CType(Me.NumericUpDownVolumeSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownVolumeCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownVolumeThroughput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownVolumeIops, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Volume Size"
        '
        'NumericUpDownVolumeSize
        '
        Me.NumericUpDownVolumeSize.Location = New System.Drawing.Point(160, 100)
        Me.NumericUpDownVolumeSize.Maximum = New Decimal(New Integer() {16000, 0, 0, 0})
        Me.NumericUpDownVolumeSize.Name = "NumericUpDownVolumeSize"
        Me.NumericUpDownVolumeSize.Size = New System.Drawing.Size(137, 23)
        Me.NumericUpDownVolumeSize.TabIndex = 17
        Me.NumericUpDownVolumeSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(14, 285)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(533, 25)
        Me.ProgressBar.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Volume Type"
        '
        'ComboBoxVolumeType
        '
        Me.ComboBoxVolumeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVolumeType.FormattingEnabled = True
        Me.ComboBoxVolumeType.Items.AddRange(New Object() {"gp2", "gp3", "io1", "io2"})
        Me.ComboBoxVolumeType.Location = New System.Drawing.Point(159, 69)
        Me.ComboBoxVolumeType.Name = "ComboBoxVolumeType"
        Me.ComboBoxVolumeType.Size = New System.Drawing.Size(138, 24)
        Me.ComboBoxVolumeType.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "# of volumes"
        '
        'NumericUpDownVolumeCount
        '
        Me.NumericUpDownVolumeCount.Location = New System.Drawing.Point(159, 39)
        Me.NumericUpDownVolumeCount.Name = "NumericUpDownVolumeCount"
        Me.NumericUpDownVolumeCount.Size = New System.Drawing.Size(80, 23)
        Me.NumericUpDownVolumeCount.TabIndex = 12
        Me.NumericUpDownVolumeCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Instance ID"
        '
        'TextBoxInstanceId
        '
        Me.TextBoxInstanceId.Location = New System.Drawing.Point(159, 10)
        Me.TextBoxInstanceId.Name = "TextBoxInstanceId"
        Me.TextBoxInstanceId.ReadOnly = True
        Me.TextBoxInstanceId.Size = New System.Drawing.Size(273, 23)
        Me.TextBoxInstanceId.TabIndex = 10
        '
        'ButtonCreateAndAttach
        '
        Me.ButtonCreateAndAttach.Location = New System.Drawing.Point(14, 207)
        Me.ButtonCreateAndAttach.Name = "ButtonCreateAndAttach"
        Me.ButtonCreateAndAttach.Size = New System.Drawing.Size(258, 48)
        Me.ButtonCreateAndAttach.TabIndex = 19
        Me.ButtonCreateAndAttach.Text = "Create and Attach Volumes"
        Me.ButtonCreateAndAttach.UseVisualStyleBackColor = True
        '
        'LabelCurrentOperation
        '
        Me.LabelCurrentOperation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelCurrentOperation.AutoSize = True
        Me.LabelCurrentOperation.Location = New System.Drawing.Point(15, 262)
        Me.LabelCurrentOperation.Name = "LabelCurrentOperation"
        Me.LabelCurrentOperation.Size = New System.Drawing.Size(150, 16)
        Me.LabelCurrentOperation.TabIndex = 20
        Me.LabelCurrentOperation.Text = "< current operation >"
        '
        'CheckBoxVolumeEncrypted
        '
        Me.CheckBoxVolumeEncrypted.AutoSize = True
        Me.CheckBoxVolumeEncrypted.Location = New System.Drawing.Point(305, 73)
        Me.CheckBoxVolumeEncrypted.Name = "CheckBoxVolumeEncrypted"
        Me.CheckBoxVolumeEncrypted.Size = New System.Drawing.Size(246, 20)
        Me.CheckBoxVolumeEncrypted.TabIndex = 21
        Me.CheckBoxVolumeEncrypted.Text = "encrypted (default EBS key only)"
        Me.CheckBoxVolumeEncrypted.UseVisualStyleBackColor = True
        '
        'NumericUpDownVolumeThroughput
        '
        Me.NumericUpDownVolumeThroughput.Location = New System.Drawing.Point(159, 160)
        Me.NumericUpDownVolumeThroughput.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
        Me.NumericUpDownVolumeThroughput.Name = "NumericUpDownVolumeThroughput"
        Me.NumericUpDownVolumeThroughput.Size = New System.Drawing.Size(137, 23)
        Me.NumericUpDownVolumeThroughput.TabIndex = 25
        Me.NumericUpDownVolumeThroughput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownVolumeThroughput.ThousandsSeparator = True
        '
        'NumericUpDownVolumeIops
        '
        Me.NumericUpDownVolumeIops.Location = New System.Drawing.Point(160, 129)
        Me.NumericUpDownVolumeIops.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
        Me.NumericUpDownVolumeIops.Name = "NumericUpDownVolumeIops"
        Me.NumericUpDownVolumeIops.Size = New System.Drawing.Size(137, 23)
        Me.NumericUpDownVolumeIops.TabIndex = 24
        Me.NumericUpDownVolumeIops.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDownVolumeIops.ThousandsSeparator = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Throughput (MB/s)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "IOPS"
        '
        'CheckBoxDeleteOnTermitation
        '
        Me.CheckBoxDeleteOnTermitation.AutoSize = True
        Me.CheckBoxDeleteOnTermitation.Location = New System.Drawing.Point(305, 43)
        Me.CheckBoxDeleteOnTermitation.Name = "CheckBoxDeleteOnTermitation"
        Me.CheckBoxDeleteOnTermitation.Size = New System.Drawing.Size(167, 20)
        Me.CheckBoxDeleteOnTermitation.TabIndex = 26
        Me.CheckBoxDeleteOnTermitation.Text = "delete on termination"
        Me.CheckBoxDeleteOnTermitation.UseVisualStyleBackColor = True
        '
        'AttachNewVolumesToTheInstance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 322)
        Me.Controls.Add(Me.CheckBoxDeleteOnTermitation)
        Me.Controls.Add(Me.NumericUpDownVolumeThroughput)
        Me.Controls.Add(Me.NumericUpDownVolumeIops)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBoxVolumeEncrypted)
        Me.Controls.Add(Me.LabelCurrentOperation)
        Me.Controls.Add(Me.ButtonCreateAndAttach)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDownVolumeSize)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxVolumeType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDownVolumeCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxInstanceId)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "AttachNewVolumesToTheInstance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AttachNewVolumeToTheInstance"
        CType(Me.NumericUpDownVolumeSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownVolumeCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownVolumeThroughput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownVolumeIops, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDownVolumeSize As NumericUpDown
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxVolumeType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDownVolumeCount As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxInstanceId As TextBox
    Friend WithEvents ButtonCreateAndAttach As Button
    Friend WithEvents LabelCurrentOperation As Label
    Friend WithEvents CheckBoxVolumeEncrypted As CheckBox
    Friend WithEvents NumericUpDownVolumeThroughput As NumericUpDown
    Friend WithEvents NumericUpDownVolumeIops As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBoxDeleteOnTermitation As CheckBox
End Class
