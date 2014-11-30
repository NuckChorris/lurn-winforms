Imports <xmlns:Lurn="LurnPack.xsd">
Imports System.IO.FileInfo

Public Class Pack
    Public Property Sets As New Dictionary(Of String, LurnSet)
    Private ns As String

    Public Sub New(file As String)
        ns = My.Computer.FileSystem.GetFileInfo(file).Name

        For Each xmlSet In XElement.Load(file)...<Lurn:Set>
            Dim _set = New LurnSet()
            Sets.Add(xmlSet.@id, _set)
            _set.Id = ns & "#" & xmlSet.@id
            _set.Name = xmlSet.@name
            For Each xmlCard In xmlSet...<Lurn:Card>
                _set.Cards.Add(New Card(_set.Id & ":" & xmlCard.@id,
                                        xmlCard.<Lurn:Front>.Value,
                                        xmlCard.<Lurn:Back>.Value))
            Next
        Next
    End Sub

    Public ReadOnly Property Cards
        Get
            Dim lstCards As New List(Of Card)
            For Each _set In Sets
                lstCards.AddRange(_set.Value)
            Next
            Return lstCards
        End Get
    End Property
End Class