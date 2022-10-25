using Microsoft.EntityFrameworkCore;
using TropiEcommerce.Models;

namespace TropiEcommerce.Data
{
    public class EcommerceDb:DbContext
    {
        public EcommerceDb(DbContextOptions<EcommerceDb> options):base(options)
        {

        }

        public DbSet<Product> Products=> Set<Product>();
    }
}
