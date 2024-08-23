using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace AvaloniaPad;

public partial class LoginForm : UserControl
{
    static LoginForm Singleton;

    private static string _username = "dakar2008";
    private static string _password = "Dakar1326";

    public UserLogin currentUser { get; set; }

    public LoginForm()
    {
        InitializeComponent();
        SetSingleton();
        currentUser = new UserLogin();
        DataContext = currentUser;
    }

    private void SetSingleton()
    {
        if (Singleton == null)
            Singleton = this;
    }

    public LoginForm GetSingleton()
    {
        return Singleton == null ? new LoginForm() : Singleton;
    }

    private void Loginbox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            CheckLogin();
        }
        else
        {
            LoginErrorText.IsVisible = false;
            e.Handled = false;
        }
    }

    private void Usernamebox_AttachedToVisualTree(object sender, VisualTreeAttachmentEventArgs e)
    {
        TextBox box = (TextBox)sender;
        box.Focus();
    }

    private void Loginbox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (Usernamebox.Text != null && Usernamebox.Text?.Length > 0 && Passwordbox.Text != null && Passwordbox.Text?.Length > 0)
        {
            LoginBtn.Opacity = 1;
            LoginBtn.IsEnabled = true;

            ResetBtn.Opacity = 1;
            ResetBtn.IsEnabled = true;
        }
        else
        {
            LoginBtn.Opacity = 0.1;
            LoginBtn.IsEnabled = false;

            ResetBtn.Opacity = 0.1;
            ResetBtn.IsEnabled = false;
        }
    }

    private void CheckLogin()
    {
        if (Usernamebox.Text.Length > 0 && Passwordbox.Text.Length > 0 && currentUser.Username == _username && currentUser.Password == _password)
        {
            ContentArea.Navigate(new MainView());
        }
        else
        {
            LoginErrorText.IsVisible = true;
            Usernamebox.SelectAll();
            Usernamebox.Focus();
        }
    }

    private void LoginBtn_Click(object sender, RoutedEventArgs e)
    {
        CheckLogin();
    }

    private void ResetBtn_Click(object sender, RoutedEventArgs e)
    {
        Usernamebox.Text = "";
        Passwordbox.Text = "";
        LoginErrorText.IsVisible = false;
        Usernamebox.Focus();
    }
}