Public Class Card
    Public Id As String
    Public Front As String
    Public Back As String
    Public Weight As Integer

    Public Sub New(Id As String, Front As String, Back As String, Optional Weight As Integer = 1)
        Me.Id = Id
        Me.Front = Front
        Me.Back = Back
        Me.Weight = Weight
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("#<Card({0}) Front={1} Back={2} Weight={3}>", Id, Front, Back, Weight)
    End Function
End Class