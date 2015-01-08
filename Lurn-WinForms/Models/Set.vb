
' prefixed to avoid clash with keyword "Set"
Public Class LurnSet
    Public Property Cards As New List(Of Card)
    Public Property Name As String
    Public Property Id As String

    Public Sub New()
    End Sub

    Public Sub New(Id As String, Name As String, Cards As List(Of Card))
        Me.Id = Id
        Me.Name = Name
        Me.Cards = Cards
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("#<Set({0}) name={1}>", Id, Name)
    End Function
End Class
