Public Class Game
    Const NUMBER_OF_CHOICES As Integer = 4
    Public Box As New Box
    Public Deck As Deck
    Private _Score As Integer = 0
    ' Honestly I don't display any of the pre or postshow stuff, that's something I'll do
    ' when I port to WPF and Windows Runtime
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
        Dim NewPlay As Play = New Play(Deck.PullCards(1)(0), Deck.PullCards(NUMBER_OF_CHOICES))
        _PreShow.Enqueue(NewPlay)
    End Sub

    Public Function ToXML() As XElement
        ' TODO
        Return <GameState></GameState>
    End Function
End Class
