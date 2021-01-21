<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplash
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
        Me.components = New System.ComponentModel.Container()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WBAnimator = New System.Windows.Forms.WebBrowser()
        Me.LoadingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblPercentage
        '
        Me.lblPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.lblPercentage.Location = New System.Drawing.Point(234, 410)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(279, 78)
        Me.lblPercentage.TabIndex = 4
        Me.lblPercentage.Text = "0%"
        Me.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(171, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 96)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Loading..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WBAnimator
        '
        Me.WBAnimator.Location = New System.Drawing.Point(32, 110)
        Me.WBAnimator.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WBAnimator.Name = "WBAnimator"
        Me.WBAnimator.ScrollBarsEnabled = False
        Me.WBAnimator.Size = New System.Drawing.Size(650, 290)
        Me.WBAnimator.TabIndex = 5
        '
        'LoadingTimer
        '
        Me.LoadingTimer.Enabled = True
        Me.LoadingTimer.Interval = 85
        '
        'FrmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(715, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.WBAnimator)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSplash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPercentage As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents WBAnimator As WebBrowser
    Friend WithEvents LoadingTimer As Timer
End Class
