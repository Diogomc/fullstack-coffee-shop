using APICoffeeShop.Context;
using APICoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICoffeeShop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var products = _context.Products.ToList();
            if(products is null)
            {
                return NotFound("Product not found");
            }
            return products;
        }

        [HttpGet("{id:int}", Name="TakeProduct")]
        public ActionResult<Product> Get(int id)
        {
            var products = _context.Products.FirstOrDefault(p => p.ProductId == id);
            if(products is null)
            {
                return NotFound("Product is no found");
            }
            return products;
        }

        [HttpPost]
        public ActionResult Post (Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return new CreatedAtRouteResult("TakeProduct",
                new { id = product.ProductId }, product);
        }
    }
}
