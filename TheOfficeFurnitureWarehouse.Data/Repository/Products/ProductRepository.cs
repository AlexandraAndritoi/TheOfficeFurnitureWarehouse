using System.Collections.Generic;
using System.Linq;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Data.Repository.Products
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(TheOfficeFurnitureWarehouseDbContext dbContext) : base(dbContext) { }

        public Product GetProductByName(string name)
        {
            return GetAll().FirstOrDefault(_ => _.Name == name);
        }

        public IEnumerable<Product> GetProductsOrderedByName()
        {
            return GetAll().OrderBy(_ => _.Name);
        }
    }
}
