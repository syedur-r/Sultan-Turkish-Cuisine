<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfirmDialogueLogOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfirmDialogueLogOut))
        Me.PicYes = New System.Windows.Forms.PictureBox()
        Me.PicNo = New System.Windows.Forms.PictureBox()
        CType(Me.PicYes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicYes
        '
        Me.PicYes.BackColor = System.Drawing.Color.Transparent
        Me.PicYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicYes.Image = Global.Sultan_Turkish_Cuisine.My.Resources.Resources.ConfirmLogOutbtnYesPNG
        Me.PicYes.Location = New System.Drawing.Point(452, 518)
        Me.PicYes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicYes.Name = "PicYes"
        Me.PicYes.Size = New System.Drawing.Size(202, 46)
        Me.PicYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicYes.TabIndex = 11
        Me.PicYes.TabStop = False
        '
        'PicNo
        '
        Me.PicNo.BackColor = System.Drawing.Color.Transparent
        Me.PicNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicNo.Image = Global.Sultan_Turkish_Cuisine.My.Resources.Resources.ConfirmLogOutbtnNoPNG
        Me.PicNo.Location = New System.Drawing.Point(664, 518)
        Me.PicNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicNo.Name = "PicNo"
        Me.PicNo.Size = New System.Drawing.Size(197, 46)
        Me.PicNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicNo.TabIndex = 12
        Me.PicNo.TabStop = False
        '
        'FrmConfirmDialogueLogOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1313, 857)
        Me.ControlBox = False
        Me.Controls.Add(Me.PicYes)
        Me.Controls.Add(Me.PicNo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConfirmDialogueLogOut"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Blue
        CType(Me.PicYes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicYes As PictureBox
    Friend WithEvents PicNo As PictureBox
End Class
