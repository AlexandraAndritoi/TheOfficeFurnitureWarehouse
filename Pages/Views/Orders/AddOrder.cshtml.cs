using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Business.Services.Customers;
using TheOfficeFurnitureWarehouse.Business.Services.Orders;
using TheOfficeFurnitureWarehouse.Business.Services.Prices;
using TheOfficeFurnitureWarehouse.Business.Services.Products;
using TheOfficeFurnitureWarehouse.Extensions;
using TheOfficeFurnitureWarehouse.ViewModels;

namespace TheOfficeFurnitureWarehouse.Pages.Views.Orders
{
    public class AddOrderModel : PageModel
    {
        private readonly ICustomerService customerService;
        private readonly IReadProductService productService;
        private readonly IPriceService priceService;
        private readonly ICreateOrderService createOrderService;

        [BindProperty]
        public OrderCreateViewModel Order { get; set; }

        public IEnumerable<SelectListItem> Customers { get; set; }

        public IEnumerable<SelectListItem> Products { get; set; }

        public AddOrderModel(ICustomerService customerService, IReadProductService productService, IPriceService priceService, ICreateOrderService createOrderService)
        {
            this.customerService = customerService;
            this.productService = productService;
            this.priceService = priceService;
            this.createOrderService = createOrderService;
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
            Order.Price = priceService.CalculatePrice(Order.Customer, Order.Product, Order.Quantity);
            return Page();
        }

        public IActionResult OnPostSave()
        {
            createOrderService.Create(Order.Customer, Order.Product, Order.Quantity, Order.Price);
            return RedirectToPage("./OrderList");
        }

        private void InitializeListsOfCustomersAndProducts()
        {
            Customers = customerService.GetCustomersOrderedByName().GetAsSelectListItems();
            Products = productService.GetProductsOrderedByName().GetAsSelectListItems();
        }
    }
}
