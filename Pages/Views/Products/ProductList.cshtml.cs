using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Pages.Views.Products
{
    public class ProductListModel : PageModel
    {
        public IEnumerable<Product> Products { get; set; }
        public void OnGet()
        {
            Products = new List<Product>();
        }
    }
}
