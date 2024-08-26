using COMEBACKBUCKET.ViewModels;

using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace COMEBACKBUCKET.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
        InitFrame();
    }

    /// <summary>
    /// InitFrame()
    /// 作用：用于初始化APP页面框架的初始内容（页面）
    /// </summary>
    public void InitFrame()
    {
        APPFrame.Navigate(ViewModel.PageNavTo);
    }

    private void APPNav_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
    {
        FrameNavigationOptions navOptions = new FrameNavigationOptions();
        navOptions.TransitionInfoOverride = args.RecommendedNavigationTransitionInfo;
        if (sender.PaneDisplayMode == NavigationViewPaneDisplayMode.Top)
        {
            navOptions.IsNavigationStackEnabled = false;
        }
        if (args.InvokedItemContainer == NavItem_DM)
        {
            ViewModel.PageNavTo = typeof(DataManagerPage);
        }
        else if (args.InvokedItemContainer == NavItem_SQLE)
        {
            ViewModel.PageNavTo = typeof(SQLEditorPage);
        }
        else if (args.InvokedItemContainer == NavItem_VSD)
        {
            ViewModel.PageNavTo = typeof(VisualDataPage);
        }
        else
        {
            ViewModel.PageNavTo = typeof (SettingsPage);
        }
        APPFrame.NavigateToType(ViewModel.PageNavTo, null, navOptions);
    }
}
