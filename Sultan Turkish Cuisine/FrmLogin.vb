Public Class FrmLogin

    'Sultan Turkish Cuisine
    'Login Form
    'Programmed By S Rahman
    '05/05/18
    '------------------------------------------------------------------------------------------------------------------------------------

    Dim DefaultUserName As String = "Username" 'This global variable sets the 1st textbox's default name as "Username"
    Dim DefaultUserPassword As String = "Password" 'This global variable sets the 2nd textbox's default name as "Password"

    Public UserName As String = "admin" 'This variable is the first defined username
    Public UserPassword As String = "syedur" 'This variable is the first defined password
    Public UserName2 As String = "1" 'This variable is the second defined username
    Public UserPassword2 As String = "1" 'This variable is the second defined password
    Public UserName3 As String = "sa" 'This variable is the third defined username
    Public UserPassword3 As String = "sa" 'This variable is the third defined password

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PicLogin.Select() 'This code selects the login button when the form loads
    End Sub

    Private Sub PicLogin_MouseEnter(sender As Object, e As EventArgs) Handles PicLogin.MouseEnter
        PicLogin.Image = New Bitmap(My.Resources.buttonrollover3) 'This code changes the image when the button is hovered over
    End Sub

    Private Sub PicLogin_MouseLeave(sender As Object, e As EventArgs) Handles PicLogin.MouseLeave
        PicLogin.Image = New Bitmap(My.Resources.button) 'This code changes the button back to its original state when the mouse has left
    End Sub

    Private Sub PicLogin_Click(sender As Object, e As EventArgs) Handles PicLogin.Click
        If txtUsername.Text = UserName And txtPassword.Text = UserPassword Then 'If the username and password is equal to the first define variables then
            'it should perform the procedures stated below
            My.Settings.UserName = UserName 'Stores the first username into built-in database
            My.Settings.UserPassword = UserPassword 'Stores the first password into built-in database
            My.Settings.Save() 'Saves the settings
            Beep() 'Makes a beep noise
            FrmSuccessDialogueLogin.TopMost = True
            FrmSuccessDialogueLogin.lblWelcome.Text = "Welcome Syedur Rahman"
                        FrmSuccessDialogueLogin.Show()
        ElseIf txtUsername.Text = UserName2 And txtPassword.Text = UserPassword2 Then 'If the username and password is equal to the second define variables then
            'it should perform the procedures stated below
            My.Settings.UserName = UserName2 'Stores the second username into built-in database
            My.Settings.UserPassword = UserPassword2 'Stores the second password into built-in database
            My.Settings.Save() 'Saves the settings
            Beep()
            FrmSuccessDialogueLogin.TopMost = True
            FrmSuccessDialogueLogin.lblWelcome.Text = "Welcome 1"
            FrmSuccessDialogueLogin.Show()
        ElseIf txtUsername.Text = UserName3 And txtPassword.Text = UserPassword3 Then 'If the username and password is equal to the third define variables then
            'it should perform the procedures stated below
            My.Settings.UserName = UserName3 'Stores the third username into built-in database
            My.Settings.UserPassword = UserPassword3 'Stores the third password into built-in database
            My.Settings.Save() 'Saves the settings
            Beep()
            FrmSuccessDialogueLogin.TopMost = True
            FrmSuccessDialogueLogin.lblWelcome.Text = "Welcome Sana Miah"
            FrmSuccessDialogueLogin.Show()
        ElseIf txtUsername.Text = My.Settings.UserName And txtPassword.Text = My.Settings.UserPassword Then 'If the username and password is equal to the values stored in the database then
            'it should perform the procedures stated below
            Beep()
            FrmSuccessDialogueLogin.TopMost = True
            FrmSuccessDialogueLogin.lblWelcome.Text = "Welcome " & My.Settings.UserName
            FrmSuccessDialogueLogin.Show()
        Else
            Beep() 'If the conditions above are not met, an error dialogue message will appear asking for a correct username and password
            FrmErrorDialogueLogin.TopMost = True
            FrmErrorDialogueLogin.Show()
            Exit Sub
        End If
    End Sub

    Private Sub PicLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles PicLogin.MouseDown
        PicLogin.Image = New Bitmap(My.Resources.buttonmousedown) 'This code changes the image when the button is clicked down
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

    Private Sub LlblOpenFrmRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlblOpenFrmRegister.LinkClicked
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

                                              FrmRegister.Opacity = 0 'This code sets the register form's opacity as 0 
                                              FrmRegister.Show() 'This code allows the register form to be displayed
                                              Dim NextFormFadeIn As New Timer 'This code declares a new timer as a variable
                                              NextFormFadeIn.Interval = 100 'This code sets the interval of the timer variable as 100
                                              NextFormFadeIn.Start() 'This code starts the timer
                                              AddHandler NextFormFadeIn.Tick, Sub()
                                                                                  'This code creates another nested subroutine within the current sub routine, allowing it to control the timer 
                                                                                  FrmRegister.Opacity += 0.1 'This code creates a fade in animation of the register form, by decreasing the opacity by 0.1
                                                                                  If FrmRegister.Opacity = 1 Then 'When the opacity has reached 1 or 100%, the timer stops
                                                                                      'and the register form is fully visible
                                                                                      NextFormFadeIn.Stop()
                                                                                      NextFormFadeIn.Dispose()
                                                                                  End If
                                                                              End Sub
                                          End If
                                      End Sub
    End Sub

    Private Sub FrmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit() 'This code exits the application
    End Sub
End Class