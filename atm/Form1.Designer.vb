﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.user = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CreateAccBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(119, 84)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(153, 22)
        Me.user.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(119, 150)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(153, 22)
        Me.pass.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(157, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CreateAccBtn
        '
        Me.CreateAccBtn.Location = New System.Drawing.Point(262, 215)
        Me.CreateAccBtn.Name = "CreateAccBtn"
        Me.CreateAccBtn.Size = New System.Drawing.Size(119, 23)
        Me.CreateAccBtn.TabIndex = 5
        Me.CreateAccBtn.Text = "Create Account"
        Me.CreateAccBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 250)
        Me.Controls.Add(Me.CreateAccBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Login Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents user As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CreateAccBtn As Button
End Class
