using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Business.PriceHandlers
{
    internal abstract class AbstractDiscountPriceHandler : IDiscountPriceHandler
    {
        protected IDiscountPriceHandler nextHandler;

        public abstract decimal Handle(Product product, int quantity);

        public IDiscountPriceHandler SetNextHandler(IDiscountPriceHandler handler)
        {
            this.nextHandler = handler;
            return handler;
        }

        protected decimal CalculateProductStandardPrice(Product product, int quantity)
        {
            return product.StandardPrice * quantity;
        }

        // maybe enhance with more checks
        protected bool CanApplyMoreDiscount(decimal price)
        {
            return price > 0;
        }
    }
}
