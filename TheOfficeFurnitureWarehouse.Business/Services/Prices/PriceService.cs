using TheOfficeFurnitureWarehouse.Business.PriceStrategyCreators;
using TheOfficeFurnitureWarehouse.Data.Repository;
using TheOfficeFurnitureWarehouse.Data.Repository.Customers;

namespace TheOfficeFurnitureWarehouse.Business.Services.Prices
{
    public class PriceService : IPriceService
    {
        private readonly IPriceStrategyCreator priceStrategyCreator;
        private readonly ICustomerRepository customerRepository;
        private readonly IProductRepository productReporitory;

        public PriceService(IPriceStrategyCreator priceStrategyCreator, ICustomerRepository customerRepository, IProductRepository productReporitory)
        {
            this.priceStrategyCreator = priceStrategyCreator;
            this.customerRepository = customerRepository;
            this.productReporitory = productReporitory;
        }

        public decimal CalculatePrice(string customerName, string productName, int quantity)
        {
            var customer = customerRepository.GetCustomerByName(customerName);
            var product = productReporitory.GetProductByName(productName);

            var priceStrategy = priceStrategyCreator.GetStrategy();

            return priceStrategy.CalculatePrice(customer.Discount, product.Price, quantity);
        }
    }
}
