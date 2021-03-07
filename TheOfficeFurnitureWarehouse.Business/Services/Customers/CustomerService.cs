using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Model;
using TheOfficeFurnitureWarehouse.Data.Repository;

namespace TheOfficeFurnitureWarehouse.Business.Services.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetCustomersOrderedByName()
        {
            return customerRepository.GetCustomersOrderedByName();
        }
    }
}
