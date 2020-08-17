<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hub
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.bxHub = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPower = New System.Windows.Forms.Label()
        Me.lblHold = New System.Windows.Forms.Label()
        Me.lblRelease = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.SlateGray
        Me.lblName.Location = New System.Drawing.Point(38, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(224, 57)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Blockade 1.0"
        '
        'bxHub
        '
        Me.bxHub.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bxHub.Location = New System.Drawing.Point(48, 116)
        Me.bxHub.Name = "bxHub"
        Me.bxHub.PasswordChar = Global.Microsoft.VisualBasic.ChrW(111)
        Me.bxHub.Size = New System.Drawing.Size(208, 22)
        Me.bxHub.TabIndex = 3
        Me.bxHub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(58, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "What would you like me to do?"
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.Font = New System.Drawing.Font("Wingdings 3", 5.0!)
        Me.lblPower.Location = New System.Drawing.Point(46, 106)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(89, 7)
        Me.lblPower.TabIndex = 5
        Me.lblPower.Text = "i am the power"
        Me.lblPower.Visible = False
        '
        'lblHold
        '
        Me.lblHold.AutoSize = True
        Me.lblHold.Font = New System.Drawing.Font("Wingdings 3", 5.0!)
        Me.lblHold.Location = New System.Drawing.Point(46, 99)
        Me.lblHold.Name = "lblHold"
        Me.lblHold.Size = New System.Drawing.Size(78, 7)
        Me.lblHold.TabIndex = 6
        Me.lblHold.Text = "i am the hold"
        Me.lblHold.Visible = False
        '
        'lblRelease
        '
        Me.lblRelease.AutoSize = True
        Me.lblRelease.Font = New System.Drawing.Font("Wingdings 3", 5.0!)
        Me.lblRelease.Location = New System.Drawing.Point(46, 92)
        Me.lblRelease.Name = "lblRelease"
        Me.lblRelease.Size = New System.Drawing.Size(105, 7)
        Me.lblRelease.TabIndex = 7
        Me.lblRelease.Text = "i am the release"
        Me.lblRelease.Visible = False
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Font = New System.Drawing.Font("Wingdings 3", 5.0!)
        Me.lblKey.Location = New System.Drawing.Point(167, 92)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(76, 7)
        Me.lblKey.TabIndex = 5
        Me.lblKey.Text = "i am the key"
        Me.lblKey.Visible = False
        '
        'Hub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(300, 170)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblRelease)
        Me.Controls.Add(Me.lblHold)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.lblPower)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bxHub)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Hub"
        Me.Opacity = 0.93R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hub"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents bxHub As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPower As Label
    Friend WithEvents lblHold As Label
    Friend WithEvents lblRelease As Label
    Friend WithEvents lblKey As Label
End Class
