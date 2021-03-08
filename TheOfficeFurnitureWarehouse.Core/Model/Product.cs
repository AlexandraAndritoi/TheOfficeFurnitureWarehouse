using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheOfficeFurnitureWarehouse.Core.Enum;

namespace TheOfficeFurnitureWarehouse.Core.Model
{
    public class Product : IEntity
    {
        public Guid Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Product Type")]
        public ProductType ProductType { get; set; }

        [Required]
        [Range(0, 999.99)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
