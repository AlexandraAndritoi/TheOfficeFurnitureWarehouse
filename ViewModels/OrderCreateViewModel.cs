using System.ComponentModel.DataAnnotations;

namespace TheOfficeFurnitureWarehouse.ViewModels
{
    public class OrderCreateViewModel
    {
        [Required]
        public string Customer { get; set; }

        [Required]
        public string Product { get; set; }

        [Required]
        [Range(0, 999.99)]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
