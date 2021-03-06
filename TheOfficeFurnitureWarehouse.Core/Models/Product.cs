using System;
using TheOfficeFurnitureWarehouse.Core.Enums;

namespace TheOfficeFurnitureWarehouse.Core.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public ProductType ProductType { get; set; }
        public decimal StandardPrice { get; set; }
        public int Quantity { get; set; }
    }
}
