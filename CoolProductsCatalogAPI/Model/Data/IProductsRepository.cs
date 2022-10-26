using CoolProductsCatalogAPI.Model.Entities;

namespace CoolProductsCatalogAPI.Model.Data
{
    public interface IProductsRepository
    {
        // read-only operations
        List<Product> GetProducts();
        Product GetProduct(int id);
        List<Product> GetProductsByBrand(string brand);
        List<Product> GetProductsByCatagory(string catagory);
        List<Product> GetProductsByCountry(string country);
        List<Product> GetProductsInStock();
        List<Product> GetProductsByRating(double rating);
        List<Product> GetProductsByPriceRange(int min, int max);

        void Delete(int id);
        void Edit(Product product);

        void Create(Product product);
    }
}
