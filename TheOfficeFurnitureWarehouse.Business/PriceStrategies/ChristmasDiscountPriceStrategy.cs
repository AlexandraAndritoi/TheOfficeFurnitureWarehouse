using TheOfficeFurnitureWarehouse.Business.PriceHandlers;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Business.PriceStrategies
{
    internal class ChristmasDiscountPriceStrategy : IPriceStrategy
    {
        public decimal CalculatePrice(Customer customer, Product product, int quantity)
        {
            var customerDiscountPriceHandler = new CustomerDiscountPriceHandler(customer);
            var volumeDiscoutPriceHandler = new VolumeDiscountPriceHandler();
            var christmasDiscountPriceHandler = new ChristmasDiscountPriceHandler();

            return customerDiscountPriceHandler
                .SetNextHandler(volumeDiscoutPriceHandler)
                .SetNextHandler(christmasDiscountPriceHandler)
                .Handle(product, quantity);
        }
    }
}
