Imports ModelsManager
Imports SqlSugar

Public Class ActiveItemService
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

    Public Sub Flush(item As ActiveItem)
        Dim db As SqlSugarClient = item.DBCilent
        Dim dbMain = db.DbMaintenance
        item.TableItems = dbMain.GetTableInfoList()
        item.ViewItems = dbMain.GetViewInfoList()
        item.FunctionItems = dbMain.GetFuncList()
        'item.IndexItems = dbMain.GetIndexList()
    End Sub
End Class
