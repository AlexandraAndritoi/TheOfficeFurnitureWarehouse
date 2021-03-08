using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TheOfficeFurnitureWarehouse.Business.Services.Products;
using TheOfficeFurnitureWarehouse.Core.Enums;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Pages.Views.Products
{
    public class AddProductModel : PageModel
    {
        private readonly ICreateProductService createProductService;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Product Product { get; set; }

        public IEnumerable<SelectListItem> ProducTypes { get; set; }

        public AddProductModel(ICreateProductService createProductService, IHtmlHelper htmlHelper)
        {
            this.createProductService = createProductService;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnGet()
        {
            InitializeListOfProductTypes();
            Product = new Product();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                InitializeListOfProductTypes();
                return Page();
            }
            createProductService.Create(Product);
            return RedirectToPage("./ProductList");
        }

        private void InitializeListOfProductTypes()
        {
            ProducTypes = htmlHelper.GetEnumSelectList<ProductType>();
        }
    }
}
