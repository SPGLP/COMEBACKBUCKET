Imports System.Reflection.Metadata.Ecma335
Imports SqlSugar

Public Class ConnectionItem
    Public Property Name As String
    Public Property DBConf As String
    Public Property DBType As DbType

    Public Overrides Function ToString() As String
        Return $"Name = {Name}, DBConf = {DBConf}, DBType = {DBType}"
    End Function
End Class
