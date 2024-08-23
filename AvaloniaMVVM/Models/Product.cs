using System;

namespace AvaloniaMVVM.Models
{
    public class Product
    {
        public string ProductNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal Price { get; set; }
        public float Quantity { get; set; }
        public ProductUnit UnitType { get; set; }
        public bool Hidden { get; set; }
        public DateTime CampaignEnd { get; set; }
    }
}