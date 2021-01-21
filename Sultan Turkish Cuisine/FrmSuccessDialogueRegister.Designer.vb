<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSuccessDialogueRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSuccessDialogueRegister))
        Me.PicOK = New System.Windows.Forms.PictureBox()
        CType(Me.PicOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicOK
        '
        Me.PicOK.BackColor = System.Drawing.Color.Transparent
        Me.PicOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicOK.Image = Global.Sultan_Turkish_Cuisine.My.Resources.Resources.SuccessDialogueBoxOKbtnPNG
        Me.PicOK.Location = New System.Drawing.Point(376, 422)
        Me.PicOK.Margin = New System.Windows.Forms.Padding(2)
        Me.PicOK.Name = "PicOK"
        Me.PicOK.Size = New System.Drawing.Size(232, 37)
        Me.PicOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicOK.TabIndex = 10
        Me.PicOK.TabStop = False
        '
        'FrmSuccessDialogueRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(985, 696)
        Me.ControlBox = False
        Me.Controls.Add(Me.PicOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSuccessDialogueRegister"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Blue
        CType(Me.PicOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicOK As PictureBox
End Class
