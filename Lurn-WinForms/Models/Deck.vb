Public Class Deck
    Shared AynRand As Random = New Random()
    Private _Cards As List(Of Card)

    Function PullCard()
        Return _Cards.ElementAt(AynRand.Next(_Cards.Count()))
    End Function

    Function PullCards(Num As Integer)
        Dim CardsList As List(Of Card) = New List(Of Card)
        For I = 0 To Num
            CardsList.Add(PullCard())
        Next
        Return CardsList
    End Function

    Sub Clear()
        _Cards.Clear()
    End Sub

    Sub AddCard(NewCard As Card)
        _Cards.Add(NewCard)
    End Sub
End Class
