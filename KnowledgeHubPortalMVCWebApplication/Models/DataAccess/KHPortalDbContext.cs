using KnowledgeHubPortalMVCWebApplication.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeHubPortalMVCWebApplication.Models.DataAccess
{
    public class KHPortalDbContext : DbContext
    {

        // configure the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=KHPortalDB;Integrated Security=True");
        }

        // map entity class to a table
        public DbSet<Catagory> Catagories { get; set; }

        // configure the table

    }
}
