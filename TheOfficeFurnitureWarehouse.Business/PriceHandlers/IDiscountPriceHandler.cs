using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Business.PriceHandlers
{
    internal interface IDiscountPriceHandler
    {
        // TODO: change to decimal standardProductPrice, int quantity
        decimal Handle(Product product, int quantity);
        IDiscountPriceHandler SetNextHandler(IDiscountPriceHandler handler);
    }
}
