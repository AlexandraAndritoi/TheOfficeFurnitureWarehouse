using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Data.Repository.Customers
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Customer GetCustomerByName(string name);
        IEnumerable<Customer> GetCustomersOrderedByName();
    }
}
