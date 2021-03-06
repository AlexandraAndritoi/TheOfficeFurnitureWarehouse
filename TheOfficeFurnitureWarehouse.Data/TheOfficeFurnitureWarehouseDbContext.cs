using Microsoft.EntityFrameworkCore;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Data
{
    public class TheOfficeFurnitureWarehouseDbContext : DbContext
    {
        public TheOfficeFurnitureWarehouseDbContext(DbContextOptions<TheOfficeFurnitureWarehouseDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
