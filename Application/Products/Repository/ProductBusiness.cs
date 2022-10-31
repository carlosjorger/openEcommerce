using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.TodoProduct.Repository
{
    public class ProductBusiness
    {
        private readonly IApplicationDbContext<Product> _context;
        public ProductBusiness(IApplicationDbContext<Product> context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProducts() {
            return _context.EntityDbSet;
        }
        public async Task<Product> EditProduct(Product product)
        {

            _context.EntityDbSet.Attach(product);
            _context.Entry(product).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            
            return product;
        }
        public async Task DeleteProduct(int id)
        {
            var product = await _context.EntityDbSet.FindAsync(id);
            _context.EntityDbSet.Remove(product!);
            await _context.SaveChangesAsync();
        }
        public async Task<Product> Create(Product product)
        {
            await _context.EntityDbSet.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
