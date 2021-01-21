<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlertDialogueCorrectPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlertDialogueCorrectPayment))
        Me.PicOK = New System.Windows.Forms.PictureBox()
        CType(Me.PicOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicOK
        '
        Me.PicOK.BackColor = System.Drawing.Color.Transparent
        Me.PicOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicOK.Image = Global.Sultan_Turkish_Cuisine.My.Resources.Resources.AlertDialogueOKbtnPNG
        Me.PicOK.Location = New System.Drawing.Point(501, 519)
        Me.PicOK.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicOK.Name = "PicOK"
        Me.PicOK.Size = New System.Drawing.Size(309, 46)
        Me.PicOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicOK.TabIndex = 10
        Me.PicOK.TabStop = False
        '
        'FrmAlertDialogueCorrectPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1313, 857)
        Me.ControlBox = False
        Me.Controls.Add(Me.PicOK)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmAlertDialogueCorrectPayment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Blue
        CType(Me.PicOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicOK As PictureBox
End Class
