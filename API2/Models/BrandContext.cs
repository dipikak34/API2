using Microsoft.EntityFrameworkCore;

namespace API2.Models
{
    public class BrandContext: DbContext
    {
       public BrandContext(DbContextOptions<BrandContext> options):base (options)
        { 

        }
        public DbSet<Brand> Brands { get;}
    }
}
    