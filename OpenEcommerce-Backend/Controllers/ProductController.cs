using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using Backend.Domain.Models;
using Application.TodoProduct.Repository;
using MediatR;
using Application.Products.Query;

namespace OpenEcommerce_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ProductBusiness _productDb;
        private readonly IMediator _mediator;


        public ProductController(ILogger<ProductController> logger, ProductBusiness productDb, IMediator mediator)
        {
            _logger = logger;
            _productDb = productDb;
            _mediator=mediator;
        }
        [HttpPost]
        public async Task<Product> Create(Product product) {
            await _productDb.Create(product);
            return product;
        }
        [HttpPut]
        public async Task<ActionResult<Product>> Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                await _productDb.EditProduct(product);
            }
            return product;
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _mediator.Send(new GetProducts());
           
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id) {

            await _productDb.DeleteProduct(id);
            return Ok();
        }
    }
}
