<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Block
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
        Me.bxKey = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.lblDoor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bxKey
        '
        Me.bxKey.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.bxKey.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bxKey.ForeColor = System.Drawing.Color.DarkGray
        Me.bxKey.Location = New System.Drawing.Point(45, 137)
        Me.bxKey.Multiline = True
        Me.bxKey.Name = "bxKey"
        Me.bxKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(79)
        Me.bxKey.Size = New System.Drawing.Size(211, 10)
        Me.bxKey.TabIndex = 1
        Me.bxKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.SlateGray
        Me.lblName.Location = New System.Drawing.Point(38, 70)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(224, 57)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Blockade 1.0"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Font = New System.Drawing.Font("Wingdings 3", 5.0!)
        Me.lblKey.ForeColor = System.Drawing.Color.Transparent
        Me.lblKey.Location = New System.Drawing.Point(176, 127)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(76, 7)
        Me.lblKey.TabIndex = 2
        Me.lblKey.Text = "i am the key"
        '
        'lblDoor
        '
        Me.lblDoor.AutoSize = True
        Me.lblDoor.Font = New System.Drawing.Font("Wingdings 3", 5.0!)
        Me.lblDoor.ForeColor = System.Drawing.Color.Transparent
        Me.lblDoor.Location = New System.Drawing.Point(46, 127)
        Me.lblDoor.Name = "lblDoor"
        Me.lblDoor.Size = New System.Drawing.Size(80, 7)
        Me.lblDoor.TabIndex = 3
        Me.lblDoor.Text = "i am the door"
        '
        'Block
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(300, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDoor)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.bxKey)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Block"
        Me.Opacity = 0.3R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blockade"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.RoyalBlue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bxKey As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblKey As Label
    Friend WithEvents lblDoor As Label
End Class
