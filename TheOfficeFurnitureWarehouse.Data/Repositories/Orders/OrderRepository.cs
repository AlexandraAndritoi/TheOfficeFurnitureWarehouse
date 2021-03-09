using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Data.Repositories.Orders
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(TheOfficeFurnitureWarehouseDbContext dbContext) : base(dbContext) { }

        public IEnumerable<Order> GetOrdersOrderedByPrice()
        {
            return dbContext.Orders.Include(_ => _.Product).Include(_ => _.Customer);
        }
    }
}
