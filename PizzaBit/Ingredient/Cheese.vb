Public Class Cheese
    Implements IIngredient

    Public Sub New()
        Name = "Cheese"
        Price = 0.5
    End Sub

    Public Property Name As String Implements IIngredient.Name

    Public Property Price As Double Implements IIngredient.Price
End Class
