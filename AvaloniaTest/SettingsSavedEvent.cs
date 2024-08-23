using System;

namespace AvaloniaTest
{
    public class SettingsSavedEventArgs : EventArgs
    {
    }

    public delegate void SettingsSavedEventHandler(object sender, SettingsSavedEventArgs e);
}