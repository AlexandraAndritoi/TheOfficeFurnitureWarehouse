using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Pages.Views.Orders
{
    public class OrderListModel : PageModel
    {
        public IEnumerable<Order> Orders { get; set; }

        public void OnGet() => Orders = new List<Order>();
    }
}
