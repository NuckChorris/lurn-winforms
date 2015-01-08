Public Class Deck
    Shared _rand As New Random
    Private _cards As New Dictionary(Of String, Card)
    Private _total As Integer = 0

    Public Sub New(cards As List(Of Card))
        For Each _card In From card In cards Order By card.Weight Descending Select card
            _total += _card.Weight
            _cards.Add(_card.Id, _card)
        Next
    End Sub

    ' TODO: switch to a bottom-up event-driven refresh
    Public Sub Refresh()
        _total = _cards.Values.Aggregate(0, Function(acc, cur) acc + cur.Weight)
    End Sub

    ' TODO: ignore recently-pulled cards N% of the time or downrank them somehow
    Private Function RandomIndex(cards As List(Of Card), total As Integer) As Integer
        Dim target = _rand.Next(total)
        Dim sum = 0 ' lol @ dim sum
        For i = 0 To cards.Count - 1
            sum += cards(i).Weight
            If sum >= target Then
                Return i
            End If
        Next
        Throw New Exception("U WOT M8")
    End Function

    Public Function PullCards(Num As Integer) As List(Of Card)
        Dim possibilities As New List(Of Card)(_cards.Values.Cast(Of Card).ToList())
        Dim total = _total
        Dim cardList As New List(Of Card)

        For i = 1 To Math.Min(_cards.Count, Num)
            Dim ri = RandomIndex(possibilities, total)
            Dim card = possibilities(ri)

            ' Add the card to the output List
            cardList.Add(card)

            ' Subtract the removed card's weight from the total and remove it from the possibilities
            total -= card.Weight
            possibilities.RemoveAt(ri)
        Next
        Return cardList
    End Function
End Class
