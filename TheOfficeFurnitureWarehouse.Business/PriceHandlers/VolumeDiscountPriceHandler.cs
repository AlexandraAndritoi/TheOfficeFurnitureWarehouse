using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Business.PriceHandlers
{
    internal class VolumeDiscountPriceHandler : AbstractDiscountPriceHandler
    {
        // In an enterprise solution this value would be stored in the database
        private const int volumeDicount = 10;

        public override decimal Handle(Product product, int quantity)
        {
            if (nextHandler != null)
            {
                var salesPrice = nextHandler.Handle(product, quantity);
                return CalculateDiscountFromSalesPrice(salesPrice);
            }
            else
            {
                return CalculteDiscountFromStandardPrice(product, quantity);
            }
        }

        private decimal CalculateDiscountFromSalesPrice(decimal salesPrice)
        {
            var volumeDiscountValue = GetVolumeDiscountOf(salesPrice);
            if (CanApplyMoreDiscount(salesPrice)) return salesPrice - volumeDiscountValue;
            return salesPrice;
        }

        private decimal CalculteDiscountFromStandardPrice(Product product, int quantity)
        {
            var standardPrice = CalculateProductStandardPrice(product, quantity);
            var volumeDiscountValue = GetVolumeDiscountOf(standardPrice);
            return standardPrice - volumeDiscountValue;
        }

        private decimal GetVolumeDiscountOf(decimal price)
        {
            return (price * volumeDicount) / 100;
        }
    }
}
