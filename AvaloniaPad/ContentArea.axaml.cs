using Avalonia.Controls;

namespace AvaloniaPad;

public partial class ContentArea : UserControl
{
    static ContentArea Singleton;

    public ContentArea()
    {
        InitializeComponent();
        GetSingleton();
    }

    public static void Navigate(UserControl control)
    {
        if (Singleton == null)
            return;
        Singleton.Content = control;
    }

    public void GetSingleton()
    {
        if (Singleton == null)
            Singleton = this;
    }
}