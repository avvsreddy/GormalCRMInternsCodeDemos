using CoolProductsCatalogAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoolProductsCatalogAPI.Model.Data
{
    public class CoolProductsCatalogDbContext : DbContext
    {

        // configure the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CoolProductsCRM2022DB;Integrated Security=True");
        }

        // map entity class to a table
        public DbSet<Product> Products { get; set; }

    }
}
