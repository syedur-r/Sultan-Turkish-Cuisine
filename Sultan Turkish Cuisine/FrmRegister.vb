Public Class FrmRegister

    'Sultan Turkish Cuisine
    'Register Form
    'Programmed By S Rahman
    '05/05/18
    '------------------------------------------------------------------------------------------------------------------------------------

    Public DefaultFullName As String = "Full Name" 'This global variable sets the 1st textbox's default name as "Full Name"
    Public DefaultUserName As String = "Username" 'This global variable sets the 2nd textbox's default name as "Username"
    Public DefaultUserPassword As String = "Password" 'This global variable sets the 3rd textbox's default name as "Password"

    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PicRegister.Select() 'This code selects the register button when the form loads
    End Sub

    Private Sub txtFullName_Enter(sender As Object, e As EventArgs) Handles txtFullName.Enter
        If txtFullName.Text = DefaultFullName Then 'This condition selects all the letters of the Full Name textbox when it contains "Full Name" 
            txtFullName.SelectAll()
            txtFullName.Text = "" 'When the user clicks on the Full Name textbox, the textbox clears
        Else
            txtFullName.SelectAll() 'This code means regardless of the condition, the Full Name textbox letters will always be selected
        End If

        txtFullName.ForeColor = Color.Black 'This sets the font colour of the textbox as black after the user has clicked the textbox
        txtFullName.Font = New Font(txtFullName.Font, FontStyle.Bold) 'This sets the font style as bold after the user has clicked the textbox
    End Sub

    Private Sub txtFullName_Leave(sender As Object, e As EventArgs) Handles txtFullName.Leave
        If txtFullName.Text = String.Empty Then 'This condition sets the Full Name text box as its default variable name, when the user hasn't entered anything into the textbox 
            txtFullName.Text = "Full Name"
        End If
        txtFullName.ForeColor = Color.DimGray 'This sets the font colour of the textbox as dim gray when the user has clicked away from the Full Name textbox
        txtFullName.Font = New Font(txtFullName.Font, FontStyle.Regular) 'This sets the font style as regular when the user has clicked away from the Full Name textbox
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter

        If txtUsername.Text = DefaultUserName Then 'This condition selects all the letters of the Username textbox when it contains "Username" 
            txtUsername.SelectAll()
            txtUsername.Text = "" 'When the user clicks on the Username textbox, the textbox clears
        Else
            txtUsername.SelectAll() 'This code means regardless of the condition, the Username textbox letters will always be selected
        End If

        txtUsername.ForeColor = Color.Black 'This sets the font colour of the textbox as black after the user has clicked the textbox
        txtUsername.Font = New Font(txtUsername.Font, FontStyle.Bold) 'This sets the font style as bold after the user has clicked the textbox
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = String.Empty Then 'This condition sets the Username text box as its default variable name, when the user hasn't entered anything into the textbox
            txtUsername.Text = "Username"
        End If
        txtUsername.ForeColor = Color.DimGray 'This sets the font colour of the textbox as dim gray when the user has clicked away from the Username textbox
        txtUsername.Font = New Font(txtUsername.Font, FontStyle.Regular) 'This sets the font style as regular when the user has clicked away from the Username textbox
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = DefaultUserPassword Then 'This condition selects all the letters of the Password textbox when it contains "Password"
            txtPassword.SelectAll()
            txtPassword.Text = "" 'When the user clicks on the Password textbox, the textbox clears the default text 
        Else
            txtPassword.SelectAll() 'This code means regardless of the condition, the Password textbox letters will always be selected
        End If

        txtPassword.ForeColor = Color.Black 'This sets the font colour of the textbox as black after the user has clicked the textbox
        txtPassword.Font = New Font(txtPassword.Font, FontStyle.Bold) 'This sets the font style as bold after the user has clicked the textbox
        txtPassword.PasswordChar = "•" 'This allows the password to be encrypted using the '•' symbol 
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = String.Empty Then 'This condition sets the Password text box as its default variable name, when the user hasn't entered anything into the textbox
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = "" 'This code removes the encryption from the Password textbox, and resets the textbox as its default variable name
        End If
        txtPassword.ForeColor = Color.DimGray 'This sets the font colour of the textbox as dim gray when the user has clicked away from the Password textbox
        txtPassword.Font = New Font(txtPassword.Font, FontStyle.Regular) 'This sets the font style as regular when the user has clicked away from the Password textbox
    End Sub

    Private Sub FrmRegister_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit() 'This code exits the application
    End Sub

    Private Sub LlblOpenFrmLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlblOpenFrmLogin.LinkClicked
        Dim FadeOutTimer As New Timer 'This code declares a new timer as a variable
        FadeOutTimer.Interval = 10 'This code sets the interval of the timer variable as 10
        FadeOutTimer.Start() 'This code starts the timer
        AddHandler FadeOutTimer.Tick, Sub()
                                          'This code creates a nested subroutine within the current sub routine, allowing it to control the timer 
                                          Me.Opacity -= 0.1 'This code creates a fade out animation of the current form, by decreasing the opacity by 0.1
                                          If Me.Opacity = 0 Then
                                              Me.Hide()
                                              FadeOutTimer.Stop()  'When the opacity has reached 0 or 0%, the timer stops
                                              'and the current form disappears
                                              FadeOutTimer.Dispose()

                                              FrmLogin.Opacity = 0 'This code sets the login form's opacity as 0 
                                              FrmLogin.Show() 'This code allows the login form to be displayed
                                              Dim NextFormFadeIn As New Timer 'This code declares a new timer as a variable
                                              NextFormFadeIn.Interval = 100 'This code sets the interval of the timer variable as 100
                                              NextFormFadeIn.Start() 'This code starts the timer
                                              AddHandler NextFormFadeIn.Tick, Sub()
                                                                                  'This code creates another nested subroutine within the current sub routine, allowing it to control the timer 
                                                                                  FrmLogin.Opacity += 0.1 'This code creates a fade in animation of the login form, by decreasing the opacity by 0.1
                                                                                  If FrmLogin.Opacity = 1 Then 'When the opacity has reached 1 or 100%, the timer stops
                                                                                      'and the login form is fully visible
                                                                                      NextFormFadeIn.Stop()
                                                                                      NextFormFadeIn.Dispose()
                                                                                  End If
                                                                              End Sub
                                          End If
                                      End Sub
    End Sub

    Private Sub PicRegister_Click(sender As Object, e As EventArgs) Handles PicRegister.Click
        'This condition states that if the three textboxes consist of their default variable names, a message box
        'should be displayed to alert the user to fill in all the fields before clicking enter 
        If (txtFullName.Text = "Full Name" OrElse txtUsername.Text = "Username" OrElse txtPassword.Text = "Password") Then
            Beep() 'Makes a beep noise
            FrmAlertDialogueRegister.TopMost = True 'Brings the alert dialogue box to the front
            FrmAlertDialogueRegister.Show() 'Displays the alert dialogue box
            Exit Sub
        Else
            Try 'This statement tries perform the conditions below, which are: saving the details into the built-in database located in settings
                'as well as displaying a success message box and reseting the textboxes to their default variable names
                My.Settings.FullName = txtFullName.Text
                My.Settings.UserName = txtUsername.Text
                My.Settings.UserPassword = txtPassword.Text
                My.Settings.Save()
                Beep()
                FrmSuccessDialogueRegister.TopMost = True
                FrmSuccessDialogueRegister.Show()
            Catch ex As Exception 'This catches the potential errors that aren't able carry out the procedure above, as an exception
                'and displays the error in a message box to allow the user to be aware of the error they have made
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PicRegister_MouseEnter(sender As Object, e As EventArgs) Handles PicRegister.MouseEnter
        PicRegister.Image = New Bitmap(My.Resources.btnRegisterRolloverPNG) 'This code changes the image when the button is hovered over
    End Sub

    Private Sub PicRegister_MouseLeave(sender As Object, e As EventArgs) Handles PicRegister.MouseLeave
        PicRegister.Image = New Bitmap(My.Resources.btnRegisterPNG) 'This code changes the button back to its original state when the mouse has left
    End Sub

    Private Sub PicRegister_MouseDown(sender As Object, e As MouseEventArgs) Handles PicRegister.MouseDown
        PicRegister.Image = New Bitmap(My.Resources.btnRegisterMouseDownPNG) 'This code changes the image when the button is clicked down
    End Sub

End Class