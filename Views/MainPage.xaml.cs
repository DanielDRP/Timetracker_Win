using Microsoft.UI.Xaml.Controls;

using Timetracker.ViewModels;

namespace Timetracker.Views;

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
    }
}
