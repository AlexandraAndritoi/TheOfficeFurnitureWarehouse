using System.Collections.Generic;
using System.Linq;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Data.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(TheOfficeFurnitureWarehouseDbContext dbContext) : base(dbContext) { }

        public Customer GetCustomerByName(string name)
        {
            return GetAll().FirstOrDefault(_ => _.Name == name);
        }

        public IEnumerable<Customer> GetCustomersOrderedByName()
        {
            return GetAll().OrderBy(_ => _.Name);
        }
    }
}
