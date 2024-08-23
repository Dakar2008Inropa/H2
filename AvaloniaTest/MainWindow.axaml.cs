using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace AvaloniaTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox thisCombo = (ComboBox)sender;
            string selected = ((ComboBoxItem)thisCombo.SelectedItem).Content.ToString();

            this.Title = selected;
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Calendar thisCalendar = (Calendar)sender;
            if (thisCalendar.SelectedDates.Count > 4)
                thisCalendar.IsVisible = false;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key < Key.D0 || e.Key > Key.D9) && (e.Key < Key.NumPad0 || e.Key > Key.NumPad9))
                e.Handled = true;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox thisBox = (TextBox)sender;
            int number = int.Parse(thisBox.Text);
            if (number == 0)
            {
                thisBox.Text = "1";
                number = 1;
            }

            thisBox.FontSize = number * 10;
        }
    }
}