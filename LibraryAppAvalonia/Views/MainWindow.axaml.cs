using Avalonia.Controls;

namespace LibraryAppAvalonia.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnSizeChanged(object sender, SizeChangedEventArgs e)
    {
        if (mainView.Content is SplitView splitView)
        {
            if (e.NewSize.Width < 800)
            {
                if (splitView.IsPaneOpen)
                {
                    splitView.IsPaneOpen = false;
                }
            }
            else
            {
                if (!splitView.IsPaneOpen)
                {
                    splitView.IsPaneOpen = true;
                }
            }
        }
    }
}