using System;
using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Model;
using TheOfficeFurnitureWarehouse.Data.Repository;

namespace TheOfficeFurnitureWarehouse.Business.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
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

        public void Update(Product product)
        {
            productRepository.Update(product);
            productRepository.Commit();
        }
    }
}
