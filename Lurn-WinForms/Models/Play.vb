Public Class Play
    Public Question As Card
    Public Answers As List(Of Card)
    Private _Flipped As Boolean

    Public Sub New(Question As Card, Answers As List(Of Card))
        Me.Question = Question
        Me.Answers = Answers
        Me.Answers.Add(Question)
        ' TODO: shuffle answers so it's not always at the same index
    End Sub

    Public ReadOnly Property StringQuestion As String
        Get
            If _Flipped Then
                Return Question.Back
            Else
                Return Question.Front
            End If
        End Get
    End Property

    Public ReadOnly Property StringAnswers As List(Of String)
        Get
            If _Flipped Then
                Return (From Answer In Answers Select Answer.Front).ToList()
            Else
                Return (From Answer In Answers Select Answer.Back).ToList()
            End If
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("#<Play Question={0} Answers={1}>",
                             StringQuestion,
                             String.Join(",", StringAnswers.ToArray()))
    End Function
End Class
