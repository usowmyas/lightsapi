using Microsoft.EntityFrameworkCore;

namespace LightsApi.Models
{
    public class LightsContext : DbContext
    {
        public LightsContext(DbContextOptions<LightsContext> options) 
            : base(options)
        {

        }
        public DbSet<LightsItem> LightsItems {get ; set;}
    }
}