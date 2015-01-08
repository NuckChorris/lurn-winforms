Public Class AppWindow
    Private SETS = New List(Of String)({"KanaPack.xml#hira-vowels", "KanaPack.xml#hira-k"})
    Private WithEvents _Game As New Game
    Public Delegate Sub RedrawDelegate(ByVal Prop As String)

    Private Sub AppWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#If DEBUG Then
        DebugWindow.Game = _Game
        DebugWindow.Show(Me)
#End If

        ' Load up the Kana pack, add it to the box, and then generate the deck
        Dim Pack = New Pack("Data/KanaPack.xml")
        _Game.Box.Add(Pack)
        _Game.Sets = SETS
        _Game.Start()
    End Sub

    Public Sub Redraw(ByVal Prop As String)
        Select Case Prop
            Case "Current"
                Me.Question.Text = _Game.Current.StringQuestion
                Me.Answer1.Text = _Game.Current.StringAnswers(0)
                Me.Answer2.Text = _Game.Current.StringAnswers(1)
                Me.Answer3.Text = _Game.Current.StringAnswers(2)
                Me.Answer4.Text = _Game.Current.StringAnswers(3)
            Case "Score"
                Me.ScoreLabel.Text = _Game.Score
            Case "TimeLeft"
                Me.TimerLabel.Text = (_Game.TimeLeft / 1000).ToString("N2") & "s"
        End Select
    End Sub

    Private Sub Game_PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles _Game.PropertyChanged
        Me.Invoke(TryCast(AddressOf Redraw, RedrawDelegate), {e.PropertyName})
    End Sub

    Private Sub Answer_Click(sender As Button, e As EventArgs) Handles Answer1.Click, Answer2.Click, Answer3.Click, Answer4.Click
        Dim answerCard As Card = _Game.Current.Answers(CInt(sender.Tag))
        ' TODO: score the play
        If _Game.Current.Question Is answerCard Then
            Me.CorrectnessLabel.Text = "Right!"
        Else
            Me.CorrectnessLabel.Text = "Wrong!"
        End If
        _Game.Pump()
    End Sub

    Private Sub AppWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' TODO: switch to real destructors
        _Game.Finish()
    End Sub
End Class
