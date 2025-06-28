using GamePlatformService.Models;
using Microsoft.EntityFrameworkCore;

namespace GamePlatformService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        public DbSet<Platform> Platforms{ get; set; }
    }
}
