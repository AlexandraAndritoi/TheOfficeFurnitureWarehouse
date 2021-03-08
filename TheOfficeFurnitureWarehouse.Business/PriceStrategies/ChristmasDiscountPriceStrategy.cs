using TheOfficeFurnitureWarehouse.Business.PriceHandlers;

namespace TheOfficeFurnitureWarehouse.Business.PriceStrategies
{
    internal class ChristmasDiscountPriceStrategy : IPriceStrategy
    {
        public decimal CalculatePrice(decimal customerDiscount, decimal productPrice, int quantity)
        {
            var customerDiscountPriceHandler = new CustomerDiscountPriceHandler(customerDiscount);
            var volumeDiscoutPriceHandler = new VolumeDiscountPriceHandler();
            var christmasDiscountPriceHandler = new ChristmasDiscountPriceHandler();

            customerDiscountPriceHandler.SetNextHandler(volumeDiscoutPriceHandler).SetNextHandler(christmasDiscountPriceHandler);
            return customerDiscountPriceHandler.Handle(productPrice, quantity);
        }
    }
}
