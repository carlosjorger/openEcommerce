using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using OpenEcommerce_Backend.Data;
using OpenEcommerce_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace OpenEcommerce_Backend.Controllers
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
        [HttpPut]
        public async Task<ActionResult<Product>> Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _ecommerceDb.Products.Attach(product);
                _ecommerceDb.Entry(product).State = EntityState.Modified;
                await _ecommerceDb.SaveChangesAsync();
            }
            return product;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _ecommerceDb.Products;
           
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id) { 
        
            var product=await _ecommerceDb.Products.FindAsync(id);
            if (product == null) { 
                return NotFound($"Not Found Product with id = {id}");
            }
            _ecommerceDb.Products.Remove(product!);
            await _ecommerceDb.SaveChangesAsync();
            return Ok();
        }
    }
}
