using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Business.PriceHandlers
{
    internal class CustomerDiscountPriceHandler : AbstractDiscountPriceHandler
    {
        private readonly Customer customer;

        public CustomerDiscountPriceHandler(Customer customer)
        {
            this.customer = customer;
        }

        public override decimal Handle(Product product, int quantity)
        {
            if(nextHandler != null)
            {
                var salesPrice = nextHandler.Handle(product, quantity);
                return CalculateDiscountFromSalesPrice(salesPrice);
            }
            else
            {
                return CalculateDiscountFromStandardPrice(product, quantity);
            }
        }

        private decimal CalculateDiscountFromSalesPrice(decimal salesPrice)
        {
            var customerDiscountValue = GetCustomerDiscountOf(salesPrice);
            if (CanApplyMoreDiscount(salesPrice)) return salesPrice - customerDiscountValue;
            return salesPrice;
        }

        private decimal CalculateDiscountFromStandardPrice(Product product, int quantity)
        {
            var standardPrice = CalculateProductStandardPrice(product, quantity);
            var customerDiscoutValue = GetCustomerDiscountOf(standardPrice);
            return standardPrice - customerDiscoutValue;
        }

        private decimal GetCustomerDiscountOf(decimal price)
        {
            return (price * customer.Discount) / 100;
        }
    }
}
