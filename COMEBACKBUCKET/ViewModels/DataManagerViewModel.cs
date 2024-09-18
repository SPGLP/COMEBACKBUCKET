using System.Drawing.Imaging;
using System.Drawing.Text;
using CommunityToolkit.Mvvm.ComponentModel;

using COMEBACKBUCKET.Views.Components.DM;

namespace COMEBACKBUCKET.ViewModels;

public partial class DataManagerViewModel : ObservableRecipient
{
    private Type _workComponent;

    public Type WorkComponent {get; set;}

    public DataManagerViewModel()
    {
        WorkComponent = typeof(DM_Main);
    }
}
