using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Models;
using TheOfficeFurnitureWarehouse.Data.Repositories.Orders;

namespace TheOfficeFurnitureWarehouse.Business.Services.Orders
{
    public class ReadOrderService : IReadOrderService
    {
        private readonly IOrderRepository orderRepository;

        public ReadOrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public IEnumerable<Order> GetOrdersOrderedByPrice()
        {
            return orderRepository.GetOrdersOrderedByPrice();
        }
    }
}
