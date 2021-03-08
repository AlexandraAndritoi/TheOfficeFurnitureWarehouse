using TheOfficeFurnitureWarehouse.Business.PriceStrategies;

namespace TheOfficeFurnitureWarehouse.Business.PriceStrategyCreators
{
    public interface IPriceStrategyCreator
    {
        IPriceStrategy GetStrategy();
    }
}
