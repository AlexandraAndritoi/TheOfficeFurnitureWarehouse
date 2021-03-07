using System;

namespace TheOfficeFurnitureWarehouse.Core.Model
{
    public class Order : IEntity
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
    }
}
