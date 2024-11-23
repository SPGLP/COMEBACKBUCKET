Imports ModelsManager
Imports SqlSugar

Public Class ActiveItemService
    ''' <summary>
    ''' 关闭活动状态的数据库连接
    ''' </summary>
    ''' <param name="workSpace">目标的 workSpace 类</param>
    ''' <param name="item">目标的 ActiveItem 类</param>
    Public Sub UnConnect(workSpace As WorkSpace, item As ActiveItem)
        If workSpace.ActiveItems.Contains(item) Then
            workSpace.ConnectionItems.Add(New ConnectionItem() With {
                .Name = item.Name,
                .DBConf = item.DBConf,
                .DBType = item.DBType
            })
            item.DBCilent.Close()
            workSpace.ActiveItems.Remove(item)
        Else
            Debug.WriteLine("item is not element of ActiveItems")
        End If
    End Sub

    ''' <summary>
    ''' 刷新连接的数据库内容
    ''' </summary>
    ''' <param name="item">目标的 ActiveItem 类</param>
    Public Sub Flush(item As ActiveItem)
        Dim db As SqlSugarClient = item.DBCilent
        Dim dbMain = db.DbMaintenance
        item.TableItems = dbMain.GetTableInfoList()
        item.ViewItems = dbMain.GetViewInfoList()
        item.FunctionItems = dbMain.GetFuncList()
        item.IndexItems = dbMain.GetIndexList(item.Name)
    End Sub
End Class
