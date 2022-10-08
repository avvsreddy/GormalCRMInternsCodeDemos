using Microsoft.EntityFrameworkCore;
using ProductsCatalogConsoleApp.DataAccess;
using ProductsCatalogConsoleApp.Entities;

namespace ProductsCatalogConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            //// get all customers
            var customers = db.Customers.ToList();
            var suppliers = db.Suppliers.ToList();
            

        }

        private static void AddCustSup()
        {
            // Add new Customer and Supplier
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();

            Customer cust = new Customer
            {
                Name = "Ravi",
                Discount = 250,
                Email = "ravi@abc.com",
                Mobile = "324234234"
            };

            Supplier sup = new Supplier { Name = "Rohith", Email = "rohith@abc.com", Mobile = "2342324", GST = "342323423", Rating = 9 };
            db.People.Add(cust);
            db.People.Add(sup);
            db.SaveChanges();
        }

        private static void Display2()
        {
            // display product name and catagory name
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();

            var products = from p in db.Products.Include("TheCatagory")
                           select p;

            foreach (var item in products)
            {
                Console.WriteLine(item.Name + "\t" + item.TheCatagory.Name);
            }
        }

        private static void AddNewProductWithExistingCatagory()
        {
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();

            Product p = new Product { Name = "IPhone 14 Pro", Price = 120000, Brand = "Apple" };
            Catagory existingCatagory = db.Catagories.Find(1);
            p.TheCatagory = existingCatagory;
            db.Products.Add(p);
            db.SaveChanges();
        }

        private static void ProductAndCatagorySave()
        {
            // add a new product with new catagory
            Product p = new Product { Name = "Galaxy S22", Price = 80000, Brand = "Samsung" };
            Catagory c = new Catagory { Name = "Mobiles", Description = "Smart Phones" };
            p.TheCatagory = c;

            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            db.Products.Add(p);
            //db.Catagories.Add(c);
            db.SaveChanges();
            Console.WriteLine("saved...");
        }

        private static void Edit()
        {
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
            Product p = new Product { Name = "IPhone 14 Pro Max", Price = 160000, Brand="Apple" };
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            var c = db.Catagories.Find(1);
            p.TheCatagory = c;
            db.Products.Add(p);
            db.SaveChanges();
            Console.WriteLine("Saved");
        }
    }
}