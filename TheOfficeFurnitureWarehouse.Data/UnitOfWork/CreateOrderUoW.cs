using Microsoft.EntityFrameworkCore;
using System.Linq;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Data.UnitOfWork
{
    public class CreateOrderUoW : ICreateOrderUoW
    {
        private readonly TheOfficeFurnitureWarehouseDbContext dbContext;

        public CreateOrderUoW(TheOfficeFurnitureWarehouseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void DoWork(string customerName, string productName, int quantity, decimal price)
        {
            var product = GetProduct(productName);
            UpdateProduct(product, quantity);
            CreateOrder(product, customerName, quantity, price);
            SaveChanges();
        }

        private void UpdateProduct(Product product, int quantity)
        {
            product.Quantity -= quantity;
            var entity = dbContext.Products.Attach(product);
            entity.State = EntityState.Modified;
        }

        private void CreateOrder(Product product, string customerName, int quantity, decimal price)
        {
            var customer = GetCustomer(customerName);
            var order = new Order
            {
                Customer = customer,
                Product = product,
                Quantity = quantity,
                Price = price,
            };
            dbContext.Orders.Add(order);
        }

        private void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        private Product GetProduct(string productName)
        {
            return dbContext.Products.FirstOrDefault(_ => _.Name == productName);
        }

        private Customer GetCustomer(string customerName)
        {
            return dbContext.Customers.FirstOrDefault(_ => _.Name == customerName);
        }
    }
}
