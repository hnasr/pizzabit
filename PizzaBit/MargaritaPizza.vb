Public Class MargaritaPizza
    Inherits Pizza


    Public Sub New(pInventory As Inventory)
        MyBase.New(pInventory)
        _crusttype = New ThinCrustType()
        _inventory = pInventory

        'add your flavors.. 
        AddIngredient(New Cheese)
        AddIngredient(New Onion)


    End Sub


End Class
