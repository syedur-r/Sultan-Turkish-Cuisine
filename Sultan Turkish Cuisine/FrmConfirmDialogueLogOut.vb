Public Class FrmConfirmDialogueLogOut

    'Sultan Turkish Cuisine
    'Confirm Log out Dialogue Form
    'Programmed By S Rahman
    '05/05/18
    '------------------------------------------------------------------------------------------------------------------------------------

#Region "Yes"
    Private Sub PicYes_Click(sender As Object, e As EventArgs) Handles PicYes.Click
        FrmOrder.lstViewOrder.Items.Clear() 'This line of code allows the entire listbox to be cleared
        FrmOrder.txtCustomerPaid.Text = "" 'Clears the customer paid textbox on the order form
        FrmOrder.txtChangeDue.Text = "" 'Clears the change due textbox on the order form

        FrmOrder.MixShishTotal = 0
        FrmOrder.ChickenIskenderTotal = 0
        FrmOrder.LambChopsTotal = 0
        FrmOrder.StrawberryMojitoTotal = 0
        FrmOrder.TurkishTeaTotal = 0    'This block of code resets the total variables of the login form to 0
        FrmOrder.TurkishCoffeeTotal = 0
        FrmOrder.ChocolateCheesecakeTotal = 0
        FrmOrder.TurkishDelightTotal = 0
        FrmOrder.StrawberryCheesecakeTotal = 0

        FrmOrder.OrderTotalGrand = 0
        FrmOrder.CustomerPaid = 0  'This block of code resets the grandtotal, customer paid, and change due variables of the login form to 0
        FrmOrder.ChangeDue = 0

        FrmOrder.txtQtyMixShish.Text = 0
        FrmOrder.txtQtyIskender.Text = 0
        FrmOrder.txtQtyLambChops.Text = 0
        FrmOrder.txtQtyStrawMojito.Text = 0
        FrmOrder.txtQtyTurkishTea.Text = 0    'This block of code resets the quantity textboxes of the login form to 0
        FrmOrder.txtQtyTurkishCoffee.Text = 0
        FrmOrder.txtQtyChocCheesecake.Text = 0
        FrmOrder.txtQtyTurkishDelight.Text = 0
        FrmOrder.txtQtyStrawCheesecake.Text = 0

        FrmOrder.lblSubtotalFigure.Text = "£0.00" 'This resets the subtotal textbox of the login form to £0.00
        FrmOrder.lblVATFigure.Text = "£0.00" 'This resets the VAT textbox of the login form to £0.00
        FrmOrder.txtGrandTotal.Text = FormatCurrency(FrmOrder.OrderTotalGrand) 'This resets the grandtotal textbox of the login form to 0, as the variable of the login form has been reset to 0

        Dim FadeOutTimer As New Timer 'This code declares a new timer as a variable
        FadeOutTimer.Interval = 10 'This code sets the interval of the timer variable as 10
        FadeOutTimer.Start() 'This code starts the timer
        AddHandler FadeOutTimer.Tick, Sub()
                                          'This code creates a nested subroutine within the current sub routine, allowing it to control the timer 
                                          FrmOrder.Opacity -= 0.1
                                          Me.Opacity -= 0.1 'This code creates a fade out animation of the current form, by decreasing the opacity by 0.1
                                          If FrmOrder.Opacity = 0 And Me.Opacity = 0 Then
                                              FrmOrder.Hide()
                                              Me.Hide()
                                              Me.Dispose()
                                              FadeOutTimer.Stop()  'When the opacity has reached 0 or 0%, the timer stops
                                              'and the current form disappears
                                              FadeOutTimer.Dispose() 'Gets rid of the timer

                                              FrmLogin.Opacity = 0 'This code sets the login form's opacity as 0 
                                              FrmLogin.Show() 'This code allows the login form to be displayed
                                              Dim NextFormFadeIn As New Timer 'This code declares a new timer as a variable
                                              NextFormFadeIn.Interval = 100 'This code sets the interval of the timer variable as 100
                                              NextFormFadeIn.Start() 'This code starts the timer
                                              AddHandler NextFormFadeIn.Tick, Sub()
                                                                                  'This code creates another nested subroutine within the current sub routine, allowing it to control the timer 
                                                                                  FrmLogin.Opacity += 0.1 'This code creates a fade in animation of the login form, by decreasing the opacity by 0.1
                                                                                  FrmLogin.txtUsername.Text = "Username"
                                                                                  FrmLogin.txtPassword.Text = "Password"
                                                                                  FrmLogin.txtPassword.PasswordChar = ""
                                                                                  FrmLogin.PicLogin.Select()
                                                                                  If FrmLogin.Opacity = 1 Then 'When the opacity has reached 1 or 100%, the timer stops
                                                                                      'and the login form is fully visible
                                                                                      NextFormFadeIn.Stop() 'stops the timer
                                                                                      NextFormFadeIn.Dispose() 'Gets rid of the timer
                                                                                  End If
                                                                              End Sub
                                          End If
                                      End Sub
    End Sub

    Private Sub PicYes_MouseDown(sender As Object, e As MouseEventArgs) Handles PicYes.MouseDown
        PicYes.Image = New Bitmap(My.Resources.ConfirmLogOutbtnYesMouseDownPNG) 'Changes the state of the button when clicked down
    End Sub

    Private Sub PicYes_MouseEnter(sender As Object, e As EventArgs) Handles PicYes.MouseEnter
        PicYes.Image = New Bitmap(My.Resources.ConfirmLogOutbtnYesRolloverPNG) 'Changes the state of the button when hovered over
    End Sub

    Private Sub PicYes_MouseLeave(sender As Object, e As EventArgs) Handles PicYes.MouseLeave
        PicYes.Image = New Bitmap(My.Resources.ConfirmLogOutbtnYesPNG) 'Changes the state of the button when the user leaves the button
    End Sub

    Private Sub PicYes_MouseUp(sender As Object, e As MouseEventArgs) Handles PicYes.MouseUp
        PicYes.Image = New Bitmap(My.Resources.ConfirmLogOutbtnYesPNG) 'Changes the state of the button when clicked up
    End Sub
#End Region

#Region "No"
    Private Sub PicNo_Click(sender As Object, e As EventArgs) Handles PicNo.Click
        Me.Close() 'Closes the current form
        Me.Dispose() 'Gets rid of the current form
    End Sub

    Private Sub PicNo_MouseEnter(sender As Object, e As EventArgs) Handles PicNo.MouseEnter
        PicNo.Image = New Bitmap(My.Resources.ConfirmLogOutbtnNoRolloverPNG)
    End Sub

    Private Sub PicNo_MouseLeave(sender As Object, e As EventArgs) Handles PicNo.MouseLeave
        PicNo.Image = New Bitmap(My.Resources.ConfirmLogOutbtnNoPNG)
    End Sub

    Private Sub PicNo_MouseDown(sender As Object, e As MouseEventArgs) Handles PicNo.MouseDown
        PicNo.Image = New Bitmap(My.Resources.ConfirmLogOutbtnNoMouseDownPNG)
    End Sub

    Private Sub PicNo_MouseUp(sender As Object, e As MouseEventArgs) Handles PicNo.MouseUp
        PicNo.Image = New Bitmap(My.Resources.ConfirmLogOutbtnNoPNG)
    End Sub
#End Region

End Class