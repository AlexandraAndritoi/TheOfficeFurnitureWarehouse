namespace TheOfficeFurnitureWarehouse.Business.Services.Orders
{
    public interface ICreateOrderService
    {
        void Create(string customerName, string productName, int quantity, decimal price);
    }
}
