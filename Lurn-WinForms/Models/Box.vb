Public Class Box
    Public Property Packs As New List(Of Pack)
    Public Property Sets As New Dictionary(Of String, LurnSet)

    Public Sub Add(newPack As Pack)
        _Packs.Add(newPack)

        For Each _set In newPack.Sets.Values
            Sets.Add(_set.Id, _set)
        Next
    End Sub

    Public Function Deck(setIds As List(Of String)) As Deck
        Dim cards As New List(Of Card)
        For Each id In setIds
            cards.AddRange(Sets(id).Cards)
        Next
        Return New Deck(cards)
    End Function

    Public ReadOnly Property Cards As List(Of Card)
        Get
            Dim _cards As New List(Of Card)
            For Each _set In Sets
                _cards.AddRange(_set.Value.Cards)
            Next
            Return _cards
        End Get
    End Property


    Public Function ToXml() As XElement
        Return <Box>
                   <%= From card In Cards Select <Card id=<%= card.Id %> value=<%= card.Weight %>/> %>
               </Box>
    End Function

    Public Overrides Function ToString() As String
        Return Me.ToXml().ToString()
    End Function
End Class
