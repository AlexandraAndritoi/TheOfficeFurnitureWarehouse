using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheOfficeFurnitureWarehouse.Business.Services.Products;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Pages.Views.Products
{
    public class ProductListModel : PageModel
    {
        private readonly IReadProductService productService;

        public IEnumerable<Product> Products { get; set; }

        public ProductListModel(IReadProductService productService)
        {
            this.productService = productService;
        }

        public void OnGet()
        {
            Products = productService.GetProductsOrderedByName();
        }
    }
}
