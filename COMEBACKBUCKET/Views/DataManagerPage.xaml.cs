using COMEBACKBUCKET.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace COMEBACKBUCKET.Views;

public sealed partial class DataManagerPage : Page
{
    public DataManagerViewModel ViewModel
    {
        get;
    }

    public DataManagerPage()
    {
        ViewModel = App.GetService<DataManagerViewModel>();
        InitializeComponent();
    }
}
