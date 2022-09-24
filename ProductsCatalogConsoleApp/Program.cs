using ProductsCatalogConsoleApp.DataAccess;
using ProductsCatalogConsoleApp.Entities;

namespace ProductsCatalogConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // save product info into db

            // using EF code first approach
            // create a product class

            // using EF db first approach
            // create a prodcuts table

            //Save();

            // get all products

            //Find();

            //Delete();

            // Edit
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            var productToEdit = db.Products.Find(1);
            productToEdit.Price -= 10000;
            db.SaveChanges();
            Console.WriteLine("edited");

        }

        private static void Delete()
        {
            // Delete
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            var productToDel = db.Products.Find(4);
            db.Products.Remove(productToDel);
            db.SaveChanges();
            Console.WriteLine("deleted");
        }

        private static void Find()
        {
            // find product id
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            var product = (from p in db.Products
                           where p.ProductID == 1
                           select p).FirstOrDefault();

            var product2 = db.Products.Find(1); // search by pk
        }

        private static void Select()
        {
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();

            var allProducts = from p in db.Products
                              where p.Price >= 150000
                              select p;

            foreach (var item in allProducts)
            {
                Console.WriteLine(item.Name + "\t" + item.Price);
            }
        }

        private static void Save()
        {
            Product p = new Product { Name = "IPhone 14 Pro Max", Price = 160000 };
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            db.Products.Add(p);
            db.SaveChanges();
            Console.WriteLine("Saved");
        }
    }
}