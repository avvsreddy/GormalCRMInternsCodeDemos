using System.ComponentModel.DataAnnotations;

namespace CoolProductsCatalogAPI.Model.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
        public string Catagory { get; set; }
        public string Brand { get; set; }
        public bool InStock { get; set; }
        public string Country { get; set; }
        public double Rating { get; set; }
    }
}
