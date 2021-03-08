using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheOfficeFurnitureWarehouse.Business.Services.Customers;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Pages.Views.Customers
{
    public class AddCustomerModel : PageModel
    {
        private readonly ICreateCustomerService createCustomerService;

        [BindProperty]
        public Customer Customer { get; set; }

        public AddCustomerModel(ICreateCustomerService createCustomerService)
        {
            this.createCustomerService = createCustomerService;
        }

        public IActionResult OnGet()
        {
            Customer = new Customer();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            createCustomerService.Create(Customer);
            return RedirectToPage("./CustomerList");
        }
    }
}
