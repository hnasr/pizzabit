Public Class ThinCrustType
    Implements ICrustType

    Public Sub New()
        Name = "Thin Crust Type"
    End Sub

    Public Function GetPrice() As Double Implements ICrustType.GetPrice
        Return 0.5
    End Function

    Public Property Name As String Implements ICrustType.Name

    Public Overrides Function ToString() As String
        Return Name
    End Function


End Class
