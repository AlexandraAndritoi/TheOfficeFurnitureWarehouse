using System;
using TheOfficeFurnitureWarehouse.Business.PriceStrategies;

namespace TheOfficeFurnitureWarehouse.Business.PriceStrategyCreators
{
    public class PriceStrategyCreator : IPriceStrategyCreator
    {
        public IPriceStrategy GetStrategy()
        {
            if (DateTime.Now.Month == 12) return new ChristmasDiscountPriceStrategy();
            return new StandardDiscountPriceStrategy();
        }
    }
}
