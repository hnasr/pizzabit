Public Class Chicken
    Implements IIngredient

    Public Sub New()
        Name = "Chicken"
        Price = 1
    End Sub

    Public Property Name As String Implements IIngredient.Name

    Public Property Price As Double Implements IIngredient.Price
End Class
