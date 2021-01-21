Public Class FrmSplash

    'Sultan Turkish Cuisine
    'Splash Screen
    'Programmed By S Rahman
    '05/05/18
    '------------------------------------------------------------------------------------------------------------------------------------

    Private Sub FrmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This try and finally statement allows the web browser to locate the animation file path for each condition.
        'If one condition for the file path isn't met, it will try the other one.
        Try
            WBAnimator.Navigate("D:\Programming projects (vb)\Sultan Turkish Cuisine (D)\Sultan Turkish Cuisine\Sultan Turkish Cuisine\Resources\SplashAnimation.swf")
        Finally
            WBAnimator.Navigate("D:\Programming projects (vb)\Sultan Turkish Cuisine (D)\Sultan Turkish Cuisine\Sultan Turkish Cuisine\Resources\SplashAnimation.swf")
        End Try
        'This code navigates the web browser to the file path, allowing the swf animated image to be displayed
        LoadingTimer.Start() 'This starts the timer and allows the percentage to be incremented
    End Sub

    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        lblPercentage.Text = Val(lblPercentage.Text) + 2 & "%" 'This code returns the text as a numeric value and 
        'increments the value by 2
        If lblPercentage.Text = 102 & "%" Then 'This condition stops the timer when the timer has reached 102% 
            'and then hides the current form, displays the login form, and gets rid of the timer
            LoadingTimer.Stop() 'Stops the timer
            FrmWelcome.TopMost = True 'This code allows the code to be displayed on top of all other forms
            FrmWelcome.Show() 'Displays the login form
            Me.Hide() 'Hides the current form
            LoadingTimer.Dispose() 'Gets rid of the timer
        End If
    End Sub
End Class
