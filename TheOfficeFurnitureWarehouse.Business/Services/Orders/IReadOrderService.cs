using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Business.Services.Orders
{
    public interface IReadOrderService
    {
        IEnumerable<Order> GetOrdersOrderedByPrice();
    }
}
