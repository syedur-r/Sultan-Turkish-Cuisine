<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrint))
        Me.PrintReceipt = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewReceipt = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtDisplayChangeDue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPreviewReceipt = New System.Windows.Forms.Button()
        Me.btnExitPrintForm = New System.Windows.Forms.Button()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.lblSuccessful = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintReceipt
        '
        '
        'PrintPreviewReceipt
        '
        Me.PrintPreviewReceipt.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewReceipt.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewReceipt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PrintPreviewReceipt.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewReceipt.Document = Me.PrintReceipt
        Me.PrintPreviewReceipt.Enabled = True
        Me.PrintPreviewReceipt.Icon = CType(resources.GetObject("PrintPreviewReceipt.Icon"), System.Drawing.Icon)
        Me.PrintPreviewReceipt.Name = "PrintPreviewReceipt"
        Me.PrintPreviewReceipt.Visible = False
        '
        'txtDisplayChangeDue
        '
        Me.txtDisplayChangeDue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayChangeDue.ForeColor = System.Drawing.Color.Black
        Me.txtDisplayChangeDue.Location = New System.Drawing.Point(217, 101)
        Me.txtDisplayChangeDue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDisplayChangeDue.Name = "txtDisplayChangeDue"
        Me.txtDisplayChangeDue.ReadOnly = True
        Me.txtDisplayChangeDue.Size = New System.Drawing.Size(147, 30)
        Me.txtDisplayChangeDue.TabIndex = 5
        Me.txtDisplayChangeDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(87, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Change:"
        '
        'btnPreviewReceipt
        '
        Me.btnPreviewReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPreviewReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreviewReceipt.FlatAppearance.BorderSize = 2
        Me.btnPreviewReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreviewReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btnPreviewReceipt.Location = New System.Drawing.Point(80, 161)
        Me.btnPreviewReceipt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPreviewReceipt.Name = "btnPreviewReceipt"
        Me.btnPreviewReceipt.Size = New System.Drawing.Size(132, 43)
        Me.btnPreviewReceipt.TabIndex = 9
        Me.btnPreviewReceipt.Text = "Preview"
        Me.btnPreviewReceipt.UseVisualStyleBackColor = False
        '
        'btnExitPrintForm
        '
        Me.btnExitPrintForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExitPrintForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExitPrintForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitPrintForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExitPrintForm.ForeColor = System.Drawing.Color.White
        Me.btnExitPrintForm.Location = New System.Drawing.Point(165, 0)
        Me.btnExitPrintForm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExitPrintForm.Name = "btnExitPrintForm"
        Me.btnExitPrintForm.Size = New System.Drawing.Size(121, 34)
        Me.btnExitPrintForm.TabIndex = 10
        Me.btnExitPrintForm.Text = "EXIT"
        Me.btnExitPrintForm.UseVisualStyleBackColor = False
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintReceipt.FlatAppearance.BorderSize = 2
        Me.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintReceipt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrintReceipt.Location = New System.Drawing.Point(240, 161)
        Me.btnPrintReceipt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(132, 43)
        Me.btnPrintReceipt.TabIndex = 11
        Me.btnPrintReceipt.Text = "Print"
        Me.btnPrintReceipt.UseVisualStyleBackColor = False
        '
        'lblSuccessful
        '
        Me.lblSuccessful.AutoSize = True
        Me.lblSuccessful.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSuccessful.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuccessful.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.lblSuccessful.Location = New System.Drawing.Point(16, 46)
        Me.lblSuccessful.Name = "lblSuccessful"
        Me.lblSuccessful.Size = New System.Drawing.Size(397, 36)
        Me.lblSuccessful.TabIndex = 104
        Me.lblSuccessful.Text = "Your order has been successful!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 153)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(453, 57)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(453, 34)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'FrmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(452, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSuccessful)
        Me.Controls.Add(Me.btnPreviewReceipt)
        Me.Controls.Add(Me.btnExitPrintForm)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtDisplayChangeDue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintReceipt As Printing.PrintDocument
    Friend WithEvents PrintPreviewReceipt As PrintPreviewDialog
    Friend WithEvents txtDisplayChangeDue As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPreviewReceipt As Button
    Friend WithEvents btnExitPrintForm As Button
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents lblSuccessful As Label
End Class
