Public Class Game
    Private _Deck As Deck
    Private _Score As Integer
    Private _PreShow As Queue(Of Play)
    Private _Current As Play
    Private _PostShow As Queue(Of Play)

    Public ReadOnly Property ActivePlay As Play
        Get
            Return _Current
        End Get
    End Property

    Sub PumpPlays()
        ' Push our Current onto the PostShow queue and truncate to 5
        _PostShow.Enqueue(_Current)
        If _PostShow.Count > 5 Then
            _PostShow.Dequeue()
        End If

        ' Pop off the last PreShow and make it our Current
        _Current = _PreShow.Dequeue()

        ' Pull a new PreShow card if PreShow is less than 5
        _PreShow.Enqueue(New Play(_Deck.PullCard(), _Deck.PullCards(4))
    End Sub
End Class
