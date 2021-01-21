<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSuccessDialogueLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSuccessDialogueLogin))
        Me.PicOK = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        CType(Me.PicOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicOK
        '
        Me.PicOK.BackColor = System.Drawing.Color.Transparent
        Me.PicOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicOK.Image = Global.Sultan_Turkish_Cuisine.My.Resources.Resources.SuccessDialogueBoxOKbtnPNG
        Me.PicOK.Location = New System.Drawing.Point(502, 519)
        Me.PicOK.Name = "PicOK"
        Me.PicOK.Size = New System.Drawing.Size(310, 45)
        Me.PicOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicOK.TabIndex = 9
        Me.PicOK.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 476)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1289, 33)
        Me.lblWelcome.TabIndex = 10
        Me.lblWelcome.Text = "Welcome Syedur"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmSuccessDialogueLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1313, 857)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.PicOK)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSuccessDialogueLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Blue
        CType(Me.PicOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicOK As PictureBox
    Friend WithEvents lblWelcome As Label
End Class
