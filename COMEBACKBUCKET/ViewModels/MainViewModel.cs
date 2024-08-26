using COMEBACKBUCKET.Views;
using CommunityToolkit.Mvvm.ComponentModel;

namespace COMEBACKBUCKET.ViewModels;

public partial class MainViewModel : ObservableRecipient
{

    [ObservableProperty]
    private Type _PageNavTo;                // 用于指定要导航到的目标（页面）

    public MainViewModel()
    {
        _PageNavTo = typeof(DataManagerPage);
    }

    public void SetPageNavTo(Type typePage)
    {
        PageNavTo = typePage;
    }

}
