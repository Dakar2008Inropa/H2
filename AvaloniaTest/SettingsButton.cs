using Avalonia.Controls;

namespace AvaloniaTest
{
    public class SettingsButton : Button
    {
        public event SettingsSavedEventHandler SettingsSaved;

        protected virtual void OnSettingsSaved(SettingsSavedEventArgs e)
        {
            SettingsSaved?.Invoke(this, e);
        }

        protected override void OnClick()
        {
            base.OnClick();

            OnSettingsSaved(new SettingsSavedEventArgs());
        }
    }
}