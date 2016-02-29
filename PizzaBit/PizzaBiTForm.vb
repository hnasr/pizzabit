Public Class PizzaBiTForm

    Private _pizza As Pizza
    Private _Inventory As Inventory = New Inventory

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnAddCheese.Enabled = False
        btnAddOnion.Enabled = False
        btnAddMeat.Enabled = False
        btnAddChicken.Enabled = False
        btnCalculatePrice.Enabled = False
        cmdCrustType.Enabled = False
        cmbSize.Enabled = False
        cmbPizza.Enabled = False

        Dim pThinCrustType As ICrustType = New ThinCrustType

        cmdCrustType.Items.Add(pThinCrustType)
        cmdCrustType.Items.Add(New ThickCrustType)
        cmdCrustType.Items.Add(New CheeseCrustType)
        cmdCrustType.Items.Add(New AppleCrustType)
        ' Dim i As Integer = 2147483647 '2^31 -1 maximum number you can put in integer
        'Dim l As Long = 9223372036854775807 '2^63 - 1

        '00000001 1
        '00000010 2
        '00000011 3
        '10000000 128
        '11111111 255
        '8 byte =256 

        'MsgBox("i = " & i & " j = " & j)

        'j = 7

        '        MsgBox("i = " & i & " j = " & j)

        '    Dim pizza1 As Pizza = New Pizza
        '     Dim pizza2 As Pizza = New Pizza
        '
        '      pizza1.Test = 100

        '        MsgBox("object1 = " & pizza1.Test & " object2 = " & pizza2.Test)





    End Sub

    Private Sub CreateNewPizzaOnClick(sender As Object, e As EventArgs) Handles btnCreatePizza.Click


        _pizza = New Pizza(_Inventory)
        cmbSize.Enabled = True

        btnAddCheese.Enabled = True
        btnAddOnion.Enabled = True
        btnAddMeat.Enabled = True
        btnAddChicken.Enabled = True
        btnCalculatePrice.Enabled = True
        cmdCrustType.Enabled = True
        cmbPizza.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddCheese.Click
        Dim pCheese As New Cheese

        If _pizza.Inventory.GetIngredientCount(pCheese) > 0 Then
            _pizza.AddIngredient(pCheese)
            lblCheesePortion.Text = _pizza.GetIngredientCount(pCheese) & "/" & _pizza.Inventory.GetIngredientCount(pCheese)
        Else
            MsgBox("Out of cheese")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAddOnion.Click
        Dim pOnion As New Onion

        If _pizza.Inventory.GetIngredientCount(pOnion) > 0 Then
            _pizza.AddIngredient(pOnion)
            lblOnionPortions.Text = _pizza.GetIngredientCount(pOnion) & "/" & _pizza.Inventory.GetIngredientCount(pOnion)
        Else
            MsgBox("Out of onion")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAddMeat.Click
        Dim pMeat As New Meat()

        If _pizza.Inventory.GetIngredientCount(pMeat) > 0 Then
            _pizza.AddIngredient(New Meat)
            lblMeatPortions.Text = _pizza.GetIngredientCount(pMeat) & "/" & _pizza.Inventory.GetIngredientCount(pMeat)
        Else
            MsgBox("We are out of Meat.")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnAddChicken.Click
        Dim pChicken As New Chicken
        If _pizza.Inventory.GetIngredientCount(pChicken) > 0 Then
            _pizza.AddIngredient(New Chicken)
            lblChicken.Text = _pizza.GetIngredientCount(pChicken) & "/" & _pizza.Inventory.GetIngredientCount(pChicken)
        Else
            MsgBox("Out of chicken")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCalculatePrice.Click
        lblPrice.Text = "$" & _pizza.GetPrice()
    End Sub

    Private Sub cmdCrustType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdCrustType.SelectedIndexChanged
        _pizza.CrustType = cmdCrustType.SelectedItem
    End Sub

    Private Sub cmbSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSize.SelectedIndexChanged
        _pizza.Size = cmbSize.Text
    End Sub

    Private Sub cmbPizza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPizza.SelectedIndexChanged

        If cmbPizza.Text = "Margarita Pizza" Then
            _pizza = New MargaritaPizza(_Inventory)
        Else
            _pizza = New Pizza(_Inventory)
        End If

        ' lblCheesePortion.Text = _pizza.CheesePortions & "/" & _pizza.Inventory.CheesePortions
        ' lblOnionPortions.Text = _pizza.OnionPortions & "/" & _pizza.Inventory.OnionPortions
        ' lblMeatPortions.Text = _pizza.MeatPortions & "/" & _pizza.Inventory.MeatPortions
        ' lblChicken.Text = _pizza.ChickenPortions & "/" & _pizza.Inventory.ChickenPortions
        cmbSize.Text = _pizza.Size
        cmdCrustType.SelectedItem = _pizza.CrustType

        lblPrice.Text = _pizza.GetPrice


    End Sub
End Class
