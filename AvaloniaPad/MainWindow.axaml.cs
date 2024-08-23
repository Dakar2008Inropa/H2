using Avalonia.Controls;

namespace AvaloniaPad
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.CanResize = false;
            ContentArea.Navigate(new LoginForm());
        }
    }
}