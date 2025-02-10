using Microsoft.EntityFrameworkCore;

namespace WebAPICRUDOperations.Models
{
    public class HeroDataDbContext : DbContext
    {
        public HeroDataDbContext(DbContextOptions<HeroDataDbContext> options): base(options)
        {
        }

        public DbSet<OurHero> OurHeros { get; set; } = null!;
    }
}
