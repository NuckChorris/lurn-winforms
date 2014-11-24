Public Class Play
    Private _Question As Card
    Private _Answers As List(Of Card)
    Private _Flipped As Boolean

    Public Sub New(Question As Card, Answers As List(Of Card))
        _Question = Question
        _Answers = Answers
    End Sub

    Public ReadOnly Property StringQuestion As String
        Get
            If _Flipped Then
                Return _Question.Back
            Else
                Return _Question.Front
            End If
        End Get
    End Property

    Public ReadOnly Property StringAnswers As List(Of String)
        Get
            If _Flipped Then
                Return From Answer In _Answers Select Answer.Front
            Else
                Return From Answer In _Answers Select Answer.Back
            End If
        End Get
    End Property

    Public Function Inspect() As String
        Dim Builder As System.Text.StringBuilder
        Builder.Append("#<Play ")
        Builder.Append(String.Format("Question=%s", StringQuestion))
        Builder.Append(String.Format("Answers=%s", String.Join(",", StringAnswers.ToArray())
        Builder.Append(">")
        Return Builder.ToString()
    End Function
End Class
