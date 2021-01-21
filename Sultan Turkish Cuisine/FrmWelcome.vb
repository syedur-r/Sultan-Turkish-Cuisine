Public Class FrmWelcome

    'Sultan Turkish Cuisine
    'Welcome Form
    'Programmed By S Rahman
    '05/05/18
    '------------------------------------------------------------------------------------------------------------------------------------

    Private Sub FrmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0 'This code sets the opacity as 0%
        Dim Animate As New Timer 'This code declares a new timer as a variable
        Animate.Interval = 100 'This code sets the interval of the timer variable as 100
        Animate.Start() 'This code starts the timer
        AddHandler Animate.Tick, Sub()
                                     'This code creates a nested subroutine within the current subroutine, allowing it to control the timer 
                                     Me.Opacity += 0.1 'This code creates an animation by increasing the opacity by 0.1
                                     If Me.Opacity = 1 Then Animate.Stop() 'When the opacity has reached 1 or 100%, the timer stops 
                                 End Sub
    End Sub

    Private Sub PicLogin_Click(sender As Object, e As EventArgs) Handles PicLogin.Click
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
                                                                                  FrmLogin.Opacity += 0.18 'This code creates a fade in animation of the login form, by decreasing the opacity by 0.1
                                                                                  If FrmLogin.Opacity = 1 Then 'When the opacity has reached 1 or 100%, the timer stops
                                                                                      'and the login form is fully visible
                                                                                      NextFormFadeIn.Stop()
                                                                                      NextFormFadeIn.Dispose()
                                                                                  End If
                                                                              End Sub
                                          End If
                                      End Sub
    End Sub

    Private Sub PicLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles PicLogin.MouseDown
        PicLogin.Image = New Bitmap(My.Resources.btnWelcomeLoginMouseDownPNG) 'This code changes the image when the button is clicked down
    End Sub

    Private Sub PicLogin_MouseEnter(sender As Object, e As EventArgs) Handles PicLogin.MouseEnter
        PicLogin.Image = New Bitmap(My.Resources.btnWelcomeLoginRolloverPNG) 'This code changes the image when the button is hovered over
    End Sub

    Private Sub PicLogin_MouseLeave(sender As Object, e As EventArgs) Handles PicLogin.MouseLeave
        PicLogin.Image = New Bitmap(My.Resources.WelcomeLogInPNG) 'This code changes the button back to its original state when the mouse has left
    End Sub

    Private Sub PicLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles PicLogin.MouseUp
        PicLogin.Image = New Bitmap(My.Resources.WelcomeLogInPNG) 'This code changes the button back to its rollover state when the button is clicked up
    End Sub

    Private Sub PicSignUp_Click(sender As Object, e As EventArgs) Handles PicSignUp.Click
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
                                                                                  FrmRegister.Opacity += 0.18 'This code creates a fade in animation of the register form, by decreasing the opacity by 0.1
                                                                                  If FrmRegister.Opacity = 1 Then 'When the opacity has reached 1 or 100%, the timer stops
                                                                                      'and the register form is fully visible
                                                                                      NextFormFadeIn.Stop()
                                                                                      NextFormFadeIn.Dispose()
                                                                                  End If
                                                                              End Sub
                                          End If
                                      End Sub
    End Sub

    Private Sub PicSignUp_MouseDown(sender As Object, e As MouseEventArgs) Handles PicSignUp.MouseDown
        PicSignUp.Image = New Bitmap(My.Resources.FrmbtnSignUpMouseDownPNG) 'This code changes the image when the button is clicked down
    End Sub

    Private Sub PicSignUp_MouseEnter(sender As Object, e As EventArgs) Handles PicSignUp.MouseEnter
        PicSignUp.Image = New Bitmap(My.Resources.btnWelcomeSignUpRolloverPNG) 'This code changes the image when the button is hovered over
    End Sub

    Private Sub PicSignUp_MouseLeave(sender As Object, e As EventArgs) Handles PicSignUp.MouseLeave
        PicSignUp.Image = New Bitmap(My.Resources.WelcomeSignUpPNG) 'This code changes the button back to its original state when the mouse has left
    End Sub

    Private Sub PicSignUp_MouseUp(sender As Object, e As MouseEventArgs) Handles PicSignUp.MouseUp
        PicSignUp.Image = New Bitmap(My.Resources.WelcomeSignUpPNG) 'This code changes the button back to its rollover state when the button is clicked up
    End Sub

    Private Sub FrmWelcome_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit() 'This code exits the application
    End Sub
End Class