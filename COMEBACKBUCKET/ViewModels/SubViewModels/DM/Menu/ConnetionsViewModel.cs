using System;

using COMEBACKBUCKET.Views.Components.DM;
using ViewInterfacesManager;

namespace COMEBACKBUCKET.ViewModels;

/// <summary>
/// DM菜单：“连接”的 ViewModel 分部类
/// </summary>
public partial class DataManagerViewModel : IConnections
{
    public void AddNew()
    {
         WorkComponent = typeof(DM_NewConnection);
    }
    public void CheckAll() => throw new NotImplementedException();
    public void ConnetionOff() => throw new NotImplementedException();
    public void ConnetionOn() => throw new NotImplementedException();
    public void Delete() => throw new NotImplementedException();
    public void Edit() => throw new NotImplementedException();
    public void ExitAPP() => throw new NotImplementedException();
    public void Fliter() => throw new NotImplementedException();
    public void Flush() => throw new NotImplementedException();

}
