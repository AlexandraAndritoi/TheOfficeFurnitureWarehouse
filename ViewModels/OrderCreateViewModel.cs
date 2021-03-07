using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheOfficeFurnitureWarehouse.ViewModels
{
    public class OrderCreateViewModel
    {
        [Required]
        [Display(Name = "Customer")]
        public string SelectedCustomer { get; set; }

        public IEnumerable<SelectListItem> Customers { get; set; }

        [Required]
        [Display(Name = "Product")]
        public string SelectedProduct { get; set; }

        public IEnumerable<SelectListItem> Products { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
