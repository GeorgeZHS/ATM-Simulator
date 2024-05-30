<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ammountBox = New System.Windows.Forms.TextBox()
        Me.checkMoney = New System.Windows.Forms.Button()
        Me.withdrawButton = New System.Windows.Forms.Button()
        Me.Deposit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current User:"
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Location = New System.Drawing.Point(76, 53)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(30, 16)
        Me.UserLabel.TabIndex = 1
        Me.UserLabel.Text = "N/A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ammount"
        '
        'ammountBox
        '
        Me.ammountBox.Location = New System.Drawing.Point(333, 125)
        Me.ammountBox.Name = "ammountBox"
        Me.ammountBox.Size = New System.Drawing.Size(115, 22)
        Me.ammountBox.TabIndex = 3
        '
        'checkMoney
        '
        Me.checkMoney.Location = New System.Drawing.Point(167, 180)
        Me.checkMoney.Name = "checkMoney"
        Me.checkMoney.Size = New System.Drawing.Size(115, 23)
        Me.checkMoney.TabIndex = 4
        Me.checkMoney.Text = "Check Money"
        Me.checkMoney.UseVisualStyleBackColor = True
        '
        'withdrawButton
        '
        Me.withdrawButton.Location = New System.Drawing.Point(333, 180)
        Me.withdrawButton.Name = "withdrawButton"
        Me.withdrawButton.Size = New System.Drawing.Size(115, 23)
        Me.withdrawButton.TabIndex = 5
        Me.withdrawButton.Text = "Withdraw"
        Me.withdrawButton.UseVisualStyleBackColor = True
        '
        'Deposit
        '
        Me.Deposit.Location = New System.Drawing.Point(493, 180)
        Me.Deposit.Name = "Deposit"
        Me.Deposit.Size = New System.Drawing.Size(115, 23)
        Me.Deposit.TabIndex = 6
        Me.Deposit.Text = "Deposit"
        Me.Deposit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 326)
        Me.Controls.Add(Me.Deposit)
        Me.Controls.Add(Me.withdrawButton)
        Me.Controls.Add(Me.checkMoney)
        Me.Controls.Add(Me.ammountBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "The bank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UserLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ammountBox As TextBox
    Friend WithEvents checkMoney As Button
    Friend WithEvents withdrawButton As Button
    Friend WithEvents Deposit As Button
End Class
