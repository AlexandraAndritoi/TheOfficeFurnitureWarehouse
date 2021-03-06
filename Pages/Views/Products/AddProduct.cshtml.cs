using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TheOfficeFurnitureWarehouse.Core.Enum;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Pages.Views.Products
{
    public class AddProductModel : PageModel
    {
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Product Product { get; set; }

        public IEnumerable<SelectListItem> ProducTypes { get; set; }

        public AddProductModel(IHtmlHelper htmlHelper)
        {
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
            return RedirectToPage("./ProductList");
        }

        private void InitializeListOfProductTypes()
        {
            ProducTypes = htmlHelper.GetEnumSelectList<ProductType>();
        }
    }
}
