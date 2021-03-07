using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Business.Services.Customers
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomersOrderedByName();
    }
}
