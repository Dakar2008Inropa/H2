using AvaloniaMVVM.Models;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;

namespace AvaloniaMVVM.ViewModels
{
    public class ProductListViewModel : ViewModelBase
    {
        private ObservableCollection<Product> _Products;

        public ObservableCollection<Product> Products
        {
            get => _Products;
            set => this.RaiseAndSetIfChanged(backingField: ref _Products, newValue: value, propertyName: nameof(Products));
        }

        public ProductListViewModel()
        {
            _Products = new ObservableCollection<Product>
            {
                new Product { Name = "Product 1", SalesPrice = 100, Price = 75, Quantity = 5, CampaignEnd = DateTime.Now.AddDays(-3) },
                new Product { Name = "Product 2", SalesPrice = 200, Price = 125, Quantity = 10, CampaignEnd = DateTime.Now.AddDays(-5) },
                new Product { Name = "Product 3", SalesPrice = 300, Price = 150, Quantity = 12, CampaignEnd = DateTime.Now.AddDays(-8) },
            };
        }
    }
}