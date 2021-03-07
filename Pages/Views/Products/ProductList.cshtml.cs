using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheOfficeFurnitureWarehouse.Business.Services.Products;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Pages.Views.Products
{
    public class ProductListModel : PageModel
    {
        private readonly IProductService productService;

        public IEnumerable<Product> Products { get; set; }

        public ProductListModel(IProductService productService)
        {
            this.productService = productService;
        }

        public void OnGet()
        {
            Products = productService.GetProductsOrderedByName();
        }
    }
}