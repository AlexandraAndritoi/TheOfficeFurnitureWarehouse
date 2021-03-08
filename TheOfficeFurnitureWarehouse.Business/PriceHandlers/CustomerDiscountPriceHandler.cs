namespace TheOfficeFurnitureWarehouse.Business.PriceHandlers
{
    internal class CustomerDiscountPriceHandler : AbstractDiscountPriceHandler
    {
        private readonly decimal customerDiscount;

        public CustomerDiscountPriceHandler(decimal customerDiscount)
        {
            this.customerDiscount = customerDiscount;
        }

        public override decimal Handle(decimal productPrice, int quantity)
        {
            if(nextHandler != null)
            {
                var salesPrice = nextHandler.Handle(productPrice, quantity);
                return CalculateDiscountFromSalesPrice(salesPrice);
            }
            else
            {
                return CalculateDiscountFromStandardPrice(productPrice, quantity);
            }
        }

        private decimal CalculateDiscountFromSalesPrice(decimal salesPrice)
        {
            var customerDiscountValue = GetCustomerDiscountOf(salesPrice);
            if (CanApplyMoreDiscount(salesPrice)) return salesPrice - customerDiscountValue;
            return salesPrice;
        }

        private decimal CalculateDiscountFromStandardPrice(decimal productPrice, int quantity)
        {
            var standardPrice = CalculateProductPrice(productPrice, quantity);
            var customerDiscoutValue = GetCustomerDiscountOf(standardPrice);
            return standardPrice - customerDiscoutValue;
        }

        private decimal GetCustomerDiscountOf(decimal price)
        {
            return (price * customerDiscount) / 100;
        }
    }
}
