using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheOfficeFurnitureWarehouse.Core.Model
{
    public class Order : IEntity
    {
        public Guid Id { get; set; }

        public Customer Customer { get; set; }

        public Product Product { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
