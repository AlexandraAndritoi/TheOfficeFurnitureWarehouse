using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Data.Repositories.Products
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Product GetProductByName(string name);
        IEnumerable<Product> GetProductsOrderedByName();
    }
}
