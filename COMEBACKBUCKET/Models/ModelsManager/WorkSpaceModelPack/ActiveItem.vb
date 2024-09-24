Imports SqlSugar

Public Class ActiveItem
    Inherits ConnectionItem

    Public Property DBCilent As SqlSugarClient
    Public Property TableItems As List(Of DbTableInfo)
    Public Property ViewItems As List(Of DbTableInfo)
    Public Property FunctionItems As List(Of String)
    Public Property IndexItems As List(Of String)

End Class
