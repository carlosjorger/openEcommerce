using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using TropiEcommerce.Data;
using TropiEcommerce.Models;

namespace TropiEcommerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly EcommerceDb _ecommerceDb;


        public ProductController(ILogger<ProductController> logger, EcommerceDb ecommerceDb)
        {
            _logger = logger;
            _ecommerceDb = ecommerceDb;
        }
        [HttpPost]
        public async Task<Product> Create(Product product) {
            await _ecommerceDb.Products.AddAsync(product);
            await _ecommerceDb.SaveChangesAsync();
            return product;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _ecommerceDb.Products;
           
        }
    }
}
