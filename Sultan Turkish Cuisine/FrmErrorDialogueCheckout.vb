Public Class FrmErrorDialogueCheckout

    'Sultan Turkish Cuisine
    'Alert Checkout Dialogue Form
    'Programmed By S Rahman
    '05/05/18
    '------------------------------------------------------------------------------------------------------------------------------------

    Private Sub PicOK_Click(sender As Object, e As EventArgs) Handles PicOK.Click
        Me.Close() 'Closes the current form
    End Sub

    Private Sub PicOK_MouseDown(sender As Object, e As MouseEventArgs) Handles PicOK.MouseDown
        PicOK.Image = New Bitmap(My.Resources.ErrorDialogueOKbtnMouseDownPNG) 'Changes the state of the button when clicked down
    End Sub

    Private Sub PicOK_MouseEnter(sender As Object, e As EventArgs) Handles PicOK.MouseEnter
        PicOK.Image = New Bitmap(My.Resources.ErrorDialogueOKbtnRolloverPNG) 'Changes the state of the button when hovered over
    End Sub

    Private Sub PicOK_MouseLeave(sender As Object, e As EventArgs) Handles PicOK.MouseLeave
        PicOK.Image = New Bitmap(My.Resources.ErrorDialogueOKbtnPNG) 'Changes the state of the button when the user has left it
    End Sub

    Private Sub PicOK_MouseUp(sender As Object, e As MouseEventArgs) Handles PicOK.MouseUp
        PicOK.Image = New Bitmap(My.Resources.ErrorDialogueOKbtnPNG) 'Changes the state of the button when the user clicks up
    End Sub
End Class