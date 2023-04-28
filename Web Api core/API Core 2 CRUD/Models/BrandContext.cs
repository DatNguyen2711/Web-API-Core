using Microsoft.EntityFrameworkCore;

namespace API_Core_2_CRUD.Models
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext>options) : base (options){ 
            
        }

        public DbSet<Brand> Brands { get; set; }    
    }
}
