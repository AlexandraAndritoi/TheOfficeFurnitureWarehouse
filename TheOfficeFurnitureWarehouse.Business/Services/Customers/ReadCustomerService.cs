using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Models;
using TheOfficeFurnitureWarehouse.Data.Repository.Customers;

namespace TheOfficeFurnitureWarehouse.Business.Services.Customers
{
    public class ReadCustomerService : IReadCustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public ReadCustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetCustomersOrderedByName()
        {
            return customerRepository.GetCustomersOrderedByName();
        }
    }
}
