﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeTermintationProtection
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
        Me.CheckBoxTerminationProtection = New System.Windows.Forms.CheckBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckBoxTerminationProtection
        '
        Me.CheckBoxTerminationProtection.AutoSize = True
        Me.CheckBoxTerminationProtection.Location = New System.Drawing.Point(15, 14)
        Me.CheckBoxTerminationProtection.Name = "CheckBoxTerminationProtection"
        Me.CheckBoxTerminationProtection.Size = New System.Drawing.Size(248, 20)
        Me.CheckBoxTerminationProtection.TabIndex = 0
        Me.CheckBoxTerminationProtection.Text = "Enable API termination protection"
        Me.CheckBoxTerminationProtection.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(15, 42)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(248, 32)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ChangeTermintationProtection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 81)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.CheckBoxTerminationProtection)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "ChangeTermintationProtection"
        Me.Text = "ChangeTermintationProtection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxTerminationProtection As CheckBox
    Friend WithEvents ButtonSave As Button
End Class
