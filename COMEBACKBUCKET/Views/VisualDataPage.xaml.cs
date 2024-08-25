using COMEBACKBUCKET.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace COMEBACKBUCKET.Views;

public sealed partial class VisualDataPage : Page
{
    public VisualDataViewModel ViewModel
    {
        get;
    }

    public VisualDataPage()
    {
        ViewModel = App.GetService<VisualDataViewModel>();
        InitializeComponent();
    }
}
