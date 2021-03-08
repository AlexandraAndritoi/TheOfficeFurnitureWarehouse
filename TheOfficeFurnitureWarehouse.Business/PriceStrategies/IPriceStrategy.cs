namespace TheOfficeFurnitureWarehouse.Business.PriceStrategies
{
    public interface IPriceStrategy
    {
        decimal CalculatePrice(decimal customerDiscount, decimal productPrice, int quantity);
    }
}
