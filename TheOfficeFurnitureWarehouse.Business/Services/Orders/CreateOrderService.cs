using TheOfficeFurnitureWarehouse.Core.Models;
using TheOfficeFurnitureWarehouse.Data.Repository;
using TheOfficeFurnitureWarehouse.Data.Repository.Customers;
using TheOfficeFurnitureWarehouse.Data.Repository.Orders;

namespace TheOfficeFurnitureWarehouse.Business.Services.Orders
{
    public class CreateOrderService : ICreateOrderService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IProductRepository productRepository;
        private readonly IOrderRepository orderRepository;

        public CreateOrderService(ICustomerRepository customerRepository, IProductRepository productRepository, IOrderRepository orderRepository)
        {
            this.customerRepository = customerRepository;
            this.productRepository = productRepository;
            this.orderRepository = orderRepository;
        }

        public void Create(string customerName, string productName, int quantity, decimal price)
        {
            var customer = customerRepository.GetCustomerByName(customerName);
            var product = productRepository.GetProductByName(productName);

            var order = new Order
            {
                Customer = customer,
                Product = product,
                Quantity = quantity,
                Price = price,
            };

            orderRepository.Create(order);
            orderRepository.Commit();
        }
    }
}
