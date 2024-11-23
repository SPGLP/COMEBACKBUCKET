Imports System.Collections.ObjectModel

Public Class WorkSpace
    Public Property ConnectionItems As ObservableCollection(Of ConnectionItem)
    Public Property ActiveItems As ObservableCollection(Of ActiveItem)
    Public Property SaveFilePath As String
End Class
