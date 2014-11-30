Imports System.Collections.Specialized

Public Class Deck
    Shared _rand As New Random
    Private _cards As New OrderedDictionary ' Card.Id => WeightedCard
    Private _total As Integer = 0

    Public Sub New(cards As List(Of Card))
        For Each _card In From card In cards Order By card.Weight Descending Select card
            _total += _card.Weight
            _cards.Add(_card.Id, _card)
        Next
    End Sub

    ' TODO: stop sorting maybe?

    ' Resort the list by weights and sum the weights for our RNG
    ' Uses an Insertion Sort, instead of the built-in sorting algorithm.
    ' This is Insertion Sort's best-case, O(n), and QuickSort's worst-case, O(n^2)
    Public Sub Refresh()
        SyncLock Me
            Dim total = _cards(1).Weight
            ' For each node, S
            For s = 1 To _cards.Count - 1
                total += _cards(s).Weight
                ' Step backwards, D
                For d = s - 1 To 0 Step -1
                    ' Until you hit a node with >= Weight, or 0
                    If _cards(d).Weight >= _cards(s).Weight Or d = 0 Then
                        Dim key = _cards.Keys(s)
                        Dim value = _cards(s)
                        ' Remove the original S
                        _cards.RemoveAt(s)
                        ' Then, insert S after D
                        _cards.Insert(d + 1, key, value)
                    End If
                Next
            Next
            _total = total
        End SyncLock
    End Sub

    ' TODO: ignore recently-pulled cards N% of the time or downrank them somehow
    Private Function RandomIndex(cards As List(Of Card), total As Integer) As Integer
        Dim target = _rand.Next(total)
        Dim sum = 0 ' chinese food
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
