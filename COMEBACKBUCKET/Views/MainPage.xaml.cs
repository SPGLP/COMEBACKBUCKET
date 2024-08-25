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
    /// InitNavText() : void
    /// 作用：用于初始化导航栏的项目和文本
    /// </summary>

    /// <summary>
    /// InitFrame()
    /// 作用：用于初始化APP页面框架的初始内容（页面）
    /// </summary>
    public void InitFrame()
    {
        APPFrame.Navigate(typeof(DataManagerPage));
    }

    private void APPNav_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
    {
        FrameNavigationOptions navOptions = new FrameNavigationOptions();
        navOptions.TransitionInfoOverride = args.RecommendedNavigationTransitionInfo;
        if (sender.PaneDisplayMode == NavigationViewPaneDisplayMode.Top)
        {
            navOptions.IsNavigationStackEnabled = false;
        }
        Type pageType;
        if (args.InvokedItemContainer == NavItem_DM)
        {
            pageType = typeof(DataManagerPage);
        }
        else if (args.InvokedItemContainer == NavItem_SQLE)
        {
            pageType = typeof(SQLEditorPage);
        }
        else if (args.InvokedItemContainer == NavItem_VSD)
        {
            pageType = typeof(VisualDataPage);
        }
        else
        {
            pageType = typeof (SettingsPage);
        }
        APPFrame.NavigateToType(pageType, null, navOptions);
    }
}
