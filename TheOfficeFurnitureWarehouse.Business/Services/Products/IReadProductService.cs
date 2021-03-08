using System;
using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Business.Services.Products
{
    public interface IReadProductService
    {
        Product GetProductById(Guid id);
        IEnumerable<Product> GetProductsOrderedByName();
    }
}
