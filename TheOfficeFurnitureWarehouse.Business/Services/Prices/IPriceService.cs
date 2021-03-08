namespace TheOfficeFurnitureWarehouse.Business.Services.Prices
{
    public interface IPriceService
    {
        decimal CalculatePrice(string customerName, string productName, int quantity);
    }
}
