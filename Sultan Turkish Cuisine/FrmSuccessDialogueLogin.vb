Public Class FrmSuccessDialogueLogin

    'Sultan Turkish Cuisine
    'Successful Login Dialogue Form
    'Programmed By S Rahman
    '05/05/18
    '------------------------------------------------------------------------------------------------------------------------------------

    Private Sub PicOK_Click(sender As Object, e As EventArgs) Handles PicOK.Click
        If FrmLogin.txtUsername.Text = FrmLogin.UserName And FrmLogin.txtPassword.Text = FrmLogin.UserPassword Then 'If the username and password is equal to the first define variables then
            'it should perform the procedures stated below
            My.Settings.UserName = FrmLogin.UserName 'Stores the first username into built-in database
            My.Settings.UserPassword = FrmLogin.UserPassword 'Stores the first password into built-in database
            My.Settings.Save() 'Saves the settings
            Dim FadeOutTimer As New Timer 'Creates a new timer variable
            FadeOutTimer.Interval = 10 'Sets the timer interval as 10
            FadeOutTimer.Start() 'Starts the timer variable
            AddHandler FadeOutTimer.Tick, Sub() 'Creates a nested sub routine within the current subroutine, controlling the timer
                                              FrmLogin.Opacity -= 0.1 'Decrements the opacity of the login form
                                              Me.Opacity -= 0.1 'Decreases the opacity of the current form by 0.1
                                              If FrmLogin.Opacity = 0 And Me.Opacity = 0 Then 'When the opacity reaches 0, the current form hides and the timer stops
                                                  Me.Hide() 'Hides the current form
                                                  FrmLogin.Hide() 'Hides the login form
                                                  Me.Dispose() 'Gets rid of the current form
                                                  FadeOutTimer.Stop() 'Stops the timer
                                                  FadeOutTimer.Dispose() 'Gets rid of the timer

                                                  FrmOrder.Opacity = 0 'Sets the next forms (Order Form) opacity as 0 
                                                  FrmOrder.Show() 'Displays the Order Form
                                                  Dim NextFormFadeIn As New Timer 'Creates a new timer variable
                                                  NextFormFadeIn.Interval = 100 'Sets the timer interval as 100
                                                  NextFormFadeIn.Start() 'Starts the timer variable
                                                  AddHandler NextFormFadeIn.Tick, Sub() 'Creates a nested sub routine within the current subroutine, controlling the timer
                                                                                      My.Settings.Reset() 'Resets the database string to its default property
                                                                                      My.Settings.UserName = "Syedur Rahman" 'Stores this name into the built-in database
                                                                                      FrmOrder.lblUsername.Text = My.Settings.UserName 'Passes the string from the database onto the Order Form label
                                                                                      FrmOrder.lblRealTime.Select() 'This allows the date and time to be selected when the form is loaded
                                                                                      FrmOrder.Opacity += 0.1 'Increases the opacity of the Order Form by 0.18
                                                                                      If FrmOrder.Opacity = 1 Then 'When the opacity reaches 0, the Order Form is displayed and the timer stops
                                                                                          NextFormFadeIn.Stop() 'Stops the timer
                                                                                          NextFormFadeIn.Dispose() 'Gets rid of the timer
                                                                                      End If
                                                                                  End Sub
                                              End If
                                          End Sub
        ElseIf frmlogin.txtUsername.Text = frmlogin.UserName2 And frmlogin.txtPassword.Text = frmlogin.UserPassword2 Then 'If the username and password is equal to the second define variables then
            'it should perform the procedures stated below
            My.Settings.UserName = FrmLogin.UserName2 'Stores the second username into built-in database
            My.Settings.UserPassword = FrmLogin.UserPassword2 'Stores the second password into built-in database
            My.Settings.Save() 'Saves the settings
            Dim FadeOutTimer As New Timer 'Creates a new timer variable
            FadeOutTimer.Interval = 10 'Sets the timer interval as 10
            FadeOutTimer.Start() 'Starts the timer variable
            AddHandler FadeOutTimer.Tick, Sub() 'Creates a nested sub routine within the current subroutine, controlling the timer
                                              FrmLogin.Opacity -= 0.1
                                              Me.Opacity -= 0.1 'Decreases the opacity of the current form by 0.1
                                              If FrmLogin.Opacity = 0 And Me.Opacity = 0 Then 'When the opacity reaches 0, the current form hides and the timer stops
                                                  Me.Hide()
                                                  FrmLogin.Hide()
                                                  Me.Dispose()
                                                  FadeOutTimer.Stop()
                                                  FadeOutTimer.Dispose()

                                                  FrmOrder.Opacity = 0 'Sets the next forms (Order Form) opacity as 0
                                                  FrmOrder.Show() 'Displays the Order Form
                                                  Dim NextFormFadeIn As New Timer 'Creates a new timer variable
                                                  NextFormFadeIn.Interval = 100 'Sets the timer interval as 100
                                                  NextFormFadeIn.Start() 'Starts the timer variable
                                                  AddHandler NextFormFadeIn.Tick, Sub() 'Creates a nested sub routine within the current subroutine, controlling the timer
                                                                                      My.Settings.Reset() 'Resets the database strings to its default property
                                                                                      My.Settings.UserName = "1" 'Stores this name into the built-in database
                                                                                      FrmOrder.lblUsername.Text = My.Settings.UserName 'Passes the string from the database onto the Order Form label
                                                                                      FrmOrder.lblRealTime.Select() 'This allows the date and time to be selected when the form is loaded
                                                                                      FrmOrder.Opacity += 0.1 'Increases the opacity of the Order Form by 0.18
                                                                                      If FrmOrder.Opacity = 1 Then 'When the opacity reaches 0, the Order Form is displayed and the timer stops
                                                                                          NextFormFadeIn.Stop()
                                                                                          NextFormFadeIn.Dispose() 'Gets rid of the timer
                                                                                      End If
                                                                                  End Sub
                                              End If
                                          End Sub
        ElseIf frmlogin.txtUsername.Text = frmlogin.UserName3 And frmlogin.txtPassword.Text = frmlogin.UserPassword3 Then 'If the username and password is equal to the third define variables then
            'it should perform the procedures stated below
            My.Settings.UserName = FrmLogin.UserName3 'Stores the third username into built-in database
            My.Settings.UserPassword = FrmLogin.UserPassword3 'Stores the third password into built-in database
            My.Settings.Save() 'Saves the settings
            Dim FadeOutTimer As New Timer 'Creates a new timer variable
            FadeOutTimer.Interval = 10 'Sets the timer interval as 10
            FadeOutTimer.Start() 'Starts the timer variable
            AddHandler FadeOutTimer.Tick, Sub() 'Creates a nested sub routine within the current subroutine, controlling the timer
                                              FrmLogin.Opacity -= 0.1
                                              Me.Opacity -= 0.1 'Decreases the opacity of the current form by 0.1
                                              If FrmLogin.Opacity = 0 And Me.Opacity = 0 Then 'When the opacity reaches 0, the current form hides and the timer stops
                                                  Me.Hide()
                                                  FrmLogin.Hide()
                                                  Me.Dispose()
                                                  FadeOutTimer.Stop()
                                                  FadeOutTimer.Dispose()

                                                  FrmOrder.Opacity = 0 'Sets the next forms (Order Form) opacity as 0
                                                  FrmOrder.Show() 'Displays the Order Form
                                                  Dim NextFormFadeIn As New Timer 'Creates a new timer variable
                                                  NextFormFadeIn.Interval = 100 'Sets the timer interval as 100
                                                  NextFormFadeIn.Start() 'Starts the timer variable
                                                  AddHandler NextFormFadeIn.Tick, Sub() 'Creates a nested sub routine within the current subroutine, controlling the timer
                                                                                      My.Settings.Reset() 'Resets the database strings to its default property
                                                                                      My.Settings.UserName = "Sana Miah" 'Stores this name into the built-in database
                                                                                      FrmOrder.lblUsername.Text = My.Settings.UserName 'Passes the string from the database onto the Order Form label
                                                                                      FrmOrder.lblRealTime.Select() 'This allows the date and time to be selected when the form is loaded
                                                                                      FrmOrder.Opacity += 0.1 'Increases the opacity of the Order Form by 0.18
                                                                                      If FrmOrder.Opacity = 1 Then 'When the opacity reaches 0, the Order Form is displayed and the timer stops
                                                                                          NextFormFadeIn.Stop()
                                                                                          NextFormFadeIn.Dispose() 'Gets rid of the timer
                                                                                      End If
                                                                                  End Sub
                                              End If
                                          End Sub
        ElseIf frmlogin.txtUsername.Text = My.Settings.UserName And frmlogin.txtPassword.Text = My.Settings.UserPassword Then 'If the username and password is equal to the values stored in the database then
            'it should perform the procedures stated below
            Dim FadeOutTimer As New Timer 'Creates a new timer variable
            FadeOutTimer.Interval = 10 'Sets the timer interval as 10
            FadeOutTimer.Start() 'Starts the timer variable
            AddHandler FadeOutTimer.Tick, Sub() 'Creates a nested sub routine within the current subroutine, controlling the timer
                                              FrmLogin.Opacity -= 0.1
                                              Me.Opacity -= 0.1 'Decreases the opacity of the current form by 0.1
                                              If FrmLogin.Opacity = 0 And Me.Opacity = 0 Then 'When the opacity reaches 0, the current form hides and the timer stops
                                                  Me.Hide()
                                                  FrmLogin.Hide()
                                                  Me.Dispose()
                                                  FadeOutTimer.Stop()
                                                  FadeOutTimer.Dispose()

                                                  FrmOrder.Opacity = 0 'Sets the next forms (Order Form) opacity as 0
                                                  FrmOrder.Show() 'Displays the Order Form
                                                  Dim NextFormFadeIn As New Timer 'Creates a new timer variable
                                                  NextFormFadeIn.Interval = 100 'Sets the timer interval as 100
                                                  NextFormFadeIn.Start() 'Starts the timer variable
                                                  AddHandler NextFormFadeIn.Tick, Sub() 'Creates a nested sub routine within the current subroutine, controlling the timer
                                                                                      FrmOrder.lblUsername.Text = My.Settings.UserName 'Passes the string from the database onto the Order Form label
                                                                                      FrmOrder.lblRealTime.Select() 'This allows the date and time to be selected when the form is loaded
                                                                                      FrmOrder.Opacity += 0.1 'Increases the opacity of the Order Form by 0.18
                                                                                      If FrmOrder.Opacity = 1 Then 'When the opacity reaches 0, the Order Form is displayed and the timer stops
                                                                                          NextFormFadeIn.Stop()
                                                                                          NextFormFadeIn.Dispose() 'Gets rid of the timer
                                                                                      End If
                                                                                  End Sub
                                              End If
                                          End Sub
        End If
    End Sub

    Private Sub PicOK_MouseDown(sender As Object, e As MouseEventArgs) Handles PicOK.MouseDown
        PicOK.Image = New Bitmap(My.Resources.SuccessDialogueBoxOKbtnMouseDownPNG) 'Changes the state of the button when clicked down
    End Sub

    Private Sub PicOK_MouseEnter(sender As Object, e As EventArgs) Handles PicOK.MouseEnter
        PicOK.Image = New Bitmap(My.Resources.SuccessDialogueBoxOKbtnRolloverPNG) 'Changes the state of the button when hovered over
    End Sub

    Private Sub PicOK_MouseLeave(sender As Object, e As EventArgs) Handles PicOK.MouseLeave
        PicOK.Image = New Bitmap(My.Resources.SuccessDialogueBoxOKbtnPNG) 'Changes the state of the button when the user has left the button
    End Sub

    Private Sub PicOK_MouseUp(sender As Object, e As MouseEventArgs) Handles PicOK.MouseUp
        PicOK.Image = New Bitmap(My.Resources.SuccessDialogueBoxOKbtnPNG) 'Changes the state of the button when clicked up
    End Sub
End Class