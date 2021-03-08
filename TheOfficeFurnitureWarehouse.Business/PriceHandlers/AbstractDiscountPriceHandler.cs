namespace TheOfficeFurnitureWarehouse.Business.PriceHandlers
{
    internal abstract class AbstractDiscountPriceHandler : IDiscountPriceHandler
    {
        protected IDiscountPriceHandler nextHandler;

        public abstract decimal Handle(decimal productPrice, int quantity);

        public IDiscountPriceHandler SetNextHandler(IDiscountPriceHandler handler)
        {
            this.nextHandler = handler;
            return handler;
        }

        protected decimal CalculateProductPrice(decimal productPrice, int quantity)
        {
            return productPrice * quantity;
        }

        // maybe enhance with more checks
        protected bool CanApplyMoreDiscount(decimal price)
        {
            return price > 0;
        }
    }
}
