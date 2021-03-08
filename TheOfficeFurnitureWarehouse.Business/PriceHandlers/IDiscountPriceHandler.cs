namespace TheOfficeFurnitureWarehouse.Business.PriceHandlers
{
    internal interface IDiscountPriceHandler
    {
        decimal Handle(decimal productPrice, int quantity);
        IDiscountPriceHandler SetNextHandler(IDiscountPriceHandler handler);
    }
}
