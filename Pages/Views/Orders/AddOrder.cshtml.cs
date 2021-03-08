using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Business.Services.Customers;
using TheOfficeFurnitureWarehouse.Business.Services.Products;
using TheOfficeFurnitureWarehouse.Extensions;
using TheOfficeFurnitureWarehouse.ViewModels;

namespace TheOfficeFurnitureWarehouse.Pages.Views.Orders
{
    public class AddOrderModel : PageModel
    {
        private readonly ICustomerService customerService;
        private readonly IProductService productService;

        [BindProperty]
        public OrderCreateViewModel Order { get; set; }

        public IEnumerable<SelectListItem> Customers { get; set; }

        public IEnumerable<SelectListItem> Products { get; set; }

        public AddOrderModel(ICustomerService customerService, IProductService productService)
        {
            this.customerService = customerService;
            this.productService = productService;
        }

        public IActionResult OnGet()
        {
            Order = new OrderCreateViewModel();
            InitializeListsOfCustomersAndProducts();
            return Page();
        }

        public IActionResult OnPostCalculate()
        {
            InitializeListsOfCustomersAndProducts();
            return Page();
        }

        public void OnPostSave()
        {
        }

        private void InitializeListsOfCustomersAndProducts()
        {
            Customers = customerService.GetCustomersOrderedByName().GetAsSelectListItems();
            Products = productService.GetProductsOrderedByName().GetAsSelectListItems();
        }
    }
}
