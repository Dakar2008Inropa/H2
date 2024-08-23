using Avalonia.Controls;

namespace AvaloniaTest;

public partial class SettingsUC : UserControl
{
    public SettingsUC()
    {
        InitializeComponent();
    }

    private void SettingsButton_SettingsSaved(object sender, SettingsSavedEventArgs e)
    {
        SettingsButton thisButton = (SettingsButton)sender;
        thisButton.Width = 120;
        thisButton.Content = "Settings Saved";
    }
}