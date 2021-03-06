using System;
using System.ComponentModel.DataAnnotations;
using TheOfficeFurnitureWarehouse.Core.Enum;

namespace TheOfficeFurnitureWarehouse.Core.Model
{
    public class Product : IEntity
    {
        public Guid Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required]
        public ProductType ProductType { get; set; }

        [Required]
        [Range(0, 999.99)]
        public decimal StandardPrice { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
