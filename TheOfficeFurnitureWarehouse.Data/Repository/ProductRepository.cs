using System.Collections.Generic;
using System.Linq;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Data.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(TheOfficeFurnitureWarehouseDbContext dbContext) : base(dbContext) { }

        public IEnumerable<Product> GetAllProductsOrderedByName()
        {
            return GetAll().OrderBy(_ => _.Name);
        }
    }
}
