using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Data.Repository.Orders
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(TheOfficeFurnitureWarehouseDbContext dbContext) : base(dbContext) { }
    }
}
