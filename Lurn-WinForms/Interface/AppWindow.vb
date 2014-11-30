Public Class AppWindow
    Dim _game As New Game
    Dim sets As New List(Of String)({"KanaPack.xml#hira-vowels", "KanaPack.xml#hira-k"})

    Private Sub AppWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'StatusWindow.Show(Me)

        ' KanaPack create and shit
        Dim Pack = New Pack("Data/KanaPack.xml")
        _game.Box.Add(Pack)

        ' Load the deck
        _game.Deck = _game.Box.Deck(sets)

        Console.WriteLine("Cards:")
        For Each pulled In _game.Deck.PullCards(4)
            Console.WriteLine(pulled)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Console.WriteLine("---")
        For Each pulled In _game.Deck.PullCards(4)
            Console.WriteLine(pulled)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Console.WriteLine("---")
        Console.WriteLine(_game.Box)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim aCard = _game.Deck.PullCards(1)(0)
        aCard.Weight = 20
        _game.Deck.Refresh()
    End Sub
End Class
