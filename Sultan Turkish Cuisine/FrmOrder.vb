Public Class FrmOrder

    'Sultan Turkish Cuisine
    'Order Form
    'Programmed By S Rahman
    '05/05/18
    '------------------------------------------------------------------------------------------------------------------------------------

    Dim StyleForMe As String = "{0,-25}{1,-10} {2,-7} {3,-5}" 'This global variable stores
    'and locates the index column of the listbox, and counts the space for the width

    Public MixShishPrice As Single = 8.5
    Public ChickenIskenderPrice As Single = 9.5
    Public LambChopsPrice As Single = 9.99
    Public StrawberryMojitoPrice As Single = 2.2  'These global variables represent the price for each set meal, drink, and dessert
    Public TurkishTeaPrice As Single = 1.0
    Public TurkishCoffeePrice As Single = 2.2
    Public ChocolateCheesecakePrice As Single = 4.0
    Public TurkishDelightsPrice As Single = 4.4
    Public StrawberryCheesecakePrice As Single = 4.0

    Public MixShishQuantity As Integer
    Public ChickenIskenderQuantity As Integer
    Public LambChopsQuantity As Integer
    Public StrawberryMojitoQuantity As Integer  'These global variables represent the quantity for each set meal, drink, and dessert
    Public TurkishTeaQuantity As Integer
    Public TurkishCoffeeQuantity As Integer
    Public ChocolateCheesecakeQuantity As Integer
    Public TurkishDelightsQuantity As Integer
    Public StrawberryCheesecakeQuantity As Integer

    Public MixShishTotal As Single
    Public ChickenIskenderTotal As Single
    Public LambChopsTotal As Single
    Public StrawberryMojitoTotal As Single  'These global variables represent the total price for each set meal, drink, and dessert
    Public TurkishTeaTotal As Single
    Public TurkishCoffeeTotal As Single
    Public ChocolateCheesecakeTotal As Single
    Public TurkishDelightTotal As Single
    Public StrawberryCheesecakeTotal As Single

    Public OrderTotalSub As Single 'This global variable represents the subtotal of the entire order
    Public ValueAddedTax As Single 'This global variable represents the VAT of the entire order
    Public OrderTotalGrand As Single 'This global variable represents the grandtotal of the entire order
    Public CustomerPaid As Single 'This global variable represents the payment made by the customer
    Public ChangeDue As Single 'The global variable represents the change received from the given payment

    Private Sub FrmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0 'Sets the next forms (Order Form) opacity as 0 
        Dim FadeIn As New Timer 'Creates a new timer variable
        FadeIn.Interval = 100 'Sets the timer interval as 100
        FadeIn.Start() 'Starts the timer variable
        AddHandler FadeIn.Tick, Sub() 'Creates a nested sub routine within the current subroutine, controlling the timer
                                    Me.Opacity += 0.1 'Increases the opacity of the Order Form by 0.18
                                    If Me.Opacity = 1 Then 'When the opacity reaches 0, the Order Form is displayed and the timer stops
                                        FadeIn.Stop()
                                        FadeIn.Dispose() 'Gets rid of the timer
                                    End If
                                End Sub
        lblUsername.Text = My.Settings.UserName 'This displays the name of the user by retrieving the data from the data stored in settings database
    End Sub

    Private Sub FrmOrderTotalFigures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This condition allows the subtotal, VAT, grandtotal and change due to appear as nothing or £0.00 when the order form is loaded
        If txtGrandTotal.Text = String.Empty Then
            lblSubtotalFigure.Text = "£0.00"
            lblVATFigure.Text = "£0.00"
            txtGrandTotal.Text = "£0.00"
            txtChangeDue.Text = ""
        End If
    End Sub

#Region "Form Closed Event"
    Private Sub FrmOrder_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit() 'Exits the application
    End Sub
#End Region

#Region "Real Time Timer"
    Private Sub RealTime_Tick(sender As Object, e As EventArgs) Handles RealTime.Tick
        lblRealTime.Text = Format(Now, "dd" & " " & "MMM" & " " & "yyyy" & "    " & "H:mm") 'This code allows
        'the date and time to be formatted and displayed in real time
    End Sub
#End Region

#Region "List View String Format"
    Private Sub lstViewOrder_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lstViewOrder.DrawItem
        e.DrawBackground()
        e.Graphics.DrawString(lstViewOrder.Items(e.Index).ToString(), New Font("Consolas", 8.5, FontStyle.Regular), Brushes.Black, e.Bounds)
        e.DrawFocusRectangle()
        'This block of code allows the list box to be drawn precisely with the given index values as well as the use of a custom font style,
        'font size and colour.
    End Sub
#End Region

#Region "Mix Shish"
    Private Sub PicMixShishAdd_Click(sender As Object, e As EventArgs) Handles PicMixShishAdd.Click
        Dim Click1 As String 'This local variable stores the Mix Shish item in a string format
        'when the user clicks the Add button
        txtQtyMixShish.Text += 1 'This code increments the text box amount of Mix Shish each time the Add button is clicked
        MixShishQuantity = txtQtyMixShish.Text 'This code assigns the textbox quantity onto the variable quantity
        MixShishTotal = MixShishPrice * MixShishQuantity 'This code calculates the total price by multiplying the quantity of Mix Shish by the original price
        Click1 = String.Format(StyleForMe, "   Mix Shish", FormatCurrency(MixShishPrice), MixShishQuantity, FormatCurrency(MixShishTotal))
        'This line of code displays the items in a string sequence onto the listbox according to its index column

        If txtQtyMixShish.Text >= 1 Then 'This condition states that if the user clicks the Add button more than once, the selected index of that
            'column should locate the new string and replace it with the previous one, allowing the quantity to be incremented on the same column
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Mix Shish") 'Locates the string
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem) 'Removes the duplicate item
            lstViewOrder.Items.Add(Click1) 'String is added again on the same row of the listbox
        End If
    End Sub

    Private Sub PicMixShishAdd_MouseEnter(sender As Object, e As EventArgs) Handles PicMixShishAdd.MouseEnter
        PicMixShishAdd.Image = New Bitmap(My.Resources.MixShishAddBtnRollover) 'This code changes the image when the button is hovered over
    End Sub

    Private Sub PicMixShishAdd_MouseLeave(sender As Object, e As EventArgs) Handles PicMixShishAdd.MouseLeave
        PicMixShishAdd.Image = New Bitmap(My.Resources.MixShishAddBtn) 'This code changes the button back to its original state when the mouse has left
    End Sub

    Private Sub PicMixShishRemove_Click(sender As Object, e As EventArgs) Handles PicMixShishRemove.Click
        Dim Click1 As String 'This local variable stores the Mix Shish item in a string format
        'when the user clicks the Remove button
        txtQtyMixShish.Text -= 1 'This code decrements the text box amount of Mix Shish each time the Remove button is clicked
        MixShishQuantity -= 1 'This code decrements the variable quantity of Mix Shish
        MixShishTotal = MixShishPrice * MixShishQuantity 'This code changes the total price automatically by multiplying the quantity of Mix Shish by its original price
        Click1 = String.Format(StyleForMe, "   Mix Shish", FormatCurrency(MixShishPrice), MixShishQuantity, FormatCurrency(MixShishTotal))
        'This line of code displays the items in a string sequence onto the listbox according to its index column

        If txtQtyMixShish.Text >= 1 Then 'This condition states that if the user clicks the Remove button more than once, the selected index of that
            'column should locate the new string and replace it with the previous one, allowing the quantity to be decremented on the same column
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Mix Shish")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click1)
        End If

        If txtQtyMixShish.Text < 1 Then 'This condition states that if the quantity of the Mix Shish is below 1
            'the selected index of that column should locate the current string, and completely remove it
            txtQtyMixShish.Text = 0 'The textbox quantity is reset to 0
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Mix Shish") 'Locates the string
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem) 'Removes the string completely
        End If
    End Sub

    Private Sub PicMixShishRemove_MouseEnter(sender As Object, e As EventArgs) Handles PicMixShishRemove.MouseEnter
        PicMixShishRemove.Image = New Bitmap(My.Resources.MixShishRemoveBtnRollover) 'This code changes the image when the button is hovered over
    End Sub

    Private Sub PicMixShishRemove_MouseLeave(sender As Object, e As EventArgs) Handles PicMixShishRemove.MouseLeave
        PicMixShishRemove.Image = New Bitmap(My.Resources.MixShishRemoveBtn) 'This code changes the button back to its original state when the mouse has left
    End Sub
#End Region

#Region "Chicken Iskender"
    Private Sub PicAddIskender_Click(sender As Object, e As EventArgs) Handles PicIskenderAdd.Click
        Dim Click2 As String
        txtQtyIskender.Text += 1
        ChickenIskenderQuantity = txtQtyIskender.Text
        ChickenIskenderTotal = ChickenIskenderPrice * ChickenIskenderQuantity
        Click2 = String.Format(StyleForMe, "   Chicken Iskender", FormatCurrency(ChickenIskenderPrice), ChickenIskenderQuantity, FormatCurrency(ChickenIskenderTotal))
        If txtQtyIskender.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Chicken Iskender")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click2)
        End If
    End Sub

    Private Sub PicAddIskender_MouseEnter(sender As Object, e As EventArgs) Handles PicIskenderAdd.MouseEnter
        PicIskenderAdd.Image = New Bitmap(My.Resources.ChickenIskenderAddBtnRollover)
    End Sub

    Private Sub PicAddIskender_MouseLeave(sender As Object, e As EventArgs) Handles PicIskenderAdd.MouseLeave
        PicIskenderAdd.Image = New Bitmap(My.Resources.ChickenIskenderAddBtn)
    End Sub

    Private Sub PicRemoveIskender_Click(sender As Object, e As EventArgs) Handles PicIskenderRemove.Click
        Dim Click2 As String
        txtQtyIskender.Text -= 1
        ChickenIskenderQuantity -= 1
        ChickenIskenderTotal = ChickenIskenderPrice * ChickenIskenderQuantity
        Click2 = String.Format(StyleForMe, "   Chicken Iskender", FormatCurrency(ChickenIskenderPrice), ChickenIskenderQuantity, FormatCurrency(ChickenIskenderTotal))
        If txtQtyIskender.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Chicken Iskender")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click2)
        End If
        If txtQtyIskender.Text < 1 Then
            txtQtyIskender.Text = 0
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Chicken Iskender")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
        End If
    End Sub

    Private Sub PicRemoveIskender_MouseEnter(sender As Object, e As EventArgs) Handles PicIskenderRemove.MouseEnter
        PicIskenderRemove.Image = New Bitmap(My.Resources.ChickenIskenderRemoveBtnRollover)
    End Sub

    Private Sub PicRemoveIskender_MouseLeave(sender As Object, e As EventArgs) Handles PicIskenderRemove.MouseLeave
        PicIskenderRemove.Image = New Bitmap(My.Resources.ChickenIskenderRemoveBtn)
    End Sub
#End Region

#Region "Lamb Chops"
    Private Sub PicAddLambChops_Click(sender As Object, e As EventArgs) Handles PicLambChopsAdd.Click
        Dim Click3 As String
        txtQtyLambChops.Text += 1
        LambChopsQuantity = txtQtyLambChops.Text
        LambChopsTotal = LambChopsPrice * LambChopsQuantity
        Click3 = String.Format(StyleForMe, "   Lamb Chops", FormatCurrency(LambChopsPrice), LambChopsQuantity, FormatCurrency(LambChopsTotal))
        If txtQtyLambChops.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Lamb Chops")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click3)
        End If
    End Sub

    Private Sub PicAddLambChops_MouseEnter(sender As Object, e As EventArgs) Handles PicLambChopsAdd.MouseEnter
        PicLambChopsAdd.Image = New Bitmap(My.Resources.LambChopsAddBtnRollover)
    End Sub

    Private Sub PicAddLambChops_MouseLeave(sender As Object, e As EventArgs) Handles PicLambChopsAdd.MouseLeave
        PicLambChopsAdd.Image = New Bitmap(My.Resources.LambChopsAddBtn)
    End Sub

    Private Sub PicRemoveLambChops_Click(sender As Object, e As EventArgs) Handles PicLambChopsRemove.Click
        Dim Click3 As String
        txtQtyLambChops.Text -= 1
        LambChopsQuantity -= 1
        LambChopsTotal = LambChopsPrice * LambChopsQuantity
        Click3 = String.Format(StyleForMe, "   Lamb Chops", FormatCurrency(LambChopsPrice), LambChopsQuantity, FormatCurrency(LambChopsTotal))
        If txtQtyLambChops.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Lamb Chops")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click3)
        End If
        If txtQtyLambChops.Text < 1 Then
            txtQtyLambChops.Text = 0
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Lamb Chops")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
        End If
    End Sub

    Private Sub PicRemoveLambChops_MouseEnter(sender As Object, e As EventArgs) Handles PicLambChopsRemove.MouseEnter
        PicLambChopsRemove.Image = New Bitmap(My.Resources.LambChopsRemoveBtnRollover)
    End Sub

    Private Sub PicRemoveLambChops_MouseLeave(sender As Object, e As EventArgs) Handles PicLambChopsRemove.MouseLeave
        PicLambChopsRemove.Image = New Bitmap(My.Resources.LambChopsRemoveBtn)
    End Sub
#End Region

#Region "Strawberry Mojito"
    Private Sub PicStrawMojitoAdd_Click(sender As Object, e As EventArgs) Handles PicStrawMojitoAdd.Click
        Dim Click4 As String
        txtQtyStrawMojito.Text += 1
        StrawberryMojitoQuantity = txtQtyStrawMojito.Text
        StrawberryMojitoTotal = StrawberryMojitoPrice * StrawberryMojitoQuantity
        Click4 = String.Format(StyleForMe, "   Strawberry Mojito", FormatCurrency(StrawberryMojitoPrice), StrawberryMojitoQuantity, FormatCurrency(StrawberryMojitoTotal))
        If txtQtyStrawMojito.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Strawberry Mojito")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click4)
        End If
    End Sub

    Private Sub PicStrawMojitoAdd_MouseEnter(sender As Object, e As EventArgs) Handles PicStrawMojitoAdd.MouseEnter
        PicStrawMojitoAdd.Image = New Bitmap(My.Resources.StrawberryMojitoAddBtnRollover)
    End Sub

    Private Sub PicStrawMojitoAdd_MouseLeave(sender As Object, e As EventArgs) Handles PicStrawMojitoAdd.MouseLeave
        PicStrawMojitoAdd.Image = New Bitmap(My.Resources.StrawberryMojitoAddBtn)
    End Sub
    Private Sub PicStrawMojitoRemove_Click(sender As Object, e As EventArgs) Handles PicStrawMojitoRemove.Click
        Dim Click4 As String
        txtQtyStrawMojito.Text -= 1
        StrawberryMojitoQuantity -= 1
        StrawberryMojitoTotal = StrawberryMojitoPrice * StrawberryMojitoQuantity
        Click4 = String.Format(StyleForMe, "   Strawberry Mojito", FormatCurrency(StrawberryMojitoPrice), StrawberryMojitoQuantity, FormatCurrency(StrawberryMojitoTotal))
        If txtQtyStrawMojito.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Strawberry Mojito")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click4)
        End If
        If txtQtyStrawMojito.Text < 1 Then
            txtQtyStrawMojito.Text = 0
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Strawberry Mojito")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
        End If
    End Sub

    Private Sub PicStrawMojitoRemove_MouseEnter(sender As Object, e As EventArgs) Handles PicStrawMojitoRemove.MouseEnter
        PicStrawMojitoRemove.Image = New Bitmap(My.Resources.StrawberryMojitoRemoveBtnRollover)
    End Sub

    Private Sub PicStrawMojitoRemove_MouseLeave(sender As Object, e As EventArgs) Handles PicStrawMojitoRemove.MouseLeave
        PicStrawMojitoRemove.Image = New Bitmap(My.Resources.StrawberryMojitoRemoveBtn)
    End Sub
#End Region

#Region "Turkish Tea"
    Private Sub PicTurkishTeaAdd_Click(sender As Object, e As EventArgs) Handles PicTurkishTeaAdd.Click
        Dim Click5 As String
        txtQtyTurkishTea.Text += 1
        TurkishTeaQuantity = txtQtyTurkishTea.Text
        TurkishTeaTotal = TurkishTeaPrice * TurkishTeaQuantity
        Click5 = String.Format(StyleForMe, "   Turkish Tea", FormatCurrency(TurkishTeaPrice), TurkishTeaQuantity, FormatCurrency(TurkishTeaTotal))
        If txtQtyTurkishTea.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Turkish Tea")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click5)
        End If
    End Sub

    Private Sub PicTurkishTeaAdd_MouseEnter(sender As Object, e As EventArgs) Handles PicTurkishTeaAdd.MouseEnter
        PicTurkishTeaAdd.Image = New Bitmap(My.Resources.TurkishTeaAddBtnRollover)
    End Sub

    Private Sub PicTurkishTeaAdd_MouseLeave(sender As Object, e As EventArgs) Handles PicTurkishTeaAdd.MouseLeave
        PicTurkishTeaAdd.Image = New Bitmap(My.Resources.TurkishTeaAddBtn)
    End Sub

    Private Sub PicTurkishTeaRemove_Click(sender As Object, e As EventArgs) Handles PicTurkishTeaRemove.Click
        Dim Click5 As String
        txtQtyTurkishTea.Text -= 1
        TurkishTeaQuantity -= 1
        TurkishTeaTotal = TurkishTeaPrice * TurkishTeaQuantity
        Click5 = String.Format(StyleForMe, "   Turkish Tea", FormatCurrency(TurkishTeaPrice), TurkishTeaQuantity, FormatCurrency(TurkishTeaTotal))
        If txtQtyTurkishTea.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Turkish Tea")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click5)
        End If
        If txtQtyTurkishTea.Text < 1 Then
            txtQtyTurkishTea.Text = 0
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Turkish Tea")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
        End If
    End Sub

    Private Sub PicTurkishTeaRemove_MouseEnter(sender As Object, e As EventArgs) Handles PicTurkishTeaRemove.MouseEnter
        PicTurkishTeaRemove.Image = New Bitmap(My.Resources.TurkishTeaRemoveBtnRollover)
    End Sub

    Private Sub PicTurkishTeaRemove_MouseLeave(sender As Object, e As EventArgs) Handles PicTurkishTeaRemove.MouseLeave
        PicTurkishTeaRemove.Image = New Bitmap(My.Resources.TurkishTeaRemoveBtn)
    End Sub
#End Region

#Region "Turkish Coffee"
    Private Sub PicTurkishCoffeeAdd_Click(sender As Object, e As EventArgs) Handles PicTurkishCoffeeAdd.Click
        Dim Click6 As String
        txtQtyTurkishCoffee.Text += 1
        TurkishCoffeeQuantity = txtQtyTurkishCoffee.Text
        TurkishCoffeeTotal = TurkishCoffeePrice * TurkishCoffeeQuantity
        Click6 = String.Format(StyleForMe, "   Turkish Coffee", FormatCurrency(TurkishCoffeePrice), TurkishCoffeeQuantity, FormatCurrency(TurkishCoffeeTotal))
        If txtQtyTurkishCoffee.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Turkish Coffee")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click6)
        End If
    End Sub

    Private Sub PicTurkishCoffeeAdd_MouseEnter(sender As Object, e As EventArgs) Handles PicTurkishCoffeeAdd.MouseEnter
        PicTurkishCoffeeAdd.Image = New Bitmap(My.Resources.TurkishCoffeeAddBtnRollover)
    End Sub

    Private Sub PicTurkishCoffeeAdd_MouseLeave(sender As Object, e As EventArgs) Handles PicTurkishCoffeeAdd.MouseLeave
        PicTurkishCoffeeAdd.Image = New Bitmap(My.Resources.TurkishCoffeeAddBtn)
    End Sub

    Private Sub PicTurkishCoffeeRemove_Click(sender As Object, e As EventArgs) Handles PicTurkishCoffeeRemove.Click
        Dim Click6 As String
        txtQtyTurkishCoffee.Text -= 1
        TurkishCoffeeQuantity -= 1
        TurkishCoffeeTotal = TurkishCoffeePrice * TurkishCoffeeQuantity
        Click6 = String.Format(StyleForMe, "   Turkish Coffee", FormatCurrency(TurkishCoffeePrice), TurkishCoffeeQuantity, FormatCurrency(TurkishCoffeeTotal))
        If txtQtyTurkishCoffee.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Turkish Coffee")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click6)
        End If
        If txtQtyTurkishCoffee.Text < 1 Then
            txtQtyTurkishCoffee.Text = 0
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Turkish Coffee")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
        End If
    End Sub

    Private Sub PicTurkishCoffeeRemove_MouseEnter(sender As Object, e As EventArgs) Handles PicTurkishCoffeeRemove.MouseEnter
        PicTurkishCoffeeRemove.Image = New Bitmap(My.Resources.TurkishCoffeeRemoveBtnRollover)
    End Sub

    Private Sub PicTurkishCoffeeRemove_MouseLeave(sender As Object, e As EventArgs) Handles PicTurkishCoffeeRemove.MouseLeave
        PicTurkishCoffeeRemove.Image = New Bitmap(My.Resources.TurkishCoffeeRemoveBtn)
    End Sub
#End Region

#Region "Chocolate Cheesecake"
    Private Sub PicChocCheesecakeAdd_Click(sender As Object, e As EventArgs) Handles PicChocCheesecakeAdd.Click
        Dim Click7 As String
        txtQtyChocCheesecake.Text += 1
        ChocolateCheesecakeQuantity = txtQtyChocCheesecake.Text
        ChocolateCheesecakeTotal = ChocolateCheesecakePrice * ChocolateCheesecakeQuantity
        Click7 = String.Format(StyleForMe, "   Choc. Cheesecake", FormatCurrency(ChocolateCheesecakePrice), ChocolateCheesecakeQuantity, FormatCurrency(ChocolateCheesecakeTotal))
        If txtQtyChocCheesecake.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Choc. Cheesecake")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click7)
        End If
    End Sub

    Private Sub PicChocCheesecakeAdd_MouseEnter(sender As Object, e As EventArgs) Handles PicChocCheesecakeAdd.MouseEnter
        PicChocCheesecakeAdd.Image = New Bitmap(My.Resources.ChickenIskenderAddBtnRollover)
    End Sub

    Private Sub PicChocCheesecakeAdd_MouseLeave(sender As Object, e As EventArgs) Handles PicChocCheesecakeAdd.MouseLeave
        PicChocCheesecakeAdd.Image = New Bitmap(My.Resources.ChickenIskenderAddBtn)
    End Sub

    Private Sub PicChocCheesecakeRemove_Click(sender As Object, e As EventArgs) Handles PicChocCheesecakeRemove.Click
        Dim Click7 As String
        txtQtyChocCheesecake.Text -= 1
        ChocolateCheesecakeQuantity -= 1
        ChocolateCheesecakeTotal = ChocolateCheesecakePrice * ChocolateCheesecakeQuantity
        Click7 = String.Format(StyleForMe, "   Choc. Cheesecake", FormatCurrency(ChocolateCheesecakePrice), ChocolateCheesecakeQuantity, FormatCurrency(ChocolateCheesecakeTotal))
        If txtQtyChocCheesecake.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Choc. Cheesecake")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click7)
        End If
        If txtQtyChocCheesecake.Text < 1 Then
            txtQtyChocCheesecake.Text = 0
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Choc. Cheesecake")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
        End If
    End Sub

    Private Sub PicChocCheesecakeRemove_MouseEnter(sender As Object, e As EventArgs) Handles PicChocCheesecakeRemove.MouseEnter
        PicChocCheesecakeRemove.Image = New Bitmap(My.Resources.ChocolateCheesecakeRemoveBtnRollover)
    End Sub

    Private Sub PicChocCheesecakeRemove_MouseLeave(sender As Object, e As EventArgs) Handles PicChocCheesecakeRemove.MouseLeave
        PicChocCheesecakeRemove.Image = New Bitmap(My.Resources.ChocolateCheesecakeRemoveBtn)
    End Sub
#End Region

#Region "Turkish Delight"
    Private Sub PicTurkishDelightAdd_Click(sender As Object, e As EventArgs) Handles PicTurkishDelightAdd.Click
        Dim Click8 As String
        txtQtyTurkishDelight.Text += 1
        TurkishDelightsQuantity = txtQtyTurkishDelight.Text
        TurkishDelightTotal = TurkishDelightsPrice * TurkishDelightsQuantity
        Click8 = String.Format(StyleForMe, "   Turkish Delight", FormatCurrency(TurkishDelightsPrice), TurkishDelightsQuantity, FormatCurrency(TurkishDelightTotal))
        If txtQtyTurkishDelight.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Turkish Delight")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click8)
        End If
    End Sub

    Private Sub PicTurkishDelightAdd_MouseEnter(sender As Object, e As EventArgs) Handles PicTurkishDelightAdd.MouseEnter
        PicTurkishDelightAdd.Image = New Bitmap(My.Resources.TurkishDelightAddBtnRollover)
    End Sub

    Private Sub PicTurkishDelightAdd_MouseLeave(sender As Object, e As EventArgs) Handles PicTurkishDelightAdd.MouseLeave
        PicTurkishDelightAdd.Image = New Bitmap(My.Resources.TurkishDelightAddBtn)
    End Sub
    Private Sub PicTurkishDelightRemove_Click(sender As Object, e As EventArgs) Handles PicTurkishDelightRemove.Click
        Dim Click8 As String
        txtQtyTurkishDelight.Text -= 1
        TurkishDelightsQuantity -= 1
        TurkishDelightTotal = TurkishDelightsPrice * TurkishDelightsQuantity
        Click8 = String.Format(StyleForMe, "   Turkish Delight", FormatCurrency(TurkishDelightsPrice), TurkishDelightsQuantity, FormatCurrency(TurkishDelightTotal))
        If txtQtyTurkishDelight.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Turkish Delight")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click8)
        End If
        If txtQtyTurkishDelight.Text < 1 Then
            txtQtyTurkishDelight.Text = 0
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Turkish Delight")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)

        End If
    End Sub

    Private Sub PicTurkishDelightRemove_MouseEnter(sender As Object, e As EventArgs) Handles PicTurkishDelightRemove.MouseEnter
        PicTurkishDelightRemove.Image = New Bitmap(My.Resources.TurkishDelightRemoveBtnRollover)
    End Sub

    Private Sub PicTurkishDelightRemove_MouseLeave(sender As Object, e As EventArgs) Handles PicTurkishDelightRemove.MouseLeave
        PicTurkishDelightRemove.Image = New Bitmap(My.Resources.TurkishDelightRemoveBtn)
    End Sub
#End Region

#Region "Strawberry Cheesecake"
    Private Sub PicStrawCheesecakeAdd_Click(sender As Object, e As EventArgs) Handles PicStrawCheesecakeAdd.Click
        Dim Click9 As String
        txtQtyStrawCheesecake.Text += 1
        StrawberryCheesecakeQuantity = txtQtyStrawCheesecake.Text
        StrawberryCheesecakeTotal = StrawberryCheesecakePrice * StrawberryCheesecakeQuantity
        Click9 = String.Format(StyleForMe, "   Straw. Cheesecake", FormatCurrency(StrawberryCheesecakePrice), StrawberryCheesecakeQuantity, FormatCurrency(StrawberryCheesecakeTotal))
        If txtQtyStrawCheesecake.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Straw. Cheesecake")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click9)
        End If
    End Sub

    Private Sub PicStrawCheesecakeAdd_MouseEnter(sender As Object, e As EventArgs) Handles PicStrawCheesecakeAdd.MouseEnter
        PicStrawCheesecakeAdd.Image = New Bitmap(My.Resources.StrawberryCheesecakeAddBtnRollover)
    End Sub

    Private Sub PicStrawCheesecakeAdd_MouseLeave(sender As Object, e As EventArgs) Handles PicStrawCheesecakeAdd.MouseLeave
        PicStrawCheesecakeAdd.Image = New Bitmap(My.Resources.StrawberryCheesecakeAddBtn)
    End Sub

    Private Sub PicStrawCheesecakeRemove_Click(sender As Object, e As EventArgs) Handles PicStrawCheesecakeRemove.Click
        Dim Click9 As String
        txtQtyStrawCheesecake.Text -= 1
        StrawberryCheesecakeQuantity -= 1
        StrawberryCheesecakeTotal = StrawberryCheesecakePrice * StrawberryCheesecakeQuantity
        Click9 = String.Format(StyleForMe, "   Straw. Cheesecake", FormatCurrency(StrawberryCheesecakePrice), StrawberryCheesecakeQuantity, FormatCurrency(StrawberryCheesecakeTotal))
        If txtQtyStrawCheesecake.Text >= 1 Then
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Straw. Cheesecake")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
            lstViewOrder.Items.Add(Click9)
        End If
        If txtQtyStrawCheesecake.Text < 1 Then
            txtQtyStrawCheesecake.Text = 0
            lstViewOrder.SelectedIndex = lstViewOrder.FindString("   Straw. Cheesecake")
            lstViewOrder.Items.Remove(lstViewOrder.SelectedItem)
        End If
    End Sub

    Private Sub PicStrawCheesecakeRemove_MouseEnter(sender As Object, e As EventArgs) Handles PicStrawCheesecakeRemove.MouseEnter
        PicStrawCheesecakeRemove.Image = New Bitmap(My.Resources.StrawberryCheesecakeRemoveBtnRollover)
    End Sub

    Private Sub PicStrawCheesecakeRemove_MouseLeave(sender As Object, e As EventArgs) Handles PicStrawCheesecakeRemove.MouseLeave
        PicStrawCheesecakeRemove.Image = New Bitmap(My.Resources.StrawberryCheesecakeRemoveBtn)
    End Sub
#End Region

#Region "Exit Application"
    Private Sub PicExit_Click(sender As Object, e As EventArgs) Handles PicExit.Click
        Application.Exit() 'This code exits the application
    End Sub

    Private Sub PicExit_MouseEnter(sender As Object, e As EventArgs) Handles PicExit.MouseEnter
        PicExit.Image = New Bitmap(My.Resources.btnExitRolloverPNG) 'This changes the state of the picture button when the user hovers over it
    End Sub

    Private Sub PicExit_MouseLeave(sender As Object, e As EventArgs) Handles PicExit.MouseLeave
        PicExit.Image = New Bitmap(My.Resources.btnExitPNG) 'This changes the state of the picture button when the user leaves the picture button
    End Sub

    Private Sub PicExit_MouseDown(sender As Object, e As MouseEventArgs) Handles PicExit.MouseDown
        PicExit.Image = New Bitmap(My.Resources.btnExitMouseDownPNG) 'This changes the state of the picture button when the user clicks down on it
    End Sub

    Private Sub PicExit_MouseUp(sender As Object, e As MouseEventArgs) Handles PicExit.MouseUp
        PicExit.Image = New Bitmap(My.Resources.btnExitPNG) 'This changes the state of the picture button when the user leaves the picture button
    End Sub
#End Region

#Region "Log Out"
    Private Sub PicLogOut_Click(sender As Object, e As EventArgs) Handles PicLogOut.Click
        Beep() 'This makes a beep noise
        FrmConfirmDialogueLogOut.TopMost = True 'This brings the confirmation dialogue box to the front
        FrmConfirmDialogueLogOut.Show() 'This displays the confirmation dialogue box
    End Sub

    Private Sub PicLogOut_MouseEnter(sender As Object, e As EventArgs) Handles PicLogOut.MouseEnter
        PicLogOut.Image = New Bitmap(My.Resources.btnLogOutRolloverPNG) 'This changes the state of the picture button when the user hovers over it
    End Sub

    Private Sub PicLogOut_MouseLeave(sender As Object, e As EventArgs) Handles PicLogOut.MouseLeave
        PicLogOut.Image = New Bitmap(My.Resources.btnLogOutPNG) 'This changes the state of the picture button when the user leaves the picture button
    End Sub

    Private Sub PicLogOut_MouseDown(sender As Object, e As MouseEventArgs) Handles PicLogOut.MouseDown
        PicLogOut.Image = New Bitmap(My.Resources.btnLogOutMouseDownPNG) 'This changes the state of the picture button when the user clicks down on it
    End Sub

    Private Sub PicLogOut_MouseUp(sender As Object, e As MouseEventArgs) Handles PicLogOut.MouseUp
        PicLogOut.Image = New Bitmap(My.Resources.btnLogOutPNG) 'This changes the state of the picture button when the user clicks up from the picture button
    End Sub
#End Region

#Region "Clear All"
    Private Sub PicClearAll_Click(sender As Object, e As EventArgs) Handles PicClearAll.Click
        lstViewOrder.Items.Clear() 'This line of code allows the entire listbox to be cleared
        txtCustomerPaid.Text = ""
        txtChangeDue.Text = ""

        MixShishTotal = 0
        ChickenIskenderTotal = 0
        LambChopsTotal = 0
        StrawberryMojitoTotal = 0
        TurkishTeaTotal = 0      'This block of code resets the total variables to 0
        TurkishCoffeeTotal = 0
        ChocolateCheesecakeTotal = 0
        TurkishDelightTotal = 0
        StrawberryCheesecakeTotal = 0

        OrderTotalGrand = 0
        CustomerPaid = 0  'This block of code resets the grandtotal, customer paid, and change due variables to 0
        ChangeDue = 0

        txtQtyMixShish.Text = 0
        txtQtyIskender.Text = 0
        txtQtyLambChops.Text = 0
        txtQtyStrawMojito.Text = 0
        txtQtyTurkishTea.Text = 0 'This block of code resets the quantity textboxes to 0
        txtQtyTurkishCoffee.Text = 0
        txtQtyChocCheesecake.Text = 0
        txtQtyTurkishDelight.Text = 0
        txtQtyStrawCheesecake.Text = 0

        lblSubtotalFigure.Text = "£0.00" 'This resets the subtotal textbox to £0.00
        lblVATFigure.Text = "£0.00" 'This resets the VAT textbox to £0.00
        txtGrandTotal.Text = FormatCurrency(OrderTotalGrand) 'This resets the grandtotal textbox to 0 as the variable has been reset to 0
        lblRealTime.Select() 'This selects the time label of the order form
    End Sub

    Private Sub PicClearAll_MouseEnter(sender As Object, e As EventArgs) Handles PicClearAll.MouseEnter
        PicClearAll.Image = New Bitmap(My.Resources.btnClearAllRolloverPNG) 'This changes the state of the picture button when the user hovers over it
    End Sub

    Private Sub PicClearAll_MouseLeave(sender As Object, e As EventArgs) Handles PicClearAll.MouseLeave
        PicClearAll.Image = New Bitmap(My.Resources.btnClearAllPNG) 'This changes the state of the picture button when the user leaves the picture button
    End Sub

    Private Sub PicClearAll_MouseDown(sender As Object, e As MouseEventArgs) Handles PicClearAll.MouseDown
        PicClearAll.Image = New Bitmap(My.Resources.btnClearAllMouseDownPNG) 'This changes the state of the picture button when the user clicks down on the picture button
    End Sub

    Private Sub PicClearAll_MouseUp(sender As Object, e As MouseEventArgs) Handles PicClearAll.MouseUp
        PicClearAll.Image = New Bitmap(My.Resources.btnClearAllPNG) 'This changes the state of the picture button when the user clicks up from the picture button
    End Sub
#End Region

#Region "Checkout"
    Private Sub PicCheckout_Click(sender As Object, e As EventArgs) Handles PicCheckout.Click
        If lstViewOrder.Items.Count = 0 And txtGrandTotal.Text = 0.00 Or 0 Then
            'This condition displays an error dialogue box if the user has not made an order and clicked the checkout button
            Beep()
            FrmErrorDialogueOrder.TopMost = True
            FrmErrorDialogueOrder.Show()
            Exit Sub 'This exits the procedure
        Else
            'This adds up all the item totals of the application, giving the subtotal
            OrderTotalSub = MixShishTotal + ChickenIskenderTotal + LambChopsTotal + StrawberryMojitoTotal + TurkishTeaTotal + TurkishCoffeeTotal + ChocolateCheesecakeTotal + TurkishDelightTotal + StrawberryCheesecakeTotal
            ValueAddedTax = OrderTotalSub * 0.2 'This multiplies the subtotal by 0.2 to give the VAT
            OrderTotalGrand = Math.Round((OrderTotalSub + ValueAddedTax), 2) 'This gives the grandtotal by adding the subtotal and VAT and rounding it to 2 decimal places

            lblSubtotalFigure.Text = FormatCurrency(OrderTotalSub) 'This changes the subtotal label to its actual subtotal
            lblVATFigure.Text = FormatCurrency(ValueAddedTax) 'This changes the VAT label to its actual VAT
            txtGrandTotal.Text = FormatCurrency(OrderTotalGrand) 'This changes the grandtotal to its actual grandtotal
        End If
    End Sub

    Private Sub PicCheckout_MouseEnter(sender As Object, e As EventArgs) Handles PicCheckout.MouseEnter
        PicCheckout.Image = New Bitmap(My.Resources.btnCheckoutRolloverPNG)
    End Sub

    Private Sub PicCheckout_MouseLeave(sender As Object, e As EventArgs) Handles PicCheckout.MouseLeave
        PicCheckout.Image = New Bitmap(My.Resources.btnCheckoutPNG)
    End Sub

    Private Sub PicCheckout_MouseDown(sender As Object, e As MouseEventArgs) Handles PicCheckout.MouseDown
        PicCheckout.Image = New Bitmap(My.Resources.btnCheckoutMouseDownPNG)
    End Sub

    Private Sub PicCheckout_MouseUp(sender As Object, e As MouseEventArgs) Handles PicCheckout.MouseUp
        PicCheckout.Image = New Bitmap(My.Resources.btnCheckoutPNG)
    End Sub
#End Region

#Region "Payment Buttons"
    Private Sub Pic10Pound_Click(sender As Object, e As EventArgs) Handles Pic10Pound.Click
        CustomerPaid += 10 'This increments the £10 button by 10 each time it is clicked 
        txtCustomerPaid.Text = FormatCurrency(CustomerPaid) 'This changes the number 10 into a currency format on the customer paid textbox
    End Sub

    Private Sub Pic10Pound_MouseEnter(sender As Object, e As EventArgs) Handles Pic10Pound.MouseEnter
        Pic10Pound.Image = New Bitmap(My.Resources.btn10PoundRolloverPNG) 'This changes the state of the picture button when the user hovers over it
    End Sub

    Private Sub Pic10Pound_MouseLeave(sender As Object, e As EventArgs) Handles Pic10Pound.MouseLeave
        Pic10Pound.Image = New Bitmap(My.Resources.btn10PoundPNG) 'This changes the state of the picture button when the user leaves the picture button
    End Sub

    Private Sub Pic10Pound_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic10Pound.MouseDown
        Pic10Pound.Image = New Bitmap(My.Resources.btn10PoundMouseDownPNG) 'This changes the state of the picture button when the user clicks down on it
    End Sub

    Private Sub Pic10Pound_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic10Pound.MouseUp
        Pic10Pound.Image = New Bitmap(My.Resources.btn10PoundRolloverPNG) 'This changes the state of the picture button when the user clicks up
    End Sub

    Private Sub Pic30Pound_Click(sender As Object, e As EventArgs) Handles Pic30Pound.Click
        CustomerPaid += 30 'This increments the £30 button by 30 each time it is clicked
        txtCustomerPaid.Text = FormatCurrency(CustomerPaid) 'This changes the number 30 into a currency format on the customer paid textbox
    End Sub

    Private Sub Pic30Pound_MouseEnter(sender As Object, e As EventArgs) Handles Pic30Pound.MouseEnter
        Pic30Pound.Image = New Bitmap(My.Resources.btn30PoundRolloverPNG)
    End Sub

    Private Sub Pic30Pound_MouseLeave(sender As Object, e As EventArgs) Handles Pic30Pound.MouseLeave
        Pic30Pound.Image = New Bitmap(My.Resources.btn30PoundPNG)
    End Sub

    Private Sub Pic30Pound_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic30Pound.MouseDown
        Pic30Pound.Image = New Bitmap(My.Resources.btn30PoundMouseDownPNG)
    End Sub

    Private Sub Pic30Pound_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic30Pound.MouseUp
        Pic30Pound.Image = New Bitmap(My.Resources.btn30PoundPNG)
    End Sub

    Private Sub Pic50Pound_Click(sender As Object, e As EventArgs) Handles Pic50Pound.Click
        CustomerPaid += 50 'This increments the £50 button by 50 each time it is clicked
        txtCustomerPaid.Text = FormatCurrency(CustomerPaid) 'This changes the number 50 into a currency format on the customer paid textbox
    End Sub

    Private Sub Pic50Pound_MouseEnter(sender As Object, e As EventArgs) Handles Pic50Pound.MouseEnter
        Pic50Pound.Image = New Bitmap(My.Resources.btn50PoundRolloverPNG)
    End Sub

    Private Sub Pic50Pound_MouseLeave(sender As Object, e As EventArgs) Handles Pic50Pound.MouseLeave
        Pic50Pound.Image = New Bitmap(My.Resources.btn50PoundPNG)
    End Sub

    Private Sub Pic50Pound_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic50Pound.MouseDown
        Pic50Pound.Image = New Bitmap(My.Resources.btn50PoundMouseDownPNG)
    End Sub

    Private Sub Pic50Pound_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic50Pound.MouseUp
        Pic50Pound.Image = New Bitmap(My.Resources.btn50PoundPNG)
    End Sub

    Private Sub PicClear_Click(sender As Object, e As EventArgs) Handles PicClear.Click
        CustomerPaid = 0 'This sets the customer paid variable to 0
        txtCustomerPaid.Text = "" 'This clears the customer paid textbox
    End Sub

    Private Sub PicClear_MouseEnter(sender As Object, e As EventArgs) Handles PicClear.MouseEnter
        PicClear.Image = New Bitmap(My.Resources.btnClearRolloverPNG)
    End Sub

    Private Sub PicClear_MouseLeave(sender As Object, e As EventArgs) Handles PicClear.MouseLeave
        PicClear.Image = New Bitmap(My.Resources.btnClearPNG)
    End Sub

    Private Sub PicClear_MouseDown(sender As Object, e As MouseEventArgs) Handles PicClear.MouseDown
        PicClear.Image = New Bitmap(My.Resources.btnClearMouseDownPNG)
    End Sub

    Private Sub PicClear_MouseUp(sender As Object, e As MouseEventArgs) Handles PicClear.MouseUp
        PicClear.Image = New Bitmap(My.Resources.btnClearPNG)
    End Sub

    Private Sub Pic0_Click(sender As Object, e As EventArgs) Handles Pic0.Click
        txtCustomerPaid.Text = txtCustomerPaid.Text & "0" 'When the user clicks the 0 button, '0' is added onto the customer paid textbox
    End Sub

    Private Sub Pic0_MouseEnter(sender As Object, e As EventArgs) Handles Pic0.MouseEnter
        Pic0.Image = New Bitmap(My.Resources.btn0RolloverPNG)
    End Sub

    Private Sub Pic0_MouseLeave(sender As Object, e As EventArgs) Handles Pic0.MouseLeave
        Pic0.Image = New Bitmap(My.Resources.btn0PNG)
    End Sub

    Private Sub Pic0_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic0.MouseDown
        Pic0.Image = New Bitmap(My.Resources.btn0MouseDownPNG)
    End Sub

    Private Sub Pic0_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic0.MouseUp
        Pic0.Image = New Bitmap(My.Resources.btn0PNG)
    End Sub

    Private Sub PicDot_Click(sender As Object, e As EventArgs) Handles PicDot.Click
        txtCustomerPaid.Text = txtCustomerPaid.Text & "." 'When the user clicks the dot button, '.' is added onto the customer paid textbox
    End Sub

    Private Sub PicDot_MouseEnter(sender As Object, e As EventArgs) Handles PicDot.MouseEnter
        PicDot.Image = New Bitmap(My.Resources.btnDotRolloverPNG)
    End Sub

    Private Sub PicDot_MouseLeave(sender As Object, e As EventArgs) Handles PicDot.MouseLeave
        PicDot.Image = New Bitmap(My.Resources.btnDotPNG)
    End Sub

    Private Sub PicDot_MouseDown(sender As Object, e As MouseEventArgs) Handles PicDot.MouseDown
        PicDot.Image = New Bitmap(My.Resources.btnDotMouseDownPNG)
    End Sub

    Private Sub PicDot_MouseUp(sender As Object, e As MouseEventArgs) Handles PicDot.MouseUp
        PicDot.Image = New Bitmap(My.Resources.btnDotPNG)
    End Sub

    Private Sub Pic1_Click(sender As Object, e As EventArgs) Handles Pic1.Click
        txtCustomerPaid.Text = txtCustomerPaid.Text & "1" 'When the user clicks the 1 button, '1' is added onto the customer paid textbox
    End Sub

    Private Sub Pic1_MouseEnter(sender As Object, e As EventArgs) Handles Pic1.MouseEnter
        Pic1.Image = New Bitmap(My.Resources.btn1RolloverPNG)
    End Sub

    Private Sub Pic1_MouseLeave(sender As Object, e As EventArgs) Handles Pic1.MouseLeave
        Pic1.Image = New Bitmap(My.Resources.btn1PNG)
    End Sub

    Private Sub Pic1_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic1.MouseDown
        Pic1.Image = New Bitmap(My.Resources.btn1MouseDownPNG)
    End Sub

    Private Sub Pic1_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic1.MouseUp
        Pic1.Image = New Bitmap(My.Resources.btn1PNG)
    End Sub

    Private Sub Pic2_Click(sender As Object, e As EventArgs) Handles Pic2.Click
        txtCustomerPaid.Text = txtCustomerPaid.Text & "2" 'When the user clicks the 2 button, '2' is added onto the customer paid textbox
    End Sub

    Private Sub Pic2_MouseEnter(sender As Object, e As EventArgs) Handles Pic2.MouseEnter
        Pic2.Image = New Bitmap(My.Resources.btn2RolloverPNG)
    End Sub

    Private Sub Pic2_MouseLeave(sender As Object, e As EventArgs) Handles Pic2.MouseLeave
        Pic2.Image = New Bitmap(My.Resources.btn2PNG)
    End Sub

    Private Sub Pic2_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic2.MouseDown
        Pic2.Image = New Bitmap(My.Resources.btn2MouseDownPNG)
    End Sub

    Private Sub Pic2_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic2.MouseUp
        Pic2.Image = New Bitmap(My.Resources.btn2PNG)
    End Sub

    Private Sub Pic3_Click(sender As Object, e As EventArgs) Handles Pic3.Click
        txtCustomerPaid.Text = txtCustomerPaid.Text & "3" 'When the user clicks the 3 button, '3' is added onto the customer paid textbox
    End Sub

    Private Sub Pic3_MouseEnter(sender As Object, e As EventArgs) Handles Pic3.MouseEnter
        Pic3.Image = New Bitmap(My.Resources.btn3RolloverPNG)
    End Sub

    Private Sub Pic3_MouseLeave(sender As Object, e As EventArgs) Handles Pic3.MouseLeave
        Pic3.Image = New Bitmap(My.Resources.btn3PNG)
    End Sub

    Private Sub Pic3_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic3.MouseDown
        Pic3.Image = New Bitmap(My.Resources.btn3MouseDownPNG)
    End Sub

    Private Sub Pic3_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic3.MouseUp
        Pic3.Image = New Bitmap(My.Resources.btn3PNG)
    End Sub

    Private Sub Pic4_Click(sender As Object, e As EventArgs) Handles Pic4.Click
        txtCustomerPaid.Text = txtCustomerPaid.Text & "4" 'When the user clicks the 4 button, '4' is added onto the customer paid textbox
    End Sub

    Private Sub Pic4_MouseEnter(sender As Object, e As EventArgs) Handles Pic4.MouseEnter
        Pic4.Image = New Bitmap(My.Resources.btn4RolloverPNG)
    End Sub

    Private Sub Pic4_MouseLeave(sender As Object, e As EventArgs) Handles Pic4.MouseLeave
        Pic4.Image = New Bitmap(My.Resources.btn4PNG)
    End Sub

    Private Sub Pic4_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic4.MouseDown
        Pic4.Image = New Bitmap(My.Resources.btn4MouseDownPNG)
    End Sub

    Private Sub Pic4_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic4.MouseUp
        Pic4.Image = New Bitmap(My.Resources.btn4PNG)
    End Sub

    Private Sub Pic5_Click(sender As Object, e As EventArgs) Handles Pic5.Click
        txtCustomerPaid.Text = txtCustomerPaid.Text & "5" 'When the user clicks the 5 button, '5' is added onto the customer paid textbox
    End Sub

    Private Sub Pic5_MouseEnter(sender As Object, e As EventArgs) Handles Pic5.MouseEnter
        Pic5.Image = New Bitmap(My.Resources.btn5RolloverPNG)
    End Sub

    Private Sub Pic5_MouseLeave(sender As Object, e As EventArgs) Handles Pic5.MouseLeave
        Pic5.Image = New Bitmap(My.Resources.btn5PNG)
    End Sub

    Private Sub Pic5_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic5.MouseDown
        Pic5.Image = New Bitmap(My.Resources.btn5MouseDownPNG)
    End Sub

    Private Sub Pic5_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic5.MouseUp
        Pic5.Image = New Bitmap(My.Resources.btn5PNG)
    End Sub

    Private Sub Pic6_Click(sender As Object, e As EventArgs) Handles Pic6.Click
        txtCustomerPaid.Text = txtCustomerPaid.Text & "6" 'When the user clicks the 6 button, '6' is added onto the customer paid textbox
    End Sub

    Private Sub Pic6_MouseEnter(sender As Object, e As EventArgs) Handles Pic6.MouseEnter
        Pic6.Image = New Bitmap(My.Resources.btn6RolloverPNG)
    End Sub

    Private Sub Pic6_MouseLeave(sender As Object, e As EventArgs) Handles Pic6.MouseLeave
        Pic6.Image = New Bitmap(My.Resources.btn6PNG)
    End Sub

    Private Sub Pic6_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic6.MouseDown
        Pic6.Image = New Bitmap(My.Resources.btn6MouseDownPNG)
    End Sub

    Private Sub Pic6_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic6.MouseUp
        Pic6.Image = New Bitmap(My.Resources.btn6PNG)
    End Sub

    Private Sub Pic7_Click(sender As Object, e As EventArgs) Handles Pic7.Click
        txtCustomerPaid.Text = txtCustomerPaid.Text & "7" 'When the user clicks the 7 button, '7' is added onto the customer paid textbox
    End Sub

    Private Sub Pic7_MouseEnter(sender As Object, e As EventArgs) Handles Pic7.MouseEnter
        Pic7.Image = New Bitmap(My.Resources.btn7RolloverPNG)
    End Sub

    Private Sub Pic7_MouseLeave(sender As Object, e As EventArgs) Handles Pic7.MouseLeave
        Pic7.Image = New Bitmap(My.Resources.btn7PNG)
    End Sub

    Private Sub Pic7_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic7.MouseDown
        Pic7.Image = New Bitmap(My.Resources.btn7MouseDownPNG)
    End Sub

    Private Sub Pic7_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic7.MouseUp
        Pic7.Image = New Bitmap(My.Resources.btn7PNG)
    End Sub

    Private Sub Pic8_Click(sender As Object, e As EventArgs) Handles Pic8.Click
        txtCustomerPaid.Text = txtCustomerPaid.Text & "8" 'When the user clicks the 8 button, '8' is added onto the customer paid textbox
    End Sub

    Private Sub Pic8_MouseEnter(sender As Object, e As EventArgs) Handles Pic8.MouseEnter
        Pic8.Image = New Bitmap(My.Resources.btn8RolloverPNG)
    End Sub

    Private Sub Pic8_MouseLeave(sender As Object, e As EventArgs) Handles Pic8.MouseLeave
        Pic8.Image = New Bitmap(My.Resources.btn8PNG)
    End Sub

    Private Sub Pic8_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic8.MouseDown
        Pic8.Image = New Bitmap(My.Resources.btn8MouseDownPNG)
    End Sub

    Private Sub Pic8_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic8.MouseUp
        Pic8.Image = New Bitmap(My.Resources.btn8PNG)
    End Sub

    Private Sub Pic9_Click(sender As Object, e As EventArgs) Handles Pic9.Click
        txtCustomerPaid.Text = txtCustomerPaid.Text & "9" 'When the user clicks the 9 button, '9' is added onto the customer paid textbox
    End Sub

    Private Sub Pic9_MouseEnter(sender As Object, e As EventArgs) Handles Pic9.MouseEnter
        Pic9.Image = New Bitmap(My.Resources.btn9RolloverPNG)
    End Sub

    Private Sub Pic9_MouseLeave(sender As Object, e As EventArgs) Handles Pic9.MouseLeave
        Pic9.Image = New Bitmap(My.Resources.btn9PNG)
    End Sub

    Private Sub Pic9_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic9.MouseDown
        Pic9.Image = New Bitmap(My.Resources.btn9MouseDownPNG)
    End Sub

    Private Sub Pic9_MouseUp(sender As Object, e As MouseEventArgs) Handles Pic9.MouseUp
        Pic9.Image = New Bitmap(My.Resources.btn9PNG)
    End Sub

    Private Sub PicBackSpace_Click(sender As Object, e As EventArgs) Handles PicBackSpace.Click
        'This condition states that if the string length is more than 0,
        'it will retrieve the characters of the string and remove one character from the last character 
        If txtCustomerPaid.Text.Length > 0 Then
            txtCustomerPaid.Text = txtCustomerPaid.Text.Remove(txtCustomerPaid.Text.Length - 1, 1)
        ElseIf txtCustomerPaid.Text.Length < 1 Then
            'This else condition states that if the string length is less than 1,
            'it will clear the textbox
            txtCustomerPaid.Text = "" 'Clears the textbox
        End If
    End Sub

    Private Sub PicBackSpace_MouseEnter(sender As Object, e As EventArgs) Handles PicBackSpace.MouseEnter
        PicBackSpace.Image = New Bitmap(My.Resources.btnBackSpaceRolloverPNG)
    End Sub

    Private Sub PicBackSpace_MouseLeave(sender As Object, e As EventArgs) Handles PicBackSpace.MouseLeave
        PicBackSpace.Image = New Bitmap(My.Resources.btnBackSpacePNG)
    End Sub

    Private Sub PicBackSpace_MouseDown(sender As Object, e As MouseEventArgs) Handles PicBackSpace.MouseDown
        PicBackSpace.Image = New Bitmap(My.Resources.btnBackSpaceMouseDownPNG)
    End Sub

    Private Sub PicBackSpace_MouseUp(sender As Object, e As MouseEventArgs) Handles PicBackSpace.MouseUp
        PicBackSpace.Image = New Bitmap(My.Resources.btnBackSpacePNG)
    End Sub
#End Region

#Region "Key Input Validation and Pay Button"
    Private Sub txtCustomerPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustomerPaid.KeyPress
        'This condition states that if any ASCII character codes corresponding to the keypress are pressed on the keyboard
        'apart from the characters 0-9 and the '.' character, the control key will be disabled
        '(Refer to ASCII table)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PicPay_Click(sender As Object, e As EventArgs) Handles PicPay.Click
        'This condition states that if the user clicks pay without checking out, 
        'an error dialogue box should appear
        If lblSubtotalFigure.Text = 0 Or 0.00 And lblVATFigure.Text = 0 Or 0.00 And txtGrandTotal.Text = 0 Or 0.00 Then
            Beep() 'This makes a beep noise
            FrmErrorDialogueCheckout.TopMost = True 'This brings the dialogue box to the front
            FrmErrorDialogueCheckout.Show() 'This displays the custom dialogue box
            Exit Sub 'This exits the procedure after the user clicks 'OK'
        End If

        If txtCustomerPaid.Text > "" Then 'If the customer paid textbox is blank, the variable will be reset
            CustomerPaid = txtCustomerPaid.Text
        Else
            'This else states that if any of the conditions are met but the amount has not been paid
            'the pay error dialogue box will be displayed
            Beep()
            FrmErrorDialoguePay.TopMost = True
            FrmErrorDialoguePay.Show()
            Exit Sub
        End If

        'This condition states that if the amount entered by the customer is greater than the grandtotal,
        'the amount will be subtracted by the grandtotal and the change will be displayed.
        'Additionally, a change/print form will appear in the middle with the given change
        If CustomerPaid >= OrderTotalGrand Then
            ChangeDue = CustomerPaid - OrderTotalGrand
            txtChangeDue.Text = FormatCurrency(ChangeDue)
            txtChangeDue.ForeColor = Color.FromArgb(164, 0, 0) 'This sets the forecolor as a custom rgb colour
            PicClearAll.Select()

            FrmPrint.TopMost = True
            FrmPrint.Show()
            Beep()

            'This condition states that if the amount entered by the customer is less than grandtotal,
            'an alert dialogue box will appear asking for a correct amount to be entered
        ElseIf CustomerPaid < OrderTotalGrand Then
            Beep()
            FrmAlertDialogueCorrectPayment.TopMost = True
            FrmAlertDialogueCorrectPayment.Show()
            Exit Sub
        End If
    End Sub

    Private Sub PicPay_MouseEnter(sender As Object, e As EventArgs) Handles PicPay.MouseEnter
        PicPay.Image = New Bitmap(My.Resources.btnPayRolloverPNG)
    End Sub

    Private Sub PicPay_MouseLeave(sender As Object, e As EventArgs) Handles PicPay.MouseLeave
        PicPay.Image = New Bitmap(My.Resources.btnPayPNG)
    End Sub

    Private Sub PicPay_MouseDown(sender As Object, e As MouseEventArgs) Handles PicPay.MouseDown
        PicPay.Image = New Bitmap(My.Resources.btnPayMouseDownPNG)
    End Sub

    Private Sub PicPay_MouseUp(sender As Object, e As MouseEventArgs) Handles PicPay.MouseUp
        PicPay.Image = New Bitmap(My.Resources.btnPayPNG)
    End Sub
#End Region

#Region "Help Button"
    Private Sub PicINeedHelp_Click(sender As Object, e As EventArgs) Handles PicINeedHelp.Click
        Dim FadeOutTimer As New Timer 'This code declares a new timer as a variable
        FadeOutTimer.Interval = 10 'This code sets the interval of the timer variable as 10
        FadeOutTimer.Start() 'This code starts the timer
        AddHandler FadeOutTimer.Tick, Sub()
                                          'This code creates a nested subroutine within the current sub routine, allowing it to control the timer 
                                          Me.Opacity -= 0.1 'This code creates a fade out animation of the current form, by decreasing the opacity by 0.1
                                          If Me.Opacity = 0 Then
                                              Me.Hide() 'Hides the current form
                                              FadeOutTimer.Stop()  'When the opacity has reached 0 or 0%, the timer stops
                                              'and the current form disappears
                                              FadeOutTimer.Dispose() 'This gets rid of the timer

                                              FrmHelp.Opacity = 0 'This code sets the help form's opacity as 0 
                                              FrmHelp.Show() 'This code allows the help form to be displayed
                                              Dim NextFormFadeIn As New Timer 'This code declares a new timer as a variable
                                              NextFormFadeIn.Interval = 100 'This code sets the interval of the timer variable as 100
                                              NextFormFadeIn.Start() 'This code starts the timer
                                              AddHandler NextFormFadeIn.Tick, Sub()
                                                                                  'This code creates another nested subroutine within the current sub routine, allowing it to control the timer 
                                                                                  FrmHelp.Opacity += 0.1 'This code creates a fade in animation of the help form, by decreasing the opacity by 0.1
                                                                                  FrmHelp.PicMenuButton.Visible = True 'This allows the menu button in the help form to be visible
                                                                                  FrmHelp.PicMenuButton.Show() 'This displays the menu button in the help form when it is loaded
                                                                                  FrmHelp.PicExitPanel.Visible = False 'This allows the exit button in the help form to not be visible when it is loaded
                                                                                  FrmHelp.PicSlidingPanel.Visible = False 'This allows the sliding panel to not be visible in the help form when it is loaded
                                                                                  FrmHelp.PicSlidingPanel.Size = New Size(10, 782) 'This sets the size of the sliding panel as a smaller size so it isn't visible
                                                                                  FrmHelp.PicHelpContent.Visible = False 'This disables the content of the help form when it is loaded
                                                                                  FrmHelp.PicHelp.Visible = False 'This disables the visibility of the help button in the help form when it is loaded
                                                                                  FrmHelp.PicTroubleshooting.Visible = False 'This disables the visibility of the troubleshooting button in the help form when it is loaded
                                                                                  FrmHelp.PicFAQ.Visible = False 'This disables the visibility of the FAQ button in the help form when it is loaded
                                                                                  FrmHelp.HelpSubPanel.Visible = False 'This disables the visibility of the help sub panel in the help form when it is loaded
                                                                                  If FrmHelp.Opacity = 1 Then 'When the opacity has reached 1 or 100%, the timer stops
                                                                                      'and the help form is fully visible
                                                                                      NextFormFadeIn.Stop() 'stops the timer
                                                                                      NextFormFadeIn.Dispose() 'gets rid of the timer
                                                                                  End If
                                                                              End Sub
                                          End If
                                      End Sub
    End Sub

    Private Sub PicINeedHelp_MouseEnter(sender As Object, e As EventArgs) Handles PicINeedHelp.MouseEnter
        PicINeedHelp.Image = New Bitmap(My.Resources.btnINeedHelpRolloverPNG)
    End Sub

    Private Sub PicINeedHelp_MouseLeave(sender As Object, e As EventArgs) Handles PicINeedHelp.MouseLeave
        PicINeedHelp.Image = New Bitmap(My.Resources.btnINeedHelpPNG)
    End Sub

    Private Sub PicINeedHelp_MouseDown(sender As Object, e As MouseEventArgs) Handles PicINeedHelp.MouseDown
        PicINeedHelp.Image = New Bitmap(My.Resources.btnINeedHelpMouseDownPNG)
    End Sub

    Private Sub PicINeedHelp_MouseUp(sender As Object, e As MouseEventArgs) Handles PicINeedHelp.MouseUp
        PicINeedHelp.Image = New Bitmap(My.Resources.btnINeedHelpPNG)
    End Sub
#End Region

End Class