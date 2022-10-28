using Application.Common.Interfaces;
using Backend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ProductDb : DbContext, IApplicationDbContext<Product>
    {
        public ProductDb(DbContextOptions<ProductDb> options) : base(options)
        {

        }

        public DbSet<Product> EntityDbSet => Set<Product>();

       
    }
}
