using TheOfficeFurnitureWarehouse.Core.Models;
using TheOfficeFurnitureWarehouse.Data.Repository;

namespace TheOfficeFurnitureWarehouse.Business.Services.Customers
{
    public class CreateCustomerService : ICreateCustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CreateCustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public void Create(Customer customer)
        {
            customerRepository.Create(customer);
            customerRepository.Commit();
        }
    }
}
