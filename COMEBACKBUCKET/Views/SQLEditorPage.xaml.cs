using COMEBACKBUCKET.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace COMEBACKBUCKET.Views;

public sealed partial class SQLEditorPage : Page
{
    public SQLEditorViewModel ViewModel
    {
        get;
    }

    public SQLEditorPage()
    {
        ViewModel = App.GetService<SQLEditorViewModel>();
        InitializeComponent();
    }
}
