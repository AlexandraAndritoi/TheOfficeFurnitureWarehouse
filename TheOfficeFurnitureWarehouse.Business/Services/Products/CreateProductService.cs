using TheOfficeFurnitureWarehouse.Core.Model;
using TheOfficeFurnitureWarehouse.Data.Repository;

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
