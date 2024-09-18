Public Interface IConnetion

    ''' <summary>
    ''' 接口功能：添加新链接
    ''' </summary>
    Sub AddNew()

    ''' <summary>
    ''' 接口功能：删除链接
    ''' </summary>
    Sub Delete()

    ''' <summary>
    ''' 接口功能：编辑链接
    ''' </summary>
    Sub Edit()

    ''' <summary>
    ''' 接口功能：打开链接
    ''' </summary>
    Sub ConnetionOn()

    ''' <summary>
    ''' 接口功能：关闭链接
    ''' </summary>
    Sub ConnetionOff()

    ''' <summary>
    ''' 接口功能：检查所有链接
    ''' </summary>
    Sub CheckAll()

    ''' <summary>
    ''' 接口功能：刷新链接列表
    ''' </summary>
    Sub Flush()

    ''' <summary>
    ''' 接口功能：链接过滤器
    ''' </summary>
    Sub Fliter()

    ''' <summary>
    ''' 接口功能：退出应用
    ''' </summary>
    Sub ExitAPP()

End Interface
