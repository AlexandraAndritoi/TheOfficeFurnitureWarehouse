using TheOfficeFurnitureWarehouse.Business.PriceHandlers;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Business.PriceStrategies
{
    internal class StandardDiscountPriceStrategy : IPriceStrategy
    {
        public decimal CalculatePrice(Customer customer, Product product, int quantity)
        {
            var customerDiscountPriceHandler = new CustomerDiscountPriceHandler(customer);
            var volumeDiscoutPriceHandler = new VolumeDiscountPriceHandler();

            return customerDiscountPriceHandler
                .SetNextHandler(volumeDiscoutPriceHandler)
                .Handle(product, quantity);
        }
    }
}
