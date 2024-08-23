using Avalonia.Controls;
using Avalonia.Input;
using AvaloniaMVVM.ViewModels;

namespace AvaloniaMVVM.Views;

public partial class ProductListView : UserControl
{
    public ProductListView()
    {
        InitializeComponent();
    }

    private void DataGrid_DoubleTapped(object sender, TappedEventArgs e)
    {
        if (ProductListDataGrid.SelectedItem is Models.Product product)
        {
            var window = new ProductDetailWindow
            {
                DataContext = new ProductDetailViewModel(product)
            };
            window.Show();
        }
    }
}