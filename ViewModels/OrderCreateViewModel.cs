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
        public decimal Price { get; set; }
    }
}
