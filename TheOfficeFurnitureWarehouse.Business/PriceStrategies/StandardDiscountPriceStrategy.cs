using TheOfficeFurnitureWarehouse.Business.PriceHandlers;

namespace TheOfficeFurnitureWarehouse.Business.PriceStrategies
{
    internal class StandardDiscountPriceStrategy : IPriceStrategy
    {
        public decimal CalculatePrice(decimal customerDiscount, decimal productPrice, int quantity)
        {
            var customerDiscountPriceHandler = new CustomerDiscountPriceHandler(customerDiscount);
            var volumeDiscoutPriceHandler = new VolumeDiscountPriceHandler();

            return customerDiscountPriceHandler
                .SetNextHandler(volumeDiscoutPriceHandler)
                .Handle(productPrice, quantity);
        }
    }
}
