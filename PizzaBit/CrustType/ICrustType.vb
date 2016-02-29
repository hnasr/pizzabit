Public Interface ICrustType

    ''' <summary>
    ''' The name of the crust type 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Property Name() As String

    ''' <summary>
    ''' Return the price of the crust type
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetPrice() As Double

   
End Interface
