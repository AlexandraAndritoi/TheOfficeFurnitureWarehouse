using System;
using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Model;
using TheOfficeFurnitureWarehouse.Data.Repository;

namespace TheOfficeFurnitureWarehouse.Business.Services.Products
{
    public class ReadProductService : IReadProductService
    {
        private readonly IProductRepository productRepository;

        public ReadProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Product GetProductById(Guid id)
        {
            return productRepository.GetById(id);
        }

        public IEnumerable<Product> GetProductsOrderedByName()
        {
            return productRepository.GetProductsOrderedByName();
        }
    }
}
