using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Business.PriceHandlers
{
    internal class ChristmasDiscountPriceHandler : AbstractDiscountPriceHandler
    {
        // In an enterprise solution this value would be stored in the database
        private const int xmasDiscount = 10;

        public override decimal Handle(Product product, int quantity)
        {
            if (nextHandler != null)
            {
                return nextHandler.Handle(product, quantity);
            }
            else
            {
                return CalculateDicount(product, quantity);
            }
        }

        private decimal CalculateDicount(Product product, int quantity)
        {
            var standardPrice = CalculateProductStandardPrice(product, quantity);
            var xmasDiscountValue = (standardPrice * xmasDiscount) / 100;
            return standardPrice - xmasDiscountValue;
        }
    }
}
