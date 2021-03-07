using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public AddOrderModel(ICustomerService customerService, IProductService productService)
        {
            this.customerService = customerService;
            this.productService = productService;
        }

        public IActionResult OnGet()
        {
            Order = new OrderCreateViewModel
            {
                Customers = customerService.GetCustomersOrderedByName().GetAsSelectListItems(),
                Products = productService.GetProductsOrderedByName().GetAsSelectListItems(),
            };
            return Page();
        }

        public void OnPostCalculate()
        {
        }

        public void OnPostSave()
        {
        }
    }
}
