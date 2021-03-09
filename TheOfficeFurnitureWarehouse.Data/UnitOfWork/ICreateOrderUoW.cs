namespace TheOfficeFurnitureWarehouse.Data.UnitOfWork
{
    public interface ICreateOrderUoW
    {
        void DoWork(string customerName, string productName, int quantity, decimal price);
    }
}
