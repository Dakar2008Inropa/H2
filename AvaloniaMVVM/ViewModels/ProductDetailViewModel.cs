using AvaloniaMVVM.Models;
using ReactiveUI;

namespace AvaloniaMVVM.ViewModels
{
    public class ProductDetailViewModel : ViewModelBase
    {
        private Product _Product;
        private string _DisplayProductText;

        public ProductDetailViewModel(Product selectedProduct)
        {
            _Product = selectedProduct;
            _DisplayProductText = $"Viewing - {selectedProduct.Name}";
        }

        public Product Product
        {
            get => _Product;
            set => this.RaiseAndSetIfChanged(backingField: ref _Product, newValue: value, propertyName: nameof(Product));
        }
        public string DisplayProductText
        {
            get => _DisplayProductText;
            set => this.RaiseAndSetIfChanged(backingField: ref _DisplayProductText, newValue: value, propertyName: nameof(DisplayProductText));
        }
    }
}