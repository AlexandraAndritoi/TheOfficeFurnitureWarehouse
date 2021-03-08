namespace TheOfficeFurnitureWarehouse.Business.PriceHandlers
{
    internal class ChristmasDiscountPriceHandler : AbstractDiscountPriceHandler
    {
        // In an enterprise solution this value would be stored in the database
        private const int xmasDiscount = 10;

        public override decimal Handle(decimal productPrice, int quantity)
        {
            if (nextHandler != null)
            {
                return nextHandler.Handle(productPrice, quantity);
            }
            else
            {
                return CalculateDicount(productPrice, quantity);
            }
        }

        private decimal CalculateDicount(decimal productPrice, int quantity)
        {
            var standardPrice = CalculateProductPrice(productPrice, quantity);
            var xmasDiscountValue = (standardPrice * xmasDiscount) / 100;
            return standardPrice - xmasDiscountValue;
        }
    }
}
