using TheOfficeFurnitureWarehouse.Core.Models;
using TheOfficeFurnitureWarehouse.Data.Repository.Products;

namespace TheOfficeFurnitureWarehouse.Business.Services.Products
{
    public class CreateProductService : ICreateProductService
    {
        private readonly IProductRepository productRepository;

        public CreateProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Create(Product product)
        {
            productRepository.Create(product);
            productRepository.Commit();
        }
    }
}
