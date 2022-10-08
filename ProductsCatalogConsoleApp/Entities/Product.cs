using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsCatalogConsoleApp.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public Catagory TheCatagory { get; set; }

        public List<Supplier> Suppliers { get; set; } = new List<Supplier>();
    }

    public class Catagory
    {
        //[Key]
        public int CatagoryID { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }


    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
    [Table("Suppliers")]
    public class Supplier : Person
    {

        public string GST { get; set; }
        public int Rating { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
    [Table("Customers")]
    public class Customer : Person
    {
        public int Discount { get; set; }
    }
}
