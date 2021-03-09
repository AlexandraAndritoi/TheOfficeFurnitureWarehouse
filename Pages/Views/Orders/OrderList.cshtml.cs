using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheOfficeFurnitureWarehouse.Business.Services.Orders;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Pages.Views.Orders
{
    public class OrderListModel : PageModel
    {
        private readonly IReadOrderService readOrderService;

        public OrderListModel(IReadOrderService readOrderService)
        {
            this.readOrderService = readOrderService;
        }

        public IEnumerable<Order> Orders { get; set; }

        public IActionResult OnGet()
        {
            Orders = readOrderService.GetOrdersOrderedByPrice();
            return Page();
        }
    }
}
