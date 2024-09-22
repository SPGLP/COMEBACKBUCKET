using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using COMEBACKBUCKET.ViewModels.SubViewModels.DM.DM_NewConnection;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace COMEBACKBUCKET.Views.Components.DM;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class DM_NewConnection : Page
{
    public NewConnectionViewModel ViewModel
    {
        get;
    }

    public DM_NewConnection()
    {
        ViewModel = App.GetService<NewConnectionViewModel>();
        this.InitializeComponent();
    }

    private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        if (e.NewSize.Width < 750) // 设定一个阈值
        {
            // VisualStateManager.GoToState(this, "Narrow", false);
            ScreenNarrowMode();
        }
        else
        {
            // VisualStateManager.GoToState(this, "Wide", false);
            ScreenWideMode();
        }
    }

    private void ScreenNarrowMode()
    {
        Grid.SetColumn(S_NormalSetting, 0);
        Grid.SetRow(S_NormalSetting, 1);
        S_NormalSetting.Margin = new Thickness(0, 30, 0, 0);
        S_NewConnectionSetting.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
    }

    private void ScreenWideMode()
    {
        Grid.SetColumn(S_NormalSetting, 1);
        Grid.SetRow(S_NormalSetting, 0);
        S_NormalSetting.Margin = new Thickness(50, 0, 0, 0);
        S_NormalSetting.VerticalScrollMode = ScrollMode.Auto;
        S_NewConnectionSetting.VerticalScrollBarVisibility= ScrollBarVisibility.Disabled;
    }
}
