<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWelcome))
        Me.PicSignUp = New System.Windows.Forms.PictureBox()
        Me.PicLogin = New System.Windows.Forms.PictureBox()
        CType(Me.PicSignUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicSignUp
        '
        Me.PicSignUp.BackColor = System.Drawing.Color.Transparent
        Me.PicSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicSignUp.Image = Global.Sultan_Turkish_Cuisine.My.Resources.Resources.WelcomeSignUpPNG
        Me.PicSignUp.Location = New System.Drawing.Point(412, 393)
        Me.PicSignUp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PicSignUp.Name = "PicSignUp"
        Me.PicSignUp.Size = New System.Drawing.Size(91, 38)
        Me.PicSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicSignUp.TabIndex = 5
        Me.PicSignUp.TabStop = False
        '
        'PicLogin
        '
        Me.PicLogin.BackColor = System.Drawing.Color.Transparent
        Me.PicLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicLogin.Image = Global.Sultan_Turkish_Cuisine.My.Resources.Resources.WelcomeLogInPNG
        Me.PicLogin.Location = New System.Drawing.Point(314, 393)
        Me.PicLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PicLogin.Name = "PicLogin"
        Me.PicLogin.Size = New System.Drawing.Size(91, 38)
        Me.PicLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicLogin.TabIndex = 4
        Me.PicLogin.TabStop = False
        '
        'FrmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(816, 519)
        Me.ControlBox = False
        Me.Controls.Add(Me.PicSignUp)
        Me.Controls.Add(Me.PicLogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Blue
        CType(Me.PicSignUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicSignUp As PictureBox
    Friend WithEvents PicLogin As PictureBox
End Class
