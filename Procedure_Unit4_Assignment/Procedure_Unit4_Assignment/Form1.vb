Public Class Form1
    'define the GetInStock function
    Function GetInStock() As Integer
        Dim IntStock As Integer
        Dim Input As String
        Input = InputBox("How many Spools currently in stock?") 'ask the user the number of spools in stock
        IntStock = CInt(Input)
        Return IntStock
    End Function
    'define the Ready to Ship Function 
    Function ReadyToShip(ByVal NumStock As Integer, ByVal NumOrder As Integer) As Integer

        Dim intready As Integer
        'Define the condition to find out the number of spools that ready to ship
        If NumOrder <= NumStock Then
            intready = NumOrder
        ElseIf NumOrder > NumStock Then
            intready = NumStock
        End If
        Return intready
    End Function
    'define the BackOrder Function 
    Function BackOrdered(ByVal Numstock As Integer, ByVal Numorder As Integer) As Integer
        Dim intBackOrder As Integer = 0
        'define the condition that if the number of order bigger than stock, calculate for number of back order
        If Numstock < Numorder Then
            intBackOrder = Numorder - Numstock

        Else
            intBackOrder = 0
        End If
        Return intBackOrder
    End Function
    'define the ShippingCharg Function
    Function ShippingCharges(ByVal IntReady As Integer, ByVal Shipping As Decimal) As Integer
        'if the user click the rush deliveri, do the calculate 
        If Rushchb.Checked = True Then
            Shipping = IntReady * 15
        Else
            Shipping = IntReady * 10 'if the user don't click on rush delivery, just calculate the normal delivery
        End If
        Return Shipping
    End Function


    Private Sub Calculatebtn_Click(sender As Object, e As EventArgs) Handles Calculatebtn.Click
        'define the valiable
        Dim IntSpoolOrder As Integer
        Dim IntSTotal As Integer
        Dim OrderTotal As Integer
        Dim IntPerSpool As Integer = 10
        Dim IntBackOrder As Integer
        Dim IntNumOfstock As Integer
        Dim IntReadyToShip As Integer

        IntSpoolOrder = CInt(NumOfSpooltxt.Text) 'put the user input in to the valiable
        IntNumOfstock = GetInStock() 'call the function

        IntBackOrder = BackOrdered(IntNumOfstock, IntSpoolOrder) 'call the bachorder function
        SpoolBacklbl.Text = IntBackOrder.ToString 'put the bachorder in to the backorder label

        IntReadyToShip = ReadyToShip(IntNumOfstock, IntSpoolOrder) 'call the ready to ship function
        SpoolReadylbl.Text = IntReadyToShip.ToString 'put the result into the ready to ship lable


        IntSTotal = IntSpoolOrder * 100 'the user input number multiply by 100
        OrderTotal = ShippingCharges(IntReadyToShip, IntPerSpool) 'call the shipping charge function
        Shippinglbl.Text = OrderTotal.ToString 'put the result into the shipping handelling label
        Totallbl.Text = Shippinglbl.Text + IntSTotal 'add the shipping coust with total



    End Sub
    'define the sub to clear the textbox and check box
    Sub ResetSpools()
        NumOfSpooltxt.Clear()
        Rushchb.Checked = False

    End Sub
    'define the sub to clean the labels in delivery information
    Sub ResetDeliver()
        SpoolReadylbl.Text = ""
        SpoolBacklbl.Text = ""
        Shippinglbl.Text = ""
        Totallbl.Text = ""
    End Sub
    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        'call the sub in the clean botton
        ResetSpools()
        ResetDeliver()
    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        'close the form
        Me.Close()
    End Sub
End Class
