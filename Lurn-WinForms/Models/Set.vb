
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
End Class
