'Class have, properties  methods, and multiple constructors.. 
Public Class Pizza

    Protected _crusttype As ICrustType

    Private _ingredients As List(Of IIngredient)
    Private _unit_dough_price As Double = 3
      

    Public Sub New(pInventory As Inventory)
        _crusttype = New ThinCrustType()
        _inventory = pInventory
        _ingredients = New List(Of IIngredient)
    End Sub


    Protected _inventory As Inventory
    Public Property Inventory() As Inventory
        Get
            Return _inventory
        End Get
        Set(ByVal value As Inventory)
            _inventory = value
        End Set
    End Property


    Public Property CrustType() As ICrustType
        Get
            Return _crusttype
        End Get
        Set(ByVal value As ICrustType)
            _crusttype = value
        End Set
    End Property


    Public Sub AddIngredient(pIngredient As IIngredient)
        _ingredients.Add(pIngredient)
        Inventory.removeIngrident(pIngredient)
    End Sub

     
    Private _size As String
    Public Property Size() As String
        Get
            Return _size
        End Get
        Set(ByVal value As String)
            _size = value
        End Set
    End Property



    Public Function GetIngredientCount(pIngrident As IIngredient) As Integer
        Dim count As Integer = 0

        For Each ping As IIngredient In _ingredients
            If ping.Name = pIngrident.Name Then
                count += 1
            End If
        Next

        Return count
    End Function


    Public Function GetPrice() As Double

        Dim price As Double = 0
        price = _unit_dough_price '+ _cheeseportions * _unit_cheese_price + _meatportions * _unit_meat_price + _onionportions * _unit_onion_price + _chickenportions * _unit_chicken_price

        'loop
        Dim pIngredient As IIngredient
        For Each pIngredient In _ingredients
            price = price + pIngredient.Price
        Next


        ' If CrustType = "Thick" Then
        'price = price + _thickcrust_price
        'ElseIf CrustType = "Thin" Then
        'price = price + _thincrust_price
        'ElseIf CrustType = "Cheese" Then
        'price = price + _cheesecrusttype_price
        '        End If
        price = price + CrustType.GetPrice()
        'final price.. 

        If Size = "Large" Then
            price = price + price * 0.2
        End If

        If Size = "Medium" Then
            price = price + price * 0.1
        End If

        Return price
    End Function

     



End Class
