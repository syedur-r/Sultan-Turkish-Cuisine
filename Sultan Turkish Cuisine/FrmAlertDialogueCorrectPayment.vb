Public Class FrmAlertDialogueCorrectPayment

    'Sultan Turkish Cuisine
    'Alert Correct Payment Dialogue Form
    'Programmed By S Rahman
    '05/05/18
    '------------------------------------------------------------------------------------------------------------------------------------

    Private Sub PicOK_Click(sender As Object, e As EventArgs) Handles PicOK.Click
        Me.Close() 'This closes the form
    End Sub

    Private Sub PicOK_MouseDown(sender As Object, e As MouseEventArgs) Handles PicOK.MouseDown
        PicOK.Image = New Bitmap(My.Resources.AlertDialogueOKbtnMouseDownPNG)
        'This changes the state of the button when the user clicks down on it
    End Sub

    Private Sub PicOK_MouseEnter(sender As Object, e As EventArgs) Handles PicOK.MouseEnter
        PicOK.Image = New Bitmap(My.Resources.AlertDialogueOKbtnRolloverPNG)
        'This changes the state of the button when the user hovers over it
    End Sub

    Private Sub PicOK_MouseLeave(sender As Object, e As EventArgs) Handles PicOK.MouseLeave
        PicOK.Image = New Bitmap(My.Resources.AlertDialogueOKbtnPNG)
        'This changes the state of the button when the user leaves the button
    End Sub

    Private Sub PicOK_MouseUp(sender As Object, e As MouseEventArgs) Handles PicOK.MouseUp
        PicOK.Image = New Bitmap(My.Resources.AlertDialogueOKbtnPNG)
        'This changes the state of the button when the user clicks up
    End Sub
End Class