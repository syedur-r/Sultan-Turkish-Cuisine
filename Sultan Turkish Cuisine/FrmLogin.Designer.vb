<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.PicLogin = New System.Windows.Forms.PictureBox()
        Me.LlblOpenFrmRegister = New System.Windows.Forms.LinkLabel()
        CType(Me.PicLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.Location = New System.Drawing.Point(317, 375)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(167, 16)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.Location = New System.Drawing.Point(317, 329)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(167, 16)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.Text = "Username"
        '
        'PicLogin
        '
        Me.PicLogin.BackColor = System.Drawing.Color.Transparent
        Me.PicLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicLogin.Image = CType(resources.GetObject("PicLogin.Image"), System.Drawing.Image)
        Me.PicLogin.Location = New System.Drawing.Point(287, 410)
        Me.PicLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PicLogin.Name = "PicLogin"
        Me.PicLogin.Size = New System.Drawing.Size(232, 37)
        Me.PicLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicLogin.TabIndex = 6
        Me.PicLogin.TabStop = False
        '
        'LlblOpenFrmRegister
        '
        Me.LlblOpenFrmRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LlblOpenFrmRegister.AutoSize = True
        Me.LlblOpenFrmRegister.BackColor = System.Drawing.Color.Transparent
        Me.LlblOpenFrmRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LlblOpenFrmRegister.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlblOpenFrmRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.LlblOpenFrmRegister.LinkColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.LlblOpenFrmRegister.Location = New System.Drawing.Point(315, 449)
        Me.LlblOpenFrmRegister.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LlblOpenFrmRegister.Name = "LlblOpenFrmRegister"
        Me.LlblOpenFrmRegister.Size = New System.Drawing.Size(180, 17)
        Me.LlblOpenFrmRegister.TabIndex = 3
        Me.LlblOpenFrmRegister.TabStop = True
        Me.LlblOpenFrmRegister.Text = "Don't have an account? Sign Up"
        Me.LlblOpenFrmRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(816, 519)
        Me.ControlBox = False
        Me.Controls.Add(Me.LlblOpenFrmRegister)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.PicLogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Blue
        CType(Me.PicLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PicLogin As PictureBox
    Friend WithEvents LlblOpenFrmRegister As LinkLabel
End Class
