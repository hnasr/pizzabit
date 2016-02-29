Public Class Meat
    Implements IIngredient

    Public Sub New()
        Name = "Meat"
        Price = 1.5

    End Sub

    Public Property Name As String Implements IIngredient.Name

    Public Property Price As Double Implements IIngredient.Price
End Class
