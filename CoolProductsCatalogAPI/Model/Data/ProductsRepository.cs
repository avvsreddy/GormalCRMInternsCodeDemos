using CoolProductsCatalogAPI.Model.Entities;

namespace CoolProductsCatalogAPI.Model.Data
{
    public class ProductsRepository : IProductsRepository
    {
        private CoolProductsCatalogDbContext db = new CoolProductsCatalogDbContext();

        public void Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var productToDel = db.Products.Find(id);
            db.Products.Remove(productToDel);
            db.SaveChanges();
        }

        public void Edit(Product product)
        {
            db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return db.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public List<Product> GetProductsByBrand(string brand)
        {
            var products = from p in db.Products
                           where p.Brand == brand
                           select p;
            return products.ToList();
        }

        public List<Product> GetProductsByCatagory(string catagory)
        {
            var products = from p in db.Products
                           where p.Catagory == catagory
                           select p;
            return products.ToList();
        }

        public List<Product> GetProductsByCountry(string country)
        {
            var products = from p in db.Products
                           where p.Country == country
                           select p;
            return products.ToList();
        }

        public List<Product> GetProductsByPriceRange(int min, int max)
        {
            var products = from p in db.Products
                           where p.Price >= min && p.Price <= max
                           select p;
            return products.ToList();
        }

        public List<Product> GetProductsByRating(double rating)
        {
            var products = from p in db.Products
                           where p.Rating >= rating
                           select p;
            return products.ToList();
        }

        public List<Product> GetProductsInStock()
        {
            var products = from p in db.Products
                           where p.InStock == true
                           select p;
            return products.ToList();
        }
    }
}
