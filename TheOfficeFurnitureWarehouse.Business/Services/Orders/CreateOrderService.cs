using TheOfficeFurnitureWarehouse.Data.UnitOfWork;

namespace TheOfficeFurnitureWarehouse.Business.Services.Orders
{
    public class CreateOrderService : ICreateOrderService
    {
        private readonly ICreateOrderUoW createOrderUoW;

        public CreateOrderService(ICreateOrderUoW createOrderUoW)
        {
            this.createOrderUoW = createOrderUoW;
        }

        public void Create(string customerName, string productName, int quantity, decimal price)
        {
            createOrderUoW.DoWork(customerName, productName, quantity, price);
        }
    }
}
