<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegister))
        Me.LlblOpenFrmLogin = New System.Windows.Forms.LinkLabel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.PicRegister = New System.Windows.Forms.PictureBox()
        CType(Me.PicRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LlblOpenFrmLogin
        '
        Me.LlblOpenFrmLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LlblOpenFrmLogin.AutoSize = True
        Me.LlblOpenFrmLogin.BackColor = System.Drawing.Color.Transparent
        Me.LlblOpenFrmLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LlblOpenFrmLogin.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlblOpenFrmLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.LlblOpenFrmLogin.LinkColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.LlblOpenFrmLogin.Location = New System.Drawing.Point(420, 553)
        Me.LlblOpenFrmLogin.Name = "LlblOpenFrmLogin"
        Me.LlblOpenFrmLogin.Size = New System.Drawing.Size(238, 22)
        Me.LlblOpenFrmLogin.TabIndex = 4
        Me.LlblOpenFrmLogin.TabStop = True
        Me.LlblOpenFrmLogin.Text = "Already have an account? Log In"
        Me.LlblOpenFrmLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.Location = New System.Drawing.Point(423, 462)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(223, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.Location = New System.Drawing.Point(423, 405)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(223, 20)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.Text = "Username"
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.White
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullName.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.ForeColor = System.Drawing.Color.DimGray
        Me.txtFullName.Location = New System.Drawing.Point(423, 333)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(223, 20)
        Me.txtFullName.TabIndex = 1
        Me.txtFullName.Text = "Full Name"
        '
        'PicRegister
        '
        Me.PicRegister.BackColor = System.Drawing.Color.Transparent
        Me.PicRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicRegister.Image = Global.Sultan_Turkish_Cuisine.My.Resources.Resources.btnRegisterPNG
        Me.PicRegister.Location = New System.Drawing.Point(383, 505)
        Me.PicRegister.Name = "PicRegister"
        Me.PicRegister.Size = New System.Drawing.Size(310, 45)
        Me.PicRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicRegister.TabIndex = 8
        Me.PicRegister.TabStop = False
        '
        'FrmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1088, 639)
        Me.ControlBox = False
        Me.Controls.Add(Me.PicRegister)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.LlblOpenFrmLogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Blue
        CType(Me.PicRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LlblOpenFrmLogin As LinkLabel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents PicRegister As PictureBox
End Class
