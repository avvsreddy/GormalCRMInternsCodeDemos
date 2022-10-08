using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductsCatalogConsoleApp.Entities;

namespace ProductsCatalogConsoleApp.DataAccess
{
    public class ProductsCatalogDbContext : DbContext
    {
        // config db server with ef
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CMRProductsDB2022v2;Integrated Security=True").LogTo(Console.WriteLine,LogLevel.Information);
        }

        // map entity class to a table
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Person> People { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
