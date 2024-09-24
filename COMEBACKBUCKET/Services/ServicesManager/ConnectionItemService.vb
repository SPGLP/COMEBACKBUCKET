Imports ModelsManager
Imports SqlSugar

Public Class ConnectionItemService

    ''' <summary>
    ''' 开启ConnectionItem所配置的数据库连接
    ''' </summary>
    ''' <param name="workSpace">工作区Model</param>
    ''' <param name="item">待启动的ConnectionItem</param>
    ''' <param name="initACService">用于调用初始化功能的ActiveItemService</param>
    Public Sub Connect(workSpace As WorkSpace, item As ConnectionItem, initACService As ActiveItemService)
        If workSpace.ConnectionItems.Contains(item) Then
            Dim db As New SqlSugarClient(New ConnectionConfig() With {
                .ConnectionString = item.DBConf,
                .DbType = item.DBType,
                .IsAutoCloseConnection = False
            })
            Dim newActiveItem As New ActiveItem() With {
                .DBCilent = db,
                .Name = item.Name,
                .DBConf = item.DBConf,
                .DBType = item.DBType,
            }
            initACService.Flush(newActiveItem)
            workSpace.ActiveItems.Add(newActiveItem)
        End If
    End Sub

End Class
