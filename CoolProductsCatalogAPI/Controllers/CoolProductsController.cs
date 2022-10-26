using CoolProductsCatalogAPI.Model.Data;
using CoolProductsCatalogAPI.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoolProductsCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoolProductsController : ControllerBase
    {
        IProductsRepository repo = null; // new ProductsRepository()
        // action methods
        public CoolProductsController(IProductsRepository repo)
        {
            this.repo = repo;
        }

        // HTTP Methods - GET POST PUT DELETE

        // [XML] [GET] http://www.abc.com/api/CoolProducts/
        [HttpGet]
        public List<Product> GetProducts()
        {
            return repo.GetProducts();
        }
        // [XML] [GET] http://www.abc.com/api/CoolProducts/1
        [Route("{id}")]
        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            var product = repo.GetProduct(id);
            if (product == null)
            {
                // return 404
                return NotFound();
            }
            else
            {
                // return data + 200
                return Ok(product);
            }
        }

        // get products by brand
        // GET....api/coolproducts/brand/apple
        [Route("brand/{brand}")]
        [HttpGet]
        public IActionResult GetProductsByBrand(string brand)
        {
            var products = repo.GetProductsByBrand(brand);
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }

        [Route("catagory/{catagory}")]
        [HttpGet]
        public IActionResult GetProductsByCatagory(string catagory)
        {
            var products = repo.GetProductsByCatagory(catagory);
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }

        [Route("country/{country}")]
        [HttpGet]
        public IActionResult GetProductsByCountry(string country)
        {
            var products = repo.GetProductsByCountry(country);
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }
        // ...api/coolproducts/min/10000/max/50000
        [Route("min/{min}/max/{max}")]
        [HttpGet]
        public IActionResult GetProductsByPriceRange(int min, int max)
        {
            var products = repo.GetProductsByPriceRange(min, max);
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }
        // ...api/coolproducts/instock
        [Route("instock")]
        [HttpGet]
        public IActionResult GetProductsInStock()
        {
            var products = repo.GetProductsInStock();
            if (products.Count == 0)
                return NotFound();
            return Ok(products);
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var product = repo.GetProduct(id);
            if (product == null)
            {
                // return 404
                return NotFound();
            }
            else
            {
                // return 200
                repo.Delete(id);
                return Ok(product);
            }
        }

        [HttpPost]
        public IActionResult CreateProduct(Product p)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid product data");
            // return 201+location+data
            repo.Create(p);
            return this.Created($"api/coolproducts/{p.ProductID}", p);
        }

        [HttpPut]
        public IActionResult Edit(Product p)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid product data");

            repo.Edit(p);
            return Ok();
        }



    }
}
