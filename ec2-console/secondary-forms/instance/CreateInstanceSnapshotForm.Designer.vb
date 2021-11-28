<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateInstanceImageForm
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
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListViewInstancesToModify = New System.Windows.Forms.ListView()
        Me.ColumnHeaderInstance = New System.Windows.Forms.ColumnHeader()
        Me.ButtonCreateInstanceImage = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(507, 291)
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ListViewInstancesToModify)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 280)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "All instances"
        '
        'ListViewInstancesToModify
        '
        Me.ListViewInstancesToModify.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderInstance})
        Me.ListViewInstancesToModify.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewInstancesToModify.HideSelection = False
        Me.ListViewInstancesToModify.Location = New System.Drawing.Point(3, 19)
        Me.ListViewInstancesToModify.Name = "ListViewInstancesToModify"
        Me.ListViewInstancesToModify.Size = New System.Drawing.Size(689, 258)
        Me.ListViewInstancesToModify.TabIndex = 11
        Me.ListViewInstancesToModify.UseCompatibleStateImageBehavior = False
        Me.ListViewInstancesToModify.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderInstance
        '
        Me.ColumnHeaderInstance.Text = "Instance Description"
        Me.ColumnHeaderInstance.Width = 550
        '
        'ButtonCreateInstanceImage
        '
        Me.ButtonCreateInstanceImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonCreateInstanceImage.Location = New System.Drawing.Point(6, 288)
        Me.ButtonCreateInstanceImage.Name = "ButtonCreateInstanceImage"
        Me.ButtonCreateInstanceImage.Size = New System.Drawing.Size(223, 41)
        Me.ButtonCreateInstanceImage.TabIndex = 10
        Me.ButtonCreateInstanceImage.Text = "Create Instance Image"
        Me.ButtonCreateInstanceImage.UseVisualStyleBackColor = True
        '
        'CreateInstanceImageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(707, 335)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonCreateInstanceImage)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateInstanceImageForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Instance Image"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonCreateInstanceImage As Button
    Friend WithEvents ListViewInstancesToModify As ListView
    Friend WithEvents ColumnHeaderInstance As ColumnHeader
End Class
