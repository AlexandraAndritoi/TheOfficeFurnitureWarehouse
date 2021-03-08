using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TheOfficeFurnitureWarehouse.Business.Services.Products;
using TheOfficeFurnitureWarehouse.Core.Enum;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Pages.Views.Products
{
    public class EditProductModel : PageModel
    {
        private readonly IReadProductService productService;
        private readonly IUpdateProductService updateProductService;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Product Product { get; set; }

        public IEnumerable<SelectListItem> ProducTypes { get; set; }

        public EditProductModel(IReadProductService productService, IUpdateProductService updateProductService, IHtmlHelper htmlHelper)
        {
            this.productService = productService;
            this.updateProductService = updateProductService;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(Guid productId)
        {
            InitializeListOfProductTypes();
            Product = productService.GetProductById(productId);
            return Page();
        }

        public IActionResult OnPost(Guid productId)
        {
            if (!IsValid())
            {
                InitializeListOfProductTypes();
                return Page();
            }
            UpdateProduct(productId);
            return RedirectToPage("./ProductList");
        }

        private void InitializeListOfProductTypes()
        {
            ProducTypes = htmlHelper.GetEnumSelectList<ProductType>();
        }

        private bool IsValid()
        {
            return ModelState.IsValid;
        }

        private void UpdateProduct(Guid productId)
        {
            Product.Id = productId;
            updateProductService.Update(Product);
        }
    }
}
