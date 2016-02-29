Public Class CheeseCrustType
    Implements ICrustType

    Public Sub New()
        Name = "Cheese Crust Type"
    End Sub

    Public Function GetPrice() As Double Implements ICrustType.GetPrice
        Return 1.5
    End Function

    Public Property Name As String Implements ICrustType.Name

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
