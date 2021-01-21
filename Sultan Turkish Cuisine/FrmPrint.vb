Public Class FrmPrint

    'Sultan Turkish Cuisine
    'Print Form
    'Programmed By S Rahman
    '05/05/18
    '------------------------------------------------------------------------------------------------------------------------------------

    Private Sub FrmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDisplayChangeDue.Text = FormatCurrency(FrmOrder.txtChangeDue.Text) 'This displays the change due to the customer in a textbox
        'when this form loads
        lblSuccessful.Select() 'This selects the label of the form, so the textbox isn't highlighted
    End Sub

    Private Sub btnExitPrintForm_Click(sender As Object, e As EventArgs) Handles btnExitPrintForm.Click
        Me.Close() 'This closes the current form (print form)
    End Sub

    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        PrintReceipt.Print() 'This prints the receipt
    End Sub

    Private Sub btnPreviewReceipt_Click(sender As Object, e As EventArgs) Handles btnPreviewReceipt.Click
        'Print Preview Button
        PrintPreviewReceipt.Document = PrintReceipt 'This identifies which document needs to be previewed
        PrintPreviewReceipt.WindowState = FormWindowState.Maximized 'This allows the document to be displayed in a maximised state
        PrintPreviewReceipt.MinimizeBox = True 'This allows the user to minimise the document
        PrintPreviewReceipt.Icon = My.Resources.SultanIcon 'This identifies the icon that will be displayed on the document
        Me.Hide() 'This hides the print form
        PrintPreviewReceipt.ShowDialog() 'This displays the print preview document
    End Sub

    Private Sub PrintReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintReceipt.PrintPage
        Dim ReceiptFont As New Font("Consolas", 14, FontStyle.Regular) 'This local variable stores a smaller size consolas font
        Dim ReceiptFont2 As New Font("Consolas", 15, FontStyle.Regular) 'This local variable stores a larger size consolas font

        Dim x As Integer 'This local variable stores the coordinates in the x axis
        Dim y As Integer 'This local variable stores the coordinates in the y axis
        Dim SultanLogo As Image = New Bitmap(My.Resources.ReceiptLogoPNG) 'This local variable stores the logo as a new instance of a the existing bitmap image

        Dim ReceiptLineDesign As Single() = {3, 3, 3, 3} 'This local variable stores the format of the receipt lines
        Dim ReceiptInk As New Pen(Color.Black, 2) 'This local variable stores the colour of the receipt lines
        ReceiptInk.DashPattern = ReceiptLineDesign 'This code assigns the dashes onto the receipt line format

        Dim i As Integer 'This local variable stores the index of each of the listbox order items
        Dim RetrieveLstItems As String 'This local variable stores the retrieved listbox items from the order form
        Dim ReceiptStyleForMe As String = "{0,-23}{1,-10}{2,-9}{3,-4}" 'This local variable stores and locates the index
        'of the receipt titles as well as counting the space for the width of the receipt titles
        Dim ReceiptStyleTitles As String = String.Format(ReceiptStyleForMe, "Description", "Price", "Qty", "Total")
        'This local variables stores the title for each column of the listbox items

        Dim ReceiptTotalStyleForMe As String = "{0,-42}{1,-8}" 'This local variable stores and locates the index column of the listbox
        'and counts the space for the width of the receipt total titles
        Dim MyOrderTotalSub As String = String.Format(ReceiptTotalStyleForMe, "Subtotal", FormatCurrency(FrmOrder.OrderTotalSub))
        'This local variable stores the retrieved subtotal from the order form, in a currency format
        Dim MyValueAddedTax As String = String.Format(ReceiptTotalStyleForMe, "VAT", FormatCurrency(FrmOrder.ValueAddedTax))
        'This local variable stores the retrieved VAT from the order form in, a currency format
        Dim MyOrderTotalGrand As String = String.Format(ReceiptTotalStyleForMe, "Grandtotal", FormatCurrency(FrmOrder.OrderTotalGrand))
        'This local variable stores the retrieved grandtotal from the order form, in a currency format
        Dim MyCustomerPaid As String = String.Format(ReceiptTotalStyleForMe, "Paid", FormatCurrency(FrmOrder.txtCustomerPaid.Text))
        'This local variable stores the retrieved amount paid by the customer from the order form, in a currency format
        Dim MyChange As String = String.Format(ReceiptTotalStyleForMe, "Change", FormatCurrency(txtDisplayChangeDue.Text))
        'This local variable stores the retrieved change due to the customer from the order form, in a currency format


        x = 170 'Sultan logo coordinates
        y = e.PageBounds.Height / 30
        e.Graphics.DrawImage(SultanLogo, x, y, 480, 180) 'Sultan logo displayed on receipt


        x = 285 'Address Line 1 coordinates
        y = 230
        e.Graphics.DrawString("Westfield – Stratford City", ReceiptFont, Brushes.Black, x, y) 'Address Line 1 displayed on receipt

        x = 370 'Address Line 2 coordinates
        y = 260
        e.Graphics.DrawString("Leyton Road", ReceiptFont, Brushes.Black, x, y) 'Address Line 2 displayed on receipt


        x = 355 'City and Postcode coordinates
        y = 290
        e.Graphics.DrawString("London E20 1EQ", ReceiptFont, Brushes.Black, x, y) 'City and Postcode displayed on receipt


        x = 295 'Phone number postcode
        y = 320
        e.Graphics.DrawString("PHONE – (+44) 2085031510", ReceiptFont, Brushes.Black, x, y) 'Phone number displayed on receipt


        e.Graphics.DrawLine(ReceiptInk, New Point(140, 360), New Point(690, 360)) 'Receipt line patterns displayed on receipt


        x = 148 'Receipt titles coordinates
        y = 370
        e.Graphics.DrawString(ReceiptStyleTitles, ReceiptFont, Brushes.Black, x, y) 'Receipt titles displayed on receipt
        e.Graphics.DrawLine(ReceiptInk, New Point(140, 400), New Point(690, 400)) 'Receipt line patterns displayed on receipt


        x = 126 'Order items coordinates
        y = 420
        For i = 0 To FrmOrder.lstViewOrder.Items.Count - 1 'This for loop allows the receipt to display the list box items
            'by counting the items from the order form one by one
            RetrieveLstItems = FrmOrder.lstViewOrder.Items(i) 'This code retrieves the listbox items from the order form 
            'and stores it inside the RetrieveLstItems variable 
            e.Graphics.DrawString(RetrieveLstItems, ReceiptFont, Brushes.Black, x, y) 'This code displays the listbox order items
            'on the receipt
            y = y + 40 'This code increments each listbox item on the y-axis by 40 pixels
        Next i


        e.Graphics.DrawLine(ReceiptInk, New Point(140, y + 5), New Point(690, y + 5)) 'Receipt line patterns displayed on receipt


        x = 140 'Subtotal coordinates
        y = y + 25
        e.Graphics.DrawString(MyOrderTotalSub, ReceiptFont, Brushes.Black, x, y) 'Subtotal displayed on receipt


        x = 140 'VAT coordinates
        y = y + 30
        e.Graphics.DrawString(MyValueAddedTax, ReceiptFont, Brushes.Black, x, y) 'VAT displayed on receipt


        x = 140 'Grandtotal coordinates
        y = y + 30
        e.Graphics.DrawString(MyOrderTotalGrand, ReceiptFont, Brushes.Black, x, y) 'Grandtotal displayed on receipt


        e.Graphics.DrawLine(ReceiptInk, New Point(140, y + 40), New Point(690, y + 40)) 'Receipt line patterns displayed


        x = 140 'Amount paid coordinates
        y = y + 60
        e.Graphics.DrawString(MyCustomerPaid, ReceiptFont, Brushes.Black, x, y) 'This displays the amount paid by the customer on the receipt 


        x = 140 'Change due coordinates
        y = y + 30
        e.Graphics.DrawString(MyChange, ReceiptFont, Brushes.Black, x, y) 'This displays the change due to the customer on the receipt


        e.Graphics.DrawLine(ReceiptInk, New Point(140, y + 40), New Point(690, y + 40)) 'Receipt line patterns displayed on receipt


        x = 200 'Date coordinates
        y = y + 55
        e.Graphics.DrawString("Date:  " & Date.Today, ReceiptFont, Brushes.Black, x, y) 'Date displayed on receipt


        x = 495 'Time coordinates
        y = y + 0
        e.Graphics.DrawString("Time:  " & TimeOfDay.ToString("H:mm"), ReceiptFont, Brushes.Black, x, y) 'Time displayed on receipt


        x = 200 'Name of waiter coordinates
        y = y + 35
        e.Graphics.DrawString("You were served today by: " & FrmOrder.lblUsername.Text, ReceiptFont, Brushes.Black, x, y) 'Name of waiter coordinates


        e.Graphics.DrawLine(ReceiptInk, New Point(140, y + 35), New Point(690, y + 35)) 'Receipt line patterns displayed on receipt


        x = 240 'Thank you message coordinates
        y = y + 60
        e.Graphics.DrawString("THANK YOU FOR COMING TO SULTAN!", ReceiptFont2, Brushes.Black, x, y) 'Thank you message displayed on receipt
    End Sub
End Class