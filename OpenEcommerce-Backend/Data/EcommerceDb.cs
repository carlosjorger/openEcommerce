using Microsoft.EntityFrameworkCore;
using OpenEcommerce_Backend.Models;

namespace OpenEcommerce_Backend.Data
{
    public class EcommerceDb:DbContext
    {
        public EcommerceDb(DbContextOptions<EcommerceDb> options):base(options)
        {

        }

        public DbSet<Product> Products=> Set<Product>();
    }
}
