using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheOfficeFurnitureWarehouse.Business.Services.Customers;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Pages.Views.Customers
{
    public class CustomerListModel : PageModel
    {
        private readonly IReadCustomerService customerService;

        public IEnumerable<Customer> Customers { get; set; }

        public CustomerListModel(IReadCustomerService customerService)
        {
            this.customerService = customerService;
        }

        public void OnGet()
        {
            Customers = customerService.GetCustomersOrderedByName();
        }
    }
}
