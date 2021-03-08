using Microsoft.EntityFrameworkCore;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Data
{
    public class TheOfficeFurnitureWarehouseDbContext : DbContext
    {
        public TheOfficeFurnitureWarehouseDbContext(DbContextOptions<TheOfficeFurnitureWarehouseDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
