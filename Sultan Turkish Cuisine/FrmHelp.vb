Public Class FrmHelp

    'Sultan Turkish Cuisine
    'Help Form
    'Programmed By S Rahman
    '05/05/18
    '------------------------------------------------------------------------------------------------------------------------------------
    Private Sub FrmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PicSlidingPanel.Size = New Size(10, 782) 'This sets the size of the sliding panel to a width of 10
        'and a height of 782 allowing it to be hidden
    End Sub

    Private Sub FrmHelp_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit() 'This allows the application to close from the form close event
    End Sub

#Region "Exit Application"
    Private Sub PicExit_Click(sender As Object, e As EventArgs) Handles PicExit.Click
        Application.Exit() 'This allows the application to close
    End Sub

    Private Sub PicExit_MouseEnter(sender As Object, e As EventArgs) Handles PicExit.MouseEnter
        PicExit.Image = New Bitmap(My.Resources.btnExitRolloverPNG) 'Changes the state of the button when hovered over
    End Sub

    Private Sub PicExit_MouseLeave(sender As Object, e As EventArgs) Handles PicExit.MouseLeave
        PicExit.Image = New Bitmap(My.Resources.btnExitPNG) 'Changes the state of the button when the user has left the button
    End Sub

    Private Sub PicExit_MouseDown(sender As Object, e As MouseEventArgs) Handles PicExit.MouseDown
        PicExit.Image = New Bitmap(My.Resources.btnExitMouseDownPNG) 'Changes the state of the button when clicked down
    End Sub

    Private Sub PicExit_MouseUp(sender As Object, e As MouseEventArgs) Handles PicExit.MouseUp
        PicExit.Image = New Bitmap(My.Resources.btnExitPNG) 'Changes the state of the button when clicked up
    End Sub
#End Region

#Region "Orders Button"
    Private Sub PicOrders_Click(sender As Object, e As EventArgs) Handles PicOrders.Click
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

                                              FrmOrder.Opacity = 0 'This code sets the order form's opacity as 0 
                                              FrmOrder.Show() 'This code allows the order form to be displayed
                                              Dim NextFormFadeIn As New Timer 'This code declares a new timer as a variable
                                              NextFormFadeIn.Interval = 100 'This code sets the interval of the timer variable as 100
                                              NextFormFadeIn.Start() 'This code starts the timer
                                              AddHandler NextFormFadeIn.Tick, Sub()
                                                                                  'This code creates another nested subroutine within the current sub routine, allowing it to control the timer 
                                                                                  FrmOrder.Opacity += 0.1 'This code creates a fade in animation of the order form, by decreasing the opacity by 0.1
                                                                                  If FrmOrder.Opacity = 1 Then 'When the opacity has reached 1 or 100%, the timer stops
                                                                                      'and the order form is fully visible
                                                                                      NextFormFadeIn.Stop()
                                                                                      NextFormFadeIn.Dispose()
                                                                                  End If
                                                                              End Sub
                                          End If
                                      End Sub
    End Sub

    Private Sub PicOrders_MouseEnter(sender As Object, e As EventArgs) Handles PicOrders.MouseEnter
        PicOrders.Image = New Bitmap(My.Resources.HelpFormbtnOrdersRolloverPNG)
    End Sub

    Private Sub PicOrders_MouseLeave(sender As Object, e As EventArgs) Handles PicOrders.MouseLeave
        PicOrders.Image = New Bitmap(My.Resources.HelpFormbtnOrdersPNG)
    End Sub

    Private Sub PicOrders_MouseDown(sender As Object, e As MouseEventArgs) Handles PicOrders.MouseDown
        PicOrders.Image = New Bitmap(My.Resources.HelpFormbtnOrdersMouseDownPNG)
    End Sub

    Private Sub PicOrders_MouseUp(sender As Object, e As MouseEventArgs) Handles PicOrders.MouseUp
        PicOrders.Image = New Bitmap(My.Resources.HelpFormbtnOrdersPNG)
    End Sub
#End Region

#Region "Navigate Button"
    Private Sub PicMenuButton_Click(sender As Object, e As EventArgs) Handles PicMenuButton.Click
        'While the sliding panel width is less than 400, the width will increment by 1 pixel,
        'Allowing the sliding panel to fully be displayed with the buttons and exit button
        While (PicSlidingPanel.Width < 400)
            PicSlidingPanel.Width += 1
            PicSlidingPanel.Show()
            PicHelp.Show()
            PicTroubleshooting.Show()
            PicFAQ.Show()
            PicMenuButton.Hide()
            PicExitPanel.Show()
        End While
    End Sub
#End Region

#Region "Exit Panel"
    Private Sub PicExitPanel_Click(sender As Object, e As EventArgs) Handles PicExitPanel.Click
        'While the sliding panel width is more than 10, the width will decrement by 1 pixel,
        'Allowing the sliding panel to fully be hidden as well as the buttons, and menu button
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            HelpSubPanel.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While
    End Sub
#End Region

#Region "Help Button"
    Private Sub PicHelp_Click(sender As Object, e As EventArgs) Handles PicHelp.Click
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While

        PicHelpContent.Visible = False
    End Sub

    Private Sub PicHelp_MouseEnter(sender As Object, e As EventArgs) Handles PicHelp.MouseEnter
        PicHelp.Image = New Bitmap(My.Resources.HelpRolloverbtnPNG)
        HelpSubPanel.Show() 'This displays the sub panel when the user hovers over the help button
    End Sub

    Private Sub PicHelp_MouseLeave(sender As Object, e As EventArgs) Handles PicHelp.MouseLeave
        PicHelp.Image = New Bitmap(My.Resources.btnHelpPNG)
    End Sub

    Private Sub PicHelp_MouseDown(sender As Object, e As MouseEventArgs) Handles PicHelp.MouseDown
        PicHelp.Image = New Bitmap(My.Resources.HelpMouseDownbtnPNG)
    End Sub

    Private Sub PicHelp_MouseUp(sender As Object, e As MouseEventArgs) Handles PicHelp.MouseUp
        PicHelp.Image = New Bitmap(My.Resources.btnHelpPNG)
    End Sub
#End Region

#Region "Troubleshooting Button"
    Private Sub PicTroubleshooting_Click(sender As Object, e As EventArgs) Handles PicTroubleshooting.Click
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While

        HelpSubPanel.Hide() 'This hides the help sub panel
        PicHelpContent.Visible = True 'This enables the visibililty of the help content
        PicHelpContent.Image = New Bitmap(My.Resources.TroubleshootingContentPNG) 'This changes the content of the picturebox into troubleshooting content
    End Sub

    Private Sub PicTroubleshooting_MouseEnter(sender As Object, e As EventArgs) Handles PicTroubleshooting.MouseEnter
        PicTroubleshooting.Image = New Bitmap(My.Resources.TroubleshootingRolloverbtnPNG)
        HelpSubPanel.Hide() 'This hides the help sub panel when the user hovers over the troubleshooting button
    End Sub

    Private Sub PicTroubleshooting_MouseLeave(sender As Object, e As EventArgs) Handles PicTroubleshooting.MouseLeave
        PicTroubleshooting.Image = New Bitmap(My.Resources.TroubleshootingbtnPNG)
    End Sub

    Private Sub PicTroubleshooting_MouseDown(sender As Object, e As MouseEventArgs) Handles PicTroubleshooting.MouseDown
        PicTroubleshooting.Image = New Bitmap(My.Resources.TroubleshootingMouseDownbtnPNG)
    End Sub

    Private Sub PicTroubleshooting_MouseUp(sender As Object, e As MouseEventArgs) Handles PicTroubleshooting.MouseUp
        PicTroubleshooting.Image = New Bitmap(My.Resources.TroubleshootingbtnPNG)
    End Sub
#End Region

#Region "FAQ Button"
    Private Sub PicFAQ_Click(sender As Object, e As EventArgs) Handles PicFAQ.Click
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While

        HelpSubPanel.Hide() 'This hides the help sub panel
        PicHelpContent.Visible = True 'This enables the visibililty of the help content
        PicHelpContent.Image = New Bitmap(My.Resources.FAQContentPNG) 'This changes the content of the picturebox into FAQ content
    End Sub

    Private Sub PicFAQ_MouseEnter(sender As Object, e As EventArgs) Handles PicFAQ.MouseEnter
        PicFAQ.Image = New Bitmap(My.Resources.FAQRolloverbtnPNG)
        HelpSubPanel.Hide() 'This hides the help sub panel when the user hovers over the FAQ button
    End Sub

    Private Sub PicFAQ_MouseLeave(sender As Object, e As EventArgs) Handles PicFAQ.MouseLeave
        PicFAQ.Image = New Bitmap(My.Resources.FAQbtnPNG)
    End Sub

    Private Sub PicFAQ_MouseDown(sender As Object, e As MouseEventArgs) Handles PicFAQ.MouseDown
        PicFAQ.Image = New Bitmap(My.Resources.FAQMouseDownbtnPNG)
    End Sub

    Private Sub PicFAQ_MouseUp(sender As Object, e As MouseEventArgs) Handles PicFAQ.MouseUp
        PicFAQ.Image = New Bitmap(My.Resources.FAQbtnPNG)
    End Sub
#End Region

#Region "Hiding Help Sub Panel"
    Private Sub PicHelpContent_MouseEnter(sender As Object, e As EventArgs) Handles PicHelpContent.MouseEnter
        HelpSubPanel.Hide() 'This hides the help sub panel when the user hovers over the picturebox
    End Sub

    Private Sub FrmHelp_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        HelpSubPanel.Hide() 'This hides the help sub panel when the user hovers over the form
    End Sub
#End Region

#Region "How To Login"
    Private Sub PicHowToLogin_Click(sender As Object, e As EventArgs) Handles PicHowToLogin.Click
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While

        HelpSubPanel.Hide()
        PicHelpContent.Visible = True
        PicHelpContent.Image = New Bitmap(My.Resources.HowDoILoginContentPNG)
    End Sub

    Private Sub PicHowToLogin_MouseEnter(sender As Object, e As EventArgs) Handles PicHowToLogin.MouseEnter
        PicHowToLogin.Image = New Bitmap(My.Resources.HowDoILoginRolloverPNG)
    End Sub

    Private Sub PicHowToLogin_MouseLeave(sender As Object, e As EventArgs) Handles PicHowToLogin.MouseLeave
        PicHowToLogin.Image = New Bitmap(My.Resources.HowDoILoginPNG)
    End Sub

    Private Sub PicHowToLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles PicHowToLogin.MouseDown
        PicHowToLogin.Image = New Bitmap(My.Resources.HowDoILoginMouseDownPNG)
    End Sub

    Private Sub PicHowToLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles PicHowToLogin.MouseUp
        PicHowToLogin.Image = New Bitmap(My.Resources.HowDoILoginPNG)
    End Sub
#End Region

#Region "How To Register"
    Private Sub PicHowToRegister_Click(sender As Object, e As EventArgs) Handles PicHowToRegister.Click
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While

        HelpSubPanel.Hide()
        PicHelpContent.Visible = True
        PicHelpContent.Image = New Bitmap(My.Resources.HowDoIRegisterContentPNG)
    End Sub

    Private Sub PicHowToRegister_MouseEnter(sender As Object, e As EventArgs) Handles PicHowToRegister.MouseEnter
        PicHowToRegister.Image = New Bitmap(My.Resources.HowDoIRegisterRolloverPNG)
    End Sub

    Private Sub PicHowToRegister_MouseLeave(sender As Object, e As EventArgs) Handles PicHowToRegister.MouseLeave
        PicHowToRegister.Image = New Bitmap(My.Resources.HowDoIRegisterPNG)
    End Sub

    Private Sub PicHowToRegister_MouseDown(sender As Object, e As MouseEventArgs) Handles PicHowToRegister.MouseDown
        PicHowToRegister.Image = New Bitmap(My.Resources.HowDoIRegisterMouseDownPNG)
    End Sub

    Private Sub PicHowToRegister_MouseUp(sender As Object, e As MouseEventArgs) Handles PicHowToRegister.MouseUp
        PicHowToRegister.Image = New Bitmap(My.Resources.HowDoIRegisterPNG)
    End Sub
#End Region

#Region "How To Create an Order"
    Private Sub PicHowToOrder_Click(sender As Object, e As EventArgs) Handles PicHowToOrder.Click
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While

        HelpSubPanel.Hide()
        PicHelpContent.Visible = True
        PicHelpContent.Image = New Bitmap(My.Resources.HowDoICreateAnOrderContentPNG)
    End Sub

    Private Sub PicHowToOrder_MouseEnter(sender As Object, e As EventArgs) Handles PicHowToOrder.MouseEnter
        PicHowToOrder.Image = New Bitmap(My.Resources.HowDoICreateAnOrderRolloverPNG)
    End Sub

    Private Sub PicHowToOrder_MouseLeave(sender As Object, e As EventArgs) Handles PicHowToOrder.MouseLeave
        PicHowToOrder.Image = New Bitmap(My.Resources.HowDoICreateAnOrderPNG)
    End Sub

    Private Sub PicHowToOrder_MouseDown(sender As Object, e As MouseEventArgs) Handles PicHowToOrder.MouseDown
        PicHowToOrder.Image = New Bitmap(My.Resources.HowDoICreateAnOrderMouseDownPNG)
    End Sub

    Private Sub PicHowToOrder_MouseUp(sender As Object, e As MouseEventArgs) Handles PicHowToOrder.MouseUp
        PicHowToOrder.Image = New Bitmap(My.Resources.HowDoICreateAnOrderPNG)
    End Sub
#End Region

#Region "How To Remove an Item"
    Private Sub PicHowToRemoveItem_Click(sender As Object, e As EventArgs) Handles PicHowToRemoveItem.Click
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While

        HelpSubPanel.Hide()
        PicHelpContent.Visible = True
        PicHelpContent.Image = New Bitmap(My.Resources.HowDoIRemoveAnItemContentPNG)
    End Sub

    Private Sub PicHowToRemoveItem_MouseEnter(sender As Object, e As EventArgs) Handles PicHowToRemoveItem.MouseEnter
        PicHowToRemoveItem.Image = New Bitmap(My.Resources.HowDoIRemoveAnItemRolloverPNG)
    End Sub

    Private Sub PicHowToRemoveItem_MouseLeave(sender As Object, e As EventArgs) Handles PicHowToRemoveItem.MouseLeave
        PicHowToRemoveItem.Image = New Bitmap(My.Resources.HowDoIRemoveAnItemPNG)
    End Sub

    Private Sub PicHowToRemoveItem_MouseDown(sender As Object, e As MouseEventArgs) Handles PicHowToRemoveItem.MouseDown
        PicHowToRemoveItem.Image = New Bitmap(My.Resources.HowDoIRemoveAnItemMouseDownPNG)
    End Sub

    Private Sub PicHowToRemoveItem_MouseUp(sender As Object, e As MouseEventArgs) Handles PicHowToRemoveItem.MouseUp
        PicHowToRemoveItem.Image = New Bitmap(My.Resources.HowDoIRemoveAnItemPNG)
    End Sub
#End Region

#Region "How To Pay For an Order"
    Private Sub PicHowToPayOrder_Click(sender As Object, e As EventArgs) Handles PicHowToPayOrder.Click
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While

        HelpSubPanel.Hide()
        PicHelpContent.Visible = True
        PicHelpContent.Image = New Bitmap(My.Resources.HowDoIPayForAnOrderContentPNG)
    End Sub

    Private Sub PicHowToPayOrder_MouseEnter(sender As Object, e As EventArgs) Handles PicHowToPayOrder.MouseEnter
        PicHowToPayOrder.Image = New Bitmap(My.Resources.HowDoIPayForAnOrderRolloverPNG)
    End Sub

    Private Sub PicHowToPayOrder_MouseLeave(sender As Object, e As EventArgs) Handles PicHowToPayOrder.MouseLeave
        PicHowToPayOrder.Image = New Bitmap(My.Resources.HowDoIPayForAnOrderPNG)
    End Sub

    Private Sub PicHowToPayOrder_MouseDown(sender As Object, e As MouseEventArgs) Handles PicHowToPayOrder.MouseDown
        PicHowToPayOrder.Image = New Bitmap(My.Resources.HowDoIPayForAnOrderMouseDownPNG)
    End Sub

    Private Sub PicHowToPayOrder_MouseUp(sender As Object, e As MouseEventArgs) Handles PicHowToPayOrder.MouseUp
        PicHowToPayOrder.Image = New Bitmap(My.Resources.HowDoIPayForAnOrderPNG)
    End Sub
#End Region

#Region "How To Clear an Order"
    Private Sub PicHowToClearOrder_Click(sender As Object, e As EventArgs) Handles PicHowToClearOrder.Click
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While

        HelpSubPanel.Hide()
        PicHelpContent.Visible = True
        PicHelpContent.Image = New Bitmap(My.Resources.HowDoIClearAnOrderContentPNG)
    End Sub

    Private Sub PicHowToClearOrder_MouseEnter(sender As Object, e As EventArgs) Handles PicHowToClearOrder.MouseEnter
        PicHowToClearOrder.Image = New Bitmap(My.Resources.HowDoIClearAnOrderRolloverPNG)
    End Sub

    Private Sub PicHowToClearOrder_MouseLeave(sender As Object, e As EventArgs) Handles PicHowToClearOrder.MouseLeave
        PicHowToClearOrder.Image = New Bitmap(My.Resources.HowDoIClearAnOrderPNG)
    End Sub

    Private Sub PicHowToClearOrder_MouseDown(sender As Object, e As MouseEventArgs) Handles PicHowToClearOrder.MouseDown
        PicHowToClearOrder.Image = New Bitmap(My.Resources.HowDoIClearAnOrderMouseDownPNG)
    End Sub

    Private Sub PicHowToClearOrder_MouseUp(sender As Object, e As MouseEventArgs) Handles PicHowToClearOrder.MouseUp
        PicHowToClearOrder.Image = New Bitmap(My.Resources.HowDoIClearAnOrderPNG)
    End Sub
#End Region

#Region "How To View The Receipt"
    Private Sub PicHowToViewReceipt_Click(sender As Object, e As EventArgs) Handles PicHowToViewReceipt.Click
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While

        HelpSubPanel.Hide()
        PicHelpContent.Visible = True
        PicHelpContent.Image = New Bitmap(My.Resources.HowDoIViewTheReceiptContentPNG)
    End Sub

    Private Sub PicHowToViewReceipt_MouseEnter(sender As Object, e As EventArgs) Handles PicHowToViewReceipt.MouseEnter
        PicHowToViewReceipt.Image = New Bitmap(My.Resources.HowDoIViewTheReceiptRolloverPNG)
    End Sub

    Private Sub PicHowToViewReceipt_MouseLeave(sender As Object, e As EventArgs) Handles PicHowToViewReceipt.MouseLeave
        PicHowToViewReceipt.Image = New Bitmap(My.Resources.HowDoIViewTheReceiptPNG)
    End Sub

    Private Sub PicHowToViewReceipt_MouseDown(sender As Object, e As MouseEventArgs) Handles PicHowToViewReceipt.MouseDown
        PicHowToViewReceipt.Image = New Bitmap(My.Resources.HowDoIViewTheReceiptMouseDownPNG)
    End Sub

    Private Sub PicHowToViewReceipt_MouseUp(sender As Object, e As MouseEventArgs) Handles PicHowToViewReceipt.MouseUp
        PicHowToViewReceipt.Image = New Bitmap(My.Resources.HowDoIViewTheReceiptPNG)
    End Sub
#End Region

#Region "How To Print The Receipt"
    Private Sub PicHowToPrintReceipt_Click(sender As Object, e As EventArgs) Handles PicHowToPrintReceipt.Click
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While

        HelpSubPanel.Hide()
        PicHelpContent.Visible = True
        PicHelpContent.Image = New Bitmap(My.Resources.HowDoIPrintTheReceiptContentPNG)
    End Sub

    Private Sub PicHowToPrintReceipt_MouseEnter(sender As Object, e As EventArgs) Handles PicHowToPrintReceipt.MouseEnter
        PicHowToPrintReceipt.Image = New Bitmap(My.Resources.HowDoIPrintTheReceiptRolloverPNG)
    End Sub

    Private Sub PicHowToPrintReceipt_MouseLeave(sender As Object, e As EventArgs) Handles PicHowToPrintReceipt.MouseLeave
        PicHowToPrintReceipt.Image = New Bitmap(My.Resources.HowDoIPrintTheReceiptPNG)
    End Sub

    Private Sub PicHowToPrintReceipt_MouseDown(sender As Object, e As MouseEventArgs) Handles PicHowToPrintReceipt.MouseDown
        PicHowToPrintReceipt.Image = New Bitmap(My.Resources.HowDoIPrintTheReceiptMouseDownPNG)
    End Sub

    Private Sub PicHowToPrintReceipt_MouseUp(sender As Object, e As MouseEventArgs) Handles PicHowToPrintReceipt.MouseUp
        PicHowToPrintReceipt.Image = New Bitmap(My.Resources.HowDoIPrintTheReceiptPNG)
    End Sub
#End Region

#Region "How To Log Out"
    Private Sub PicHowToLogOut_Click(sender As Object, e As EventArgs) Handles PicHowToLogOut.Click
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While

        HelpSubPanel.Hide()
        PicHelpContent.Visible = True
        PicHelpContent.Image = New Bitmap(My.Resources.HowDoILogOutContentPNG)
    End Sub

    Private Sub PicHowToLogOut_MouseEnter(sender As Object, e As EventArgs) Handles PicHowToLogOut.MouseEnter
        PicHowToLogOut.Image = New Bitmap(My.Resources.HowDoILogoutRolloverPNG)
    End Sub

    Private Sub PicHowToLogOut_MouseLeave(sender As Object, e As EventArgs) Handles PicHowToLogOut.MouseLeave
        PicHowToLogOut.Image = New Bitmap(My.Resources.HowDoILogoutPNG)
    End Sub

    Private Sub PicHowToLogOut_MouseDown(sender As Object, e As MouseEventArgs) Handles PicHowToLogOut.MouseDown
        PicHowToLogOut.Image = New Bitmap(My.Resources.HowDoILogoutMouseDownPNG)
    End Sub

    Private Sub PicHowToLogOut_MouseUp(sender As Object, e As MouseEventArgs) Handles PicHowToLogOut.MouseUp
        PicHowToLogOut.Image = New Bitmap(My.Resources.HowDoILogoutPNG)
    End Sub
#End Region

#Region "How To Exit The Application"
    Private Sub PicHowToExitApp_Click(sender As Object, e As EventArgs) Handles PicHowToExitApp.Click
        While (PicSlidingPanel.Width > 10)
            PicSlidingPanel.Width -= 1
            PicSlidingPanel.Hide()
            PicHelp.Hide()
            PicTroubleshooting.Hide()
            PicFAQ.Hide()
            PicMenuButton.Show()
            PicExitPanel.Hide()
        End While

        HelpSubPanel.Hide()
        PicHelpContent.Visible = True
        PicHelpContent.Image = New Bitmap(My.Resources.HowDoIExitTheApplicationContentPNG)
    End Sub

    Private Sub PicHowToExitApp_MouseEnter(sender As Object, e As EventArgs) Handles PicHowToExitApp.MouseEnter
        PicHowToExitApp.Image = New Bitmap(My.Resources.HowDoIExitTheApplicationRolloverPNG)
    End Sub

    Private Sub PicHowToExitApp_MouseLeave(sender As Object, e As EventArgs) Handles PicHowToExitApp.MouseLeave
        PicHowToExitApp.Image = New Bitmap(My.Resources.HowDoIExitTheApplicationPNG)
    End Sub

    Private Sub PicHowToExitApp_MouseDown(sender As Object, e As MouseEventArgs) Handles PicHowToExitApp.MouseDown
        PicHowToExitApp.Image = New Bitmap(My.Resources.HowDoIExitTheApplicationMouseDownPNG)
    End Sub

    Private Sub PicHowToExitApp_MouseUp(sender As Object, e As MouseEventArgs) Handles PicHowToExitApp.MouseUp
        PicHowToExitApp.Image = New Bitmap(My.Resources.HowDoIExitTheApplicationPNG)
    End Sub
#End Region

End Class