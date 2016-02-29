Public Class AppleCrustType
    Implements ICrustType
    Public Sub New()
        Name = "Apple Crust Type"
    End Sub
    Public Function GetPrice() As Double Implements ICrustType.GetPrice
        Return 2
    End Function

    Public Property Name As String Implements ICrustType.Name

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
