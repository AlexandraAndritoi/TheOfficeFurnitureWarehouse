using TheOfficeFurnitureWarehouse.Core.Models;
using TheOfficeFurnitureWarehouse.Data.Repository;

namespace TheOfficeFurnitureWarehouse.Business.Services.Products
{
    public class UpdateProductService : IUpdateProductService
    {
        private readonly IProductRepository productRepository;

        public UpdateProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Update(Product product)
        {
            productRepository.Update(product);
            productRepository.Commit();
        }
    }
}
