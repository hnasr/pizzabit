Public Class Inventory

    Private _ingredientsInventory As List(Of IIngredient)
    Public Property Ingredients() As List(Of IIngredient)
        Get
            Return _ingredientsInventory
        End Get
        Set(ByVal value As List(Of IIngredient))
            _ingredientsInventory = value
        End Set
    End Property
     
    Public Sub New()

        Ingredients = New List(Of IIngredient)

        For i As Integer = 1 To 10
            Ingredients.Add(New Meat)
        Next


        For i As Integer = 1 To 10
            Ingredients.Add(New Cheese)
        Next

        For i As Integer = 1 To 15
            Ingredients.Add(New Chicken)
        Next

        For i As Integer = 1 To 14
            Ingredients.Add(New Onion)
        Next

    
    End Sub
     


    Public Function GetIngredientCount(pIngrident As IIngredient) As Integer
        Dim count As Integer = 0

        For Each ping As IIngredient In Ingredients
            If ping.Name = pIngrident.Name Then
                count += 1
            End If
        Next

        Return count
    End Function


    Public Function removeIngrident(pIngrident As IIngredient) As Boolean
         
        If GetIngredientCount(pIngrident) = 0 Then Return False

        For i As Integer = 0 To Ingredients.Count - 1
            Dim ping As IIngredient = Ingredients(i)
            If pIng.Name = pIngrident.Name Then
                Ingredients.RemoveAt(i)
                Return True
            End If
        Next

        Return True

    End Function



End Class
