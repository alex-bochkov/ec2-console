<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetConsoleScreenshot
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
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.ButtonRefreshScreenshot = New System.Windows.Forms.Button()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox
        '
        Me.PictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox.Location = New System.Drawing.Point(0, 29)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(923, 585)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'ButtonRefreshScreenshot
        '
        Me.ButtonRefreshScreenshot.Location = New System.Drawing.Point(3, 1)
        Me.ButtonRefreshScreenshot.Name = "ButtonRefreshScreenshot"
        Me.ButtonRefreshScreenshot.Size = New System.Drawing.Size(86, 25)
        Me.ButtonRefreshScreenshot.TabIndex = 1
        Me.ButtonRefreshScreenshot.Text = "Refresh"
        Me.ButtonRefreshScreenshot.UseVisualStyleBackColor = True
        '
        'GetConsoleScreenshot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 613)
        Me.Controls.Add(Me.ButtonRefreshScreenshot)
        Me.Controls.Add(Me.PictureBox)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "GetConsoleScreenshot"
        Me.Text = "Instance Console Screenshot"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents ButtonRefreshScreenshot As Button
End Class
