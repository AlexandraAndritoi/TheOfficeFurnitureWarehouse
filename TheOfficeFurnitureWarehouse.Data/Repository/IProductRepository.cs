using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Data.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IEnumerable<Product> GetProductsOrderedByName();
    }
}
