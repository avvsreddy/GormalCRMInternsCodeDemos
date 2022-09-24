using Microsoft.EntityFrameworkCore;
using ProductsCatalogConsoleApp.Entities;

namespace ProductsCatalogConsoleApp.DataAccess
{
    public class ProductsCatalogDbContext : DbContext
    {
        // config db server with ef
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CMRProductsDB2022;Integrated Security=True");
        }

        // map entity class to a table
        public DbSet<Product> Products { get; set; }
    }
}
