Imports System.ComponentModel

''' <summary>
''' Orchestrates the entire game, exposing changes in state via events following
''' the INotifyPropertyChanged interface.
''' </summary>
''' <remarks></remarks>
Public Class Game
    Implements INotifyPropertyChanged

    Const NUMBER_OF_CHOICES As Integer = 4
    Const BONUS_PERIOD As Integer = 5000 ' milliseconds
    Const INTERVAL = 100

    Private WithEvents _timer As New System.Timers.Timer(INTERVAL)

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Property Box As New Box
    Private _Sets As New List(Of String)
    Private _Deck As Deck
    Public Property Score As Integer = 0
    ' Honestly I don't display any of the pre or postshow stuff outside the debugger window.
    ' That's something I'll do when I port to WPF and Windows Runtime and sell on the Store.
    Public Property PreShow As New Queue(Of Play)
    Public Property PostShow As New Queue(Of Play)
    Public Property Current As Play
    Public Property TimeLeft As Integer = BONUS_PERIOD

    Public ReadOnly Property Deck As Deck
        Get
            If _Deck Is Nothing Then
                _Deck = Box.Deck(_Sets)
            End If
            Return _Deck
        End Get
    End Property

    Public Property Sets As List(Of String)
        Get
            Return _Sets
        End Get
        Set(value As List(Of String))
            _Deck = Box.Deck(value)
            _Sets = value
            OnPropertyChanged("Sets")
        End Set
    End Property

    ' TODO: Switch to time subtraction for improved accuracy
    Private Sub timer_Tick() Handles _timer.Elapsed
        If TimeLeft > 0 Then
            TimeLeft -= INTERVAL
            OnPropertyChanged("TimeLeft")
        Else
            _timer.Stop()
        End If
    End Sub

    Public Sub Start()
        For I = 1 To 5
            Dim cards = Deck.PullCards(NUMBER_OF_CHOICES)
            Dim Play As New Play(cards(0), cards.GetRange(1, NUMBER_OF_CHOICES - 1))
            PreShow.Enqueue(Play)
        Next
        _timer.Start()
        Pump()
    End Sub

    Public Sub Finish()
        _timer.Stop()
    End Sub

    Public Sub Pump()
        SyncLock Me
            TimeLeft = BONUS_PERIOD
            _timer.Start()
            OnPropertyChanged("TimeLeft")

            ' Push our Current onto the PostShow queue and truncate to 5
            If Not IsNothing(Current) Then
                PostShow.Enqueue(Current)
            End If
            If PostShow.Count > 5 Then
                PostShow.Dequeue()
            End If
            OnPropertyChanged("PostShow")

            ' Pop off the last PreShow and make it our Current
            Current = PreShow.Dequeue()
            OnPropertyChanged("Current")

            ' Pull a new PreShow card if PreShow is less than 5
            Dim cards = Deck.PullCards(NUMBER_OF_CHOICES)
            Dim NewPlay As Play = New Play(cards(0), cards.GetRange(1, NUMBER_OF_CHOICES - 1))
            PreShow.Enqueue(NewPlay)
            OnPropertyChanged("PreShow")
        End SyncLock
    End Sub

    Public Function ToXML() As XElement
        ' TODO
        Return <GameState></GameState>
    End Function

    Protected Sub OnPropertyChanged(ByVal name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub
End Class
