using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Business.Services.Customers
{
    public interface IReadCustomerService
    {
        IEnumerable<Customer> GetCustomersOrderedByName();
    }
}
