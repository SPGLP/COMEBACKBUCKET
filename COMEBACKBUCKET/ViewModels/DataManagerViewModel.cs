using System.Drawing.Imaging;
using System.Drawing.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using COMEBACKBUCKET.Views.Components.DM;
using COMEBACKBUCKET.Models.MessagePack;
using CommunityToolkit.Mvvm.Messaging;

namespace COMEBACKBUCKET.ViewModels;

public partial class DataManagerViewModel : ObservableRecipient
{
    [ObservableProperty]
    private Type _workComponent;

    public DataManagerViewModel()
    {
        IsActive = true;
        WorkComponent = typeof(DM_Main);
    }

    protected override void OnActivated()
    {
        WeakReferenceMessenger.Default.Register<NavMessage>(this, (r, m) =>
        {
            WorkComponent = m.TargetPage; // 更新当前显示的页面
        });
    }

    protected override void OnDeactivated()
    {
        WeakReferenceMessenger.Default.Unregister<NavMessage>(this);
    }

}
