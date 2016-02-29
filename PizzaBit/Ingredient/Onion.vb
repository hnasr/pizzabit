Public Class Onion
    Implements IIngredient

    Public Sub New()
        Name = "Onion"
        Price = 0.1
    End Sub

    Public Property Name As String Implements IIngredient.Name

    Public Property Price As Double Implements IIngredient.Price
End Class
