Public Class FrmSuccessDialogueRegister

    'Sultan Turkish Cuisine
    'Successful Register Dialogue Form
    'Programmed By S Rahman
    '05/05/18
    '------------------------------------------------------------------------------------------------------------------------------------

    Private Sub PicOK_Click(sender As Object, e As EventArgs) Handles PicOK.Click
        FrmRegister.txtFullName.Text = FrmRegister.DefaultFullName 'Register full name textbox is assigned to its default name
        FrmRegister.txtUsername.Text = FrmRegister.DefaultUserName 'Register user name textbox is assigned to its default name
        FrmRegister.txtPassword.Text = FrmRegister.DefaultUserPassword 'Register password textbox is assigned to its default name
        FrmRegister.txtPassword.PasswordChar = "" 'Decrypts the password by removing the password character
        FrmRegister.PicRegister.Select() 'Selects the register button on the register form
        Me.Hide() 'Hides the current form
        FrmRegister.Hide() 'Hides the register form
        FrmLogin.Opacity = 1 'Sets the opacity of the login form as 100%
        FrmLogin.Show() 'Displays the login form
        Me.Dispose() 'Disposes the current form
    End Sub

    Private Sub PicOK_MouseDown(sender As Object, e As MouseEventArgs) Handles PicOK.MouseDown
        PicOK.Image = New Bitmap(My.Resources.SuccessDialogueBoxOKbtnMouseDownPNG) 'Changes the state of the button when clicked down
    End Sub

    Private Sub PicOK_MouseEnter(sender As Object, e As EventArgs) Handles PicOK.MouseEnter
        PicOK.Image = New Bitmap(My.Resources.SuccessDialogueBoxOKbtnRolloverPNG) 'Changes the state of the button when hovered over
    End Sub

    Private Sub PicOK_MouseLeave(sender As Object, e As EventArgs) Handles PicOK.MouseLeave
        PicOK.Image = New Bitmap(My.Resources.SuccessDialogueBoxOKbtnPNG) 'Changes the state of the button when the user has left it
    End Sub

    Private Sub PicOK_MouseUp(sender As Object, e As MouseEventArgs) Handles PicOK.MouseUp
        PicOK.Image = New Bitmap(My.Resources.SuccessDialogueBoxOKbtnPNG) 'Changes the state of the button when clicked up
    End Sub
End Class