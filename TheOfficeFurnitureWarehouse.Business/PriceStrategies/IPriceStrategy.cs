using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Business.PriceStrategies
{
    public interface IPriceStrategy
    {
        decimal CalculatePrice(Customer customer, Product product, int quantity);
    }
}
