using System.Drawing.Imaging;
using System.Drawing.Text;
using CommunityToolkit.Mvvm.ComponentModel;

using COMEBACKBUCKET.Views.Components.DM;

namespace COMEBACKBUCKET.ViewModels;

public partial class DataManagerViewModel : ObservableRecipient
{
    [ObservableProperty]
    private Type _workComponent;

    public DataManagerViewModel()
    {
        WorkComponent = typeof(DM_Main);
    }

}
