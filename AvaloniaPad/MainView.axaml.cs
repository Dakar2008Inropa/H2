using Avalonia.Controls;

namespace AvaloniaPad;

public partial class MainView : UserControl
{
    static MainView Singleton;

    public MainView()
    {
        InitializeComponent();
        SetSingleton();
    }

    private void SetSingleton()
    {
        if (Singleton == null)
            Singleton = this;
    }

    private void StatusBarBtn_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        StatusBar.IsVisible = StatusBarBtn.IsChecked;
    }

    private async void AppearanceBtn_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var ownerWindow = VisualRoot as Window;
        var appearanceWindow = new AppearanceWindow();
        await appearanceWindow.ShowDialog(ownerWindow);
    }

    private void UserControl_Loaded(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var ownerWindow = VisualRoot as Window;
        ownerWindow.Width = 800;
        ownerWindow.Height = 600;
        ownerWindow.CanResize = true;
    }
}